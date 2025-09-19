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
    internal class Stud_CourseConfiguration : IEntityTypeConfiguration<Stud_Course>
    {
        public void Configure(EntityTypeBuilder<Stud_Course> SC)
        {
            SC.ToTable("Stud_Course");

            SC.HasKey(sc => new { sc.stud_ID, sc.Course_ID });

            SC.HasOne(sc => sc.Student)
                   .WithMany()
                   .HasForeignKey(sc => sc.stud_ID);

            SC.HasOne(sc => sc.Course)
                   .WithMany()
                   .HasForeignKey(sc => sc.Course_ID);
        }
    }
}
