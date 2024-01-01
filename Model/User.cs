using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class User
    {
        private int? id = null;
        private string username;
        private string password;
        private string nickname;

        public int? Id
        {
            get { return id; }
            set { id = value; }
        }
        public User(string username, string password, string nickname = "user")
        {
            this.username = username;
            this.password = password;
            this.nickname = nickname;
        }

        public string Username
        {
            get { return username; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("用户名不能为null或空白字符");
                username = value;
            }
        }

        public string Password
        {
            get { return password; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("密码不能为null或空白字符");
                password = value;
            }
        }

        public string Nickname
        {
            get { return nickname; }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 2)
                    throw new ArgumentException("昵称长度至少为2个字符");
                nickname = value;
            }
        }
    }

}
