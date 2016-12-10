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
using PEPlugin.Form;

namespace wApplyMorph
{
    public partial class ApplyMorphForm : Form
    {
        //GLOBAL
        IPERunArgs args;
        List<int> Indices = new List<int>();

        public ApplyMorphForm(IPERunArgs p_args)
        {
            args = p_args;
            InitializeComponent();
        }

        private void UpdatePmx(IPXPmx scene)
        {
            args.Host.Connector.Pmx.Update(scene);
            args.Host.Connector.View.PMDView.UpdateModel();
            args.Host.Connector.View.PMDView.UpdateView();
        }

        private void ScanModel(IPXPmx scene)
        {
            for(int i = 0; i < scene.Morph.Count; ++i)
            {

            }
        }

        private int AppliedCount = 0;
        private void applyButton_Click(object sender, EventArgs e)
        {
            AppliedCount++;
            appliedCountLabel.Text = Math.Abs(AppliedCount).ToString();
            if(AppliedCount == 0)
            {
                appliedCountLabel.ForeColor = Control.DefaultForeColor;
            }
            else
            {
                appliedCountLabel.ForeColor = Color.Red;
            }
        }

        private void applyNegativeButton_Click(object sender, EventArgs e)
        {
            AppliedCount--;
            appliedCountLabel.Text = Math.Abs(AppliedCount).ToString();
            if (AppliedCount == 0)
            {
                appliedCountLabel.ForeColor = Control.DefaultForeColor;
            }
            else
            {
                appliedCountLabel.ForeColor = Color.Red;
            }
        }

        private void ApplyMorphForm_Load(object sender, EventArgs e)
        {
            applyButton.Enabled = false;
            applyNegativeButton.Enabled = false;
        }
    }
}
