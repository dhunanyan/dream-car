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

        public static string imageUrl = "";
        public static string reservationDateStart = "";
        public static string reservationDateEnd = "";

        public Publication(object context)
        {
            PublicationStyles.buttonAddImage.Text = "200 x 200";
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
                PublicationStyles.textBoxCardBrand.Text == "" ||
                PublicationStyles.textBoxCarModel.Text == "" ||
                PublicationStyles.textBoxCardProdYear.Text == "" ||
                PublicationStyles.textBoxCarCapacity.Text == "" ||
                PublicationStyles.textBoxCarFuel.Text == "" ||
                PublicationStyles.textBoxCardGearbox.Text == "" ||
                PublicationStyles.textBoxCarCountry.Text == "" ||
                PublicationStyles.textBoxCarCity.Text == "" ||
                PublicationStyles.textBoxCarColor.Text == "" ||
                PublicationStyles.textBoxCarPrice.Text == "" ||
                PublicationStyles.textBoxCarTags.Text == ""
                )
            {
                string emptyTextBoxes = "";

                foreach (Control control in PublicationStyles.flowLayoutPanel2.Controls)
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
            else if (!double.TryParse(PublicationStyles.textBoxCarPrice.Text, out errorDouble) || !int.TryParse(PublicationStyles.textBoxCarPrice.Text, out errorInt))
            {
                MessageBox.Show(
                    $"Wrong Price value. Please enter valid price."
                    , "CarAdd Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!double.TryParse(PublicationStyles.textBoxCarCapacity.Text, out errorDouble) || !int.TryParse(PublicationStyles.textBoxCarCapacity.Text, out errorInt))
            {
                MessageBox.Show(
                    $"Wrong Capacity value. Please enter capacity price."
                    , "CarAdd Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!int.TryParse(PublicationStyles.textBoxCardProdYear.Text, out errorInt))
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

                    List<Models.Publication> publicationsList = PublicationReq.GetPublications(context, currentUserUsername);
                    Car currentCar = PublicationStyles.CreateNewCar(currentUserUsername, publicationsList.Count(), imageUrl, reservationDateStart, reservationDateEnd);
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
                        $"Congratulations, you have added to collection your {publicationsList.Count()}"
                        , "CarAdd Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                PublicationStyles.AddCarReset();
                return;
            }
        }


        private void ButtonAddCar_Click(object sender, EventArgs e)
        {
            AddCar();
        }

        public static void ClearForm()
        {
            PublicationStyles.textBoxCardBrand.Text = "";
            PublicationStyles.textBoxCarModel.Text = "";
            PublicationStyles.textBoxCardProdYear.Text = "";
            PublicationStyles.textBoxCarCapacity.Text = "";
            PublicationStyles.textBoxCarFuel.Text = "";
            PublicationStyles.textBoxCardGearbox.Text = "";
            PublicationStyles.textBoxCarCountry.Text = "";
            PublicationStyles.textBoxCarCity.Text = "";
            PublicationStyles.textBoxCarColor.Text = "";
            PublicationStyles.textBoxCarTags.Text = "";
            PublicationStyles.textBoxCarPrice.Text = "";
            PublicationStyles.textBoxCardBrand.Focus();
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
                    PublicationStyles.labelLoadingProgress.Text = "0%";
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
                            PublicationStyles.labelLoadingProgress.Text = e.Percentage.ToString() + "%";
                        };
                        imageUrl = await task;

                        PublicationStyles.buttonAddImage.BackgroundImage = setBackgroungImageUrl(imageUrl);
                        PublicationStyles.buttonAddImage.BackgroundImageLayout = ImageLayout.Zoom;
                        PublicationStyles.buttonAddImage.Text = "";
                        Console.WriteLine(imageUrl);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public static void MonthCalendar_DateSelected(object sender, System.Windows.Forms.DateRangeEventArgs e)
        {
            Console.WriteLine("Date Selected: Start = " +
                e.Start.ToShortDateString() + " : End = " + e.End.ToShortDateString());
            reservationDateStart = e.Start.ToShortDateString();
            reservationDateEnd = e.End.ToShortDateString();
        }

        //PROGRESS BAR
        private void labelLoadingProgress_TextChanged(object sender, EventArgs e)
        {
            PublicationStyles.labelLoadingProgress.Size = new Size(int.Parse(PublicationStyles.labelLoadingProgress.Text.Split('%')[0]) * 205 / 100, 18);
        }
    }
}
