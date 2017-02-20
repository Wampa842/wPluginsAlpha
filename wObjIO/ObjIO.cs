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

namespace wObjIO
{
    public class wObjImport : IPEImportPlugin
    {
        public string Caption { get { return "Wavefront OBJ file"; } }

        public string Ext { get { return ".obj"; } }

        public IPXPmx Import(string path, IPERunArgs args)
        {
            IPXPmx pmx = PEStaticBuilder.Pmx.Pmx();
            List<V3> posList = new List<V3>();
            List<V3> normalList = new List<V3>();
            List<V2> uvList = new List<V2>();


            try
            {
                using (StreamReader obj = new StreamReader(path))
                {
                    string line, type, values;
                    int v = 0;
                    int vn = 0;
                    int vt = 0;
                    while (obj.Peek() >= 0) //Process the file line by line until the end is reached. Write results into the four lists.
                    {
                        line = obj.ReadLine();
                        type = Regex.Match(line, @"(^\w+)").Groups[0].Value;
                        switch (type)
                        {
                            case "v":
                                //Vertex position

                                break;
                            case "vt":
                                break;
                            case "vn":
                                break;
                            case "f":
                                break;
                            case "g":
                                break;
                            case "usemtl":
                                break;
                            case "mtllib":
                                break;
                            default:
                                break;
                        }
                    }
                }
            }
            catch(UnauthorizedAccessException ex)
            {
                MessageBox.Show("You don't have permission to read that file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return pmx;
        }
    }
}
