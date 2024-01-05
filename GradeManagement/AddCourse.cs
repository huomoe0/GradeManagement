using BLL;
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
    public partial class AddCourse : Form
    {
        private CourseBLL courseBLL = new();
        public AddCourse()
        {
            InitializeComponent();
        }

        private void AddCourse_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string course = this.textCourse.Text;
            if(course.Length == 0)
            {
                MessageBox.Show("请输入课程");
                return;
            }
            else
            {
                Model.Course course01 = new();
                course01.Cname = course;
                bool success = courseBLL.AddStudentCourse(course01);
                if (success) 
                {
                    MessageBox.Show("添加成功");
                }
                else
                {
                    MessageBox.Show("添加失败");
                }
            }
 
        }
    }
}
