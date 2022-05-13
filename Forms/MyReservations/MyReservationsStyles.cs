using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DreamCar.Forms.MyReservations
{
    public partial class MyReservationsStyles
    {
        public MyReservationsStyles()
        {
            //Console.WriteLine(currentUser);
        }

        public static void UpdateStyles(int take)
        {
            flowLayoutPanelCarCollection.AutoScroll = false;
            flowLayoutPanelCarCollection.AutoScrollMinSize = new Size(0, 0);
            flowLayoutPanelCarCollection.Location = new Point(take == 6 ? 25 : 15, 100);
            flowLayoutPanelCarCollection.AutoScroll = true;
            flowLayoutPanelCarCollection.AutoScrollMinSize = new Size(0, (65 * take) + 25);
            flowLayoutPanelCarCollection.MinimumSize = new Size(take == 6 ? 1020 : 1040, take == 6 ? 65 * 6 + 35 : 65 * 6 + 50);
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
                labelEmpty.Text = "Your Reservations list is empty go to collection and choose a car to reserve";
                labelEmpty.TextAlign = ContentAlignment.MiddleCenter;
            }
            else
            {
                flowLayoutPanelCarCollection.Controls.Remove(labelEmpty);
            }
        }

        public static void CreateLoadMoreButton(Form form)
        {
            // 
            // buttonLoadMore
            // 
            buttonLoadMore = new Button();
            buttonLoadMore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(184)))), ((int)(((byte)(119)))));
            buttonLoadMore.FlatAppearance.BorderSize = 0;
            buttonLoadMore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonLoadMore.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F);
            buttonLoadMore.ForeColor = System.Drawing.Color.Gainsboro;
            buttonLoadMore.Location = new System.Drawing.Point(50, 65);
            buttonLoadMore.Margin = new System.Windows.Forms.Padding(0);
            buttonLoadMore.Name = "buttonLoadMore";
            buttonLoadMore.Size = new System.Drawing.Size(191, 36);
            buttonLoadMore.TabIndex = 4;
            buttonLoadMore.Text = "Load More";
            buttonLoadMore.UseVisualStyleBackColor = true;
            buttonLoadMore.Cursor = Cursors.Hand;
            buttonLoadMore.Click += new EventHandler(MyReservations.ButtonLoadMore_Click);
            form.Controls.Add(buttonLoadMore);
            buttonLoadMore.BringToFront();
        }


        // COLLECTION
        public static FlowLayoutPanel flowLayoutPanelCarCollection;
        public static Panel panelMain;
        public static Label labelEmpty;
        public static Button buttonLoadMore;

        // DETAILS
        public static FlowLayoutPanel flowLayoutPanelPopup;
        public static Button buttonPopupFav;
        public static DateTimePicker dateTimePickerPopupDate;
    }
}
