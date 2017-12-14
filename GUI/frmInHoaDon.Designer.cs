namespace GUI
{
    partial class frmInHoaDon
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.GioHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QL_BanSachDataSet = new GUI.QL_BanSachDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.GioHangTableAdapter = new GUI.QL_BanSachDataSetTableAdapters.GioHangTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.GioHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QL_BanSachDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // GioHangBindingSource
            // 
            this.GioHangBindingSource.DataMember = "GioHang";
            this.GioHangBindingSource.DataSource = this.QL_BanSachDataSet;
            // 
            // QL_BanSachDataSet
            // 
            this.QL_BanSachDataSet.DataSetName = "QL_BanSachDataSet";
            this.QL_BanSachDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.GioHangBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GUI.InHoaDon.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(672, 703);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // GioHangTableAdapter
            // 
            this.GioHangTableAdapter.ClearBeforeFill = true;
            // 
            // frmInHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 703);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmInHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmInHoaDon";
            this.Load += new System.EventHandler(this.frmInHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GioHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QL_BanSachDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource GioHangBindingSource;
        private QL_BanSachDataSet QL_BanSachDataSet;
        private QL_BanSachDataSetTableAdapters.GioHangTableAdapter GioHangTableAdapter;
    }
}