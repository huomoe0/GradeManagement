using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeManagement
{
    public partial class AddCourse : Form
    {
        public AddCourse()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string course = this.textBox1.Text.Trim();
            if(course.Length == 0)
            {
                MessageBox.Show("请输入课程名"); return;
            }
            else
            {
                string sql = "insert into tb_course (cname) values (@course)";
                using (MySqlConnection conn = Utils.GetConnection())
                {
                    MySqlCommand cmd1 = new MySqlCommand(sql, conn);
                    cmd1.Parameters.AddWithValue("@course", course);
                    int rows = 0;
                    try
                    {
                        rows = cmd1.ExecuteNonQuery();
                    }
                    catch { }
                    if (rows > 0)
                    {
                        MessageBox.Show("添加课程成功！", "信息提示", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("添加课程失败！", "信息提示", MessageBoxButtons.OK);
                    }
                }
            }
        }
    }
}
