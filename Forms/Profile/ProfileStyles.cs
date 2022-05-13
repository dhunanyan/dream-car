using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DreamCar.Forms.Profile;
using DreamCar.Helpers;
using DreamCar.Properties;

namespace DreamCar.Forms.Profile
{
    public class ProfileStyles
    {

        public ProfileStyles()
        {

        }

        public static void InitializeComponent(Form form)
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profile));
            panelTitleBar = new System.Windows.Forms.Panel();
            panelMenu = new System.Windows.Forms.FlowLayoutPanel();
            buttonMyProfile = new System.Windows.Forms.Button();
            buttonMyCollection = new System.Windows.Forms.Button();
            buttonMyFavourites = new System.Windows.Forms.Button();
            labelTitle = new System.Windows.Forms.Label();
            panelMain = new System.Windows.Forms.Panel();
            panelMenu.SuspendLayout();
            panelTitleBar.SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            panelMenu.Controls.Add(buttonMyProfile);
            panelMenu.Controls.Add(buttonMyCollection);
            panelMenu.Controls.Add(buttonMyFavourites);
            panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            panelMenu.Location = new System.Drawing.Point(0, 0);
            panelMenu.Margin = new System.Windows.Forms.Padding(2);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new System.Drawing.Size(1087, 58);
            panelMenu.TabIndex = 0;
            // 
            // buttonMyProfile
            // 
            buttonMyProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            buttonMyProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            buttonMyProfile.Dock = System.Windows.Forms.DockStyle.Top;
            buttonMyProfile.FlatAppearance.BorderSize = 0;
            buttonMyProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonMyProfile.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            buttonMyProfile.ForeColor = System.Drawing.Color.Gainsboro;
            buttonMyProfile.Image = global::DreamCar.Properties.Resources.user;
            buttonMyProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonMyProfile.Location = new System.Drawing.Point(0, 174);
            buttonMyProfile.Margin = new System.Windows.Forms.Padding(0);
            buttonMyProfile.Name = "buttonMyProfile";
            buttonMyProfile.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            buttonMyProfile.Size = new System.Drawing.Size(362, 58);
            buttonMyProfile.TabIndex = 3;
            buttonMyProfile.Text = "My Profile";
            buttonMyProfile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            buttonMyProfile.UseVisualStyleBackColor = true;
            buttonMyProfile.EnabledChanged += new System.EventHandler(Profile.ButtonMyProfile_EnabledChanged);
            buttonMyProfile.Click += new System.EventHandler(Profile.ButtonMyProfile_Click);
            buttonMyProfile.Paint += new System.Windows.Forms.PaintEventHandler(ButtonProfile_Paint);
            // 
            // buttonMyCollection
            // 
            buttonMyCollection.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            buttonMyCollection.Cursor = System.Windows.Forms.Cursors.Hand;
            buttonMyCollection.Dock = System.Windows.Forms.DockStyle.Top;
            buttonMyCollection.FlatAppearance.BorderSize = 0;
            buttonMyCollection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonMyCollection.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            buttonMyCollection.ForeColor = System.Drawing.Color.Gainsboro;
            buttonMyCollection.Image = global::DreamCar.Properties.Resources.myCollection;
            buttonMyCollection.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonMyCollection.Location = new System.Drawing.Point(0, 116);
            buttonMyCollection.Margin = new System.Windows.Forms.Padding(0);
            buttonMyCollection.Name = "buttonMyCollection";
            buttonMyCollection.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            buttonMyCollection.Size = new System.Drawing.Size(362, 58);
            buttonMyCollection.TabIndex = 2;
            buttonMyCollection.Text = "My Collection";
            buttonMyCollection.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            buttonMyCollection.UseVisualStyleBackColor = true;
            buttonMyCollection.EnabledChanged += new System.EventHandler(Profile.ButtonMyCollection_EnabledChanged);
            buttonMyCollection.Click += new System.EventHandler(Profile.ButtonMyCollection_Click);
            buttonMyCollection.Paint += new System.Windows.Forms.PaintEventHandler(buttonMyCollection_Paint);
            // 
            // buttonMyFavourites
            // 
            buttonMyFavourites.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            buttonMyFavourites.Cursor = System.Windows.Forms.Cursors.Hand;
            buttonMyFavourites.Dock = System.Windows.Forms.DockStyle.Top;
            buttonMyFavourites.FlatAppearance.BorderSize = 0;
            buttonMyFavourites.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonMyFavourites.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            buttonMyFavourites.ForeColor = System.Drawing.Color.Gainsboro;
            buttonMyFavourites.Image = Resources.myFavourites;
            buttonMyFavourites.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonMyFavourites.Location = new System.Drawing.Point(0, 58);
            buttonMyFavourites.Margin = new System.Windows.Forms.Padding(0);
            buttonMyFavourites.Name = "buttonMyFavourites";
            buttonMyFavourites.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            buttonMyFavourites.Size = new System.Drawing.Size(362, 58);
            buttonMyFavourites.TabIndex = 1;
            buttonMyFavourites.Text = "My Favourites";
            buttonMyFavourites.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            buttonMyFavourites.UseVisualStyleBackColor = true;
            buttonMyFavourites.EnabledChanged += new System.EventHandler(Profile.ButtonMyFavourites_EnabledChanged);
            buttonMyFavourites.Click += new System.EventHandler(Profile.ButtonMyFavourites_Click);
            buttonMyFavourites.Paint += new System.Windows.Forms.PaintEventHandler(buttonFavourites_Paint);
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(212)))), ((int)(((byte)(132)))));
            panelTitleBar.Controls.Add(labelTitle);
            panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            panelTitleBar.Location = new System.Drawing.Point(180, 0);
            panelTitleBar.Margin = new System.Windows.Forms.Padding(0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new System.Drawing.Size(1087, 58);
            panelTitleBar.TabIndex = 1;
            // 
            // labelTitle
            // 
            labelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            labelTitle.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(93)))));
            labelTitle.Location = new System.Drawing.Point(0, 0);
            labelTitle.Margin = new System.Windows.Forms.Padding(0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new System.Drawing.Size(1087, 58);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "My Profile";
            labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelMain
            // 
            panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(93)))));
            panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            panelMain.Location = new System.Drawing.Point(180, 58);
            panelMain.Margin = new System.Windows.Forms.Padding(0);
            panelMain.MinimumSize = new System.Drawing.Size(1087, 750);
            panelMain.Name = "panelMain";
            panelMain.Size = new System.Drawing.Size(1087, 750);
            panelMain.TabIndex = 2;
            // 
            // Profile
            // 
            form.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            form.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            form.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(93)))));
            form.ClientSize = new System.Drawing.Size(1267, 741);
            form.Controls.Add(panelTitleBar);
            form.Controls.Add(panelMain);
            form.Controls.Add(panelMenu);
            form.Margin = new System.Windows.Forms.Padding(2);
            form.MinimumSize = new System.Drawing.Size(1087, 750);
            form.Name = "Profile";
            form.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            form.Text = "DreamCar";
            form.ResumeLayout(false);

            panelMenu.ResumeLayout(false);
            panelTitleBar.ResumeLayout(false);
            panelMain.ResumeLayout(false);
        }

        public static void SetButtonColors()
        {
            buttonMyFavourites.BackColor = ThemeColor.ChangeColorBrightness(ColorTranslator.FromHtml("#33334c"), 0.5);
            buttonMyFavourites.ForeColor = Color.Gainsboro;
            buttonMyFavourites.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;

            buttonMyProfile.BackColor = ThemeColor.ChangeColorBrightness(ColorTranslator.FromHtml("#33334c"), 0.5);
            buttonMyProfile.ForeColor = Color.Gainsboro;
            buttonMyProfile.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;

            buttonMyCollection.BackColor = ThemeColor.ChangeColorBrightness(ColorTranslator.FromHtml("#33334c"), 0.5);
            buttonMyCollection.ForeColor = Color.Gainsboro;
            buttonMyCollection.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
        }

        public static void buttonFavourites_Paint(object sender, PaintEventArgs e)
        {
            Button currentButton = (Button)sender;
            buttonMyFavourites.ForeColor = Color.Gainsboro;
            SolidBrush drawBrush = new SolidBrush(currentButton.ForeColor);
            StringFormat sf = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            buttonMyFavourites.Text = string.Empty;
            e.Graphics.DrawString("My Favourites", currentButton.Font, drawBrush, e.ClipRectangle, sf);
            drawBrush.Dispose();
            sf.Dispose();
        }

        public static void buttonMyCollection_Paint(object sender, PaintEventArgs e)
        {
            Button currentButton = (Button)sender;
            buttonMyCollection.ForeColor = Color.Gainsboro;
            SolidBrush drawBrush = new SolidBrush(currentButton.ForeColor);
            StringFormat sf = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            buttonMyCollection.Text = string.Empty;
            e.Graphics.DrawString("My Collection", currentButton.Font, drawBrush, e.ClipRectangle, sf);
            drawBrush.Dispose();
            sf.Dispose();
        }

        public static void ButtonProfile_Paint(object sender, PaintEventArgs e)
        {
            Button currentButton = (Button)sender;
            buttonMyProfile.ForeColor = Color.Gainsboro;
            SolidBrush drawBrush = new SolidBrush(currentButton.ForeColor);
            StringFormat sf = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            buttonMyProfile.Text = string.Empty;
            e.Graphics.DrawString("My Profile", currentButton.Font, drawBrush, e.ClipRectangle, sf);
            drawBrush.Dispose();
            sf.Dispose();
        }

        public static Panel panelMain;
        public static Panel panelTitleBar;
        public static FlowLayoutPanel panelMenu;


        public static Label labelTitle;

        public static Button buttonMyFavourites;
        public static Button buttonMyProfile;
        public static Button buttonMyCollection;
    }
}