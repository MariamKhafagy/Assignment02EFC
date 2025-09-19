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
    internal class CourseConfiruration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> D)
        {
            D.ToTable("Courses");

            // Primary Key
            D.HasKey(c => c.ID);

            D.Property(c => c.ID)
             .HasColumnName("CourseId")
             .UseIdentityColumn(1, 1);

            // Name column
            D.Property(c => c.Name)
             .IsRequired()
             .HasMaxLength(100)
             .HasColumnType("varchar")
             .HasDefaultValue("Untitled Course");

            // Description column
            D.Property(c => c.Description)
             .HasMaxLength(250)
             .HasColumnType("varchar");

            // Duration column
            D.Property(c => c.Duration)
             .HasColumnType("int")
             .HasDefaultValue(30);

            // Top_ID column
            D.Property(c => c.Top_ID)
             .HasColumnName("TopicId")
             .HasColumnType("int");

            D.HasOne(E=>E.topic)
             .WithMany(d=>d.Courses)
             .HasForeignKey(e => e.Top_ID)
             .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
