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
        private const string OnlineCounterInfoText ="Would you like to send a usage report?\n\nIt's not actually a report, it\'s just a message to a website that counts how many such messages have been received.Other than the fact that the message was sent, absolutely nothing is logged, I give you my word.\nIf you're not convinced, you can press \"no\" and I won't bother you again.";
        IPERunArgs args;
        public PluginSettingsForm(IPERunArgs p_args)
        {
            args = p_args;
            InitializeComponent();
        }

        //Options
        private class WPluginOptionsClass
        {
            public WPluginOptionsClass(bool autoStart, bool storeSettings)
            {
                AutoStart = autoStart;
                StoreSettings = storeSettings;
            }
            public bool AutoStart { get; set; }
            public bool StoreSettings { get; set; }
        }
        private Dictionary<int, WPluginOptionsClass> PluginOptions;

        private void ReadSettingsXml(string path)
        {
            PluginOptions = new Dictionary<int, WPluginOptionsClass>();
            try
            {
                XmlDocument XmlSettingsFile = new XmlDocument();
                XmlSettingsFile.Load(path);
                XmlNode root = XmlSettingsFile.DocumentElement;
                foreach(KeyValuePair<string, int> plugin in RegisteredPlugins)
                {
                    try
                    {
                        XmlAttributeCollection attribs = root[plugin.Key].Attributes;
                        PluginOptions.Add(plugin.Value, new WPluginOptionsClass(bool.Parse(attribs["autostart"].InnerText), bool.Parse(attribs["store"].InnerText)));
                    }
                    catch (NullReferenceException)  //If anything goes wrong, exceptions are thrown and new settings are generated, which will be written to file later.
                    {
                        PluginOptions.Add(plugin.Value, new WPluginOptionsClass(false, false));
                        MessageBox.Show("New settings for " + plugin.Key + ": NRE");
                    }
                    catch (FormatException)
                    {
                        PluginOptions.Add(plugin.Value, new WPluginOptionsClass(false, false));
                        MessageBox.Show("New settings for " + plugin.Key + ": Format");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private WPluginOptionsClass ReadSettings(string path, string name)
        {
            XmlDocument xml = new XmlDocument();
            xml.Load(path);
            XmlAttributeCollection att = xml.DocumentElement[name].Attributes;

            return new WPluginOptionsClass(bool.Parse(att["autostart"].InnerText), bool.Parse(att["store"].InnerText));

        }

        //List of plugin names and their registration numbers
        private Dictionary<string, int> RegisteredPlugins;
        private Dictionary<string, int> ReadRegisteredPlugins()
        {
            Dictionary<string, int> Plugins = new Dictionary<string, int>();
            //This will have to be updated if I decide to make CPlugins.
            for(int i = 0; i < args.Host.Connector.System.RegisteredPluginCount; ++i)
            {
                string PluginName = args.Host.Connector.System.GetPluginInfo(i).Name;
                if (System.Text.RegularExpressions.Regex.IsMatch(PluginName, "w[A-Z]+"))
                    Plugins.Add(PluginName, i);
            }
            //Populate the list
            foreach (KeyValuePair<string, int> plugin in Plugins)
            {
                pluginList.Items.Add(plugin);
            }
            return Plugins;
        }

        private void PluginSettingsForm_Load(object sender, EventArgs e)
        {
            RegisteredPlugins = ReadRegisteredPlugins();
            //ReadSettingsXml(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\settings.xml");

        }

        private void pluginList_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
