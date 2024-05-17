using InheritanceMapping.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceMapping.Configurations
{
    internal class FullTimeConfiguration : IEntityTypeConfiguration<FullTime>
    {
        public void Configure(EntityTypeBuilder<FullTime> builder)
        {
            builder.Property(F => F.Salary)
                .HasColumnType("decimal(18,2)");

        }
    }
}
