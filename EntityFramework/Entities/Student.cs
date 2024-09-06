﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Entities
{
    internal class Student
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string? Address { get; set; }
        public int? Age { get; set; }
        [ForeignKey("Department")]
        public int? Dept_Id { get; set; }
        public Department? Department { get; set; }

        public ICollection<Student_Course>? StudentCourses { get; set; } = new HashSet<Student_Course>();

    }
}
