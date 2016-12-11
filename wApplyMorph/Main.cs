using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

using PEPlugin;

namespace wApplyMorph
{
    public class Main : IPEPlugin
    {
        string PluginName = "wApplyMorph";
        public void Run(IPERunArgs args)
        {
            if (!args.Host.Connector.Form.PmxFormActivate)
            {
                MessageBox.Show("The legacy PMD Editor is not supported. Please use PMX Editor.\n\nThis plugin will now close.", "PMD Not Supported!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ApplyMorphForm MainForm = new ApplyMorphForm(args);
            MainForm.Show();
        }

        public string Name { get { return "wApplyMorph"; } }

        public string Description { get { return "Apply a morph (or its inverse) to the model within PMX Editor"; } }


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
