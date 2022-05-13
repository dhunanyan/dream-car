using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DreamCar.Forms.MyReservations
{
    public partial class MyReservations : Form
    {
        public static int initialCarGenAmount = 6;
        public MyReservations()
        {
            MyReservationsStyles.flowLayoutPanelCarCollection = new FlowLayoutPanel();
            Collection.CollectionStyles.GerenerateCollectionContainer(this, MyReservationsStyles.flowLayoutPanelCarCollection, initialCarGenAmount);
            Collection.CollectionStyles.ChangeCollectionContainerScrollMinSize(initialCarGenAmount);
            Collection.Collection.GenerateReservationsCollection(MyReservationsStyles.flowLayoutPanelCarCollection, initialCarGenAmount, initialCarGenAmount - 6);
            MyReservationsStyles.UpdateStyles(initialCarGenAmount);
            MyReservationsStyles.EmptyFlow();
            MyReservationsStyles.CreateLoadMoreButton(this);
        }

        public static void ButtonLoadMore_Click(object sender, EventArgs e)
        {
            initialCarGenAmount += 6;
            Collection.Collection.GenerateReservationsCollection(MyReservationsStyles.flowLayoutPanelCarCollection, initialCarGenAmount, initialCarGenAmount - 6);
            if ((MyReservationsStyles.flowLayoutPanelCarCollection.AutoScrollMinSize.Height + 65) / 65 > initialCarGenAmount)
            {
                MyReservationsStyles.buttonLoadMore.Enabled = false;
            }
            else
            {
                MyReservationsStyles.buttonLoadMore.Enabled = true;
            }
        }
    }
}
