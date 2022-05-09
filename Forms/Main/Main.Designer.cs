namespace DreamCar.Forms.Main
{
    public partial class Main : DreamCar.Helpers.Container
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            Main.panelMenu = new System.Windows.Forms.Panel();
            Main.buttonProfile = new System.Windows.Forms.Button();
            Main.buttonPublish = new System.Windows.Forms.Button();
            Main.buttonCollection = new System.Windows.Forms.Button();
            Main.panelLogo = new System.Windows.Forms.FlowLayoutPanel();
            Main.pictureBox1 = new System.Windows.Forms.PictureBox();
            Main.labelDreamCar = new System.Windows.Forms.Label();
            Main.panelTitleBar = new System.Windows.Forms.Panel();
            Main.buttonTimes = new System.Windows.Forms.Button();
            Main.labelTitle = new System.Windows.Forms.Label();
            Main.panelMain = new System.Windows.Forms.Panel();
            Main.SignUp = new System.Windows.Forms.FlowLayoutPanel();
            Main.labelSignup = new System.Windows.Forms.Label();
            Main.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            Main.labelFirstName = new System.Windows.Forms.Label();
            Main.labelLastName = new System.Windows.Forms.Label();
            Main.labelUsername = new System.Windows.Forms.Label();
            Main.textBoxFirstName = new System.Windows.Forms.TextBox();
            Main.textBoxLastName = new System.Windows.Forms.TextBox();
            Main.textBoxUsername = new System.Windows.Forms.TextBox();
            Main.labelCountry = new System.Windows.Forms.Label();
            Main.labelCity = new System.Windows.Forms.Label();
            Main.labelAddress = new System.Windows.Forms.Label();
            Main.textBoxCountry = new System.Windows.Forms.TextBox();
            Main.textBoxCity = new System.Windows.Forms.TextBox();
            Main.textBoxAddress = new System.Windows.Forms.TextBox();
            Main.labelPhone = new System.Windows.Forms.Label();
            Main.labelEmail = new System.Windows.Forms.Label();
            Main.textBoxPhone = new System.Windows.Forms.TextBox();
            Main.textBoxEmail = new System.Windows.Forms.TextBox();
            Main.labelPassword = new System.Windows.Forms.Label();
            Main.labelConfirmPassword = new System.Windows.Forms.Label();
            Main.textBoxPassword = new System.Windows.Forms.TextBox();
            Main.textBoxConfirmPassword = new System.Windows.Forms.TextBox();
            Main.checkBoxShowPassword = new System.Windows.Forms.CheckBox();
            Main.buttonSignup = new System.Windows.Forms.Button();
            Main.buttonClear = new System.Windows.Forms.Button();
            Main.labelHaveAcc = new System.Windows.Forms.Label();
            Main.labelChangeToSignin = new System.Windows.Forms.Label();
            Main.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            Main.pictureBox2 = new System.Windows.Forms.PictureBox();
            Main.label1 = new System.Windows.Forms.Label();
            Main.SignIn = new System.Windows.Forms.FlowLayoutPanel();
            Main.labelSignin = new System.Windows.Forms.Label();
            Main.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            Main.labelUsernameSignin = new System.Windows.Forms.Label();
            Main.textBoxUsernameSignin = new System.Windows.Forms.TextBox();
            Main.labelPasswordSignin = new System.Windows.Forms.Label();
            Main.textBoxPasswordSignin = new System.Windows.Forms.TextBox();
            Main.checkBoxShowPasswordSignin = new System.Windows.Forms.CheckBox();
            Main.buttonSignin = new System.Windows.Forms.Button();
            Main.buttonClearSignin = new System.Windows.Forms.Button();
            Main.labelDontHaveAcc = new System.Windows.Forms.Label();
            Main.labelChangeToSignup = new System.Windows.Forms.Label();
            Main.panelMenu.SuspendLayout();
            Main.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            Main.panelTitleBar.SuspendLayout();
            Main.panelMain.SuspendLayout();
            Main.SignUp.SuspendLayout();
            Main.flowLayoutPanel2.SuspendLayout();
            Main.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(pictureBox2)).BeginInit();
            Main.SignIn.SuspendLayout();
            Main.flowLayoutPanel5.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            Main.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            Main.panelMenu.Controls.Add(buttonProfile);
            Main.panelMenu.Controls.Add(buttonPublish);
            Main.panelMenu.Controls.Add(buttonCollection);
            Main.panelMenu.Controls.Add(panelLogo);
            Main.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            Main.panelMenu.Location = new System.Drawing.Point(0, 0);
            Main.panelMenu.Margin = new System.Windows.Forms.Padding(2);
            Main.panelMenu.Name = "panelMenu";
            Main.panelMenu.Size = new System.Drawing.Size(180, 741);
            Main.panelMenu.TabIndex = 0;
            // 
            // buttonProfile
            // 
            Main.buttonProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            Main.buttonProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            Main.buttonProfile.Dock = System.Windows.Forms.DockStyle.Top;
            Main.buttonProfile.FlatAppearance.BorderSize = 0;
            Main.buttonProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Main.buttonProfile.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            Main.buttonProfile.ForeColor = System.Drawing.Color.Gainsboro;
            Main.buttonProfile.Image = global::DreamCar.Properties.Resources.user;
            Main.buttonProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            Main.buttonProfile.Location = new System.Drawing.Point(0, 174);
            Main.buttonProfile.Margin = new System.Windows.Forms.Padding(2);
            Main.buttonProfile.Name = "buttonProfile";
            Main.buttonProfile.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            Main.buttonProfile.Size = new System.Drawing.Size(180, 58);
            Main.buttonProfile.TabIndex = 3;
            Main.buttonProfile.Text = "  Profile";
            Main.buttonProfile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            Main.buttonProfile.UseVisualStyleBackColor = true;
            Main.buttonProfile.EnabledChanged += new System.EventHandler(ButtonProfile_EnabledChanged);
            Main.buttonProfile.Click += new System.EventHandler(ButtonProfile_Click);
            Main.buttonProfile.Paint += new System.Windows.Forms.PaintEventHandler(DreamCar.Forms.Main.MainStyles.ButtonProfile_Paint);
            // 
            // buttonPublish
            // 
            Main.buttonPublish.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            Main.buttonPublish.Cursor = System.Windows.Forms.Cursors.Hand;
            Main.buttonPublish.Dock = System.Windows.Forms.DockStyle.Top;
            Main.buttonPublish.FlatAppearance.BorderSize = 0;
            Main.buttonPublish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Main.buttonPublish.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            Main.buttonPublish.ForeColor = System.Drawing.Color.Gainsboro;
            Main.buttonPublish.Image = global::DreamCar.Properties.Resources.upload;
            Main.buttonPublish.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            Main.buttonPublish.Location = new System.Drawing.Point(0, 116);
            Main.buttonPublish.Margin = new System.Windows.Forms.Padding(2);
            Main.buttonPublish.Name = "buttonPublish";
            Main.buttonPublish.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            Main.buttonPublish.Size = new System.Drawing.Size(180, 58);
            Main.buttonPublish.TabIndex = 2;
            Main.buttonPublish.Text = "  Publish";
            Main.buttonPublish.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            Main.buttonPublish.UseVisualStyleBackColor = true;
            Main.buttonPublish.EnabledChanged += new System.EventHandler(ButtonPublish_EnabledChanged);
            Main.buttonPublish.Click += new System.EventHandler(ButtonPublish_Click);
            Main.buttonPublish.Paint += new System.Windows.Forms.PaintEventHandler(DreamCar.Forms.Main.MainStyles.ButtonPublish_Paint); ;
            // 
            // buttonCollection
            // 
            Main.buttonCollection.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            Main.buttonCollection.Cursor = System.Windows.Forms.Cursors.Hand;
            Main.buttonCollection.Dock = System.Windows.Forms.DockStyle.Top;
            Main.buttonCollection.FlatAppearance.BorderSize = 0;
            Main.buttonCollection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Main.buttonCollection.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            Main.buttonCollection.ForeColor = System.Drawing.Color.Gainsboro;
            Main.buttonCollection.Image = ((System.Drawing.Image)(resources.GetObject("buttonCollection.Image")));
            Main.buttonCollection.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            Main.buttonCollection.Location = new System.Drawing.Point(0, 58);
            Main.buttonCollection.Margin = new System.Windows.Forms.Padding(2);
            Main.buttonCollection.Name = "buttonCollection";
            Main.buttonCollection.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            Main.buttonCollection.Size = new System.Drawing.Size(180, 58);
            Main.buttonCollection.TabIndex = 1;
            Main.buttonCollection.Text = "  Collection";
            Main.buttonCollection.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            Main.buttonCollection.UseVisualStyleBackColor = true;
            Main.buttonCollection.EnabledChanged += new System.EventHandler(ButtonCollection_EnabledChanged);
            Main.buttonCollection.Click += new System.EventHandler(ButtonCollection_Click);
            Main.buttonCollection.Paint += new System.Windows.Forms.PaintEventHandler(DreamCar.Forms.Main.MainStyles.ButtonCollection_Paint);
            // 
            // panelLogo
            // 
            Main.panelLogo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            Main.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(184)))), ((int)(((byte)(119)))));
            Main.panelLogo.Controls.Add(pictureBox1);
            Main.panelLogo.Controls.Add(labelDreamCar);
            Main.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            Main.panelLogo.Location = new System.Drawing.Point(0, 0);
            Main.panelLogo.Name = "panelLogo";
            Main.panelLogo.Size = new System.Drawing.Size(180, 58);
            Main.panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            Main.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            Main.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(184)))), ((int)(((byte)(119)))));
            Main.pictureBox1.BackgroundImage = global::DreamCar.Properties.Resources.logoGreen;
            Main.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            Main.pictureBox1.ErrorImage = null;
            Main.pictureBox1.InitialImage = null;
            Main.pictureBox1.Location = new System.Drawing.Point(10, 12);
            Main.pictureBox1.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            Main.pictureBox1.Name = "pictureBox1";
            Main.pictureBox1.Padding = new System.Windows.Forms.Padding(7, 11, 7, 11);
            Main.pictureBox1.Size = new System.Drawing.Size(32, 32);
            Main.pictureBox1.TabIndex = 1;
            Main.pictureBox1.TabStop = false;
            // 
            // labelDreamCar
            // 
            Main.labelDreamCar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(184)))), ((int)(((byte)(119)))));
            Main.labelDreamCar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Main.labelDreamCar.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            Main.labelDreamCar.ForeColor = System.Drawing.Color.Gainsboro;
            Main.labelDreamCar.Location = new System.Drawing.Point(44, 0);
            Main.labelDreamCar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            Main.labelDreamCar.Name = "labelDreamCar";
            Main.labelDreamCar.Size = new System.Drawing.Size(115, 56);
            Main.labelDreamCar.TabIndex = 0;
            Main.labelDreamCar.Text = " DreamCar";
            Main.labelDreamCar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelTitleBar
            // 
            Main.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(212)))), ((int)(((byte)(132)))));
            Main.panelTitleBar.Controls.Add(buttonTimes);
            Main.panelTitleBar.Controls.Add(labelTitle);
            Main.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            Main.panelTitleBar.Location = new System.Drawing.Point(180, 0);
            Main.panelTitleBar.Margin = new System.Windows.Forms.Padding(0);
            Main.panelTitleBar.Name = "panelTitleBar";
            Main.panelTitleBar.Size = new System.Drawing.Size(1087, 58);
            Main.panelTitleBar.TabIndex = 1;
            // 
            // buttonTimes
            // 
            Main.buttonTimes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonTimes.BackgroundImage")));
            Main.buttonTimes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            Main.buttonTimes.Cursor = System.Windows.Forms.Cursors.Hand;
            Main.buttonTimes.Dock = System.Windows.Forms.DockStyle.Left;
            Main.buttonTimes.FlatAppearance.BorderSize = 0;
            Main.buttonTimes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Main.buttonTimes.Location = new System.Drawing.Point(0, 0);
            Main.buttonTimes.Margin = new System.Windows.Forms.Padding(2);
            Main.buttonTimes.Name = "buttonTimes";
            Main.buttonTimes.Size = new System.Drawing.Size(60, 58);
            Main.buttonTimes.TabIndex = 1;
            Main.buttonTimes.UseVisualStyleBackColor = true;
            Main.buttonTimes.Click += new System.EventHandler(ButtonTimes_Click);
            // 
            // labelTitle
            // 
            Main.labelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            Main.labelTitle.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            Main.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(93)))));
            Main.labelTitle.Location = new System.Drawing.Point(0, 0);
            Main.labelTitle.Margin = new System.Windows.Forms.Padding(0);
            Main.labelTitle.Name = "labelTitle";
            Main.labelTitle.Size = new System.Drawing.Size(1087, 58);
            Main.labelTitle.TabIndex = 0;
            Main.labelTitle.Text = "HOME";
            Main.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelMain
            // 
            Main.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(93)))));
            Main.panelMain.Controls.Add(SignUp);
            Main.panelMain.Controls.Add(flowLayoutPanel1);
            Main.panelMain.Controls.Add(SignIn);
            Main.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            Main.panelMain.Location = new System.Drawing.Point(180, 58);
            Main.panelMain.Margin = new System.Windows.Forms.Padding(0);
            Main.panelMain.MinimumSize = new System.Drawing.Size(1087, 750);
            Main.panelMain.Name = "panelMain";
            Main.panelMain.Size = new System.Drawing.Size(1087, 750);
            Main.panelMain.TabIndex = 2;
            // 
            // SignUp
            // 
            Main.SignUp.Anchor = System.Windows.Forms.AnchorStyles.None;
            Main.SignUp.Controls.Add(labelSignup);
            Main.SignUp.Controls.Add(flowLayoutPanel2);
            Main.SignUp.Location = new System.Drawing.Point(48, 141);
            Main.SignUp.Margin = new System.Windows.Forms.Padding(2);
            Main.SignUp.Name = "SignUp";
            Main.SignUp.Size = new System.Drawing.Size(997, 510);
            Main.SignUp.TabIndex = 16;
            // 
            // labelSignup
            // 
            Main.labelSignup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(184)))), ((int)(((byte)(119)))));
            Main.labelSignup.Font = new System.Drawing.Font("Tw Cen MT Condensed", 24F, System.Drawing.FontStyle.Bold);
            Main.labelSignup.ForeColor = System.Drawing.Color.Gainsboro;
            Main.labelSignup.Location = new System.Drawing.Point(0, 0);
            Main.labelSignup.Margin = new System.Windows.Forms.Padding(0);
            Main.labelSignup.Name = "labelSignup";
            Main.labelSignup.Size = new System.Drawing.Size(997, 46);
            Main.labelSignup.TabIndex = 3;
            Main.labelSignup.Text = "SIGN UP";
            Main.labelSignup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel2
            // 
            Main.flowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(110)))));
            Main.flowLayoutPanel2.Controls.Add(labelFirstName);
            Main.flowLayoutPanel2.Controls.Add(labelLastName);
            Main.flowLayoutPanel2.Controls.Add(labelUsername);
            Main.flowLayoutPanel2.Controls.Add(textBoxFirstName);
            Main.flowLayoutPanel2.Controls.Add(textBoxLastName);
            Main.flowLayoutPanel2.Controls.Add(textBoxUsername);
            Main.flowLayoutPanel2.Controls.Add(labelCountry);
            Main.flowLayoutPanel2.Controls.Add(labelCity);
            Main.flowLayoutPanel2.Controls.Add(labelAddress);
            Main.flowLayoutPanel2.Controls.Add(textBoxCountry);
            Main.flowLayoutPanel2.Controls.Add(textBoxCity);
            Main.flowLayoutPanel2.Controls.Add(textBoxAddress);
            Main.flowLayoutPanel2.Controls.Add(labelPhone);
            Main.flowLayoutPanel2.Controls.Add(labelEmail);
            Main.flowLayoutPanel2.Controls.Add(textBoxPhone);
            Main.flowLayoutPanel2.Controls.Add(textBoxEmail);
            Main.flowLayoutPanel2.Controls.Add(labelPassword);
            Main.flowLayoutPanel2.Controls.Add(labelConfirmPassword);
            Main.flowLayoutPanel2.Controls.Add(textBoxPassword);
            Main.flowLayoutPanel2.Controls.Add(textBoxConfirmPassword);
            Main.flowLayoutPanel2.Controls.Add(checkBoxShowPassword);
            Main.flowLayoutPanel2.Controls.Add(buttonSignup);
            Main.flowLayoutPanel2.Controls.Add(buttonClear);
            Main.flowLayoutPanel2.Controls.Add(labelHaveAcc);
            Main.flowLayoutPanel2.Controls.Add(labelChangeToSignin);
            Main.flowLayoutPanel2.Location = new System.Drawing.Point(0, 46);
            Main.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            Main.flowLayoutPanel2.Name = "flowLayoutPanel2";
            Main.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(14, 13, 14, 13);
            Main.flowLayoutPanel2.Size = new System.Drawing.Size(997, 464);
            Main.flowLayoutPanel2.TabIndex = 15;
            // 
            // labelFirstName
            // 
            Main.labelFirstName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            Main.labelFirstName.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            Main.labelFirstName.ForeColor = System.Drawing.Color.Gainsboro;
            Main.labelFirstName.Location = new System.Drawing.Point(14, 13);
            Main.labelFirstName.Margin = new System.Windows.Forms.Padding(0, 0, 13, 0);
            Main.labelFirstName.Name = "labelFirstName";
            Main.labelFirstName.Size = new System.Drawing.Size(314, 28);
            Main.labelFirstName.TabIndex = 22;
            Main.labelFirstName.Text = "First Name";
            // 
            // labelLastName
            // 
            Main.labelLastName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            Main.labelLastName.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            Main.labelLastName.ForeColor = System.Drawing.Color.Gainsboro;
            Main.labelLastName.Location = new System.Drawing.Point(341, 13);
            Main.labelLastName.Margin = new System.Windows.Forms.Padding(0, 0, 13, 0);
            Main.labelLastName.Name = "labelLastName";
            Main.labelLastName.Size = new System.Drawing.Size(314, 28);
            Main.labelLastName.TabIndex = 23;
            Main.labelLastName.Text = "Last Name";
            // 
            // labelUsername
            // 
            Main.labelUsername.Anchor = System.Windows.Forms.AnchorStyles.Top;
            Main.labelUsername.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            Main.labelUsername.ForeColor = System.Drawing.Color.Gainsboro;
            Main.labelUsername.Location = new System.Drawing.Point(668, 13);
            Main.labelUsername.Margin = new System.Windows.Forms.Padding(0);
            Main.labelUsername.Name = "labelUsername";
            Main.labelUsername.Size = new System.Drawing.Size(314, 28);
            Main.labelUsername.TabIndex = 24;
            Main.labelUsername.Text = "Username";
            // 
            // textBoxFirstName
            // 
            Main.textBoxFirstName.Anchor = System.Windows.Forms.AnchorStyles.None;
            Main.textBoxFirstName.BackColor = System.Drawing.Color.Gainsboro;
            Main.textBoxFirstName.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            Main.textBoxFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(93)))));
            Main.textBoxFirstName.Location = new System.Drawing.Point(14, 41);
            Main.textBoxFirstName.Margin = new System.Windows.Forms.Padding(0, 0, 13, 13);
            Main.textBoxFirstName.Name = "textBoxFirstName";
            Main.textBoxFirstName.Size = new System.Drawing.Size(314, 33);
            Main.textBoxFirstName.TabIndex = 1;
            // 
            // textBoxLastName
            // 
            Main.textBoxLastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            Main.textBoxLastName.BackColor = System.Drawing.Color.Gainsboro;
            Main.textBoxLastName.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            Main.textBoxLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(93)))));
            Main.textBoxLastName.Location = new System.Drawing.Point(341, 41);
            Main.textBoxLastName.Margin = new System.Windows.Forms.Padding(0, 0, 13, 13);
            Main.textBoxLastName.Name = "textBoxLastName";
            Main.textBoxLastName.Size = new System.Drawing.Size(314, 33);
            Main.textBoxLastName.TabIndex = 2;
            // 
            // textBoxUsername
            // 
            Main.textBoxUsername.BackColor = System.Drawing.Color.Gainsboro;
            Main.textBoxUsername.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            Main.textBoxUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(93)))));
            Main.textBoxUsername.Location = new System.Drawing.Point(668, 41);
            Main.textBoxUsername.Margin = new System.Windows.Forms.Padding(0, 0, 0, 13);
            Main.textBoxUsername.Name = "textBoxUsername";
            Main.textBoxUsername.Size = new System.Drawing.Size(314, 33);
            Main.textBoxUsername.TabIndex = 3;
            // 
            // labelCountry
            // 
            Main.labelCountry.Anchor = System.Windows.Forms.AnchorStyles.Top;
            Main.labelCountry.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            Main.labelCountry.ForeColor = System.Drawing.Color.Gainsboro;
            Main.labelCountry.Location = new System.Drawing.Point(14, 87);
            Main.labelCountry.Margin = new System.Windows.Forms.Padding(0, 0, 13, 0);
            Main.labelCountry.Name = "labelCountry";
            Main.labelCountry.Size = new System.Drawing.Size(314, 28);
            Main.labelCountry.TabIndex = 25;
            Main.labelCountry.Text = "Country";
            // 
            // labelCity
            // 
            Main.labelCity.Anchor = System.Windows.Forms.AnchorStyles.Top;
            Main.labelCity.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            Main.labelCity.ForeColor = System.Drawing.Color.Gainsboro;
            Main.labelCity.Location = new System.Drawing.Point(341, 87);
            Main.labelCity.Margin = new System.Windows.Forms.Padding(0, 0, 13, 0);
            Main.labelCity.Name = "labelCity";
            Main.labelCity.Size = new System.Drawing.Size(314, 28);
            Main.labelCity.TabIndex = 26;
            Main.labelCity.Text = "City";
            // 
            // labelAddress
            // 
            Main.labelAddress.Anchor = System.Windows.Forms.AnchorStyles.Top;
            Main.labelAddress.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            Main.labelAddress.ForeColor = System.Drawing.Color.Gainsboro;
            Main.labelAddress.Location = new System.Drawing.Point(668, 87);
            Main.labelAddress.Margin = new System.Windows.Forms.Padding(0);
            Main.labelAddress.Name = "labelAddress";
            Main.labelAddress.Size = new System.Drawing.Size(314, 28);
            Main.labelAddress.TabIndex = 27;
            Main.labelAddress.Text = "Address";
            // 
            // textBoxCountry
            // 
            Main.textBoxCountry.Anchor = System.Windows.Forms.AnchorStyles.None;
            Main.textBoxCountry.BackColor = System.Drawing.Color.Gainsboro;
            Main.textBoxCountry.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            Main.textBoxCountry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(93)))));
            Main.textBoxCountry.Location = new System.Drawing.Point(14, 115);
            Main.textBoxCountry.Margin = new System.Windows.Forms.Padding(0, 0, 13, 13);
            Main.textBoxCountry.Name = "textBoxCountry";
            Main.textBoxCountry.Size = new System.Drawing.Size(314, 33);
            Main.textBoxCountry.TabIndex = 4;
            // 
            // textBoxCity
            // 
            Main.textBoxCity.Anchor = System.Windows.Forms.AnchorStyles.None;
            Main.textBoxCity.BackColor = System.Drawing.Color.Gainsboro;
            Main.textBoxCity.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            Main.textBoxCity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(93)))));
            Main.textBoxCity.Location = new System.Drawing.Point(341, 115);
            Main.textBoxCity.Margin = new System.Windows.Forms.Padding(0, 0, 13, 13);
            Main.textBoxCity.Name = "textBoxCity";
            Main.textBoxCity.Size = new System.Drawing.Size(314, 33);
            Main.textBoxCity.TabIndex = 5;
            // 
            // textBoxAddress
            // 
            Main.textBoxAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            Main.textBoxAddress.BackColor = System.Drawing.Color.Gainsboro;
            Main.textBoxAddress.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            Main.textBoxAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(93)))));
            Main.textBoxAddress.Location = new System.Drawing.Point(668, 115);
            Main.textBoxAddress.Margin = new System.Windows.Forms.Padding(0, 0, 0, 13);
            Main.textBoxAddress.Name = "textBoxAddress";
            Main.textBoxAddress.Size = new System.Drawing.Size(314, 33);
            Main.textBoxAddress.TabIndex = 6;
            // 
            // labelPhone
            // 
            Main.labelPhone.Anchor = System.Windows.Forms.AnchorStyles.Top;
            Main.labelPhone.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            Main.labelPhone.ForeColor = System.Drawing.Color.Gainsboro;
            Main.labelPhone.Location = new System.Drawing.Point(14, 161);
            Main.labelPhone.Margin = new System.Windows.Forms.Padding(0, 0, 13, 0);
            Main.labelPhone.Name = "labelPhone";
            Main.labelPhone.Size = new System.Drawing.Size(478, 28);
            Main.labelPhone.TabIndex = 28;
            Main.labelPhone.Text = "Phone";
            // 
            // labelEmail
            // 
            Main.labelEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            Main.labelEmail.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            Main.labelEmail.ForeColor = System.Drawing.Color.Gainsboro;
            Main.labelEmail.Location = new System.Drawing.Point(505, 161);
            Main.labelEmail.Margin = new System.Windows.Forms.Padding(0);
            Main.labelEmail.Name = "labelEmail";
            Main.labelEmail.Size = new System.Drawing.Size(478, 28);
            Main.labelEmail.TabIndex = 29;
            Main.labelEmail.Text = "Email";
            // 
            // textBoxPhone
            // 
            Main.textBoxPhone.Anchor = System.Windows.Forms.AnchorStyles.None;
            Main.textBoxPhone.BackColor = System.Drawing.Color.Gainsboro;
            Main.textBoxPhone.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            Main.textBoxPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(93)))));
            Main.textBoxPhone.Location = new System.Drawing.Point(14, 189);
            Main.textBoxPhone.Margin = new System.Windows.Forms.Padding(0, 0, 13, 13);
            Main.textBoxPhone.Name = "textBoxPhone";
            Main.textBoxPhone.Size = new System.Drawing.Size(478, 33);
            Main.textBoxPhone.TabIndex = 7;
            // 
            // textBoxEmail
            // 
            Main.textBoxEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            Main.textBoxEmail.BackColor = System.Drawing.Color.Gainsboro;
            Main.textBoxEmail.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            Main.textBoxEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(93)))));
            Main.textBoxEmail.Location = new System.Drawing.Point(505, 189);
            Main.textBoxEmail.Margin = new System.Windows.Forms.Padding(0, 0, 0, 13);
            Main.textBoxEmail.Name = "textBoxEmail";
            Main.textBoxEmail.Size = new System.Drawing.Size(478, 33);
            Main.textBoxEmail.TabIndex = 8;
            // 
            // labelPassword
            // 
            Main.labelPassword.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            Main.labelPassword.ForeColor = System.Drawing.Color.Gainsboro;
            Main.labelPassword.Location = new System.Drawing.Point(14, 235);
            Main.labelPassword.Margin = new System.Windows.Forms.Padding(0, 0, 13, 0);
            Main.labelPassword.Name = "labelPassword";
            Main.labelPassword.Size = new System.Drawing.Size(478, 28);
            Main.labelPassword.TabIndex = 5;
            Main.labelPassword.Text = "Password";
            // 
            // labelConfirmPassword
            // 
            Main.labelConfirmPassword.AutoSize = true;
            Main.labelConfirmPassword.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            Main.labelConfirmPassword.ForeColor = System.Drawing.Color.Gainsboro;
            Main.labelConfirmPassword.Location = new System.Drawing.Point(505, 235);
            Main.labelConfirmPassword.Margin = new System.Windows.Forms.Padding(0);
            Main.labelConfirmPassword.Name = "labelConfirmPassword";
            Main.labelConfirmPassword.Size = new System.Drawing.Size(166, 28);
            Main.labelConfirmPassword.TabIndex = 8;
            Main.labelConfirmPassword.Text = "Confirm Password";
            // 
            // textBoxPassword
            // 
            Main.textBoxPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            Main.textBoxPassword.BackColor = System.Drawing.Color.Gainsboro;
            Main.textBoxPassword.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            Main.textBoxPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(93)))));
            Main.textBoxPassword.Location = new System.Drawing.Point(14, 263);
            Main.textBoxPassword.Margin = new System.Windows.Forms.Padding(0, 0, 13, 13);
            Main.textBoxPassword.Name = "textBoxPassword";
            Main.textBoxPassword.PasswordChar = '●';
            Main.textBoxPassword.Size = new System.Drawing.Size(478, 33);
            Main.textBoxPassword.TabIndex = 9;
            // 
            // textBoxConfirmPassword
            // 
            Main.textBoxConfirmPassword.BackColor = System.Drawing.Color.Gainsboro;
            Main.textBoxConfirmPassword.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            Main.textBoxConfirmPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(93)))));
            Main.textBoxConfirmPassword.Location = new System.Drawing.Point(505, 263);
            Main.textBoxConfirmPassword.Margin = new System.Windows.Forms.Padding(0, 0, 0, 13);
            Main.textBoxConfirmPassword.Name = "textBoxConfirmPassword";
            Main.textBoxConfirmPassword.PasswordChar = '●';
            Main.textBoxConfirmPassword.Size = new System.Drawing.Size(478, 33);
            Main.textBoxConfirmPassword.TabIndex = 10;
            // 
            // checkBoxShowPassword
            // 
            Main.checkBoxShowPassword.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            Main.checkBoxShowPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            Main.checkBoxShowPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Main.checkBoxShowPassword.Font = new System.Drawing.Font("Tw Cen MT Condensed", 12F, System.Drawing.FontStyle.Bold);
            Main.checkBoxShowPassword.ForeColor = System.Drawing.Color.Gainsboro;
            Main.checkBoxShowPassword.Location = new System.Drawing.Point(14, 309);
            Main.checkBoxShowPassword.Margin = new System.Windows.Forms.Padding(0, 0, 0, 6);
            Main.checkBoxShowPassword.Name = "checkBoxShowPassword";
            Main.checkBoxShowPassword.Size = new System.Drawing.Size(969, 21);
            Main.checkBoxShowPassword.TabIndex = 11;
            Main.checkBoxShowPassword.Text = "Show Password";
            Main.checkBoxShowPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            Main.checkBoxShowPassword.UseVisualStyleBackColor = true;
            Main.checkBoxShowPassword.CheckedChanged += new System.EventHandler(CheckBoxShowPassword_CheckedChanged);
            // 
            // buttonSignup
            // 
            Main.buttonSignup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(212)))), ((int)(((byte)(132)))));
            Main.buttonSignup.Cursor = System.Windows.Forms.Cursors.Hand;
            Main.buttonSignup.FlatAppearance.BorderSize = 0;
            Main.buttonSignup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Main.buttonSignup.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            Main.buttonSignup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(93)))));
            Main.buttonSignup.Location = new System.Drawing.Point(14, 336);
            Main.buttonSignup.Margin = new System.Windows.Forms.Padding(0);
            Main.buttonSignup.Name = "buttonSignup";
            Main.buttonSignup.Size = new System.Drawing.Size(969, 39);
            Main.buttonSignup.TabIndex = 12;
            Main.buttonSignup.Text = "Sign up";
            Main.buttonSignup.UseVisualStyleBackColor = false;
            Main.buttonSignup.Click += new System.EventHandler(ButtonSignup_Click);
            // 
            // buttonClear
            // 
            Main.buttonClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(110)))));
            Main.buttonClear.Cursor = System.Windows.Forms.Cursors.Hand;
            Main.buttonClear.FlatAppearance.BorderSize = 3;
            Main.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Main.buttonClear.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            Main.buttonClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(212)))), ((int)(((byte)(132)))));
            Main.buttonClear.Location = new System.Drawing.Point(14, 381);
            Main.buttonClear.Margin = new System.Windows.Forms.Padding(0, 6, 0, 6);
            Main.buttonClear.Name = "buttonClear";
            Main.buttonClear.Size = new System.Drawing.Size(969, 39);
            Main.buttonClear.TabIndex = 13;
            Main.buttonClear.Text = "Clear";
            Main.buttonClear.UseVisualStyleBackColor = false;
            Main.buttonClear.Click += new System.EventHandler(ButtonClear_Click);
            // 
            // labelHaveAcc
            // 
            Main.labelHaveAcc.Font = new System.Drawing.Font("Tw Cen MT Condensed", 12F, System.Drawing.FontStyle.Bold);
            Main.labelHaveAcc.ForeColor = System.Drawing.Color.Gainsboro;
            Main.labelHaveAcc.Location = new System.Drawing.Point(14, 426);
            Main.labelHaveAcc.Margin = new System.Windows.Forms.Padding(0);
            Main.labelHaveAcc.Name = "labelHaveAcc";
            Main.labelHaveAcc.Size = new System.Drawing.Size(851, 38);
            Main.labelHaveAcc.TabIndex = 13;
            Main.labelHaveAcc.Text = "Already have an account?";
            Main.labelHaveAcc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelChangeToSignin
            // 
            Main.labelChangeToSignin.Cursor = System.Windows.Forms.Cursors.Hand;
            Main.labelChangeToSignin.Font = new System.Drawing.Font("Tw Cen MT Condensed", 14F, System.Drawing.FontStyle.Bold);
            Main.labelChangeToSignin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(212)))), ((int)(((byte)(132)))));
            Main.labelChangeToSignin.Location = new System.Drawing.Point(865, 426);
            Main.labelChangeToSignin.Margin = new System.Windows.Forms.Padding(0);
            Main.labelChangeToSignin.Name = "labelChangeToSignin";
            Main.labelChangeToSignin.Size = new System.Drawing.Size(117, 38);
            Main.labelChangeToSignin.TabIndex = 14;
            Main.labelChangeToSignin.Text = "Back to SIGN IN";
            Main.labelChangeToSignin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            Main.labelChangeToSignin.Click += new System.EventHandler(LabelChangeToSignin_Click);
            // 
            // flowLayoutPanel1
            // 
            Main.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            Main.flowLayoutPanel1.Controls.Add(pictureBox2);
            Main.flowLayoutPanel1.Controls.Add(label1);
            Main.flowLayoutPanel1.Location = new System.Drawing.Point(324, 21);
            Main.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            Main.flowLayoutPanel1.Name = "flowLayoutPanel1";
            Main.flowLayoutPanel1.Size = new System.Drawing.Size(471, 95);
            Main.flowLayoutPanel1.TabIndex = 2;
            // 
            // pictureBox2
            // 
            Main.pictureBox2.BackgroundImage = global::DreamCar.Properties.Resources.logoGreen;
            Main.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            Main.pictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            Main.pictureBox2.Location = new System.Drawing.Point(0, 0);
            Main.pictureBox2.Margin = new System.Windows.Forms.Padding(0);
            Main.pictureBox2.Name = "pictureBox2";
            Main.pictureBox2.Size = new System.Drawing.Size(95, 95);
            Main.pictureBox2.TabIndex = 0;
            Main.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            Main.label1.Font = new System.Drawing.Font("Tw Cen MT Condensed", 66F, System.Drawing.FontStyle.Bold);
            Main.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(212)))), ((int)(((byte)(132)))));
            Main.label1.Location = new System.Drawing.Point(95, 0);
            Main.label1.Margin = new System.Windows.Forms.Padding(0);
            Main.label1.Name = "label1";
            Main.label1.Size = new System.Drawing.Size(376, 95);
            Main.label1.TabIndex = 1;
            Main.label1.Text = "DreamCar";
            Main.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SignIn
            // 
            Main.SignIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            Main.SignIn.Controls.Add(labelSignin);
            Main.SignIn.Controls.Add(flowLayoutPanel5);
            Main.SignIn.Location = new System.Drawing.Point(374, 178);
            Main.SignIn.Margin = new System.Windows.Forms.Padding(2);
            Main.SignIn.Name = "SignIn";
            Main.SignIn.Size = new System.Drawing.Size(300, 355);
            Main.SignIn.TabIndex = 17;
            Main.SignIn.Visible = false;
            // 
            // labelSignin
            // 
            Main.labelSignin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(184)))), ((int)(((byte)(119)))));
            Main.labelSignin.Font = new System.Drawing.Font("Tw Cen MT Condensed", 24F, System.Drawing.FontStyle.Bold);
            Main.labelSignin.ForeColor = System.Drawing.Color.Gainsboro;
            Main.labelSignin.Location = new System.Drawing.Point(0, 0);
            Main.labelSignin.Margin = new System.Windows.Forms.Padding(0);
            Main.labelSignin.Name = "labelSignin";
            Main.labelSignin.Size = new System.Drawing.Size(300, 46);
            Main.labelSignin.TabIndex = 3;
            Main.labelSignin.Text = "SIGN IN";
            Main.labelSignin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel5
            // 
            Main.flowLayoutPanel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(110)))));
            Main.flowLayoutPanel5.Controls.Add(labelUsernameSignin);
            Main.flowLayoutPanel5.Controls.Add(textBoxUsernameSignin);
            Main.flowLayoutPanel5.Controls.Add(labelPasswordSignin);
            Main.flowLayoutPanel5.Controls.Add(textBoxPasswordSignin);
            Main.flowLayoutPanel5.Controls.Add(checkBoxShowPasswordSignin);
            Main.flowLayoutPanel5.Controls.Add(buttonSignin);
            Main.flowLayoutPanel5.Controls.Add(buttonClearSignin);
            Main.flowLayoutPanel5.Controls.Add(labelDontHaveAcc);
            Main.flowLayoutPanel5.Controls.Add(labelChangeToSignup);
            Main.flowLayoutPanel5.Location = new System.Drawing.Point(0, 46);
            Main.flowLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            Main.flowLayoutPanel5.Name = "flowLayoutPanel5";
            Main.flowLayoutPanel5.Padding = new System.Windows.Forms.Padding(14, 13, 14, 13);
            Main.flowLayoutPanel5.Size = new System.Drawing.Size(300, 310);
            Main.flowLayoutPanel5.TabIndex = 15;
            // 
            // labelUsernameSignin
            // 
            Main.labelUsernameSignin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            Main.labelUsernameSignin.AutoSize = true;
            Main.labelUsernameSignin.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            Main.labelUsernameSignin.ForeColor = System.Drawing.Color.Gainsboro;
            Main.labelUsernameSignin.Location = new System.Drawing.Point(14, 13);
            Main.labelUsernameSignin.Margin = new System.Windows.Forms.Padding(0);
            Main.labelUsernameSignin.Name = "labelUsernameSignin";
            Main.labelUsernameSignin.Size = new System.Drawing.Size(97, 28);
            Main.labelUsernameSignin.TabIndex = 4;
            Main.labelUsernameSignin.Text = "Username";
            // 
            // textBoxUsernameSignin
            // 
            Main.textBoxUsernameSignin.BackColor = System.Drawing.Color.Gainsboro;
            Main.textBoxUsernameSignin.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            Main.textBoxUsernameSignin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(93)))));
            Main.textBoxUsernameSignin.Location = new System.Drawing.Point(14, 41);
            Main.textBoxUsernameSignin.Margin = new System.Windows.Forms.Padding(0, 0, 0, 13);
            Main.textBoxUsernameSignin.Name = "textBoxUsernameSignin";
            Main.textBoxUsernameSignin.Size = new System.Drawing.Size(275, 33);
            Main.textBoxUsernameSignin.TabIndex = 6;
            // 
            // labelPasswordSignin
            // 
            Main.labelPasswordSignin.AutoSize = true;
            Main.labelPasswordSignin.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            Main.labelPasswordSignin.ForeColor = System.Drawing.Color.Gainsboro;
            Main.labelPasswordSignin.Location = new System.Drawing.Point(14, 87);
            Main.labelPasswordSignin.Margin = new System.Windows.Forms.Padding(0);
            Main.labelPasswordSignin.Name = "labelPasswordSignin";
            Main.labelPasswordSignin.Size = new System.Drawing.Size(92, 28);
            Main.labelPasswordSignin.TabIndex = 5;
            Main.labelPasswordSignin.Text = "Password";
            // 
            // textBoxPasswordSignin
            // 
            Main.textBoxPasswordSignin.BackColor = System.Drawing.Color.Gainsboro;
            Main.textBoxPasswordSignin.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            Main.textBoxPasswordSignin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(93)))));
            Main.textBoxPasswordSignin.Location = new System.Drawing.Point(14, 115);
            Main.textBoxPasswordSignin.Margin = new System.Windows.Forms.Padding(0, 0, 0, 13);
            Main.textBoxPasswordSignin.Name = "textBoxPasswordSignin";
            Main.textBoxPasswordSignin.PasswordChar = '●';
            Main.textBoxPasswordSignin.Size = new System.Drawing.Size(275, 33);
            Main.textBoxPasswordSignin.TabIndex = 7;
            // 
            // checkBoxShowPasswordSignin
            // 
            Main.checkBoxShowPasswordSignin.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            Main.checkBoxShowPasswordSignin.Cursor = System.Windows.Forms.Cursors.Hand;
            Main.checkBoxShowPasswordSignin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Main.checkBoxShowPasswordSignin.Font = new System.Drawing.Font("Tw Cen MT Condensed", 12F, System.Drawing.FontStyle.Bold);
            Main.checkBoxShowPasswordSignin.ForeColor = System.Drawing.Color.Gainsboro;
            Main.checkBoxShowPasswordSignin.Location = new System.Drawing.Point(14, 161);
            Main.checkBoxShowPasswordSignin.Margin = new System.Windows.Forms.Padding(0, 0, 0, 6);
            Main.checkBoxShowPasswordSignin.Name = "checkBoxShowPasswordSignin";
            Main.checkBoxShowPasswordSignin.Size = new System.Drawing.Size(273, 21);
            Main.checkBoxShowPasswordSignin.TabIndex = 10;
            Main.checkBoxShowPasswordSignin.Text = "Show Password";
            Main.checkBoxShowPasswordSignin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            Main.checkBoxShowPasswordSignin.UseVisualStyleBackColor = true;
            Main.checkBoxShowPasswordSignin.CheckedChanged += new System.EventHandler(CheckBoxShowPasswordSignin_CheckedChange);
            // 
            // buttonSignin
            // 
            Main.buttonSignin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(212)))), ((int)(((byte)(132)))));
            Main.buttonSignin.Cursor = System.Windows.Forms.Cursors.Hand;
            Main.buttonSignin.FlatAppearance.BorderSize = 0;
            Main.buttonSignin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Main.buttonSignin.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            Main.buttonSignin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(93)))));
            Main.buttonSignin.Location = new System.Drawing.Point(14, 188);
            Main.buttonSignin.Margin = new System.Windows.Forms.Padding(0);
            Main.buttonSignin.Name = "buttonSignin";
            Main.buttonSignin.Size = new System.Drawing.Size(273, 39);
            Main.buttonSignin.TabIndex = 11;
            Main.buttonSignin.Text = "Sign in";
            Main.buttonSignin.UseVisualStyleBackColor = false;
            Main.buttonSignin.Click += new System.EventHandler(ButtonSignin_Click);
            // 
            // buttonClearSignin
            // 
            Main.buttonClearSignin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(110)))));
            Main.buttonClearSignin.Cursor = System.Windows.Forms.Cursors.Hand;
            Main.buttonClearSignin.FlatAppearance.BorderSize = 3;
            Main.buttonClearSignin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Main.buttonClearSignin.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            Main.buttonClearSignin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(212)))), ((int)(((byte)(132)))));
            Main.buttonClearSignin.Location = new System.Drawing.Point(14, 233);
            Main.buttonClearSignin.Margin = new System.Windows.Forms.Padding(0, 6, 0, 6);
            Main.buttonClearSignin.Name = "buttonClearSignin";
            Main.buttonClearSignin.Size = new System.Drawing.Size(273, 39);
            Main.buttonClearSignin.TabIndex = 12;
            Main.buttonClearSignin.Text = "Clear";
            Main.buttonClearSignin.UseVisualStyleBackColor = false;
            Main.buttonClearSignin.Click += new System.EventHandler(ButtonClearSignin);
            // 
            // labelDontHaveAcc
            // 
            Main.labelDontHaveAcc.Font = new System.Drawing.Font("Tw Cen MT Condensed", 12F, System.Drawing.FontStyle.Bold);
            Main.labelDontHaveAcc.ForeColor = System.Drawing.Color.Gainsboro;
            Main.labelDontHaveAcc.Location = new System.Drawing.Point(14, 278);
            Main.labelDontHaveAcc.Margin = new System.Windows.Forms.Padding(0);
            Main.labelDontHaveAcc.Name = "labelDontHaveAcc";
            Main.labelDontHaveAcc.Size = new System.Drawing.Size(167, 19);
            Main.labelDontHaveAcc.TabIndex = 13;
            Main.labelDontHaveAcc.Text = "Don\'t have an account?";
            Main.labelDontHaveAcc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelChangeToSignup
            // 
            Main.labelChangeToSignup.Cursor = System.Windows.Forms.Cursors.Hand;
            Main.labelChangeToSignup.Font = new System.Drawing.Font("Tw Cen MT Condensed", 14F, System.Drawing.FontStyle.Bold);
            Main.labelChangeToSignup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(212)))), ((int)(((byte)(132)))));
            Main.labelChangeToSignup.Location = new System.Drawing.Point(181, 278);
            Main.labelChangeToSignup.Margin = new System.Windows.Forms.Padding(0);
            Main.labelChangeToSignup.Name = "labelChangeToSignup";
            Main.labelChangeToSignup.Size = new System.Drawing.Size(105, 22);
            Main.labelChangeToSignup.TabIndex = 14;
            Main.labelChangeToSignup.Text = "Go to SIGN UP";
            Main.labelChangeToSignup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            Main.labelChangeToSignup.Click += new System.EventHandler(LabelChangeToSignup_Click);
            // 
            // Main
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(93)))));
            ClientSize = new System.Drawing.Size(1267, 741);
            Controls.Add(panelMain);
            Controls.Add(panelTitleBar);
            Controls.Add(panelMenu);
            Margin = new System.Windows.Forms.Padding(2);
            MinimumSize = new System.Drawing.Size(1281, 774);
            Name = "Main";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "DreamCar";
            Main.panelMenu.ResumeLayout(false);
            Main.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            Main.panelTitleBar.ResumeLayout(false);
            Main.panelMain.ResumeLayout(false);
            Main.SignUp.ResumeLayout(false);
            Main.flowLayoutPanel2.ResumeLayout(false);
            Main.flowLayoutPanel2.PerformLayout();
            Main.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(pictureBox2)).EndInit();
            Main.SignIn.ResumeLayout(false);
            Main.flowLayoutPanel5.ResumeLayout(false);
            Main.flowLayoutPanel5.PerformLayout();
            ResumeLayout(false);

        }
    }
}