using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeManagement
{
    public partial class AddGrade : Form
    {
        private DataSet ds = new();
        public AddGrade()
        {
            InitializeComponent();
        }

        private void GetCourse()
        {
            string sql = "select cid, cname from tb_course";
            using (MySqlConnection conn = Utils.GetConnection())
            {
                MySqlDataAdapter mda = new(sql, conn);
                DataSet ds = new DataSet();
                mda.Fill(ds);
                this.cboCourse.DataSource = ds.Tables[0];
                this.cboCourse.DisplayMember = "cname";
                this.cboCourse.ValueMember = "cid";
            }
        }
        private void GetClass()
        {
            string sql = "select id, name from tb_class";
            using (MySqlConnection conn = Utils.GetConnection())
            {
                MySqlDataAdapter mda = new(sql, conn);
                DataSet ds = new DataSet();
                mda.Fill(ds);
                this.cboClass.DataSource = ds.Tables[0];
                this.cboClass.DisplayMember = "name";
                this.cboClass.ValueMember = "id";
            }
        }


        private void AddGrade_Load(object sender, EventArgs e)
        {
            GetCourse();
            GetClass();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ds.Clear();
            int id = (int)this.cboClass.SelectedValue;
            string sql = "select stuid, name from tb_student where class = @class";
            using (MySqlConnection conn = Utils.GetConnection())
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@class", id);
                MySqlDataAdapter mda = new(cmd);
                mda.Fill(ds);
                this.dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            string term = this.txtTerm.Text.Trim();
            if (term.Length == 0) { MessageBox.Show("请输入学期"); return; }

            int cid = (int)this.cboCourse.SelectedValue;
            List<string> sqls = new List<string>();
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                string sid = (string)dataGridView1.Rows[r.Index].Cells[1].Value;
                string grade = (string)dataGridView1.Rows[r.Index].Cells[0].Value;
                // 如果学生成绩为空则不添加
                if (grade == null) continue;

                string sql = string.Format("insert into tb_grade(stuid, cid, grade, term) values ({0},{1},{2},{3}) ON DUPLICATE KEY UPDATE grade = VALUES(grade)"
                    , sid, cid, grade, term);
                sqls.Add(sql);
            }

            using (MySqlConnection conn = Utils.GetConnection())
            {
                // 开启事务
                MySqlTransaction mt = conn.BeginTransaction();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.Transaction = mt;

                try
                {
                    // 执行命令
                    foreach (string sql in sqls)
                    {
                        cmd.CommandText = sql;
                        cmd.ExecuteNonQuery();
                    }
                    // 提交事务
                    mt.Commit();
                    MessageBox.Show("学生成绩添加成功！", "添加学生成绩");
                }
                catch (Exception ex)
                {
                    mt.Rollback();
                    MessageBox.Show("SQL执行错误: " + ex.Message);
                }
            }
        }
    }
}
