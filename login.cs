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
            if (username.Equals("admin") || password.Equals("123"))
            {
                MainForm mainForm = new MainForm();
                this.Hide();
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("用户名或密码错误，请重新输入！", "提示");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
