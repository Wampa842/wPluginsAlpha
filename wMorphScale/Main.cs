using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PEPlugin;

namespace wMorphScale
{
    public class Main : IPEPlugin
    {
        public void Run(IPERunArgs args)
        {
            MorphScaleForm Main = new MorphScaleForm(args);
            Main.Show();
        }

        public string Name { get { return "wMorphScale"; } }

        public string Description { get { return "Scale vertex and bone morphs"; } }

        private class Opt : IPEPluginOption
        {
            public string RegisterMenuText { get { return "wMorphScale"; } }
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
