using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml;

namespace wPluginsSettings
{
    //Base class
    public class PluginSettings
    {
        private void ReadSettingsFromXml(string path, string name)
        {
            try
            {
                XmlDocument xml = new XmlDocument();
                xml.Load(path); //IOException can be thrown
                XmlElement node = xml.DocumentElement[name];    //NullReferenceException can be thrown if settings for <name> do not exist in the file

                if (!bool.TryParse(node.Attributes["autostart"].InnerText, out AutoStart)) AutoStart = false;
                if (!bool.TryParse(node.Attributes["store"].InnerText, out StoreSettings)) StoreSettings = false;
            }
            catch (NullReferenceException)
            {
                AutoStart = false;
                StoreSettings = false;
            }
            catch (Exception ex) when (ex is UnauthorizedAccessException || ex is IOException)
            {
                MessageBox.Show("Error: can't read from the file at: \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                AutoStart = false;
                StoreSettings = false;
            }
        }
        public PluginSettings(string path, string name, int number)
        {
            ReadSettingsFromXml(path, name);
            ID = number;
        }
        public PluginSettings(int number)
        {
            AutoStart = false;
            StoreSettings = false;
            ID = number;
        }
        public int ID;
        public bool AutoStart;
        public bool StoreSettings;
    }
}
