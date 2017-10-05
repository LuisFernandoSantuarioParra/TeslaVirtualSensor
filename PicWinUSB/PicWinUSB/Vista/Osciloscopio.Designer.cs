namespace PicWinUSB
{
    partial class Osciloscopio
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
            MetroSuite.MetroButton.MainColorScheme mainColorScheme1 = new MetroSuite.MetroButton.MainColorScheme();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.metroButton1 = new MetroSuite.MetroButton();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.metroLabelHeader1 = new MetroSuite.MetroLabelHeader();
            this.metroLabelHeader2 = new MetroSuite.MetroLabelHeader();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // metroButton1
            // 
            mainColorScheme1.AccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(164)))), ((int)(((byte)(240)))));
            mainColorScheme1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            mainColorScheme1.FillColor = System.Drawing.Color.White;
            mainColorScheme1.HoverFillColor = System.Drawing.Color.White;
            mainColorScheme1.PressAccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            mainColorScheme1.PressFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.metroButton1.ColorScheme = mainColorScheme1;
            this.metroButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.metroButton1.ForeColor = System.Drawing.Color.Black;
            this.metroButton1.Location = new System.Drawing.Point(741, 537);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(105, 27);
            this.metroButton1.TabIndex = 1;
            this.metroButton1.Text = "Autoset";
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // chart
            // 
            this.chart.BackColor = System.Drawing.SystemColors.Control;
            this.chart.BorderlineColor = System.Drawing.SystemColors.Control;
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(88, 38);
            this.chart.Name = "chart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.LabelBackColor = System.Drawing.SystemColors.Control;
            series1.LabelBorderColor = System.Drawing.SystemColors.Control;
            series1.Legend = "Legend1";
            series1.Name = "CH1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "CH2";
            this.chart.Series.Add(series1);
            this.chart.Series.Add(series2);
            this.chart.Size = new System.Drawing.Size(785, 448);
            this.chart.TabIndex = 2;
            this.chart.Text = "chart1";
            // 
            // metroLabelHeader1
            // 
            this.metroLabelHeader1.AutoSize = true;
            this.metroLabelHeader1.Font = new System.Drawing.Font("Segoe UI Light", 16F);
            this.metroLabelHeader1.ForeColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(164)))), ((int)(((byte)(240)))));
            this.metroLabelHeader1.ForeColorNormal = System.Drawing.Color.Black;
            this.metroLabelHeader1.Location = new System.Drawing.Point(83, 5);
            this.metroLabelHeader1.Name = "metroLabelHeader1";
            this.metroLabelHeader1.Size = new System.Drawing.Size(82, 30);
            this.metroLabelHeader1.TabIndex = 3;
            this.metroLabelHeader1.Text = "Voltage";
            this.metroLabelHeader1.UseHoverMode = false;
            // 
            // metroLabelHeader2
            // 
            this.metroLabelHeader2.AutoSize = true;
            this.metroLabelHeader2.Font = new System.Drawing.Font("Segoe UI Light", 16F);
            this.metroLabelHeader2.ForeColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(164)))), ((int)(((byte)(240)))));
            this.metroLabelHeader2.ForeColorNormal = System.Drawing.Color.Black;
            this.metroLabelHeader2.Location = new System.Drawing.Point(692, 476);
            this.metroLabelHeader2.Name = "metroLabelHeader2";
            this.metroLabelHeader2.Size = new System.Drawing.Size(58, 30);
            this.metroLabelHeader2.TabIndex = 4;
            this.metroLabelHeader2.Text = "Time";
            this.metroLabelHeader2.UseHoverMode = false;
            // 
            // Osciloscopio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 593);
            this.Controls.Add(this.metroLabelHeader2);
            this.Controls.Add(this.metroLabelHeader1);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.metroButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Osciloscopio";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Osciloscopio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroSuite.MetroButton metroButton1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private MetroSuite.MetroLabelHeader metroLabelHeader1;
        private MetroSuite.MetroLabelHeader metroLabelHeader2;
    }
}