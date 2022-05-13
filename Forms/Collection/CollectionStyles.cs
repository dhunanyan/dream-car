using DreamCar.Data;
using DreamCar.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DreamCar.Forms.Collection;
using DreamCar.Models;

namespace DreamCar.Forms.Collection
{
    public partial class CollectionStyles
    {
        public CollectionStyles()
        {
            //Console.WriteLine(currentUser);
        }

        public static void InitializeComponent(Form form)
        {

        }

        public static void GerenerateCollectionContainer(Form form, FlowLayoutPanel flow, int take)
        {
            form.ResumeLayout(true);
            // 
            // flowLayoutPanelCarCollection
            // 
            panelMain = new Panel
            {
                Name = "panelMain",
                TabIndex = 0,
                Dock = DockStyle.Fill,
                Location = new Point(15, 15),
                Padding = new Padding(30, 30, 30, 30),
                Size = new Size(1576, 1064)
            };
            flow.SuspendLayout();
            flow.AutoScroll = true;
            flow.AutoScrollMinSize = new Size(0, (65 * take) + 25);
            flow.BackColor = Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(110)))));
            flow.Margin = new Padding(0);
            flow.Name = "flowLayoutPanelCarCollection_" + take.ToString();
            flow.Padding = new Padding(5);
            flow.Location = new Point(take == 6 ? 35 : 25, 200);
            flow.Size = new Size(take == 6 ? 1000 : 1020, take == 6 ? 65 * 6 + 25 : 65 * 6 + 30);
            flow.MinimumSize = new Size(take == 6 ? 1000 : 1020, take == 6 ? 65 * 6 + 25 : 65 * 6 + 30);
            flow.TabIndex = 0;
            panelMain.Controls.Add(flow);
            flow.ResumeLayout(false);
            // 
            // Collection
            // 
            form.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            form.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            form.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(93)))));
            form.ClientSize = new System.Drawing.Size(1606, 1094);
            form.Controls.Add(panelMain);
            form.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            form.Name = "Collection";
            form.Padding = new System.Windows.Forms.Padding(15);
            form.Text = "FormCollection";
            form.ResumeLayout(false);
        }

        public static void ChangeCollectionContainerScrollMinSize(int take)
        {
            flowLayoutPanelCarCollection.Location = new Point(take == 6 ? 35 : 25, 200);
            flowLayoutPanelCarCollection.Size = new Size(take == 6 ? 1000 : 1020, 65 * 6 + 30);
            flowLayoutPanelCarCollection.AutoScrollMinSize = new Size(0, (65 * take) + 25);
        }

        public static void GenerateCar(FlowLayoutPanel flow, string image, string brand, string model, string year, string fuel, string gearbox, int carId, bool isFav, int take)
        {
            if(take == 4)
            {
                flowLayoutPanelCarCollection.SuspendLayout();

            }
            else
            {
                flowLayoutPanelCarCollection.ResumeLayout(true);

            }
            flowLayoutPanelCurrentCar = new FlowLayoutPanel();
            labelCurrentCarBrand = new Label();
            labelCurrentCarModel = new Label();
            labelCurrentCarProdYear = new Label();
            labelCurrentCarFuel = new Label();
            labelCurrentCarGearbox = new Label();
            panelCurrentCarImage = new Panel();
            buttonCurrentCarMore = new Button();
            buttonCurrentCarFav = new Button();
            flowLayoutPanelCurrentCar.ResumeLayout(true);
            // 
            // flowLayoutPanelCurrentCar
            // 
            flowLayoutPanelCurrentCar.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            flowLayoutPanelCurrentCar.MaximumSize = new Size(993, 65);
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
            panelCurrentCarImage.BackgroundImage = Collection.setBackgroungImageUrl(image);
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
            buttonCurrentCarFav.BackgroundImage = isFav ? Resources.starFilled : Resources.starEmpty;
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
            buttonCurrentCarFav.Tag = isFav ? "true" : "false";
            buttonCurrentCarFav.UseVisualStyleBackColor = false;
            buttonCurrentCarFav.Click += new EventHandler(ButtonCarFav_Click);
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
            buttonCurrentCarMore.Click += new EventHandler(Collection.ButtonCurrentCarMore_Click);

            //FlowLayoutPanel currentPanelContainer = (FlowLayoutPanel)Collection.panelMain.Controls.Find("flowLayoutPanelCarCollection_" + take.ToString(), true)[0];
            //currentPanelContainer.Controls.Add(flowLayoutPanelCurrentCar); 
            flow.Controls.Add(flowLayoutPanelCurrentCar);
            flowLayoutPanelCurrentCar.ResumeLayout(false);
        }

        public static void GenerateDetails(
            int carId,
            string username, 
            string brand, 
            string model, 
            string country, 
            string city, 
            string fuel, 
            string gearbox, 
            int year, 
            int capacity, 
            string tags, 
            string startDate, 
            string endDate, 
            string imgUrl,
            float price,
            bool isFav,
            bool isReserved)
            {
            flowLayoutPanelPopup = new FlowLayoutPanel();
            panelPopupTop = new Panel();
            buttonPopupClose = new Button();
            flowLayoutPanelPopupContainer = new FlowLayoutPanel();
            panelPopupImg = new Panel();
            flowLayoutPanelPopupContent = new FlowLayoutPanel();
            labelPopupBrand = new Label();
            labelPopupModel = new Label();
            labelPopupCountry = new Label();
            labelPopupCity = new Label();
            labelPopupFuel = new Label();
            labelPopupGearbox = new Label();
            labelPopupProdYear = new Label();
            labelPopupCapacity = new Label();
            labelPopupUsername = new Label();
            flowLayoutPanelPopupTags = new FlowLayoutPanel();
            labelPopupTag = new Label();
            labelPopupTags = new Label();
            flowLayoutPanelPopupDatesContainer = new FlowLayoutPanel();
            flowLayoutPanelPopupDates = new FlowLayoutPanel();
            labelPopupStartDate = new Label();
            labelPopupBetweenDates = new Label();
            labelPopupPrice = new Label();
            labelPopupEndDate = new Label();
            buttonPopupReserve = new Button();
            buttonPopupFav = new Button();
            dateTimePickerPopupDate = new DateTimePicker();
            flowLayoutPanelPopup.SuspendLayout();
            panelPopupTop.SuspendLayout();
            flowLayoutPanelPopupContainer.SuspendLayout();
            flowLayoutPanelPopupContent.SuspendLayout();
            flowLayoutPanelPopupTags.SuspendLayout();
            flowLayoutPanelPopupDatesContainer.SuspendLayout();
            flowLayoutPanelPopupDates.SuspendLayout();
            // 
            // flowLayoutPanelPopup
            // 
            flowLayoutPanelPopup.Controls.Add(panelPopupTop);
            flowLayoutPanelPopup.Controls.Add(flowLayoutPanelPopupContainer);
            flowLayoutPanelPopup.Location = new System.Drawing.Point(120, 50);
            flowLayoutPanelPopup.Margin = new Padding(0);
            flowLayoutPanelPopup.Name = "flowLayoutPanelPopup" + "." + carId;
            flowLayoutPanelPopup.Size = new System.Drawing.Size(797, 545);
            flowLayoutPanelPopup.TabIndex = 0;
            flowLayoutPanelPopup.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // panelPopupTop
            // 
            panelPopupTop.BackColor = System.Drawing.Color.FromArgb(51, 51, 76);
            panelPopupTop.Controls.Add(buttonPopupClose);
            panelPopupTop.Location = new System.Drawing.Point(0, 0);
            panelPopupTop.Margin = new Padding(0);
            panelPopupTop.Name = "panelPopupTop" + "." + carId;
            panelPopupTop.Size = new System.Drawing.Size(800, 30);
            panelPopupTop.TabIndex = 0;
            // 
            // buttonPopupClose
            // 
            buttonPopupClose.BackgroundImage = global::DreamCar.Properties.Resources.times;
            buttonPopupClose.BackgroundImageLayout = ImageLayout.Center;
            buttonPopupClose.Cursor = Cursors.Hand;
            buttonPopupClose.FlatAppearance.BorderSize = 0;
            buttonPopupClose.FlatStyle = FlatStyle.Flat;
            buttonPopupClose.Location = new System.Drawing.Point(773, 3);
            buttonPopupClose.Name = "buttonPopupClose" + "." + carId;
            buttonPopupClose.Size = new System.Drawing.Size(24, 24);
            buttonPopupClose.TabIndex = 1;
            buttonPopupClose.UseVisualStyleBackColor = true;
            buttonPopupClose.Click += new EventHandler(DeleteMoreDetails);
            // 
            // flowLayoutPanelPopupContainer
            // 
            flowLayoutPanelPopupContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            flowLayoutPanelPopupContainer.Controls.Add(panelPopupImg);
            flowLayoutPanelPopupContainer.Controls.Add(flowLayoutPanelPopupContent);
            flowLayoutPanelPopupContainer.Controls.Add(flowLayoutPanelPopupTags);
            flowLayoutPanelPopupContainer.Controls.Add(labelPopupPrice);
            flowLayoutPanelPopupContainer.Controls.Add(flowLayoutPanelPopupDatesContainer);
            flowLayoutPanelPopupContainer.Controls.Add(buttonPopupReserve);
            flowLayoutPanelPopupContainer.Controls.Add(buttonPopupFav);
            flowLayoutPanelPopupContainer.Location = new System.Drawing.Point(0, 30);
            flowLayoutPanelPopupContainer.Margin = new Padding(0);
            flowLayoutPanelPopupContainer.Name = "flowLayoutPanelPopupContainer" + "." + carId;
            flowLayoutPanelPopupContainer.Padding = new Padding(30);
            flowLayoutPanelPopupContainer.Size = new System.Drawing.Size(797, 515);
            flowLayoutPanelPopupContainer.TabIndex = 1;
            // 
            // panelPopupImg
            // 
            panelPopupImg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            panelPopupImg.BackgroundImage = DreamCar.Helpers.Container.setBackgroungImageUrl(imgUrl);
            panelPopupImg.BackgroundImageLayout = ImageLayout.Zoom;
            panelPopupImg.Location = new System.Drawing.Point(30, 30);
            panelPopupImg.Margin = new Padding(0, 0, 15, 0);
            panelPopupImg.Name = "panelPopupImg" + "." + carId;
            panelPopupImg.Size = new System.Drawing.Size(270, 271);
            panelPopupImg.TabIndex = 0;
            // 
            // flowLayoutPanelPopupContent
            // 
            flowLayoutPanelPopupContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            flowLayoutPanelPopupContent.Controls.Add(labelPopupBrand);
            flowLayoutPanelPopupContent.Controls.Add(labelPopupModel);
            flowLayoutPanelPopupContent.Controls.Add(labelPopupCountry);
            flowLayoutPanelPopupContent.Controls.Add(labelPopupCity);
            flowLayoutPanelPopupContent.Controls.Add(labelPopupFuel);
            flowLayoutPanelPopupContent.Controls.Add(labelPopupGearbox);
            flowLayoutPanelPopupContent.Controls.Add(labelPopupProdYear);
            flowLayoutPanelPopupContent.Controls.Add(labelPopupCapacity);
            flowLayoutPanelPopupContent.Controls.Add(labelPopupUsername);
            flowLayoutPanelPopupContent.Location = new System.Drawing.Point(315, 30);
            flowLayoutPanelPopupContent.Margin = new Padding(0);
            flowLayoutPanelPopupContent.Name = "flowLayoutPanelPopupContent" + "." + carId;
            flowLayoutPanelPopupContent.Size = new System.Drawing.Size(452, 271);
            flowLayoutPanelPopupContent.TabIndex = 1;
            // 
            // labelPopupBrand
            // 
            labelPopupBrand.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            labelPopupBrand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            labelPopupBrand.Location = new System.Drawing.Point(5, 5);
            labelPopupBrand.Margin = new Padding(5, 5, 0, 5);
            labelPopupBrand.Name = "labelPopupBrand" + "." + carId;
            labelPopupBrand.Size = new System.Drawing.Size(215, 45);
            labelPopupBrand.TabIndex = 0;
            labelPopupBrand.Text = brand;
            // 
            // labelPopupModel
            // 
            labelPopupModel.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            labelPopupModel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            labelPopupModel.Location = new System.Drawing.Point(225, 5);
            labelPopupModel.Margin = new Padding(5, 5, 0, 5);
            labelPopupModel.Name = "labelPopupModel" + "." + carId;
            labelPopupModel.Size = new System.Drawing.Size(215, 45);
            labelPopupModel.TabIndex = 1;
            labelPopupModel.Text = model;
            // 
            // labelPopupCountry
            // 
            labelPopupCountry.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            labelPopupCountry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            labelPopupCountry.Location = new System.Drawing.Point(5, 60);
            labelPopupCountry.Margin = new Padding(5, 5, 0, 5);
            labelPopupCountry.Name = "labelPopupCountry" + "." + carId;
            labelPopupCountry.Size = new System.Drawing.Size(215, 45);
            labelPopupCountry.TabIndex = 6;
            labelPopupCountry.Text = country;
            // 
            // labelPopupCity
            // 
            labelPopupCity.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            labelPopupCity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            labelPopupCity.Location = new System.Drawing.Point(225, 60);
            labelPopupCity.Margin = new Padding(5, 5, 0, 5);
            labelPopupCity.Name = "labelPopupCity" + "." + carId;
            labelPopupCity.Size = new System.Drawing.Size(215, 45);
            labelPopupCity.TabIndex = 7;
            labelPopupCity.Text = city;
            // 
            // labelPopupFuel
            // 
            labelPopupFuel.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            labelPopupFuel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            labelPopupFuel.Location = new System.Drawing.Point(5, 115);
            labelPopupFuel.Margin = new Padding(5, 5, 0, 5);
            labelPopupFuel.Name = "labelPopupFuel" + "." + carId;
            labelPopupFuel.Size = new System.Drawing.Size(215, 45);
            labelPopupFuel.TabIndex = 2;
            labelPopupFuel.Text = fuel;
            // 
            // labelPopupGearbox
            // 
            labelPopupGearbox.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            labelPopupGearbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            labelPopupGearbox.Location = new System.Drawing.Point(225, 115);
            labelPopupGearbox.Margin = new Padding(5, 5, 0, 5);
            labelPopupGearbox.Name = "labelPopupGearbox" + "." + carId;
            labelPopupGearbox.Size = new System.Drawing.Size(215, 45);
            labelPopupGearbox.TabIndex = 3;
            labelPopupGearbox.Text = gearbox;
            // 
            // labelPopupProdYear
            // 
            labelPopupProdYear.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            labelPopupProdYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            labelPopupProdYear.Location = new System.Drawing.Point(5, 170);
            labelPopupProdYear.Margin = new Padding(5, 5, 0, 5);
            labelPopupProdYear.Name = "labelPopupProdYear" + "." + carId;
            labelPopupProdYear.Size = new System.Drawing.Size(215, 45);
            labelPopupProdYear.TabIndex = 4;
            labelPopupProdYear.Text = year.ToString();
            // 
            // labelPopupCapacity
            // 
            labelPopupCapacity.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            labelPopupCapacity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            labelPopupCapacity.Location = new System.Drawing.Point(225, 170);
            labelPopupCapacity.Margin = new Padding(5, 5, 0, 5);
            labelPopupCapacity.Name = "labelPopupCapacity" + "." + carId;
            labelPopupCapacity.Size = new System.Drawing.Size(215, 45);
            labelPopupCapacity.TabIndex = 5;
            labelPopupCapacity.Text = capacity + "cm3";
            // 
            // labelPopupUsername
            // 
            labelPopupUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(184)))), ((int)(((byte)(119)))));
            labelPopupUsername.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            labelPopupUsername.ForeColor = System.Drawing.Color.Gainsboro;
            labelPopupUsername.Location = new System.Drawing.Point(0, 220);
            labelPopupUsername.Margin = new Padding(0);
            labelPopupUsername.Name = "labelPopupUsername" + "." + carId;
            labelPopupUsername.Size = new System.Drawing.Size(452, 51);
            labelPopupUsername.TabIndex = 8;
            labelPopupUsername.Text = username;
            labelPopupUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanelPopupTags
            // 
            flowLayoutPanelPopupTags.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            flowLayoutPanelPopupTags.Controls.Add(labelPopupTag);
            flowLayoutPanelPopupTags.Controls.Add(labelPopupTags);
            flowLayoutPanelPopupTags.Location = new System.Drawing.Point(30, 316);
            flowLayoutPanelPopupTags.Margin = new Padding(0, 15, 15, 0);
            flowLayoutPanelPopupTags.Name = "flowLayoutPanelPopupTags" + "." + carId;
            flowLayoutPanelPopupTags.Size = new System.Drawing.Size(582, 51);
            flowLayoutPanelPopupTags.TabIndex = 2;
            // 
            // labelPopupPrice
            // 
            labelPopupPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(184)))), ((int)(((byte)(119)))));
            labelPopupPrice.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            labelPopupPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            labelPopupPrice.Location = new System.Drawing.Point(0, 0);
            labelPopupPrice.Margin = new Padding(0);
            labelPopupPrice.Name = "labelPopupPrice" + "." + carId;
            labelPopupPrice.Margin = new Padding(0, 15, 0, 0);
            labelPopupPrice.Size = new System.Drawing.Size(140, 51);
            labelPopupPrice.TabIndex = 9;
            labelPopupPrice.Text = price.ToString() + "zł";
            labelPopupPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPopupTag
            // 
            labelPopupTag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(184)))), ((int)(((byte)(119)))));
            labelPopupTag.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            labelPopupTag.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            labelPopupTag.Location = new System.Drawing.Point(0, 0);
            labelPopupTag.Margin = new Padding(0);
            labelPopupTag.Name = "labelPopupTag" + "." + carId;
            labelPopupTag.Size = new System.Drawing.Size(106, 51);
            labelPopupTag.TabIndex = 9;
            labelPopupTag.Text = "Tags:";
            labelPopupTag.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPopupTags
            // 
            labelPopupTags.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            labelPopupTags.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            labelPopupTags.Location = new System.Drawing.Point(106, 0);
            labelPopupTags.Margin = new Padding(0);
            labelPopupTags.Name = "labelPopupTags" + "." + carId;
            labelPopupTags.Size = new System.Drawing.Size(631, 51);
            labelPopupTags.TabIndex = 10;
            labelPopupTags.Text = tags;
            labelPopupTags.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanelPopupDatesContainer
            // 
            flowLayoutPanelPopupDatesContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            flowLayoutPanelPopupDatesContainer.Controls.Add(flowLayoutPanelPopupDates);
            flowLayoutPanelPopupDatesContainer.Controls.Add(dateTimePickerPopupDate);
            flowLayoutPanelPopupDatesContainer.Location = new System.Drawing.Point(30, 442);
            flowLayoutPanelPopupDatesContainer.Margin = new Padding(0, 15, 0, 0);
            flowLayoutPanelPopupDatesContainer.Name = "flowLayoutPanelPopupDatesContainer" + "." + carId;
            flowLayoutPanelPopupDatesContainer.Size = new System.Drawing.Size(372, 104);
            flowLayoutPanelPopupDatesContainer.TabIndex = 1;
            // 
            // flowLayoutPanelPopupDates
            // 
            flowLayoutPanelPopupDates.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            flowLayoutPanelPopupDates.Controls.Add(labelPopupStartDate);
            flowLayoutPanelPopupDates.Controls.Add(labelPopupBetweenDates);
            flowLayoutPanelPopupDates.Controls.Add(labelPopupEndDate);
            flowLayoutPanelPopupDates.Location = new System.Drawing.Point(0, 0);
            flowLayoutPanelPopupDates.Margin = new Padding(0);
            flowLayoutPanelPopupDates.Name = "flowLayoutPanelPopupDates" + "." + carId;
            flowLayoutPanelPopupDates.Size = new System.Drawing.Size(372, 50);
            flowLayoutPanelPopupDates.TabIndex = 1;
            // 
            // labelPopupStartDate
            // 
            labelPopupStartDate.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            labelPopupStartDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            labelPopupStartDate.Location = new System.Drawing.Point(0, 0);
            labelPopupStartDate.Margin = new Padding(0);
            labelPopupStartDate.Name = "labelPopupStartDate" + "." + carId;
            labelPopupStartDate.Size = new System.Drawing.Size(175, 50);
            labelPopupStartDate.TabIndex = 9;
            labelPopupStartDate.Text = startDate;
            labelPopupStartDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelPopupBetweenDates
            // 
            labelPopupBetweenDates.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            labelPopupBetweenDates.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            labelPopupBetweenDates.Location = new System.Drawing.Point(175, 0);
            labelPopupBetweenDates.Margin = new Padding(0);
            labelPopupBetweenDates.Name = "labelPopupBetweenDates" + "." + carId;
            labelPopupBetweenDates.Size = new System.Drawing.Size(22, 50);
            labelPopupBetweenDates.TabIndex = 11;
            labelPopupBetweenDates.Text = "-";
            labelPopupBetweenDates.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPopupEndDate
            // 
            labelPopupEndDate.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            labelPopupEndDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            labelPopupEndDate.Location = new System.Drawing.Point(197, 0);
            labelPopupEndDate.Margin = new Padding(0);
            labelPopupEndDate.Name = "labelPopupEndDate" + "." + carId;
            labelPopupEndDate.Size = new System.Drawing.Size(175, 50);
            labelPopupEndDate.TabIndex = 10;
            labelPopupEndDate.Text = endDate;
            labelPopupEndDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateTimePickerPopupDate
            // 
            if (isReserved)
            {
                dateTimePickerPopupDate.Enabled = false;
            }
            else
            {
                dateTimePickerPopupDate.Enabled = true;
            }
            string[] maxDate = endDate.Split('/');
            string[] minDate = startDate.Split('/');
            dateTimePickerPopupDate.CalendarForeColor = Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            dateTimePickerPopupDate.CalendarMonthBackground = Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dateTimePickerPopupDate.CalendarTitleBackColor = Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dateTimePickerPopupDate.CalendarTitleForeColor = Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            dateTimePickerPopupDate.CalendarTrailingForeColor = Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            dateTimePickerPopupDate.Checked = false;
            dateTimePickerPopupDate.Font = new Font("Tw Cen MT Condensed", 18F);
            dateTimePickerPopupDate.Location = new Point(505, 256);
            dateTimePickerPopupDate.MaxDate = new DateTime(int.Parse(maxDate[2]), int.Parse(maxDate[0]), int.Parse(maxDate[1]), 0, 0, 0, 0);
            dateTimePickerPopupDate.MaximumSize = new Size(372, 50);
            dateTimePickerPopupDate.MinDate = new DateTime(int.Parse(minDate[2]), int.Parse(minDate[0]), int.Parse(minDate[1]), 0, 0, 0, 0);
            dateTimePickerPopupDate.MinimumSize = new Size(372, 50);
            dateTimePickerPopupDate.Name = "dateTimePicker1";
            dateTimePickerPopupDate.Size = new Size(372, 50);
            dateTimePickerPopupDate.TabIndex = 0;
            dateTimePickerPopupDate.Value = new DateTime(int.Parse(minDate[2]), int.Parse(minDate[0]), int.Parse(minDate[1]), 0, 0, 0, 0);
            dateTimePickerPopupDate.Cursor = Cursors.Hand;
            // 
            // buttonPopupReserve
            // 
            if (isReserved)
            {
                buttonPopupReserve.Text = "Reserved";
                buttonPopupReserve.Enabled = false;
                buttonPopupReserve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
                buttonPopupReserve.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            }
            else
            {
                buttonPopupReserve.Text = "Reserve";
                buttonPopupReserve.Enabled = true;
                buttonPopupReserve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(184)))), ((int)(((byte)(119)))));
                buttonPopupReserve.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            }
            buttonPopupReserve.FlatStyle = FlatStyle.Flat;
            buttonPopupReserve.Font = new System.Drawing.Font("Tw Cen MT Condensed", 38F, System.Drawing.FontStyle.Bold);
            buttonPopupReserve.Location = new System.Drawing.Point(417, 442);
            buttonPopupReserve.Margin = new Padding(15, 15, 0, 0);
            buttonPopupReserve.Name = "buttonPopupReserve" + "." + carId;
            buttonPopupReserve.Size = new System.Drawing.Size(231, 104);
            buttonPopupReserve.TabIndex = 3;
            buttonPopupReserve.UseVisualStyleBackColor = false;
            buttonPopupReserve.Cursor = Cursors.Hand;
            buttonPopupReserve.Click += new EventHandler(Collection.ButtonPopupReserve_Click);
            // 
            // buttonPopupFav
            // 
            buttonPopupFav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(184)))), ((int)(((byte)(119)))));
            buttonPopupFav.BackgroundImage = isFav ? Resources.starFilled : Resources.starEmpty;
            buttonPopupFav.BackgroundImageLayout = ImageLayout.Center;
            buttonPopupFav.FlatStyle = FlatStyle.Flat;
            buttonPopupFav.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            buttonPopupFav.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            buttonPopupFav.Location = new System.Drawing.Point(663, 442);
            buttonPopupFav.Margin = new Padding(15, 15, 0, 0);
            buttonPopupFav.Name = "buttonPopupFav" + "." + carId;
            buttonPopupFav.Size = new System.Drawing.Size(104, 104);
            buttonPopupFav.TabIndex = 4;
            buttonPopupFav.Tag = isFav ? "true" : "false";
            buttonPopupFav.UseVisualStyleBackColor = false;
            buttonPopupFav.Cursor = Cursors.Hand;
            buttonPopupFav.Click += new EventHandler(ButtonCarFav_Click);


            flowLayoutPanelPopup.ResumeLayout(false);
            panelPopupTop.ResumeLayout(false);
            panelMain.Controls.Add(flowLayoutPanelPopup);
            flowLayoutPanelPopupContainer.ResumeLayout(false);
            flowLayoutPanelPopupContent.ResumeLayout(false);
            flowLayoutPanelPopupTags.ResumeLayout(false);
            flowLayoutPanelPopupDatesContainer.ResumeLayout(false);
            flowLayoutPanelPopupDatesContainer.PerformLayout();
            flowLayoutPanelPopupDates.ResumeLayout(false);
            flowLayoutPanelPopup.BringToFront();
        }

        public static void GenerateSearch(Form form)
        {
            flowLayoutPanelSearchContainer = new System.Windows.Forms.FlowLayoutPanel();
            comboBoxSearchBrand = new System.Windows.Forms.ComboBox();
            comboBoxSearchModel = new System.Windows.Forms.ComboBox();
            comboBoxSearchYear = new System.Windows.Forms.ComboBox();
            comboBoxSearchGearbox = new System.Windows.Forms.ComboBox();
            comboBoxSearchCountry = new System.Windows.Forms.ComboBox();
            comboBoxSearchCity = new System.Windows.Forms.ComboBox();
            textBoxSearchbox = new System.Windows.Forms.TextBox(); 
            buttonLoadMore = new System.Windows.Forms.Button();
            buttonSearch = new System.Windows.Forms.Button();
            flowLayoutPanelSearchContainer.SuspendLayout();
            form.SuspendLayout();
            // 
            // flowLayoutPanelSearchContainer
            // 
            flowLayoutPanelSearchContainer.Controls.Add(comboBoxSearchBrand);
            flowLayoutPanelSearchContainer.Controls.Add(comboBoxSearchModel);
            flowLayoutPanelSearchContainer.Controls.Add(comboBoxSearchYear);
            flowLayoutPanelSearchContainer.Controls.Add(comboBoxSearchGearbox);
            flowLayoutPanelSearchContainer.Controls.Add(buttonLoadMore);
            flowLayoutPanelSearchContainer.Controls.Add(comboBoxSearchCountry);
            flowLayoutPanelSearchContainer.Controls.Add(comboBoxSearchCity);
            flowLayoutPanelSearchContainer.Controls.Add(textBoxSearchbox);
            flowLayoutPanelSearchContainer.Controls.Add(buttonSearch);
            flowLayoutPanelSearchContainer.Location = new System.Drawing.Point(30, 30);
            flowLayoutPanelSearchContainer.Name = "flowLayoutPanelSearchContainer";
            flowLayoutPanelSearchContainer.Size = new System.Drawing.Size(1015, 87);
            flowLayoutPanelSearchContainer.TabIndex = 0;
            // 
            // comboBoxSearchBrand
            // 
            comboBoxSearchBrand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            comboBoxSearchBrand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            comboBoxSearchBrand.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F);
            comboBoxSearchBrand.FormattingEnabled = true;
            comboBoxSearchBrand.Location = new System.Drawing.Point(0, 0);
            comboBoxSearchBrand.Margin = new System.Windows.Forms.Padding(0, 0, 15, 0);
            comboBoxSearchBrand.MinimumSize = new System.Drawing.Size(191, 0);
            comboBoxSearchBrand.Name = "comboBoxSearchBrand";
            comboBoxSearchBrand.Size = new System.Drawing.Size(191, 36);
            comboBoxSearchBrand.TabIndex = 0;
            comboBoxSearchBrand.Items.AddRange(new object[] {
            "--All Brands--"});
            comboBoxSearchBrand.ItemHeight = 13;
            comboBoxSearchBrand.DropDownHeight = 260;
            comboBoxSearchBrand.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSearchBrand.SelectedItem = "--All Brands--";
            comboBoxSearchBrand.SelectionChangeCommitted += new EventHandler(Collection.ComboBoxSearchBrand_SelectionChangeCommitted);
            // 
            // comboBoxSearchModel
            // 
            comboBoxSearchModel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            comboBoxSearchModel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            comboBoxSearchModel.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F);
            comboBoxSearchModel.FormattingEnabled = true;
            comboBoxSearchModel.Location = new System.Drawing.Point(206, 0);
            comboBoxSearchModel.Margin = new System.Windows.Forms.Padding(0, 0, 15, 0);
            comboBoxSearchModel.MinimumSize = new System.Drawing.Size(191, 0);
            comboBoxSearchModel.Name = "comboBoxSearchModel";
            comboBoxSearchModel.Size = new System.Drawing.Size(191, 36);
            comboBoxSearchModel.TabIndex = 1;
            comboBoxSearchModel.Items.AddRange(new object[] {
            "--All Models--"});
            comboBoxSearchModel.ItemHeight = 13;
            comboBoxSearchModel.DropDownHeight = 260;
            comboBoxSearchModel.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSearchModel.SelectedItem = "--All Models--";
            comboBoxSearchModel.SelectionChangeCommitted += new EventHandler(Collection.ComboBoxSearchModel_SelectionChangeCommitted);
            // 
            // comboBoxSearchYear
            // 
            comboBoxSearchYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            comboBoxSearchYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            comboBoxSearchYear.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F);
            comboBoxSearchYear.FormattingEnabled = true;
            comboBoxSearchYear.Location = new System.Drawing.Point(412, 0);
            comboBoxSearchYear.Margin = new System.Windows.Forms.Padding(0, 0, 15, 0);
            comboBoxSearchYear.MinimumSize = new System.Drawing.Size(191, 0);
            comboBoxSearchYear.Name = "comboBoxSearchYear";
            comboBoxSearchYear.Size = new System.Drawing.Size(191, 36);
            comboBoxSearchYear.TabIndex = 2;
            comboBoxSearchYear.Items.AddRange(new object[] {
            "--All Years--"});
            comboBoxSearchYear.ItemHeight = 13;
            comboBoxSearchYear.DropDownHeight = 260;
            comboBoxSearchYear.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSearchYear.SelectedItem = "--All Years--";
            comboBoxSearchYear.SelectionChangeCommitted += new EventHandler(Collection.ComboBoxSearchYear_SelectionChangeCommitted);
            // 
            // comboBoxSearchGearbox
            // 
            comboBoxSearchGearbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            comboBoxSearchGearbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            comboBoxSearchGearbox.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F);
            comboBoxSearchGearbox.FormattingEnabled = true;
            comboBoxSearchGearbox.Location = new System.Drawing.Point(618, 0);
            comboBoxSearchGearbox.Margin = new System.Windows.Forms.Padding(0, 0, 15, 0);
            comboBoxSearchGearbox.MinimumSize = new System.Drawing.Size(191, 0);
            comboBoxSearchGearbox.Name = "comboBoxSearchGearbox";
            comboBoxSearchGearbox.Size = new System.Drawing.Size(191, 36);
            comboBoxSearchGearbox.TabIndex = 3;
            comboBoxSearchGearbox.Items.AddRange(new object[] {
            "--All Gearboxes--"});
            comboBoxSearchGearbox.ItemHeight = 13;
            comboBoxSearchGearbox.DropDownHeight = 260;
            comboBoxSearchGearbox.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSearchGearbox.SelectedItem = "--All Gearboxes--";
            comboBoxSearchGearbox.SelectionChangeCommitted += new EventHandler(Collection.ComboBoxSearchGearbox_SelectionChangeCommitted);
            // 
            // buttonLoadMore
            // 
            buttonLoadMore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(184)))), ((int)(((byte)(119)))));
            buttonLoadMore.FlatAppearance.BorderSize = 0;
            buttonLoadMore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonLoadMore.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F);
            buttonLoadMore.ForeColor = System.Drawing.Color.Gainsboro;
            buttonLoadMore.Location = new System.Drawing.Point(824, 0);
            buttonLoadMore.Margin = new System.Windows.Forms.Padding(0);
            buttonLoadMore.Name = "buttonLoadMore";
            buttonLoadMore.Size = new System.Drawing.Size(191, 36);
            buttonLoadMore.TabIndex = 4;
            buttonLoadMore.Text = "Load More";
            buttonLoadMore.UseVisualStyleBackColor = true;
            buttonLoadMore.Cursor = Cursors.Hand;
            buttonLoadMore.Click += new EventHandler(Collection.ButtonLoadMore_Click);
            // 
            // buttonSearch
            // 
            buttonSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(184)))), ((int)(((byte)(119)))));
            buttonSearch.FlatAppearance.BorderSize = 0;
            buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonSearch.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F);
            buttonSearch.ForeColor = System.Drawing.Color.Gainsboro;
            buttonSearch.Location = new System.Drawing.Point(824, 0);
            buttonSearch.Margin = new System.Windows.Forms.Padding(0, 15, 0, 0);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new System.Drawing.Size(191, 36);
            buttonSearch.TabIndex = 4;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Cursor = Cursors.Hand;
            buttonSearch.Click += new EventHandler(Collection.ButtonSearch_Click);
            // 
            // comboBoxSearchCountry
            // 
            comboBoxSearchCountry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            comboBoxSearchCountry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            comboBoxSearchCountry.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F);
            comboBoxSearchCountry.FormattingEnabled = true;
            comboBoxSearchCountry.Location = new System.Drawing.Point(0, 53);
            comboBoxSearchCountry.Margin = new System.Windows.Forms.Padding(0, 15, 15, 0);
            comboBoxSearchCountry.MinimumSize = new System.Drawing.Size(191, 0);
            comboBoxSearchCountry.Name = "comboBoxSearchCountry";
            comboBoxSearchCountry.Size = new System.Drawing.Size(191, 36);
            comboBoxSearchCountry.TabIndex = 5;
            comboBoxSearchCountry.ItemHeight = 13;
            comboBoxSearchCountry.DropDownHeight = 260;
            comboBoxSearchCountry.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSearchCountry.Items.AddRange(new object[] {
            "--All Countries--"});
            comboBoxSearchCountry.SelectedItem = "--All Countries--";
            comboBoxSearchCountry.SelectionChangeCommitted += new EventHandler(Collection.ComboBoxSearchCountry_SelectionChangeCommitted);
            // 
            // comboBoxSearchCity
            // 
            comboBoxSearchCity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            comboBoxSearchCity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            comboBoxSearchCity.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F);
            comboBoxSearchCity.FormattingEnabled = true;
            comboBoxSearchCity.Location = new System.Drawing.Point(206, 53);
            comboBoxSearchCity.Margin = new System.Windows.Forms.Padding(0, 15, 15, 0);
            comboBoxSearchCity.MinimumSize = new System.Drawing.Size(191, 0);
            comboBoxSearchCity.Name = "comboBoxSearchCity";
            comboBoxSearchCity.Size = new System.Drawing.Size(191, 36);
            comboBoxSearchCity.TabIndex = 6;
            comboBoxSearchCity.ItemHeight = 13;
            comboBoxSearchCity.DropDownHeight = 260;
            comboBoxSearchCity.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSearchCity.Items.AddRange(new object[] {
            "--All Cities--"});
            comboBoxSearchCity.SelectedItem = "--All Cities--";
            comboBoxSearchCity.SelectionChangeCommitted += new EventHandler(Collection.ComboBoxSearchCity_SelectionChangeCommitted);
            // 
            // textBoxSearchbox
            // 
            textBoxSearchbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            textBoxSearchbox.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F);
            textBoxSearchbox.Location = new System.Drawing.Point(412, 53);
            textBoxSearchbox.Margin = new System.Windows.Forms.Padding(0, 15, 15, 0);
            textBoxSearchbox.Multiline = true;
            textBoxSearchbox.Name = "textBoxSearchbox";
            textBoxSearchbox.Size = new System.Drawing.Size(396, 36);
            textBoxSearchbox.TabIndex = 7;


            panelMain.Controls.Add(flowLayoutPanelSearchContainer);
            flowLayoutPanelSearchContainer.ResumeLayout(false);
            flowLayoutPanelSearchContainer.PerformLayout();
        }

        public static void DeleteMoreDetails(object sender, EventArgs e)
        {
            panelMain.Controls.Remove(flowLayoutPanelPopup);
        }

        public static void ButtonCarFav_Click(object sender, EventArgs e)
        {
            using (DreamCarContext context = new DreamCarContext())
            {
                Button currentPopupFavButton = (Button)sender;
                string carId = currentPopupFavButton.Name.Split('.')[1];
                string favButtonName = "buttonCarFav." + carId;
                string favPopupButtonName = "buttonPopupFav." + carId;
                bool isFav = bool.Parse(currentPopupFavButton.Tag.ToString());
                Car currentCarRecord = CollectionReq.GetCarById(context, int.Parse(carId));

                Button favButton = (Button)panelMain.Controls.Find(favButtonName, true)[0];


                try
                {
                    Button favPopupButton = (Button)panelMain.Controls.Find(favPopupButtonName, true)[0];

                    if (!isFav)
                    {
                        favButton.BackgroundImage = Resources.starFilled;
                        favButton.Tag = "true";

                        favPopupButton.BackgroundImage = Resources.starFilled;
                        favPopupButton.Tag = "true";

                        currentCarRecord.Favourites = new List<Favourite>() {
                            new Favourite() {
                                FavouriteAuthor = Collection.currentUserUsername,
                                CarId = currentCarRecord.CarId,
                            }
                        };
                    }
                    else
                    {
                        favButton.BackgroundImage = Resources.starEmpty;
                        favButton.Tag = "false";

                        favPopupButton.BackgroundImage = Resources.starEmpty;
                        favPopupButton.Tag = "false";

                        context.Favourites.Remove(context.Favourites.Where(f => f.CarId == currentCarRecord.CarId).FirstOrDefault());
                    }
                    context.SaveChanges();
                }
                catch
                {
                    if (!isFav)
                    {
                        favButton.BackgroundImage = Resources.starFilled;
                        favButton.Tag = "true";

                        currentCarRecord.Favourites = new List<Favourite>() {
                            new Favourite() {
                                FavouriteAuthor = Collection.currentUserUsername,
                                CarId = currentCarRecord.CarId,
                            }
                        };
                    }
                    else
                    {
                        favButton.BackgroundImage = Resources.starEmpty;
                        favButton.Tag = "false";

                        context.Favourites.Remove(context.Favourites.Where(f => f.CarId == currentCarRecord.CarId).FirstOrDefault());
                    }
                    context.SaveChanges();
                }
               
            }
        }

        public static void ShowDatePick(object sender, EventArgs e)
        {

        }

        // COLLECTION
        private static FlowLayoutPanel flowLayoutPanelCurrentCar;
        private static Panel panelCurrentCarImage;
        private static Label labelCurrentCarBrand;
        private static Label labelCurrentCarModel;
        private static Label labelCurrentCarProdYear;
        private static Label labelCurrentCarFuel;
        private static Label labelCurrentCarGearbox;
        private static Button buttonCurrentCarFav;
        private static Button buttonCurrentCarMore;
        public static FlowLayoutPanel flowLayoutPanelCarCollection;
        public static Panel panelMain;

        // DETAILS
        public static FlowLayoutPanel flowLayoutPanelPopup;
        private static Panel panelPopupTop;
        private static FlowLayoutPanel flowLayoutPanelPopupContainer;
        private static Panel panelPopupImg;
        private static FlowLayoutPanel flowLayoutPanelPopupContent;
        private static Label labelPopupBrand;
        private static Label labelPopupModel;
        private static Label labelPopupFuel;
        private static Label labelPopupCountry;
        private static Label labelPopupCity;
        private static Label labelPopupGearbox;
        private static Label labelPopupProdYear;
        private static Label labelPopupCapacity;
        private static Label labelPopupUsername;
        private static Label labelPopupPrice;
        private static Button buttonPopupClose;
        private static Label labelPopupTag;
        private static FlowLayoutPanel flowLayoutPanelPopupTags;
        private static Label labelPopupTags;
        private static FlowLayoutPanel flowLayoutPanelPopupDatesContainer;
        private static Label labelPopupStartDate;
        private static Label labelPopupEndDate;
        private static Label labelPopupBetweenDates;
        public static Button buttonPopupReserve;
        public static Button buttonPopupFav;
        private static FlowLayoutPanel flowLayoutPanelPopupDates;
        public static DateTimePicker dateTimePickerPopupDate;

        // SEARCH
        public static FlowLayoutPanel flowLayoutPanelSearchContainer;
        public static ComboBox comboBoxSearchBrand;
        public static ComboBox comboBoxSearchModel;
        public static ComboBox comboBoxSearchYear;
        public static ComboBox comboBoxSearchGearbox;
        public static ComboBox comboBoxSearchCountry;
        public static ComboBox comboBoxSearchCity;
        public static TextBox textBoxSearchbox;
        public static Button buttonSearch;
        public static Button buttonLoadMore;
    }
}
