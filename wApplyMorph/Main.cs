using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PEPlugin;

namespace wApplyMorph
{
    public class Main : IPEPlugin
    {
        public void Run(IPERunArgs args)
        {

        }

        public string Name { get { return "wApplyMorph"; } }

        public string Description { get { return "Apply a morph (or its inverse) to the model within PMX Editor"; } }

        private class Opt : IPEPluginOption
        {
            public string RegisterMenuText { get { return "wApplyMorph"; } }
            public bool RegisterMenu { get { return true; } }
            public bool Bootup { get { return true; } }
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
