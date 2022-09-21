using System;
using EmptyMVC.Models;
using Microsoft.EntityFrameworkCore;


namespace EmptyMVC.DataAccess
{
    public class PhoneDbContext : DbContext
    {
        public PhoneDbContext(DbContextOptions<PhoneDbContext> option):base(option)
        {
            
        }

        public virtual DbSet<Category> Categories { get; set; } = null!;
        public virtual DbSet<Phone> Phones { get; set; } = null!;
        public virtual DbSet<Computer> Computers { get; set; } = null!;

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    if (!optionsBuilder.IsConfigured)
        //    {
        //        optionsBuilder.UseSqlServer("server=localhost,1433;database=Test;uid=sa;pwd=your_password123;");
        //    }
        //}

    }
}

