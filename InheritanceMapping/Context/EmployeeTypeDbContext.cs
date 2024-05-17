using InheritanceMapping.Configurations;
using InheritanceMapping.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceMapping.Context
{
    internal class EmployeeTypeDbContext:DbContext
    {
        #region OnConfiguring And connection string
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
          => optionsBuilder.UseSqlServer("Server =.;Database =KyrillosEmployeeType;Trusted_Connection = true;TrustServerCertificate = true");
        #endregion

        #region OnModelCreating to apply Configuration 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<FullTime>(new FullTimeConfiguration());
            modelBuilder.ApplyConfiguration<PartTime>(new PartTimeConfiguration());
        }
        #endregion

        #region Dbsets
        public DbSet<FullTime> FullTimeEmployees { get; set; }
        public DbSet<PartTime> PartTimeEmployees { get; set; }
        #endregion
    }
}
