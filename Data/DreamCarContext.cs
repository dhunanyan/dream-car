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
        public virtual DbSet<UserCar> UserCars { get; set; } = null!;
        public virtual DbSet<Favourite> Favourite { get; set; } = null!;
        public virtual DbSet<Reservation> Reservation { get; set; } = null!;


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Keep your connection strings separate from your code!
            // Secure connection string guidance: https://aka.ms/ef-core-connection-strings
            // 
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DreamCarDB;Integrated Security=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserCar>().HasKey(uc => new { uc.UserId, uc.CarId });

            modelBuilder.Entity<UserCar>().HasOne<User>(u => u.User).WithMany(c => c.UserCars);
            modelBuilder.Entity<UserCar>().HasOne<Car>(c => c.Car).WithMany(u => u.UserCars);

            modelBuilder.Entity<Favourite>().HasOne<UserCar>(uc => uc.UserCar).WithMany(f => f.Favourites).HasForeignKey(uc => uc.UserCarId).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Reservation>().HasOne<UserCar>(uc => uc.UserCar).WithMany(f => f.Reservations).HasForeignKey(uc => uc.UserCarId).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Publish>().HasOne<UserCar>(uc => uc.UserCar).WithMany(f => f.Publishes).HasForeignKey(uc => uc.UserCarId).OnDelete(DeleteBehavior.Cascade);

            base.OnModelCreating(modelBuilder);
        }
    }
}