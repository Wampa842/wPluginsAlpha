using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PEPlugin;
using PEPlugin.Pmx;
using PEPlugin.Form;

namespace wAverageVertexPosition
{
    public class AverageVertexPlugin : IPEPlugin
    {
        public void Run(IPERunArgs args)
        {
            AverageVertexForm Main = new AverageVertexForm(args);
            Main.Show();
        }

        public string Name { get { return "wAverageVertexPosition"; } }

        public string Description { get { return "Unifies vertices without welding them"; } }

        private class Opt : IPEPluginOption
        {
            public string RegisterMenuText { get { return "wAverageVertexPosition"; } }
            public bool RegisterMenu { get { return true; } }
            public bool Bootup { get { return false; } }
        }

        public IPEPluginOption Option { get { return new Opt(); } }


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
