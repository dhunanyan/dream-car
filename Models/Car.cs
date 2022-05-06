using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DreamCar.Models
{
    public class Car
    {
        [Key]
        public int CarId { get; set; }

        [Column(TypeName = "varchar(1000)")]
        public string CarCountry { get; set; } = null!;

        [Column(TypeName = "varchar(1000)")]
        public string CarCity { get; set; } = null!;

        [Column(TypeName = "varchar(1000)")]
        public string CarName { get; set; } = null!;

        [Column(TypeName = "varchar(1000)")]
        public string CarBrand { get; set; } = null!;

        [Column(TypeName = "varchar(1000)")]
        public string CarModel { get; set; } = null!;

        public int CarCapacity { get; set; }

        public int CarProdYear { get; set; }

        [Column(TypeName = "varchar(1000)")]
        public string CarColor { get; set; } = null!;

        [Column(TypeName = "varchar(1000)")]
        public string CarFuel { get; set; } = null!;

        [Column(TypeName = "varchar(1000)")]
        public string CarGearbox { get; set; } = null!;

        [Column(TypeName = "varchar(1000)")]
        public string CarImageUrl { get; set; } = null!;

        [Column(TypeName = "decimal(6,2)")]
        public decimal CarPrice { get; set; }

        [Column(TypeName = "varchar(1000)")]
        public string CarTags { get; set; } = null!;

        [Column(TypeName = "varchar(1000)")]
        public string CarReservationDateStart { get; set; } = null!;

        [Column(TypeName = "varchar(1000)")]
        public string CarReservationDateEnd { get; set; } = null!;
        public bool CarIsSold { get; set; }
        public bool CarIsReserved { get; set; }

        [Column(TypeName = "varchar(1000)")]
        public string CarAuthor { get; set; } = null!;

        public ICollection<UserCar> UserCars { get; set; } = null!;
    }
}