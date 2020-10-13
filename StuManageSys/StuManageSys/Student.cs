using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StuManageSys
{
    class Student
    {
        private int StudentId;
        private string StudentName;
        private int ClassId;
        private string Sex;
        private int Age;

        public int GetStudentId() { return StudentId; }
        public string GetStudentName() { return StudentName;}
        public int GetClassId() { return ClassId; }

        public string GetSex() { return Sex; }
        public int GetAge() { return Age; }
        public Student(int StudentId, string StudentName, int ClassId, string Sex, int Age)
        {
            this.StudentId = StudentId;
            this.StudentName = StudentName;
            this.ClassId = ClassId;
            this.Sex = Sex;
            this.Age = Age;
        }
        public string[] ToStrings()
        {
            return new string[] { StudentId.ToString(), StudentName, ClassId.ToString(), Sex, Age.ToString()};
        }
    }
}
