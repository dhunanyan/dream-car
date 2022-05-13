using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DreamCar.Forms.MyProfile
{
    public partial class MyProfileStyles
    {
        public static void InitializeComponent(Form form)
        {
            labelUsername = new System.Windows.Forms.Label();
            labeluserFirstName = new System.Windows.Forms.Label();
            labelUserLastName = new System.Windows.Forms.Label();
            labelUserCountry = new System.Windows.Forms.Label();
            labelUserCity = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            labelUserPhone = new System.Windows.Forms.Label();
            labelUserMail = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            panel2 = new System.Windows.Forms.Panel();
            labelDreamCar = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            panel2.SuspendLayout();
            form.SuspendLayout();
            // 
            // labelUsername
            // 
            labelUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            labelUsername.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            labelUsername.ForeColor = System.Drawing.Color.Gainsboro;
            labelUsername.Location = new System.Drawing.Point(14, 12);
            labelUsername.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new System.Drawing.Size(215, 45);
            labelUsername.TabIndex = 4;
            labelUsername.Text = "Username";
            labelUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labeluserFirstName
            // 
            labeluserFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            labeluserFirstName.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            labeluserFirstName.ForeColor = System.Drawing.Color.Gainsboro;
            labeluserFirstName.Location = new System.Drawing.Point(234, 12);
            labeluserFirstName.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
            labeluserFirstName.Name = "labeluserFirstName";
            labeluserFirstName.Size = new System.Drawing.Size(215, 45);
            labeluserFirstName.TabIndex = 5;
            labeluserFirstName.Text = "FirstName";
            labeluserFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelUserLastName
            // 
            labelUserLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            labelUserLastName.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            labelUserLastName.ForeColor = System.Drawing.Color.Gainsboro;
            labelUserLastName.Location = new System.Drawing.Point(454, 12);
            labelUserLastName.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
            labelUserLastName.Name = "labelUserLastName";
            labelUserLastName.Size = new System.Drawing.Size(215, 45);
            labelUserLastName.TabIndex = 6;
            labelUserLastName.Text = "LastName";
            labelUserLastName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelUserCountry
            // 
            labelUserCountry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            labelUserCountry.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            labelUserCountry.ForeColor = System.Drawing.Color.Gainsboro;
            labelUserCountry.Location = new System.Drawing.Point(14, 67);
            labelUserCountry.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
            labelUserCountry.Name = "labelUserCountry";
            labelUserCountry.Size = new System.Drawing.Size(215, 45);
            labelUserCountry.TabIndex = 7;
            labelUserCountry.Text = "Country";
            labelUserCountry.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelUserCity
            // 
            labelUserCity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            labelUserCity.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            labelUserCity.ForeColor = System.Drawing.Color.Gainsboro;
            labelUserCity.Location = new System.Drawing.Point(234, 67);
            labelUserCity.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
            labelUserCity.Name = "labelUserCity";
            labelUserCity.Size = new System.Drawing.Size(215, 45);
            labelUserCity.TabIndex = 8;
            labelUserCity.Text = "City";
            labelUserCity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            label1.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            label1.ForeColor = System.Drawing.Color.Gainsboro;
            label1.Location = new System.Drawing.Point(454, 67);
            label1.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(215, 45);
            label1.TabIndex = 9;
            label1.Text = "City";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelUserPhone
            // 
            labelUserPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            labelUserPhone.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            labelUserPhone.ForeColor = System.Drawing.Color.Gainsboro;
            labelUserPhone.Location = new System.Drawing.Point(14, 122);
            labelUserPhone.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
            labelUserPhone.Name = "labelUserPhone";
            labelUserPhone.Size = new System.Drawing.Size(325, 45);
            labelUserPhone.TabIndex = 10;
            labelUserPhone.Text = "Phone";
            labelUserPhone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelUserMail
            // 
            labelUserMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            labelUserMail.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            labelUserMail.ForeColor = System.Drawing.Color.Gainsboro;
            labelUserMail.Location = new System.Drawing.Point(349, 122);
            labelUserMail.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
            labelUserMail.Name = "labelUserMail";
            labelUserMail.Size = new System.Drawing.Size(320, 45);
            labelUserMail.TabIndex = 11;
            labelUserMail.Text = "Mail";
            labelUserMail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(labelUsername);
            panel1.Controls.Add(labelUserMail);
            panel1.Controls.Add(labeluserFirstName);
            panel1.Controls.Add(labelUserPhone);
            panel1.Controls.Add(labelUserLastName);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(labelUserCountry);
            panel1.Controls.Add(labelUserCity);
            panel1.Location = new System.Drawing.Point(3, 196);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(684, 182);
            panel1.TabIndex = 12;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = global::DreamCar.Properties.Resources.userGreen;
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            pictureBox1.Location = new System.Drawing.Point(484, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(200, 187);
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(93)))));
            panel2.Controls.Add(labelDreamCar);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(panel1);
            panel2.Location = new System.Drawing.Point(251, 75);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(688, 380);
            panel2.TabIndex = 14;
            // 
            // labelDreamCar
            // 
            labelDreamCar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(212)))), ((int)(((byte)(132)))));
            labelDreamCar.Font = new System.Drawing.Font("Tw Cen MT Condensed", 64F, System.Drawing.FontStyle.Bold);
            labelDreamCar.ForeColor = System.Drawing.Color.Gainsboro;
            labelDreamCar.Location = new System.Drawing.Point(13, 7);
            labelDreamCar.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
            labelDreamCar.Name = "labelDreamCar";
            labelDreamCar.Size = new System.Drawing.Size(466, 183);
            labelDreamCar.TabIndex = 12;
            labelDreamCar.Text = "DreamCar";
            labelDreamCar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MyProfile
            // 
            form.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            form.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            form.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(110)))));
            form.ClientSize = new System.Drawing.Size(1540, 567);
            form.Controls.Add(panel2);
            form.Name = "MyProfile";
            form.Text = "MyProfile";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            panel2.ResumeLayout(false);
            form.ResumeLayout(false);

        }

        public static Panel panel2;
        public static Label labelUsername;
        public static Label labeluserFirstName;
        public static Label labelUserLastName;
        public static Label labelUserCountry;
        public static Label labelUserCity;
        public static Label label1;
        public static Label labelUserPhone;
        public static Label labelUserMail;
        public static Panel panel1;
        public static PictureBox pictureBox1;
        public static Label labelDreamCar;
    }
}
