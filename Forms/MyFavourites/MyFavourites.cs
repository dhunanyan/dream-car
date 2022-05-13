using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DreamCar.Forms.MyFavourites
{
    public partial class MyFavourites : Form
    {
        public static int initialCarGenAmount = 6;
        public MyFavourites()
        {
            MyFavouritesStyles.flowLayoutPanelCarCollection = new FlowLayoutPanel();
            Collection.CollectionStyles.GerenerateCollectionContainer(this, MyFavouritesStyles.flowLayoutPanelCarCollection, initialCarGenAmount);
            Collection.CollectionStyles.ChangeCollectionContainerScrollMinSize(initialCarGenAmount);
            Collection.Collection.GenerateFavsCollection(MyFavouritesStyles.flowLayoutPanelCarCollection, initialCarGenAmount, initialCarGenAmount - 6);
            MyFavouritesStyles.UpdateStyles(initialCarGenAmount);
            MyFavouritesStyles.EmptyFlow();
            MyFavouritesStyles.CreateLoadMoreButton(this);
        }

        public static void ButtonLoadMore_Click(object sender, EventArgs e)
        {
            initialCarGenAmount += 6;
            Collection.Collection.GenerateFavsCollection(MyFavouritesStyles.flowLayoutPanelCarCollection, initialCarGenAmount, initialCarGenAmount - 6);
            if ((MyFavouritesStyles.flowLayoutPanelCarCollection.AutoScrollMinSize.Height + 65) / 65 > initialCarGenAmount)
            {
                MyFavouritesStyles.buttonLoadMore.Enabled = false;
            }
            else
            {
                MyFavouritesStyles.buttonLoadMore.Enabled = true;
            }
        }
    }
}
