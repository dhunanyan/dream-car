using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DreamCar.Forms.MyFavourites
{
    public partial class MyFavouritesStyles
    {
        public MyFavouritesStyles()
        {
            //Console.WriteLine(currentUser);
        }

        public static void UpdateStyles(int take)
        {
            flowLayoutPanelCarCollection.Location = new Point(take == 6 ? 25 : 15, 100);
            flowLayoutPanelCarCollection.AutoScroll = true;
            flowLayoutPanelCarCollection.AutoScrollMinSize = new Size(0, (65 * take) + 25);
            flowLayoutPanelCarCollection.MinimumSize = new Size(take == 6 ? 1020 : 1040, take == 6 ? 65 * 6 + 25 : 65 * 6 + 50);
        }

        public static void EmptyFlow()
        {
            labelEmpty = new Label();
            flowLayoutPanelCarCollection.Controls.Add(labelEmpty);
            if (flowLayoutPanelCarCollection.Controls.Count < 2)
            {
                
                labelEmpty.BackColor = Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(110)))));
                labelEmpty.Font = new Font("Tw Cen MT Condensed", 18F, FontStyle.Bold);
                labelEmpty.ForeColor = Color.Gainsboro;
                labelEmpty.Location = new Point(0, 0);
                labelEmpty.Margin = new Padding(0, 0, 5, 0);
                labelEmpty.Name = "labelEmpty";
                labelEmpty.Size = new Size(950, 65 * 6);
                labelEmpty.TabIndex = 0;
                labelEmpty.Text = "You Favourites list is empty go to collection to add cars here";
                labelEmpty.TextAlign = ContentAlignment.MiddleCenter;
            }
            else
            {
                flowLayoutPanelCarCollection.Controls.Remove(labelEmpty);
            }
        }


        // COLLECTION
        public static FlowLayoutPanel flowLayoutPanelCarCollection;
        public static Panel panelMain;
        public static Label labelEmpty;

        // DETAILS
        public static FlowLayoutPanel flowLayoutPanelPopup;
        public static Button buttonPopupFav;
        public static DateTimePicker dateTimePickerPopupDate;
    }
}

