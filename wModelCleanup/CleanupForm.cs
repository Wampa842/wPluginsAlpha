using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using PEPlugin;
using PEPlugin.Pmx;
using PEPlugin.Pmd;

namespace wModelCleanup
{
    public partial class CleanupForm : Form
    {
        IPERunArgs args;
        public CleanupForm(IPERunArgs p_args)
        {
            InitializeComponent();
            args = p_args;
        }
    }
    public class IssueClass
    {
        public static string[] IssueDescription = new string[6]
        {
            "The issue has no apparent effect on the model or MMD.",
            "The issue may cause visual problems on the model, but it's otherwise unaffected.",
            "The issue can cause problems with how the model behaves in MMD.",
            "The issue will severely affect the model's appearance or behaviour in MMD.",
            "The issue can cause severe instability, performance issues or crashing in MMD.",
            "The issue will cause MMD to become unersponsive or crash immediately."
        };
        public enum IssueType : byte { None, Vertex, Normal, Face, Material, Bitmap, Bone, RigidBody, Joint, Group, SoftBody };
        public enum IssueSeverity : byte { None, Low, Medium, High, Critical, Fatal };

        public IssueSeverity Severity { get; set; }
        public IssueType Type { get; set; }
        public object Subject { get; set; }
        public string Name { get; set; }

    }
    
}
