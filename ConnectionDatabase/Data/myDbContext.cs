using ConnectionDatabase.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConnectionDatabase.Data
{
    public class myDbContext : DbContext
    {
        public myDbContext(DbContextOptions<myDbContext> options) : base(options)
        {

        }
        public DbSet<Person> Person { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Person>(e => e.Property(o => o.Age).HasColumnType("tinyInt(3)").HasConversion<short>());
            modelBuilder.Entity<Person>(e => e.Property(o => o.IsPlayer).HasConversion(new BoolToZeroOneConverter<Int16>()).HasColumnType("bit"));
        }
    }
}
