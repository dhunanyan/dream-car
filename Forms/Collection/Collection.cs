using DreamCar.Data;
using DreamCar.Helpers;
using DreamCar.Models;
using DreamCar.Properties;
using LinqKit;
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

        public static Dictionary<string, string> brandDic = new Dictionary<string, string>()
        {
            {"CarBrand", "" },
            {"CarModel", "" },
            {"CarProdYear", "" },
            {"CarGearbox", "" },
            {"CarCountry", "" },
            {"CarCity", "" },
        };

        public static Dictionary<string, string> modelDic = new Dictionary<string, string>()
        {
            {"CarBrand", "" },
            {"CarModel", "" },
            {"CarProdYear", "" },
            {"CarGearbox", "" },
            {"CarCountry", "" },
            {"CarCity", "" },
        };

        public static Dictionary<string, string> yearDic = new Dictionary<string, string>()
        {
            {"CarBrand", "" },
            {"CarModel", "" },
            {"CarProdYear", "" },
            {"CarGearbox", "" },
            {"CarCountry", "" },
            {"CarCity", "" },
        };

        public static Dictionary<string, string> gearboxDic = new Dictionary<string, string>()
        {
            {"CarBrand", "" },
            {"CarModel", "" },
            {"CarProdYear", "" },
            {"CarGearbox", "" },
            {"CarCountry", "" },
            {"CarCity", "" },
        };

        public static Dictionary<string, string> countryDic = new Dictionary<string, string>()
        {
            {"CarBrand", "" },
            {"CarModel", "" },
            {"CarProdYear", "" },
            {"CarGearbox", "" },
            {"CarCountry", "" },
            {"CarCity", "" },
        };

        public static Dictionary<string, string> cityDic = new Dictionary<string, string>()
        {
            {"CarBrand", "" },
            {"CarModel", "" },
            {"CarProdYear", "" },
            {"CarGearbox", "" },
            {"CarCountry", "" },
            {"CarCity", "" },
        };

        public static Dictionary<string, string> searchDic = new Dictionary<string, string>()
        {
            {"CarBrand", "" },
            {"CarModel", "" },
            {"CarProdYear", "" },
            {"CarGearbox", "" },
            {"CarCountry", "" },
            {"CarCity", "" },
        };

        public Collection()
        {
            CollectionStyles.flowLayoutPanelCarCollection = new FlowLayoutPanel();
            CollectionStyles.GerenerateCollectionContainer(this, CollectionStyles.flowLayoutPanelCarCollection, initialCarGenAmount);
            CollectionStyles.ChangeCollectionContainerScrollMinSize(initialCarGenAmount);
            CollectionStyles.GenerateSearch(this);
            GenerateCollection(CollectionStyles.flowLayoutPanelCarCollection, initialCarGenAmount, initialCarGenAmount - 6);
            CollectionStyles.InitializeComponent(this);

            GenerateComboBoxValues();

        }

        public static void ButtonLoadMore_Click(object sender, EventArgs e)
        {
            if((CollectionStyles.flowLayoutPanelCarCollection.AutoScrollMinSize.Height + 46) / 65 > initialCarGenAmount)
            {
                CollectionStyles.buttonLoadMore.Enabled = false;
            }
            else
            {
                CollectionStyles.buttonLoadMore.Enabled = true;

            }
            initialCarGenAmount += 6;
            GenerateCollection(CollectionStyles.flowLayoutPanelCarCollection, initialCarGenAmount, initialCarGenAmount - 6);
        }

        public static void GenerateCollection(FlowLayoutPanel flow, int take, int skip)
        {
            using (DreamCarContext context = new DreamCarContext())
            {
                List<Favourite> currentFavRecord = CollectionReq.GetFavsByUsername(context, currentUserUsername);
                List<Car> carCollection = CollectionReq.GetSearchedCarWithSkipNTake(
                        CollectionReq.GetCarsListByBrandModelYearGearboxCountryCity(
                            searchDic["CarBrand"],
                            searchDic["CarModel"],
                            searchDic["CarProdYear"],
                            searchDic["CarGearbox"],
                            searchDic["CarCountry"],
                            searchDic["CarCity"]),
                        take,
                        skip);
                CollectionStyles.ChangeCollectionContainerScrollMinSize(take);
                foreach (var car in carCollection)
                {
                    bool isFav = false;
                    if (currentFavRecord.Where(f => f.CarId == car.CarId).Count() > 0)
                    {
                        isFav = true;
                    }

                    CollectionStyles.GenerateCar(flow, car.CarImageUrl, car.CarBrand, car.CarModel, car.CarProdYear.ToString(), car.CarFuel, car.CarGearbox, car.CarId, isFav, take);
                }
            }
        }

        public static void GenerateFavsCollection(FlowLayoutPanel flow, int take, int skip)
        {
            using (DreamCarContext context = new DreamCarContext())
            {
                List<Favourite> currentFavRecord = CollectionReq.GetFavsByUsername(context, currentUserUsername);
                List<Car> carCollection = CollectionReq.GetSearchedCarWithSkipNTake(
                        CollectionReq.GetCarsListByBrandModelYearGearboxCountryCity(
                            searchDic["CarBrand"],
                            searchDic["CarModel"],
                            searchDic["CarProdYear"],
                            searchDic["CarGearbox"],
                            searchDic["CarCountry"],
                            searchDic["CarCity"]),
                        take,
                        skip);
                CollectionStyles.ChangeCollectionContainerScrollMinSize(take);
                foreach (var car in carCollection)
                {
                    bool isFav = false;
                    if (currentFavRecord.Where(f => f.CarId == car.CarId).Count() > 0)
                    {
                        isFav = true;
                        CollectionStyles.GenerateCar(flow, car.CarImageUrl, car.CarBrand, car.CarModel, car.CarProdYear.ToString(), car.CarFuel, car.CarGearbox, car.CarId, isFav, take);
                    }
                }
            }
        }

        public static void GenerateReservationsCollection(FlowLayoutPanel flow, int take, int skip)
        {
            using (DreamCarContext context = new DreamCarContext())
            {
                List<Reservation> currentFavRecord = CollectionReq.GetReservationByUsername(context, currentUserUsername);
                List<Car> carCollection = CollectionReq.GetSearchedCarWithSkipNTake(
                        CollectionReq.GetCarsListByBrandModelYearGearboxCountryCity(
                            searchDic["CarBrand"],
                            searchDic["CarModel"],
                            searchDic["CarProdYear"],
                            searchDic["CarGearbox"],
                            searchDic["CarCountry"],
                            searchDic["CarCity"]),
                        take,
                        skip);
                CollectionStyles.ChangeCollectionContainerScrollMinSize(take);
                foreach (var car in carCollection)
                {
                    bool isFav = false;
                    if (currentFavRecord.Where(f => f.CarId == car.CarId).Count() > 0)
                    {
                        isFav = true;
                        CollectionStyles.GenerateCar(flow, car.CarImageUrl, car.CarBrand, car.CarModel, car.CarProdYear.ToString(), car.CarFuel, car.CarGearbox, car.CarId, isFav, take);
                    }
                }
            }
        }

        public static void GeneratePublicationsCollection(FlowLayoutPanel flow, int take, int skip)
        {
            using (DreamCarContext context = new DreamCarContext())
            {
                List<Reservation> currentFavRecord = CollectionReq.GetReservationByUsername(context, currentUserUsername);
                List<Models.Publication> currentPubRecord = CollectionReq.GetPublicationByUsername(context, currentUserUsername);
                List<Car> carCollection = CollectionReq.GetSearchedCarWithSkipNTake(
                        CollectionReq.GetCarsListByBrandModelYearGearboxCountryCity(
                            searchDic["CarBrand"],
                            searchDic["CarModel"],
                            searchDic["CarProdYear"],
                            searchDic["CarGearbox"],
                            searchDic["CarCountry"],
                            searchDic["CarCity"]),
                        take,
                        skip);
                CollectionStyles.ChangeCollectionContainerScrollMinSize(take);
                foreach (var car in carCollection)
                {
                    bool isFav = false;
                    if (currentFavRecord.Where(f => f.CarId == car.CarId).Count() > 0)
                    {
                        isFav = true;
                    }

                    if(currentPubRecord.Where(p => p.CarId == car.CarId).Count() > 0){
                        CollectionStyles.GenerateCar(flow, car.CarImageUrl, car.CarBrand, car.CarModel, car.CarProdYear.ToString(), car.CarFuel, car.CarGearbox, car.CarId, isFav, take);
                    }
                }
            }
        }

        private static void UpdateComboBoxValues()
        {
            CollectionStyles.comboBoxSearchBrand.Items.Clear();
            CollectionStyles.comboBoxSearchBrand.Items.Add("--All Brands--");
            CollectionStyles.comboBoxSearchBrand.Items.AddRange(CollectionReq.GetCarBrands(brandDic["CarBrand"], brandDic["CarModel"], brandDic["CarProdYear"], brandDic["CarGearbox"], brandDic["CarCountry"], brandDic["CarCity"]));
            if (searchDic["CarBrand"] == "")
            {
                CollectionStyles.comboBoxSearchBrand.SelectedItem = "--All Brands--";

            }
            else
            {
                CollectionStyles.comboBoxSearchBrand.SelectedItem = searchDic["CarBrand"];
            }

            CollectionStyles.comboBoxSearchModel.Items.Clear();
            CollectionStyles.comboBoxSearchModel.Items.Add("--All Models--");
            CollectionStyles.comboBoxSearchModel.Items.AddRange(CollectionReq.GetCarModels(modelDic["CarBrand"], modelDic["CarModel"], modelDic["CarProdYear"], modelDic["CarGearbox"], modelDic["CarCountry"], modelDic["CarCity"]));
            if (searchDic["CarModel"] == "")
            {
                CollectionStyles.comboBoxSearchModel.SelectedItem = "--All Models--";
            }
            else
            {
                CollectionStyles.comboBoxSearchModel.SelectedItem = searchDic["CarModel"];
            }

            CollectionStyles.comboBoxSearchYear.Items.Clear();
            CollectionStyles.comboBoxSearchYear.Items.Add("--All Years--");
            CollectionStyles.comboBoxSearchYear.Items.AddRange(CollectionReq.GetCarYears(yearDic["CarBrand"], yearDic["CarModel"], yearDic["CarProdYear"], yearDic["CarGearbox"], yearDic["CarCountry"], yearDic["CarCity"]));
            if (searchDic["CarProdYear"] == "")
            {
                CollectionStyles.comboBoxSearchYear.SelectedItem = "--All Years--";
            }
            else
            {
                CollectionStyles.comboBoxSearchYear.SelectedItem = searchDic["CarProdYear"];
            }

            CollectionStyles.comboBoxSearchGearbox.Items.Clear();
            CollectionStyles.comboBoxSearchGearbox.Items.Add("--All Gearboxes--");
            CollectionStyles.comboBoxSearchGearbox.Items.AddRange(CollectionReq.GetCarGearboxes(gearboxDic["CarBrand"], gearboxDic["CarModel"], gearboxDic["CarProdYear"], gearboxDic["CarGearbox"], gearboxDic["CarCountry"], gearboxDic["CarCity"]));
            if (searchDic["CarGearbox"] == "")
            {
                CollectionStyles.comboBoxSearchGearbox.SelectedItem = "--All Gearboxes--";
            }
            else
            {
                CollectionStyles.comboBoxSearchGearbox.SelectedItem = searchDic["CarGearbox"];
            }

            CollectionStyles.comboBoxSearchCountry.Items.Clear();
            CollectionStyles.comboBoxSearchCountry.Items.Add("--All Countries--");
            CollectionStyles.comboBoxSearchCountry.Items.AddRange(CollectionReq.GetCarCountries(countryDic["CarBrand"], countryDic["CarModel"], countryDic["CarProdYear"], countryDic["CarGearbox"], countryDic["CarCountry"], countryDic["CarCity"]));
            if (searchDic["CarCountry"] == "")
            {
                CollectionStyles.comboBoxSearchCountry.SelectedItem = "--All Countries--";
            }
            else
            {
                CollectionStyles.comboBoxSearchCountry.SelectedItem = searchDic["CarCountry"];
            }

            CollectionStyles.comboBoxSearchCity.Items.Clear();
            CollectionStyles.comboBoxSearchCity.Items.Add("--All Cities--");
            CollectionStyles.comboBoxSearchCity.Items.AddRange(CollectionReq.GetCarCities(cityDic["CarBrand"], cityDic["CarModel"], cityDic["CarProdYear"], cityDic["CarGearbox"], cityDic["CarCountry"], cityDic["CarCity"]));
            if (searchDic["CarCity"] == "")
            {
                CollectionStyles.comboBoxSearchCity.SelectedItem = "--All Cities--";
            }
            else
            {
                CollectionStyles.comboBoxSearchCity.SelectedItem = searchDic["CarCity"];
            }
        }

        public static void GenerateComboBoxValues()
        {
            UpdateComboBoxValues();
        }

        public static void ComboBoxSearchBrand_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if(CollectionStyles.comboBoxSearchBrand.SelectedItem.ToString() == "--All Brands--")
            {
                modelDic["CarBrand"] = "";
                yearDic["CarBrand"] = "";
                gearboxDic["CarBrand"] = "";
                countryDic["CarBrand"] = "";
                cityDic["CarBrand"] = "";
                searchDic["CarBrand"] = "";
            }
            else
            {
                modelDic["CarBrand"] = CollectionStyles.comboBoxSearchBrand.SelectedItem.ToString();
                yearDic["CarBrand"] = CollectionStyles.comboBoxSearchBrand.SelectedItem.ToString();
                gearboxDic["CarBrand"] = CollectionStyles.comboBoxSearchBrand.SelectedItem.ToString();
                countryDic["CarBrand"] = CollectionStyles.comboBoxSearchBrand.SelectedItem.ToString();
                cityDic["CarBrand"] = CollectionStyles.comboBoxSearchBrand.SelectedItem.ToString();
                searchDic["CarBrand"] = CollectionStyles.comboBoxSearchBrand.SelectedItem.ToString();
            }

            UpdateComboBoxValues();
        }

        public static void ComboBoxSearchModel_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (CollectionStyles.comboBoxSearchModel.SelectedItem.ToString() == "--All Models--")
            {
                brandDic["CarModel"] = "";
                yearDic["CarModel"] = "";
                gearboxDic["CarModel"] = "";
                countryDic["CarModel"] = "";
                cityDic["CarModel"] = "";
                searchDic["CarModel"] = "";
            }
            else
            {
                brandDic["CarModel"] = CollectionStyles.comboBoxSearchModel.SelectedItem.ToString();
                yearDic["CarModel"] = CollectionStyles.comboBoxSearchModel.SelectedItem.ToString();
                gearboxDic["CarModel"] = CollectionStyles.comboBoxSearchModel.SelectedItem.ToString();
                countryDic["CarModel"] = CollectionStyles.comboBoxSearchModel.SelectedItem.ToString();
                cityDic["CarModel"] = CollectionStyles.comboBoxSearchModel.SelectedItem.ToString();
                searchDic["CarModel"] = CollectionStyles.comboBoxSearchModel.SelectedItem.ToString();
            }

            UpdateComboBoxValues();
        }

        public static void ComboBoxSearchYear_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (CollectionStyles.comboBoxSearchYear.SelectedItem.ToString() == "--All Years--")
            {
                modelDic["CarProdYear"] = "";
                brandDic["CarProdYear"] = "";
                gearboxDic["CarProdYear"] = "";
                countryDic["CarProdYear"] = "";
                cityDic["CarProdYear"] = "";
                searchDic["CarProdYear"] = "";
            }
            else
            {
                modelDic["CarProdYear"] = CollectionStyles.comboBoxSearchYear.SelectedItem.ToString();
                brandDic["CarProdYear"] = CollectionStyles.comboBoxSearchYear.SelectedItem.ToString();
                gearboxDic["CarProdYear"] = CollectionStyles.comboBoxSearchYear.SelectedItem.ToString();
                countryDic["CarProdYear"] = CollectionStyles.comboBoxSearchYear.SelectedItem.ToString();
                cityDic["CarProdYear"] = CollectionStyles.comboBoxSearchYear.SelectedItem.ToString();
                searchDic["CarProdYear"] = CollectionStyles.comboBoxSearchYear.SelectedItem.ToString();
            }

            UpdateComboBoxValues();
        }

        public static void ComboBoxSearchGearbox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (CollectionStyles.comboBoxSearchGearbox.SelectedItem.ToString() == "--All Gearboxes--")
            {
                modelDic["CarGearbox"] = "";
                yearDic["CarGearbox"] = "";
                brandDic["CarGearbox"] = "";
                countryDic["CarGearbox"] = "";
                cityDic["CarGearbox"] = "";
                searchDic["CarGearbox"] = "";
            }
            else
            {
                modelDic["CarGearbox"] = CollectionStyles.comboBoxSearchGearbox.SelectedItem.ToString();
                yearDic["CarGearbox"] = CollectionStyles.comboBoxSearchGearbox.SelectedItem.ToString();
                brandDic["CarGearbox"] = CollectionStyles.comboBoxSearchGearbox.SelectedItem.ToString();
                countryDic["CarGearbox"] = CollectionStyles.comboBoxSearchGearbox.SelectedItem.ToString();
                cityDic["CarGearbox"] = CollectionStyles.comboBoxSearchGearbox.SelectedItem.ToString();
                searchDic["CarGearbox"] = CollectionStyles.comboBoxSearchGearbox.SelectedItem.ToString();
            }

            UpdateComboBoxValues();
        }

        public static void ComboBoxSearchCountry_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (CollectionStyles.comboBoxSearchCountry.SelectedItem.ToString() == "--All Countries--")
            {
                modelDic["CarCountry"] = "";
                yearDic["CarCountry"] = "";
                gearboxDic["CarCountry"] = "";
                brandDic["CarCountry"] = "";
                cityDic["CarCountry"] = "";
                searchDic["CarCountry"] = "";
            }
            else
            {
                modelDic["CarCountry"] = CollectionStyles.comboBoxSearchCountry.SelectedItem.ToString();
                yearDic["CarCountry"] = CollectionStyles.comboBoxSearchCountry.SelectedItem.ToString();
                gearboxDic["CarCountry"] = CollectionStyles.comboBoxSearchCountry.SelectedItem.ToString();
                brandDic["CarCountry"] = CollectionStyles.comboBoxSearchCountry.SelectedItem.ToString();
                cityDic["CarCountry"] = CollectionStyles.comboBoxSearchCountry.SelectedItem.ToString();
                searchDic["CarCountry"] = CollectionStyles.comboBoxSearchCountry.SelectedItem.ToString();
            }

            UpdateComboBoxValues();
        }

        public static void ComboBoxSearchCity_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (CollectionStyles.comboBoxSearchCity.SelectedItem.ToString() == "--All Cities--")
            {
                modelDic["CarCity"] = "";
                yearDic["CarCity"] = "";
                gearboxDic["CarCity"] = "";
                countryDic["CarCity"] = "";
                brandDic["CarCity"] = "";
                searchDic["CarCity"] = "";
            }
            else
            {
                modelDic["CarCity"] = CollectionStyles.comboBoxSearchCity.SelectedItem.ToString();
                yearDic["CarCity"] = CollectionStyles.comboBoxSearchCity.SelectedItem.ToString();
                gearboxDic["CarCity"] = CollectionStyles.comboBoxSearchCity.SelectedItem.ToString();
                countryDic["CarCity"] = CollectionStyles.comboBoxSearchCity.SelectedItem.ToString();
                brandDic["CarCity"] = CollectionStyles.comboBoxSearchCity.SelectedItem.ToString();
                searchDic["CarCity"] = CollectionStyles.comboBoxSearchCity.SelectedItem.ToString();
            }

            UpdateComboBoxValues();
        }

        public static void ButtonSearch_Click(object sender, EventArgs e)
        {
            initialCarGenAmount = 6;
            CollectionStyles.flowLayoutPanelCarCollection.Controls.Clear();
            GenerateCollection(CollectionStyles.flowLayoutPanelCarCollection, initialCarGenAmount, initialCarGenAmount - 6);
            if ((CollectionStyles.flowLayoutPanelCarCollection.AutoScrollMinSize.Height - 25) / 65 > CollectionStyles.flowLayoutPanelCarCollection.Controls.Count)
            {
                CollectionStyles.buttonLoadMore.Enabled = false;
            }
            else
            {
                CollectionStyles.buttonLoadMore.Enabled = true;
            }
            Console.WriteLine((CollectionStyles.flowLayoutPanelCarCollection.AutoScrollMinSize.Height + 46) / 65);
            Console.WriteLine(CollectionStyles.flowLayoutPanelCarCollection.Controls.Count);
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

                try
                {
                    if(favs.Where(f => f.CarId == currentCar.CarId).Count() > 0)
                    {
                        isFav = true;

                    }
                    else
                    {
                        isFav = false;

                    }
                }
                catch
                {
                    isFav = false;
                }


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
                float.Parse(currentCar.CarPrice.ToString()),
                isFav,
                CollectionReq.GetCarIsReserved(currentCar.CarId)
                );
            };
        }

        public static void ButtonPopupReserve_Click(object sender, EventArgs e)
        {
            CollectionReq.AddReservation(
                currentUserUsername,
                int.Parse(CollectionStyles.buttonPopupReserve.Name.Split('.')[1].ToString()),
                CollectionStyles.dateTimePickerPopupDate.Value.ToShortDateString());

            CollectionStyles.dateTimePickerPopupDate.Enabled = false;

            CollectionReq.SetCarIsReservedTrue(int.Parse(CollectionStyles.buttonPopupReserve.Name.Split('.')[1].ToString()));
            CollectionStyles.buttonPopupReserve.Text = "Reserved";
            CollectionStyles.buttonPopupReserve.Enabled = false;
            CollectionStyles.buttonPopupReserve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            CollectionStyles.buttonPopupReserve.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));

            MessageBox.Show($"You have reserved a test a drive on {CollectionStyles.dateTimePickerPopupDate.Value.ToShortDateString()}", "Reservation success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
