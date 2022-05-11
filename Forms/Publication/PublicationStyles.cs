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
                CarPrice = int.Parse(textBoxCarPrice.Text),
                CarReservationDateStart = reservationDateStart,
                CarReservationDateEnd = reservationDateEnd,
                CarIsSold = false,
                CarIsReserved = false,
                CarImageUrl = imageUrl,
                CarAuthor = currentUserUsername,
                CarColor = textBoxCarColor.Text,
                CarCity = textBoxCarCity.Text,
                CarCountry = textBoxCarCountry.Text,
                CarGearbox = textBoxCardGearbox.Text,
                CarFuel = textBoxCarFuel.Text,
                CarCapacity = int.Parse(textBoxCarCapacity.Text),
                CarProdYear = int.Parse(textBoxCardProdYear.Text),
                CarBrand = textBoxCardBrand.Text,
                CarModel = textBoxCarModel.Text,
                CarTags = textBoxCarTags.Text,
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
            labelLoadingProgress.Text = "0%";
            buttonAddImage.Text = "200 x 200";
            buttonAddImage.BackgroundImage = Resources.addImageGreen;
            buttonAddImage.BackgroundImageLayout = ImageLayout.Center;

            monthCalendar = new MonthCalendar();
            monthCalendar.Anchor = AnchorStyles.None;
            monthCalendar.Location = new Point(17, 211);
            monthCalendar.Margin = new Padding(0, 0, 13, 0);
            monthCalendar.MaxSelectionCount = 62;
            monthCalendar.Name = "monthCalendar";
            monthCalendar.ShowToday = false;
            monthCalendar.ShowTodayCircle = false;
            monthCalendar.TabIndex = 13;
            monthCalendar.DateSelected += new DateRangeEventHandler(Publication.MonthCalendar_DateSelected);
        }

        public static Panel panel1;
        public static FlowLayoutPanel SignUp;
        public static Label labelPublish;
        public static FlowLayoutPanel flowLayoutPanel2;
        public static Label labelCarBrand;
        public static Label labelCarModel;
        public static Label labelCarProdYear;
        public static TextBox textBoxCarModel;
        public static TextBox textBoxCardProdYear;
        public static Label labelCarCapacity;
        public static Label labelCarFuel;
        public static Label labelCarGearbox;
        public static TextBox textBoxCarCapacity;
        public static TextBox textBoxCarFuel;
        public static TextBox textBoxCardGearbox;
        public static Label labelCarCountry;
        public static Label labelCarCity;
        public static TextBox textBoxCarCountry;
        public static TextBox textBoxCarCity;
        public static Label labelCarColor;
        public static Label labelCarTags;
        public static TextBox textBoxCarColor;
        public static TextBox textBoxCarTags;
        public static Button buttonPost;
        public static Button buttonClear;
        public static TextBox textBoxCardBrand;
        public static MonthCalendar monthCalendar;
        public static FlowLayoutPanel flowLayoutPanel1;
        public static Button buttonAddImage;
        public static Panel panel2;
        public static Panel panelLoadingBar;
        public static Label labelLoadingProgress;
        public static TextBox textBoxCarPrice;
        public static Label labelCarPrice;
    }
}
