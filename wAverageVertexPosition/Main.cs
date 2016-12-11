using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

using PEPlugin;
using PEPlugin.Pmx;
using PEPlugin.Form;

namespace wAverageVertexPosition
{
    public class AverageVertexPlugin : IPEPlugin
    {
        string PluginName = "wAverageVertexPosition";
        public void Run(IPERunArgs args)
        {
            AverageVertexForm Main = new AverageVertexForm(args);
            Main.Show();
        }

        public string Name { get { return "wAverageVertexPosition"; } }

        public string Description { get { return "Unifies vertices without welding them"; } }


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
            catch (FormatException)
            {
                return false;
            }
            catch (System.IO.FileNotFoundException)
            {
                return false;
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
