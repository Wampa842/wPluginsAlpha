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
using PEPlugin.View;
using PEPlugin.SDX;

namespace wAverageVertexPosition
{
    public partial class MainForm : Form
    {
        IPERunArgs Args;
        public MainForm(IPERunArgs p_args)
        {
            Args = p_args;
            InitializeComponent();
        }

        bool IsWithinRange(V3 v1, V3 v2, float range)
        {
            V3 Dist = v1 - v2;
            if (Dist.Length() <= range) return true;
            else return false;
        }

        V3 Average(List<V3> vectors)
        {
            V3 Sum = new V3();
            int Count = 0;
            foreach(V3 v in vectors)
            {
                Sum += v;
                Count++;
            }
            return (Sum / Count);
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            IPXPmx Scene = Args.Host.Connector.Pmx.GetCurrentState();
            float Range = (float)ThresholdNumber.Value;

            //Get a list of selected vertices
            int[] SelectedIndex = Args.Host.Connector.View.PMDView.GetSelectedVertexIndices();
            List<IPXVertex> Vertices = new List<IPXVertex>();
            List<int> Matched = new List<int>();

            foreach (int i in SelectedIndex)
            {
                Vertices.Add(Scene.Vertex[i]);
            }

            for(int i = 0; (i < Vertices.Count()); ++i)
            {
                if (!Matched.Contains(i))
                {
                    List<int> Group = new List<int>();
                    Group.Add(i);
                    for (int j = 0; (j < Vertices.Count()); ++j)
                    {
                        if (!Matched.Contains(j) && IsWithinRange(Vertices[i].Position, Vertices[j].Position, Range))
                        {
                            Group.Add(j);
                        }
                    }
                    V3 Sum = new V3();
                    foreach(int k in Group) Sum += Vertices[k].Position;
                    foreach (int k in Group)
                    {
                        Scene.Vertex[k].Position = Sum / Group.Count;
                        Matched.Add(k);
                    }
                }
            }
            Args.Host.Connector.Pmx.Update(Scene);
        }
    }
}
