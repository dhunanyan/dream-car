using DreamCar.Data;
using DreamCar.Helpers;
using DreamCar.Models;
using DreamCar.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DreamCar.Forms
{
    public partial class FormCollection : Container
    {
        public FormCollection()
        {
            InitializeComponent();
            GenerateCollection();

            //DreamCarContext contextFavs = new DreamCarContext();
            //var favsRecord = from fav in contextFavs.Set<Favourite>() where fav.UserId == currentUserId select fav;

            //foreach (var fav in favsRecord.ToList())
            //{
            //    DreamCarContext contextCars = new DreamCarContext();
            //    var carRecord = from car in contextFavs.Set<Favourite>() where car.CarId == fav.CarId select car;

            //}
        }

        private void GenerateCollection()
        {
            DreamCarContext contextAllFavs = new DreamCarContext();
            DreamCarContext contextCar = new DreamCarContext();
            var currentfavRecord = contextAllFavs.Favourite.Where(c => c.FavouriteAuthor == currentUserUsername);
            // 
            // flowLayoutPanelCarCollection
            // 
            flowLayoutPanelCarCollection.AutoScroll = true;
            flowLayoutPanelCarCollection.AutoScrollMinSize = new Size(0, (65 * contextCar.Cars.ToList().Count()) + 45);
            flowLayoutPanelCarCollection.BackColor = Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(110)))));
            flowLayoutPanelCarCollection.Location = new Point(16, 109);
            flowLayoutPanelCarCollection.Margin = new Padding(0);
            flowLayoutPanelCarCollection.Name = "flowLayoutPanelCarCollection";
            flowLayoutPanelCarCollection.Padding = new Padding(5);
            flowLayoutPanelCarCollection.Size = new Size(1020, 541);
            flowLayoutPanelCarCollection.TabIndex = 0;


            foreach (var car in contextCar.Cars)
            {
                bool isFav = false;
                if (currentfavRecord.Where(f => f.CarId == car.CarId).Count() > 0)
                {
                    isFav = true;
                }

                GenerateCar(car.CarImageUrl, car.CarBrand, car.CarModel, car.CarProdYear.ToString(), car.CarFuel, car.CarGearbox, car.CarId, isFav);
            }
        }

        private void GenerateCar(string image, string brand, string model, string year, string fuel, string gearbox, int carId, bool isFav)
        {

            flowLayoutPanelCurrentCar = new FlowLayoutPanel();
            labelCurrentCarBrand = new Label();
            labelCurrentCarModel = new Label();
            labelCurrentCarProdYear = new Label();
            labelCurrentCarFuel = new Label();
            labelCurrentCarGearbox = new Label();
            panelCurrentCarImage = new Panel();
            buttonCurrentCarMore = new Button();
            buttonCurrentCarFav = new Button();
            flowLayoutPanelCurrentCar.SuspendLayout();

            // 
            // flowLayoutPanelCurrentCar
            // 
            flowLayoutPanelCurrentCar.BackColor = Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(127)))));
            flowLayoutPanelCurrentCar.Controls.Add(panelCurrentCarImage);
            flowLayoutPanelCurrentCar.Controls.Add(labelCurrentCarBrand);
            flowLayoutPanelCurrentCar.Controls.Add(labelCurrentCarModel);
            flowLayoutPanelCurrentCar.Controls.Add(labelCurrentCarProdYear);
            flowLayoutPanelCurrentCar.Controls.Add(labelCurrentCarFuel);
            flowLayoutPanelCurrentCar.Controls.Add(labelCurrentCarGearbox); 
            flowLayoutPanelCurrentCar.Controls.Add(buttonCurrentCarFav);
            flowLayoutPanelCurrentCar.Controls.Add(buttonCurrentCarMore);
            flowLayoutPanelCurrentCar.Location = new Point(5, 5);
            flowLayoutPanelCurrentCar.Margin = new Padding(0, 0, 0, 5);
            flowLayoutPanelCurrentCar.Name = "flowLayoutPanelCar" + "." + carId.ToString();
            flowLayoutPanelCurrentCar.Padding = new Padding(5);
            flowLayoutPanelCurrentCar.Size = new Size(993, 65);
            flowLayoutPanelCurrentCar.TabIndex = 0;
            // 
            // labelCurrentCarBrand
            // 
            labelCurrentCarBrand.BackColor = Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(110)))));
            labelCurrentCarBrand.Font = new Font("Tw Cen MT Condensed", 18F, FontStyle.Bold);
            labelCurrentCarBrand.ForeColor = Color.Gainsboro;
            labelCurrentCarBrand.Location = new Point(68, 5);
            labelCurrentCarBrand.Margin = new Padding(0, 0, 5, 0);
            labelCurrentCarBrand.Name = "labelCarBrand" + "." + carId.ToString();
            labelCurrentCarBrand.Size = new Size(210, 55);
            labelCurrentCarBrand.TabIndex = 0;
            labelCurrentCarBrand.Text = brand;
            labelCurrentCarBrand.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelCurrentCarModel
            // 
            labelCurrentCarModel.BackColor = Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(110)))));
            labelCurrentCarModel.Font = new Font("Tw Cen MT Condensed", 18F, FontStyle.Bold);
            labelCurrentCarModel.ForeColor = Color.Gainsboro;
            labelCurrentCarModel.Location = new Point(303, 5);
            labelCurrentCarModel.Margin = new Padding(0, 0, 5, 0);
            labelCurrentCarModel.Name = "labelCarModel" + "." + carId.ToString();
            labelCurrentCarModel.Size = new Size(210, 55);
            labelCurrentCarModel.TabIndex = 1;
            labelCurrentCarModel.Text = model;
            labelCurrentCarModel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelCurrentCarProdYear
            // 
            labelCurrentCarProdYear.BackColor = Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(110)))));
            labelCurrentCarProdYear.Font = new Font("Tw Cen MT Condensed", 18F, FontStyle.Bold);
            labelCurrentCarProdYear.ForeColor = Color.Gainsboro;
            labelCurrentCarProdYear.Location = new Point(577, 5);
            labelCurrentCarProdYear.Margin = new Padding(0, 0, 5, 0);
            labelCurrentCarProdYear.Name = "labelCarProdYear" + "." + carId.ToString();
            labelCurrentCarProdYear.Size = new Size(90, 55);
            labelCurrentCarProdYear.TabIndex = 2;
            labelCurrentCarProdYear.Text = year;
            labelCurrentCarProdYear.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelCurrentCarFuel
            // 
            labelCurrentCarFuel.BackColor = Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(110)))));
            labelCurrentCarFuel.Font = new Font("Tw Cen MT Condensed", 18F, FontStyle.Bold);
            labelCurrentCarFuel.ForeColor = Color.Gainsboro;
            labelCurrentCarFuel.Location = new Point(670, 5);
            labelCurrentCarFuel.Margin = new Padding(0, 0, 5, 0);
            labelCurrentCarFuel.Name = "labelCarFuel" + "." + carId.ToString();
            labelCurrentCarFuel.Size = new Size(140, 55);
            labelCurrentCarFuel.TabIndex = 3;
            labelCurrentCarFuel.Text = fuel;
            labelCurrentCarFuel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelCurrentCarGearbox
            // 
            labelCurrentCarGearbox.BackColor = Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(110)))));
            labelCurrentCarGearbox.Font = new Font("Tw Cen MT Condensed", 18F, FontStyle.Bold);
            labelCurrentCarGearbox.ForeColor = Color.Gainsboro;
            labelCurrentCarGearbox.Location = new Point(817, 5);
            labelCurrentCarGearbox.Margin = new Padding(0, 0, 5, 0);
            labelCurrentCarGearbox.Name = "labelCarGearbox" + "." + carId.ToString();
            labelCurrentCarGearbox.Size = new Size(123, 55);
            labelCurrentCarGearbox.TabIndex = 4;
            labelCurrentCarGearbox.Text = gearbox;
            labelCurrentCarGearbox.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelCurrentCarImage
            // 
            panelCurrentCarImage.BackColor = Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(110)))));
            panelCurrentCarImage.BackgroundImage = setBackgroungImageUrl(image);
            panelCurrentCarImage.BackgroundImageLayout = ImageLayout.Zoom;
            panelCurrentCarImage.Location = new Point(5, 5);
            panelCurrentCarImage.Margin = new Padding(0, 0, 5, 0);
            panelCurrentCarImage.Name = "panelCarImage" + "." + carId.ToString();
            panelCurrentCarImage.Size = new Size(58, 55);
            panelCurrentCarImage.TabIndex = 0;
            // 
            // buttonCurrentCarFav
            // 
            buttonCurrentCarFav.BackColor = Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(143)))));
            buttonCurrentCarFav.BackgroundImage = isFav? Resources.starFilled: Resources.starEmpty;
            buttonCurrentCarFav.BackgroundImageLayout = ImageLayout.Center;
            buttonCurrentCarFav.Cursor = Cursors.Hand;
            buttonCurrentCarFav.FlatAppearance.BorderSize = 0;
            buttonCurrentCarFav.FlatStyle = FlatStyle.Flat;
            buttonCurrentCarFav.Font = new Font("Tw Cen MT Condensed", 18F, FontStyle.Bold);
            buttonCurrentCarFav.Location = new Point(947, 5);
            buttonCurrentCarFav.Margin = new Padding(0, 0, 5, 0);
            buttonCurrentCarFav.Name = "buttonCarFav" + "." + carId.ToString();
            buttonCurrentCarFav.Size = new Size(58, 55);
            buttonCurrentCarFav.TabIndex = 1;
            buttonCurrentCarFav.UseVisualStyleBackColor = false;
            buttonCurrentCarFav.Click += new EventHandler(ButtonCurrentCarFav_Click);
            // 
            // buttonCurrentCarMore
            // 
            buttonCurrentCarMore.BackColor = Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(143)))));
            buttonCurrentCarMore.BackgroundImage = Resources.threeDots;
            buttonCurrentCarMore.BackgroundImageLayout = ImageLayout.Center;
            buttonCurrentCarMore.Cursor = Cursors.Hand;
            buttonCurrentCarMore.FlatAppearance.BorderSize = 0;
            buttonCurrentCarMore.FlatStyle = FlatStyle.Flat;
            buttonCurrentCarMore.Font = new Font("Tw Cen MT Condensed", 18F, FontStyle.Bold);
            buttonCurrentCarMore.Location = new Point(947, 5);
            buttonCurrentCarMore.Margin = new Padding(0);
            buttonCurrentCarMore.Name = "buttonCarMore" + "." + carId.ToString();
            buttonCurrentCarMore.Size = new Size(58, 55);
            buttonCurrentCarMore.TabIndex = 1;
            buttonCurrentCarMore.UseVisualStyleBackColor = false;
            buttonCurrentCarMore.Click += new EventHandler(ButtonCurrentCarMore_Click);


            flowLayoutPanelCarCollection.Controls.Add(flowLayoutPanelCurrentCar);
            flowLayoutPanelCurrentCar.ResumeLayout(false);
        }

        private void ButtonCurrentCarFav_Click(object sender, EventArgs e)
        {
            Button currentFavButton = (Button)sender;
            currentFavButton.BackgroundImage = Resources.starFilled;

            using (DreamCarContext contextInner = new DreamCarContext())
            {
                DreamCarContext contextCar = new DreamCarContext();
                var currentCarRecord = contextCar.Cars.Where(c => c.UserId == currentUserId).FirstOrDefault();
                if (currentCarRecord != null)
                {
                    var favs = contextInner.Favourite;
                    foreach (var f in favs)
                    {
                        if (f.FavouriteAuthor == currentUserUsername)
                        {
                            f.CarId = currentCarRecord.CarId;
                        }
                    }
                }
                contextCar.SaveChanges();
                contextInner.SaveChanges();
            }
        }

        private void ButtonCurrentCarMore_Click(object sender, EventArgs e)
        {
            
           
        }
    }
}
