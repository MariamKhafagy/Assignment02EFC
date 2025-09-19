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
    internal class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> D)
        {
            D.HasOne(E=>E.manager)
             .WithOne()
             .HasForeignKey<Department>(d=>d.Ins_ID)
             .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
