using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace wPluginsSettings
{
    public partial class PluginSettingsForm : Form
    {
        PEPlugin.IPERunArgs args;
        public PluginSettingsForm(PEPlugin.IPERunArgs p_args)
        {
            args = p_args;
            InitializeComponent();
        }
    }
}
