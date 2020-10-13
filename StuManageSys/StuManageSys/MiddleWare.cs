using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;



namespace StuManageSys
{
    class MiddleWare
    {
        private List<Student> students;
        private List<Class> classes;
        private List<School> schools;
        private SqliteOp Op;

        public List<Student> GetStudents()
        {
            return this.students;
        }
        public List<Class> GetClasses()
        {
            return this.classes;
        }
        public List<School> GetSchools()
        {
            return this.schools;
        }
        public MiddleWare(string ConncetionString)
        {
            this.Op = new SqliteOp(ConncetionString);
            this.students = new List<Student>();
            this.classes = new List<Class>();
            this.schools = new List<School>();
        }
        public void FillLists()
        {
            SQLiteDataReader dbReaderStu = Op.ReadFullTable("Student");
            SQLiteDataReader dbReaderCla = Op.ReadFullTable("Class");
            SQLiteDataReader dbReaderSch = Op.ReadFullTable("School");

            while(dbReaderStu.Read())
            {
                
                int StudentId = dbReaderStu.GetInt32(dbReaderStu.GetOrdinal("StudentId"));
                string name = dbReaderStu.GetString(dbReaderStu.GetOrdinal("StudentName"));
                int ClassId = dbReaderStu.GetInt32(dbReaderStu.GetOrdinal("ClassId"));
                int Age = dbReaderStu.GetInt32(dbReaderStu.GetOrdinal("Age"));
                string Sex = dbReaderStu.GetString(dbReaderStu.GetOrdinal("Sex"));
                students.Add(new Student(StudentId, name, ClassId, Sex, Age));

            }
            while(dbReaderCla.Read())
            {
                int ClassId = dbReaderCla.GetInt32(dbReaderCla.GetOrdinal("ClassId"));
                int SchoolId = dbReaderCla.GetInt32(dbReaderCla.GetOrdinal("SchoolId"));
                int Nums = dbReaderCla.GetInt32(dbReaderCla.GetOrdinal("Nums"));
                string Major = dbReaderCla.GetString(dbReaderCla.GetOrdinal("Major"));
                int Grade = dbReaderCla.GetInt32(dbReaderCla.GetOrdinal("Grade"));
                classes.Add(new Class(ClassId, SchoolId, Nums, Major,Grade));

            }
            while (dbReaderSch.Read())
            {
                int SchoolId = dbReaderSch.GetInt32(dbReaderSch.GetOrdinal("SchoolId"));
                string SchoolName = dbReaderSch.GetString(dbReaderSch.GetOrdinal("SchoolName"));
                schools.Add(new School(SchoolId, SchoolName));
            }

        }
        public void Update<T>(T Object)
        {
            if(Object is Student stu)
            {

            }
            else if(Object is Class cla)
            {

            }
            else if(Object is School sch)
            {

            }
            else
            {
                throw new System.ArgumentException("Update 参数有误");
            }
        }
        public void Delete<T>(T Object)
        {
            if (Object is Student stu)
            {
                Op.DeleteValuesAnd("Student", new string[] { "StudentId", "StudentName", "ClassId", "Sex", "Age", }, stu.ToStrings(),new string[]{"=", "=", "=", "=", "="});
            }
            else if (Object is Class cla)
            {
                Op.DeleteValuesAnd("Class", new string[] { "ClassId", "SchoolId", "Nums", "Major", "Grade", }, cla.ToStrings(), new string[] { "=", "=", "=", "=", "=" });
            }
            else if (Object is School sch)
            {
                Op.DeleteValuesAnd("School", new string[] { "SchoolId", "SchoolName" }, sch.ToStrings(), new string[] { "=", "=" });
            }
            else
            {
                throw new System.ArgumentException("Delete 参数有误");
            }
        }
        public void Insert<T>(T Object)
        {
            if (Object is Student)
            {

            }
            else if (Object is Class)
            {

            }
            else if (Object is School)
            {

            }
            else
            {
                throw new System.ArgumentException("Insert 参数有误");
            }
        }

    }
}
