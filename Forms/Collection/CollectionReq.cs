using DreamCar.Data;
using DreamCar.Models;
using LinqKit;
using System;
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

        public static List<Reservation> GetReservationByUsername(DreamCarContext context, string usernameToCompare)
        {
            return context.Reservations.Where(c => c.ReservationAuthor == usernameToCompare).ToList();
        }

        public static List<Models.Publication> GetPublicationByUsername(DreamCarContext context, string usernameToCompare)
        {
            return context.Publications.Where(c => c.PublishAuthor == usernameToCompare).ToList();
        }

        public static Car GetCarById(DreamCarContext context, int carIdToCompare)
        {
            return context.Cars.Where(c => c.CarId == carIdToCompare).FirstOrDefault();
        }

        public static List<Car> GetCarWithSkipNTake(DreamCarContext context, int take, int skip)
        {
            return context.Cars.Take(take).Skip(skip).ToList();
        }

        public static List<Car> GetSearchedCarWithSkipNTake(List<Car> cars, int take, int skip)
        {
            return cars.Take(take).Skip(skip).ToList();
        }

        public static List<Car> GetCarsListByBrandModelYearGearboxCountryCity(string brand, string model, string year, string gearbox, string country, string city)
        {
            using (DreamCarContext context = new DreamCarContext())
            {
                ExpressionStarter<Car> pr = PredicateBuilder.New<Car>();
                if (brand != "")
                {
                    pr = pr.And(x => x.CarBrand == brand);
                }

                if (model != "")
                {
                    pr = pr.And(x => x.CarModel == model);
                }

                if (year != "")
                {
                    pr = pr.And(x => x.CarProdYear == int.Parse(year));
                }

                if (gearbox != "")
                {
                    pr = pr.And(x => x.CarGearbox == gearbox);
                }

                if (country != "")
                {
                    pr = pr.And(x => x.CarCountry == country);
                }

                if (city != "")
                {
                    pr = pr.And(x => x.CarCity == city);
                }

                if(brand == "" && model == "" && year == "" && gearbox == "" && country == "" && city == "")
                {
                    return context.Cars.ToList();
                }

                return context.Cars.Where(pr).ToList();
            }
        }

        public static string[] GetCarBrands(string brand, string model, string year, string gearbox, string country, string city)
        {
            return GetCarsListByBrandModelYearGearboxCountryCity(brand, model, year, gearbox, country, city).OrderBy(x => x.CarBrand).Select(c => c.CarBrand).Distinct().ToArray();
        }

        public static string[] GetCarModels(string brand, string model, string year, string gearbox, string country, string city)
        {
            return GetCarsListByBrandModelYearGearboxCountryCity(brand, model, year, gearbox, country, city).OrderBy(x => x.CarModel).Select(c => c.CarModel).Distinct().ToArray();
        }

        public static string[] GetCarYears(string brand, string model, string year, string gearbox, string country, string city)
        {
            return GetCarsListByBrandModelYearGearboxCountryCity(brand, model, year, gearbox, country, city).OrderBy(x => x.CarProdYear).Select(c => c.CarProdYear.ToString()).Distinct().ToArray();
        }

        public static string[] GetCarGearboxes(string brand, string model, string year, string gearbox, string country, string city)
        {
            return GetCarsListByBrandModelYearGearboxCountryCity(brand, model, year, gearbox, country, city).OrderBy(x => x.CarGearbox).Select(c => c.CarGearbox).Distinct().ToArray();
        }

        public static string[] GetCarCountries(string brand, string model, string year, string gearbox, string country, string city)
        {
            return GetCarsListByBrandModelYearGearboxCountryCity(brand, model, year, gearbox, country, city).OrderBy(x => x.CarCountry).Select(c => c.CarCountry).Distinct().ToArray();
        }

        public static string[] GetCarCities(string brand, string model, string year, string gearbox, string country, string city)
        {
            return GetCarsListByBrandModelYearGearboxCountryCity(brand, model, year, gearbox, country, city).OrderBy(x => x.CarCity).Select(c => c.CarCity).Distinct().ToArray();
        }

        public static void AddReservation(string username, int cardId, string date)
        {
            using (DreamCarContext context = new DreamCarContext())
            {
                context.Reservations.Add(new Reservation()
                {
                    ReservationAuthor = username,
                    ReservationDate = date,
                    CarId = cardId
                });
                context.SaveChanges();
            }
        }

        public static void SetCarIsReservedTrue(int carId)
        {
            using (DreamCarContext context = new DreamCarContext())
            {
                context.Cars.Where(c => c.CarId == carId).FirstOrDefault().CarIsReserved = true;
                context.SaveChanges();
            }
        }

        public static bool GetCarIsReserved(int carId)
        {
            using (DreamCarContext context = new DreamCarContext())
            {
                return context.Cars.Where(c => c.CarId == carId).FirstOrDefault().CarIsReserved;
            }
        }
    }
}
