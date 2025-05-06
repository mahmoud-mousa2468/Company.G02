﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Company.G02.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace Company.G02.DAL.Data.Contexts
{
    internal class CompanyDbContext:DbContext
    {
        public CompanyDbContext():base()
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;DataBase=CompanyG02;Trusted_Connection=True;TrustServerCertificate=True");
        }
        public DbSet<Department> Departments { get; set; }
    }
}
