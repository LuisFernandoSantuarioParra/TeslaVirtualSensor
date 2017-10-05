namespace PicWinUSB
{
    partial class PicWinUSB
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PicWinUSB));
            MetroSuite.MetroControlBox.MainColorScheme mainColorScheme4 = new MetroSuite.MetroControlBox.MainColorScheme();
            this.BarraSuperior = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.teslabutton = new Bunifu.Framework.UI.BunifuImageButton();
            this.metroControlBox1 = new MetroSuite.MetroControlBox();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.BarraSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teslabutton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // BarraSuperior
            // 
            this.BarraSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(33)))), ((int)(((byte)(49)))));
            this.BarraSuperior.Controls.Add(this.bunifuCustomLabel1);
            this.BarraSuperior.Controls.Add(this.teslabutton);
            this.BarraSuperior.Controls.Add(this.metroControlBox1);
            this.BarraSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraSuperior.Location = new System.Drawing.Point(0, 0);
            this.BarraSuperior.Name = "BarraSuperior";
            this.BarraSuperior.Size = new System.Drawing.Size(1192, 33);
            this.BarraSuperior.TabIndex = 0;
            this.BarraSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraSuperior_MouseDown);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(64, 1);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(121, 28);
            this.bunifuCustomLabel1.TabIndex = 2;
            this.bunifuCustomLabel1.Text = "Tesla Sensors";
            this.bunifuCustomLabel1.Click += new System.EventHandler(this.bunifuCustomLabel1_Click);
            // 
            // teslabutton
            // 
            this.teslabutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(33)))), ((int)(((byte)(49)))));
            this.teslabutton.Image = ((System.Drawing.Image)(resources.GetObject("teslabutton.Image")));
            this.teslabutton.ImageActive = null;
            this.teslabutton.Location = new System.Drawing.Point(15, 3);
            this.teslabutton.Name = "teslabutton";
            this.teslabutton.Size = new System.Drawing.Size(30, 30);
            this.teslabutton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.teslabutton.TabIndex = 1;
            this.teslabutton.TabStop = false;
            this.teslabutton.Zoom = 10;
            this.teslabutton.Click += new System.EventHandler(this.teslabutton_Click);
            // 
            // metroControlBox1
            // 
            this.metroControlBox1.BoxMaximize = false;
            mainColorScheme4.CloseColor = System.Drawing.Color.White;
            mainColorScheme4.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(33)))), ((int)(((byte)(49)))));
            mainColorScheme4.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(53)))), ((int)(((byte)(89)))));
            mainColorScheme4.MaximizeColor = System.Drawing.Color.Transparent;
            mainColorScheme4.MinimizeColor = System.Drawing.Color.White;
            mainColorScheme4.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(53)))), ((int)(((byte)(89)))));
            mainColorScheme4.SymbolHoverColor = System.Drawing.Color.White;
            mainColorScheme4.SymbolPressedColor = System.Drawing.Color.White;
            this.metroControlBox1.ColorScheme = mainColorScheme4;
            this.metroControlBox1.FormHeight = 0;
            this.metroControlBox1.FormWidth = 0;
            this.metroControlBox1.Location = new System.Drawing.Point(1070, 3);
            this.metroControlBox1.Name = "metroControlBox1";
            this.metroControlBox1.Size = new System.Drawing.Size(110, 26);
            this.metroControlBox1.TabIndex = 0;
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelContenedor.Location = new System.Drawing.Point(0, 32);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1192, 680);
            this.panelContenedor.TabIndex = 2;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Black;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(298, 171);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(586, 346);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 0;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // PicWinUSB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1192, 711);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.BarraSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PicWinUSB";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.BarraSuperior.ResumeLayout(false);
            this.BarraSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teslabutton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BarraSuperior;
        private MetroSuite.MetroControlBox metroControlBox1;
        private Bunifu.Framework.UI.BunifuImageButton teslabutton;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Panel panelContenedor;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
    }
}

