using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CourseBLL
    {
        private DAL.CourseDAL courseDAL = new DAL.CourseDAL();
        public List<Model.Course> SelectAll()
        {
            return courseDAL.SelectAll();
        }
    }
}
