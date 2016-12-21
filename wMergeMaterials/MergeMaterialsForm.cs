using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using PEPlugin;
using PEPlugin.Pmx;

namespace wMergeMaterials
{
    public partial class MergeMaterialsForm : Form
    {
        IPERunArgs args;
        public MergeMaterialsForm(IPERunArgs p_args)
        {
            args = p_args;
            InitializeComponent();
        }

        private void selectCheck_CheckedChanged(object sender, EventArgs e)
        {
            MaterialListForm materialList = new MaterialListForm((List<IPXMaterial>)args.Host.Connector.Pmx.GetCurrentState().Material);
        }
    }
}
