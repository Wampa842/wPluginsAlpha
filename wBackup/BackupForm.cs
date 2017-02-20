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

namespace wBackup
{
    public partial class BackupForm : Form
    {
        IPERunArgs args;
        SideListsForm sideList;


        public BackupForm(IPERunArgs p_args)
        {
            InitializeComponent();
            args = p_args;
            sideList = new SideListsForm();
            sideList.Visible = false;
        }

        private void BackupForm_Load(object sender, EventArgs e)
        {

        }

        private void sideListShowButton_Click(object sender, EventArgs e)
        {
            sideList.Visible = !sideList.Visible;
            sideList.Location = new Point(this.Location.X + this.Width + 5, this.Location.Y);
        }

        private void BackupForm_Move(object sender, EventArgs e)
        {
            sideList.Location = new Point(this.Location.X + this.Width + 5, this.Location.Y);
        }
    }
}
