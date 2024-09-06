using EntityFramework.Configurations;
using EntityFramework.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Contexts
{
    internal class ITIDbContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server =.; DataBase = ITIEFWorkshop; Trusted_Connection = True; Encrypt = False", options => options.UseDateOnlyTimeOnly());
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfiguration(new CourseConfigurations());
            //modelBuilder.ApplyConfiguration(new InstructorConfigurations());
            //modelBuilder.ApplyConfiguration(new StudentConfigurations());

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            modelBuilder.Entity<Course_Instructor>()
                 .HasKey(CI => new { CI.Course_Id, CI.Ins_Id });

            modelBuilder.Entity<Student_Course>()
                .HasKey(SC => new { SC.StudentId, SC.CourseId });


        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Student_Course> Student_Courses { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Course_Instructor> Course_Instructors { get; set; }
    }
}
