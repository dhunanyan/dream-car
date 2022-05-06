using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DreamCar.Models
{
    public class Reservation
    {
        [Key]
        public int ReservationId { get; set; }
        public string ReservationAuthor { get; set; } = null!;

        public int? CarId { get; set; }
        public Car Car { get; set; } = null!;
    }
}
