using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

using PEPlugin;
using PEPlugin.Pmx;
using PEPlugin.SDX;

namespace wObjIO
{
    public struct ObjImportSettings
    {
        public enum BitmapAction { None, Copy, ToPng, ToJpg, ToTga, ToDds };
        public enum MaterialName { Library, Bitmap, ObjNameNumbered, CustomNumbered };
        public float ScaleX { get; set; }
        public float ScaleY { get; set; }
        public float ScaleZ { get; set; }
        public bool SwapAxes { get; set; }
        public bool ReverseFaces { get; set; }
        public bool MirrorU { get; set; }
        public bool MirrorV { get; set; }
        public bool CreateBone { get; set; }
        BitmapAction Bitmap { get; set; }
        MaterialName Material { get; set; }
    }

    public class wObjImportv2 : IPEImportPlugin
    {
        public string Ext
        {
            get
            {
                string systemPluginsPath = Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location), "_plugin\\System");
                string stockPluginPath = Path.Combine(systemPluginsPath, "ImportObj.dll");
                string wObjIOPath = System.Reflection.Assembly.GetExecutingAssembly().Location;
                //MessageBox.Show(systemPluginsPath);
                if (File.Exists(stockPluginPath))
                {
                    //MessageBox.Show("A system plugin is preventing wObjIO from functioning.\nUnfortunately, PMX can't run two import/export plugins for the same extension concurrently, so you have to delete one of the following files:\n\nStock plugin:\n" + stockPluginPath + "\nwObjIO:\n" + wObjIOPath + "\n\nIf it helps you decide, the stock ObjImport.dll doesn't work on most systems and handles mesh transformation poorly.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                return ".obj";
            }
        }
        public string Caption { get { return "Wavefront OBJ (wPlugins importer)"; } }
        //public string Ext { get { return ".obj"; } }

        private IPXPmxBuilder builder;
        private IPXPmx pmx = null;
        private ObjImportSettingsForm settingsForm;

        public IPXPmx Import(string objPath, IPERunArgs args)
        {
            try
            {
                builder = PEStaticBuilder.Pmx;
                pmx = builder.Pmx();
                pmx.Clear();

                settingsForm = new ObjImportSettingsForm();
                if (settingsForm.ShowDialog() == DialogResult.OK)
                {
                    ObjFile import = new ObjFile(objPath, builder);
                    import.RegisterInPmx(pmx, builder, settingsForm.Settings);
                    pmx.ModelInfo.ModelName = pmx.ModelInfo.ModelNameE = import.ObjName;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + ex.StackTrace, "Exception");
            }
            return pmx;
        }
    }

    public class ObjFile
    {
        public string ObjName;
        public List<IPXVertex> VertexList;
        public Dictionary<string, IPXMaterial> MaterialList;
        private List<V3> _posList;
        private List<V2> _uvList;
        private List<V3> _normalList;
        private Dictionary<string, int> _vertexList;

        private void getVertexElements(string faceVertex, out int v, out int vt, out int vn)
        {
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
            Dictionary<string, IPXMaterial> materials = new Dictionary<string, IPXMaterial>();
            IPXMaterial mat = null;
            using (StreamReader mtl = new StreamReader(path))
            {
                string[] allLines = mtl.ReadToEnd().Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
                float r, g, b;
                foreach(string lineStr in allLines)
                {

                    //MessageBox.Show(lineStr);
                    string[] line = lineStr.Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    if (line.Length > 0)
                    {
                        string type = line[0].Trim();
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

        public ObjFile(string path, IPXPmxBuilder bld)
        {
            ObjName = Path.GetFileNameWithoutExtension(path);
            _posList = new List<V3>();
            _uvList = new List<V2>();
            _normalList = new List<V3>();
            _vertexList = new Dictionary<string, int>();
            VertexList = new List<IPXVertex>();

            using (StreamReader obj = new StreamReader(path))
            {
                string[] allLines = obj.ReadToEnd().Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
                IPXMaterial material = null;
                foreach(string lineStr in allLines)
                {
                    string[] line = lineStr.Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    if(line.Length > 0)
                    {
                        string type = line[0].Trim();
                        int v, vt, vn;
                        float x, y, z;
                        switch (type)
                        {
                            case "v":
                                float.TryParse(line[1], out x);
                                float.TryParse(line[2], out y);
                                float.TryParse(line[3], out z);
                                _posList.Add(new V3(x, y, -z));
                                break;
                            case "vt":
                                float.TryParse(line[1].Trim(), out x);
                                float.TryParse(line[2].Trim(), out y);
                                _uvList.Add(new V2(x, -y));
                                break;
                            case "vn":
                                float.TryParse(line[1].Trim(), out x);
                                float.TryParse(line[2].Trim(), out y);
                                float.TryParse(line[3].Trim(), out z);
                                _normalList.Add(new V3(x, y, -z));
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
                                break;
                            case "usemtl":
                                if (line.Length >= 2 && MaterialList != null)
                                {
                                    string name = line[1].Trim();
                                    if (MaterialList.ContainsKey(name))
                                    {
                                        material = MaterialList[name];
                                    }
                                }
                                break;
                            case "mtllib":
                                string mtlPath = Path.Combine(Path.GetDirectoryName(path), line[1].Trim());
                                MaterialList = ReadMaterialLibrary(mtlPath, bld);
                                break;
                            default:
                                break;
                        }
                        /*
                        if(line[0] == "v")              //Vertex position
                        {

                        }
                        else if(line[0] == "vt")        //Vertex UV
                        {

                        }
                        else if(line[0] == "vn")        //Vertex normal
                        {

                        }
                        else if(line[0] == "f")         //Face
                        {

                        }
                        else if(line[0] == "usemtl")    //Material
                        {

                        }
                        else if(line[0] == "mtllib")    //Material library
                        {

                        }
                        else
                        {

                        }*/
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
                if(settings.SwapAxes)
                {   /* 
                    //For some reason, this doesn't process some vertices. I'll try transformation instead.
                    float oldZ = v.Position.Z;
                    v.Position.Z = v.Position.Y;
                    v.Position.Y = oldZ;
                    oldZ = v.Normal.Z;
                    v.Normal.Z = v.Normal.Y;
                    v.Normal.Y = oldZ;
                    */
                } 
                
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
    /*
    public class wObjImport : IPEImportPlugin
    {

        public string Caption { get { return "wP: Wavefront OBJ"; } }

        public string Ext { get { return ".obj"; } }

        //Forward declarations
        IPXPmx _pmx;
        IPXPmxBuilder _builder;
        List<V3> _posList;
        List<V3> _normalList;
        List<V2> _uvList;
        Dictionary<string, int> _vertexList;
        Dictionary<string, IPXMaterial> _materials;

        public IPXPmx Import(string path, IPERunArgs args)
        {
            _builder = PEStaticBuilder.Pmx;
            _pmx = _builder.Pmx();
            _pmx.Clear();
            _posList = new List<V3>();      //Lists for vertex positions, normals and UV coords. Independently indexed. Indices are one less (0-base) than OBJ indices (1-base).
            _normalList = new List<V3>();
            _uvList = new List<V2>();
            _vertexList = new Dictionary<string, int>(); //Store all existing vertices - if a face uses one that already exists (same pos, uv and normal index), it'll refer to its index instead of creating a new one.
            _materials = null;
            IPXMaterial material = null;

            try
            {
                using (StreamReader obj = new StreamReader(path))
                {
                    //string lineStr;
                    int v = 0;
                    int vn = 0;
                    int vt = 0;
                    string[] allLines = obj.ReadToEnd().Split('\n');
                    //while (obj.Peek() >= 0) //Process the file line by line until the end is reached. Write results into the four lists.
                    foreach (string lineStr in allLines)
                    {
                        //lineStr = obj.ReadLine().Trim();
                        string[] line = lineStr.Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                        if (line.Length < 1) continue;
                        float x, y, z;
                        switch (line[0].Trim())
                        {
                            case "v":
                                //Vertex position
                                float.TryParse(line[1], out x);
                                float.TryParse(line[2], out y);
                                float.TryParse(line[3], out z);
                                _posList.Add(new V3(x, y, -z));
                                break;
                            case "vt":
                                //Texture vertex
                                float.TryParse(line[1], out x);
                                float.TryParse(line[2], out y);
                                _uvList.Add(new V2(x, -y));
                                //MessageBox.Show(x.ToString());
                                break;
                            case "vn":
                                //Vertex normal
                                float.TryParse(line[1], out x);
                                float.TryParse(line[2], out y);
                                float.TryParse(line[3], out z);
                                _normalList.Add(new V3(x, y, -z));
                                break;
                            case "f":
                                //Face vertices. Each entry binds together a v, vn and vt entry.
                                //Format is v1/vt1/vn1 v2/vt2/vn2...
                                //Always preceded by "usemtl". 
                                if (line.Length == 4)
                                {
                                    //Triangle
                                    getVertexElements(line[1], out v, out vt, out vn);
                                    int v1 = getVertexNumber(v, vt, vn);
                                    if (v1 >= 0)
                                    {
                                        getVertexElements(line[2], out v, out vt, out vn);
                                        int v2 = getVertexNumber(v, vt, vn);
                                        if (v2 >= 0)
                                        {
                                            getVertexElements(line[3], out v, out vt, out vn);
                                            int v3 = getVertexNumber(v, vt, vn);
                                            if (v3 >= 0)
                                            {
                                                IPXFace face = _builder.Face();
                                                face.Vertex1 = _pmx.Vertex[v3];
                                                face.Vertex2 = _pmx.Vertex[v2];
                                                face.Vertex3 = _pmx.Vertex[v1];
                                                material.Faces.Add(face);
                                            }
                                        }
                                    }
                                }
                                else if(line.Length == 5)
                                {
                                    //Quadrilateral
                                    getVertexElements(line[1], out v, out vt, out vn);
                                    int v1 = getVertexNumber(v, vt, vn);
                                    if (v1 >= 0)
                                    {
                                        getVertexElements(line[2], out v, out vt, out vn);
                                        int v2 = getVertexNumber(v, vt, vn);
                                        if (v2 >= 0)
                                        {
                                            getVertexElements(line[3], out v, out vt, out vn);
                                            int v3 = getVertexNumber(v, vt, vn);
                                            if (v3 >= 0)
                                            {
                                                getVertexElements(line[4], out v, out vt, out vn);
                                                int v4 = getVertexNumber(v, vt, vn);
                                                if (v4 >= 0)
                                                {
                                                    IPXFace face1 = _builder.Face();
                                                    face1.Vertex1 = _pmx.Vertex[v3];
                                                    face1.Vertex2 = _pmx.Vertex[v2];
                                                    face1.Vertex3 = _pmx.Vertex[v1];
                                                    material.Faces.Add(face1);
                                                    IPXFace face2 = _builder.Face();
                                                    face2.Vertex1 = _pmx.Vertex[v1];
                                                    face2.Vertex2 = _pmx.Vertex[v4];
                                                    face2.Vertex3 = _pmx.Vertex[v3];
                                                    material.Faces.Add(face2);
                                                }
                                            }
                                        }
                                    }
                                }
                                break;
                            case "g":   //TODO: if materials are not present, try to separate by groups
                                break;
                            case "usemtl":  //Always precedes face definitions
                                //MessageBox.Show((line.Length >= 2).ToString() + (_materials != null).ToString());
                                if (line.Length >= 2 && _materials != null)
                                {
                                    string name = line[1].Trim();
                                    if (_materials.ContainsKey(name))
                                    {
                                        material = _materials[name];
                                        _pmx.Material.Add(material);
                                        //MessageBox.Show("Added " + _pmx.Material[0].Name);
                                    }
                                }
                                break;
                            case "mtllib":  //Should be only one, and at the beginning of the file
                                if (line.Length >= 2)
                                {
                                    string mtlPath = Path.Combine(Path.GetDirectoryName(path), line[1].Trim());
                                    _materials = readMaterials(mtlPath);
                                }
                                break;
                            default:
                                break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + ex.StackTrace, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            args.Host.Connector.Pmx.Update(_pmx);
            return _pmx;
        }

        private void getVertexElements(string faceVertex, out int v, out int vt, out int vn)
        {
            v = -1;
            vt = -1;
            vn = -1;
            //Split faceVertex at / characters
            string[] vStr = faceVertex.Trim().Split('/');
            //string[] vStr = new string[] { "1", "2", "3" };
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
        private int getVertexNumber(int v, int vt, int vn)
        {
            string vertexKey = v.ToString() + '/' + vt.ToString() + '/' + vn.ToString();    //Construct a unique identifier that'll be used as key in vertexList.
            if (_vertexList.ContainsKey(vertexKey))  //If the vertex exists, return its index
            {
                //MessageBox.Show("Existing " + vertexKey);
                return _vertexList[vertexKey];
            }
            else       //Otherwise create a new vertex, set its values, then add its key and index to the dictionary
            {
                //MessageBox.Show("New " + vertexKey);
                IPXVertex newVertex = _builder.Vertex();
                if (v >= 0 && v < _posList.Count) newVertex.Position = _posList[v];
                if (vt >= 0 && vt < _uvList.Count) newVertex.UV = _uvList[vt];
                if (vn >= 0 && vn < _normalList.Count) newVertex.Normal = _normalList[vn];
                newVertex.Bone1 = _pmx.Bone[0];
                newVertex.Weight1 = 1;
                _pmx.Vertex.Add(newVertex);
                int newIndex = _pmx.Vertex.Count - 1;
                _vertexList.Add(vertexKey, newIndex);
                return newIndex;
            }
        }

        Dictionary<string, IPXMaterial> readMaterials(string path)
        {
            Dictionary<string, IPXMaterial> materials = new Dictionary<string, IPXMaterial>();
            if (!File.Exists(path))   //If no material file is present, default materials will be added as needed.
            {
                return materials;
            }
            IPXMaterial mat = null;
            float r = 0, g = 0, b = 0;


            using (StreamReader mtl = new StreamReader(path))
            {
                string[] mtlLines = mtl.ReadToEnd().Split('\n');
                //while(mtl.Peek() >= 0)
                foreach (string lineStr in mtlLines)
                {
                    //string lineStr = mtl.ReadLine().Trim();
                    string[] line = lineStr.Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    if (line.Length < 1) continue;
                    switch (line[0].Trim())
                    {
                        case "newmtl":  //new material
                            if (line.Length >= 2)
                            {
                                string name = line[1].Trim();
                                if (!materials.ContainsKey(name))
                                {
                                    mat = _builder.Material();
                                    mat.Name = name;
                                    mat.NameE = name;
                                    materials.Add(name, mat);
                                }
                            }
                            break;
                        case "map_Kd":  //diffuse bitmap
                            if (mat != null && line.Length > 1)
                            {
                                mat.Tex = line[1];
                                mat.Diffuse = new V4(1f, 1f, 1f, 1f);
                                mat.Ambient = new V3(0.5f, 0.5f, 0.5f);
                            }
                            break;
                        case "Kd":      //diffuse colour
                            if (mat != null && line.Length >= 4)
                            {
                                if (string.IsNullOrWhiteSpace(mat.Tex))
                                {
                                    float.TryParse(line[1], out r);
                                    float.TryParse(line[2], out g);
                                    float.TryParse(line[3], out b);
                                }
                                else
                                {
                                    r = 1.0f;
                                    g = 1.0f;
                                    b = 1.0f;
                                }
                                mat.Diffuse = new V4(r, g, b, mat.Diffuse.A);
                            }
                            break;
                        case "Ks":      //specular colour
                            if (mat != null && line.Length >= 4)
                            {
                                float.TryParse(line[1], out r);
                                float.TryParse(line[2], out g);
                                float.TryParse(line[3], out b);
                                mat.Specular = new V3(r, g, b);
                            }
                            break;
                        case "Ka":      //ambient colour
                            if (mat != null && line.Length >= 4)
                            {
                                if(string.IsNullOrWhiteSpace(mat.Tex))
                                {
                                    float.TryParse(line[1], out r);
                                    float.TryParse(line[2], out g);
                                    float.TryParse(line[3], out b);
                                }
                                else
                                {
                                    r = 0.5f;
                                    g = 0.5f;
                                    b = 0.5f;
                                }
                                mat.Ambient = new V3(r, g, b);
                            }
                            break;
                        case "Ns":      //glossiness
                            if (mat != null && line.Length >= 2)
                            {
                                float.TryParse(line[1], out r);
                                mat.Power = r;
                            }
                            break;
                        case "d":       //opacity
                            if (mat != null && line.Length >= 2)
                            {
                                float.TryParse(line[1], out r);
                                mat.Diffuse.A = r;
                            }
                            break;
                        default:
                            break;
                    }
                }
            }
            return materials;
        }
    }*/
}