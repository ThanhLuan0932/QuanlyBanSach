using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GUI
{
    public partial class frmPhanQuyen : Form
    {
        BUS_DangNhap xldl = new BUS_DangNhap();
        DuLieu_DangNhap dl = new DuLieu_DangNhap();
        public frmPhanQuyen()
        {
            InitializeComponent();
        }

        private void frmPhanQuyen_Load(object sender, EventArgs e)
        {
            cbTenTaiKhoan.DataSource = xldl.TaiKhoan_PQ(dl);
            cbTenTaiKhoan.DisplayMember = "TaiKhoan";
            cbTenTaiKhoan.ValueMember = "TaiKhoan";
            dtgDanhSachQuyen.DataSource = xldl.TaiKhoan_Search(dl);
            Enable();
            Binding();
            dl.TaiKhoan = cbTenTaiKhoan.SelectedValue.ToString();
            cbMaNV.DataSource = xldl.MaNV_PQ(dl);
            cbMaNV.DisplayMember = "MaNV";
            cbMaNV.ValueMember = "MaNV";
            dl.TaiKhoan = cbTenTaiKhoan.Text;
            dtgDanhSachQuyen.DataSource = xldl.TaiKhoan_Search(dl);
            
        }
        private void cbTenTaiKhoan_SelectedIndexChanged(object sender, EventArgs e)
        {
            dl.TaiKhoan = cbTenTaiKhoan.SelectedValue.ToString();
            cbMaNV.DataSource = xldl.MaNV_PQ(dl);
            cbMaNV.DisplayMember = "MaNV";
            cbMaNV.ValueMember = "MaNV";

            if (cbTenTaiKhoan.Text == "Quản Lý")
            {
                btThayDoiQuyen.Enabled = false;
            }
            else
            {
                btThayDoiQuyen.Enabled = true;
            }
            dl.TaiKhoan = cbTenTaiKhoan.Text;
            dtgDanhSachQuyen.DataSource = xldl.TaiKhoan_Search(dl);
            Binding();
        }
        private void cbMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            dl.MaNV = cbMaNV.SelectedValue.ToString();
            txtTenNhanVien.DataBindings.Clear();
            txtTenNhanVien.DataBindings.Add("Text", xldl.TenNV_PQ(dl), "TenNhanVien");
            dl.MaNV = cbMaNV.Text;
            dtgDanhSachQuyen.DataSource = xldl.MaNV_Search(dl);
            Binding();
        }
        void Enable()
        {
            cbQuyen_QuanLy.Enabled = false;
            cbQuyen_BanHang.Enabled = false;
            cbQuyen_Kho.Enabled = false;
            cbQuyen_TongKet.Enabled = false;
            cbTenTaiKhoan.Enabled = false;
            cbMaNV.Enabled = false;
            txtTenNhanVien.Enabled = false;
            btThayDoiQuyen.Enabled = false;
        }
        void Clear()
        {

            cbQuyen_BanHang.Enabled = true;
            cbQuyen_Kho.Enabled = true;
            cbQuyen_TongKet.Enabled = true;
        }
        void Binding()
        {
            cbQuyen_QuanLy.DataBindings.Clear();
            cbQuyen_QuanLy.DataBindings.Add("Text", dtgDanhSachQuyen.DataSource, "QuanLy");
            cbQuyen_BanHang.DataBindings.Clear();
            cbQuyen_BanHang.DataBindings.Add("Text", dtgDanhSachQuyen.DataSource, "BanHang");
            cbQuyen_Kho.DataBindings.Clear();
            cbQuyen_Kho.DataBindings.Add("Text", dtgDanhSachQuyen.DataSource, "Kho");
            cbQuyen_TongKet.DataBindings.Clear();
            cbQuyen_TongKet.DataBindings.Add("Text", dtgDanhSachQuyen.DataSource, "TongKet");
        }

        private void cbTenTaiKhoan_SelectedValueChanged(object sender, EventArgs e)
        {
            //if (cbTenTaiKhoan.Text == "Quản Lý")
            //{
            //    btThayDoiQuyen.Enabled = false;
            //}
            //else
            //{
            //    btThayDoiQuyen.Enabled = true;
            //}
            //dl.TaiKhoan = cbTenTaiKhoan.Text;
            //dtgDanhSachQuyen.DataSource = xldl.TaiKhoan_Search(dl);
            //Binding();
        }

        private void btThayDoiQuyen_Click(object sender, EventArgs e)
        {
            Clear();  
        }

        private void btLuuQuyen_Click(object sender, EventArgs e)
        {
            dl.BanHang = cbQuyen_BanHang.Text;
            dl.Kho = cbQuyen_Kho.Text;
            dl.TongKet = cbQuyen_TongKet.Text;
            
            if(SuaQuyen_ViTri)
            {
                dl.TaiKhoan = cbTenTaiKhoan.Text;
                xldl.Quyen_ViTri_Update(dl);
                SuaQuyen_ViTri = false;
                dtgDanhSachQuyen.DataSource = xldl.TaiKhoan_Search(dl);
            }
            if(SuaQuyen_NhanVien)
            {
                dl.MaNV = cbMaNV.Text; 
                xldl.Quyen_NhanVien_Update(dl);
                SuaQuyen_NhanVien = false;
                dtgDanhSachQuyen.DataSource = xldl.MaNV_Search(dl);
            }
            
            
            Enable();
            Binding();
        }

        private void cbTenTaiKhoan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))// bắt lỗi khi nhập kí tự vào combobox loại
            {
                MessageBox.Show("Mời Chọn", "Thông Báo", MessageBoxButtons.OK);
                e.Handled = true;

            }
        }

        private void cbQuyen_QuanLy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))// bắt lỗi khi nhập kí tự vào combobox loại
            {
                MessageBox.Show("Mời Chọn", "Thông Báo", MessageBoxButtons.OK);
                e.Handled = true;

            }
        }
        public bool SuaQuyen_ViTri = false;
        public bool SuaQuyen_NhanVien = false;
        private void btSuaQuyen_ViTri_Click(object sender, EventArgs e)
        {
            cbTenTaiKhoan.Enabled = true;
            cbMaNV.Enabled = false;
            txtTenNhanVien.Enabled = false;
            SuaQuyen_ViTri = true;
            btThayDoiQuyen.Enabled = true;
        }

        private void btSuaQuyen_NhanVien_Click(object sender, EventArgs e)
        {
            cbTenTaiKhoan.Enabled = true;
            cbMaNV.Enabled = true;
            txtTenNhanVien.Enabled = true;
            SuaQuyen_NhanVien = true;
            btThayDoiQuyen.Enabled = true;
        }

        

        

        

        
    }
}
