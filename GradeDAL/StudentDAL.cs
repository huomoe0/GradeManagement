using Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static Google.Protobuf.Reflection.SourceCodeInfo.Types;
using System.Xml.Linq;
using System.Data;

namespace DAL
{
    public class StudentDAL
    {
        public int DeleteById(int stuid)
        {
            string sql = "delete from tb_student where stuid = @stuid";
            int rows = SqlHelper.ExecuteNonQuery(sql, CommandType.Text, new MySqlParameter[]
            {
                new("@stuid", stuid)
            });
            return rows;
        }
        public int Update(Student s)
        {
            string sql = "update tb_student set name=@name, gender=@gender, politics=@politics, age=@age, location=@location, class=@class where stuid=@stuid";
            int rows = SqlHelper.ExecuteNonQuery(sql, CommandType.Text, new MySqlParameter[]
            {
                new("@name", s.Name),
                new("@gender", s.Gender),
                new("@politics", s.Politics),
                new("@age", s.Age),
                new("@location", s.Location),
                new("@class", s.Inclass),
                new("@stuid", s.Stuid)
            });
            return rows;
        }
        public Student? SelectById(string stuid)
        {
            string sql = "select name, gender, politics, age, location, class from tb_student where stuid = @stuid";
            MySqlDataReader reader = SqlHelper.ExecuteReader(sql, CommandType.Text, new MySqlParameter[] {new("@stuid", stuid)});
            if (reader.Read())
            {
                return new Student(stuid, reader.GetString(0), reader.GetString(1), reader.GetInt32(2), reader.GetInt32(3)
                , reader.GetString(4), reader.GetInt32(5));
            }
            return null;
        }
        public List<Student> SelectByClass(int classId)
        {
            string sql = "select stuid, name from tb_student where class = @class";
            System.Data.DataTable dataTable = SqlHelper.ExecuteDataTable(sql, CommandType.Text, new MySqlParameter[] { new("@class", classId) });
            List<Student> stus = SqlHelper.ConvertDataTableToList<Student>(dataTable);
            return stus;
        }

        public int AddStudent(Student student)
        {
            string sql = "insert into tb_student (stuid, name, gender, politics, age, location, class) " +
                "values(@stuid, @name, @gender, @politics, @age, @location, @class)";
            int rows = SqlHelper.ExecuteNonQuery(sql, System.Data.CommandType.Text, new MySqlParameter[]
            {
                new("@stuid", student.Stuid),
                new("@name", student.Name),
                new("@gender", student.Gender),
                new("@politics", student.Politics),
                new("@age", student.Age),
                new("@location", student.Location),
                new("@class", student.Inclass)
            });
            return rows;
        }

        public DataTable SelectStudentInfomation(int classID)
        {
            string sql = "select stuid, tb_student.name,case gender when 'M' THEN '男' when 'F' THEN '女' END as gender" +
                ",case politics when 0 then '中共党员' when 1 then '共青团员' when 2 then '学生' when 3 then '其他' end as politics," +
                " age, location, tb_class.name as className" +
                " from tb_student, tb_class where tb_student.class = tb_class.id and class = @class";
            DataTable dt = SqlHelper.ExecuteDataTable(sql, CommandType.Text, new MySqlParameter[] { new("@class", classID) });
            return dt;
        }
    }
}
