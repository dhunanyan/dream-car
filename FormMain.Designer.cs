namespace DreamCar
{
    public partial class FormMain : DreamCar.Helpers.Container
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonProfile = new System.Windows.Forms.Button();
            this.buttonPublish = new System.Windows.Forms.Button();
            this.buttonCollection = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelDreamCar = new System.Windows.Forms.Label();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.buttonTimes = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.SignUp = new System.Windows.Forms.FlowLayoutPanel();
            this.labelSignup = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelUsername = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelConfirmPassword = new System.Windows.Forms.Label();
            this.textBoxConfirmPassword = new System.Windows.Forms.TextBox();
            this.checkBoxShowPassword = new System.Windows.Forms.CheckBox();
            this.buttonSignup = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.labelHaveAcc = new System.Windows.Forms.Label();
            this.labelChangeToSignin = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SignIn = new System.Windows.Forms.FlowLayoutPanel();
            this.labelSignin = new System.Windows.Forms.Label();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelUsernameSignin = new System.Windows.Forms.Label();
            this.textBoxUsernameSignin = new System.Windows.Forms.TextBox();
            this.labelPasswordSignin = new System.Windows.Forms.Label();
            this.textBoxPasswordSignin = new System.Windows.Forms.TextBox();
            this.checkBoxShowPasswordSignin = new System.Windows.Forms.CheckBox();
            this.buttonSignin = new System.Windows.Forms.Button();
            this.buttonClearSignin = new System.Windows.Forms.Button();
            this.labelDontHaveAcc = new System.Windows.Forms.Label();
            this.labelChangeToSignup = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.SignUp.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SignIn.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.buttonProfile);
            this.panelMenu.Controls.Add(this.buttonPublish);
            this.panelMenu.Controls.Add(this.buttonCollection);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(180, 729);
            this.panelMenu.TabIndex = 0;
            // 
            // buttonProfile
            // 
            this.buttonProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonProfile.FlatAppearance.BorderSize = 0;
            this.buttonProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProfile.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            this.buttonProfile.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonProfile.Image = ((System.Drawing.Image)(resources.GetObject("buttonProfile.Image")));
            this.buttonProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonProfile.Location = new System.Drawing.Point(0, 174);
            this.buttonProfile.Margin = new System.Windows.Forms.Padding(2);
            this.buttonProfile.Name = "buttonProfile";
            this.buttonProfile.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.buttonProfile.Size = new System.Drawing.Size(180, 58);
            this.buttonProfile.TabIndex = 2;
            this.buttonProfile.Text = "  Profile";
            this.buttonProfile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonProfile.UseVisualStyleBackColor = true;
            this.buttonProfile.EnabledChanged += new System.EventHandler(this.ButtonProfile_EnabledChanged);
            this.buttonProfile.Click += new System.EventHandler(this.ButtonProfile_Click);
            this.buttonProfile.Paint += new System.Windows.Forms.PaintEventHandler(this.ButtonProfile_Paint);
            // 
            // buttonPublish
            // 
            this.buttonPublish.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonPublish.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPublish.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPublish.FlatAppearance.BorderSize = 0;
            this.buttonPublish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPublish.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            this.buttonPublish.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonPublish.Image = ((System.Drawing.Image)(resources.GetObject("buttonPublish.Image")));
            this.buttonPublish.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPublish.Location = new System.Drawing.Point(0, 116);
            this.buttonPublish.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPublish.Name = "buttonPublish";
            this.buttonPublish.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.buttonPublish.Size = new System.Drawing.Size(180, 58);
            this.buttonPublish.TabIndex = 1;
            this.buttonPublish.Text = "  Publish";
            this.buttonPublish.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonPublish.UseVisualStyleBackColor = true;
            this.buttonPublish.EnabledChanged += new System.EventHandler(this.ButtonPublish_EnabledChanged);
            this.buttonPublish.Click += new System.EventHandler(this.ButtonPublish_Click);
            this.buttonPublish.Paint += new System.Windows.Forms.PaintEventHandler(this.ButtonPublish_Paint);
            // 
            // buttonCollection
            // 
            this.buttonCollection.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonCollection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCollection.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonCollection.FlatAppearance.BorderSize = 0;
            this.buttonCollection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCollection.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            this.buttonCollection.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonCollection.Image = ((System.Drawing.Image)(resources.GetObject("buttonCollection.Image")));
            this.buttonCollection.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCollection.Location = new System.Drawing.Point(0, 58);
            this.buttonCollection.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCollection.Name = "buttonCollection";
            this.buttonCollection.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.buttonCollection.Size = new System.Drawing.Size(180, 58);
            this.buttonCollection.TabIndex = 0;
            this.buttonCollection.Text = "  Collection";
            this.buttonCollection.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCollection.UseVisualStyleBackColor = true;
            this.buttonCollection.EnabledChanged += new System.EventHandler(this.ButtonCollection_EnabledChanged);
            this.buttonCollection.Click += new System.EventHandler(this.ButtonCollection_Click);
            this.buttonCollection.Paint += new System.Windows.Forms.PaintEventHandler(this.ButtonCollection_Paint);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Controls.Add(this.labelDreamCar);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.ForeColor = System.Drawing.Color.Gainsboro;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(2);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Padding = new System.Windows.Forms.Padding(3);
            this.panelLogo.Size = new System.Drawing.Size(180, 58);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(7, 11, 7, 11);
            this.pictureBox1.Size = new System.Drawing.Size(43, 52);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // labelDreamCar
            // 
            this.labelDreamCar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDreamCar.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            this.labelDreamCar.Location = new System.Drawing.Point(3, 3);
            this.labelDreamCar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDreamCar.Name = "labelDreamCar";
            this.labelDreamCar.Size = new System.Drawing.Size(174, 52);
            this.labelDreamCar.TabIndex = 0;
            this.labelDreamCar.Text = "   DreamCar";
            this.labelDreamCar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.panelTitleBar.Controls.Add(this.buttonTimes);
            this.panelTitleBar.Controls.Add(this.labelTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(180, 0);
            this.panelTitleBar.Margin = new System.Windows.Forms.Padding(0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1087, 58);
            this.panelTitleBar.TabIndex = 1;
            // 
            // buttonTimes
            // 
            this.buttonTimes.BackgroundImage = global::DreamCar.Properties.Resources.logout;
            this.buttonTimes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonTimes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTimes.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonTimes.FlatAppearance.BorderSize = 0;
            this.buttonTimes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTimes.Location = new System.Drawing.Point(0, 0);
            this.buttonTimes.Margin = new System.Windows.Forms.Padding(2);
            this.buttonTimes.Name = "buttonTimes";
            this.buttonTimes.Size = new System.Drawing.Size(60, 58);
            this.buttonTimes.TabIndex = 1;
            this.buttonTimes.UseVisualStyleBackColor = true;
            this.buttonTimes.Click += new System.EventHandler(this.ButtonTimes_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTitle.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelTitle.Location = new System.Drawing.Point(0, 0);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(1087, 58);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "HOME";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(93)))));
            this.panelMain.Controls.Add(this.SignUp);
            this.panelMain.Controls.Add(this.flowLayoutPanel1);
            this.panelMain.Controls.Add(this.SignIn);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(180, 58);
            this.panelMain.Margin = new System.Windows.Forms.Padding(0);
            this.panelMain.MinimumSize = new System.Drawing.Size(1086, 616);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1087, 671);
            this.panelMain.TabIndex = 2;
            // 
            // SignUp
            // 
            this.SignUp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SignUp.Controls.Add(this.labelSignup);
            this.SignUp.Controls.Add(this.flowLayoutPanel2);
            this.SignUp.Location = new System.Drawing.Point(344, 211);
            this.SignUp.Margin = new System.Windows.Forms.Padding(2);
            this.SignUp.Name = "SignUp";
            this.SignUp.Size = new System.Drawing.Size(300, 429);
            this.SignUp.TabIndex = 16;
            // 
            // labelSignup
            // 
            this.labelSignup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.labelSignup.Font = new System.Drawing.Font("Tw Cen MT Condensed", 24F, System.Drawing.FontStyle.Bold);
            this.labelSignup.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelSignup.Location = new System.Drawing.Point(2, 0);
            this.labelSignup.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSignup.Name = "labelSignup";
            this.labelSignup.Size = new System.Drawing.Size(300, 46);
            this.labelSignup.TabIndex = 3;
            this.labelSignup.Text = "SIGN UP";
            this.labelSignup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(110)))));
            this.flowLayoutPanel2.Controls.Add(this.labelUsername);
            this.flowLayoutPanel2.Controls.Add(this.textBoxUsername);
            this.flowLayoutPanel2.Controls.Add(this.labelPassword);
            this.flowLayoutPanel2.Controls.Add(this.textBoxPassword);
            this.flowLayoutPanel2.Controls.Add(this.labelConfirmPassword);
            this.flowLayoutPanel2.Controls.Add(this.textBoxConfirmPassword);
            this.flowLayoutPanel2.Controls.Add(this.checkBoxShowPassword);
            this.flowLayoutPanel2.Controls.Add(this.buttonSignup);
            this.flowLayoutPanel2.Controls.Add(this.buttonClear);
            this.flowLayoutPanel2.Controls.Add(this.labelHaveAcc);
            this.flowLayoutPanel2.Controls.Add(this.labelChangeToSignin);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 46);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(300, 384);
            this.flowLayoutPanel2.TabIndex = 15;
            // 
            // labelUsername
            // 
            this.labelUsername.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            this.labelUsername.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelUsername.Location = new System.Drawing.Point(14, 13);
            this.labelUsername.Margin = new System.Windows.Forms.Padding(0);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(97, 28);
            this.labelUsername.TabIndex = 4;
            this.labelUsername.Text = "Username";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxUsername.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            this.textBoxUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(93)))));
            this.textBoxUsername.Location = new System.Drawing.Point(14, 41);
            this.textBoxUsername.Margin = new System.Windows.Forms.Padding(0, 0, 0, 13);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(275, 33);
            this.textBoxUsername.TabIndex = 6;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            this.labelPassword.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelPassword.Location = new System.Drawing.Point(14, 87);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(92, 28);
            this.labelPassword.TabIndex = 5;
            this.labelPassword.Text = "Password";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxPassword.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            this.textBoxPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(93)))));
            this.textBoxPassword.Location = new System.Drawing.Point(14, 115);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(0, 0, 0, 13);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '●';
            this.textBoxPassword.Size = new System.Drawing.Size(275, 33);
            this.textBoxPassword.TabIndex = 7;
            // 
            // labelConfirmPassword
            // 
            this.labelConfirmPassword.AutoSize = true;
            this.labelConfirmPassword.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            this.labelConfirmPassword.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelConfirmPassword.Location = new System.Drawing.Point(14, 161);
            this.labelConfirmPassword.Margin = new System.Windows.Forms.Padding(0);
            this.labelConfirmPassword.Name = "labelConfirmPassword";
            this.labelConfirmPassword.Size = new System.Drawing.Size(166, 28);
            this.labelConfirmPassword.TabIndex = 8;
            this.labelConfirmPassword.Text = "Confirm Password";
            // 
            // textBoxConfirmPassword
            // 
            this.textBoxConfirmPassword.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxConfirmPassword.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            this.textBoxConfirmPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(93)))));
            this.textBoxConfirmPassword.Location = new System.Drawing.Point(14, 189);
            this.textBoxConfirmPassword.Margin = new System.Windows.Forms.Padding(0, 0, 0, 13);
            this.textBoxConfirmPassword.Name = "textBoxConfirmPassword";
            this.textBoxConfirmPassword.PasswordChar = '●';
            this.textBoxConfirmPassword.Size = new System.Drawing.Size(275, 33);
            this.textBoxConfirmPassword.TabIndex = 9;
            // 
            // checkBoxShowPassword
            // 
            this.checkBoxShowPassword.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxShowPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxShowPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxShowPassword.Font = new System.Drawing.Font("Tw Cen MT Condensed", 12F, System.Drawing.FontStyle.Bold);
            this.checkBoxShowPassword.ForeColor = System.Drawing.Color.Gainsboro;
            this.checkBoxShowPassword.Location = new System.Drawing.Point(14, 235);
            this.checkBoxShowPassword.Margin = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.checkBoxShowPassword.Name = "checkBoxShowPassword";
            this.checkBoxShowPassword.Size = new System.Drawing.Size(273, 21);
            this.checkBoxShowPassword.TabIndex = 10;
            this.checkBoxShowPassword.Text = "Show Password";
            this.checkBoxShowPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxShowPassword.UseVisualStyleBackColor = true;
            //REG
            //this.checkBoxShowPassword.CheckedChanged += new System.EventHandler(this.CheckBoxShowPassword_CheckedChanged);
            // 
            // buttonSignup
            // 
            this.buttonSignup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.buttonSignup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSignup.FlatAppearance.BorderSize = 0;
            this.buttonSignup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSignup.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            this.buttonSignup.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonSignup.Location = new System.Drawing.Point(14, 262);
            this.buttonSignup.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSignup.Name = "buttonSignup";
            this.buttonSignup.Size = new System.Drawing.Size(273, 39);
            this.buttonSignup.TabIndex = 11;
            this.buttonSignup.Text = "Sign up";
            this.buttonSignup.UseVisualStyleBackColor = false;
            //REG
            //this.buttonSignup.Click += new System.EventHandler(this.ButtonSignup_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(110)))));
            this.buttonClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClear.FlatAppearance.BorderSize = 3;
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClear.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            this.buttonClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.buttonClear.Location = new System.Drawing.Point(14, 307);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(273, 39);
            this.buttonClear.TabIndex = 12;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = false;
            //REG
            //this.buttonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // labelHaveAcc
            // 
            this.labelHaveAcc.AutoSize = true;
            this.labelHaveAcc.Font = new System.Drawing.Font("Tw Cen MT Condensed", 12F, System.Drawing.FontStyle.Bold);
            this.labelHaveAcc.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelHaveAcc.Location = new System.Drawing.Point(14, 352);
            this.labelHaveAcc.Margin = new System.Windows.Forms.Padding(0);
            this.labelHaveAcc.Name = "labelHaveAcc";
            this.labelHaveAcc.Size = new System.Drawing.Size(156, 19);
            this.labelHaveAcc.TabIndex = 13;
            this.labelHaveAcc.Text = "Already have an account?";
            this.labelHaveAcc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelChangeToSignin
            // 
            this.labelChangeToSignin.AutoSize = true;
            this.labelChangeToSignin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelChangeToSignin.Font = new System.Drawing.Font("Tw Cen MT Condensed", 14F, System.Drawing.FontStyle.Bold);
            this.labelChangeToSignin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.labelChangeToSignin.Location = new System.Drawing.Point(170, 352);
            this.labelChangeToSignin.Margin = new System.Windows.Forms.Padding(0);
            this.labelChangeToSignin.Name = "labelChangeToSignin";
            this.labelChangeToSignin.Size = new System.Drawing.Size(114, 22);
            this.labelChangeToSignin.TabIndex = 14;
            this.labelChangeToSignin.Text = "Back to SIGN IN";
            this.labelChangeToSignin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //REG
            //this.labelChangeToSignin.Click += new System.EventHandler(this.LabelChangeToSignin_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanel1.Controls.Add(this.pictureBox2);
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(241, 21);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(580, 150);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::DreamCar.Properties.Resources.cardsBlueMain;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(153, 150);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tw Cen MT Condensed", 92F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(192)))), ((int)(((byte)(251)))));
            this.label1.Location = new System.Drawing.Point(153, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(427, 150);
            this.label1.TabIndex = 1;
            this.label1.Text = "DreamCar";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SignIn
            // 
            this.SignIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SignIn.Controls.Add(this.labelSignin);
            this.SignIn.Controls.Add(this.flowLayoutPanel5);
            this.SignIn.Location = new System.Drawing.Point(344, 211);
            this.SignIn.Margin = new System.Windows.Forms.Padding(2);
            this.SignIn.Name = "SignIn";
            this.SignIn.Size = new System.Drawing.Size(300, 355);
            this.SignIn.TabIndex = 17;
            this.SignIn.Visible = false;
            // 
            // labelSignin
            // 
            this.labelSignin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.labelSignin.Font = new System.Drawing.Font("Tw Cen MT Condensed", 24F, System.Drawing.FontStyle.Bold);
            this.labelSignin.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelSignin.Location = new System.Drawing.Point(2, 0);
            this.labelSignin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSignin.Name = "labelSignin";
            this.labelSignin.Size = new System.Drawing.Size(300, 46);
            this.labelSignin.TabIndex = 3;
            this.labelSignin.Text = "SIGN IN";
            this.labelSignin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(110)))));
            this.flowLayoutPanel5.Controls.Add(this.labelUsernameSignin);
            this.flowLayoutPanel5.Controls.Add(this.textBoxUsernameSignin);
            this.flowLayoutPanel5.Controls.Add(this.labelPasswordSignin);
            this.flowLayoutPanel5.Controls.Add(this.textBoxPasswordSignin);
            this.flowLayoutPanel5.Controls.Add(this.checkBoxShowPasswordSignin);
            this.flowLayoutPanel5.Controls.Add(this.buttonSignin);
            this.flowLayoutPanel5.Controls.Add(this.buttonClearSignin);
            this.flowLayoutPanel5.Controls.Add(this.labelDontHaveAcc);
            this.flowLayoutPanel5.Controls.Add(this.labelChangeToSignup);
            this.flowLayoutPanel5.Location = new System.Drawing.Point(0, 46);
            this.flowLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Padding = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.flowLayoutPanel5.Size = new System.Drawing.Size(300, 310);
            this.flowLayoutPanel5.TabIndex = 15;
            // 
            // labelUsernameSignin
            // 
            this.labelUsernameSignin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelUsernameSignin.AutoSize = true;
            this.labelUsernameSignin.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            this.labelUsernameSignin.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelUsernameSignin.Location = new System.Drawing.Point(14, 13);
            this.labelUsernameSignin.Margin = new System.Windows.Forms.Padding(0);
            this.labelUsernameSignin.Name = "labelUsernameSignin";
            this.labelUsernameSignin.Size = new System.Drawing.Size(97, 28);
            this.labelUsernameSignin.TabIndex = 4;
            this.labelUsernameSignin.Text = "Username";
            // 
            // textBoxUsernameSignin
            // 
            this.textBoxUsernameSignin.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxUsernameSignin.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            this.textBoxUsernameSignin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(93)))));
            this.textBoxUsernameSignin.Location = new System.Drawing.Point(14, 41);
            this.textBoxUsernameSignin.Margin = new System.Windows.Forms.Padding(0, 0, 0, 13);
            this.textBoxUsernameSignin.Name = "textBoxUsernameSignin";
            this.textBoxUsernameSignin.Size = new System.Drawing.Size(275, 33);
            this.textBoxUsernameSignin.TabIndex = 6;
            // 
            // labelPasswordSignin
            // 
            this.labelPasswordSignin.AutoSize = true;
            this.labelPasswordSignin.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            this.labelPasswordSignin.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelPasswordSignin.Location = new System.Drawing.Point(14, 87);
            this.labelPasswordSignin.Margin = new System.Windows.Forms.Padding(0);
            this.labelPasswordSignin.Name = "labelPasswordSignin";
            this.labelPasswordSignin.Size = new System.Drawing.Size(92, 28);
            this.labelPasswordSignin.TabIndex = 5;
            this.labelPasswordSignin.Text = "Password";
            // 
            // textBoxPasswordSignin
            // 
            this.textBoxPasswordSignin.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxPasswordSignin.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            this.textBoxPasswordSignin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(93)))));
            this.textBoxPasswordSignin.Location = new System.Drawing.Point(14, 115);
            this.textBoxPasswordSignin.Margin = new System.Windows.Forms.Padding(0, 0, 0, 13);
            this.textBoxPasswordSignin.Name = "textBoxPasswordSignin";
            this.textBoxPasswordSignin.PasswordChar = '●';
            this.textBoxPasswordSignin.Size = new System.Drawing.Size(275, 33);
            this.textBoxPasswordSignin.TabIndex = 7;
            // 
            // checkBoxShowPasswordSignin
            // 
            this.checkBoxShowPasswordSignin.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxShowPasswordSignin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxShowPasswordSignin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxShowPasswordSignin.Font = new System.Drawing.Font("Tw Cen MT Condensed", 12F, System.Drawing.FontStyle.Bold);
            this.checkBoxShowPasswordSignin.ForeColor = System.Drawing.Color.Gainsboro;
            this.checkBoxShowPasswordSignin.Location = new System.Drawing.Point(14, 161);
            this.checkBoxShowPasswordSignin.Margin = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.checkBoxShowPasswordSignin.Name = "checkBoxShowPasswordSignin";
            this.checkBoxShowPasswordSignin.Size = new System.Drawing.Size(273, 21);
            this.checkBoxShowPasswordSignin.TabIndex = 10;
            this.checkBoxShowPasswordSignin.Text = "Show Password";
            this.checkBoxShowPasswordSignin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxShowPasswordSignin.UseVisualStyleBackColor = true;
            //REG
            //this.checkBoxShowPasswordSignin.CheckedChanged += new System.EventHandler(this.CheckBoxShowPasswordSignin_CheckedChange);
            // 
            // buttonSignin
            // 
            this.buttonSignin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.buttonSignin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSignin.FlatAppearance.BorderSize = 0;
            this.buttonSignin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSignin.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            this.buttonSignin.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonSignin.Location = new System.Drawing.Point(14, 188);
            this.buttonSignin.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSignin.Name = "buttonSignin";
            this.buttonSignin.Size = new System.Drawing.Size(273, 39);
            this.buttonSignin.TabIndex = 11;
            this.buttonSignin.Text = "Sign in";
            this.buttonSignin.UseVisualStyleBackColor = false;
            //REG
            //this.buttonSignin.Click += new System.EventHandler(this.ButtonSignin_Click);
            // 
            // buttonClearSignin
            // 
            this.buttonClearSignin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(110)))));
            this.buttonClearSignin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClearSignin.FlatAppearance.BorderSize = 3;
            this.buttonClearSignin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClearSignin.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            this.buttonClearSignin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.buttonClearSignin.Location = new System.Drawing.Point(14, 233);
            this.buttonClearSignin.Margin = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.buttonClearSignin.Name = "buttonClearSignin";
            this.buttonClearSignin.Size = new System.Drawing.Size(273, 39);
            this.buttonClearSignin.TabIndex = 12;
            this.buttonClearSignin.Text = "Clear";
            this.buttonClearSignin.UseVisualStyleBackColor = false;
            //REG
            //this.buttonClearSignin.Click += new System.EventHandler(this.ButtonClearSignin);
            // 
            // labelDontHaveAcc
            // 
            this.labelDontHaveAcc.AutoSize = true;
            this.labelDontHaveAcc.Font = new System.Drawing.Font("Tw Cen MT Condensed", 12F, System.Drawing.FontStyle.Bold);
            this.labelDontHaveAcc.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelDontHaveAcc.Location = new System.Drawing.Point(14, 278);
            this.labelDontHaveAcc.Margin = new System.Windows.Forms.Padding(0);
            this.labelDontHaveAcc.Name = "labelDontHaveAcc";
            this.labelDontHaveAcc.Size = new System.Drawing.Size(142, 19);
            this.labelDontHaveAcc.TabIndex = 13;
            this.labelDontHaveAcc.Text = "Don\'t have an account?";
            this.labelDontHaveAcc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelChangeToSignup
            // 
            this.labelChangeToSignup.AutoSize = true;
            this.labelChangeToSignup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelChangeToSignup.Font = new System.Drawing.Font("Tw Cen MT Condensed", 14F, System.Drawing.FontStyle.Bold);
            this.labelChangeToSignup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.labelChangeToSignup.Location = new System.Drawing.Point(156, 278);
            this.labelChangeToSignup.Margin = new System.Windows.Forms.Padding(0);
            this.labelChangeToSignup.Name = "labelChangeToSignup";
            this.labelChangeToSignup.Size = new System.Drawing.Size(105, 22);
            this.labelChangeToSignup.TabIndex = 14;
            this.labelChangeToSignup.Text = "Go to SIGN UP";
            this.labelChangeToSignup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //REG
            //this.labelChangeToSignup.Click += new System.EventHandler(this.LabelChangeToSignup_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(93)))));
            this.ClientSize = new System.Drawing.Size(1267, 729);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(1283, 768);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DreamCar";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.SignUp.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.SignIn.ResumeLayout(false);
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button buttonCollection;
        private System.Windows.Forms.Button buttonProfile;
        private System.Windows.Forms.Button buttonPublish;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelDreamCar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button buttonTimes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelSignup;
        private System.Windows.Forms.TextBox textBoxConfirmPassword;
        private System.Windows.Forms.Label labelConfirmPassword;
        private System.Windows.Forms.Button buttonSignup;
        private System.Windows.Forms.CheckBox checkBoxShowPassword;
        private System.Windows.Forms.Label labelChangeToSignin;
        private System.Windows.Forms.Label labelHaveAcc;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel SignUp;
        private System.Windows.Forms.FlowLayoutPanel SignIn;
        private System.Windows.Forms.Label labelSignin;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.Label labelUsernameSignin;
        private System.Windows.Forms.TextBox textBoxUsernameSignin;
        private System.Windows.Forms.Label labelPasswordSignin;
        private System.Windows.Forms.TextBox textBoxPasswordSignin;
        private System.Windows.Forms.CheckBox checkBoxShowPasswordSignin;
        private System.Windows.Forms.Button buttonSignin;
        private System.Windows.Forms.Button buttonClearSignin;
        private System.Windows.Forms.Label labelDontHaveAcc;
        private System.Windows.Forms.Label labelChangeToSignup;

    }
}