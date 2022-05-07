using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
