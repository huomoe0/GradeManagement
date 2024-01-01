using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Class
    {
        private int? id = null;
        private string name;
        private int depart;

        public string Name { get { return name; } set { name = value; } }
        public int Depart { get { return depart; } set { depart = value; } }
        public int? Id { get => id; set => id = value; }

        public Class(int? id, string name)
        {
            this.id = id;
            this.name = name;
        }
        public Class() { }
    }
}
