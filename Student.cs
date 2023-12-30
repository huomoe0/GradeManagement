using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeManagement
{
    internal class Student(string stuid, string name, string gender, string politics, int age, string nation, int inclass)
    {
        private int? id;
        private string stuid = stuid;
        private string name = name;
        private string gender = gender;
        private string politics = politics;
        private int age = age;
        private string location = nation;
        private int inclass = inclass;

        public string Stuid { get {  return stuid; } }
        public string Name { get { return name; } }
        public string Gender { get {  return gender; } }
        public string Politics { get {  return politics; } }
        public string Location { get {  return location; } }
        public int Age { get { return age; } }
        public int Inclass { get {  return inclass; } }
    }
}
