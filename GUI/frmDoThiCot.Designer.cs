namespace GUI
{
    partial class frmDoThiCot
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
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cbChon = new System.Windows.Forms.ComboBox();
            this.cbThoiGian = new System.Windows.Forms.ComboBox();
            this.cbSapXep = new System.Windows.Forms.ComboBox();
            this.btLoc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Area3DStyle.Enable3D = true;
            chartArea1.Area3DStyle.Inclination = 10;
            chartArea1.Area3DStyle.PointDepth = 20;
            chartArea1.Area3DStyle.PointGapDepth = 20;
            chartArea1.Area3DStyle.WallWidth = 5;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.BorderColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 91);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            this.chart1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = ".";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1432, 604);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // cbChon
            // 
            this.cbChon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbChon.FormattingEnabled = true;
            this.cbChon.Items.AddRange(new object[] {
            "Doanh Thu",
            "Số Lượng Bán Ra"});
            this.cbChon.Location = new System.Drawing.Point(81, 52);
            this.cbChon.Name = "cbChon";
            this.cbChon.Size = new System.Drawing.Size(242, 33);
            this.cbChon.TabIndex = 1;
            // 
            // cbThoiGian
            // 
            this.cbThoiGian.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbThoiGian.FormattingEnabled = true;
            this.cbThoiGian.Items.AddRange(new object[] {
            "Tháng",
            "Năm",
            "Các Loại Sách",
            "Thể Loại"});
            this.cbThoiGian.Location = new System.Drawing.Point(370, 52);
            this.cbThoiGian.Name = "cbThoiGian";
            this.cbThoiGian.Size = new System.Drawing.Size(242, 33);
            this.cbThoiGian.TabIndex = 2;
            // 
            // cbSapXep
            // 
            this.cbSapXep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSapXep.FormattingEnabled = true;
            this.cbSapXep.Items.AddRange(new object[] {
            "Top Cao Nhất",
            "Top Thấp Nhất"});
            this.cbSapXep.Location = new System.Drawing.Point(667, 52);
            this.cbSapXep.Name = "cbSapXep";
            this.cbSapXep.Size = new System.Drawing.Size(242, 33);
            this.cbSapXep.TabIndex = 3;
            // 
            // btLoc
            // 
            this.btLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLoc.Location = new System.Drawing.Point(963, 52);
            this.btLoc.Name = "btLoc";
            this.btLoc.Size = new System.Drawing.Size(95, 32);
            this.btLoc.TabIndex = 4;
            this.btLoc.Text = "Lọc";
            this.btLoc.UseVisualStyleBackColor = true;
            this.btLoc.Click += new System.EventHandler(this.btLoc_Click);
            // 
            // frmDoThiCot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 733);
            this.Controls.Add(this.btLoc);
            this.Controls.Add(this.cbSapXep);
            this.Controls.Add(this.cbThoiGian);
            this.Controls.Add(this.cbChon);
            this.Controls.Add(this.chart1);
            this.Name = "frmDoThiCot";
            this.Text = "frmDoThiCot";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ComboBox cbChon;
        private System.Windows.Forms.ComboBox cbThoiGian;
        private System.Windows.Forms.ComboBox cbSapXep;
        private System.Windows.Forms.Button btLoc;
    }
}