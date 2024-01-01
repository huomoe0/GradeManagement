using BLL;
using DAL;
using Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeManagement
{
    public partial class AddStudent : Form
    {
        private CollegeBLL collegeBLL = new CollegeBLL();
        private ClassBLL classBLL = new ClassBLL();
        private StudentBLL studentBLL = new StudentBLL();
        public AddStudent()
        {
            InitializeComponent();
        }

        private void AddStudent_Load(object sender, EventArgs e)
        {
            FillCollege(); // 添加学院
            this.txtStuID.Focus();
            this.rbtMale.Checked = true;
            this.comPolitics.SelectedIndex = 0;
        }
        private void FillCollege()
        {
            // 数据绑定前解除事件，防止出现异常数据
            this.comDepart.SelectedValueChanged -= comDepart_SelectedValueChanged;
            List<Model.College> colleges = collegeBLL.SelectAll();
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

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string stuid = this.txtStuID.Text;
            string name = this.txtName.Text;
            string gender = this.rbtMale.Checked ? "M" : "F";
            int politics = this.comPolitics.SelectedIndex;
            int age = Convert.ToInt32(this.numAge.Value);
            int inclass = Convert.ToInt32(this.comClass.SelectedValue);
            string location = this.txtLocation.Text;

            Student student = new(stuid, name, gender, politics, age, location, inclass);
            int rows = studentBLL.AddStudent(student);
            if (rows > 0)
            {
                MessageBox.Show("添加学生成功！", "信息提示", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("添加学生失败！", "信息提示", MessageBoxButtons.OK);
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

        
}

