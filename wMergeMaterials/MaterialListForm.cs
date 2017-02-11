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
        Form parentForm;
        public MaterialListForm(List<IPXMaterial> p_materials, Form p_parent)
        {
            Materials = p_materials;
            parentForm = p_parent;
            InitializeComponent();
        }

        public void PopulateList(List<IPXMaterial> list, CheckedListBox listBox)
        {
            foreach(IPXMaterial m in Materials)
            {
                listBox.Items.Add(m.Name, false);
            }
        }

        private void MaterialListForm_Load(object sender, EventArgs e)
        {
            PopulateList(Materials, materialList);
            //Location = Parent.Location + new Point(Parent.Size.Width, 0);
            Location = new Point(ParentForm.Location.X + ParentForm.Size.Width, ParentForm.Location.Y);
        }

        private void selectAllButton_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < materialList.Items.Count; ++i)
            {
                //Check every item
                materialList.SetItemChecked(i, true);
            }
        }

        private void selectNoneButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < materialList.Items.Count; ++i)
            {
                //Uncheck every item
                materialList.SetItemChecked(i, false);
            }
        }

        private void selectInvertButton_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < materialList.Items.Count; ++i)
            {
                //Invert checked status
                materialList.SetItemChecked(i, !materialList.GetItemChecked(i));
            }
        }
    }
}
