using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

using INT422A1.Models;

namespace INT422A1
{
    public partial class PhoneContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite(@"Data Source=/data/Playground/DotNet/INT422A1/Phones.db;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Phone>(entity => 
            {
                entity.Property(e => e.Id).IsRequired();
                entity.Property(e => e.PhoneName).IsRequired();
                entity.Property(e => e.Manufacturer).IsRequired();
                entity.Property(e => e.DateReleased).IsRequired();
                entity.Property(e => e.MSRP).IsRequired();
                entity.Property(e => e.ScreenSize).IsRequired();
            });
        }
        public DbSet<Phone> Phones{ get; set; }

    }
}
