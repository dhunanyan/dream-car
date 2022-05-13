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
            InitializeComponent();

            //    buttonTimes.Visible = false;
            //    buttonCollection.Enabled = false;
            //    buttonProfile.Enabled = false;
            //    buttonPublish.Enabled = false;

            //    Color color = ColorTranslator.FromHtml("#74d484");

            //    buttonCollection.BackColor = ThemeColor.ChangeColorBrightness(ColorTranslator.FromHtml("#33334c"), 0.5);
            //    buttonCollection.ForeColor = Color.Gainsboro;
            //    buttonCollection.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;

            //    buttonProfile.BackColor = ThemeColor.ChangeColorBrightness(ColorTranslator.FromHtml("#33334c"), 0.5);
            //    buttonProfile.ForeColor = Color.Gainsboro;
            //    buttonProfile.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;

            //    buttonPublish.BackColor = ThemeColor.ChangeColorBrightness(ColorTranslator.FromHtml("#33334c"), 0.5);
            //    buttonPublish.ForeColor = Color.Gainsboro;
            //    buttonPublish.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;

            //    SignUp.Visible = false;
            //    SignIn.Visible = true;
        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {

        }

        private void comboBox1_DropDownClosed(object sender, EventArgs e)
        {

        }

        //private Color SelectThemeColor(string buttonName)
        //{
        //    //string color = ThemeColor.colorList[buttonName];
        //    return ColorTranslator.FromHtml("#74d484");
        //}

        //private void ActivateButton(object buttonSender)
        //{
        //    if (buttonSender == null || currentButton == (Button)buttonSender)
        //    {
        //        return;
        //    }
        //    DisableButton();
        //    currentButton = (Button)buttonSender;
        //    Color currentColor = SelectThemeColor(currentButton.Name);
        //    currentButton.BackColor = currentColor;
        //    currentButton.ForeColor = Color.White;
        //    panelTitleBar.BackColor = currentColor;
        //    ThemeColor.PrimaryColor = currentColor;
        //    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(currentColor, -0.3);
        //    ThemeColor.TertiaryColor = ThemeColor.ChangeColorBrightness(currentColor, 0.5);
        //    buttonTimes.Visible = true;
        //}

        //private void DisableButton()
        //{
        //    foreach (Control previousButton in panelMenu.Controls)
        //    {
        //        if (previousButton.GetType() == typeof(Button))
        //        {
        //            previousButton.BackColor = ColorTranslator.FromHtml("#33334c");
        //            previousButton.ForeColor = ColorTranslator.FromHtml("#33334c");
        //        }
        //    }
        //}

        //private void OpenChildForm(Form childForm, object buttonSender)
        //{
        //    if (currentForm != null)
        //    {
        //        currentForm.Close();
        //    }
        //    ActivateButton(buttonSender);
        //    currentForm = childForm;
        //    childForm.TopLevel = false;
        //    childForm.FormBorderStyle = FormBorderStyle.None;
        //    childForm.Dock = DockStyle.Fill;
        //    panelMain.Controls.Add(childForm);
        //    panelMain.Tag = childForm;
        //    childForm.BringToFront();
        //    childForm.Show();

        //}

        //// COLLECTION
        //private void ButtonCollection_Click(object sender, EventArgs e)
        //{
        //    labelTitle.Text = "COLLECTION";
        //    buttonCollection.Enabled = false;
        //    buttonProfile.Enabled = true;
        //    buttonPublish.Enabled = true;
        //    OpenChildForm(new Forms.FormCollection(), sender);
        //}

        //private void ButtonCollection_EnabledChanged(object sender, EventArgs e)
        //{
        //    Button currentButton = (Button)sender;
        //    buttonCollection.ForeColor = Color.Gainsboro;
        //    buttonCollection.BackColor = currentButton.Enabled ? ColorTranslator.FromHtml("#33334c") : ThemeColor.ChangeColorBrightness(ColorTranslator.FromHtml("#33334c"), 0.5);
        //    buttonCollection.FlatAppearance.BorderColor = currentButton.Enabled ? ColorTranslator.FromHtml("#33334c") : ThemeColor.ChangeColorBrightness(ColorTranslator.FromHtml("#33334c"), 0.5);
        //}

        //private void ButtonCollection_Paint(object sender, PaintEventArgs e)
        //{
        //    Button currentButton = (Button)sender;
        //    buttonCollection.ForeColor = Color.Gainsboro;
        //    SolidBrush drawBrush = new SolidBrush(currentButton.ForeColor);
        //    StringFormat sf = new StringFormat
        //    {
        //        Alignment = StringAlignment.Center,
        //        LineAlignment = StringAlignment.Center
        //    };
        //    buttonCollection.Text = string.Empty;
        //    e.Graphics.DrawString("    Collection", currentButton.Font, drawBrush, e.ClipRectangle, sf);
        //    drawBrush.Dispose();
        //    sf.Dispose();
        //}

        //// PUBLISH
        //private void ButtonPublish_Click(object sender, EventArgs e)
        //{
        //    //if (isLaunched)
        //    //{
        //    //    DialogResult dialog = MessageBox.Show("Youur current searching results will be lost, do you really want to leave?",
        //    //        "Session Exit", MessageBoxButtons.YesNo);
        //    //    if (dialog == DialogResult.No)
        //    //    {
        //    //        return;
        //    //    }
        //    //}

        //    labelTitle.Text = "PUBLISH";
        //    buttonPublish.Enabled = false;
        //    buttonProfile.Enabled = true;
        //    buttonCollection.Enabled = true;
        //    OpenChildForm(new Forms.FormPublish(), sender);
        //}


        //private void ButtonPublish_EnabledChanged(object sender, EventArgs e)
        //{
        //    Button currentButton = (Button)sender;
        //    buttonPublish.ForeColor = Color.Gainsboro;
        //    buttonPublish.BackColor = currentButton.Enabled ? ColorTranslator.FromHtml("#33334c") : ThemeColor.ChangeColorBrightness(ColorTranslator.FromHtml("#33334c"), 0.5);
        //    buttonPublish.FlatAppearance.BorderColor = currentButton.Enabled ? ColorTranslator.FromHtml("#33334c") : ThemeColor.ChangeColorBrightness(ColorTranslator.FromHtml("#33334c"), 0.5);
        //}

        //private void ButtonPublish_Paint(object sender, PaintEventArgs e)
        //{
        //    Button currentButton = (Button)sender;
        //    buttonPublish.ForeColor = Color.Gainsboro;
        //    SolidBrush drawBrush = new SolidBrush(currentButton.ForeColor);
        //    StringFormat sf = new StringFormat
        //    {
        //        Alignment = StringAlignment.Center,
        //        LineAlignment = StringAlignment.Center
        //    };
        //    buttonPublish.Text = string.Empty;
        //    e.Graphics.DrawString("Publish", currentButton.Font, drawBrush, e.ClipRectangle, sf);
        //    drawBrush.Dispose();
        //    sf.Dispose();
        //}

        //// PROFILE
        //private void ButtonProfile_Click(object sender, EventArgs e)
        //{
        //    //if (isLaunched)
        //    //{
        //    //    DialogResult dialog = MessageBox.Show("Youur current searching results will be lost, do you really want to leave?",
        //    //        "Session Exit", MessageBoxButtons.YesNo);
        //    //    if (dialog == DialogResult.No)
        //    //    {
        //    //        return;
        //    //    }
        //    //}
        //    labelTitle.Text = "PROFILE";
        //    buttonProfile.Enabled = false;
        //    buttonPublish.Enabled = true;
        //    buttonCollection.Enabled = true;
        //    OpenChildForm(new Forms.FormProfile(), sender);
        //    //timer.Stop();
        //}


        //private void ButtonProfile_EnabledChanged(object sender, EventArgs e)
        //{
        //    Button currentButton = (Button)sender;
        //    buttonProfile.ForeColor = Color.Gainsboro;
        //    buttonProfile.BackColor = currentButton.Enabled ? ColorTranslator.FromHtml("#33334c") : ThemeColor.ChangeColorBrightness(ColorTranslator.FromHtml("#33334c"), 0.5);
        //    buttonProfile.FlatAppearance.BorderColor = currentButton.Enabled ? ColorTranslator.FromHtml("#33334c") : ThemeColor.ChangeColorBrightness(ColorTranslator.FromHtml("#33334c"), 0.5);
        //}

        //private void ButtonProfile_Paint(object sender, PaintEventArgs e)
        //{
        //    Button currentButton = (Button)sender;
        //    buttonProfile.ForeColor = Color.Gainsboro;
        //    SolidBrush drawBrush = new SolidBrush(currentButton.ForeColor);
        //    StringFormat sf = new StringFormat
        //    {
        //        Alignment = StringAlignment.Center,
        //        LineAlignment = StringAlignment.Center
        //    };
        //    buttonProfile.Text = string.Empty;
        //    e.Graphics.DrawString("Profile", currentButton.Font, drawBrush, e.ClipRectangle, sf);
        //    drawBrush.Dispose();
        //    sf.Dispose();
        //}

        //private void Reset()
        //{
        //    DisableButton();
        //    labelTitle.Text = "HOME";
        //    currentButton = null;
        //    buttonTimes.Visible = false;
        //    buttonCollection.BackColor = buttonCollection.Enabled ? ColorTranslator.FromHtml("#33334c") : ThemeColor.ChangeColorBrightness(ColorTranslator.FromHtml("#33334c"), 0.5);
        //    buttonCollection.ForeColor = Color.Gainsboro;
        //    buttonCollection.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;

        //    buttonProfile.BackColor = buttonProfile.Enabled ? ColorTranslator.FromHtml("#33334c") : ThemeColor.ChangeColorBrightness(ColorTranslator.FromHtml("#33334c"), 0.5);
        //    buttonProfile.ForeColor = Color.Gainsboro;
        //    buttonProfile.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;

        //    buttonPublish.BackColor = buttonPublish.Enabled ? ColorTranslator.FromHtml("#33334c") : ThemeColor.ChangeColorBrightness(ColorTranslator.FromHtml("#33334c"), 0.5);
        //    buttonPublish.ForeColor = Color.Gainsboro;
        //    buttonPublish.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
        //}

    }
}
