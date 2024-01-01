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
    public class CollegeDAL
    {
        public List<College> SelectAll()
        {
            string sql = "select id, name from tb_college";
            DataTable dataTable = SqlHelper.ExecuteDataTable(sql);
            List<College> colleges = SqlHelper.ConvertDataTableToList<College>(dataTable);
            return colleges;
        }
        public College? SelectByClass(int classId)
        {
            string sql = "select depart from tb_class where id = @id";
            MySqlDataReader reader = SqlHelper.ExecuteReader(sql, CommandType.Text, new MySqlParameter[] { new("@id", classId) });
            if (reader.Read())
            {
                College college = new College(classId, reader.GetString(0));
                return college;
            }
            return null;
        }
    }
}
