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
    public partial class EditStudent : Form
    {
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
            string sql = "select name, gender, politics, age, location, class from tb_student where stuid = @stuid";
            using (MySqlConnection conn = Utils.GetConnection())
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@stuid", stuid);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    this.txtStuID.Text = stuid;
                    this.txtName.Text = reader.GetString(0);
                    _ = reader.GetString(1).Equals("M") ? this.rbtMale.Checked = true : this.rbtFemal.Checked = true;
                    this.comPolitics.SelectedIndex = reader.GetInt32(2);
                    this.numAge.Value = reader.GetInt32(3);
                    this.txtLocation.Text = reader.GetString(4);
                    // 设置学院和班级
                    string classid = reader.GetString(5);
                    using (MySqlConnection conn1 = Utils.GetConnection())
                    {
                        MySqlCommand cmd1 = new MySqlCommand("select depart from tb_class where id = @id", conn1);
                        cmd1.Parameters.AddWithValue("@id", classid);
                        int id = (int)cmd1.ExecuteScalar();
                        this.comDepart.SelectedValue = id;
                    }
                    this.comClass.SelectedValue = classid;
                }
                else
                {
                    // 保证学生不存在时无法修改
                    this.txtStuID.Text = string.Empty;
                }
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

        private void comDepart_SelectedValueChanged(object? sender, EventArgs e)
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

        private void EditStudent_Shown(object sender, EventArgs e)
        {
            this.txtSearch.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (this.txtStuID.Text == string.Empty) return;

            string sql = "update tb_student set name=@name, gender=@gender, politics=@politics, age=@age, location=@location, class=@class where stuid=@stuid";
            using (MySqlConnection conn = Utils.GetConnection())
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@name", this.txtName.Text.Trim());
                cmd.Parameters.AddWithValue("@gender", this.rbtMale.Checked ? "M" : "F");
                cmd.Parameters.AddWithValue("@politics", this.comPolitics.SelectedIndex);
                cmd.Parameters.AddWithValue("@age", this.numAge.Text.Trim());
                cmd.Parameters.AddWithValue("@location", this.txtLocation.Text.Trim());
                cmd.Parameters.AddWithValue("@class", this.comClass.SelectedValue);
                cmd.Parameters.AddWithValue("@stuid", this.txtStuID.Text);
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    MessageBox.Show("修改成功！", "提示");
                }
                else
                {
                    MessageBox.Show("修改失败！", "提示");
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.txtStuID.Text == string.Empty) { return; }
            string sql = "delete from tb_student where stuid = @stuid";
            using (MySqlConnection conn = Utils.GetConnection())
            {
                MySqlCommand cmd = new(sql, conn);
                cmd.Parameters.AddWithValue("@stuid", this.txtStuID.Text.Trim());
                DialogResult res = MessageBox.Show("您确定要删除吗？", "删除确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (res == DialogResult.OK)
                {
                    int rows = Convert.ToInt32(cmd.ExecuteNonQuery());
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
}
