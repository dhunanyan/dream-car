using DreamCar.Data;
using DreamCar.Helpers;
using DreamCar.Models;
using DreamCar.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace DreamCar.Forms.Collection
{
    public partial class Collection : Container
    {
        public Collection()
        {
            InitializeComponent();
            GenerateCollection();
        }

        private static void GenerateCollection()
        {
            using (DreamCarContext context = new DreamCarContext())
            {
                using (DreamCarContext contexInner = new DreamCarContext())
                {
                    List<Favourite> currentFavRecord = CollectionReq.GetFavsByUsername(contexInner, currentUserUsername);
                    CollectionStyles.GerenerateCollectionContainer(context);
                    foreach (var car in context.Cars)
                    {
                        bool isFav = false;
                        if (currentFavRecord.Where(f => f.CarId == car.CarId).Count() > 0)
                        {
                            isFav = true;
                        }

                        CollectionStyles.GenerateCar(car.CarImageUrl, car.CarBrand, car.CarModel, car.CarProdYear.ToString(), car.CarFuel, car.CarGearbox, car.CarId, isFav);
                    }
                }
            }
        }

        public static void ButtonCurrentCarFav_Click(object sender, EventArgs e)
        {
            using (DreamCarContext context = new DreamCarContext())
            {
                Button currentFavButton = (Button)sender;
                bool isFav = bool.Parse(currentFavButton.Tag.ToString());
                Car currentCarRecord = CollectionReq.GetCarById(context, int.Parse(currentFavButton.Name.Split('.')[1]));

                if (!isFav)
                {
                    currentFavButton.BackgroundImage = Resources.starFilled;
                    currentFavButton.Tag = "true";
                    currentCarRecord.Favourites = new List<Favourite>() {
                            new Favourite() {
                                FavouriteAuthor = currentUserUsername,
                                CarId = currentCarRecord.CarId,
                            }
                    };
                }
                else
                {
                    currentFavButton.BackgroundImage = Resources.starEmpty;
                    currentFavButton.Tag = "false";
                    context.Favourites.Remove(context.Favourites.Where(f => f.CarId == currentCarRecord.CarId).FirstOrDefault());
                }
                context.SaveChanges();
                
            }
        }

        public static void ButtonCurrentCarMore_Click(object sender, EventArgs e)
        {
            
           
        }
    }
}
