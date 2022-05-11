using DreamCar.Data;
using DreamCar.Helpers;
using DreamCar.Models;
using DreamCar.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DreamCar.Forms.Collection
{
    public partial class Collection : Container
    {
        public static int initialCarGenAmount = 6;
        public Collection()
        {
            CollectionStyles.GerenerateCollectionContainer(this, initialCarGenAmount);
            CollectionStyles.ChangeCollectionContainerScrollMinSize(initialCarGenAmount);
            CollectionStyles.GenerateSearch(this);
            GenerateCollection(initialCarGenAmount, initialCarGenAmount - 6);
            CollectionStyles.InitializeComponent(this);
        }

        public static void ButtonLoadMore_Click(object sender, EventArgs e)
        {
            initialCarGenAmount += 6;
            GenerateCollection(initialCarGenAmount, initialCarGenAmount - 6);
        }

        private static void GenerateCollection(int take, int skip)
        {
            using (DreamCarContext context = new DreamCarContext())
            {
                using (DreamCarContext contexInner = new DreamCarContext())
                {
                    List<Favourite> currentFavRecord = CollectionReq.GetFavsByUsername(contexInner, currentUserUsername);
                    List<Car> carCollection = CollectionReq.GetCarWithSkipNTake(context, take, skip);
                    CollectionStyles.ChangeCollectionContainerScrollMinSize(take);
                    foreach (var car in carCollection)
                    {
                        bool isFav = false;
                        if (currentFavRecord.Where(f => f.CarId == car.CarId).Count() > 0)
                        {
                            isFav = true;
                        }

                        CollectionStyles.GenerateCar(car.CarImageUrl, car.CarBrand, car.CarModel, car.CarProdYear.ToString(), car.CarFuel, car.CarGearbox, car.CarId, isFav, take);
                    }
                }
            }
        }


        public static void ButtonSearch_Click(object sender, EventArgs e)
        {

        }

        public static async void ButtonCurrentCarMore_Click(object sender, EventArgs e)
        {
            CollectionStyles.panelMain.Controls.Remove(CollectionStyles.flowLayoutPanelPopup);
            await Task.Delay(1);
            Button currentShowMore = (Button)sender;
            int currentId = int.Parse(currentShowMore.Name.ToString().Split('.')[1]);
            using(DreamCarContext context = new DreamCarContext())
            {
                bool isFav = false;
                Car currentCar = CollectionReq.GetCarById(context, currentId);

                List<Favourite> favs = CollectionReq.GetFavsByUsername(context, currentUserUsername);

                foreach(Favourite fav in favs)
                {
                    if (fav.CarId == currentCar.CarId)
                    {
                        isFav = true;

                    }
                    else
                    {
                        isFav = false;
                    }
                }

                Console.WriteLine(isFav);
                Console.WriteLine(context.Favourites.Where(fav => fav.CarId == currentCar.CarId && fav.FavouriteAuthor == currentCar.CarAuthor));

                CollectionStyles.GenerateDetails(
                currentCar.CarId,
                currentCar.CarAuthor,
                currentCar.CarBrand,
                currentCar.CarModel,
                currentCar.CarCountry,
                currentCar.CarCity,
                currentCar.CarFuel,
                currentCar.CarGearbox,
                currentCar.CarProdYear,
                currentCar.CarCapacity,
                currentCar.CarTags,
                currentCar.CarReservationDateStart,
                currentCar.CarReservationDateEnd,
                currentCar.CarImageUrl,
                isFav
                );
            };
        }
    }
}
