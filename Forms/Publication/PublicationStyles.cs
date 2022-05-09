using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DreamCar.Data;
using DreamCar.Forms.Publication;
using DreamCar.Helpers;
using DreamCar.Models;
using DreamCar.Properties;

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

        public static void AddCarReset()
        {
            Publication.imageUrl = "";
            Publication.ClearForm();
            Publication.labelLoadingProgress.Text = "0%";
            Publication.buttonAddImage.Text = "200 x 200";
            Publication.buttonAddImage.BackgroundImage = Resources.addImageGreen;
            Publication.buttonAddImage.BackgroundImageLayout = ImageLayout.Center;

            Publication.monthCalendar = new MonthCalendar();
            Publication.monthCalendar.Anchor = AnchorStyles.None;
            Publication.monthCalendar.Location = new Point(17, 211);
            Publication.monthCalendar.Margin = new Padding(0, 0, 13, 0);
            Publication.monthCalendar.MaxSelectionCount = 62;
            Publication.monthCalendar.Name = "monthCalendar";
            Publication.monthCalendar.ShowToday = false;
            Publication.monthCalendar.ShowTodayCircle = false;
            Publication.monthCalendar.TabIndex = 13;
            Publication.monthCalendar.DateSelected += new DateRangeEventHandler(Publication.MonthCalendar_DateSelected);
        }
    }
}
