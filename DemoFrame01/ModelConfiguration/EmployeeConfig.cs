using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoFrame01.Models;
namespace DemoFrame01.ModelConfiguration
{
    internal class EmployeeConfig : IEntityTypeConfiguration<Employee>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Employee> builder)
        {
          builder.HasKey(E => E.Id);
            builder.Property(E => E.Id).UseIdentityColumn(1,1);
            builder.Property(E => E.Name).HasColumnName("EmployeeName").HasColumnType("varchar(50)").HasMaxLength(40).IsRequired(false);

            builder.OwnsOne(E => E.EmpAddres, Address => Address.WithOwner());
        }
    }
}
