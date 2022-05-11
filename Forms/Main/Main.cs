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

namespace DreamCar.Forms.Main
{
    public partial class Main : Container
    {
        public Main()
        {
            MainStyles.InitializeComponent(this);

            MainStyles.buttonTimes.Visible = false;
            MainStyles.buttonCollection.Enabled = false;
            MainStyles.buttonProfile.Enabled = false;
            MainStyles.buttonPublish.Enabled = false;

            MainStyles.SetButtonColors();

            MainStyles.SignUp.Visible = false;
            MainStyles.SignIn.Visible = true;
        }

        private static Color SelectThemeColor(string buttonName)
        {
            //string color = ThemeColor.colorList[buttonName];
            return ColorTranslator.FromHtml("#74d484");
        }

        private static void ActivateButton(object buttonSender)
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
            MainStyles.panelTitleBar.BackColor = currentColor;
            ThemeColor.PrimaryColor = currentColor;
            ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(currentColor, -0.3);
            ThemeColor.TertiaryColor = ThemeColor.ChangeColorBrightness(currentColor, 0.5);
            MainStyles.buttonTimes.Visible = true;
        }

        private static void DisableButton()
        {
            foreach (Control previousButton in MainStyles.panelMenu.Controls)
            {
                if (previousButton.GetType() == typeof(Button))
                {
                    previousButton.BackColor = ColorTranslator.FromHtml("#33334c");
                    previousButton.ForeColor = ColorTranslator.FromHtml("#33334c");
                }
            }
        }

        public static void OpenChildForm(Form childForm, object buttonSender)
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
            MainStyles.panelMain.Controls.Add(childForm);
            MainStyles.panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        // COLLECTION
        public static void ButtonCollection_Click(object sender, EventArgs e)
        {
            MainStyles.labelTitle.Text = "COLLECTION";
            MainStyles.buttonCollection.Enabled = false;
            MainStyles.buttonProfile.Enabled = true;
            MainStyles.buttonPublish.Enabled = true;
            OpenChildForm(new Collection.Collection(), sender);
        }

        public static void ButtonCollection_EnabledChanged(object sender, EventArgs e)
        {
            Button currentButton = (Button)sender;
            MainStyles.buttonCollection.ForeColor = Color.Gainsboro;
            MainStyles.buttonCollection.BackColor = currentButton.Enabled ? ColorTranslator.FromHtml("#33334c") : ThemeColor.ChangeColorBrightness(ColorTranslator.FromHtml("#33334c"), 0.5);
            MainStyles.buttonCollection.FlatAppearance.BorderColor = currentButton.Enabled ? ColorTranslator.FromHtml("#33334c") : ThemeColor.ChangeColorBrightness(ColorTranslator.FromHtml("#33334c"), 0.5);
        }

        // PUBLISH
        public static void ButtonPublish_Click(object sender, EventArgs e)
        {
            MainStyles.labelTitle.Text = "PUBLISH";
            MainStyles.buttonPublish.Enabled = false;
            MainStyles.buttonProfile.Enabled = true;
            MainStyles.buttonCollection.Enabled = true;
            OpenChildForm(new Publication.Publication(), sender);
        }


        public static void ButtonPublish_EnabledChanged(object sender, EventArgs e)
        {
            Button currentButton = (Button)sender;
            MainStyles.buttonPublish.ForeColor = Color.Gainsboro;
            MainStyles.buttonPublish.BackColor = currentButton.Enabled ? ColorTranslator.FromHtml("#33334c") : ThemeColor.ChangeColorBrightness(ColorTranslator.FromHtml("#33334c"), 0.5);
            MainStyles.buttonPublish.FlatAppearance.BorderColor = currentButton.Enabled ? ColorTranslator.FromHtml("#33334c") : ThemeColor.ChangeColorBrightness(ColorTranslator.FromHtml("#33334c"), 0.5);
        }

        // PROFILE
        public static void ButtonProfile_Click(object sender, EventArgs e)
        {
            MainStyles.labelTitle.Text = "PROFILE";
            MainStyles.buttonProfile.Enabled = false;
            MainStyles.buttonPublish.Enabled = true;
            MainStyles.buttonCollection.Enabled = true;
            OpenChildForm(new Profile.Profile(), sender);
        }


        public static void ButtonProfile_EnabledChanged(object sender, EventArgs e)
        {
            Button currentButton = (Button)sender;
            MainStyles.buttonProfile.ForeColor = Color.Gainsboro;
            MainStyles.buttonProfile.BackColor = currentButton.Enabled ? ColorTranslator.FromHtml("#33334c") : ThemeColor.ChangeColorBrightness(ColorTranslator.FromHtml("#33334c"), 0.5);
            MainStyles.buttonProfile.FlatAppearance.BorderColor = currentButton.Enabled ? ColorTranslator.FromHtml("#33334c") : ThemeColor.ChangeColorBrightness(ColorTranslator.FromHtml("#33334c"), 0.5);
        }

        // LOGOUT
        public static void ButtonTimes_Click(object sender, EventArgs e)
        {
            if (currentForm != null)
            {
                MainStyles.labelTitle.Text = currentForm.Text;
                MainStyles.buttonProfile.Enabled = false;
                MainStyles.buttonPublish.Enabled = false;
                MainStyles.buttonCollection.Enabled = false;
                currentForm.Close();
            }
            Reset();
            MainStyles.SignIn.Visible = true;
            MainStyles.flowLayoutPanel1.Visible = true;
        }

        public static void Reset()
        {
            DisableButton();
            MainStyles.labelTitle.Text = "HOME";
            currentButton = null;
            MainStyles.buttonTimes.Visible = false;
            MainStyles.SetButtonColors();
        }

        // SHOW PASSWORD FOR SIGNUP
        public static void CheckBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (MainStyles.checkBoxShowPassword.Checked)
            {
                MainStyles.textBoxPassword.PasswordChar = '\0';
                MainStyles.textBoxConfirmPassword.PasswordChar = '\0';
            }
            else
            {
                MainStyles.textBoxPassword.PasswordChar = '\u25CF';
                MainStyles.textBoxConfirmPassword.PasswordChar = '\u25CF';
            }
        }

        // IS PHONE NUMBER
        public static bool IsPhoneNbr(string number, string motif)
        {
            if (number != null) return Regex.IsMatch(number, motif);
            else return false;
        }

        // SIGN UP
        public static void ButtonSignup_Click(object sender, EventArgs e)
        {
            DreamCarContext context = new DreamCarContext();
            DreamCarContext contextSignUp = new DreamCarContext();
            User user = MainReq.GetCurrentUser(context, MainStyles.textBoxUsernameSignin.Text, "password", false);
            if (MainStyles.textBoxUsername.Text == "" ||
                MainStyles.textBoxPassword.Text == "" ||
                MainStyles.textBoxConfirmPassword.Text == "" ||
                MainStyles.textBoxFirstName.Text == "" ||
                MainStyles.textBoxLastName.Text == "" ||
                MainStyles.textBoxCountry.Text == "" ||
                MainStyles.textBoxAddress.Text == "" ||
                MainStyles.textBoxPhone.Text == "" ||
                MainStyles.textBoxCity.Text == "" ||
                MainStyles.textBoxEmail.Text == "")
            {
                string emptyTextBoxes = "";
                
                foreach (Control control in MainStyles.flowLayoutPanel2.Controls)
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

            if (MainStyles.textBoxUsername.Text.Length > 16)
            {
                MessageBox.Show("Username can contain max 16 characters.", "Registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MainStyles.textBoxUsername.Text = "";
                MainStyles.textBoxPassword.Text = "";
                MainStyles.textBoxConfirmPassword.Text = "";
                MainStyles.textBoxUsername.Focus();
                return;
            }

            if (user.UserId.ToString().Length > 0)
            {
                MessageBox.Show("User with current username exists, choose another username.", "Registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MainStyles.textBoxUsername.Text = "";
                MainStyles.textBoxPassword.Text = "";
                MainStyles.textBoxConfirmPassword.Text = "";
                MainStyles.textBoxUsername.Focus();
                return;
            }

            //if(!IsPhoneNbr(textBoxPhone.Text.ToString(), @"^+48 [0-9]{3} [0-9]{3} [0-9]{3}$"))
            //{
            //    MessageBox.Show("Please enter valid phone number. Sample current format: '+48 *** *** ***' (For you location onyl Polish numbers accepted).", "Registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    textBoxPassword.Text = "";
            //    textBoxConfirmPassword.Text = "";
            //    return;
            //}

            if (MainStyles.textBoxPassword.Text == MainStyles.textBoxConfirmPassword.Text)
            {
                contextSignUp.Add(new User() { 
                    UserUsername = MainStyles.textBoxUsername.Text,
                    UserPassword = MainStyles.textBoxPassword.Text,
                    UserFirstName = MainStyles.textBoxFirstName.Text,
                    UserLastName = MainStyles.textBoxLastName.Text,
                    UserEmail = MainStyles.textBoxEmail.Text,
                    UserCountry = MainStyles.textBoxCountry.Text,
                    UserCity = MainStyles.textBoxCity.Text,
                    UserAddress = MainStyles.textBoxAddress.Text,
                    UserPhone = MainStyles.textBoxPhone.Text,
                });
                contextSignUp.SaveChanges();

                MainStyles.textBoxUsername.Text = "";
                MainStyles.textBoxPassword.Text = "";
                MainStyles.textBoxConfirmPassword.Text = "";

                MessageBox.Show("Your account has been successfully created!", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                MainStyles.SignIn.Visible = true;
                MainStyles.SignUp.Visible = false;
                return;
            }
            else
            {
                MessageBox.Show("Passwords don't match, Please enter valid credentials.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MainStyles.textBoxPassword.Text = "";
                MainStyles.textBoxConfirmPassword.Text = "";
                MainStyles.textBoxPassword.Focus();
                return;
            }
        }

        private static void Clear()
        {
            MainStyles.textBoxUsernameSignin.Text = "";
            MainStyles.textBoxPasswordSignin.Text = "";
            MainStyles.textBoxFirstName.Text = "";
            MainStyles.textBoxLastName.Text = "";
            MainStyles.textBoxEmail.Text = "";
            MainStyles.textBoxCountry.Text = "";
            MainStyles.textBoxCity.Text = "";
            MainStyles.textBoxAddress.Text = "";
            MainStyles.textBoxPhone.Text = "";
            MainStyles.textBoxUsername.Text = "";
            MainStyles.textBoxPassword.Text = "";
            MainStyles.textBoxConfirmPassword.Text = "";
            MainStyles.textBoxUsernameSignin.Text = "";
            MainStyles.textBoxPasswordSignin.Text = "";
            if (MainStyles.SignIn.Visible)
            {
                MainStyles.textBoxUsernameSignin.Focus();
            }
            else
            {
                MainStyles.textBoxFirstName.Focus();
            }
        }

        public static void ButtonClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        public static void LabelChangeToSignin_Click(object sender, EventArgs e)
        {
            MainStyles.checkBoxShowPassword.Checked = false;
            Clear();
            MainStyles.SignIn.Visible = true;
            MainStyles.SignUp.Visible = false;
            MainStyles.textBoxUsernameSignin.Focus();
        }

        // SHOW PASSWORD FOR SIGNIN
        public static void CheckBoxShowPasswordSignin_CheckedChange(object sender, EventArgs e)
        {
            if (MainStyles.checkBoxShowPasswordSignin.Checked)
            {
                MainStyles.textBoxPasswordSignin.PasswordChar = '\0';
            }
            else
            {
                MainStyles.textBoxPasswordSignin.PasswordChar = '\u25CF';
            }
        }

        // SIGN IN
        public static void ButtonSignin_Click(object sender, EventArgs e)
        {
            DreamCarContext context = new DreamCarContext();
            User user = MainReq.GetCurrentUser(context, MainStyles.textBoxUsernameSignin.Text, MainStyles.textBoxPasswordSignin.Text, true);
            if (MainStyles.textBoxUsernameSignin.Text == "" && MainStyles.textBoxPasswordSignin.Text == "")
            {
                MessageBox.Show("Empty Username and Pasword fields. Please fill up the form and try again", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MainStyles.textBoxUsernameSignin.Focus();
            }
            else if (MainStyles.textBoxUsernameSignin.Text == "")
            {
                MessageBox.Show("Empty Username field. Please fill up the form and try again", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MainStyles.textBoxUsernameSignin.Focus();
            }
            else if (MainStyles.textBoxPasswordSignin.Text == "")
            {
                MessageBox.Show("Empty Password field. Please fill up the form and try again", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MainStyles.textBoxPasswordSignin.Focus();
            }
            else if (user != null)
            {
                currentUserId = user.UserId;
                currentUserUsername = MainStyles.textBoxUsernameSignin.Text.ToString();
                MainStyles.buttonCollection.Enabled = true;
                MainStyles.buttonProfile.Enabled = true;
                MainStyles.buttonPublish.Enabled = true;
                MainStyles.SignIn.Visible = false;
                MainStyles.SignUp.Visible = false;
                MainStyles.flowLayoutPanel1.Visible = false;

                if (currentForm != null)
                {
                    MainStyles.labelTitle.Text = currentForm.Text;
                    currentForm.Close();
                }
                MainStyles.textBoxUsernameSignin.Text = "";
                MainStyles.textBoxPasswordSignin.Text = "";
                MainStyles.labelTitle.Text = "COLLECTION";
                OpenChildForm(new Collection.Collection(), MainStyles.buttonCollection);
                MainStyles.buttonTimes.Visible = true;
            }
            else
            {
                MessageBox.Show("Invalid Username or Password, Please try again", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Clear();
            }
        }

        public static void ButtonClearSignin(object sender, EventArgs e)
        {
            Clear();
        }


        public static void LabelChangeToSignup_Click(object sender, EventArgs e)
        {
            MainStyles.checkBoxShowPasswordSignin.Checked = false;
            Clear();
            MainStyles.SignIn.Visible = false;
            MainStyles.SignUp.Visible = true;
            MainStyles.textBoxFirstName.Focus();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Main
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "Main";
            this.ResumeLayout(false);

        }
    }
}