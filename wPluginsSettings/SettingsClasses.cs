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
        //---Public members
        public struct OptionEntry
        {
            public string Type;    //stored in the type attribute
            public string Value;   //stored between tags
        }
        public int ID;
        public Dictionary<string, OptionEntry> Options;

        //---Constructors
        private void ReadSettingsFromXml(string path, string name)
        {
            try
            {
                XmlDocument xml = new XmlDocument();
                xml.Load(path); //IOException can be thrown
                XmlNode node = xml.DocumentElement[name];    //NullReferenceException can be thrown if settings for <name> do not exist in the file
                //"node" is the XML element containing the settings nodes for "name"
                Options = new Dictionary<string, OptionEntry>();

                foreach(XmlNode s in node)
                {
                    OptionEntry optionEntry = new OptionEntry();
                    optionEntry.Type = s.Attributes["type"].InnerText;
                    optionEntry.Value = s.InnerText;
                    Options.Add(s.Name,optionEntry);
                }
            }
            catch (Exception ex) when (ex is UnauthorizedAccessException || ex is IOException)
            {
                MessageBox.Show("Error: can't read from the file at: \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public PluginSettings(string path, string name, int number)
        {
            ReadSettingsFromXml(path, name);
            ID = number;
        }
        public PluginSettings(int number)
        {
            ID = number;
        }
    }
}
