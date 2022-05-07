using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DreamCar.Models
{
    public class Publication
    {
        [Key]
        public int PublishId { get; set; }
        public string PublishAuthor { get; set; } = null!;

        public int? CarId { get; set; }
        public Car Car { get; set; } = null!;
    }
}
