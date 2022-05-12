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
            GenerateComboBoxValues();
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

        public static void GenerateComboBoxValues()
        {
            using(DreamCarContext context = new DreamCarContext())
            {
                context.Cars.ToList().ForEach(car => {
                    if (!CollectionStyles.comboBoxSearchBrand.Items.Contains(car.CarBrand))
                    {
                        CollectionStyles.comboBoxSearchBrand.Items.Add(car.CarBrand);
                    }

                    if (!CollectionStyles.comboBoxSearchModel.Items.Contains(car.CarModel))
                    {
                        CollectionStyles.comboBoxSearchModel.Items.Add(car.CarModel);
                    }

                    if (!CollectionStyles.comboBoxSearchYear.Items.Contains(car.CarProdYear))
                    {
                        CollectionStyles.comboBoxSearchYear.Items.Add(car.CarProdYear);
                    }

                    if (!CollectionStyles.comboBoxSearchGearbox.Items.Contains(car.CarGearbox))
                    {
                        CollectionStyles.comboBoxSearchGearbox.Items.Add(car.CarGearbox);
                    }

                    if (!CollectionStyles.comboBoxSearchCountry.Items.Contains(car.CarCountry))
                    {
                        CollectionStyles.comboBoxSearchCountry.Items.Add(car.CarCountry);
                    }

                    if (!CollectionStyles.comboBoxSearchCity.Items.Contains(car.CarCity))
                    {
                        CollectionStyles.comboBoxSearchCity.Items.Add(car.CarCity);
                    }
                });
            }
        }

        public static void ComboBoxSearchBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(!(CollectionStyles.comboBoxSearchBrand.SelectedItem.ToString() == "All Brands"))
            {
                if (CollectionStyles.comboBoxSearchModel.SelectedItem.ToString() == "All Models")
                {
                    CollectionStyles.comboBoxSearchModel.Items.Clear();
                }

                if (CollectionStyles.comboBoxSearchYear.SelectedItem.ToString() == "All Years")
                {
                    CollectionStyles.comboBoxSearchYear.Items.Clear();
                }

                if (CollectionStyles.comboBoxSearchGearbox.SelectedItem.ToString() == "All Gearboxes")
                {
                    CollectionStyles.comboBoxSearchGearbox.Items.Clear();
                }

                if (CollectionStyles.comboBoxSearchCountry.SelectedItem.ToString() == "All Countries")
                {
                    CollectionStyles.comboBoxSearchCountry.Items.Clear();
                }

                if (CollectionStyles.comboBoxSearchCity.SelectedItem.ToString() == "All Cities")
                {
                    CollectionStyles.comboBoxSearchCity.Items.Clear();
                }
                using (DreamCarContext context = new DreamCarContext())
                {
                    List<Car> allCars = context.Cars.ToList();
                    List<Car> selectedCars = CollectionReq.GetCarsListByBrand(allCars, CollectionStyles.comboBoxSearchBrand.SelectedItem.ToString());
                    selectedCars.ForEach(car => {
                        if (!CollectionStyles.comboBoxSearchModel.Items.Contains(car.CarModel))
                        {
                            if(CollectionStyles.comboBoxSearchModel.SelectedItem.ToString() == "All Models")
                            {
                                CollectionStyles.comboBoxSearchModel.Items.Add(car.CarModel);
                            }
                            else
                            {
                                CollectionStyles.comboBoxSearchModel.Items.Add(CollectionStyles.comboBoxSearchModel.SelectedItem);
                            }
                        }

                        if (!CollectionStyles.comboBoxSearchYear.Items.Contains(car.CarProdYear))
                        {
                            if (CollectionStyles.comboBoxSearchYear.SelectedItem.ToString() == "All Years")
                            {
                                CollectionStyles.comboBoxSearchYear.Items.Add(car.CarProdYear);
                            }
                            else
                            {
                                CollectionStyles.comboBoxSearchYear.Items.Add(CollectionStyles.comboBoxSearchYear.SelectedItem);
                            }
                        }

                        if (!CollectionStyles.comboBoxSearchGearbox.Items.Contains(car.CarGearbox))
                        {
                            if (CollectionStyles.comboBoxSearchGearbox.SelectedItem.ToString() == "All Gearboxes")
                            {
                                CollectionStyles.comboBoxSearchGearbox.Items.Add(car.CarGearbox);
                            }
                            else
                            {
                                CollectionStyles.comboBoxSearchGearbox.Items.Add(CollectionStyles.comboBoxSearchGearbox.SelectedItem);
                            }
                        }

                        if (!CollectionStyles.comboBoxSearchCountry.Items.Contains(car.CarCountry))
                        {
                            if (CollectionStyles.comboBoxSearchCountry.SelectedItem.ToString() == "All Countries")
                            {
                                CollectionStyles.comboBoxSearchCountry.Items.Add(car.CarCountry);

                            }
                            else
                            {
                                CollectionStyles.comboBoxSearchCountry.Items.Add(CollectionStyles.comboBoxSearchCountry.SelectedItem);
                            }
                        }

                        if (!CollectionStyles.comboBoxSearchCity.Items.Contains(car.CarCity))
                        {
                            if (CollectionStyles.comboBoxSearchCity.SelectedItem.ToString() == "All Cities")
                            {
                                CollectionStyles.comboBoxSearchCity.Items.Add(car.CarCity);
                            }
                            else
                            {
                                CollectionStyles.comboBoxSearchCity.Items.Add(CollectionStyles.comboBoxSearchCity.SelectedItem);
                            }
                        }
                    });
                }
            }
        }

        public static void ComboBoxSearchModel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public static void ComboBoxSearchYear_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public static void ComboBoxSearchGearbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public static void ComboBoxSearchCountry_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public static void ComboBoxSearchCity_SelectedIndexChanged(object sender, EventArgs e)
        {

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
