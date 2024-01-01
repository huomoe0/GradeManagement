using Model;

namespace GradeManagement
{
    public partial class MainForm : Form
    {
        private User currentUser;
        public void HandleUserLoggedIn(User user)
        {
            this.currentUser = user;
        }
        public MainForm()
        {
            InitializeComponent();
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
            this.tsslInfo.Text = "ÄãºÃ: " + currentUser.Nickname;
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

        private void SJBFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DBBackupForm backup = new();
            backup.ShowDialog();
        }

        private void BJXSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditStudent editStudent = new EditStudent();
            editStudent.Show();
        }

        private void CXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BrowseStudent browseStudent = new BrowseStudent();
            browseStudent.Show();
        }

        private void TJCJToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddGrade addGrade = new AddGrade();
            addGrade.Show();
        }
    }
}
