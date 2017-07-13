using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.ComponentModel;
using System.Xml;

using PEPlugin;
using PEPlugin.SDX;
using PEPlugin.Pmx;

namespace wObjIO
{
    public class ObjExportSettings
    {
        public float ScaleX { get; set; } = 1.0f;
        public float ScaleY { get; set; } = 1.0f;
        public float ScaleZ { get; set; } = 1.0f;
        public bool SwapAxes { get; set; } = false;
        public bool ReverseFaces { get; set; } = false;
        public bool MirrorU { get; set; } = false;
        public bool MirrorV { get; set; } = false;
        public bool CopyBitmaps { get; set; } = true;

        public ObjExportSettings() { }
    }


    public class ObjFileExport
    {
        //Mesh data
        public class WFace
        {
            public int[] V, Vt, Vn;
            public WFace()
            {
                V = new int[3];
                Vt = new int[3];
                Vn = new int[3];
            }
            public void Vert1(int v, int vt, int vn)
            {
                this.V[0] = v;
                this.Vt[0] = vt;
                this.Vn[0] = vn;
            }
            public void Vert2(int v, int vt, int vn)
            {
                this.V[1] = v;
                this.Vt[1] = vt;
                this.Vn[1] = vn;
            }
            public void Vert3(int v, int vt, int vn)
            {
                this.V[2] = v;
                this.Vt[2] = vt;
                this.Vn[2] = vn;
            }

            public string FaceToString()
            {
                string v1 = V[0].ToString() + '/' + Vt[0].ToString() + '/' + Vn[0].ToString();
                string v2 = V[1].ToString() + '/' + Vt[1].ToString() + '/' + Vn[1].ToString();
                string v3 = V[2].ToString() + '/' + Vt[2].ToString() + '/' + Vn[2].ToString();
                return "f " + v1 + ' ' + v2 + ' ' + v3;
            }
        }
        public class WMaterial
        {
            public List<WFace> Faces;
            public V3 Diffuse;
            public V3 Ambient;
            public V3 Specular;
            public float Glossiness = 32;
            public float Opacity = 1.0f;
            public string Bitmap = "";
            public string Name = "";
            public WMaterial(IPXMaterial source)
            {
                Faces = new List<WFace>();
                Name = source.Name;
                Diffuse = source.Diffuse.ToV3();
                Opacity = source.Diffuse.A;
                Ambient = source.Ambient;
                Specular = source.Specular;
                Glossiness = source.Power;
                if (!string.IsNullOrWhiteSpace(source.Tex))
                    Bitmap = source.Tex;
            }
        }
        public int ItemCount
        {
            get
            {
                int faceCount = 0;
                foreach(WMaterial m in materialList)
                {
                    faceCount += m.Faces.Count;
                }
                return faceCount + vList.Count + vtList.Count + vnList.Count;
            }
        }

        private List<string> vList;
        private List<string> vtList;
        private List<string> vnList;
        private List<WMaterial> materialList;

        private IPERunArgs args;

        public ObjFileExport(IPXPmx pmx, ObjExportSettings settings, IPERunArgs p_args)
        {
            args = p_args;
            List<IPXVertex> processedVerts = new List<IPXVertex>();
            vList = new List<string>();
            vtList = new List<string>();
            vnList = new List<string>();
            materialList = new List<WMaterial>();
            //Add vertices to the lists
            foreach(IPXVertex v in pmx.Vertex)
            {
                string vStr = "v " + v.Position.X.ToString() + ' ' + v.Position.Y.ToString() + ' ' + v.Position.Z.ToString();
                string vtStr = "vt " + v.UV.U.ToString() + ' ' + (-v.UV.V).ToString() + ' ' + 0.0f.ToString();
                string vnStr = "vn " + v.Normal.X.ToString() + ' ' + v.Normal.Y.ToString() + ' ' + v.Normal.Z.ToString();

                if (!vList.Contains(vStr)) vList.Add(vStr);
                if (!vtList.Contains(vtStr)) vtList.Add(vtStr);
                if (!vnList.Contains(vnStr)) vnList.Add(vnStr);
            }
            //Process the scene by iterating over its materials, then its faces. Relevant data will be written into strings.
            foreach(IPXMaterial m in pmx.Material)
            {
                WMaterial mat = new WMaterial(m);
                foreach(IPXFace f in m.Faces)
                {
                    WFace face = new WFace();
                    //Vertex 1
                    IPXVertex v = f.Vertex1;
                    string vStr = "v " + v.Position.X.ToString() + ' ' + v.Position.Y.ToString() + ' ' + v.Position.Z.ToString();
                    string vtStr = "vt " + v.UV.U.ToString() + ' ' + (-v.UV.V).ToString() + ' ' + 0.0f.ToString();
                    string vnStr = "vn " + v.Normal.X.ToString() + ' ' + v.Normal.Y.ToString() + ' ' + v.Normal.Z.ToString();
                    face.Vert1(vList.FindIndex(a => a == vStr) + 1, vtList.FindIndex(a => a == vtStr) + 1, vnList.FindIndex(a => a == vnStr) + 1);

                    //Vertex 2
                    v = f.Vertex2;
                    vStr = "v " + v.Position.X.ToString() + ' ' + v.Position.Y.ToString() + ' ' + v.Position.Z.ToString();
                    vtStr = "vt " + v.UV.U.ToString() + ' ' + (-v.UV.V).ToString() + ' ' + 0.0f.ToString();
                    vnStr = "vn " + v.Normal.X.ToString() + ' ' + v.Normal.Y.ToString() + ' ' + v.Normal.Z.ToString();
                    face.Vert2(vList.FindIndex(a => a == vStr) + 1, vtList.FindIndex(a => a == vtStr) + 1, vnList.FindIndex(a => a == vnStr) + 1);
                    
                    //Vertex 3
                    v = f.Vertex3;
                    vStr = "v " + v.Position.X.ToString() + ' ' + v.Position.Y.ToString() + ' ' + v.Position.Z.ToString();
                    vtStr = "vt " + v.UV.U.ToString() + ' ' + (-v.UV.V).ToString() + ' ' + 0.0f.ToString();
                    vnStr = "vn " + v.Normal.X.ToString() + ' ' + v.Normal.Y.ToString() + ' ' + v.Normal.Z.ToString();
                    face.Vert3(vList.FindIndex(a => a == vStr) + 1, vtList.FindIndex(a => a == vtStr) + 1, vnList.FindIndex(a => a == vnStr) + 1);
                    
                    mat.Faces.Add(face);
                }
                materialList.Add(mat);
            }
        }

        public void SaveMtl(string objPath, ObjExportSettings settings, ObjExportProgress progress)
        {
            using (StreamWriter mtl = File.CreateText(Path.Combine(Path.GetDirectoryName(objPath), Path.GetFileNameWithoutExtension(objPath) + ".mtl")))
            {
                string mtlStr = string.Empty;
                mtlStr += "# wObjIO OBJ Exporter - (c) 2017 Wampa842\n# wampa842.deviantart.com\n# wampa842@gmail.com\n\n# File created: " + DateTime.Now.ToString("yyyy-MM-dd HH:mm") + "\n";

                foreach (WMaterial m in materialList)
                {
                    progress.progressBar1.Value++;
                    mtlStr += "\n\nnewmtl " + m.Name;
                    mtlStr += "\n    Ka " + m.Ambient.R + ' ' + m.Ambient.G + ' ' + m.Ambient.B;
                    mtlStr += "\n    Ks " + m.Specular.R + ' ' + m.Specular.G + ' ' + m.Specular.B;
                    mtlStr += "\n    Kd " + m.Diffuse.R + ' ' + m.Diffuse.G + ' ' + m.Diffuse.B;
                    if (!string.IsNullOrWhiteSpace(m.Bitmap))
                    {
                        mtlStr += "\n    map_Ka " + m.Bitmap;
                        mtlStr += "\n    map_Kd " + m.Bitmap;
                    }
                    mtlStr += "\n    d " + m.Opacity;
                    mtlStr += "\n    Ns " + m.Glossiness;
                    mtlStr += "\n    illum 2";

                    
                    if(settings.CopyBitmaps && !string.IsNullOrWhiteSpace(m.Bitmap))
                    {
                        string originalPath = Path.Combine(Path.GetDirectoryName(args.Host.Connector.Pmx.CurrentPath), m.Bitmap);
                        string targetPath = Path.Combine(Path.GetDirectoryName(objPath), m.Bitmap);
                        
                        if (!File.Exists(targetPath) && File.Exists(originalPath))
                        {
                            try
                            {
                                File.Copy(originalPath, targetPath);
                            }
                            catch(Exception ex) when (ex is UnauthorizedAccessException || ex is PathTooLongException)
                            {
                                if(MessageBox.Show("Unable to copy bitmap. Make sure there is enough free space on the disc, the filename isn't too long, and you have permission to access the destination.\nWould you like to export the rest of the bitmaps?\n", "Can't copy bitmap", MessageBoxButtons.YesNo) == DialogResult.No)
                                {
                                    settings.CopyBitmaps = false;
                                }
                            }
                        }
                    }
                }

                mtl.Write(mtlStr);
                mtl.Close();
            }
        }

        public void SaveObj(string objPath, ObjExportSettings settings, ObjExportProgress progress)
        {
            SaveMtl(objPath, settings, progress);
            using (StreamWriter obj = new StreamWriter(objPath))
            {
                obj.WriteLine("# wObjIO OBJ Exporter - (c) 2017 Wampa842");
                obj.WriteLine("# wampa842.deviantart.com");
                obj.WriteLine("# wampa842@gmail.com");

                obj.WriteLine("\n\nmtllib " + Path.GetFileNameWithoutExtension(objPath) + ".mtl\n");

                //Write vertices
                foreach (string v in vList)
                {
                    progress.progressBar1.Value++;
                    obj.WriteLine(v);
                }
                obj.WriteLine("# " + vList.Count + " vertex positions\n");
                foreach (string vt in vtList)
                {
                    progress.progressBar1.Value++;
                    obj.WriteLine(vt);
                }
                obj.WriteLine("# " + vtList.Count + " texture coordinates\n");
                foreach (string vn in vnList)
                {
                    progress.progressBar1.Value++;
                    obj.WriteLine(vn);
                }
                obj.WriteLine("# " + vnList.Count + " vertex normals\n");

                //Groups
                foreach (WMaterial m in materialList)
                {
                    obj.WriteLine("\ng " + m.Name);
                    obj.WriteLine("usemtl " + m.Name);
                    obj.WriteLine("s 1");
                    foreach(WFace f in m.Faces)
                    {
                        obj.WriteLine(f.FaceToString());
                    }
                }
            }

        }
    }
    
    public class wObjExport : IPEExportPlugin
    {
        public string Ext { get { return ".obj"; } }
        public string Caption { get { return "Wavefront OBJ (wObjIO Exporter)"; } }

        public void Export(IPXPmx pmx, string path, IPERunArgs args)
        {
            try
            {
                /*
                The OBJ file will always begin with the mtllib keyword to define materials.
                It is followed by v, vt and vn lines in this order. Vertex data is flat and ungrouped.
                v is the XYZ coordinates of a vertex.
                vt is the UVW coordinates. Since PMX only defines U and V, W will always be 0.
                vn is the normal coordinates. It's always a unit vector.

                Face and group data begins with g, then usemtl. Processing a material will always result in both g and usemtl.
                Smoothing groups will always be defined as 2 - they're defined in PMX by vertex normals.
                Each face will be a triangle. A face will consist of three vertex definitions.
                Each vertex definition will contain the 1-based index of its v, vt and vn entry, separated by forward slashes, definitions separated by spaces.

                The MTL file contains material definitions.
                Processing a material will append a newmtl and relevant data to the end of the file.
                The material name is as it appears in PMX.
                Kd, Ks, Ns, Ka, d are float values. map_Kd and map_Ka are both the diffuse map name.

                I might also include copyright and meta information as comments.
                */

                ObjExportSettingsForm settingsForm = new ObjExportSettingsForm();
                if (settingsForm.ShowDialog() == DialogResult.OK)
                {
                    ObjExportProgress report = new ObjExportProgress();
                    report.Show();
                    ObjFileExport obj = new ObjFileExport(pmx, settingsForm.Settings, args);
                    report.progressBar1.Maximum = obj.ItemCount;
                    obj.SaveObj(path, settingsForm.Settings, report);
                    report.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + ex.StackTrace, "Exception");
            }
        }
    }
}
