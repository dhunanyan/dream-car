using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DreamCar.Models
{
    public class Favourite
    {
        [Key]
        public int FavouriteId { get; set; }
        public string FavouriteAuthor { get; set; } = null!;

        [ForeignKey("Car")]
        public int? CarId { get; set; }
        public Car Car { get; set; } = null!;
    }
}
