using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DreamCar.Data;
using DreamCar.Forms.Publish;
using DreamCar.Helpers;
using DreamCar.Models;

namespace DreamCar.Forms.Publication
{
    public class PublicationStyles
    {
        public PublicationStyles()
        {

        }

        public static Car CreateNewCar(string currentUserUsername, int currentUserPublishCount, string imageUrl, string reservationDateStart, string reservationDateEnd)
        {
            return new Car()
            {
                CarName = currentUserUsername + "_" + currentUserPublishCount,
                CarPrice = int.Parse(Publication.textBoxCarPrice.Text),
                CarReservationDateStart = reservationDateStart,
                CarReservationDateEnd = reservationDateEnd,
                CarIsSold = false,
                CarIsReserved = false,
                CarImageUrl = imageUrl,
                CarAuthor = currentUserUsername,
                CarColor = Publication.textBoxCarColor.Text,
                CarCity = Publication.textBoxCarCity.Text,
                CarCountry = Publication.textBoxCarCountry.Text,
                CarGearbox = Publication.textBoxCardGearbox.Text,
                CarFuel = Publication.textBoxCarFuel.Text,
                CarCapacity = int.Parse(Publication.textBoxCarCapacity.Text),
                CarProdYear = int.Parse(Publication.textBoxCardProdYear.Text),
                CarBrand = Publication.textBoxCardBrand.Text,
                CarModel = Publication.textBoxCarModel.Text,
                CarTags = Publication.textBoxCarTags.Text,
                UserId = Publication.currentUserId,
                Publications = new List<Models.Publication>() {
                            new Models.Publication() { PublishAuthor = currentUserUsername }
                },
            };
        }
    }
}
