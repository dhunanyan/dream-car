﻿using System.Collections.Generic;
using System.Drawing;

namespace DreamCar.Helpers
{
    public class ThemeColor
    {
        public static Color PrimaryColor { get; set; }
        public static Color SecondaryColor { get; set; }
        public static Color TertiaryColor { get; set; }

        public static Dictionary<string, string> colorList = new Dictionary<string, string>() {
            {"buttonSettings", "#74d484" },
            {"buttonPlay", "#74d484" },
            {"buttonRanking", "#74d484" },
        };

        //public static Dictionary<string, string> colorList = new Dictionary<string, string>() {
        //    {"buttonSettings", "#2196f3" },
        //    {"buttonPlay", "#43b76e" },
        //    {"buttonRanking", "#e41a4a" },
        //};

        public static Color ChangeColorBrightness(Color color, double correctionFactor)
        {
            double red = color.R;
            double green = color.G;
            double blue = color.B;
            if (correctionFactor < 0)
            {
                correctionFactor = 1 + correctionFactor;
                red *= correctionFactor;
                green *= correctionFactor;
                blue *= correctionFactor;
            }
            else
            {
                red = (255 - red) * correctionFactor + red;
                green = (255 - green) * correctionFactor + green;
                blue = (255 - blue) * correctionFactor + blue;
            }
            return Color.FromArgb(color.A, (byte)red, (byte)green, (byte)blue);
        }
    }
}

