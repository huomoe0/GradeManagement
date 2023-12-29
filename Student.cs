using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeManagement
{
    internal class Student
    {
        private string stuid;
        private string name;
        private string gender;
        private string politics;
        private string age;
        private string nation;

        public Student(string stuid, string name, string gender, string politics, string age, string nation)
        {
            this.stuid = stuid;
            this.name = name;
            this.gender = gender;
            this.politics = politics;
            this.age = age;
            this.nation = nation;
        }
        public string Stuid { get {  return stuid; } }
        public string Name { get { return name; } }
        public string Gender { get {  return gender; } }
        public string Politics { get {  return politics; } }
        public string Nation { get {  return nation; } }
        public string Age { get { return age; } }
    }
}
