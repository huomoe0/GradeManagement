using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class StudentBLL
    {
        private StudentDAL studentDAL = new StudentDAL();
        public int DeleteById(int stuid)
        {
            return studentDAL.DeleteById(stuid);
        }
        public int Update(Student s)
        {
            return studentDAL.Update(s);
        }
        public List<Student> SelectByClass(int id)
        {
            return studentDAL.SelectByClass(id);
        }
        public int AddStudent(Student student)
        {
            return studentDAL.AddStudent(student);
        }
        public DataTable SelectStudentInfomation(int classID)
        {
            return studentDAL.SelectStudentInfomation(classID);
        }
        public Student? SelectById(string stuid)
        {
            return studentDAL.SelectById(stuid);
        }
    }
}
