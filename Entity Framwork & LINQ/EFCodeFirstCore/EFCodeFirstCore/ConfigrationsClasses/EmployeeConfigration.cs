using EFCodeFirstCore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstCore.ConfigrationsClasses
{
    internal class EmployeeConfigration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(E => E.SSN);

            builder.Property(E => E.SSN)
                .IsRequired(true)
                .HasMaxLength(14)
                .HasAnnotation("MinLength", "14");

            builder.Property(E => E.FullName)
                .IsRequired(false)
                .HasColumnType("nvarchar")
                .HasMaxLength(50);

                
        }
    }
}
