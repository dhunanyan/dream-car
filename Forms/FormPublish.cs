using DreamCar.Data;
using DreamCar.Helpers;
using DreamCar.Models;
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
    public partial class FormPublish : Container
    {
        DreamCarContext _context =  new DreamCarContext();

        public FormPublish(object context)
        {
            _context = (DreamCarContext)context;
            InitializeComponent();
        }

        public FormPublish()
        {
            InitializeComponent();
        }

        private void FormPublish_Leave(object sender, EventArgs e)
        {
            ClearForm();
        }

        public void AddCar()
        {
            DreamCarContext contextCurrentUser = new DreamCarContext();
            var currentUserRecord = contextCurrentUser.Users.Where(u => u.UserUsername == currentUser).FirstOrDefault();

            if(currentUserRecord != null)
            {
                Car car;
                car = new Car()
                {
                    CarName = "NaCarNameme",
                    CarPrice = 99.9M,
                    CarReservationDateStart = "NaCarNameme",
                    CarReservationDateEnd = "NaCarNameme",
                    CarIsSold = false,
                    CarIsReserved = false,
                    CarAuthor = currentUser,
                    CarColor = textBoxCarColor.Text,
                    CarCity = textBoxCarCity.Text,
                    CarCountry = textBoxCarCountry.Text,
                    CarGearbox = textBoxCardGearbox.Text,
                    CarFuel = textBoxCarFuel.Text,
                    CarCapacity = int.Parse(textBoxCarCapacity.Text),
                    CarProdYear = int.Parse(textBoxCardProdYear.Text),
                    CarBrand = textBoxCardBrand.Text,
                    CarModel = textBoxCarModel.Text,
                    CarTags = textBoxCarTags.Text
                };
                currentUserRecord.Cars.Add(car);
                contextCurrentUser.SaveChanges();
            }

        }

        private void ButtonSignup_Click(object sender, EventArgs e)
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
            textBoxCardBrand.Focus();
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ButtonImage_Click(object sender, EventArgs e)
        {
            String ImageLocation = "";
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";
                
                if(dlg.ShowDialog() == DialogResult.OK)
                {
                    ImageLocation = dlg.FileName;
                }

                
            }
            catch (Exception)
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        //CarName
        //CarImageUrl
        //CarPrice
        //CarReservationDateStart
        //CarReservationDateEnd
        //CarIsSold
        //CarIsReserved
        //CarAuthor


        //CarColor
        //CarCity
        //CarCountry
        //CarGearbox
        //CarFuel
        //CarCapacity
        //CarProdYear
        //CarBrand
        //CarModel
    }
}
