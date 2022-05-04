using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using DreamCar.Models;

namespace DreamCar.Data
{
    public partial class DreamCarContext : DbContext
    {


        public virtual DbSet<User>? Users { get; set; }
        public virtual DbSet<Car>? Cars { get; set; }
        public virtual DbSet<Favourite>? Favourite { get; set; }
        public virtual DbSet<Reservation>? Reservation { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Keep your connection strings separate from your code!
            // Secure connection string guidance: https://aka.ms/ef-core-connection-strings
            // 
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DreamCarDB;Integrated Security=True;");
        }
    }
}