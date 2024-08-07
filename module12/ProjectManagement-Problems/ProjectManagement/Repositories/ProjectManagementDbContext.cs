using Microsoft.EntityFrameworkCore;
using ProjectManagement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagement.Repositories
{
    public class ProjectManagementDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Project> Projects { get; set; }
        public int Id { get; set; }

        public ProjectManagementDbContext()
        {
            this.Users = this.Set<User>();
            this.Projects = this.Set<Project>();
            this.Id = this.Set<int>();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
             .UseSqlServer(@"Server=localhost;Database=ProjectManagementDB;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User()
                {
                    Id = 1,
                    Username = "admin",
                    Password = "adminpass",
                    FirstName = "Admin",
                    LastName = "Istrator",
                    Projects = new List<Project>()
                });
        }
    }
}
