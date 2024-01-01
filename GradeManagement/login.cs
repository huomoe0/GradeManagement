using Model;

namespace GradeManagement
{
    public partial class LoginForm : Form
    {
        private BLL.UserBLL userBLL = new();
        // 用户登录成功事件
        public event Action<User> UserLoggedIn; 
        private void OnUserLoggedIn(User user)
        {
            UserLoggedIn?.Invoke(user);
        }
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
                this.textBox1.Focus();
            }
            else
            {
                User user = new(username, password);
                if (userBLL.IsUser(user))
                {
                    this.DialogResult = DialogResult.OK;
                    OnUserLoggedIn(user);
                }
                else
                {
                    MessageBox.Show("用户名或密码错误，请重新输入！", "登录信息");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
