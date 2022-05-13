using DreamCar.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamCar.Forms.MyProfile
{
    public partial class MyProfileStyles
    {
        public MyProfileStyles()
        {

        }

        public static Models.User GetUserDataByUsername(string username)
        {
            using(DreamCarContext context = new DreamCarContext())
            {
                return context.Users.Where(u => u.UserUsername == username).FirstOrDefault();
            }
        }
    }
}
