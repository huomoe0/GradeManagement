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
    public class CollegeBLL
    {
        private CollegeDAL collegeDAL = new CollegeDAL();
        public List<College> SelectAll()
        {
            return collegeDAL.SelectAll();
        }
        public College SelectByClass(int classId)
        {
            return collegeDAL.SelectByClass(classId);
        }
    }
}
