using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DreamCar.Forms.Main;
using DreamCar.Helpers;

namespace DreamCar.Forms.Main
{
    public class MainStyles
    {

        public MainStyles()
        {

        }

        public static void SetButtonColors()
        {
            Main.buttonCollection.BackColor = ThemeColor.ChangeColorBrightness(ColorTranslator.FromHtml("#33334c"), 0.5);
            Main.buttonCollection.ForeColor = Color.Gainsboro;
            Main.buttonCollection.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;

            Main.buttonProfile.BackColor = ThemeColor.ChangeColorBrightness(ColorTranslator.FromHtml("#33334c"), 0.5);
            Main.buttonProfile.ForeColor = Color.Gainsboro;
            Main.buttonProfile.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;

            Main.buttonPublish.BackColor = ThemeColor.ChangeColorBrightness(ColorTranslator.FromHtml("#33334c"), 0.5);
            Main.buttonPublish.ForeColor = Color.Gainsboro;
            Main.buttonPublish.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
        }

        public static void ButtonCollection_Paint(object sender, PaintEventArgs e)
        {
            Button currentButton = (Button)sender;
            Main.buttonCollection.ForeColor = Color.Gainsboro;
            SolidBrush drawBrush = new SolidBrush(currentButton.ForeColor);
            StringFormat sf = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            Main.buttonCollection.Text = string.Empty;
            e.Graphics.DrawString("    Collection", currentButton.Font, drawBrush, e.ClipRectangle, sf);
            drawBrush.Dispose();
            sf.Dispose();
        }

        public static void ButtonPublish_Paint(object sender, PaintEventArgs e)
        {
            Button currentButton = (Button)sender;
            Main.buttonPublish.ForeColor = Color.Gainsboro;
            SolidBrush drawBrush = new SolidBrush(currentButton.ForeColor);
            StringFormat sf = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            Main.buttonPublish.Text = string.Empty;
            e.Graphics.DrawString("Publish", currentButton.Font, drawBrush, e.ClipRectangle, sf);
            drawBrush.Dispose();
            sf.Dispose();
        }

        public static void ButtonProfile_Paint(object sender, PaintEventArgs e)
        {
            Button currentButton = (Button)sender;
            Main.buttonProfile.ForeColor = Color.Gainsboro;
            SolidBrush drawBrush = new SolidBrush(currentButton.ForeColor);
            StringFormat sf = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            Main.buttonProfile.Text = string.Empty;
            e.Graphics.DrawString("Profile", currentButton.Font, drawBrush, e.ClipRectangle, sf);
            drawBrush.Dispose();
            sf.Dispose();
        }
    }
}
