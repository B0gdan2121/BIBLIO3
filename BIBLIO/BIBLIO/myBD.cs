namespace BIBLIO
{
    public partial class myBD : Form
    {
        public myBD()
        {
            InitializeComponent();
        }

        private void �����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ����������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            about f1 = new about();
            f1.ShowDialog();
        }

        private void �����������ToolStripMenuItem_Click(object sender, EventArgs e)
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