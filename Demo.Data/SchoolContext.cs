using Demo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Data
{
    public class SchoolContext : DbContext
    {
        const string connectionString = "Data Source=school.db";

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }

        public SchoolContext() : base(){}

        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options){}


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(connectionString);
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Source : https://docs.microsoft.com/en-us/ef/core/modeling/data-seeding
            base.OnModelCreating(modelBuilder);
        }

    }



}
