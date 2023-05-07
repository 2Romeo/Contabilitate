namespace PawContabilitate
{
    partial class Charts_Conturi
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chr_TopCred = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chr_TopDeb = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btn_print = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chr_TopCred)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chr_TopDeb)).BeginInit();
            this.SuspendLayout();
            // 
            // chr_TopCred
            // 
            chartArea1.Name = "ChartArea1";
            this.chr_TopCred.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chr_TopCred.Legends.Add(legend1);
            this.chr_TopCred.Location = new System.Drawing.Point(30, 142);
            this.chr_TopCred.Name = "chr_TopCred";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series1.Legend = "Legend1";
            series1.Name = "U.m.";
            this.chr_TopCred.Series.Add(series1);
            this.chr_TopCred.Size = new System.Drawing.Size(469, 267);
            this.chr_TopCred.TabIndex = 1;
            this.chr_TopCred.Text = "chart2";
            title1.Name = "Title1";
            title1.Text = "Top solduri creditoare";
            title2.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title2.Name = "Title2";
            title2.Text = "id cont";
            this.chr_TopCred.Titles.Add(title1);
            this.chr_TopCred.Titles.Add(title2);
            // 
            // chr_TopDeb
            // 
            chartArea2.Name = "ChartArea1";
            this.chr_TopDeb.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chr_TopDeb.Legends.Add(legend2);
            this.chr_TopDeb.Location = new System.Drawing.Point(555, 142);
            this.chr_TopDeb.Name = "chr_TopDeb";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series2.Legend = "Legend1";
            series2.Name = "U.m.";
            this.chr_TopDeb.Series.Add(series2);
            this.chr_TopDeb.Size = new System.Drawing.Size(469, 267);
            this.chr_TopDeb.TabIndex = 3;
            title3.Name = "Title1";
            title3.Text = "Top solduri debitoare";
            title4.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title4.Name = "Title2";
            title4.Text = "id cont";
            this.chr_TopDeb.Titles.Add(title3);
            this.chr_TopDeb.Titles.Add(title4);
            // 
            // btn_print
            // 
            this.btn_print.Location = new System.Drawing.Point(493, 415);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(75, 23);
            this.btn_print.TabIndex = 4;
            this.btn_print.Text = "Print";
            this.btn_print.UseVisualStyleBackColor = true;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // Charts_Conturi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 590);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.chr_TopDeb);
            this.Controls.Add(this.chr_TopCred);
            this.Name = "Charts_Conturi";
            this.Text = "Charts_Conturi";
            this.Load += new System.EventHandler(this.Charts_Conturi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chr_TopCred)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chr_TopDeb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chr_TopCred;
        private System.Windows.Forms.DataVisualization.Charting.Chart chr_TopDeb;
        private System.Windows.Forms.Button btn_print;
    }
}