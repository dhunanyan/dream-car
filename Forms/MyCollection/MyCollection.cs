using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DreamCar.Forms.MyCollection
{
    public partial class MyCollection : Form
    {
        public static int initialCarGenAmount = 6;
        public MyCollection()
        {
            MyCollectionStyles.flowLayoutPanelCarCollection = new FlowLayoutPanel();
            Collection.CollectionStyles.GerenerateCollectionContainer(this, MyCollectionStyles.flowLayoutPanelCarCollection, initialCarGenAmount);
            Collection.CollectionStyles.ChangeCollectionContainerScrollMinSize(initialCarGenAmount);
            Collection.Collection.GeneratePublicationsCollection(MyCollectionStyles.flowLayoutPanelCarCollection, initialCarGenAmount, initialCarGenAmount - 6);
            MyCollectionStyles.UpdateStyles(initialCarGenAmount);
            MyCollectionStyles.EmptyFlow();
        }
    }
}
