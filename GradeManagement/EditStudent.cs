using BLL;
using Model;
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
using System.Xml.Linq;

namespace GradeManagement
{
    public partial class EditStudent : Form
    {
        private StudentBLL studentBLL = new StudentBLL();
        private CollegeBLL collegeBLL = new CollegeBLL();
        private ClassBLL classBLL = new ClassBLL();
        public EditStudent()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            string stuid = this.txtSearch.Text.Trim();
            Student? student = studentBLL.SelectById(stuid);
            if (student != null)
            {
                this.txtStuID.Text = stuid;
                this.txtName.Text = student.Name;
                _ = student.Gender.Equals("M") ? this.rbtMale.Checked = true : this.rbtFemal.Checked = true;
                this.comPolitics.SelectedIndex = student.Politics;
                this.numAge.Value = student.Age;
                this.txtLocation.Text = student.Location;
                // 设置学院和班级
                int classid = student.Inclass;
                College college = collegeBLL.SelectByClass(classid);
                this.comDepart.SelectedValue = college.Id;
                this.comClass.SelectedValue = classid;
            }
            else
            {
                // 保证学生不存在时无法修改
                this.txtStuID.Text = string.Empty;
            }

        }

        private void EditStudent_Load(object sender, EventArgs e)
        {
            FillCollege();
        }

        private void FillCollege()
        {
            // 数据绑定前解除事件，防止出现异常数据
            this.comDepart.SelectedValueChanged -= comDepart_SelectedValueChanged;
            List<College> colleges = collegeBLL.SelectAll();
            comDepart.DataSource = colleges;
            comDepart.DisplayMember = "name";
            comDepart.ValueMember = "id";
            //恢复事件，并主动触发事件更新
            this.comDepart.SelectedValueChanged += comDepart_SelectedValueChanged;
            comDepart_SelectedValueChanged(this.comDepart, new EventArgs());
        }

        private void comDepart_SelectedValueChanged(object? sender, EventArgs e)
        {
            if (comDepart.SelectedIndex < 0 || this.comDepart.SelectedValue == null)
                return;
            int id = (int)this.comDepart.SelectedValue;
            List<Class> classes = classBLL.SelectByDepart(id);
            comClass.DataSource = classes;
            comClass.DisplayMember = "name";
            comClass.ValueMember = "id";
        }

        private void EditStudent_Shown(object sender, EventArgs e)
        {
            this.txtSearch.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (this.txtStuID.Text == string.Empty) return;

            Student s = new Student();
            s.Name = this.txtName.Text.Trim();
            s.Stuid = this.txtStuID.Text.Trim();
            s.Politics = this.comPolitics.SelectedIndex;
            s.Age = Convert.ToInt32(this.numAge.Value);
            s.Location = this.txtLocation.Text.Trim();
            s.Gender = this.rbtMale.Checked ? "M" : "F";
            s.Inclass = Convert.ToInt32(this.comClass.SelectedValue);
            int rows = studentBLL.Update(s);
            if (rows > 0)
            {
                MessageBox.Show("修改成功！", "提示");
            }
            else
            {
                MessageBox.Show("修改失败！", "提示");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.txtStuID.Text == string.Empty) { return; }

            DialogResult res = MessageBox.Show("您确定要删除吗？", "删除确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (res == DialogResult.OK)
            {
                int rows = studentBLL.DeleteById(Convert.ToInt32(this.txtStuID.Text));
                if (rows > 0)
                {
                    MessageBox.Show("学生信息删除成功！", "信息删除");
                    this.txtStuID.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("学生信息删除失败！", "信息删除");
                }
            }
        }
    }
}
