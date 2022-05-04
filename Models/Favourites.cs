using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DreamCar.Models
{
    public class Favourite
    {
        [Key]
        public int FavouriteId { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }

        [ForeignKey("Car")]
        public int CarId { get; set; }

        public User User { get; set; } = null!;
        public Car Car { get; set; } = null!;
    }
}
