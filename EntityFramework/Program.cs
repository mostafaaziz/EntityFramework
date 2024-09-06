using EntityFramework.Contexts;
using EntityFramework.Entities;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //using ITIDbContext context = new ITIDbContext();

            #region CRUD Operations
            #region Insert
            //var std = new Student() {FName = "Mostafa", LName = "Aziz"};
            //context.Students.Add(std);

            //var dept = new Department() { Name = "IT"};
            //context.Departments.Add(dept);


            //var Ins = new Instructor() { Name = "Mohamed", Salary = 4_000, Hour_Rate = 200 };
            //context.Instructors.Add(Ins);

            //var top = new Topic() { Name = "BackEnd" };
            //context.Topics.Add(top);

            //var course = new Course() { Name = ".Net", Duration = 160, Description = "ASP.Net Programming"};
            //context.Courses.Add(course);

            //context.SaveChanges();

            //var inscrs = new Course_Instructor() { Course_Id = 2, Ins_Id = 2, Evaluate = 7 };
            //context.Add(inscrs);

            //var crsstd = new Student_Course() { CourseId = 2, StudentId = 2 };
            //context.Add(crsstd);

            //context.SaveChanges(); 
            #endregion

            #region Select
            //var dept = (from D in context.Departments
            //           where D.Id == 2
            //           select D).FirstOrDefault();

            //Console.WriteLine($"Department Name : {dept.Name}");

            //var Course = (from C in context.Courses
            //            where C.Id == 2
            //            select C).FirstOrDefault();

            //Console.WriteLine($"Course Name : {Course.Name}, Descripation: {Course.Description}");

            //var Topic = (from T in context.Topics
            //            where T.Id == 2
            //            select T).AsNoTracking().FirstOrDefault();

            //Console.WriteLine($"Topic Name : {Topic.Name}"); 
            #endregion

            #region Update
            //var crs = (from C in context.Courses
            //           where C.Id == 2
            //           select C).FirstOrDefault();

            //crs.Top_Id = 2;

            //context.SaveChanges();

            //var Course = (from C in context.Courses
            //              where C.Id == 2
            //              select C).FirstOrDefault();

            //Console.WriteLine($"Course Name : {Course.Name}, Descripation: {Course.Description}, Topic Id: {Course.Top_Id}"); 
            #endregion

            #region Delete
            //var Result = from CI in context.Course_Instructors
            //             where CI.Course_Id == 2
            //             select CI;

            //foreach (var crs_Ins in Result)
            //{
            //    context.Remove(crs_Ins);
            //}

            //context.SaveChanges(); 
            #endregion 
            #endregion
        }
    }
}
