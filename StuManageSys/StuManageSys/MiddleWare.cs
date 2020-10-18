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
            if (Op.GetExist() != 1)
                InitTable();
        }
        public void InitTable()
        {

            Op.CreateTable("Student", new string[] { "StudentId", "StudentName", "ClassId", "Age", "Sex" }, new string[] { "INT", "Text", "Int", "Int", "Text" });
            Op.CreateTable("Class", new string[] { "ClassId", "SchoolId", "Major", "Grade", "Nums" }, new string[] { "INT",  "Int", "Text","Int", "Int" });
            Op.CreateTable("School", new string[] { "SchoolId", "SchoolName" }, new string[] { "INT", "Text" });
            Op.InsertValues("Student", new string[] { "93", "王晨飞", "2", "19", "女" });
            Op.InsertValues("Student", new string[] { "94", "金泽辉", "7", "19", "男" });
            

            Op.InsertValues("Student", new string[] { "95", "王学良", "2", "19", "男" });
            Op.InsertValues("Student", new string[] { "96", "周龙", "2", "19", "男" });
            Op.InsertValues("Student", new string[] { "97", "司晗骞", "3", "19", "男" });

            Op.InsertValues("Class", new string[] { "2", "1", "电信", "18", "20" });
            Op.InsertValues("Class", new string[] { "3", "1", "电信", "18", "30" });
            Op.InsertValues("Class", new string[] { "6", "2", "文学", "18", "40" });
            Op.InsertValues("Class", new string[] { "7", "1", "计算机", "18", "37" });
            Op.InsertValues("Class", new string[] { "8", "1", "电信", "18", "25" });
            Op.InsertValues("Class", new string[] { "9", "3", "教育学", "19", "20" });
            Op.InsertValues("Class", new string[] { "10", "5", "博雅", "20", "20" });



            Op.InsertValues("School", new string[] { "1", "武汉大学" });
            Op.InsertValues("School", new string[] { "2", "华中科技大学" });
            Op.InsertValues("School", new string[] { "3", "华中师范大学" });
            Op.InsertValues("School", new string[] { "4", "清华大学" });
            Op.InsertValues("School", new string[] { "5", "北京大学" });
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
            if (Object is Student stu)
            {
                Op.InsertValues("Student", stu.ToStrings());
            }
            else if (Object is Class cla)
            {
                Op.InsertValues("Class", cla.ToStrings());
            }
            else if (Object is School sch)
            {
                Op.InsertValues("School", sch.ToStrings());
            }
            else
            {
                throw new System.ArgumentException("Insert 参数有误");
            }
        }

    }
}
