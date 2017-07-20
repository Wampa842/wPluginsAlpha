using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;

using PEPlugin;

namespace wNameUtil
{

    public class Main : IPEPlugin
    {
        string PluginName = "wNameUtil";
        private string _prefsFilePath = Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), "wNameUtil.cfg");
        public void Run(IPERunArgs args)
        {
            NameUtilForm mainForm = new NameUtilForm(args);
            mainForm.Show();
        }

        public string Name { get { return PluginName; } }

        public string Description { get { return "Merge materials based on similar properties"; } }


        public bool GetAutoStartSetting()
        {
            bool autoStart = false;
            using (StreamReader read = new StreamReader(_prefsFilePath))
            {
                while (!read.EndOfStream)
                {
                    string line = read.ReadLine();
                    if (string.IsNullOrWhiteSpace(line) || line.Trim()[0] == '#')
                        continue;
                    string[] kvp = line.Split('=');
                    string key = kvp[0].Trim().ToLowerInvariant();
                    string value = kvp[1].Trim().ToLowerInvariant();

                    if(key == "autostart")
                    {
                        bool.TryParse(value, out autoStart);
                    }
                }
            }

            return autoStart;
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
