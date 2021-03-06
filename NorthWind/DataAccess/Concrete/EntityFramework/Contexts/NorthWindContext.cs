﻿using Core.Entity.Concrete;
using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework.Contexts
{
    public class NorthwindContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = Northwind; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Core.Entity.Concrete.OperationClaim> OperationClaims { get; set; }
        public DbSet<Core.Entity.Concrete.User> Users { get; set; }
        public DbSet<Core.Entity.Concrete.UserOperationClaim> UserOperationClaims { get; set; }

    }
}

