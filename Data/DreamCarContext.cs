using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using DreamCar.Models;

namespace DreamCar.Data
{
    public partial class DreamCarContext : DbContext
    {


        public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<Car> Cars { get; set; } = null!;
        public virtual DbSet<Favourite> Favourite { get; set; } = null!;
        public virtual DbSet<Reservation> Reservation { get; set; } = null!;


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Keep your connection strings separate from your code!
            // Secure connection string guidance: https://aka.ms/ef-core-connection-strings
            // 
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DreamCar;Integrated Security=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasMany(u => u.Cars).WithOne(c => c.User);
            modelBuilder.Entity<Car>().HasOne(c => c.User).WithMany(c => c.Cars);
            modelBuilder.Entity<Favourite>().HasOne(c => c.Car).WithMany(f => f.Favourites);
            modelBuilder.Entity<Car>().HasMany(c => c.Favourites).WithOne(r => r.Car);
            modelBuilder.Entity<Reservation>().HasOne(c => c.Car).WithMany(f => f.Reservations);
            modelBuilder.Entity<Car>().HasMany(c => c.Reservations).WithOne(r => r.Car);

            base.OnModelCreating(modelBuilder);
        }
    }
}