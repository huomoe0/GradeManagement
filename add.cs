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
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void AddStudent_Load(object sender, EventArgs e)
        {
            this.txtStuID.Focus();
            this.rbtMale.Checked = true;
            comDepart.Items.Add("信息工程学院");
            comDepart.Items.Add("机电工程学院");
            comDepart.Items.Add("通讯工程学院");
            comDepart.Items.Add("机械与自动化学院");
            comDepart.Items.Add("土木工程学院");
        }

        private void comDepart_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comDepart.SelectedIndex < 0)
            {
                return;
            }
            string department = this.comDepart.Text.Trim();
            if (department == "信息工程学院")
            {
                this.comClass.Items.Add("信息工程1班");
                this.comClass.Items.Add("信息工程2班");
            }
            else if (department == "机电工程学院")
            {
                this.comClass.Items.Add("机电工程1班");
                this.comClass.Items.Add("机电工程2班");
            }
            else if (department == "通讯工程学院")
            {
                this.comClass.Items.Add("通讯工程1班");
                this.comClass.Items.Add("通讯工程2班");
            }
            else if (department == "机械与自动化学院")
            {
                this.comClass.Items.Add("机械与自动化1班");
                this.comClass.Items.Add("机械与自动化2班");
            }
            else if (department == "土木工程学院")
            {
                this.comClass.Items.Add("土木工程1班");
                this.comClass.Items.Add("土木工程2班");
            }
        }
        private string GetHobby()
        {
            string hobby = "";
            if (this.checkBox1.Checked == true) hobby = hobby + this.checkBox1.Text.Trim() + "、";
            if (this.checkBox2.Checked == true) hobby = hobby + this.checkBox2.Text.Trim() + "、";
            if (this.checkBox3.Checked == true) hobby = hobby + this.checkBox3.Text.Trim() + "、";
            if (this.checkBox4.Checked == true) hobby = hobby + this.checkBox4.Text.Trim() + "、";
            if (this.checkBox5.Checked == true) hobby = hobby + this.checkBox5.Text.Trim() + "、";
            return hobby;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string stuid = this.txtStuID.Text;
            string name = this.txtName.Text;
            string gender = this.rbtMale.Checked == true ? "男" : "女";
            string nation = this.comNation.Text;
            string age = Convert.ToString(this.numAge.Value);
            string depart = this.comDepart.Text;
            string inclass = this.comClass.Text;
            string location = this.txtLocation.Text;
            string hobby = GetHobby();
            string stuinfo = "学号: " + stuid + " 姓名: " + name + " 性别: " + gender + "\n\n政治面貌: " + nation
                + " 年龄: " + age + "   院系: " + depart + "\n\n班级: " + inclass + " 籍贯: " + location
                + "\n\n兴趣爱好: " + hobby.Substring(0, hobby.Length - 1);
            MessageBox.Show(stuinfo, "学生信息");
        }
    }
}
