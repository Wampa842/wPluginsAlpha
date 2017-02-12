using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

using PEPlugin;

namespace wBackup
{
    public class Main : IPEPlugin
    {
        string PluginName = "wBackup";

        public void Run(IPERunArgs args)
        {
            BackupForm MainForm = new BackupForm(args);
            MainForm.Show();
        }

        public string Name { get { return PluginName; } }

        public string Description { get { return "Automatic backup utility for PMX Editor"; } }

        public bool GetStartupSettings()
        {
            bool AutoStart;
            XmlDocument doc = new XmlDocument();
            string AssemblyPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            doc.Load(System.IO.Path.Combine(AssemblyPath, "settings.xml"));
            try
            {
                AutoStart = bool.Parse(doc.DocumentElement[PluginName]["AutoStart"].InnerText);

            }
            //Sorry about this.
            catch (Exception)
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

        public IPEPluginOption Option { get { return new Opt(PluginName, true, GetStartupSettings()); } }


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
