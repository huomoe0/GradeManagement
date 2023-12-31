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
            FillCollege(); // 添加学院
            this.txtStuID.Focus();
            this.rbtMale.Checked = true;
            this.comPolitics.SelectedIndex = 0;
        }
        private void FillCollege()
        {
            // 数据绑定前解除事件，防止出现异常数据
            this.comDepart.SelectedValueChanged -= comDepart_SelectedValueChanged;
            string sql = "select id, name from tb_college";
            using (MySqlConnection conn = Utils.GetConnection())
            {
                DataSet ds = new DataSet();
                MySqlDataAdapter mda = new(sql, conn);
                mda.Fill(ds);
                comDepart.DataSource = ds.Tables[0];
                comDepart.DisplayMember = "name";
                comDepart.ValueMember = "id";
            }
            //恢复事件，并主动触发事件更新
            this.comDepart.SelectedValueChanged += comDepart_SelectedValueChanged;
            comDepart_SelectedValueChanged(this.comDepart, new EventArgs());
        }
        private void comDepart_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comDepart.SelectedIndex < 0 || this.comDepart.SelectedValue == null)
                return;

            int id = (int)this.comDepart.SelectedValue;

            string sql = "select id, name from tb_class where depart = @id";
            using (MySqlConnection conn = Utils.GetConnection())
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

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string stuid = this.txtStuID.Text;
            string name = this.txtName.Text;
            string gender = this.rbtMale.Checked ? "M" : "F";
            int politics = this.comPolitics.SelectedIndex;
            int age = (int)this.numAge.Value;
            int inclass = (int)this.comClass.SelectedValue;
            string location = this.txtLocation.Text;

            string sql = "insert into tb_student (stuid, name, gender, politics, age, location, class) " +
                "values(@stuid, @name, @gender, @politics, @age, @location, @class)";
            using (MySqlConnection conn = Utils.GetConnection())
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@stuid", stuid);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@gender", gender);
                cmd.Parameters.AddWithValue("@politics", politics);
                cmd.Parameters.AddWithValue("@age", age);
                cmd.Parameters.AddWithValue("@location", location);
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
