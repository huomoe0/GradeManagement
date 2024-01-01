using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Course
    {
        private int cid;
        private string cname;

        public int Cid { get { return cid; } set { cid = value; } }
        public string Cname { get { return cname; } set {  cname = value; } }

    }
}
