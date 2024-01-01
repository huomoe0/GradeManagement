using Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class GradeDAL
    {
        public List<GradeView> SelectByClass(int classId, string term)
        {
            string sql = "SELECT tb_student.stuid, tb_student.name, @term AS term, tb_grade.score FROM tb_student LEFT JOIN tb_grade ON tb_student.stuid = tb_grade.stuid AND tb_grade.term = @term WHERE tb_student.class = @class";
            MySqlDataReader r = SqlHelper.ExecuteReader(sql, CommandType.Text, new MySqlParameter[] { new("@class", classId), new("@term", term) });
            List<GradeView> list = new List<GradeView>();
            while (r.Read())
            {
                int? score = r.IsDBNull(3) ? (int?)null : r.GetInt32(3);
                list.Add(new GradeView(r.GetString(0), r.GetString(1), r.GetString(2), score));
            }
            return list;
        }
        public bool AddStudentGrades(List<Grade> grades)
        {
            using MySqlConnection conn = SqlHelper.GetConnection();
            MySqlTransaction mt = conn.BeginTransaction();
            using MySqlCommand cmd = conn.CreateCommand();
            cmd.Transaction = mt;

            try
            {
                foreach (Grade g in grades)
                {
                    cmd.CommandText = "INSERT INTO tb_grade (stuid, cid, score, term) VALUES (@stuid, @cid, @score, @term) ON DUPLICATE KEY UPDATE score = VALUES(score)";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@stuid", g.Stuid);
                    cmd.Parameters.AddWithValue("@cid", g.Cid);
                    cmd.Parameters.AddWithValue("@score", g.Score);
                    cmd.Parameters.AddWithValue("@term", g.Term);
                    cmd.ExecuteNonQuery();
                }
                mt.Commit();
            }
            catch (Exception)
            {
                mt.Rollback();
                return false;
            }
            return true;
        }
    }
}
