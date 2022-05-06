using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DreamCar.Helpers
{
    public class Container : Form
    {
        public static Button currentButton;
        public static Form currentForm;

        public static string currentUserUsername;
        public static int currentUserId;

        public Image setBackgroungImageUrl(string imageUrl)
        {
            var request = WebRequest.Create(imageUrl);
            using (var webSresponse = request.GetResponse())
            using (var webStream = webSresponse.GetResponseStream())
            {
                return Bitmap.FromStream(webStream);
            }
        }
    }
}
