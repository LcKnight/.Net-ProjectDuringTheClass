using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StuManageSys
{
    class School
    {
        private int SchoolId;
        private string SchoolName;
        public School(int SchoolId, string SchoolName)
        {
            this.SchoolId = SchoolId;
            this.SchoolName = SchoolName;
        }
        public string[] ToStrings()
        {
            return new string[] { SchoolId.ToString(), SchoolName };
        }
    }
}
