namespace GradeManagement
{
    public partial class MainForm : Form
    {
        private string name;
        public MainForm(string name)
        {
            InitializeComponent();
            this.name = name;
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void tmrStudentGrade_Tick(object sender, EventArgs e)
        {
            this.tsslTime.Text = DateTime.Now.ToString();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.tsslInfo.Text = "ÄãºÃ: " + name;
            this.tmrStudentGrade.Enabled = true;
        }

        private void TJXSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStudent addForm = new AddStudent();
            addForm.Show();
        }

        private void TCXTXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
