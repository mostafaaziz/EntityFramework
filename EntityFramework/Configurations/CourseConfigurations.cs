using EntityFramework.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Configurations
{
    internal class CourseConfigurations : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasMany(C => C.CourseInstructors)
                .WithOne()
                .HasForeignKey(CI => CI.Course_Id);

            builder.HasMany(C => C.CourseStudents)
                .WithOne()
                .HasForeignKey(CS => CS.CourseId);
        }
    }
}
