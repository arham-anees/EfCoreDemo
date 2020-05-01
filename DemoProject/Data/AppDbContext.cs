using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoProject.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoProject.Data
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions options):base(options)
        {
            
        }



        public DbSet<cUser> Users { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<cUser>().Property(x => x.FirstName).IsRequired().HasMaxLength(30);
            modelBuilder.Entity<cUser>().Property(x => x.LastName).IsRequired().HasMaxLength(30);
        }
    }
}
