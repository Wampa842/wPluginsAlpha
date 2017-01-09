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
        MaterialListForm materialList;
        public MergeMaterialsForm(IPERunArgs p_args)
        {
            args = p_args;
            InitializeComponent();
            materialList = new MaterialListForm((List<IPXMaterial>)args.Host.Connector.Pmx.GetCurrentState().Material, this);
        }

        private void selectCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
            {
                if(materialList.IsDisposed) materialList = new MaterialListForm((List<IPXMaterial>)args.Host.Connector.Pmx.GetCurrentState().Material, this);
                materialList.Show();
            }
            else
            {
                materialList.Hide();
            }
        }

        private void MergeMaterialsForm_Move(object sender, EventArgs e)
        {
            materialList.Location = new Point(Location.X + Size.Width, Location.Y);
        }
    }
}
