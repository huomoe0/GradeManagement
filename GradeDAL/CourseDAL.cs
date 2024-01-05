using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
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
        public bool AddStudentCourse(Model.Course course)
        {
            using MySqlConnection conn = SqlHelper.GetConnection();
            using MySqlCommand cmd = conn.CreateCommand();
            try
            {
                cmd.CommandText = "insert into tb_course (cname) values(@cname)";
                cmd.Parameters.AddWithValue("@cname", course.Cname);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex) 
            { 
                return false;
            }
             return true;
        }
    }
}
