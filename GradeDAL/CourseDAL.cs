using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CourseDAL
    {
        public List<Model.Course> SelectAll()
        {
            string sql = "select cid, cname from tb_course";
            DataTable dataTable = SqlHelper.ExecuteDataTable(sql);
            List<Model.Course> courses = SqlHelper.ConvertDataTableToList<Model.Course>(dataTable);
            return courses;
        }
    }
}
