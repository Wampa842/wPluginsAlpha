using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;
using System.Windows.Forms;

using PEPlugin;
using PEPlugin.Pmx;
using PEPlugin.SDX;

namespace ImportPlugin
{
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

        private void getVertexElements(string faceVertex, out int v, out int vt, out int vn)
        {
            v = -1;
            vt = -1;
            vn = -1;
            //Split faceVertex at / characters
            string[] vStr = faceVertex.Trim().Split('/');
            //string[] vStr = new string[] { "1", "2", "3" };
            if(vStr.Length >= 1)
            {
                int.TryParse(vStr[0], out v);
                --v;    //Decrement ensures correct indexing
                if(vStr.Length >= 2)
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
                foreach(string lineStr in mtlLines)
                {
                    //string lineStr = mtl.ReadLine().Trim();
                    string[] line = lineStr.Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    if (line.Length < 1) continue;
                    switch (line[0].Trim())
                    {
                        case "newmtl":  //new material
                            if(line.Length >= 2)
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
                            if(mat != null && line.Length > 1)
                            {
                                mat.Tex = line[1];
                            }
                            break;
                        case "Kd":      //diffuse colour
                            if (mat != null && line.Length >= 4)
                            {
                                float.TryParse(line[1], out r);
                                float.TryParse(line[2], out g);
                                float.TryParse(line[3], out b);
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
                                float.TryParse(line[1], out r);
                                float.TryParse(line[2], out g);
                                float.TryParse(line[3], out b);
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

        public IPXPmx Import(string path, IPERunArgs args)
        {
            _builder = PEStaticBuilder.Pmx;
            _pmx = _builder.Pmx();
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
                    foreach(string lineStr in allLines)
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
                                _posList.Add(new V3(x, y, z));
                                break;
                            case "vt":
                                //Texture vertex
                                float.TryParse(line[1], out x);
                                float.TryParse(line[2], out y);
                                _uvList.Add(new V2(x, y));
                                //MessageBox.Show(x.ToString());
                                break;
                            case "vn":
                                //Vertex normal
                                float.TryParse(line[1], out x);
                                float.TryParse(line[2], out y);
                                float.TryParse(line[3], out z);
                                _normalList.Add(new V3(x, y, z));
                                break;
                            case "f":
                                //Face vertices. Each entry binds together a v, vn and vt entry.
                                //Format is v1/vt1/vn1 v2/vt2/vn2...
                                //Always preceded by "usemtl". 
                                if (line.Length >= 4)
                                {
                                    //Triangle
                                    //First vertex
                                    getVertexElements(line[1], out v, out vt, out vn);
                                    int v1 = getVertexNumber(v, vt, vn);
                                    if(v1 >= 0)
                                    {
                                        getVertexElements(line[2], out v, out vt, out vn);
                                        int v2 = getVertexNumber(v, vt, vn);
                                        if(v2 >= 0)
                                        {
                                            getVertexElements(line[3], out v, out vt, out vn);
                                            int v3 = getVertexNumber(v, vt, vn);
                                            if(v3 >= 0)
                                            {
                                                IPXFace face = _builder.Face();
                                                face.Vertex1 = _pmx.Vertex[v1];
                                                face.Vertex2 = _pmx.Vertex[v2];
                                                face.Vertex3 = _pmx.Vertex[v3];
                                                material.Faces.Add(face);
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
                                        MessageBox.Show("Added " + _pmx.Material[0].Name);
                                    }
                                }
                                break;
                            case "mtllib":  //Should be only one, and at the beginning of the file
                                if(line.Length >= 2)
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + '\n' + ex.StackTrace, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            MessageBox.Show(_pmx.Material[0].Name);
            args.Host.Connector.Pmx.Update(_pmx);
            return _pmx;
        }
    }
}
