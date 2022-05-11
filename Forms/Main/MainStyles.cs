using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DreamCar.Forms.Main;
using DreamCar.Helpers;
using DreamCar.Properties;

namespace DreamCar.Forms.Main
{
    public class MainStyles
    {

        public MainStyles()
        {

        }

        public static void InitializeComponent(Form form)
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            panelMenu = new System.Windows.Forms.Panel();
            buttonProfile = new System.Windows.Forms.Button();
            buttonPublish = new System.Windows.Forms.Button();
            buttonCollection = new System.Windows.Forms.Button();
            panelLogo = new System.Windows.Forms.FlowLayoutPanel();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            labelDreamCar = new System.Windows.Forms.Label();
            panelTitleBar = new System.Windows.Forms.Panel();
            buttonTimes = new System.Windows.Forms.Button();
            labelTitle = new System.Windows.Forms.Label();
            panelMain = new System.Windows.Forms.Panel();
            SignUp = new System.Windows.Forms.FlowLayoutPanel();
            labelSignup = new System.Windows.Forms.Label();
            flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            labelFirstName = new System.Windows.Forms.Label();
            labelLastName = new System.Windows.Forms.Label();
            labelUsername = new System.Windows.Forms.Label();
            textBoxFirstName = new System.Windows.Forms.TextBox();
            textBoxLastName = new System.Windows.Forms.TextBox();
            textBoxUsername = new System.Windows.Forms.TextBox();
            labelCountry = new System.Windows.Forms.Label();
            labelCity = new System.Windows.Forms.Label();
            labelAddress = new System.Windows.Forms.Label();
            textBoxCountry = new System.Windows.Forms.TextBox();
            textBoxCity = new System.Windows.Forms.TextBox();
            textBoxAddress = new System.Windows.Forms.TextBox();
            labelPhone = new System.Windows.Forms.Label();
            labelEmail = new System.Windows.Forms.Label();
            textBoxPhone = new System.Windows.Forms.TextBox();
            textBoxEmail = new System.Windows.Forms.TextBox();
            labelPassword = new System.Windows.Forms.Label();
            labelConfirmPassword = new System.Windows.Forms.Label();
            textBoxPassword = new System.Windows.Forms.TextBox();
            textBoxConfirmPassword = new System.Windows.Forms.TextBox();
            checkBoxShowPassword = new System.Windows.Forms.CheckBox();
            buttonSignup = new System.Windows.Forms.Button();
            buttonClear = new System.Windows.Forms.Button();
            labelHaveAcc = new System.Windows.Forms.Label();
            labelChangeToSignin = new System.Windows.Forms.Label();
            flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            label1 = new System.Windows.Forms.Label();
            SignIn = new System.Windows.Forms.FlowLayoutPanel();
            labelSignin = new System.Windows.Forms.Label();
            flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            labelUsernameSignin = new System.Windows.Forms.Label();
            textBoxUsernameSignin = new System.Windows.Forms.TextBox();
            labelPasswordSignin = new System.Windows.Forms.Label();
            textBoxPasswordSignin = new System.Windows.Forms.TextBox();
            checkBoxShowPasswordSignin = new System.Windows.Forms.CheckBox();
            buttonSignin = new System.Windows.Forms.Button();
            buttonClearSignin = new System.Windows.Forms.Button();
            labelDontHaveAcc = new System.Windows.Forms.Label();
            labelChangeToSignup = new System.Windows.Forms.Label();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            panelTitleBar.SuspendLayout();
            SignUp.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(pictureBox2)).BeginInit();
            SignIn.SuspendLayout();
            flowLayoutPanel5.SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            panelMenu.Controls.Add(buttonProfile);
            panelMenu.Controls.Add(buttonPublish);
            panelMenu.Controls.Add(buttonCollection);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            panelMenu.Location = new System.Drawing.Point(0, 0);
            panelMenu.Margin = new System.Windows.Forms.Padding(2);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new System.Drawing.Size(180, 741);
            panelMenu.TabIndex = 0;
            // 
            // buttonProfile
            // 
            buttonProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            buttonProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            buttonProfile.Dock = System.Windows.Forms.DockStyle.Top;
            buttonProfile.FlatAppearance.BorderSize = 0;
            buttonProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonProfile.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            buttonProfile.ForeColor = System.Drawing.Color.Gainsboro;
            buttonProfile.Image = global::DreamCar.Properties.Resources.user;
            buttonProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonProfile.Location = new System.Drawing.Point(0, 174);
            buttonProfile.Margin = new System.Windows.Forms.Padding(2);
            buttonProfile.Name = "buttonProfile";
            buttonProfile.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            buttonProfile.Size = new System.Drawing.Size(180, 58);
            buttonProfile.TabIndex = 3;
            buttonProfile.Text = "  Profile";
            buttonProfile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            buttonProfile.UseVisualStyleBackColor = true;
            buttonProfile.EnabledChanged += new System.EventHandler(Main.ButtonProfile_EnabledChanged);
            buttonProfile.Click += new System.EventHandler(Main.ButtonProfile_Click);
            buttonProfile.Paint += new System.Windows.Forms.PaintEventHandler(ButtonProfile_Paint);
            // 
            // buttonPublish
            // 
            buttonPublish.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            buttonPublish.Cursor = System.Windows.Forms.Cursors.Hand;
            buttonPublish.Dock = System.Windows.Forms.DockStyle.Top;
            buttonPublish.FlatAppearance.BorderSize = 0;
            buttonPublish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonPublish.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            buttonPublish.ForeColor = System.Drawing.Color.Gainsboro;
            buttonPublish.Image = global::DreamCar.Properties.Resources.upload;
            buttonPublish.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonPublish.Location = new System.Drawing.Point(0, 116);
            buttonPublish.Margin = new System.Windows.Forms.Padding(2);
            buttonPublish.Name = "buttonPublish";
            buttonPublish.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            buttonPublish.Size = new System.Drawing.Size(180, 58);
            buttonPublish.TabIndex = 2;
            buttonPublish.Text = "  Publish";
            buttonPublish.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            buttonPublish.UseVisualStyleBackColor = true;
            buttonPublish.EnabledChanged += new System.EventHandler(Main.ButtonPublish_EnabledChanged);
            buttonPublish.Click += new System.EventHandler(Main.ButtonPublish_Click);
            buttonPublish.Paint += new System.Windows.Forms.PaintEventHandler(ButtonPublish_Paint);
            // 
            // buttonCollection
            // 
            buttonCollection.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            buttonCollection.Cursor = System.Windows.Forms.Cursors.Hand;
            buttonCollection.Dock = System.Windows.Forms.DockStyle.Top;
            buttonCollection.FlatAppearance.BorderSize = 0;
            buttonCollection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonCollection.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            buttonCollection.ForeColor = System.Drawing.Color.Gainsboro;
            buttonCollection.Image = Resources.search;
            buttonCollection.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonCollection.Location = new System.Drawing.Point(0, 58);
            buttonCollection.Margin = new System.Windows.Forms.Padding(2);
            buttonCollection.Name = "buttonCollection";
            buttonCollection.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            buttonCollection.Size = new System.Drawing.Size(180, 58);
            buttonCollection.TabIndex = 1;
            buttonCollection.Text = "  Collection";
            buttonCollection.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            buttonCollection.UseVisualStyleBackColor = true;
            buttonCollection.EnabledChanged += new System.EventHandler(Main.ButtonCollection_EnabledChanged);
            buttonCollection.Click += new System.EventHandler(Main.ButtonCollection_Click);
            buttonCollection.Paint += new System.Windows.Forms.PaintEventHandler(ButtonCollection_Paint);
            // 
            // panelLogo
            // 
            panelLogo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(184)))), ((int)(((byte)(119)))));
            panelLogo.Controls.Add(pictureBox1);
            panelLogo.Controls.Add(labelDreamCar);
            panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            panelLogo.Location = new System.Drawing.Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new System.Drawing.Size(180, 58);
            panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(184)))), ((int)(((byte)(119)))));
            pictureBox1.BackgroundImage = global::DreamCar.Properties.Resources.logoGreen;
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            pictureBox1.ErrorImage = null;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new System.Drawing.Point(10, 12);
            pictureBox1.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Padding = new System.Windows.Forms.Padding(7, 11, 7, 11);
            pictureBox1.Size = new System.Drawing.Size(32, 32);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // labelDreamCar
            // 
            labelDreamCar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(184)))), ((int)(((byte)(119)))));
            labelDreamCar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            labelDreamCar.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            labelDreamCar.ForeColor = System.Drawing.Color.Gainsboro;
            labelDreamCar.Location = new System.Drawing.Point(44, 0);
            labelDreamCar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            labelDreamCar.Name = "labelDreamCar";
            labelDreamCar.Size = new System.Drawing.Size(115, 56);
            labelDreamCar.TabIndex = 0;
            labelDreamCar.Text = " DreamCar";
            labelDreamCar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(212)))), ((int)(((byte)(132)))));
            panelTitleBar.Controls.Add(buttonTimes);
            panelTitleBar.Controls.Add(labelTitle);
            panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            panelTitleBar.Location = new System.Drawing.Point(180, 0);
            panelTitleBar.Margin = new System.Windows.Forms.Padding(0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new System.Drawing.Size(1087, 58);
            panelTitleBar.TabIndex = 1;
            // 
            // buttonTimes
            // 
            buttonTimes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonTimes.BackgroundImage")));
            buttonTimes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            buttonTimes.Cursor = System.Windows.Forms.Cursors.Hand;
            buttonTimes.Dock = System.Windows.Forms.DockStyle.Left;
            buttonTimes.FlatAppearance.BorderSize = 0;
            buttonTimes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonTimes.Location = new System.Drawing.Point(0, 0);
            buttonTimes.Margin = new System.Windows.Forms.Padding(2);
            buttonTimes.Name = "buttonTimes";
            buttonTimes.Size = new System.Drawing.Size(60, 58);
            buttonTimes.TabIndex = 1;
            buttonTimes.UseVisualStyleBackColor = true;
            buttonTimes.Click += new System.EventHandler(Main.ButtonTimes_Click);
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
            labelTitle.Text = "HOME";
            labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelMain
            // 
            panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(93)))));
            panelMain.Controls.Add(SignUp);
            panelMain.Controls.Add(flowLayoutPanel1);
            panelMain.Controls.Add(SignIn);
            panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            panelMain.Location = new System.Drawing.Point(180, 58);
            panelMain.Margin = new System.Windows.Forms.Padding(0);
            panelMain.MinimumSize = new System.Drawing.Size(1087, 750);
            panelMain.Name = "panelMain";
            panelMain.Size = new System.Drawing.Size(1087, 750);
            panelMain.TabIndex = 2;
            // 
            // SignUp
            // 
            SignUp.Anchor = System.Windows.Forms.AnchorStyles.None;
            SignUp.Controls.Add(labelSignup);
            SignUp.Controls.Add(flowLayoutPanel2);
            SignUp.Location = new System.Drawing.Point(48, 141);
            SignUp.Margin = new System.Windows.Forms.Padding(2);
            SignUp.Name = "SignUp";
            SignUp.Size = new System.Drawing.Size(997, 510);
            SignUp.TabIndex = 16;
            // 
            // labelSignup
            // 
            labelSignup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(184)))), ((int)(((byte)(119)))));
            labelSignup.Font = new System.Drawing.Font("Tw Cen MT Condensed", 24F, System.Drawing.FontStyle.Bold);
            labelSignup.ForeColor = System.Drawing.Color.Gainsboro;
            labelSignup.Location = new System.Drawing.Point(0, 0);
            labelSignup.Margin = new System.Windows.Forms.Padding(0);
            labelSignup.Name = "labelSignup";
            labelSignup.Size = new System.Drawing.Size(997, 46);
            labelSignup.TabIndex = 3;
            labelSignup.Text = "SIGN UP";
            labelSignup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(110)))));
            flowLayoutPanel2.Controls.Add(labelFirstName);
            flowLayoutPanel2.Controls.Add(labelLastName);
            flowLayoutPanel2.Controls.Add(labelUsername);
            flowLayoutPanel2.Controls.Add(textBoxFirstName);
            flowLayoutPanel2.Controls.Add(textBoxLastName);
            flowLayoutPanel2.Controls.Add(textBoxUsername);
            flowLayoutPanel2.Controls.Add(labelCountry);
            flowLayoutPanel2.Controls.Add(labelCity);
            flowLayoutPanel2.Controls.Add(labelAddress);
            flowLayoutPanel2.Controls.Add(textBoxCountry);
            flowLayoutPanel2.Controls.Add(textBoxCity);
            flowLayoutPanel2.Controls.Add(textBoxAddress);
            flowLayoutPanel2.Controls.Add(labelPhone);
            flowLayoutPanel2.Controls.Add(labelEmail);
            flowLayoutPanel2.Controls.Add(textBoxPhone);
            flowLayoutPanel2.Controls.Add(textBoxEmail);
            flowLayoutPanel2.Controls.Add(labelPassword);
            flowLayoutPanel2.Controls.Add(labelConfirmPassword);
            flowLayoutPanel2.Controls.Add(textBoxPassword);
            flowLayoutPanel2.Controls.Add(textBoxConfirmPassword);
            flowLayoutPanel2.Controls.Add(checkBoxShowPassword);
            flowLayoutPanel2.Controls.Add(buttonSignup);
            flowLayoutPanel2.Controls.Add(buttonClear);
            flowLayoutPanel2.Controls.Add(labelHaveAcc);
            flowLayoutPanel2.Controls.Add(labelChangeToSignin);
            flowLayoutPanel2.Location = new System.Drawing.Point(0, 46);
            flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(14, 13, 14, 13);
            flowLayoutPanel2.Size = new System.Drawing.Size(997, 464);
            flowLayoutPanel2.TabIndex = 15;
            // 
            // labelFirstName
            // 
            labelFirstName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            labelFirstName.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            labelFirstName.ForeColor = System.Drawing.Color.Gainsboro;
            labelFirstName.Location = new System.Drawing.Point(14, 13);
            labelFirstName.Margin = new System.Windows.Forms.Padding(0, 0, 13, 0);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new System.Drawing.Size(314, 28);
            labelFirstName.TabIndex = 22;
            labelFirstName.Text = "First Name";
            // 
            // labelLastName
            // 
            labelLastName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            labelLastName.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            labelLastName.ForeColor = System.Drawing.Color.Gainsboro;
            labelLastName.Location = new System.Drawing.Point(341, 13);
            labelLastName.Margin = new System.Windows.Forms.Padding(0, 0, 13, 0);
            labelLastName.Name = "labelLastName";
            labelLastName.Size = new System.Drawing.Size(314, 28);
            labelLastName.TabIndex = 23;
            labelLastName.Text = "Last Name";
            // 
            // labelUsername
            // 
            labelUsername.Anchor = System.Windows.Forms.AnchorStyles.Top;
            labelUsername.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            labelUsername.ForeColor = System.Drawing.Color.Gainsboro;
            labelUsername.Location = new System.Drawing.Point(668, 13);
            labelUsername.Margin = new System.Windows.Forms.Padding(0);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new System.Drawing.Size(314, 28);
            labelUsername.TabIndex = 24;
            labelUsername.Text = "Username";
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Anchor = System.Windows.Forms.AnchorStyles.None;
            textBoxFirstName.BackColor = System.Drawing.Color.Gainsboro;
            textBoxFirstName.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            textBoxFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(93)))));
            textBoxFirstName.Location = new System.Drawing.Point(14, 41);
            textBoxFirstName.Margin = new System.Windows.Forms.Padding(0, 0, 13, 13);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new System.Drawing.Size(314, 33);
            textBoxFirstName.TabIndex = 1;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            textBoxLastName.BackColor = System.Drawing.Color.Gainsboro;
            textBoxLastName.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            textBoxLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(93)))));
            textBoxLastName.Location = new System.Drawing.Point(341, 41);
            textBoxLastName.Margin = new System.Windows.Forms.Padding(0, 0, 13, 13);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new System.Drawing.Size(314, 33);
            textBoxLastName.TabIndex = 2;
            // 
            // textBoxUsername
            // 
            textBoxUsername.BackColor = System.Drawing.Color.Gainsboro;
            textBoxUsername.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            textBoxUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(93)))));
            textBoxUsername.Location = new System.Drawing.Point(668, 41);
            textBoxUsername.Margin = new System.Windows.Forms.Padding(0, 0, 0, 13);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new System.Drawing.Size(314, 33);
            textBoxUsername.TabIndex = 3;
            // 
            // labelCountry
            // 
            labelCountry.Anchor = System.Windows.Forms.AnchorStyles.Top;
            labelCountry.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            labelCountry.ForeColor = System.Drawing.Color.Gainsboro;
            labelCountry.Location = new System.Drawing.Point(14, 87);
            labelCountry.Margin = new System.Windows.Forms.Padding(0, 0, 13, 0);
            labelCountry.Name = "labelCountry";
            labelCountry.Size = new System.Drawing.Size(314, 28);
            labelCountry.TabIndex = 25;
            labelCountry.Text = "Country";
            // 
            // labelCity
            // 
            labelCity.Anchor = System.Windows.Forms.AnchorStyles.Top;
            labelCity.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            labelCity.ForeColor = System.Drawing.Color.Gainsboro;
            labelCity.Location = new System.Drawing.Point(341, 87);
            labelCity.Margin = new System.Windows.Forms.Padding(0, 0, 13, 0);
            labelCity.Name = "labelCity";
            labelCity.Size = new System.Drawing.Size(314, 28);
            labelCity.TabIndex = 26;
            labelCity.Text = "City";
            // 
            // labelAddress
            // 
            labelAddress.Anchor = System.Windows.Forms.AnchorStyles.Top;
            labelAddress.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            labelAddress.ForeColor = System.Drawing.Color.Gainsboro;
            labelAddress.Location = new System.Drawing.Point(668, 87);
            labelAddress.Margin = new System.Windows.Forms.Padding(0);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new System.Drawing.Size(314, 28);
            labelAddress.TabIndex = 27;
            labelAddress.Text = "Address";
            // 
            // textBoxCountry
            // 
            textBoxCountry.Anchor = System.Windows.Forms.AnchorStyles.None;
            textBoxCountry.BackColor = System.Drawing.Color.Gainsboro;
            textBoxCountry.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            textBoxCountry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(93)))));
            textBoxCountry.Location = new System.Drawing.Point(14, 115);
            textBoxCountry.Margin = new System.Windows.Forms.Padding(0, 0, 13, 13);
            textBoxCountry.Name = "textBoxCountry";
            textBoxCountry.Size = new System.Drawing.Size(314, 33);
            textBoxCountry.TabIndex = 4;
            // 
            // textBoxCity
            // 
            textBoxCity.Anchor = System.Windows.Forms.AnchorStyles.None;
            textBoxCity.BackColor = System.Drawing.Color.Gainsboro;
            textBoxCity.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            textBoxCity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(93)))));
            textBoxCity.Location = new System.Drawing.Point(341, 115);
            textBoxCity.Margin = new System.Windows.Forms.Padding(0, 0, 13, 13);
            textBoxCity.Name = "textBoxCity";
            textBoxCity.Size = new System.Drawing.Size(314, 33);
            textBoxCity.TabIndex = 5;
            // 
            // textBoxAddress
            // 
            textBoxAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            textBoxAddress.BackColor = System.Drawing.Color.Gainsboro;
            textBoxAddress.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            textBoxAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(93)))));
            textBoxAddress.Location = new System.Drawing.Point(668, 115);
            textBoxAddress.Margin = new System.Windows.Forms.Padding(0, 0, 0, 13);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new System.Drawing.Size(314, 33);
            textBoxAddress.TabIndex = 6;
            // 
            // labelPhone
            // 
            labelPhone.Anchor = System.Windows.Forms.AnchorStyles.Top;
            labelPhone.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            labelPhone.ForeColor = System.Drawing.Color.Gainsboro;
            labelPhone.Location = new System.Drawing.Point(14, 161);
            labelPhone.Margin = new System.Windows.Forms.Padding(0, 0, 13, 0);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new System.Drawing.Size(478, 28);
            labelPhone.TabIndex = 28;
            labelPhone.Text = "Phone";
            // 
            // labelEmail
            // 
            labelEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            labelEmail.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            labelEmail.ForeColor = System.Drawing.Color.Gainsboro;
            labelEmail.Location = new System.Drawing.Point(505, 161);
            labelEmail.Margin = new System.Windows.Forms.Padding(0);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new System.Drawing.Size(478, 28);
            labelEmail.TabIndex = 29;
            labelEmail.Text = "Email";
            // 
            // textBoxPhone
            // 
            textBoxPhone.Anchor = System.Windows.Forms.AnchorStyles.None;
            textBoxPhone.BackColor = System.Drawing.Color.Gainsboro;
            textBoxPhone.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            textBoxPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(93)))));
            textBoxPhone.Location = new System.Drawing.Point(14, 189);
            textBoxPhone.Margin = new System.Windows.Forms.Padding(0, 0, 13, 13);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new System.Drawing.Size(478, 33);
            textBoxPhone.TabIndex = 7;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            textBoxEmail.BackColor = System.Drawing.Color.Gainsboro;
            textBoxEmail.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            textBoxEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(93)))));
            textBoxEmail.Location = new System.Drawing.Point(505, 189);
            textBoxEmail.Margin = new System.Windows.Forms.Padding(0, 0, 0, 13);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new System.Drawing.Size(478, 33);
            textBoxEmail.TabIndex = 8;
            // 
            // labelPassword
            // 
            labelPassword.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            labelPassword.ForeColor = System.Drawing.Color.Gainsboro;
            labelPassword.Location = new System.Drawing.Point(14, 235);
            labelPassword.Margin = new System.Windows.Forms.Padding(0, 0, 13, 0);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new System.Drawing.Size(478, 28);
            labelPassword.TabIndex = 5;
            labelPassword.Text = "Password";
            // 
            // labelConfirmPassword
            // 
            labelConfirmPassword.AutoSize = true;
            labelConfirmPassword.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            labelConfirmPassword.ForeColor = System.Drawing.Color.Gainsboro;
            labelConfirmPassword.Location = new System.Drawing.Point(505, 235);
            labelConfirmPassword.Margin = new System.Windows.Forms.Padding(0);
            labelConfirmPassword.Name = "labelConfirmPassword";
            labelConfirmPassword.Size = new System.Drawing.Size(166, 28);
            labelConfirmPassword.TabIndex = 8;
            labelConfirmPassword.Text = "Confirm Password";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            textBoxPassword.BackColor = System.Drawing.Color.Gainsboro;
            textBoxPassword.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            textBoxPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(93)))));
            textBoxPassword.Location = new System.Drawing.Point(14, 263);
            textBoxPassword.Margin = new System.Windows.Forms.Padding(0, 0, 13, 13);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '●';
            textBoxPassword.Size = new System.Drawing.Size(478, 33);
            textBoxPassword.TabIndex = 9;
            // 
            // textBoxConfirmPassword
            // 
            textBoxConfirmPassword.BackColor = System.Drawing.Color.Gainsboro;
            textBoxConfirmPassword.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            textBoxConfirmPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(93)))));
            textBoxConfirmPassword.Location = new System.Drawing.Point(505, 263);
            textBoxConfirmPassword.Margin = new System.Windows.Forms.Padding(0, 0, 0, 13);
            textBoxConfirmPassword.Name = "textBoxConfirmPassword";
            textBoxConfirmPassword.PasswordChar = '●';
            textBoxConfirmPassword.Size = new System.Drawing.Size(478, 33);
            textBoxConfirmPassword.TabIndex = 10;
            // 
            // checkBoxShowPassword
            // 
            checkBoxShowPassword.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            checkBoxShowPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            checkBoxShowPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            checkBoxShowPassword.Font = new System.Drawing.Font("Tw Cen MT Condensed", 12F, System.Drawing.FontStyle.Bold);
            checkBoxShowPassword.ForeColor = System.Drawing.Color.Gainsboro;
            checkBoxShowPassword.Location = new System.Drawing.Point(14, 309);
            checkBoxShowPassword.Margin = new System.Windows.Forms.Padding(0, 0, 0, 6);
            checkBoxShowPassword.Name = "checkBoxShowPassword";
            checkBoxShowPassword.Size = new System.Drawing.Size(969, 21);
            checkBoxShowPassword.TabIndex = 11;
            checkBoxShowPassword.Text = "Show Password";
            checkBoxShowPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            checkBoxShowPassword.UseVisualStyleBackColor = true;
            checkBoxShowPassword.CheckedChanged += new System.EventHandler(Main.CheckBoxShowPassword_CheckedChanged);
            // 
            // buttonSignup
            // 
            buttonSignup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(212)))), ((int)(((byte)(132)))));
            buttonSignup.Cursor = System.Windows.Forms.Cursors.Hand;
            buttonSignup.FlatAppearance.BorderSize = 0;
            buttonSignup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonSignup.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            buttonSignup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(93)))));
            buttonSignup.Location = new System.Drawing.Point(14, 336);
            buttonSignup.Margin = new System.Windows.Forms.Padding(0);
            buttonSignup.Name = "buttonSignup";
            buttonSignup.Size = new System.Drawing.Size(969, 39);
            buttonSignup.TabIndex = 12;
            buttonSignup.Text = "Sign up";
            buttonSignup.UseVisualStyleBackColor = false;
            buttonSignup.Click += new System.EventHandler(Main.ButtonSignup_Click);
            // 
            // buttonClear
            // 
            buttonClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(110)))));
            buttonClear.Cursor = System.Windows.Forms.Cursors.Hand;
            buttonClear.FlatAppearance.BorderSize = 3;
            buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonClear.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            buttonClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(212)))), ((int)(((byte)(132)))));
            buttonClear.Location = new System.Drawing.Point(14, 381);
            buttonClear.Margin = new System.Windows.Forms.Padding(0, 6, 0, 6);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new System.Drawing.Size(969, 39);
            buttonClear.TabIndex = 13;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = false;
            buttonClear.Click += new System.EventHandler(Main.ButtonClear_Click);
            // 
            // labelHaveAcc
            // 
            labelHaveAcc.Font = new System.Drawing.Font("Tw Cen MT Condensed", 12F, System.Drawing.FontStyle.Bold);
            labelHaveAcc.ForeColor = System.Drawing.Color.Gainsboro;
            labelHaveAcc.Location = new System.Drawing.Point(14, 426);
            labelHaveAcc.Margin = new System.Windows.Forms.Padding(0);
            labelHaveAcc.Name = "labelHaveAcc";
            labelHaveAcc.Size = new System.Drawing.Size(851, 38);
            labelHaveAcc.TabIndex = 13;
            labelHaveAcc.Text = "Already have an account?";
            labelHaveAcc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelChangeToSignin
            // 
            labelChangeToSignin.Cursor = System.Windows.Forms.Cursors.Hand;
            labelChangeToSignin.Font = new System.Drawing.Font("Tw Cen MT Condensed", 14F, System.Drawing.FontStyle.Bold);
            labelChangeToSignin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(212)))), ((int)(((byte)(132)))));
            labelChangeToSignin.Location = new System.Drawing.Point(865, 426);
            labelChangeToSignin.Margin = new System.Windows.Forms.Padding(0);
            labelChangeToSignin.Name = "labelChangeToSignin";
            labelChangeToSignin.Size = new System.Drawing.Size(117, 38);
            labelChangeToSignin.TabIndex = 14;
            labelChangeToSignin.Text = "Back to SIGN IN";
            labelChangeToSignin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            labelChangeToSignin.Click += new System.EventHandler(Main.LabelChangeToSignin_Click);
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            flowLayoutPanel1.Controls.Add(pictureBox2);
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Location = new System.Drawing.Point(324, 21);
            flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new System.Drawing.Size(471, 95);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = global::DreamCar.Properties.Resources.logoGreen;
            pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            pictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            pictureBox2.Location = new System.Drawing.Point(0, 0);
            pictureBox2.Margin = new System.Windows.Forms.Padding(0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(95, 95);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.Font = new System.Drawing.Font("Tw Cen MT Condensed", 66F, System.Drawing.FontStyle.Bold);
            label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(212)))), ((int)(((byte)(132)))));
            label1.Location = new System.Drawing.Point(95, 0);
            label1.Margin = new System.Windows.Forms.Padding(0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(376, 95);
            label1.TabIndex = 1;
            label1.Text = "DreamCar";
            label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SignIn
            // 
            SignIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            SignIn.Controls.Add(labelSignin);
            SignIn.Controls.Add(flowLayoutPanel5);
            SignIn.Location = new System.Drawing.Point(374, 178);
            SignIn.Margin = new System.Windows.Forms.Padding(2);
            SignIn.Name = "SignIn";
            SignIn.Size = new System.Drawing.Size(300, 355);
            SignIn.TabIndex = 17;
            SignIn.Visible = false;
            // 
            // labelSignin
            // 
            labelSignin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(184)))), ((int)(((byte)(119)))));
            labelSignin.Font = new System.Drawing.Font("Tw Cen MT Condensed", 24F, System.Drawing.FontStyle.Bold);
            labelSignin.ForeColor = System.Drawing.Color.Gainsboro;
            labelSignin.Location = new System.Drawing.Point(0, 0);
            labelSignin.Margin = new System.Windows.Forms.Padding(0);
            labelSignin.Name = "labelSignin";
            labelSignin.Size = new System.Drawing.Size(300, 46);
            labelSignin.TabIndex = 3;
            labelSignin.Text = "SIGN IN";
            labelSignin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel5
            // 
            flowLayoutPanel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(110)))));
            flowLayoutPanel5.Controls.Add(labelUsernameSignin);
            flowLayoutPanel5.Controls.Add(textBoxUsernameSignin);
            flowLayoutPanel5.Controls.Add(labelPasswordSignin);
            flowLayoutPanel5.Controls.Add(textBoxPasswordSignin);
            flowLayoutPanel5.Controls.Add(checkBoxShowPasswordSignin);
            flowLayoutPanel5.Controls.Add(buttonSignin);
            flowLayoutPanel5.Controls.Add(buttonClearSignin);
            flowLayoutPanel5.Controls.Add(labelDontHaveAcc);
            flowLayoutPanel5.Controls.Add(labelChangeToSignup);
            flowLayoutPanel5.Location = new System.Drawing.Point(0, 46);
            flowLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            flowLayoutPanel5.Name = "flowLayoutPanel5";
            flowLayoutPanel5.Padding = new System.Windows.Forms.Padding(14, 13, 14, 13);
            flowLayoutPanel5.Size = new System.Drawing.Size(300, 310);
            flowLayoutPanel5.TabIndex = 15;
            // 
            // labelUsernameSignin
            // 
            labelUsernameSignin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            labelUsernameSignin.AutoSize = true;
            labelUsernameSignin.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            labelUsernameSignin.ForeColor = System.Drawing.Color.Gainsboro;
            labelUsernameSignin.Location = new System.Drawing.Point(14, 13);
            labelUsernameSignin.Margin = new System.Windows.Forms.Padding(0);
            labelUsernameSignin.Name = "labelUsernameSignin";
            labelUsernameSignin.Size = new System.Drawing.Size(97, 28);
            labelUsernameSignin.TabIndex = 4;
            labelUsernameSignin.Text = "Username";
            // 
            // textBoxUsernameSignin
            // 
            textBoxUsernameSignin.BackColor = System.Drawing.Color.Gainsboro;
            textBoxUsernameSignin.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            textBoxUsernameSignin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(93)))));
            textBoxUsernameSignin.Location = new System.Drawing.Point(14, 41);
            textBoxUsernameSignin.Margin = new System.Windows.Forms.Padding(0, 0, 0, 13);
            textBoxUsernameSignin.Name = "textBoxUsernameSignin";
            textBoxUsernameSignin.Size = new System.Drawing.Size(275, 33);
            textBoxUsernameSignin.TabIndex = 6;
            // 
            // labelPasswordSignin
            // 
            labelPasswordSignin.AutoSize = true;
            labelPasswordSignin.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            labelPasswordSignin.ForeColor = System.Drawing.Color.Gainsboro;
            labelPasswordSignin.Location = new System.Drawing.Point(14, 87);
            labelPasswordSignin.Margin = new System.Windows.Forms.Padding(0);
            labelPasswordSignin.Name = "labelPasswordSignin";
            labelPasswordSignin.Size = new System.Drawing.Size(92, 28);
            labelPasswordSignin.TabIndex = 5;
            labelPasswordSignin.Text = "Password";
            // 
            // textBoxPasswordSignin
            // 
            textBoxPasswordSignin.BackColor = System.Drawing.Color.Gainsboro;
            textBoxPasswordSignin.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            textBoxPasswordSignin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(93)))));
            textBoxPasswordSignin.Location = new System.Drawing.Point(14, 115);
            textBoxPasswordSignin.Margin = new System.Windows.Forms.Padding(0, 0, 0, 13);
            textBoxPasswordSignin.Name = "textBoxPasswordSignin";
            textBoxPasswordSignin.PasswordChar = '●';
            textBoxPasswordSignin.Size = new System.Drawing.Size(275, 33);
            textBoxPasswordSignin.TabIndex = 7;
            // 
            // checkBoxShowPasswordSignin
            // 
            checkBoxShowPasswordSignin.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            checkBoxShowPasswordSignin.Cursor = System.Windows.Forms.Cursors.Hand;
            checkBoxShowPasswordSignin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            checkBoxShowPasswordSignin.Font = new System.Drawing.Font("Tw Cen MT Condensed", 12F, System.Drawing.FontStyle.Bold);
            checkBoxShowPasswordSignin.ForeColor = System.Drawing.Color.Gainsboro;
            checkBoxShowPasswordSignin.Location = new System.Drawing.Point(14, 161);
            checkBoxShowPasswordSignin.Margin = new System.Windows.Forms.Padding(0, 0, 0, 6);
            checkBoxShowPasswordSignin.Name = "checkBoxShowPasswordSignin";
            checkBoxShowPasswordSignin.Size = new System.Drawing.Size(273, 21);
            checkBoxShowPasswordSignin.TabIndex = 10;
            checkBoxShowPasswordSignin.Text = "Show Password";
            checkBoxShowPasswordSignin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            checkBoxShowPasswordSignin.UseVisualStyleBackColor = true;
            checkBoxShowPasswordSignin.CheckedChanged += new System.EventHandler(Main.CheckBoxShowPasswordSignin_CheckedChange);
            // 
            // buttonSignin
            // 
            buttonSignin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(212)))), ((int)(((byte)(132)))));
            buttonSignin.Cursor = System.Windows.Forms.Cursors.Hand;
            buttonSignin.FlatAppearance.BorderSize = 0;
            buttonSignin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonSignin.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            buttonSignin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(93)))));
            buttonSignin.Location = new System.Drawing.Point(14, 188);
            buttonSignin.Margin = new System.Windows.Forms.Padding(0);
            buttonSignin.Name = "buttonSignin";
            buttonSignin.Size = new System.Drawing.Size(273, 39);
            buttonSignin.TabIndex = 11;
            buttonSignin.Text = "Sign in";
            buttonSignin.UseVisualStyleBackColor = false;
            buttonSignin.Click += new System.EventHandler(Main.ButtonSignin_Click);
            // 
            // buttonClearSignin
            // 
            buttonClearSignin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(110)))));
            buttonClearSignin.Cursor = System.Windows.Forms.Cursors.Hand;
            buttonClearSignin.FlatAppearance.BorderSize = 3;
            buttonClearSignin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonClearSignin.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            buttonClearSignin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(212)))), ((int)(((byte)(132)))));
            buttonClearSignin.Location = new System.Drawing.Point(14, 233);
            buttonClearSignin.Margin = new System.Windows.Forms.Padding(0, 6, 0, 6);
            buttonClearSignin.Name = "buttonClearSignin";
            buttonClearSignin.Size = new System.Drawing.Size(273, 39);
            buttonClearSignin.TabIndex = 12;
            buttonClearSignin.Text = "Clear";
            buttonClearSignin.UseVisualStyleBackColor = false;
            buttonClearSignin.Click += new System.EventHandler(Main.ButtonClearSignin);
            // 
            // labelDontHaveAcc
            // 
            labelDontHaveAcc.Font = new System.Drawing.Font("Tw Cen MT Condensed", 12F, System.Drawing.FontStyle.Bold);
            labelDontHaveAcc.ForeColor = System.Drawing.Color.Gainsboro;
            labelDontHaveAcc.Location = new System.Drawing.Point(14, 278);
            labelDontHaveAcc.Margin = new System.Windows.Forms.Padding(0);
            labelDontHaveAcc.Name = "labelDontHaveAcc";
            labelDontHaveAcc.Size = new System.Drawing.Size(167, 19);
            labelDontHaveAcc.TabIndex = 13;
            labelDontHaveAcc.Text = "Don\'t have an account?";
            labelDontHaveAcc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelChangeToSignup
            // 
            labelChangeToSignup.Cursor = System.Windows.Forms.Cursors.Hand;
            labelChangeToSignup.Font = new System.Drawing.Font("Tw Cen MT Condensed", 14F, System.Drawing.FontStyle.Bold);
            labelChangeToSignup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(212)))), ((int)(((byte)(132)))));
            labelChangeToSignup.Location = new System.Drawing.Point(181, 278);
            labelChangeToSignup.Margin = new System.Windows.Forms.Padding(0);
            labelChangeToSignup.Name = "labelChangeToSignup";
            labelChangeToSignup.Size = new System.Drawing.Size(105, 22);
            labelChangeToSignup.TabIndex = 14;
            labelChangeToSignup.Text = "Go to SIGN UP";
            labelChangeToSignup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            labelChangeToSignup.Click += new System.EventHandler(Main.LabelChangeToSignup_Click);
            // 
            // Main
            // 
            form.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            form.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            form.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(93)))));
            form.ClientSize = new System.Drawing.Size(1267, 741);
            form.Controls.Add(MainStyles.panelMain);
            form.Controls.Add(MainStyles.panelTitleBar);
            form.Controls.Add(MainStyles.panelMenu);
            form.Margin = new System.Windows.Forms.Padding(2);
            form.MinimumSize = new System.Drawing.Size(1281, 774);
            form.Name = "Main";
            form.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            form.Text = "DreamCar";
            form.ResumeLayout(false);

            MainStyles.panelMenu.ResumeLayout(false);
            MainStyles.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(MainStyles.pictureBox1)).EndInit();
            MainStyles.panelTitleBar.ResumeLayout(false);
            MainStyles.panelMain.ResumeLayout(false);
            MainStyles.SignUp.ResumeLayout(false);
            MainStyles.flowLayoutPanel2.ResumeLayout(false);
            MainStyles.flowLayoutPanel2.PerformLayout();
            MainStyles.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(MainStyles.pictureBox2)).EndInit();
            MainStyles.SignIn.ResumeLayout(false);
            MainStyles.flowLayoutPanel5.ResumeLayout(false);
            MainStyles.flowLayoutPanel5.PerformLayout();
        }

        public static void SetButtonColors()
        {
            buttonCollection.BackColor = ThemeColor.ChangeColorBrightness(ColorTranslator.FromHtml("#33334c"), 0.5);
            buttonCollection.ForeColor = Color.Gainsboro;
            buttonCollection.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;

            buttonProfile.BackColor = ThemeColor.ChangeColorBrightness(ColorTranslator.FromHtml("#33334c"), 0.5);
            buttonProfile.ForeColor = Color.Gainsboro;
            buttonProfile.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;

            buttonPublish.BackColor = ThemeColor.ChangeColorBrightness(ColorTranslator.FromHtml("#33334c"), 0.5);
            buttonPublish.ForeColor = Color.Gainsboro;
            buttonPublish.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
        }

        public static void ButtonCollection_Paint(object sender, PaintEventArgs e)
        {
            Button currentButton = (Button)sender;
            buttonCollection.ForeColor = Color.Gainsboro;
            SolidBrush drawBrush = new SolidBrush(currentButton.ForeColor);
            StringFormat sf = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            buttonCollection.Text = string.Empty;
            e.Graphics.DrawString("    Collection", currentButton.Font, drawBrush, e.ClipRectangle, sf);
            drawBrush.Dispose();
            sf.Dispose();
        }

        public static void ButtonPublish_Paint(object sender, PaintEventArgs e)
        {
            Button currentButton = (Button)sender;
            buttonPublish.ForeColor = Color.Gainsboro;
            SolidBrush drawBrush = new SolidBrush(currentButton.ForeColor);
            StringFormat sf = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            buttonPublish.Text = string.Empty;
            e.Graphics.DrawString("Publish", currentButton.Font, drawBrush, e.ClipRectangle, sf);
            drawBrush.Dispose();
            sf.Dispose();
        }

        public static void ButtonProfile_Paint(object sender, PaintEventArgs e)
        {
            Button currentButton = (Button)sender;
            buttonProfile.ForeColor = Color.Gainsboro;
            SolidBrush drawBrush = new SolidBrush(currentButton.ForeColor);
            StringFormat sf = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            buttonProfile.Text = string.Empty;
            e.Graphics.DrawString("Profile", currentButton.Font, drawBrush, e.ClipRectangle, sf);
            drawBrush.Dispose();
            sf.Dispose();
        }

        public static Panel panelMain;
        public static Panel panelMenu;
        public static Panel panelTitleBar;

        public static FlowLayoutPanel SignUp;
        public static FlowLayoutPanel SignIn;
        private static FlowLayoutPanel panelLogo;
        public static FlowLayoutPanel flowLayoutPanel1;
        public static FlowLayoutPanel flowLayoutPanel2;
        private static FlowLayoutPanel flowLayoutPanel5;

        public static Label labelTitle;
        private static Label labelDreamCar;

        private static PictureBox pictureBox1;
        private static PictureBox pictureBox2;

        private static Label labelDontHaveAcc;
        private static Label labelChangeToSignup;

        private static Label labelConfirmPassword;
        private static Label labelPasswordSignin;
        private static Label labelSignin;
        private static Label labelUsernameSignin;
        private static Label labelChangeToSignin;
        private static Label labelHaveAcc;
        private static Label labelPassword;
        private static Label labelSignup;
        private static Label label1;

        public static CheckBox checkBoxShowPassword;

        public static Button buttonCollection;
        public static Button buttonProfile;
        public static Button buttonPublish;
        public static Button buttonTimes;
        public static Button buttonSignin;
        public static Button buttonSignup;
        public static Button buttonClearSignin;
        public static Button buttonClear;

        public static CheckBox checkBoxShowPasswordSignin;

        private static Label labelFirstName;
        private static Label labelLastName;
        private static Label labelUsername;
        private static Label labelCountry;
        private static Label labelCity;
        private static Label labelAddress;
        private static Label labelPhone;
        private static Label labelEmail;

        public static TextBox textBoxPassword;
        public static TextBox textBoxUsername;
        public static TextBox textBoxAddress;
        public static TextBox textBoxEmail;
        public static TextBox textBoxPhone;
        public static TextBox textBoxFirstName;
        public static TextBox textBoxLastName;
        public static TextBox textBoxCountry;
        public static TextBox textBoxCity;
        public static TextBox textBoxConfirmPassword;

        public static TextBox textBoxUsernameSignin;
        public static TextBox textBoxPasswordSignin;
    }
}
