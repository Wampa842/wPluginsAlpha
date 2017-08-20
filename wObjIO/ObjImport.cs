using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

using PEPlugin;
using PEPlugin.Pmx;
using PEPlugin.SDX;

namespace wObjIO
{
    public class PolygonException : Exception
    {
        public int VertexCount { get; set; } = 0;
        public PolygonException() { }
        public PolygonException(int vertexCount)
        {
            VertexCount = vertexCount;
        }
        public PolygonException(string message) : base(message) { }
        public PolygonException(string message, Exception inner) : base(message, inner) { }
    }
    public class ObjImportSettings
    {
        public enum BitmapAction { None, Copy, ToPng, ToJpg, ToTga, ToDds };
        public enum MaterialName { Library, Bitmap, ObjNameNumbered, CustomNumbered };
        public float ScaleX { get; set; } = 1.0f;
        public float ScaleY { get; set; } = 1.0f;
        public float ScaleZ { get; set; } = 1.0f;
        public bool SwapAxes { get; set; } = false;
        public bool ReverseFaces { get; set; } = false;
        public bool MirrorU { get; set; } = false;
        public bool MirrorV { get; set; } = false;
        public bool CreateBone { get; set; } = false;
        BitmapAction Bitmap { get; set; }
        MaterialName Material { get; set; }
    }

    public class wObjImportv2 : IPEImportPlugin
    {
        public string Ext
        {
            get
            {
                return ".obj";
            }
        }
        public string Caption {
            get
            {
                string version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
                return "wPlugins OBJ Importer (v" + version + ")";
            }
        }
        //public string Ext { get { return ".obj"; } }

        private IPXPmxBuilder builder;
        private IPXPmx pmx = null;
        private ObjImportSettingsForm settingsForm;

        public IPXPmx Import(string objPath, IPERunArgs args)
        {
            try
            {
                //Create builder and new PMX scene
                builder = PEStaticBuilder.Pmx;
                pmx = builder.Pmx();
                pmx.Clear();

                //Open the settings form
                settingsForm = new ObjImportSettingsForm();
                if (settingsForm.ShowDialog() == DialogResult.OK)
                {
                    //Create the import object and add it to the scene
                    try
                    {
                        ObjFileImport import = new ObjFileImport(objPath, builder);
                        import.RegisterInPmx(pmx, builder, settingsForm.Settings);
                        pmx.ModelInfo.ModelName = pmx.ModelInfo.ModelNameE = import.ObjName;
                    }
                    catch(PolygonException ex)
                    {
                        MessageBox.Show("The mesh you're trying to import contains a polygon with " + ex.VertexCount + " vertices. This plugin only supports triangles and quads.", "Unsupported polygon");
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + ex.StackTrace, "Exception");
            }
            return pmx;
        }
    }

    public class ObjFileImport
    {
        public string ObjName;  //Name of the obj file
        public List<IPXVertex> VertexList;  //List of compiled vertices
        public Dictionary<string, IPXMaterial> MaterialList;    //List of compiled materials
        public Dictionary<string, IPXMaterial> AvailableMaterials;  //List of unique materials
        private List<V3> _posList;  //Temporary list of position vectors
        private List<V2> _uvList;   //Temporary list of UV coordinates
        private List<V3> _normalList;   //Temporary list of normal vectors
        private Dictionary<string, int> _vertexList;

        private void getVertexElements(string faceVertex, out int v, out int vt, out int vn)
        {
            //This method returns the indices of an f entry's v, vt and vn entries
            v = -1;
            vt = -1;
            vn = -1;
            //Split faceVertex at / characters
            string[] vStr = faceVertex.Trim().Split('/');
            if (vStr.Length >= 1)
            {
                int.TryParse(vStr[0], out v);
                --v;    //Decrement ensures correct indexing
                if (vStr.Length >= 2)
                {
                    int.TryParse(vStr[1], out vt);
                    --vt;
                    if (vStr.Length >= 3)
                    {
                        int.TryParse(vStr[2], out vn);
                        --vn;
                    }
                }
            }
        }

        private int getVertexNumber(int v, int vt, int vn, IPXPmxBuilder bld)
        {
            //This method creates a dictionary where the key is generated from the vertex data, and the value is a pointer to the vertex itself. This ensures that no vertex will be added twice, and that faces will be properly linked.
            //Returns the index of the appropriate vertex, either new or existing.
            string vertexKey = v.ToString() + '/' + vt.ToString() + '/' + vn.ToString();    //Construct a unique identifier that'll be used as key in vertexList.
            if (_vertexList.ContainsKey(vertexKey))  //If the vertex exists, return its index
            {
                return _vertexList[vertexKey];
            }
            else       //Otherwise create a new vertex, set its values, then add its key and index to the dictionary
            {
                IPXVertex newVertex = bld.Vertex();
                if (v >= 0 && v < _posList.Count) newVertex.Position = _posList[v];
                if (vt >= 0 && vt < _uvList.Count) newVertex.UV = _uvList[vt];
                if (vn >= 0 && vn < _normalList.Count) newVertex.Normal = _normalList[vn];
                VertexList.Add(newVertex);
                int newIndex = VertexList.Count - 1;
                _vertexList.Add(vertexKey, newIndex);
                return newIndex;
            }
        }

        public Dictionary<string, IPXMaterial> ReadMaterialLibrary(string path, IPXPmxBuilder bld)
        {
            if (!File.Exists(path))
            {
                DialogResult warningRes = MessageBox.Show("Material library file not found at\n" + path + "\n\nWould you like to locate it manually?", "File not found", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                if (warningRes == DialogResult.Yes)
                {
                    OpenFileDialog browseMtl = new OpenFileDialog();
                    browseMtl.Multiselect = false;
                    browseMtl.Filter = "Wavefront Material Library|*.mtl|All files|*.*";
                    browseMtl.InitialDirectory = Path.GetDirectoryName(path);
                    if (browseMtl.ShowDialog() == DialogResult.OK)
                    {
                        path = browseMtl.FileName;
                    }
                    else
                        return new Dictionary<string, IPXMaterial>();
                }
                else
                    return new Dictionary<string, IPXMaterial>();
            }
            //Read and parse the mtl file
            Dictionary<string, IPXMaterial> materials = new Dictionary<string, IPXMaterial>();
            IPXMaterial mat = null;
            using (StreamReader mtl = new StreamReader(path))
            {
                string[] allLines = mtl.ReadToEnd().Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
                float r, g, b;
                foreach(string lineStr in allLines)
                {
                    string[] line = lineStr.Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    if (line.Length > 0)
                    {
                        string type = line[0].Trim();   //The first token is the entry type
                        switch (type)
                        {
                            case "Kd":
                                if(line.Length >= 4)
                                {
                                    float.TryParse(line[1].Trim(), out r);
                                    float.TryParse(line[2].Trim(), out g);
                                    float.TryParse(line[3].Trim(), out b);
                                    mat.Diffuse = new V4(r, g, b, mat.Diffuse.A);
                                }
                                break;
                            case "Ks":
                                if (line.Length >= 4)
                                {
                                    float.TryParse(line[1].Trim(), out r);
                                    float.TryParse(line[2].Trim(), out g);
                                    float.TryParse(line[3].Trim(), out b);
                                    mat.Specular = new V3(r, g, b);
                                }
                                break;
                            case "Ns":
                                if (line.Length >= 2)
                                {
                                    float.TryParse(line[1].Trim(), out r);
                                    mat.Power = r;
                                }
                                break;
                            case "Ka":
                                if (line.Length >= 4)
                                {
                                    float.TryParse(line[1].Trim(), out r);
                                    float.TryParse(line[2].Trim(), out g);
                                    float.TryParse(line[3].Trim(), out b);
                                    mat.Ambient = new V3(r, g, b);
                                }
                                break;
                            case "map_Kd":
                                if (line.Length >= 2)
                                {
                                    mat.Tex = line[1];
                                    mat.Diffuse = new V4(1.0f, 1.0f, 1.0f, mat.Diffuse.A);
                                    mat.Ambient = new V3(0.5f, 0.5f, 0.5f);
                                }
                                break;
                            case "Ke":
                                if (line.Length >= 4)
                                {
                                    float.TryParse(line[1].Trim(), out r);
                                    float.TryParse(line[2].Trim(), out g);
                                    float.TryParse(line[3].Trim(), out b);
                                    mat.Ambient = new V3(r, g, b);
                                }
                                break;
                            case "d":
                                if (line.Length >= 2)
                                {
                                    float.TryParse(line[1].Trim(), out r);
                                    mat.Diffuse.A = r;
                                }
                                break;
                            case "newmtl":
                                if (line.Length >= 2)
                                {
                                    //Build a new material if it doesn't exist yet
                                    string name = line[1].Trim();
                                    if (!materials.ContainsKey(name))
                                    {
                                        mat = bld.Material();
                                        mat.Name = name;
                                        mat.NameE = name;
                                        materials.Add(name, mat);
                                    }
                                }
                                break;
                            default:
                                break;
                        }
                    }
                }
            }

            return materials;
        }

        public ObjFileImport(string path, IPXPmxBuilder bld)
        {
            //Read and parse the obj file
            ObjName = Path.GetFileNameWithoutExtension(path);
            _posList = new List<V3>();
            _uvList = new List<V2>();
            _normalList = new List<V3>();
            _vertexList = new Dictionary<string, int>();
            VertexList = new List<IPXVertex>();

            using (StreamReader obj = new StreamReader(path))
            {
                MaterialList = new Dictionary<string, IPXMaterial>();
                string[] allLines = obj.ReadToEnd().Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
                IPXMaterial material = null;
                IPXMaterial baseMaterial = null;
                foreach(string lineStr in allLines)
                {
                    string[] line = lineStr.Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    if(line.Length > 0)
                    {
                        string type = line[0].Trim();
                        int v, vt, vn;
                        float x, y, z;
                        bool lastWasG = false;
                        switch (type)
                        {
                            case "v":
                                float.TryParse(line[1], out x);
                                float.TryParse(line[2], out y);
                                float.TryParse(line[3], out z);
                                _posList.Add(new V3(x, y, -z));
                                lastWasG = false;
                                break;
                            case "vt":
                                float.TryParse(line[1].Trim(), out x);
                                float.TryParse(line[2].Trim(), out y);
                                _uvList.Add(new V2(x, -y));
                                lastWasG = false;
                                break;
                            case "vn":
                                float.TryParse(line[1].Trim(), out x);
                                float.TryParse(line[2].Trim(), out y);
                                float.TryParse(line[3].Trim(), out z);
                                _normalList.Add(new V3(x, y, -z));
                                lastWasG = false;
                                break;
                            case "f":
                                if (line.Length == 4)
                                {
                                    //Triangle
                                    getVertexElements(line[1], out v, out vt, out vn);
                                    int v1 = getVertexNumber(v, vt, vn, bld);
                                    if (v1 >= 0)
                                    {
                                        getVertexElements(line[2], out v, out vt, out vn);
                                        int v2 = getVertexNumber(v, vt, vn, bld);
                                        if (v2 >= 0)
                                        {
                                            getVertexElements(line[3], out v, out vt, out vn);
                                            int v3 = getVertexNumber(v, vt, vn, bld);
                                            if (v3 >= 0)
                                            {
                                                IPXFace face = bld.Face();
                                                face.Vertex1 = VertexList[v3];
                                                face.Vertex2 = VertexList[v2];
                                                face.Vertex3 = VertexList[v1];
                                                material.Faces.Add(face);
                                            }
                                        }
                                    }
                                }
                                else if (line.Length == 5)
                                {
                                    //Quadrilateral
                                    getVertexElements(line[1], out v, out vt, out vn);
                                    int v1 = getVertexNumber(v, vt, vn, bld);
                                    if (v1 >= 0)
                                    {
                                        getVertexElements(line[2], out v, out vt, out vn);
                                        int v2 = getVertexNumber(v, vt, vn, bld);
                                        if (v2 >= 0)
                                        {
                                            getVertexElements(line[3], out v, out vt, out vn);
                                            int v3 = getVertexNumber(v, vt, vn, bld);
                                            if (v3 >= 0)
                                            {
                                                getVertexElements(line[4], out v, out vt, out vn);
                                                int v4 = getVertexNumber(v, vt, vn, bld);
                                                if (v4 >= 0)
                                                {
                                                    IPXFace face1 = bld.Face();
                                                    IPXFace face2 = bld.Face();
                                                    face1.Vertex1 = VertexList[v3];
                                                    face1.Vertex2 = VertexList[v2];
                                                    face1.Vertex3 = VertexList[v1];
                                                    face2.Vertex1 = VertexList[v1];
                                                    face2.Vertex2 = VertexList[v4];
                                                    face2.Vertex3 = VertexList[v3];
                                                    material.Faces.Add(face1);
                                                    material.Faces.Add(face2);
                                                }
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    //n>4 n-gon
                                    throw new PolygonException(line.Length - 1);
                                }
                                lastWasG = false;
                                break;
                            case "g":
                                if (line.Length >= 2)
                                {
                                    material = bld.Material();
                                    material.Name = line[1].Trim();
                                    material.NameE = line[1].Trim();
                                    MaterialList.Add(material.Name, material);
                                }
                                lastWasG = true;
                                break;
                            case "usemtl":
                                if (line.Length >= 2 && AvailableMaterials != null)
                                {

                                    string name = line[1].Trim();
                                    if (AvailableMaterials.ContainsKey(name))
                                    {
                                        //I'm sure there's a more efficient way to do this. Maybe with ICloneable.Clone().
                                        baseMaterial = AvailableMaterials[name];
                                        material.Diffuse = baseMaterial.Diffuse;
                                        material.Ambient = baseMaterial.Ambient;
                                        material.Specular = baseMaterial.Specular;
                                        material.Tex = baseMaterial.Tex;
                                        material.Power = baseMaterial.Power;
                                    }
                                }
                                lastWasG = false;
                                break;
                            case "mtllib":
                                string mtlFileName = lineStr.Substring(7, lineStr.Length - 7);
                                string mtlPath = Path.Combine(Path.GetDirectoryName(path), mtlFileName);
                                AvailableMaterials = new Dictionary<string, IPXMaterial>();
                                AvailableMaterials = ReadMaterialLibrary(mtlPath, bld);
                                break;
                            default:
                                break;
                        }
                    }
                }
            }
        }

        public void RegisterInPmx(IPXPmx pmx, IPXPmxBuilder bld, ObjImportSettings settings)
        {
            IPXBone newBone = null;
            V3 newBonePos = new V3();
            if (settings.CreateBone)
            {
                newBone = bld.Bone();
                newBone.Name = newBone.NameE = ObjName;
            }
            foreach (IPXVertex v in VertexList)
            {
                /*
                if(settings.SwapAxes)
                {
                    TODO - current implementation swaps border vertices twice. Currently disabled in GUI.
                    float oldZ = v.Position.Z;
                    v.Position.Z = v.Position.Y;
                    v.Position.Y = oldZ;
                    float oldNZ = v.Normal.Z;
                    v.Normal.Z = v.Normal.Y;
                    v.Normal.Y = oldNZ;
                } 
                */

                v.Position *= new V3(settings.ScaleX, settings.ScaleY, settings.ScaleZ);
                v.UV *= new V2((settings.MirrorU ? -1 : 1), (settings.MirrorV ? -1 : 1));

                if(settings.CreateBone)
                {
                    newBonePos += v.Position;
                    v.Bone1 = newBone;
                }
                else
                {
                    v.Bone1 = pmx.Bone[0];
                }
                v.Weight1 = 1.0f;
                pmx.Vertex.Add(v);
            }
            if (settings.CreateBone)
            {
                newBonePos /= pmx.Vertex.Count;
                newBone.Position = newBonePos;
                newBone.SetPMDBoneKind(PEPlugin.Pmd.BoneKind.RotateMove);
                pmx.Bone.Add(newBone);
            }

            foreach (KeyValuePair<string, IPXMaterial> m in MaterialList)
            {
                if (settings.ReverseFaces)
                {
                    foreach (IPXFace f in m.Value.Faces)
                    {
                        IPXVertex temp = f.Vertex1;
                        f.Vertex1 = f.Vertex3;
                        f.Vertex3 = temp;
                    }
                }
                pmx.Material.Add(m.Value);
            }
        }
    }
}