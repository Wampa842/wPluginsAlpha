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

namespace wNameUtil
{
    public partial class NameUtilForm : Form
    {
        //Private members
        private IPERunArgs args;

        public NameUtilForm(IPERunArgs p_args)
        {
            args = p_args;
            InitializeComponent();
        }
    }
}
