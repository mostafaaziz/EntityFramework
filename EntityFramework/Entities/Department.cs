using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Entities
{
    internal class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateOnly? Hiring_Date { get; set; }
        public ICollection<Student> Students { get; set; } = new HashSet<Student>();
        [ForeignKey("Manager")]
        public int? Ins_Id { get; set; }
        [InverseProperty(nameof(Instructor.Manage))]
        public Instructor? Manager { get; set; }

        [InverseProperty(nameof(Instructor.Department))]
        public ICollection<Instructor> Instructors { get; set; } = new HashSet<Instructor>();
    }
}
