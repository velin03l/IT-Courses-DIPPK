using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApp_FireAndIce.Models;

namespace WebApp_FireAndIce.Repositories
{
    public class WebApp_FireAndIceDbContext : DbContext
    {
        public virtual DbSet<Administrator> Administrators { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Request> Requests { get; set; }
        public virtual DbSet<Tech> Techs { get; set; }

        public WebApp_FireAndIceDbContext()
        {
            this.Administrators = this.Set<Administrator>();
            this.Customers = this.Set<Customer>();
            this.Requests = this.Set<Request>();
            this.Techs = this.Set<Tech>();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
             .UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=WebAppFireIceDb;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Administrator>().HasData(
              new Administrator()
              {
                  Id = 1,
                  Username = "admin",
                  Password = "password",
              });
        }
    }
}
