using DreamCar.Helpers;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using DreamCar.Properties;
using DreamCar.Data;
using System.Linq;
using DreamCar.Models;
using System.Text.RegularExpressions;

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

            Color color = ColorTranslator.FromHtml("#74d484");

            buttonCollection.BackColor = ThemeColor.ChangeColorBrightness(ColorTranslator.FromHtml("#33334c"), 0.5);
            buttonCollection.ForeColor = Color.Gainsboro;
            buttonCollection.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;

            buttonProfile.BackColor = ThemeColor.ChangeColorBrightness(ColorTranslator.FromHtml("#33334c"), 0.5);
            buttonProfile.ForeColor = Color.Gainsboro;
            buttonProfile.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;

            buttonPublish.BackColor = ThemeColor.ChangeColorBrightness(ColorTranslator.FromHtml("#33334c"), 0.5);
            buttonPublish.ForeColor = Color.Gainsboro;
            buttonPublish.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;

            SignUp.Visible = false;
            SignIn.Visible = true;
        }

        private Color SelectThemeColor(string buttonName)
        {
            //string color = ThemeColor.colorList[buttonName];
            return ColorTranslator.FromHtml("#74d484");
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
                    previousButton.BackColor = ColorTranslator.FromHtml("#33334c");
                    previousButton.ForeColor = ColorTranslator.FromHtml("#33334c");
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
            labelTitle.Text = "COLLECTION";
            buttonCollection.Enabled = false;
            buttonProfile.Enabled = true;
            buttonPublish.Enabled = true;
            OpenChildForm(new Forms.FormCollection(), sender);
        }

        private void ButtonCollection_EnabledChanged(object sender, EventArgs e)
        {
            Button currentButton = (Button)sender;
            buttonCollection.ForeColor = Color.Gainsboro;
            buttonCollection.BackColor = currentButton.Enabled ? ColorTranslator.FromHtml("#33334c") : ThemeColor.ChangeColorBrightness(ColorTranslator.FromHtml("#33334c"), 0.5);
            buttonCollection.FlatAppearance.BorderColor = currentButton.Enabled ? ColorTranslator.FromHtml("#33334c") : ThemeColor.ChangeColorBrightness(ColorTranslator.FromHtml("#33334c"), 0.5);
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
            e.Graphics.DrawString("    Collection", currentButton.Font, drawBrush, e.ClipRectangle, sf);
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

            labelTitle.Text = "PUBLISH";
            buttonPublish.Enabled = false;
            buttonProfile.Enabled = true;
            buttonCollection.Enabled = true;
            OpenChildForm(new Forms.FormPublish(), sender);
        }


        private void ButtonPublish_EnabledChanged(object sender, EventArgs e)
        {
            Button currentButton = (Button)sender;
            buttonPublish.ForeColor = Color.Gainsboro;
            buttonPublish.BackColor = currentButton.Enabled ? ColorTranslator.FromHtml("#33334c") : ThemeColor.ChangeColorBrightness(ColorTranslator.FromHtml("#33334c"), 0.5);
            buttonPublish.FlatAppearance.BorderColor = currentButton.Enabled ? ColorTranslator.FromHtml("#33334c") : ThemeColor.ChangeColorBrightness(ColorTranslator.FromHtml("#33334c"), 0.5);
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
            labelTitle.Text = "PROFILE";
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
            buttonProfile.BackColor = currentButton.Enabled ? ColorTranslator.FromHtml("#33334c") : ThemeColor.ChangeColorBrightness(ColorTranslator.FromHtml("#33334c"), 0.5);
            buttonProfile.FlatAppearance.BorderColor = currentButton.Enabled ? ColorTranslator.FromHtml("#33334c") : ThemeColor.ChangeColorBrightness(ColorTranslator.FromHtml("#33334c"), 0.5);
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
            if (currentForm != null)
            {
                labelTitle.Text = currentForm.Text;
                buttonProfile.Enabled = false;
                buttonPublish.Enabled = false;
                buttonCollection.Enabled = false;
                currentForm.Close();
            }
            Reset();
            SignIn.Visible = true;
            flowLayoutPanel1.Visible = true;
        }

        private void Reset()
        {
            DisableButton();
            labelTitle.Text = "HOME";
            currentButton = null;
            buttonTimes.Visible = false;
            buttonCollection.BackColor = buttonCollection.Enabled ? ColorTranslator.FromHtml("#33334c") : ThemeColor.ChangeColorBrightness(ColorTranslator.FromHtml("#33334c"), 0.5);
            buttonCollection.ForeColor = Color.Gainsboro;
            buttonCollection.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;

            buttonProfile.BackColor = buttonProfile.Enabled ? ColorTranslator.FromHtml("#33334c") : ThemeColor.ChangeColorBrightness(ColorTranslator.FromHtml("#33334c"), 0.5);
            buttonProfile.ForeColor = Color.Gainsboro;
            buttonProfile.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;

            buttonPublish.BackColor = buttonPublish.Enabled ? ColorTranslator.FromHtml("#33334c") : ThemeColor.ChangeColorBrightness(ColorTranslator.FromHtml("#33334c"), 0.5);
            buttonPublish.ForeColor = Color.Gainsboro;
            buttonPublish.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
        }

        // SHOW PASSWORD FOR SIGNUP
        private void CheckBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPassword.Checked)
            {
                textBoxPassword.PasswordChar = '\0';
                textBoxConfirmPassword.PasswordChar = '\0';
            }
            else
            {
                textBoxPassword.PasswordChar = '\u25CF';
                textBoxConfirmPassword.PasswordChar = '\u25CF';
            }
        }

        // IS PHONE NUMBER
        public static bool IsPhoneNbr(string number, string motif)
        {
            if (number != null) return Regex.IsMatch(number, motif);
            else return false;
        }

        // SIGN UP
        private void ButtonSignup_Click(object sender, EventArgs e)
        {
            DreamCarContext contextUserExists = new DreamCarContext();
            DreamCarContext contextSignUp = new DreamCarContext();
            var userExists = contextUserExists.Users.Where(u => u.UserUsername == textBoxUsername.Text);

            if (textBoxUsername.Text == "" || 
                textBoxPassword.Text == "" || 
                textBoxConfirmPassword.Text == "" || 
                textBoxFirstName.Text == "" ||
                textBoxLastName.Text == "" ||
                textBoxCountry.Text == "" ||
                textBoxAddress.Text == "" ||
                textBoxPhone.Text == "" ||
                textBoxCity.Text == "" ||
                textBoxEmail.Text == "")
            {
                string emptyTextBoxes = "";
                
                foreach (Control control in flowLayoutPanel2.Controls)
                {
                    if(control.Text == "" && control is TextBox)
                    {
                        emptyTextBoxes += control.Name.Split('x')[2] + ", ";
                    }
                }

                MessageBox.Show(
                    $"{emptyTextBoxes} fields empty ary empty, Please fill them."
                    , "Registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (textBoxUsername.Text.Length > 16)
            {
                MessageBox.Show("Username can contain max 7 characters.", "Registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxUsername.Text = "";
                textBoxPassword.Text = "";
                textBoxConfirmPassword.Text = "";
                textBoxUsername.Focus();
                return;
            }

            if (userExists.Count() > 0)
            {
                MessageBox.Show("User with current username exists, choose another username.", "Registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxUsername.Text = "";
                textBoxPassword.Text = "";
                textBoxConfirmPassword.Text = "";
                textBoxUsername.Focus();
                return;
            }

            //if(!IsPhoneNbr(textBoxPhone.Text.ToString(), @"^+48 [0-9]{3} [0-9]{3} [0-9]{3}$"))
            //{
            //    MessageBox.Show("Please enter valid phone number. Sample current format: '+48 *** *** ***' (For you location onyl Polish numbers accepted).", "Registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    textBoxPassword.Text = "";
            //    textBoxConfirmPassword.Text = "";
            //    return;
            //}

            if (textBoxPassword.Text == textBoxConfirmPassword.Text)
            {
                contextSignUp.Add(new User() { 
                    UserUsername = textBoxUsername.Text,
                    UserPassword = textBoxPassword.Text,
                    UserFirstName = textBoxFirstName.Text,
                    UserLastName = textBoxLastName.Text,
                    UserEmail = textBoxEmail.Text,
                    UserCountry = textBoxCountry.Text,
                    UserCity = textBoxCity.Text,
                    UserAddress = textBoxAddress.Text,
                    UserPhone = textBoxPhone.Text,
                });
                contextSignUp.SaveChanges();

                textBoxUsername.Text = "";
                textBoxPassword.Text = "";
                textBoxConfirmPassword.Text = "";

                MessageBox.Show("Your account has been successfully created!", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                SignIn.Visible = true;
                SignUp.Visible = false;
                return;
            }
            else
            {
                MessageBox.Show("Passwords don't match, Please enter valid credentials.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxPassword.Text = "";
                textBoxConfirmPassword.Text = "";
                textBoxPassword.Focus();
                return;
            }
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            textBoxUsernameSignin.Text = "";
            textBoxPasswordSignin.Text = "";
            textBoxFirstName.Text = "";
            textBoxLastName.Text = "";
            textBoxEmail.Text = "";
            textBoxCountry.Text = "";
            textBoxCity.Text = "";
            textBoxAddress.Text = "";
            textBoxPhone.Text = "";
            textBoxUsername.Text = "";
            textBoxPassword.Text = "";
            textBoxConfirmPassword.Text = "";
            textBoxFirstName.Focus();
        }

        private void LabelChangeToSignin_Click(object sender, EventArgs e)
        {
            checkBoxShowPassword.Checked = false;
            textBoxUsernameSignin.Text = "";
            textBoxPasswordSignin.Text = "";
            SignIn.Visible = true;
            SignUp.Visible = false;
            textBoxUsernameSignin.Focus();
        }

        // SHOW PASSWORD FOR SIGNIN
        private void CheckBoxShowPasswordSignin_CheckedChange(object sender, EventArgs e)
        {
            if (checkBoxShowPasswordSignin.Checked)
            {
                textBoxPasswordSignin.PasswordChar = '\0';
            }
            else
            {
                textBoxPasswordSignin.PasswordChar = '\u25CF';
            }
        }

        // SIGN IN
        private void ButtonSignin_Click(object sender, EventArgs e)
        {
            DreamCarContext contextUserExists = new DreamCarContext();
            var userExists = from users in contextUserExists.Users where users.UserUsername  == textBoxUsernameSignin.Text && users.UserPassword == textBoxPasswordSignin.Text select users;
            //var userExists = contextUserExists.Users.Where(u => u.UserUsername == textBoxUsernameSignin.Text && u.UserPassword == textBoxPasswordSignin.Text);
            if (textBoxUsernameSignin.Text == "" && textBoxPasswordSignin.Text == "")
            {
                MessageBox.Show("Empty Username and Pasword fields. Please fill up the form and try again", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxUsernameSignin.Focus();
            }
            else if (textBoxUsernameSignin.Text == "")
            {
                MessageBox.Show("Empty Username field. Please fill up the form and try again", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxUsernameSignin.Focus();
            }
            else if (textBoxPasswordSignin.Text == "")
            {
                MessageBox.Show("Empty Password field. Please fill up the form and try again", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxPasswordSignin.Focus();
            }
            else if (userExists.Count() != 0)
            {
                currentUserId = userExists.ToList().First().UserId;
                currentUserUsername = textBoxUsernameSignin.Text.ToString();
                buttonCollection.Enabled = true;
                buttonProfile.Enabled = true;
                buttonPublish.Enabled = true;
                SignIn.Visible = false;
                SignUp.Visible = false;
                flowLayoutPanel1.Visible = false;

                if (currentForm != null)
                {
                    labelTitle.Text = currentForm.Text;
                    currentForm.Close();
                }
                textBoxUsernameSignin.Text = "";
                textBoxPasswordSignin.Text = "";
                OpenChildForm(new Forms.FormCollection(), buttonCollection);
                Reset();
                buttonTimes.Visible = true;
            }
            else
            {
                MessageBox.Show("Invalid Username or Password, Please try again", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                textBoxUsernameSignin.Text = "";
                textBoxPasswordSignin.Text = "";
                textBoxUsernameSignin.Focus();
            }
        }

        private void ButtonClearSignin(object sender, EventArgs e)
        {
            textBoxUsernameSignin.Text = "";
            textBoxPasswordSignin.Text = "";
            textBoxUsernameSignin.Focus();
        }


        private void LabelChangeToSignup_Click(object sender, EventArgs e)
        {
            checkBoxShowPasswordSignin.Checked = false;
            textBoxUsername.Text = "";
            textBoxPassword.Text = "";
            textBoxConfirmPassword.Text = "";
            textBoxFirstName.Text = "";
            textBoxLastName.Text = "";
            textBoxEmail.Text = "";
            textBoxCountry.Text = "";
            textBoxCity.Text = "";
            textBoxAddress.Text = "";
            textBoxPhone.Text = "";
            SignIn.Visible = false;
            SignUp.Visible = true;
            textBoxFirstName.Focus();
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