using DreamCar.Data;
using DreamCar.Helpers;
using DreamCar.Models;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Firebase.Storage;
using DreamCar.Properties;
using System.Collections.Generic;

namespace DreamCar.Forms.Publication
{
    public partial class Publication : Container
    {

        string imageUrl = "";
        string reservationDateStart = "";
        string reservationDateEnd = "";

        public Publication(object context)
        {
            buttonAddImage.Text = "200 x 200";
            InitializeComponent();
        }

        public Publication()
        {
            InitializeComponent();
        }

        private void FormPublish_Leave(object sender, EventArgs e)
        {
            ClearForm();
        }

        public void AddCar()
        {
            int errorInt;
            double errorDouble;
            if (
                textBoxCardBrand.Text == "" ||
                textBoxCarModel.Text == "" ||
                textBoxCardProdYear.Text == "" ||
                textBoxCarCapacity.Text == "" ||
                textBoxCarFuel.Text == "" ||
                textBoxCardGearbox.Text == "" ||
                textBoxCarCountry.Text == "" ||
                textBoxCarCity.Text == "" ||
                textBoxCarColor.Text == "" ||
                textBoxCarPrice.Text == "" ||
                textBoxCarTags.Text == ""
                )
            {
                string emptyTextBoxes = "";

                foreach (Control control in flowLayoutPanel2.Controls)
                {
                    if (control.Text == "" && control is TextBox)
                    {
                        emptyTextBoxes += control.Name.Split('x')[2] + ", ";
                    }
                }

                MessageBox.Show(
                    $"{emptyTextBoxes} fields empty ary empty, Please fill them."
                    , "CarAdd Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!double.TryParse(textBoxCarPrice.Text, out errorDouble) || !int.TryParse(textBoxCarPrice.Text, out errorInt))
            {
                MessageBox.Show(
                    $"Wrong Price value. Please enter valid price."
                    , "CarAdd Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!double.TryParse(textBoxCarCapacity.Text, out errorDouble) || !int.TryParse(textBoxCarCapacity.Text, out errorInt))
            {
                MessageBox.Show(
                    $"Wrong Capacity value. Please enter capacity price."
                    , "CarAdd Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!int.TryParse(textBoxCardProdYear.Text, out errorInt))
            {
                MessageBox.Show(
                    $"Wrong Production Year value. Please enter valid production year."
                    , "CarAdd Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (imageUrl == "") {
                MessageBox.Show(
                    $"No picture attached. Please attach your car's picture."
                    , "CarAdd Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (reservationDateStart == "" || reservationDateEnd == "")
            {
                MessageBox.Show(
                    $"No available Date selected. Please select a day or days range in the calendar."
                    , "CarAdd Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                using (DreamCarContext context = new DreamCarContext())
                {
                    
                    
                    Car currentCar = PublicationStyles.CreateNewCar(currentUserUsername, currentUserPublishCount, imageUrl, reservationDateStart, reservationDateEnd);
                    PublicationReq.AddNewCar(context, currentUserUsername, currentCar);

                    using (DreamCarContext contextInner = new DreamCarContext())
                    {
                        DreamCarContext contextCar = new DreamCarContext();
                        var currentCarRecord = contextCar.Cars.Where(c => c.UserId == currentUserId).FirstOrDefault();
                        if (currentCarRecord != null)
                        {
                            var publishes = contextInner.Publications;
                            foreach (var p in publishes)
                            {
                                if (p.CarId == null && p.PublishAuthor == currentUserUsername)
                                {
                                    p.CarId = currentCarRecord.CarId;
                                }
                            }
                        }
                        contextCar.SaveChanges();
                        contextInner.SaveChanges();
                    }

                    MessageBox.Show(
                        $"Congratulations, you have added to collection your {currentUserPublishCount}"
                        , "CarAdd Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                AddCarReset();
                return;
            }
        }

        private void AddCarReset()
        {
            imageUrl = "";
            ClearForm();
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
            monthCalendar.DateSelected += new DateRangeEventHandler(MonthCalendar_DateSelected);
        }

        private void ButtonAddCar_Click(object sender, EventArgs e)
        {
            AddCar();
        }

        private void ClearForm()
        {
            textBoxCardBrand.Text = "";
            textBoxCarModel.Text = "";
            textBoxCardProdYear.Text = "";
            textBoxCarCapacity.Text = "";
            textBoxCarFuel.Text = "";
            textBoxCardGearbox.Text = "";
            textBoxCarCountry.Text = "";
            textBoxCarCity.Text = "";
            textBoxCarColor.Text = "";
            textBoxCarTags.Text = "";
            textBoxCarPrice.Text = "";
            textBoxCardBrand.Focus();
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private async void ButtonImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    labelLoadingProgress.Text = "0%";
                    using (DreamCarContext context = new DreamCarContext())
                    {
                        var currentUserPublishCount = context.Publications.Where(x => x.PublishAuthor == currentUserUsername).Count();

                        var stream = File.Open(dlg.FileName, FileMode.Open);
                        var task = new FirebaseStorage("dreamcar-d63e5.appspot.com")
                            .Child("Images")
                            .Child(currentUserUsername + "_" + currentUserPublishCount)
                            .PutAsync(stream);

                        task.Progress.ProgressChanged += (s, e) => {
                            Console.WriteLine($"Progress: {e.Percentage} %");
                            labelLoadingProgress.Text = e.Percentage.ToString() + "%";
                        };
                        imageUrl = await task;

                        buttonAddImage.BackgroundImage = setBackgroungImageUrl(imageUrl);
                        buttonAddImage.BackgroundImageLayout = ImageLayout.Zoom;
                        buttonAddImage.Text = "";
                        Console.WriteLine(imageUrl);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private string GetProjectPath()
        {
            string path = "";
            for (int i = 0; i < Application.StartupPath.Split('\\').Length - 2; i++)
            {
                path += Application.StartupPath.Split('\\')[i] + '\\';
            }

            return path;
        }

        private void MonthCalendar_DateSelected(object sender, System.Windows.Forms.DateRangeEventArgs e)
        {
            // Show the start and end dates in the text box.
            Console.WriteLine("Date Selected: Start = " +
                e.Start.ToShortDateString() + " : End = " + e.End.ToShortDateString());
            reservationDateStart = e.Start.ToShortDateString();
            reservationDateEnd = e.End.ToShortDateString();
        }

        //LOADING ANIMATION
        private void labelLoadingProgress_TextChanged(object sender, EventArgs e)
        {
            labelLoadingProgress.Size = new Size(int.Parse(labelLoadingProgress.Text.Split('%')[0]) * 205 / 100, 18);
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
