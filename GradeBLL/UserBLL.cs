using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class UserBLL
    {
        public bool IsUser(Model.User user)
        {
            DAL.UserDAL user1 = new DAL.UserDAL();
            return user1.IsUser(user);
        }
    }
}
