using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Entities
{
    internal class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Duration { get; set; }
        public string? Description { get; set; }
        [ForeignKey("Topic")]
        public int? Top_Id { get; set; }
        public Topic? Topic { get; set; }
        public ICollection<Student_Course>? CourseStudents { get; set; } = new HashSet<Student_Course>();
        public ICollection<Course_Instructor>? CourseInstructors { get; set; } = new HashSet<Course_Instructor>();

    }
}
