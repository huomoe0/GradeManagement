using Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ClassDAL
    {
        public List<Class> SelectAll()
        {
            string sql = "select id, name from tb_class";
            DataTable dt = SqlHelper.ExecuteDataTable(sql);
            List<Class> list = SqlHelper.ConvertDataTableToList<Class>(dt);
            return list;
        }
        public List<Class> SelectByDepart(int id)
        {
            string sql = "select id, name from tb_class where depart = @id";
            MySqlDataReader reader = SqlHelper.ExecuteReader(sql, CommandType.Text, new MySqlParameter[] { new("@id", id) });
            List<Class> list = new List<Class>();
            while (reader.Read())
            {
                list.Add(new Class(reader.GetInt32(0), reader.GetString(1)));
            }
            return list;
        }
    }
}
