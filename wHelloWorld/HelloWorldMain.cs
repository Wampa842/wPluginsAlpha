/*
 * This example assumes the reader has a basic understanding of C# and the Visual Studio environment.
 *
 *
 * SETTING UP THE PROJECT
 * 
 * Create a new Class Library (dll) project.
 * In Solution Explorer, add a reference to PEPlugin.dll, and whatever other assemblies you need (I always add System.Windows.Forms).
 * You should open the Object Browser (double click on the PEPlugin reference) to familiarize yourself with the namespaces.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Enable using the PEPlugin namespace, and whatever else you need.
using PEPlugin; //Main namespace
using PEPlugin.Pmx; //PMX-specific interfaces
using PEPlugin.SDX; //SlimDX
using PEPlugin.Form;    //PMX Editor's user interface

namespace wHelloWorld
{
    //The main class of the plugin has to be derived from the PEPlugin.IPEPlugin interface.
    //Expect a ton of errors to appear.
    public class HelloWorldMain : IPEPlugin
    {

        //A plugin class has to implement six public members.

        //IPEPlugin.Run is the method called when the plugin is started. It can contain arbitrary code. Important data is passed in the IPERunArgs args parameter.
        public void Run(IPERunArgs args)
        {

            //For the sake of the tutorial, this plugin will display a message box with yes and no buttons, "Hello World" as title, and the model's name. If yes is clicked, it'll shift all vertices +100 units on the Y axis.
            IPXPmx Scene = args.Host.Connector.Pmx.GetCurrentState();
            string ModelName = Scene.ModelInfo.ModelName + " (" + Scene.ModelInfo.ModelNameE + ")";

            if (MessageBox.Show(ModelName, "Hello World!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //PMX classes do not store their indices. It's almost always better to use for instead of foreach because the iterator is easily accessible.
                for (int i = 0; i < Scene.Vertex.Count; ++i)
                {
                    Scene.Vertex[i].Position += new PEPlugin.SDX.V3(0f, 100f, 0f);  //V3 is a 3D vector implemented by SlimDX. It supports all arithmetic operations with scalars and vectors.
                }
            }
        }

        //The Name property passes a unique identifier to PMX Editor.
        public string Name { get { return "wHelloWorld"; } }

        //The Description property doesn't seem to have an effect. It can return an empty string.
        public string Description { get { return ""; } }

        //The Version property supplies version information as a string - again, doesn't seem to have an effect.
        //I like to return the assembly version here.
        public string Version { get { return System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString(); } }

        //The Option property has to return an instance of a class derived from IPEPluginOption.
        //It passes information about the way PMX should display the plugin.
        private class Opt : IPEPluginOption
        {
            public bool RegisterMenu { get; } = true;   //Whether or not the plugin should be listed at all
            public string RegisterMenuText { get; } = "wHelloWorld";    //The name that is listed in PMX
            public bool Bootup { get; } = false;    //If true, the plugin will be launched as soon as PMX Editor is running

            //You can also implement a constructor that gets these properties from arguments. They can be passed from other variables, or even methods.
            //I use it to read startup data from an XML file.
            public Opt(bool p_register, string p_name, bool p_autorun)
            {
                RegisterMenuText = p_name;
                RegisterMenu = p_register;
                Bootup = p_autorun;
            }
        }
        public IPEPluginOption Option { get { return new Opt(true, "wHelloWorld", false); } }

        //Dispose is required by the IDisposable interface. Not having it doesn't seem to affect usability.
        public void Dispose()
        {
            ;
        }
    }
}