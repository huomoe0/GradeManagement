using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Student
    {

        private int? id;
        private string stuid;
        private string name;
        private string gender;
        private int politics;
        private int age;
        private string location;
        private int inclass;

        public string Stuid { get { return stuid; } set { stuid = value; } }
        public string Name { get { return name; } set { name = value; } }
        public string Gender { get { return gender; } set { gender = value; } }
        public int Politics { get { return politics; } set { politics = value; } }
        public string Location { get { return location; } set { location = value; } }
        public int Age { get { return age; } set { age = value; } }
        public int Inclass { get { return inclass; } set { inclass = value; } }
        public Student(string stuid, string name, string gender, int politics, int age, string location, int inclass)
        {
            this.stuid = stuid;
            this.name = name;
            this.gender = gender;
            this.politics = politics;
            this.age = age;
            this.location = location;
            this.inclass = inclass;
        }
        public Student() { }
    }
}

