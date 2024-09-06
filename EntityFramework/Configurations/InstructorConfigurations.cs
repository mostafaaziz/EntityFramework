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
    internal class InstructorConfigurations : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> builder)
        {
            builder.HasMany(I => I.InstructorCourses)
                .WithOne()
                .HasForeignKey(CI => CI.Ins_Id);

            builder.Property(I => I.Salary)
                .HasColumnType("decimal(12,2)");
        }
    }
}
