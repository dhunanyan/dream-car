using DreamCar.Helpers;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DreamCar
{
    public partial class FormMain : Container
    {
        public FormMain()
        {
            InitializeComponent();

            buttonTimes.Visible = false;
            buttonCollection.Enabled = false;
            buttonProfile.Enabled = false;
            buttonPublish.Enabled = false;

            Color color = ColorTranslator.FromHtml("#33334c");

            buttonCollection.BackColor = ThemeColor.ChangeColorBrightness(color, 0.5);
            buttonCollection.ForeColor = Color.Gainsboro;
            buttonCollection.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;

            buttonProfile.BackColor = ThemeColor.ChangeColorBrightness(color, 0.5);
            buttonProfile.ForeColor = Color.Gainsboro;
            buttonProfile.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;

            buttonPublish.BackColor = ThemeColor.ChangeColorBrightness(color, 0.5);
            buttonPublish.ForeColor = Color.Gainsboro;
            buttonPublish.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;

        }

        private Color SelectThemeColor(string buttonName)
        {
            string color = ThemeColor.colorList[buttonName];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object buttonSender)
        {
            if (buttonSender == null || currentButton == (Button)buttonSender)
            {
                return;
            }
            DisableButton();
            currentButton = (Button)buttonSender;
            Color currentColor = SelectThemeColor(currentButton.Name);
            currentButton.BackColor = currentColor;
            currentButton.ForeColor = Color.White;
            panelTitleBar.BackColor = currentColor;
            panelLogo.BackColor = ThemeColor.ChangeColorBrightness(currentColor, -0.3);
            ThemeColor.PrimaryColor = currentColor;
            ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(currentColor, -0.3);
            ThemeColor.TertiaryColor = ThemeColor.ChangeColorBrightness(currentColor, 0.5);
            buttonTimes.Visible = true;
        }

        private void DisableButton()
        {
            foreach (Control previousButton in panelMenu.Controls)
            {
                if (previousButton.GetType() == typeof(Button))
                {
                    previousButton.BackColor = Color.FromArgb(51, 51, 76);
                    previousButton.ForeColor = Color.Gainsboro;
                }
            }
        }

        private void OpenChildForm(Form childForm, object buttonSender)
        {
            if (currentForm != null)
            {
                currentForm.Close();
            }
            ActivateButton(buttonSender);
            currentForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMain.Controls.Add(childForm);
            panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        // COLLECTION
        private void ButtonCollection_Click(object sender, EventArgs e)
        {
            labelTitle.Text = "Collection";
            buttonCollection.Enabled = false;
            buttonProfile.Enabled = true;
            buttonPublish.Enabled = true;
            OpenChildForm(new Forms.FormCollection(), sender);
        }

        private void ButtonCollection_EnabledChanged(object sender, EventArgs e)
        {
            Button currentButton = (Button)sender;
            buttonCollection.ForeColor = Color.Gainsboro;
            buttonCollection.BackColor = currentButton.Enabled ? ThemeColor.PrimaryColor : ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.5);
        }

        private void ButtonCollection_Paint(object sender, PaintEventArgs e)
        {
            Button currentButton = (Button)sender;
            buttonCollection.ForeColor = Color.Gainsboro;
            SolidBrush drawBrush = new SolidBrush(currentButton.ForeColor);
            StringFormat sf = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            buttonCollection.Text = string.Empty;
            e.Graphics.DrawString("Collection", currentButton.Font, drawBrush, e.ClipRectangle, sf);
            drawBrush.Dispose();
            sf.Dispose();
        }

        // PUBLISH
        private void ButtonPublish_Click(object sender, EventArgs e)
        {
            //if (isLaunched)
            //{
            //    DialogResult dialog = MessageBox.Show("Youur current searching results will be lost, do you really want to leave?",
            //        "Session Exit", MessageBoxButtons.YesNo);
            //    if (dialog == DialogResult.No)
            //    {
            //        return;
            //    }
            //}

            labelTitle.Text = "Publish";
            buttonPublish.Enabled = false;
            buttonProfile.Enabled = true;
            buttonCollection.Enabled = true;
            OpenChildForm(new Forms.FormPublish(), sender);
        }


        private void ButtonPublish_EnabledChanged(object sender, EventArgs e)
        {
            Button currentButton = (Button)sender;
            buttonPublish.ForeColor = Color.Gainsboro;
            buttonPublish.BackColor = currentButton.Enabled ? ThemeColor.PrimaryColor : ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.5);
        }

        private void ButtonPublish_Paint(object sender, PaintEventArgs e)
        {
            Button currentButton = (Button)sender;
            buttonPublish.ForeColor = Color.Gainsboro;
            SolidBrush drawBrush = new SolidBrush(currentButton.ForeColor);
            StringFormat sf = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            buttonPublish.Text = string.Empty;
            e.Graphics.DrawString("Publish", currentButton.Font, drawBrush, e.ClipRectangle, sf);
            drawBrush.Dispose();
            sf.Dispose();
        }

        // PROFILE
        private void ButtonProfile_Click(object sender, EventArgs e)
        {
            //if (isLaunched)
            //{
            //    DialogResult dialog = MessageBox.Show("Youur current searching results will be lost, do you really want to leave?",
            //        "Session Exit", MessageBoxButtons.YesNo);
            //    if (dialog == DialogResult.No)
            //    {
            //        return;
            //    }
            //}
            labelTitle.Text = "Profile";
            buttonProfile.Enabled = false;
            buttonPublish.Enabled = true;
            buttonCollection.Enabled = true;
            OpenChildForm(new Forms.FormProfile(), sender);
            //timer.Stop();
        }


        private void ButtonProfile_EnabledChanged(object sender, EventArgs e)
        {
            Button currentButton = (Button)sender;
            buttonProfile.ForeColor = Color.Gainsboro;
            buttonProfile.BackColor = currentButton.Enabled ? ThemeColor.PrimaryColor : ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.5);
        }

        private void ButtonProfile_Paint(object sender, PaintEventArgs e)
        {
            Button currentButton = (Button)sender;
            buttonProfile.ForeColor = Color.Gainsboro;
            SolidBrush drawBrush = new SolidBrush(currentButton.ForeColor);
            StringFormat sf = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            buttonProfile.Text = string.Empty;
            e.Graphics.DrawString("Profile", currentButton.Font, drawBrush, e.ClipRectangle, sf);
            drawBrush.Dispose();
            sf.Dispose();
        }

        // LOGOUT
        private void ButtonTimes_Click(object sender, EventArgs e)
        {
            //CurrentUser[0] = "Username";
            //CurrentUser[1] = "Password";
            if (currentForm != null)
            {
                labelTitle.Text = currentForm.Text;
                buttonProfile.Enabled = true;
                buttonPublish.Enabled = true;
                buttonCollection.Enabled = true;
                currentForm.Close();
            }
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            labelTitle.Text = "HOME";
            currentButton = null;
            buttonTimes.Visible = false;
        }
    }

}


//DreamCarContext context = new DreamCarContext();
//User user1 = new User();
//User user2 = new User();
//Car car1 = new Car();
//Car car2 = new Car();

//car1 = new Car()
//{
//    CarName = $"BMW_m5_2012",
//    CarBrand = $"BMW",
//    CarModel = $"M5",
//    CarEngine = $"V6",
//    CarColor = $"#303030",
//    CarImageUrl = $"/sdsd/2rf/sd.png",
//    CarPrice = 99.9M,
//    CarTags = $"#sport #cool",
//    CarReservationDateStart = $"12/16/2022",
//    CarReservationDateEnd = $"12/22/2022",
//};

//car2 = new Car()
//{
//    CarName = $"Audi_A4_2016",
//    CarBrand = $"Audi",
//    CarModel = $"A4",
//    CarEngine = $"V4",
//    CarColor = $"#dddddd",
//    CarImageUrl = $"/sdsd/adfrf/sd.png",
//    CarPrice = 120.9M,
//    CarTags = $"#sport #bussiness",
//    CarReservationDateStart = $"12/22/2022",
//    CarReservationDateEnd = $"1/11/2023",
//};

//user1 = new User()
//{
//    UserUsername = $"dhunan",
//    UserPassword = $"dhunan",
//    UserFirstName = "Dav",
//    UserLastName = "Hun",
//    UserAddress = "Wese",
//    UserPhone = "+39829344",
//    UserEmail = "dsadas@ds.com",
//};

//user2 = new User()
//{
//    UserUsername = $"dhunan111",
//    UserPassword = $"dhunan111",
//    UserFirstName = "Davit",
//    UserLastName = "Hunanyan",
//    UserAddress = "Wesele 32",
//    UserPhone = "+374 77 12 21 21",
//    UserEmail = "davo@lol.com",
//};


// FAVOURTIES
//DreamCarContext context_1 = new DreamCarContext();
//DreamCarContext context_2 = new DreamCarContext();
//var cars = context_1.Cars;
//var currentUser = context_2.Users.Where(p => p.UserUsername == "dhunan111").FirstOrDefault();

//foreach(Car currentCar in cars)
//{
//    context.Add(new Favourite()
//    {
//        UserId = currentUser.UserId,
//        CarId = currentCar.CarId,
//    });
//    context.SaveChanges();
//}


// COLLECTION ?
//int i = 0;
//var cars = context.Cars.Where(p => p.CarPrice > 10.00M).OrderBy(p => p.CarName);
//Console.WriteLine(cars);
////var products2 = from product in context.Cars where product.CarPrice > 10.00M orderby product.CarName select product;
//if(cars != null)
//{
//    foreach (Car p in cars)
//    {
//        Label lbl = new Label()
//        {
//            Text = $"{p.CarName} \n {p.CarPrice}",
//            Name = p.CarName,
//            Location = new Point(150 * i, 800),
//            Size = new Size(150, 50)
//        };
//        Controls.Add(lbl);
//        i++;
//    }
//}

//i = 0;
//var favourites = context.Favourite.Where(p => p.User.UserUsername == user2.UserUsername).OrderBy(p => p.Car.CarName);
////var products2 = from product in context.Cars where product.CarPrice > 10.00M orderby product.CarName select product;
//foreach (Favourite f in favourites)
//{
//    DreamCarContext context_1 = new DreamCarContext();
//    DreamCarContext context_2 = new DreamCarContext();
//    var currentCar = context_1.Cars.Where(p => p.CarId == f.CarId).FirstOrDefault();
//    var currentUser = context_2.Users.Where(p => p.UserId == f.UserId).FirstOrDefault();
//    Label lbl = new Label()
//    {
//        Text = $"{currentUser.UserUsername}: {currentCar.CarName}",
//        Name = $"Res_{currentUser.UserUsername}_{currentCar.CarName}",
//        Location = new Point(200 * i, 800),
//        Size = new Size(200, 50)
//    };
//    Controls.Add(lbl);
//    i++;
//}

//Label lblCount = new Label()
//{
//    Text = $"{favourites.Count()}",
//    Name = $"Res_lblCount",
//    Location = new Point(1200 * i, 800),
//    Size = new Size(200, 50)
//};
//Controls.Add(lblCount);



// CALENDAR
//private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
//{
//    // Show the start and end dates in the text box.
//    this.textBox1.Text = "Date Changed: Start =  " +
//        e.Start.ToShortDateString() + " : End = " + e.End.ToShortDateString();
//}

//private void monthCalendar1_DateSelected(object sender, System.Windows.Forms.DateRangeEventArgs e)
//{
//    // Show the start and end dates in the text box.
//    this.textBox1.Text = "Date Selected: Start = " +
//        e.Start.ToShortDateString() + " : End = " + e.End.ToShortDateString();
//}