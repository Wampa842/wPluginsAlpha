using System.Windows.Forms;

namespace wApplyMorph
{
    public partial class PleaseWaitForm : Form
    {
        public PleaseWaitForm()
        {
            InitializeComponent();
        }

        public void UpdateProgress(int prog, int min, int max)
        {
            progressBar1.Minimum = min;
            progressBar1.Maximum = max;
            progressBar1.Value = prog;

            progressLabel.Text = prog.ToString() + " / " + max.ToString();
        }
    }
}
