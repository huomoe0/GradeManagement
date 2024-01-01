using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ClassBLL
    {
        private DAL.ClassDAL classDAL = new DAL.ClassDAL();
        public List<Model.Class> SelectAll()
        {
            return classDAL.SelectAll();
        }
        public List<Class> SelectByDepart(int id)
        {
            return classDAL.SelectByDepart(id);
        }
    }
}
