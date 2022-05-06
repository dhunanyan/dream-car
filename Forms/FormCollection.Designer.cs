namespace DreamCar.Forms
{
    public partial class FormCollection
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMain = new System.Windows.Forms.Panel();
            this.flowLayoutPanelCarCollection = new System.Windows.Forms.FlowLayoutPanel();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.flowLayoutPanelCarCollection);
            this.panelMain.Location = new System.Drawing.Point(10, 11);
            this.panelMain.Margin = new System.Windows.Forms.Padding(0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1050, 690);
            this.panelMain.TabIndex = 1;
            // 
            // FormCollection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(93)))));
            this.ClientSize = new System.Drawing.Size(1071, 711);
            this.Controls.Add(this.panelMain);
            this.Name = "FormCollection";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "FormCollection";
            this.panelMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelCarCollection;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelCurrentCar;
        private System.Windows.Forms.Panel panelCurrentCarImage;
        private System.Windows.Forms.Label labelCurrentCarBrand;
        private System.Windows.Forms.Label labelCurrentCarModel;
        private System.Windows.Forms.Label labelCurrentCarProdYear;
        private System.Windows.Forms.Label labelCurrentCarFuel;
        private System.Windows.Forms.Label labelCurrentCarGearbox; 
        private System.Windows.Forms.Button buttonCurrentCarFav;
        private System.Windows.Forms.Button buttonCurrentCarMore;
    }
}