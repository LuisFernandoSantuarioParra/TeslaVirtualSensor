namespace PicWinUSB
{
    partial class Humedad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Humedad));
            this.bunifuCircleProgressbar1 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuiOSSwitch1 = new Bunifu.Framework.UI.BunifuiOSSwitch();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCircleProgressbar1
            // 
            this.bunifuCircleProgressbar1.animated = false;
            this.bunifuCircleProgressbar1.animationIterval = 5;
            this.bunifuCircleProgressbar1.animationSpeed = 300;
            this.bunifuCircleProgressbar1.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuCircleProgressbar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCircleProgressbar1.BackgroundImage")));
            this.bunifuCircleProgressbar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.bunifuCircleProgressbar1.ForeColor = System.Drawing.Color.Blue;
            this.bunifuCircleProgressbar1.LabelVisible = true;
            this.bunifuCircleProgressbar1.LineProgressThickness = 15;
            this.bunifuCircleProgressbar1.LineThickness = 20;
            this.bunifuCircleProgressbar1.Location = new System.Drawing.Point(29, 76);
            this.bunifuCircleProgressbar1.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuCircleProgressbar1.MaxValue = 100;
            this.bunifuCircleProgressbar1.Name = "bunifuCircleProgressbar1";
            this.bunifuCircleProgressbar1.Padding = new System.Windows.Forms.Padding(0, 5, 5, 5);
            this.bunifuCircleProgressbar1.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.bunifuCircleProgressbar1.ProgressColor = System.Drawing.Color.Blue;
            this.bunifuCircleProgressbar1.Size = new System.Drawing.Size(414, 414);
            this.bunifuCircleProgressbar1.TabIndex = 0;
            this.bunifuCircleProgressbar1.Value = 0;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuImageButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.BackgroundImage")));
            this.bunifuImageButton1.Enabled = false;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(273, 250);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(50, 58);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 1;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // bunifuiOSSwitch1
            // 
            this.bunifuiOSSwitch1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuiOSSwitch1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuiOSSwitch1.BackgroundImage")));
            this.bunifuiOSSwitch1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuiOSSwitch1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuiOSSwitch1.Location = new System.Drawing.Point(585, 144);
            this.bunifuiOSSwitch1.Name = "bunifuiOSSwitch1";
            this.bunifuiOSSwitch1.OffColor = System.Drawing.Color.Gray;
            this.bunifuiOSSwitch1.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(202)))), ((int)(((byte)(94)))));
            this.bunifuiOSSwitch1.Size = new System.Drawing.Size(43, 25);
            this.bunifuiOSSwitch1.TabIndex = 2;
            this.bunifuiOSSwitch1.Value = false;
            this.bunifuiOSSwitch1.OnValueChange += new System.EventHandler(this.bunifuiOSSwitch1_OnValueChange);
            // 
            // Humedad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 554);
            this.Controls.Add(this.bunifuiOSSwitch1);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.bunifuCircleProgressbar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Humedad";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCircleProgressbar bunifuCircleProgressbar1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuiOSSwitch bunifuiOSSwitch1;
    }
}