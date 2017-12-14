using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            ribbonPage_QuanLy.Visible = frmDangNhap.PQ_QuanLy;
            ribbonPage_BanHang.Visible = frmDangNhap.PQ_BanHang;
            ribbonPage_Kho.Visible = frmDangNhap.PQ_Kho;
            ribbonPage_TongKet.Visible = frmDangNhap.PQ_TongKet;
        }
        private bool CheckExistForm(String name)
        {
            bool check = false;
            foreach (Form frm in this.MdiChildren)
            {

                if (frm.Name == name)
                {
                    check = true;
                }

            }
            return check;

        }
        private void ActiveChildForm(String name)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == name)
                {
                    frm.Activate();
                    break;
                }
            }
        }
        public void ThoatChuongTrinh()
        {
            DialogResult dr;
            dr = MessageBox.Show("  Thoát Khỏi Ứng Dụng ?", "Thông Báo", MessageBoxButtons.OKCancel);

            if (dr == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void barButtonItem_QuanLyBanHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            timer1.Start();
            if (!CheckExistForm("frmBanSach"))
            {
                frmBanSach bansach = new frmBanSach();
                bansach.MdiParent = this;
                bansach.Show();
            }
            else
            {
                ActiveChildForm("frmBanSach");
            }
        }

        private void barButtonItem_DangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
            frmDangNhap dn = new frmDangNhap();
            dn.Show();
        }

        private void barButtonItem_Thoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ThoatChuongTrinh();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            richTextLoad.Visible = false;
        }

        private void barButtonItem_BieuDo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            timer1.Start();
            if (!CheckExistForm("frmDoThiCot"))
            {
                frmDoThiCot dothi = new frmDoThiCot();
                dothi.MdiParent = this;
                dothi.Show();
            }
            else
            {
                ActiveChildForm("frmDoThiCot");
            }
        }

        private void barButtonItem_PhanQuyen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            timer1.Start();
            if (!CheckExistForm("frmPhanQuyen"))
            {
                frmPhanQuyen phanquyen = new frmPhanQuyen();
                phanquyen.MdiParent = this;
                phanquyen.Show();
            }
            else
            {
                ActiveChildForm("frmPhanQuyen");
            }
        }

        

       
    }
}
