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
        public AddStudent()
        {
            InitializeComponent();
        }

        private void AddStudent_Load(object sender, EventArgs e)
        {
            this.txtStuID.Focus();
            this.rbtMale.Checked = true;
            this.comNation.SelectedIndex = 0;
            FillCollege(); // 添加学院
        }
        private void FillCollege()
        {
            string sql = "select id, name from tb_college";
            using (MySqlConnection conn = Utils.getConnection())
            {
                DataSet ds = new DataSet();
                MySqlDataAdapter mda = new(sql, conn);
                mda.Fill(ds);
                comDepart.DataSource = ds.Tables[0];
                comDepart.DisplayMember = "name";
                comDepart.ValueMember = "id";
            }
        }
        private void comDepart_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comDepart.SelectedIndex < 0 || this.comDepart.SelectedValue == null)
                return;

            string? id = this.comDepart.SelectedValue.ToString();
            string sql = "select id, name from tb_class where depart = @id";
            using (MySqlConnection conn = Utils.getConnection())
            {
                DataSet ds = new DataSet();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("id", id);
                MySqlDataAdapter mda = new(cmd);
                mda.Fill(ds);
                comClass.DataSource = ds.Tables[0];
                comClass.DisplayMember = "name";
                comClass.ValueMember = "id";
            }
        }
        private string GetHobby()
        {
            string hobby = string.Empty;
            if (this.checkBox1.Checked) hobby = hobby + this.checkBox1.Text.Trim() + "、";
            if (this.checkBox2.Checked) hobby = hobby + this.checkBox2.Text.Trim() + "、";
            if (this.checkBox3.Checked) hobby = hobby + this.checkBox3.Text.Trim() + "、";
            if (this.checkBox4.Checked) hobby = hobby + this.checkBox4.Text.Trim() + "、";
            if (this.checkBox5.Checked) hobby = hobby + this.checkBox5.Text.Trim() + "、";
            if (hobby == string.Empty) return string.Empty;
            return hobby.Substring(0, hobby.Length-1);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string stuid = this.txtStuID.Text;
            string name = this.txtName.Text;
            string gender = this.rbtMale.Checked == true ? "男" : "女";
            string nation = this.comNation.Text;
            string age = Convert.ToString(this.numAge.Value);
            string depart = this.comDepart.SelectedValue.ToString().Trim();
            string inclass = this.comClass.SelectedValue.ToString().Trim();
            string location = this.txtLocation.Text;
            string hobby = GetHobby();

            string sql = "insert into tb_student (stuid, name, gender, politics, age, location, depart, class) " +
                "values(@stuid, @name, @gender, @politics, @age, @location, @depart, @class)";
            using (MySqlConnection conn = Utils.getConnection())
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@stuid", stuid);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@gender", gender);
                cmd.Parameters.AddWithValue("@politics", nation);
                cmd.Parameters.AddWithValue("@age", age);
                cmd.Parameters.AddWithValue("@location", location);
                cmd.Parameters.AddWithValue("@depart", depart);
                cmd.Parameters.AddWithValue("@class", inclass);
                int rows = 0;
                try
                {
                    rows = cmd.ExecuteNonQuery();
                }
                catch { }
                if (rows > 0)
                {
                    MessageBox.Show("添加学生成功！", "信息提示", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("添加学生失败！", "信息提示", MessageBoxButtons.OK);
                }
            }
        }
    }
}
