using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBLL
{
    public class User
    {
        public bool IsUser(Model.User user)
        {
            GradeDAL.User user1 = new GradeDAL.User();
            return user1.IsUser(user);
        }
    }
}
