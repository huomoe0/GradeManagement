using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace GradeManagement
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = this.textBox1.Text.Trim();
            string password = this.textBox2.Text.Trim();
            if (username == string.Empty || password == string.Empty)
            {
                MessageBox.Show("用户名或密码为空！", "登录提示");
                return;
            }
            if (CheckUser(username, password))
            {
                MainForm mainForm = new MainForm(username);
                this.Hide();
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("用户名或密码错误，请重新输入！", "登录信息");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private bool CheckUser(string username, string password)
        {
            string SQL = "SELECT * FROM tb_user WHERE username = @Username AND password = @Password";
            // 建立连接
            using (MySqlConnection conn = Utils.GetConnection())
            {
                // 设置命令对象属性
                MySqlCommand cmd = new(SQL, conn);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);
                // 执行
                object result = cmd.ExecuteScalar();
                if (result != null)
                    return true;
                return false;
            }
        }
    }
}
