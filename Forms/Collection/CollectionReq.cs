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

        public static List<Car> GetCarWithSkipNTake(DreamCarContext context, int take, int skip)
        {
            return context.Cars.Take(take).Skip(skip).ToList();
        }

        public static List<Car> GetCarsListByBrand(List<Car> cars, string carColumnToCompare)
        {
            return cars.Where(c => c.CarBrand == carColumnToCompare).ToList();
        }

        public static List<Car> GetCarsListByModel(List<Car> cars, string carColumnToCompare)
        {
            return cars.Where(c => c.CarModel == carColumnToCompare).ToList();
        }

        public static List<Car> GetCarsListByYear(List<Car> cars, int carColumnToCompare)
        {
            return cars.Where(c => c.CarProdYear == carColumnToCompare).ToList();
        }

        public static List<Car> GetCarsListByGearbox(List<Car> cars, string carColumnToCompare)
        {
            return cars.Where(c => c.CarGearbox == carColumnToCompare).ToList();
        }
        public static List<Car> GetCarsListByCountry(List<Car> cars, string carColumnToCompare)
        {
            return cars.Where(c => c.CarCountry == carColumnToCompare).ToList();
        }

        public static List<Car> GetCarsListByCity(List<Car> cars, string carColumnToCompare)
        {
            return cars.Where(c => c.CarCity == carColumnToCompare).ToList();
        }
    }
}
