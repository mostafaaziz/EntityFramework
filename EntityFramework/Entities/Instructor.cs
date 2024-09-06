using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Entities
{
    internal class Instructor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double? Bonus { get; set; }
        public decimal Salary { get; set; }
        public int Hour_Rate { get; set; }
        public string? Address { get; set; }
        [ForeignKey("Department")]
        public int? Dept_Id { get; set; }
        [InverseProperty(nameof(Entities.Department.Instructors))]
        public Department? Department { get; set; }

        [InverseProperty(nameof(Entities.Department.Manager))]
        public Department? Manage { get; set; }
        public ICollection<Course_Instructor>? InstructorCourses { get; set; } = new HashSet<Course_Instructor>();
    }
}
