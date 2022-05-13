using DreamCar.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DreamCar.Forms.MyProfile
{
    public partial class MyProfile : Helpers.Container
    {
        public MyProfile()
        {
            MyProfileStyles.InitializeComponent(this);
            User user = MyProfileStyles.GetUserDataByUsername(currentUserUsername);
            SetMyProfileData(user);
        }

        public static void SetMyProfileData(User user)
        {
            MyProfileStyles.labelUsername.Text = user.UserUsername;
            MyProfileStyles.labeluserFirstName.Text = user.UserFirstName;
            MyProfileStyles.labelUserLastName.Text = user.UserLastName;
            MyProfileStyles.labelUserCountry.Text = user.UserCountry;
            MyProfileStyles.labelUserCity.Text = user.UserCity;
            MyProfileStyles.labelUserPhone.Text = user.UserPhone;
            MyProfileStyles.labelUserMail.Text = user.UserEmail;
        }
    }
}
