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
            InitializeComponent();

            buttonTimes.Visible = false;
            buttonCollection.Enabled = false;
            buttonProfile.Enabled = false;
            buttonPublish.Enabled = false;

            MainStyles.SetButtonColors();

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
            OpenChildForm(new Forms.Collection.Collection(), sender);
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
            OpenChildForm(new Forms.Publish.Publication(), sender);
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
            labelTitle.Text = "PROFILE";
            buttonProfile.Enabled = false;
            buttonPublish.Enabled = true;
            buttonCollection.Enabled = true;
            OpenChildForm(new Forms.Profile.Profile(), sender);
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
            MainStyles.SetButtonColors();
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
            DreamCarContext context = new DreamCarContext();
            DreamCarContext contextSignUp = new DreamCarContext();
            User user = MainReq.GetCurrentUser(context, textBoxUsernameSignin.Text, "password", false);
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
                MessageBox.Show("Username can contain max 16 characters.", "Registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxUsername.Text = "";
                textBoxPassword.Text = "";
                textBoxConfirmPassword.Text = "";
                textBoxUsername.Focus();
                return;
            }

            if (user.UserId.ToString().Length > 0)
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

        private void Clear()
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
            textBoxUsernameSignin.Text = "";
            textBoxPasswordSignin.Text = "";
            if (SignIn.Visible)
            {
                textBoxUsernameSignin.Focus();
            }
            else
            {
                textBoxFirstName.Focus();
            }
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void LabelChangeToSignin_Click(object sender, EventArgs e)
        {
            checkBoxShowPassword.Checked = false;
            Clear();
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
            DreamCarContext context = new DreamCarContext();
            User user = MainReq.GetCurrentUser(context, textBoxUsernameSignin.Text, textBoxPasswordSignin.Text, true);
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
            else if (user.UserId.ToString().Length > 0)
            {
                currentUserId = user.UserId;
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
                OpenChildForm(new Forms.Collection.Collection(), buttonCollection);
                Reset();
                buttonTimes.Visible = true;
            }
            else
            {
                MessageBox.Show("Invalid Username or Password, Please try again", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Clear();
            }
        }

        private void ButtonClearSignin(object sender, EventArgs e)
        {
            Clear();
        }


        private void LabelChangeToSignup_Click(object sender, EventArgs e)
        {
            checkBoxShowPasswordSignin.Checked = false;
            Clear();
            SignIn.Visible = false;
            SignUp.Visible = true;
            textBoxFirstName.Focus();
        }

        public static Panel panelMenu;
        public static Button buttonCollection;
        public static Button buttonProfile;
        public static Button buttonPublish;
        public static Panel panelTitleBar;
        public static Label labelTitle;
        public static Label labelDreamCar;
        public static PictureBox pictureBox1;
        public static Panel panelMain;
        public static Button buttonTimes;
        public static Label label1;
        public static PictureBox pictureBox2;
        public static FlowLayoutPanel flowLayoutPanel1;
        public static TextBox textBoxPassword;
        public static TextBox textBoxUsername;
        public static Label labelPassword;
        public static Label labelSignup;
        public static TextBox textBoxConfirmPassword;
        public static Label labelConfirmPassword;
        public static Button buttonSignup;
        public static Label labelChangeToSignin;
        public static Label labelHaveAcc;
        public static Button buttonClear;
        public static FlowLayoutPanel flowLayoutPanel2;
        public static FlowLayoutPanel SignUp;
        public static FlowLayoutPanel SignIn;
        public static Label labelSignin;
        public static FlowLayoutPanel flowLayoutPanel5;
        public static Label labelUsernameSignin;
        public static TextBox textBoxUsernameSignin;
        public static Label labelPasswordSignin;
        public static TextBox textBoxPasswordSignin;
        public static CheckBox checkBoxShowPasswordSignin;
        public static Button buttonSignin;
        public static Button buttonClearSignin;
        public static Label labelDontHaveAcc;
        public static Label labelChangeToSignup;
        public static TextBox textBoxEmail;
        public static TextBox textBoxPhone;
        public static TextBox textBoxFirstName;
        public static TextBox textBoxLastName;
        public static TextBox textBoxCountry;
        public static TextBox textBoxCity;
        public static Label labelFirstName;
        public static Label labelLastName;
        public static Label labelUsername;
        public static Label labelCountry;
        public static Label labelCity;
        public static Label labelAddress;
        public static TextBox textBoxAddress;
        public static Label labelPhone;
        public static Label labelEmail;
        public static CheckBox checkBoxShowPassword;
        public static FlowLayoutPanel panelLogo;
    }
}