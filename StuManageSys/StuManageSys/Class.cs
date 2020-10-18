using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StuManageSys
{
    class Class
    {
        private int ClassId;
        //学校Id
        private int SchoolId;
        //容纳人数
        private int Nums;
        //专业
        private string Major;
        //班长Id  
        //涉及到了两个表的互为外键 不好处理
        //private string MonitorId;
        //级别 例2018 2019 2020
        private int Grade;
        public Class(int ClassId, int SchoolId, int Nums, string Major,int Grade)
        {
            this.ClassId = ClassId;
            this.SchoolId = SchoolId;
            this.Nums = Nums;
            this.Major = Major;
            this.Grade = Grade;
        }
        public int GetClassId() { return ClassId; }
        public int GetSchoolId() { return SchoolId; }
        public int GetNums() { return Nums; }
        public string GetMajor() { return Major; }
        public int GetGrade() { return Grade; }
        public string[] ToStrings()
        {
            return new string[] { ClassId.ToString(), SchoolId.ToString(), Nums.ToString(), Major, Grade.ToString() };
        }
    }
}
