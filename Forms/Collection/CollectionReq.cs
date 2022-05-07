using DreamCar.Data;
using DreamCar.Models;
using System.Collections.Generic;
using System.Linq;

namespace DreamCar.Forms.Collection
{
    public partial class CollectionReq
    {
        public CollectionReq()
        {
        }

        public static List<Favourite> GetFavsByUsername(DreamCarContext context, string usernameToCompare)
        {
            return context.Favourites.Where(c => c.FavouriteAuthor == usernameToCompare).ToList();
        }

        public static Car GetCarById(DreamCarContext context, int carIdToCompare)
        {
            return context.Cars.Where(c => c.CarId == carIdToCompare).FirstOrDefault();
        }
    }
}
