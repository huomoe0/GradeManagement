using DAL;
using Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class GradeBLL
    {
        private GradeDAL gradeDAL = new GradeDAL();
        public bool AddStudentGrades(List<Grade> grades)
        {
            return gradeDAL.AddStudentGrades(grades);
        }

        public List<GradeView> SelectByClass(int classId, string term)
        {
            return gradeDAL.SelectByClass(classId, term);
        }
    }
}
