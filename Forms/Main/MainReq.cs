using DreamCar.Data;
using DreamCar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamCar.Forms.Main
{
    public class MainReq
    {

        public MainReq()
        {

        }

        public static User GetCurrentUser(DreamCarContext context, string username, string password, bool isSignIn)
        {
            if(isSignIn)
            {
                return context.Users.Where(u => u.UserUsername == username && u.UserPassword == password).First();
            }
            else
            {
                return context.Users.Where(u => u.UserUsername == username).First();
            }
        }
    }
}
