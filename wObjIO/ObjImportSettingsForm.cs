using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace wObjIO
{
    public partial class ObjImportSettingsForm : Form
    {
        public ObjImportSettings Settings;
        public Dictionary<string, ObjImportSettings.MaterialName> MaterialName;
        public Dictionary<string, ObjImportSettings.BitmapAction> BitmapAction;
        public ObjImportSettingsForm()
        {
            MaterialName = new Dictionary<string, ObjImportSettings.MaterialName>();
            MaterialName.Add("From material library", ObjImportSettings.MaterialName.Library);
            MaterialName.Add("From bitmap", ObjImportSettings.MaterialName.Bitmap);
            MaterialName.Add("Obj name + number", ObjImportSettings.MaterialName.ObjNameNumbered);
            MaterialName.Add("Custom + number", ObjImportSettings.MaterialName.CustomNumbered);
            BitmapAction = new Dictionary<string, ObjImportSettings.BitmapAction>();
            BitmapAction.Add("Do nothing", ObjImportSettings.BitmapAction.None);
            BitmapAction.Add("Copy", ObjImportSettings.BitmapAction.Copy);
            BitmapAction.Add("Convert to PNG and copy", ObjImportSettings.BitmapAction.ToPng);
            BitmapAction.Add("Convert to JPG and copy", ObjImportSettings.BitmapAction.ToJpg);
            BitmapAction.Add("Convert to TGA and copy", ObjImportSettings.BitmapAction.ToTga);
            BitmapAction.Add("Convert to DDS and copy", ObjImportSettings.BitmapAction.ToDds);
            InitializeComponent();
        }

        //Load settings from XML file
        private void LoadSettingsFromXml()
        {
            XmlDocument xml = new XmlDocument();
            xml.Load(Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), "settings.xml"));
            XmlNode node = xml.DocumentElement["wObjIO"];

            bool _useMetricUnits = false;
            bool _flipFaces = false;
            bool _uniformScale = false;
            bool _swapAxes = false;
            bool _mirrorX = false;
            bool _mirrorY = false;
            bool _mirrorZ = false;
            bool _mirrorU = false;
            bool _mirrorV = false;
            bool _withBone = false;
            float _scaleX = 1.0f;
            float _scaleY = 1.0f;
            float _scaleZ = 1.0f;

            bool.TryParse(node["MetricUnits"].InnerText, out _useMetricUnits);
            unitBaseMetric.Checked = _useMetricUnits;
            bool.TryParse(node["FlipFaces"].InnerText, out _flipFaces);
            flipFacesCheck.Checked = _flipFaces;
            bool.TryParse(node["SwapYZ"].InnerText, out _swapAxes);
            yzSwap.Checked = _swapAxes;
            bool.TryParse(node["UniformScale"].InnerText, out _uniformScale);
            uniformScale.Checked = _uniformScale;
            bool.TryParse(node["MirrorX"].InnerText, out _mirrorX);
            xFlip.Checked = _mirrorX;
            bool.TryParse(node["MirrorY"].InnerText, out _mirrorY);
            yFlip.Checked = _mirrorY;
            bool.TryParse(node["MirrorZ"].InnerText, out _mirrorZ);
            zFlip.Checked = _mirrorZ;
            bool.TryParse(node["MirrorU"].InnerText, out _mirrorU);
            uFlip.Checked = _mirrorU;
            bool.TryParse(node["MirrorV"].InnerText, out _mirrorV);
            vFlip.Checked = _mirrorV;
            bool.TryParse(node["WithBone"].InnerText, out _withBone);
            vFlip.Checked = _mirrorV;

            float.TryParse(node["XScale"].InnerText, out _scaleX);
            xScale.Value = (decimal)_scaleX;
            float.TryParse(node["YScale"].InnerText, out _scaleY);
            yScale.Value = (decimal)_scaleY;
            float.TryParse(node["ZScale"].InnerText, out _scaleZ);
            zScale.Value = (decimal)_scaleZ;
        }

        //Save settings to XML file
        private void SaveSettingsToXml()
        {
            XmlDocument xml = new XmlDocument();
            xml.Load(Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), "settings.xml"));
            XmlNode n = xml.DocumentElement["wObjIO"];
            n["MetricUnits"].InnerText = unitBaseMetric.Checked.ToString().ToLowerInvariant();
            n["FlipFaces"].InnerText = flipFacesCheck.Checked.ToString().ToLowerInvariant();
            n["SwapYZ"].InnerText = yzSwap.Checked.ToString().ToLowerInvariant();
            n["UniformScale"].InnerText = uniformScale.Checked.ToString().ToLowerInvariant();
            n["MirrorX"].InnerText = xFlip.Checked.ToString().ToLowerInvariant();
            n["MirrorY"].InnerText = yFlip.Checked.ToString().ToLowerInvariant();
            n["MirrorZ"].InnerText = zFlip.Checked.ToString().ToLowerInvariant();
            n["MirrorU"].InnerText = uFlip.Checked.ToString().ToLowerInvariant();
            n["MirrorV"].InnerText = vFlip.Checked.ToString().ToLowerInvariant();
            n["WithBone"].InnerText = vFlip.Checked.ToString().ToLowerInvariant();

            n["XScale"].InnerText = ((float)xScale.Value).ToString();
            n["YScale"].InnerText = ((float)yScale.Value).ToString();
            n["ZScale"].InnerText = ((float)zScale.Value).ToString();
            xml.Save(Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), "settings.xml"));
        }

        private void ScaleValue_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown o = (NumericUpDown)sender;
            if(uniformScale.Checked)
            {
                yScale.Value = xScale.Value;
                zScale.Value = xScale.Value;
            }
        }

        private void uniformScale_CheckedChanged(object sender, EventArgs e)
        {
            yScale.Enabled = !((CheckBox)sender).Checked;
            zScale.Enabled = !((CheckBox)sender).Checked;
            yScale.Value = xScale.Value;
            zScale.Value = xScale.Value;
        }

        private void importButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Settings = new ObjImportSettings();
            bool oneSelected = (xFlip.Checked && !yFlip.Checked && !zFlip.Checked) || (!xFlip.Checked && yFlip.Checked && !zFlip.Checked) || (!xFlip.Checked && !yFlip.Checked && zFlip.Checked);
            bool threeSelected = (xFlip.Checked && yFlip.Checked && !zFlip.Checked) || (!xFlip.Checked && yFlip.Checked && zFlip.Checked) || (xFlip.Checked && !yFlip.Checked && zFlip.Checked);
            Settings.ReverseFaces = (oneSelected || threeSelected) ^ flipFacesCheck.Checked;
            Settings.ScaleX = (float)xScale.Value * (xFlip.Checked ? -1.0f : 1.0f) * (unitBaseMetric.Checked ? 2.54f : 1.0f);
            Settings.ScaleY = (float)yScale.Value * (yFlip.Checked ? -1.0f : 1.0f) * (unitBaseMetric.Checked ? 2.54f : 1.0f);
            Settings.ScaleZ = (float)zScale.Value * (zFlip.Checked ? -1.0f : 1.0f) * (unitBaseMetric.Checked ? 2.54f : 1.0f);
            Settings.SwapAxes = yzSwap.Checked;
            Settings.MirrorU = uFlip.Checked;
            Settings.MirrorV = vFlip.Checked;
            Settings.CreateBone = withBone.Checked;

            if (storeSettings.Checked)
                SaveSettingsToXml();
            Close();
        }

        private void ObjImportSettingsForm_Load(object sender, EventArgs e)
        {
            bitmapActionSelect.SelectedIndex = 0;
            materialNameSelect.SelectedIndex = 0;
            LoadSettingsFromXml();
            
        }
    }
}
