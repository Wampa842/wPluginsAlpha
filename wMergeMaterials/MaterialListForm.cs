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
using PEPlugin.Form;
using PEPlugin.Pmx;

namespace wMergeMaterials
{
    public partial class MaterialListForm : Form
    {
        List<IPXMaterial> Materials;
        public MaterialListForm(List<IPXMaterial> p_materials)
        {
            Materials = p_materials;
            InitializeComponent();
        }

        private void PopulateList(List<IPXMaterial> list, CheckedListBox listBox)
        {
            foreach(IPXMaterial m in Materials)
            {
                listBox.Items.Add(m.Name, false);
            }
        }

        private void MaterialListForm_Load(object sender, EventArgs e)
        {

        }
    }
}
