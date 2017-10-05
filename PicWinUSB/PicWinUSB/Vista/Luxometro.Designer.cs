namespace PicWinUSB
{
    partial class Luxometro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Luxometro));
            this.bunifuiOSSwitch1 = new Bunifu.Framework.UI.BunifuiOSSwitch();
            this.gCircleChart1 = new GChartLib.GCircleChart();
            this.metroLabelHeader2 = new MetroSuite.MetroLabelHeader();
            this.SuspendLayout();
            // 
            // bunifuiOSSwitch1
            // 
            this.bunifuiOSSwitch1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuiOSSwitch1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuiOSSwitch1.BackgroundImage")));
            this.bunifuiOSSwitch1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuiOSSwitch1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuiOSSwitch1.Location = new System.Drawing.Point(694, 149);
            this.bunifuiOSSwitch1.Name = "bunifuiOSSwitch1";
            this.bunifuiOSSwitch1.OffColor = System.Drawing.Color.Gray;
            this.bunifuiOSSwitch1.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(202)))), ((int)(((byte)(94)))));
            this.bunifuiOSSwitch1.Size = new System.Drawing.Size(43, 25);
            this.bunifuiOSSwitch1.TabIndex = 3;
            this.bunifuiOSSwitch1.Value = false;
            this.bunifuiOSSwitch1.OnValueChange += new System.EventHandler(this.bunifuiOSSwitch1_OnValueChange);
            // 
            // gCircleChart1
            // 
            this.gCircleChart1.CircleBorderColor = System.Drawing.Color.Gray;
            this.gCircleChart1.CircleColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gCircleChart1.DrawCircleBorder = true;
            this.gCircleChart1.DrawDataNames = true;
            this.gCircleChart1.Location = new System.Drawing.Point(70, 51);
            this.gCircleChart1.Name = "gCircleChart1";
            this.gCircleChart1.Size = new System.Drawing.Size(500, 500);
            this.gCircleChart1.TabIndex = 4;
            // 
            // metroLabelHeader2
            // 
            this.metroLabelHeader2.AutoSize = true;
            this.metroLabelHeader2.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.metroLabelHeader2.ForeColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(164)))), ((int)(((byte)(240)))));
            this.metroLabelHeader2.ForeColorNormal = System.Drawing.Color.Black;
            this.metroLabelHeader2.Location = new System.Drawing.Point(681, 125);
            this.metroLabelHeader2.Name = "metroLabelHeader2";
            this.metroLabelHeader2.Size = new System.Drawing.Size(73, 21);
            this.metroLabelHeader2.TabIndex = 16;
            this.metroLabelHeader2.Text = "ON / OFF";
            this.metroLabelHeader2.UseHoverMode = false;
            // 
            // Luxometro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 593);
            this.Controls.Add(this.metroLabelHeader2);
            this.Controls.Add(this.gCircleChart1);
            this.Controls.Add(this.bunifuiOSSwitch1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Luxometro";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuiOSSwitch bunifuiOSSwitch1;
        private GChartLib.GCircleChart gCircleChart1;
        private MetroSuite.MetroLabelHeader metroLabelHeader2;
    }
}