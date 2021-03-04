using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class RentCarContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\ProjectsV13;Database=RentCar;Trusted_Connection=true");
        }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Color> Colors { get; set; }

        //Classlarımızı veritabanındaki tablo adlarından farklı tanımladığımızda classımızın hangi tabloya karşılık geldiğini belirtmek için aşağıdaki kod bloğunu kullanırız.
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //   // modelBuilder.HasDefaultSchema("dbo");
        //    modelBuilder.Entity<Color>().ToTable("Colors");
        //    modelBuilder.Entity<Color>().Property(c => c.ColorId).HasColumnName("ColorId");
        //    modelBuilder.Entity<Color>().Property(c => c.ColorName).HasColumnName("ColorName");
        //}
    }
}
