using Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeDAL
{
    public class User
    {
        public bool IsUser(Model.User user)
        {
            string sql = "select nickname from tb_user where username=@username and password=@password";
            // 参数数组
            MySqlParameter[] parameters = new MySqlParameter[]
            { new("@username", user.Username), new("@password", user.Password) };
            // 执行sql
            DataTable dt = SqlHelper.ExecuteDataTable(sql, CommandType.Text, parameters);
            if (dt.Rows.Count > 0)
            {
                user.Nickname = Convert.ToString(dt.Rows[0]["nickname"]);
                return true;
            }
            return false;
        }
    }
}
