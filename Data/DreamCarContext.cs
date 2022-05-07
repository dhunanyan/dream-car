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
        public virtual DbSet<Favourite> Favourites { get; set; } = null!;
        public virtual DbSet<Publication> Publications { get; set; } = null!;
        public virtual DbSet<Reservation> Reservations { get; set; } = null!;


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Keep your connection strings separate from your code!
            // Secure connection string guidance: https://aka.ms/ef-core-connection-strings
            // 
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DreamCarDB;Integrated Security=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>().HasOne<User>(uc => uc.User).WithMany(f => f.Cars).HasForeignKey(uc => uc.UserId).OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Favourite>().HasOne<Car>(uc => uc.Car).WithMany(f => f.Favourites).HasForeignKey(uc => uc.CarId).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Reservation>().HasOne<Car>(uc => uc.Car).WithMany(f => f.Reservations).HasForeignKey(uc => uc.CarId).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Publication>().HasOne<Car>(uc => uc.Car).WithMany(f => f.Publications).HasForeignKey(uc => uc.CarId).OnDelete(DeleteBehavior.Cascade);

            base.OnModelCreating(modelBuilder);
        }
    }
}