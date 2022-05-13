using DreamCar.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DreamCar.Forms.Profile
{
    public partial class Profile : Container
    {
        public Profile()
        {
            ProfileStyles.InitializeComponent(this);

            ProfileStyles.buttonMyFavourites.Enabled = true;
            ProfileStyles.buttonMyProfile.Enabled = false;
            ProfileStyles.buttonMyCollection.Enabled = true;

        }

        public static Color SelectThemeColor(string buttonName)
        {
            //string color = ThemeColor.colorList[buttonName];
            return ColorTranslator.FromHtml("#74d484");
        }

        public static void ActivateButton(object buttonSender)
        {
            if (buttonSender == null || currentProfileButton == (Button)buttonSender)
            {
                return;
            }
            DisableButton();
            currentProfileButton = (Button)buttonSender;
            Color currentColor = SelectThemeColor(currentProfileButton.Name);
            currentProfileButton.BackColor = currentColor;
            currentProfileButton.ForeColor = Color.White;
            ProfileStyles.panelTitleBar.BackColor = currentColor;
            ThemeColor.PrimaryColor = currentColor;
            ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(currentColor, -0.3);
            ThemeColor.TertiaryColor = ThemeColor.ChangeColorBrightness(currentColor, 0.5);
        }

        public static void DisableButton()
        {
            foreach (Control previousButton in ProfileStyles.panelMenu.Controls)
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
            if (currentProfileForm != null)
            {
                currentProfileForm.Close();
            }
            ActivateButton(buttonSender);
            currentProfileForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            ProfileStyles.panelMain.Controls.Add(childForm);
            ProfileStyles.panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        // MY FAVOURITES
        public static void ButtonMyFavourites_Click(object sender, EventArgs e)
        {
            ProfileStyles.labelTitle.Text = "My Favourites";
            ProfileStyles.buttonMyFavourites.Enabled = false;
            ProfileStyles.buttonMyProfile.Enabled = true;
            ProfileStyles.buttonMyCollection.Enabled = true;
            OpenChildForm(new MyFavourites.MyFavourites(), sender);
        }

        public static void ButtonMyFavourites_EnabledChanged(object sender, EventArgs e)
        {
            Button currentButton = (Button)sender;
            ProfileStyles.buttonMyFavourites.ForeColor = Color.Gainsboro;
            ProfileStyles.buttonMyFavourites.BackColor = currentButton.Enabled ? ColorTranslator.FromHtml("#33334c") : ThemeColor.ChangeColorBrightness(ColorTranslator.FromHtml("#33334c"), 0.5);
            ProfileStyles.buttonMyFavourites.FlatAppearance.BorderColor = currentButton.Enabled ? ColorTranslator.FromHtml("#33334c") : ThemeColor.ChangeColorBrightness(ColorTranslator.FromHtml("#33334c"), 0.5);
        }

        // MY COLLECTION
        public static void ButtonMyCollection_Click(object sender, EventArgs e)
        {
            ProfileStyles.labelTitle.Text = "My Collection";
            ProfileStyles.buttonMyCollection.Enabled = false;
            ProfileStyles.buttonMyProfile.Enabled = true;
            ProfileStyles.buttonMyFavourites.Enabled = true;
            OpenChildForm(new MyCollection.MyCollection(), sender);
        }


        public static void ButtonMyCollection_EnabledChanged(object sender, EventArgs e)
        {
            Button currentButton = (Button)sender;
            ProfileStyles.buttonMyCollection.ForeColor = Color.Gainsboro;
            ProfileStyles.buttonMyCollection.BackColor = currentButton.Enabled ? ColorTranslator.FromHtml("#33334c") : ThemeColor.ChangeColorBrightness(ColorTranslator.FromHtml("#33334c"), 0.5);
            ProfileStyles.buttonMyCollection.FlatAppearance.BorderColor = currentButton.Enabled ? ColorTranslator.FromHtml("#33334c") : ThemeColor.ChangeColorBrightness(ColorTranslator.FromHtml("#33334c"), 0.5);
        }

        // MY PROFILE
        public static void ButtonMyProfile_Click(object sender, EventArgs e)
        {
            ProfileStyles.labelTitle.Text = "My Profile";
            ProfileStyles.buttonMyProfile.Enabled = false;
            ProfileStyles.buttonMyCollection.Enabled = true;
            ProfileStyles.buttonMyFavourites.Enabled = true;
            OpenChildForm(new MyProfile.MyProfile(), sender);
        }


        public static void ButtonMyProfile_EnabledChanged(object sender, EventArgs e)
        {
            Button currentButton = (Button)sender;
            ProfileStyles.buttonMyProfile.ForeColor = Color.Gainsboro;
            ProfileStyles.buttonMyProfile.BackColor = currentButton.Enabled ? ColorTranslator.FromHtml("#33334c") : ThemeColor.ChangeColorBrightness(ColorTranslator.FromHtml("#33334c"), 0.5);
            ProfileStyles.buttonMyProfile.FlatAppearance.BorderColor = currentButton.Enabled ? ColorTranslator.FromHtml("#33334c") : ThemeColor.ChangeColorBrightness(ColorTranslator.FromHtml("#33334c"), 0.5);
        }
    }
}
