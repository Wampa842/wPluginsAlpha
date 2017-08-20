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
            bool oneSelected = (xFlip.Checked && !yFlip.Checked && !zFlip.Checked) || (!xFlip.Checked && yFlip.Checked && !zFlip.Checked) || (!xFlip.Checked && !yFlip.Checked && zFlip.Checked);
            bool threeSelected = (xFlip.Checked && yFlip.Checked && !zFlip.Checked) || (!xFlip.Checked && yFlip.Checked && zFlip.Checked) || (xFlip.Checked && !yFlip.Checked && zFlip.Checked);
            Settings.ReverseFaces = (oneSelected || threeSelected) ^ flipFaces.Checked;
            Settings.ScaleX = (float)xScale.Value * (xFlip.Checked ? -1 : 1);
            Settings.ScaleY = (float)yScale.Value * (yFlip.Checked ? -1 : 1);
            Settings.ScaleZ = (float)zScale.Value * (zFlip.Checked ? -1 : 1);
            Settings.SwapAxes = yzSwap.Checked;
            Settings.MirrorU = uFlip.Checked;
            Settings.MirrorV = vFlip.Checked;
            Settings.CopyBitmaps = copyBitmaps.Checked;
            DialogResult = DialogResult.OK;

            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void uniformScale_CheckedChanged(object sender, EventArgs e)
        {
            yScale.Enabled = !((CheckBox)sender).Checked;
            zScale.Enabled = !((CheckBox)sender).Checked;
            yScale.Value = xScale.Value;
            zScale.Value = xScale.Value;
        }

        private void ScaleValue_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown o = (NumericUpDown)sender;
            if (uniformScale.Checked)
            {
                yScale.Value = xScale.Value;
                zScale.Value = xScale.Value;
            }
        }

        private void ObjExportSettingsForm_Load(object sender, EventArgs e)
        {
            ObjExportSettings settings = new ObjExportSettings();
            settings.ReadSettingsFile(null);
        }
    }
}
