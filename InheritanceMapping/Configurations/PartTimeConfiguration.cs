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
    internal class PartTimeConfiguration : IEntityTypeConfiguration<PartTime>
    {
        public void Configure(EntityTypeBuilder<PartTime> builder)
        {
            builder.Property(F => F.HourRate)
                .HasColumnType("decimal(18,2)");
        }
    }
}
