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
        //pluginList is where all settings are stored in key-value pairs. Key is the internal name of the plugin, which is also used as the element name in the XML file.
        //PluginSettings is a class that contains the plugin's ID and the list of settings in KVPs, where the key is the option name used in the XML file, 
        //and the value is a class that contains the type and value. All actual types are strings that are parsed where needed - FormatExceptions should be handled even if they're unlikely.
        //Dictionary<string, PluginSettings> Settings = new Dictionary<string, PluginSettings>();

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
                    //Settings.Add(Name, SettingsForThis);
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

                    foreach (KeyValuePair<string, PluginSettings> s in pluginList.Items)    //Plugin
                    {
                        xml.WriteStartElement(s.Key);

                        foreach(KeyValuePair<string, OptionEntry> o in s.Value.Options) //Option
                        {
                            xml.WriteStartElement(o.Key);
                            xml.WriteAttributeString("type", o.Value.Type.ToLowerInvariant());
                            xml.WriteString(o.Value.Value.ToLowerInvariant());
                            xml.WriteEndElement();
                        }

                        xml.WriteEndElement();
                    }
                    xml.WriteEndElement();
                    xml.WriteEndDocument();
                    Unsaved = false;
                }
            }
            catch (Exception ex) when (ex is UnauthorizedAccessException || ex is IOException)
            {
                MessageBox.Show("Could not write to the settings file.\nMake sure you have permission to write there, and that the file is not read-only.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateOptionList(ref ListView list, string name)
        {
            list.Items.Clear();
            //PluginSettings pluginSettings = Settings[pluginList.Text];
            PluginSettings pluginSettings = ((KeyValuePair<string, PluginSettings>)(pluginList.Items[pluginList.FindString(name)])).Value;
            foreach (KeyValuePair<string, OptionEntry> option in pluginSettings.Options)
            {
                ListViewItem listItem = new ListViewItem();
                listItem.Text = option.Key;
                ListViewItem.ListViewSubItem listItemValue = new ListViewItem.ListViewSubItem(listItem, option.Value.Value);
                ListViewItem.ListViewSubItem listItemType = new ListViewItem.ListViewSubItem(listItem, option.Value.Type);
                listItem.SubItems.Add(listItemValue);
                listItem.SubItems.Add(listItemType);
                list.Items.Add(listItem);
            }
        }

        private void PluginSettingsForm_Load(object sender, EventArgs e)
        {
            pluginList.DisplayMember = "Key";
            ReadPlugins();
            //if(!((KeyValuePair<string, PluginSettings>)pluginList.Items[pluginList.FindString("wPluginsSettings")]).Value.StoreSettings)
            if(((KeyValuePair<string, PluginSettings>)(pluginList.Items[pluginList.FindString("wPluginsSettings")])).Value.Options["SurveyComplete"].Value.ToLowerInvariant() == "false")
            {
                UsageReportForm report = new UsageReportForm();
                report.Show();
                ((KeyValuePair<string, PluginSettings>)(pluginList.Items[pluginList.FindString("wPluginsSettings")])).Value.Options["SurveyComplete"].Value = "true";
                WriteSettingsToFile(SettingsFile);
            }
        }

        private void pluginList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedName = ((KeyValuePair<string, PluginSettings>)pluginList.SelectedItem).Key;
            PluginSettings SelectedSettings = ((KeyValuePair<string, PluginSettings>)pluginList.SelectedItem).Value;
            settingsGroupBox.Text = "Settings for " + selectedName + " (double click to edit)";

            //Load settings and populate the list
            UpdateOptionList(ref optionList, selectedName);
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
            //((KeyValuePair<string, PluginSettings>)pluginList.SelectedItem).Value.AutoStart = autoStartCheck.Checked;
        }

        private void storeSettingsCheck_CheckedChanged(object sender, EventArgs e)
        {
            Unsaved = true;
            //((KeyValuePair<string, PluginSettings>)pluginList.SelectedItem).Value.StoreSettings = storeSettingsCheck.Checked;
        }

        private void saveSettingsButton_Click(object sender, EventArgs e)
        {
            WriteSettingsToFile(SettingsFile);
        }

        private void revertSettingsButton_Click(object sender, EventArgs e)
        {
            pluginList.Items.Clear();
            optionList.Items.Clear();
            ReadPlugins();
        }

        private void sendStatisticsReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsageReportForm report = new UsageReportForm();
            report.Show();
        }

        private void optionList_DoubleClick(object sender, EventArgs e)
        {
            EditOptionForm editOption = new EditOptionForm();
            //editOption.ShowDialog();
            ListViewItem selectedItem = ((ListView)sender).SelectedItems[0];
            if (editOption.EditString(selectedItem.Text, selectedItem.SubItems[1].Text, selectedItem.SubItems[2].Text) == DialogResult.OK)
            {
                ((KeyValuePair<string, PluginSettings>)(pluginList.SelectedItem)).Value.Options[selectedItem.Text].Value = editOption.ReturnString;
                UpdateOptionList(ref optionList, ((KeyValuePair<string, PluginSettings>)(pluginList.SelectedItem)).Key);
            }
            editOption.Dispose();
        }
    }
}
