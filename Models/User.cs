using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DreamCar.Models
{
    public class User
    {
        public User()
        {
            Cars = new HashSet<Car>();
        }

        [Key]
        public int UserId { get; set; }

        [Column(TypeName = "varchar(1000)")]
        public string UserUsername { get; set; } = null!;

        [Column(TypeName = "varchar(1000)")]
        public string UserPassword { get; set; } = null!;

        [Column(TypeName = "varchar(1000)")]
        public string UserFirstName { get; set; } = null!;

        [Column(TypeName = "varchar(1000)")]
        public string UserLastName { get; set; } = null!;

        [Column(TypeName = "varchar(1000)")]
        public string UserCountry { get; set; } = null!;

        [Column(TypeName = "varchar(1000)")]
        public string UserCity { get; set; } = null!;

        [Column(TypeName = "varchar(1000)")]
        public string UserAddress { get; set; } = null!;

        [Column(TypeName = "varchar(1000)")]
        public string UserPhone { get; set; } = null!;

        [Column(TypeName = "varchar(1000)")]
        public string UserEmail { get; set; } = null!;

        public ICollection<Car> Cars { get; set; } = null!;

        //public ICollection<Car> Cars { get; set; } = new List<Car>();
        //public ICollection<Car> FavouriteCars { get; set; } = new List<Car>();
    }
}
