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
    internal class Course_InstConfiguration : IEntityTypeConfiguration<Course_Inst>
    {
        public void Configure(EntityTypeBuilder<Course_Inst> CI)
        {
            CI.ToTable("Course_Inst");

            CI.HasKey(ci => new { ci.ins_ID, ci.Course_ID });

            CI.HasOne(ci => ci.Instructor)
                   .WithMany()
                   .HasForeignKey(ci => ci.ins_ID);

            CI.HasOne(ci => ci.Course)
                   .WithMany()
                   .HasForeignKey(ci => ci.Course_ID);
        }
    }
}
