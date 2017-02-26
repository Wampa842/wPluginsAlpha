using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wObjIO
{
    public partial class ObjExportSettingsForm : Form
    {
        public ObjExportSettings Settings;

        public ObjExportSettingsForm()
        {
            InitializeComponent();
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            Settings = new ObjExportSettings();
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
