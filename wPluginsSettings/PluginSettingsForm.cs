using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml;

using PEPlugin;
using PEPlugin.Form;

namespace wPluginsSettings
{
    public partial class PluginSettingsForm : Form
    {
        bool Unsaved = false;
        IPERunArgs args;
        string SettingsFile = Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), "settings.xml");
        public PluginSettingsForm(IPERunArgs pArgs)
        {
            args = pArgs;
            InitializeComponent();
        }

        //This is when my body ran out of caffeine
        //Dictionary<string, PluginSettings> Plugins = new Dictionary<string, PluginSettings>();
        private void ReadPlugins()
        {
            Unsaved = false;
            //Plugins.Clear();
            pluginList.Items.Clear();
            IPESystemConnector sys = args.Host.Connector.System;
            for(int i = 0; i < sys.RegisteredPluginCount; ++i)
            {
                string Name = sys.GetPluginInfo(i).Name;
                if(System.Text.RegularExpressions.Regex.IsMatch(Name, @"^w[A-Z]\w+"))
                {
                    PluginSettings SettingsForThis = new PluginSettings(SettingsFile, Name, i);
                    //Plugins.Add(Name, SettingsForThis);
                    pluginList.Items.Add(new KeyValuePair<string, PluginSettings>(Name, SettingsForThis));
                }
            }
            pluginList.SetSelected(0, true);
        }

        private void WriteSettingsToFile(string path)
        {
            XmlWriterSettings XmlSettings = new XmlWriterSettings();
            XmlSettings.Indent = true;
            try
            {
                using (XmlWriter xml = XmlWriter.Create(path, XmlSettings))
                {
                    xml.WriteStartDocument();
                    xml.WriteStartElement("settings");

                    foreach (KeyValuePair<string, PluginSettings> s in pluginList.Items)
                    {
                        xml.WriteStartElement(s.Key);
                        xml.WriteAttributeString("autostart", s.Value.AutoStart.ToString().ToLowerInvariant());
                        xml.WriteAttributeString("store", s.Value.StoreSettings.ToString().ToLowerInvariant());
                        xml.WriteElementString("Verbose", "false");
                        xml.WriteEndElement();
                    }
                    xml.WriteEndElement();
                    xml.WriteEndDocument();
                    Unsaved = false;
                }
            }
            catch(Exception ex) when (ex is UnauthorizedAccessException || ex is IOException)
            {
                MessageBox.Show("Could not write to the settings file.\nMake sure you have permission to write there, and that the file is not read-only.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PluginSettingsForm_Load(object sender, EventArgs e)
        {
            pluginList.DisplayMember = "Key";
            ReadPlugins();
            if(!((KeyValuePair<string, PluginSettings>)pluginList.Items[pluginList.FindString("wPluginsSettings")]).Value.StoreSettings)
            {
                UsageReportForm report = new UsageReportForm();
                report.Show();
                ((KeyValuePair<string, PluginSettings>)pluginList.Items[pluginList.FindString("wPluginsSettings")]).Value.StoreSettings = true;
                WriteSettingsToFile(SettingsFile);
            }
        }

        private void pluginList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string SelectedName = ((KeyValuePair<string, PluginSettings>)pluginList.SelectedItem).Key;
            PluginSettings SelectedSettings = ((KeyValuePair<string, PluginSettings>)pluginList.SelectedItem).Value;
            settingsGroupBox.Text = "Settings for " + SelectedName;
            autoStartCheck.Checked = SelectedSettings.AutoStart;
            storeSettingsCheck.Checked = SelectedSettings.StoreSettings;
        }

        private void PluginSettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Unsaved)
            {
                DialogResult ExitConfirmation = MessageBox.Show("There are unsaved changes. Would you like to save before you exit?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                if (ExitConfirmation == DialogResult.Yes) WriteSettingsToFile(SettingsFile);
                else if (ExitConfirmation == DialogResult.Cancel) e.Cancel = true;
            }
        }

        private void autoStartCheck_CheckedChanged(object sender, EventArgs e)
        {
            Unsaved = true;
            ((KeyValuePair<string, PluginSettings>)pluginList.SelectedItem).Value.AutoStart = autoStartCheck.Checked;
        }

        private void storeSettingsCheck_CheckedChanged(object sender, EventArgs e)
        {
            Unsaved = true;
            ((KeyValuePair<string, PluginSettings>)pluginList.SelectedItem).Value.StoreSettings = storeSettingsCheck.Checked;
        }

        private void saveSettingsButton_Click(object sender, EventArgs e)
        {
            WriteSettingsToFile(SettingsFile);
        }

        private void revertSettingsButton_Click(object sender, EventArgs e)
        {
            ReadPlugins();
        }

        private void sendStatisticsReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsageReportForm report = new UsageReportForm();
            report.Show();
        }
    }
}
