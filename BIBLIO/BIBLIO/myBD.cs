namespace BIBLIO
{
    public partial class myBD : Form
    {
        public myBD()
        {
            InitializeComponent();
        }

        private void âèõ³äToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ïğîĞîãğàìóToolStripMenuItem_Click(object sender, EventArgs e)
        {
            about f1 = new about();
            f1.ShowDialog();
        }

        private void êàëüêóëÿòîğToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calculator f2 = new Calculator();
            f2.ShowDialog();
        }

        private void myBD_Load(object sender, EventArgs e)
        {

        }

        private void myBD_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}