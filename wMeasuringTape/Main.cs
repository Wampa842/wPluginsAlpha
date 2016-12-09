using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PEPlugin;

namespace wMeasuringTape
{
    public class Main : IPEPlugin
    {
        public void Run(IPERunArgs args)
        {

        }

        public string Name { get { return "wMeasuringTape"; } }

        public string Description { get { return "Measure the distance between two points"; } }

        private class Opt : IPEPluginOption
        {
            public string RegisterMenuText { get { return "wMeasuringTape"; } }
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
