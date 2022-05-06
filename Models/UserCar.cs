using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamCar.Models
{
    public class UserCar
    {
        public int UserCarId { get; set; }


        public int UserId { get; set; }
        public User User { get; set; } = null!;
        public int CarId { get; set; }
        public Car Car { get; set; } = null!;

        public ICollection<Reservation> Reservations { get; set; } = null!;
        public ICollection<Publish> Publishes { get; set; } = null!;
        public ICollection<Favourite> Favourites { get; set; } = null!;
    }
}
