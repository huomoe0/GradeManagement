using BLL;
using Model;
using MySql.Data.MySqlClient;
using System.Data;

namespace GradeManagement
{
    public partial class AddGrade : Form
    {
        private CourseBLL courseBLL = new();
        private ClassBLL classBLL = new();
        private StudentBLL studentBLL = new();
        private GradeBLL gradeBLL = new();
        public AddGrade()
        {
            InitializeComponent();
        }

        private void AddGrade_Load(object sender, EventArgs e)
        {
            // 加载课程班级
            List<Course> courses = courseBLL.SelectAll();
            this.cboCourse.DataSource = courses;
            this.cboCourse.DisplayMember = "cname";
            this.cboCourse.ValueMember = "cid";
            List<Class> classes = classBLL.SelectAll();
            this.cboClass.DataSource = classes;
            this.cboClass.DisplayMember = "name";
            this.cboClass.ValueMember = "id";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (this.txtTerm.Text == string.Empty)
            {
                MessageBox.Show("请输入学期");
                return;
            }
            int id = Convert.ToInt32(this.cboClass.SelectedValue);
            List<GradeView> gradeViews = gradeBLL.SelectByClass(id, this.txtTerm.Text.Trim());
            this.dataGridView1.DataSource = gradeViews;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            string term = this.txtTerm.Text.Trim();
            if (term.Length == 0) { MessageBox.Show("请输入学期"); return; }
            int cid = Convert.ToInt32(this.cboCourse.SelectedValue);
            // 取得成绩列表
            List<Grade> grades = new();
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                // 如果学生成绩为空则不添加
                if (dataGridView1.Rows[r.Index].Cells[2].Value == null) continue;
                int score = Convert.ToInt32(dataGridView1.Rows[r.Index].Cells[2].Value);
                string sid = (string)dataGridView1.Rows[r.Index].Cells[0].Value;
                grades.Add(new Grade(Convert.ToInt32(sid), cid, score, term));
            }
            bool success = gradeBLL.AddStudentGrades(grades);
            if (success)
            {
                MessageBox.Show("学生成绩添加成功！", "添加学生成绩");
            }
            else
            {
                MessageBox.Show("学生成绩添加失败！", "添加学生成绩");
            }
        }
    }
}
