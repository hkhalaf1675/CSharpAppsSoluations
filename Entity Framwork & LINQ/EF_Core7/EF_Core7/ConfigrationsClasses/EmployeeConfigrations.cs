using EF_Core7.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core7.ConfigrationsClasses
{
    internal class FullTimeEmployeeConfigrations : IEntityTypeConfiguration<FullTimeEmployee>
    {
        // the fourth way of mapping class to tables
        public void Configure(EntityTypeBuilder<FullTimeEmployee> builder)
        {
            //builder.HasKey(E => E.EmpID);

            //builder.Property(E => E.FullName)
            //    .HasAnnotation("Display", "Name=Full Name");

            builder.Property(E => E.Salary)
                .HasColumnType("money");
        }
    }
}
