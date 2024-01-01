using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class GradeView
    {
        public string Stuid { get; set; }
        public string Name { get; set; }
        public int? Score { get; set; }
        public string Term { get; set; }
        public GradeView() { }

        public GradeView(string stuid, string name, string term, int? score)
        {
            Stuid = stuid;
            Name = name;
            Score = score;
            Term = term;
        }
    }
}
