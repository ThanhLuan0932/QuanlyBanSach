namespace GUI
{
    partial class frmPhanQuyen
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
            this.cbTenTaiKhoan = new System.Windows.Forms.ComboBox();
            this.dtgDanhSachQuyen = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btLuuQuyen = new System.Windows.Forms.Button();
            this.cbQuyen_TongKet = new System.Windows.Forms.ComboBox();
            this.cbQuyen_Kho = new System.Windows.Forms.ComboBox();
            this.cbQuyen_BanHang = new System.Windows.Forms.ComboBox();
            this.cbQuyen_QuanLy = new System.Windows.Forms.ComboBox();
            this.btThayDoiQuyen = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btSuaQuyen_NhanVien = new System.Windows.Forms.Button();
            this.btSuaQuyen_ViTri = new System.Windows.Forms.Button();
            this.cbMaNV = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTenNhanVien = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDanhSachQuyen)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbTenTaiKhoan
            // 
            this.cbTenTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTenTaiKhoan.FormattingEnabled = true;
            this.cbTenTaiKhoan.Location = new System.Drawing.Point(602, 147);
            this.cbTenTaiKhoan.Name = "cbTenTaiKhoan";
            this.cbTenTaiKhoan.Size = new System.Drawing.Size(137, 33);
            this.cbTenTaiKhoan.TabIndex = 0;
            this.cbTenTaiKhoan.SelectedIndexChanged += new System.EventHandler(this.cbTenTaiKhoan_SelectedIndexChanged);
            this.cbTenTaiKhoan.SelectedValueChanged += new System.EventHandler(this.cbTenTaiKhoan_SelectedValueChanged);
            this.cbTenTaiKhoan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbTenTaiKhoan_KeyPress);
            // 
            // dtgDanhSachQuyen
            // 
            this.dtgDanhSachQuyen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDanhSachQuyen.Location = new System.Drawing.Point(6, 229);
            this.dtgDanhSachQuyen.Name = "dtgDanhSachQuyen";
            this.dtgDanhSachQuyen.ReadOnly = true;
            this.dtgDanhSachQuyen.RowTemplate.Height = 24;
            this.dtgDanhSachQuyen.Size = new System.Drawing.Size(621, 122);
            this.dtgDanhSachQuyen.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtgDanhSachQuyen);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btLuuQuyen);
            this.groupBox1.Controls.Add(this.cbQuyen_TongKet);
            this.groupBox1.Controls.Add(this.cbQuyen_Kho);
            this.groupBox1.Controls.Add(this.cbQuyen_BanHang);
            this.groupBox1.Controls.Add(this.cbQuyen_QuanLy);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(341, 266);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(633, 351);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Các Quyền";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(172, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(336, 48);
            this.label5.TabIndex = 13;
            this.label5.Text = "< Ghi Chú : true\\có quyền \r\n                  false\\không có quyền >";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(432, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "Tổng Kết";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(353, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "Kho";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(234, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "Bán Hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(123, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Quản Lý";
            // 
            // btLuuQuyen
            // 
            this.btLuuQuyen.Location = new System.Drawing.Point(238, 164);
            this.btLuuQuyen.Name = "btLuuQuyen";
            this.btLuuQuyen.Size = new System.Drawing.Size(145, 59);
            this.btLuuQuyen.TabIndex = 8;
            this.btLuuQuyen.Text = "Lưu Lại";
            this.btLuuQuyen.UseVisualStyleBackColor = true;
            this.btLuuQuyen.Click += new System.EventHandler(this.btLuuQuyen_Click);
            // 
            // cbQuyen_TongKet
            // 
            this.cbQuyen_TongKet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbQuyen_TongKet.FormattingEnabled = true;
            this.cbQuyen_TongKet.Items.AddRange(new object[] {
            "true",
            "false"});
            this.cbQuyen_TongKet.Location = new System.Drawing.Point(445, 106);
            this.cbQuyen_TongKet.Name = "cbQuyen_TongKet";
            this.cbQuyen_TongKet.Size = new System.Drawing.Size(72, 33);
            this.cbQuyen_TongKet.TabIndex = 6;
            this.cbQuyen_TongKet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbQuyen_QuanLy_KeyPress);
            // 
            // cbQuyen_Kho
            // 
            this.cbQuyen_Kho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbQuyen_Kho.FormattingEnabled = true;
            this.cbQuyen_Kho.Items.AddRange(new object[] {
            "true",
            "false"});
            this.cbQuyen_Kho.Location = new System.Drawing.Point(340, 106);
            this.cbQuyen_Kho.Name = "cbQuyen_Kho";
            this.cbQuyen_Kho.Size = new System.Drawing.Size(72, 33);
            this.cbQuyen_Kho.TabIndex = 5;
            this.cbQuyen_Kho.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbQuyen_QuanLy_KeyPress);
            // 
            // cbQuyen_BanHang
            // 
            this.cbQuyen_BanHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbQuyen_BanHang.FormattingEnabled = true;
            this.cbQuyen_BanHang.Items.AddRange(new object[] {
            "true",
            "false"});
            this.cbQuyen_BanHang.Location = new System.Drawing.Point(238, 106);
            this.cbQuyen_BanHang.Name = "cbQuyen_BanHang";
            this.cbQuyen_BanHang.Size = new System.Drawing.Size(72, 33);
            this.cbQuyen_BanHang.TabIndex = 4;
            this.cbQuyen_BanHang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbQuyen_QuanLy_KeyPress);
            // 
            // cbQuyen_QuanLy
            // 
            this.cbQuyen_QuanLy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbQuyen_QuanLy.FormattingEnabled = true;
            this.cbQuyen_QuanLy.Items.AddRange(new object[] {
            "true",
            "false"});
            this.cbQuyen_QuanLy.Location = new System.Drawing.Point(139, 106);
            this.cbQuyen_QuanLy.Name = "cbQuyen_QuanLy";
            this.cbQuyen_QuanLy.Size = new System.Drawing.Size(72, 33);
            this.cbQuyen_QuanLy.TabIndex = 3;
            this.cbQuyen_QuanLy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbQuyen_QuanLy_KeyPress);
            // 
            // btThayDoiQuyen
            // 
            this.btThayDoiQuyen.Location = new System.Drawing.Point(762, 147);
            this.btThayDoiQuyen.Name = "btThayDoiQuyen";
            this.btThayDoiQuyen.Size = new System.Drawing.Size(145, 72);
            this.btThayDoiQuyen.TabIndex = 7;
            this.btThayDoiQuyen.Text = "Thay Đổi Quyền";
            this.btThayDoiQuyen.UseVisualStyleBackColor = true;
            this.btThayDoiQuyen.Click += new System.EventHandler(this.btThayDoiQuyen_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(435, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "Chọn Tài Khoản";
            // 
            // btSuaQuyen_NhanVien
            // 
            this.btSuaQuyen_NhanVien.Location = new System.Drawing.Point(669, 57);
            this.btSuaQuyen_NhanVien.Name = "btSuaQuyen_NhanVien";
            this.btSuaQuyen_NhanVien.Size = new System.Drawing.Size(145, 59);
            this.btSuaQuyen_NhanVien.TabIndex = 11;
            this.btSuaQuyen_NhanVien.Text = "Sửa Quyền Truy Cập Của Nhân Viên";
            this.btSuaQuyen_NhanVien.UseVisualStyleBackColor = true;
            this.btSuaQuyen_NhanVien.Click += new System.EventHandler(this.btSuaQuyen_NhanVien_Click);
            // 
            // btSuaQuyen_ViTri
            // 
            this.btSuaQuyen_ViTri.Location = new System.Drawing.Point(506, 57);
            this.btSuaQuyen_ViTri.Name = "btSuaQuyen_ViTri";
            this.btSuaQuyen_ViTri.Size = new System.Drawing.Size(145, 59);
            this.btSuaQuyen_ViTri.TabIndex = 12;
            this.btSuaQuyen_ViTri.Text = "Sửa Quyền Truy Cập Theo Vị Trí";
            this.btSuaQuyen_ViTri.UseVisualStyleBackColor = true;
            this.btSuaQuyen_ViTri.Click += new System.EventHandler(this.btSuaQuyen_ViTri_Click);
            // 
            // cbMaNV
            // 
            this.cbMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaNV.FormattingEnabled = true;
            this.cbMaNV.Location = new System.Drawing.Point(602, 186);
            this.cbMaNV.Name = "cbMaNV";
            this.cbMaNV.Size = new System.Drawing.Size(137, 33);
            this.cbMaNV.TabIndex = 13;
            this.cbMaNV.SelectedIndexChanged += new System.EventHandler(this.cbMaNV_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(397, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(199, 24);
            this.label7.TabIndex = 14;
            this.label7.Text = "Chọn Mã Nhân Viên";
            // 
            // txtTenNhanVien
            // 
            this.txtTenNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNhanVien.Location = new System.Drawing.Point(531, 225);
            this.txtTenNhanVien.Name = "txtTenNhanVien";
            this.txtTenNhanVien.Size = new System.Drawing.Size(208, 27);
            this.txtTenNhanVien.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(326, 223);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 24);
            this.label8.TabIndex = 16;
            this.label8.Text = "Tên Nhân Viên";
            // 
            // frmPhanQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 733);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTenNhanVien);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbMaNV);
            this.Controls.Add(this.btSuaQuyen_ViTri);
            this.Controls.Add(this.btSuaQuyen_NhanVien);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbTenTaiKhoan);
            this.Controls.Add(this.btThayDoiQuyen);
            this.Name = "frmPhanQuyen";
            this.Text = "frmPhanQuyen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPhanQuyen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDanhSachQuyen)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbTenTaiKhoan;
        private System.Windows.Forms.DataGridView dtgDanhSachQuyen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbQuyen_TongKet;
        private System.Windows.Forms.ComboBox cbQuyen_Kho;
        private System.Windows.Forms.ComboBox cbQuyen_BanHang;
        private System.Windows.Forms.ComboBox cbQuyen_QuanLy;
        private System.Windows.Forms.Button btThayDoiQuyen;
        private System.Windows.Forms.Button btLuuQuyen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btSuaQuyen_NhanVien;
        private System.Windows.Forms.Button btSuaQuyen_ViTri;
        private System.Windows.Forms.ComboBox cbMaNV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTenNhanVien;
        private System.Windows.Forms.Label label8;
    }
}