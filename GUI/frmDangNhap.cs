using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using DTO;
using BUS;

namespace GUI
{
    public partial class frmDangNhap : Form
    {
        BUS_DangNhap xldl = new BUS_DangNhap();
        DuLieu_DangNhap dl = new DuLieu_DangNhap();
        public frmDangNhap()
        {
            InitializeComponent();
        }
        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            dtgDangNhap.DataSource = xldl.DangNhap_Select(dl);
        }
        public void KiemTra_Quyen()
        {
            txtTaiKhoan.DataBindings.Clear();
            txtTaiKhoan.DataBindings.Add("Text", dtgDangNhap.DataSource, "TaiKhoan");
            txtQuanLy.DataBindings.Clear();
            txtQuanLy.DataBindings.Add("Text", xldl.QuanLy_PQ(dl), "QuanLy");
            txtBanHang.DataBindings.Clear();
            txtBanHang.DataBindings.Add("Text", xldl.BanHang_PQ(dl), "BanHang");
            txtKho.DataBindings.Clear();
            txtKho.DataBindings.Add("Text", xldl.Kho_PQ(dl), "Kho");
            txtTongKet.DataBindings.Clear();
            txtTongKet.DataBindings.Add("Text", xldl.TongKet_PQ(dl), "TongKet");
        }
        public static Boolean PQ_QuanLy;
        public static Boolean PQ_BanHang;
        public static Boolean PQ_Kho;
        public static Boolean PQ_TongKet;//biến login phân quyền
        public static string MaNV;
        public void DangNhap()
        {
            MaNV = txtMaNV.Text;
            dl.TaiKhoan = cbTaiKhoan.Text;//ta gán phương thức nhập của txtuser vào Tai khoan
            dl.MaNV = txtMaNV.Text;

            try
            {
                if (cbTaiKhoan.Text == "")//nếu txtuser trống
                {
                    throw new Exception("Chưa Chọn Tài Khoản");// quăng ra lỗi chưa nhập id
                }
                if (txtMaNV.Text == "")
                {
                    throw new Exception("Chưa Nhập Mật Khẩu");
                }
                else//nếu txt k trống 
                {
                    dtgDangNhap.DataSource = xldl.TK_Check(dl);// thì hàm Tk_check sẽ kiểm tra dữ liệu ở csdl...
                    if (dtgDangNhap.RowCount == 2)//nếu có thì đếm dòng ở datagrid view sẽ bằng 1
                    {
                        KiemTra_Quyen();
                        if (cbTaiKhoan.Text == txtTaiKhoan.Text)//nếu txtTaiKhoản = tài khoản nào đuọc đăng nhập
                        {
                            PQ_QuanLy = Convert.ToBoolean(txtQuanLy.Text);
                            PQ_BanHang = Convert.ToBoolean(txtBanHang.Text);
                            PQ_Kho = Convert.ToBoolean(txtKho.Text);
                            PQ_TongKet = Convert.ToBoolean(txtTongKet.Text);
                        }
                        frmMain main = new frmMain();
                        main.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Sai Mật Khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btDangNhap_Click(object sender, EventArgs e)
        {
            DangNhap();
        }

        private void btDangNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)// bắt event khi nhập kí tự enter vào combobox
            {
                DangNhap();
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cbTaiKhoan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))// bắt lỗi khi nhập kí tự vào combobox loại
            {
                MessageBox.Show("Mời Chọn", "Thông Báo", MessageBoxButtons.OK);
                e.Handled = true;

            }
        }
      
        
    }
}
