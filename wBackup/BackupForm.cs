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
        public BackupForm(IPERunArgs p_args)
        {
            InitializeComponent();
            args = p_args;
        }

        private void BackupForm_Load(object sender, EventArgs e)
        {

        }
    }
}
