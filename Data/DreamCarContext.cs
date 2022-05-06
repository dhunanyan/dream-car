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
        //public virtual DbSet<Favourite> Favourite { get; set; } = null!;
        //public virtual DbSet<Reservation> Reservation { get; set; } = null!;


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Keep your connection strings separate from your code!
            // Secure connection string guidance: https://aka.ms/ef-core-connection-strings
            // 
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DreamCarDB;Integrated Security=True;");
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Car>()
        //        .HasOne(c => c.Owner)
        //        .WithMany(u => u.Cars)
        //        .OnDelete(DeleteBehavior.Restrict);

        //    modelBuilder.Entity<User>()
        //        .HasMany(u => u.FavouriteCars)
        //        .WithMany(c => c.Likers);


        //    base.OnModelCreating(modelBuilder);
        //}
    }
}