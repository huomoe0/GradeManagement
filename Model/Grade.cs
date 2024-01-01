using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Grade
    {
        public int? Id { get; set; }
        public int Stuid { get; set; }
        public int Cid { get; set; }
        public int Score {  get; set; }
        public string Term { get; set; }

        public Grade(int stuid, int cid, int score, string term)
        {
            Stuid = stuid;
            Cid = cid;
            Score = score;
            Term = term;
        }
    }
}
