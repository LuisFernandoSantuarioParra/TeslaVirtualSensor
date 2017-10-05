namespace PicWinUSB
{
    partial class Termometro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Termometro));
            this.bunifuProgressBar1 = new Bunifu.Framework.UI.BunifuProgressBar();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuiOSSwitch1 = new Bunifu.Framework.UI.BunifuiOSSwitch();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuProgressBar1
            // 
            this.bunifuProgressBar1.BackColor = System.Drawing.Color.Silver;
            this.bunifuProgressBar1.BorderRadius = 25;
            this.bunifuProgressBar1.Location = new System.Drawing.Point(91, 76);
            this.bunifuProgressBar1.MaximumValue = 100;
            this.bunifuProgressBar1.Name = "bunifuProgressBar1";
            this.bunifuProgressBar1.ProgressColor = System.Drawing.Color.OrangeRed;
            this.bunifuProgressBar1.Size = new System.Drawing.Size(672, 42);
            this.bunifuProgressBar1.TabIndex = 0;
            this.bunifuProgressBar1.Value = 0;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuImageButton1.Enabled = false;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(23, 67);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(58, 59);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 2;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuImageButton2.Enabled = false;
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(773, 64);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(68, 67);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 3;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            // 
            // bunifuiOSSwitch1
            // 
            this.bunifuiOSSwitch1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuiOSSwitch1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuiOSSwitch1.BackgroundImage")));
            this.bunifuiOSSwitch1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuiOSSwitch1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuiOSSwitch1.Location = new System.Drawing.Point(640, 167);
            this.bunifuiOSSwitch1.Name = "bunifuiOSSwitch1";
            this.bunifuiOSSwitch1.OffColor = System.Drawing.Color.Gray;
            this.bunifuiOSSwitch1.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(202)))), ((int)(((byte)(94)))));
            this.bunifuiOSSwitch1.Size = new System.Drawing.Size(43, 25);
            this.bunifuiOSSwitch1.TabIndex = 4;
            this.bunifuiOSSwitch1.Value = false;
            this.bunifuiOSSwitch1.OnValueChange += new System.EventHandler(this.bunifuiOSSwitch1_OnValueChange_1);
            // 
            // Termometro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 554);
            this.Controls.Add(this.bunifuiOSSwitch1);
            this.Controls.Add(this.bunifuImageButton2);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.bunifuProgressBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Termometro";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuProgressBar bunifuProgressBar1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Bunifu.Framework.UI.BunifuiOSSwitch bunifuiOSSwitch1;
    }
}