using Assignment_1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1.Configuration
{
    internal class InstructorConfigration : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> builder)
        {
            builder.HasOne(i => i.LearnInDepartment)
                 .WithMany(d => d.Instructors)
                 .HasForeignKey(i => i.Dept_ID)
                 .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
