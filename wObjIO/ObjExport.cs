using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using PEPlugin;
using PEPlugin.SDX;
using PEPlugin.Pmx;

namespace wObjIO
{
    class wObjExport : IPEExportPlugin
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

                I might also include copyright and meta information as comments.
                */
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + ex.StackTrace, "Exception");
            }
        }
    }
}
