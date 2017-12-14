namespace GUI
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem_QuanLyBanHang = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_Thoat = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_DangXuat = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_BaoCao = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_BieuDo = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage_QuanLy = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup_PhanQuyen = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage_BanHang = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup_QuanLyBanSach = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup_TraCuu = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage_Kho = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup_CapNhatSach = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage_TongKet = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup_BaoCao = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup_BieuDo = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage_HeThong = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup_Thoat = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup_DangXuat = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.richTextLoad = new System.Windows.Forms.RichTextBox();
            this.barButtonItem_PhanQuyen = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.barButtonItem_QuanLyBanHang,
            this.barButtonItem_Thoat,
            this.barButtonItem_DangXuat,
            this.barButtonItem_BaoCao,
            this.barButtonItem_BieuDo,
            this.barButtonItem_PhanQuyen});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 7;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage_QuanLy,
            this.ribbonPage_BanHang,
            this.ribbonPage_Kho,
            this.ribbonPage_TongKet,
            this.ribbonPage_HeThong});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbonControl1.Size = new System.Drawing.Size(846, 162);
            // 
            // barButtonItem_QuanLyBanHang
            // 
            this.barButtonItem_QuanLyBanHang.Caption = "Quản Lý Bán Hàng";
            this.barButtonItem_QuanLyBanHang.Id = 1;
            this.barButtonItem_QuanLyBanHang.Name = "barButtonItem_QuanLyBanHang";
            this.barButtonItem_QuanLyBanHang.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_QuanLyBanHang_ItemClick);
            // 
            // barButtonItem_Thoat
            // 
            this.barButtonItem_Thoat.Caption = "Thoát";
            this.barButtonItem_Thoat.Id = 2;
            this.barButtonItem_Thoat.Name = "barButtonItem_Thoat";
            this.barButtonItem_Thoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_Thoat_ItemClick);
            // 
            // barButtonItem_DangXuat
            // 
            this.barButtonItem_DangXuat.Caption = "Đăng Xuất";
            this.barButtonItem_DangXuat.Id = 3;
            this.barButtonItem_DangXuat.Name = "barButtonItem_DangXuat";
            this.barButtonItem_DangXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_DangXuat_ItemClick);
            // 
            // barButtonItem_BaoCao
            // 
            this.barButtonItem_BaoCao.Caption = "Báo Cáo";
            this.barButtonItem_BaoCao.Id = 4;
            this.barButtonItem_BaoCao.Name = "barButtonItem_BaoCao";
            // 
            // barButtonItem_BieuDo
            // 
            this.barButtonItem_BieuDo.Caption = "Biểu Đồ";
            this.barButtonItem_BieuDo.Id = 5;
            this.barButtonItem_BieuDo.Name = "barButtonItem_BieuDo";
            this.barButtonItem_BieuDo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_BieuDo_ItemClick);
            // 
            // ribbonPage_QuanLy
            // 
            this.ribbonPage_QuanLy.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup_PhanQuyen});
            this.ribbonPage_QuanLy.Name = "ribbonPage_QuanLy";
            this.ribbonPage_QuanLy.Text = "Quản Lý";
            // 
            // ribbonPageGroup_PhanQuyen
            // 
            this.ribbonPageGroup_PhanQuyen.ItemLinks.Add(this.barButtonItem_PhanQuyen);
            this.ribbonPageGroup_PhanQuyen.Name = "ribbonPageGroup_PhanQuyen";
            this.ribbonPageGroup_PhanQuyen.Text = "Phân Quyền";
            // 
            // ribbonPage_BanHang
            // 
            this.ribbonPage_BanHang.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup_QuanLyBanSach,
            this.ribbonPageGroup_TraCuu});
            this.ribbonPage_BanHang.Name = "ribbonPage_BanHang";
            this.ribbonPage_BanHang.Text = "Bán Hàng";
            // 
            // ribbonPageGroup_QuanLyBanSach
            // 
            this.ribbonPageGroup_QuanLyBanSach.ItemLinks.Add(this.barButtonItem_QuanLyBanHang);
            this.ribbonPageGroup_QuanLyBanSach.Name = "ribbonPageGroup_QuanLyBanSach";
            this.ribbonPageGroup_QuanLyBanSach.Text = "Quản Lý Bán Hàng";
            // 
            // ribbonPageGroup_TraCuu
            // 
            this.ribbonPageGroup_TraCuu.Name = "ribbonPageGroup_TraCuu";
            this.ribbonPageGroup_TraCuu.Text = "Tra Cứu";
            // 
            // ribbonPage_Kho
            // 
            this.ribbonPage_Kho.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup_CapNhatSach});
            this.ribbonPage_Kho.Name = "ribbonPage_Kho";
            this.ribbonPage_Kho.Text = "Kho";
            // 
            // ribbonPageGroup_CapNhatSach
            // 
            this.ribbonPageGroup_CapNhatSach.Name = "ribbonPageGroup_CapNhatSach";
            this.ribbonPageGroup_CapNhatSach.Text = "Cập Nhật Sách";
            // 
            // ribbonPage_TongKet
            // 
            this.ribbonPage_TongKet.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup_BaoCao,
            this.ribbonPageGroup_BieuDo});
            this.ribbonPage_TongKet.Name = "ribbonPage_TongKet";
            this.ribbonPage_TongKet.Text = "Tổng Kết";
            // 
            // ribbonPageGroup_BaoCao
            // 
            this.ribbonPageGroup_BaoCao.ItemLinks.Add(this.barButtonItem_BaoCao);
            this.ribbonPageGroup_BaoCao.Name = "ribbonPageGroup_BaoCao";
            this.ribbonPageGroup_BaoCao.Text = "Báo Cáo";
            // 
            // ribbonPageGroup_BieuDo
            // 
            this.ribbonPageGroup_BieuDo.ItemLinks.Add(this.barButtonItem_BieuDo);
            this.ribbonPageGroup_BieuDo.Name = "ribbonPageGroup_BieuDo";
            this.ribbonPageGroup_BieuDo.Text = "Biểu Đồ";
            // 
            // ribbonPage_HeThong
            // 
            this.ribbonPage_HeThong.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup_Thoat,
            this.ribbonPageGroup_DangXuat});
            this.ribbonPage_HeThong.Name = "ribbonPage_HeThong";
            this.ribbonPage_HeThong.Text = "Hệ Thống";
            // 
            // ribbonPageGroup_Thoat
            // 
            this.ribbonPageGroup_Thoat.ItemLinks.Add(this.barButtonItem_Thoat);
            this.ribbonPageGroup_Thoat.Name = "ribbonPageGroup_Thoat";
            this.ribbonPageGroup_Thoat.Text = "Thoát";
            // 
            // ribbonPageGroup_DangXuat
            // 
            this.ribbonPageGroup_DangXuat.ItemLinks.Add(this.barButtonItem_DangXuat);
            this.ribbonPageGroup_DangXuat.Name = "ribbonPageGroup_DangXuat";
            this.ribbonPageGroup_DangXuat.Text = "Đăng Xuất";
            // 
            // timer1
            // 
            this.timer1.Interval = 300;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // richTextLoad
            // 
            this.richTextLoad.BackColor = System.Drawing.SystemColors.Control;
            this.richTextLoad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextLoad.Enabled = false;
            this.richTextLoad.Location = new System.Drawing.Point(0, 162);
            this.richTextLoad.Name = "richTextLoad";
            this.richTextLoad.Size = new System.Drawing.Size(846, 182);
            this.richTextLoad.TabIndex = 5;
            this.richTextLoad.Text = "";
            // 
            // barButtonItem_PhanQuyen
            // 
            this.barButtonItem_PhanQuyen.Caption = "Phân Quyền";
            this.barButtonItem_PhanQuyen.Description = "Phân Quyền Truy Cập Cho Các Tài Khoản";
            this.barButtonItem_PhanQuyen.Id = 6;
            this.barButtonItem_PhanQuyen.Name = "barButtonItem_PhanQuyen";
            this.barButtonItem_PhanQuyen.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_PhanQuyen_ItemClick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(846, 344);
            this.Controls.Add(this.richTextLoad);
            this.Controls.Add(this.ribbonControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage_BanHang;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup_QuanLyBanSach;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage_TongKet;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage_HeThong;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_QuanLyBanHang;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_Thoat;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_DangXuat;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup_Thoat;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup_DangXuat;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_BaoCao;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_BieuDo;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup_BaoCao;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup_BieuDo;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage_QuanLy;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup_PhanQuyen;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage_Kho;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup_CapNhatSach;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup_TraCuu;
        private System.Windows.Forms.RichTextBox richTextLoad;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_PhanQuyen;
    }
}