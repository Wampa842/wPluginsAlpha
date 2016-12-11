using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

using PEPlugin;

namespace wPluginsSettings
{
    public class Main : IPEPlugin
    {
        string PluginName = "wPluginsSettings";

        public void Run(IPERunArgs args)
        {

        }

        public string Name { get { return PluginName; } }

        public string Description { get { return ""; } }

        public bool GetAutoStartSetting()
        {
            bool AutoStart;
            XmlDocument Doc = new XmlDocument();
            string AssemblyPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            Doc.Load(System.IO.Path.Combine(AssemblyPath, "settings.xml"));
            try
            {
                AutoStart = bool.Parse(Doc.DocumentElement[PluginName].Attributes["autostart"].InnerText);
            }
            //Sorry about this.
            catch (Exception ex)
            {
                AutoStart = false;
            }
            return AutoStart;
        }

        private class Opt : IPEPluginOption
        {
            public Opt(string p_name, bool p_register, bool p_autostart)
            {
                RegisterMenu = p_register;
                Bootup = p_autostart;
                RegisterMenuText = p_name;
            }
            public string RegisterMenuText { get; set; }
            public bool RegisterMenu { get; set; }
            public bool Bootup { get; set; }
        }

        public IPEPluginOption Option { get { return new Opt(PluginName, true, GetAutoStartSetting()); } }


        public string Version
        {
            get
            {
                return System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public void Dispose()
        {
            ;
        }
    }
}
