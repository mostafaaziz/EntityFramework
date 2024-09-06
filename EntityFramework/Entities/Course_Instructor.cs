using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Entities
{
    internal class Course_Instructor
    {
        public int Ins_Id { get; set; }
        public int Course_Id { get; set; }
        public int Evaluate { get; set; }
    }
}
