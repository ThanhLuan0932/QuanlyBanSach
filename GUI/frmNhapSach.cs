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
    public partial class frmNhapSach : Form
    {
        BUS_NhapSach xldl_NhapSach = new BUS_NhapSach();
        DuLieu_NhapSach dl_NhapSach = new DuLieu_NhapSach();
        public frmNhapSach()
        {
            InitializeComponent();
        }

        private void frmNhapSach_Load(object sender, EventArgs e)
        {
            txtMaNV.Text = frmDangNhap.MaNV;
            txtNgayNhap.Text = DateTime.Now.ToString("dd/MM/yyyy");
            dtgNhapSach.DataSource = xldl_NhapSach.NhapSach_Select(dl_NhapSach);
            cbTheLoaiNhapKho.DataSource = xldl_NhapSach.TheLoai_Select(dl_NhapSach);
            cbTheLoaiNhapKho.DisplayMember = "TheLoai";
            cbQuocGiaNhapKho.DataSource = xldl_NhapSach.QuocGia_Select(dl_NhapSach);
            cbQuocGiaNhapKho.DisplayMember = "QuocGia";
            Binding();
            
            
        }

        private void cbTheLoaiNhapKho_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtVietTatTheLoai.DataBindings.Clear();
            txtVietTatTheLoai.DataBindings.Add("Text",cbTheLoaiNhapKho.DataSource, "VietTatTheLoai");
            
        }

        private void cbQuocGiaNhapKho_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtVietTatQuocGia.DataBindings.Clear();
            txtVietTatQuocGia.DataBindings.Add("Text", cbQuocGiaNhapKho.DataSource, "VietTatTenNuoc");
            
            
        }
        private void Binding()
        {
            dl_NhapSach.TheLoai = cbTheLoaiNhapKho.Text;
            txtVietTatTheLoai.DataBindings.Clear();
            txtVietTatTheLoai.DataBindings.Add("Text", xldl_NhapSach.LayTheLoai_Select(dl_NhapSach), "MaTheLoai");
            cbTheLoaiNhapKho.DataBindings.Clear();
            cbTheLoaiNhapKho.DataBindings.Add("Text", dtgNhapSach.DataSource, "TheLoai");
            cbQuocGiaNhapKho.DataBindings.Clear();
            cbQuocGiaNhapKho.DataBindings.Add("Text", dtgNhapSach.DataSource, "QuocGia");
            txtTenSach.DataBindings.Clear();
            txtTenSach.DataBindings.Add("Text", dtgNhapSach.DataSource, "TenSach");
            txtTacGia.DataBindings.Clear();
            txtTacGia.DataBindings.Add("Text", dtgNhapSach.DataSource, "TenTacGia");
            txtNXB.DataBindings.Clear();
            txtNXB.DataBindings.Add("Text", dtgNhapSach.DataSource, "NXB");
            txtGiaNhapKho.DataBindings.Clear();
            txtGiaNhapKho.DataBindings.Add("Text", dtgNhapSach.DataSource, "Gia");
            nmrSlNhapKho.DataBindings.Clear();
            nmrSlNhapKho.DataBindings.Add("Text", dtgNhapSach.DataSource, "SlNhap");
            txtSTT.DataBindings.Clear();
            txtSTT.DataBindings.Add("Text", dtgNhapSach.DataSource, "STT");

        }
        private void Clear()
        {
            txtVietTatTheLoai.Clear();
            txtVietTatQuocGia.Clear();
            cbTheLoaiNhapKho.ResetText();
            cbQuocGiaNhapKho.ResetText();
            txtTenSach.Clear();
            txtTacGia.Clear();
            txtNXB.ResetText();
            txtGiaNhapKho.Clear();
            nmrSlNhapKho.ResetText();
        }
        private void Enable_False()
        {
            txtVietTatTheLoai.Enabled = false;
            txtVietTatQuocGia.Enabled = false;
            cbTheLoaiNhapKho.Enabled = false;
            cbQuocGiaNhapKho.Enabled = false;
            txtTenSach.Enabled = false;
            txtTacGia.Enabled = false;
            txtNXB.Enabled = false;
            txtGiaNhapKho.Enabled = false;
            nmrSlNhapKho.Enabled = false;
        }
        private void Enable_True()
        {
            txtVietTatTheLoai.Enabled = true;
            txtVietTatQuocGia.Enabled = true;
            cbTheLoaiNhapKho.Enabled = true;
            cbQuocGiaNhapKho.Enabled = true;
            txtTenSach.Enabled = true;
            txtTacGia.Enabled = true;
            txtNXB.Enabled = true;
            txtGiaNhapKho.Enabled = true;
            nmrSlNhapKho.Enabled = true;
        }
        private void dtgNhapSach_Click(object sender, EventArgs e)
        {
            Enable_False();
        }
        private bool ThemMoi = false;
        private void btThemMoi_Click(object sender, EventArgs e)
        {
            Clear();
            Enable_True();
            ThemMoi = true;
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            Enable_True();
        }

        private void btThemVaoDachSachNhap_Click(object sender, EventArgs e)
        {
            dl_NhapSach.Ngay = Convert.ToDateTime(txtNgayNhap.Text);
            dl_NhapSach.MaSach = txtVietTatTheLoai.Text + txtVietTatQuocGia.Text;
            dl_NhapSach.TheLoai = cbTheLoaiNhapKho.Text;
            dl_NhapSach.QuocGia = cbQuocGiaNhapKho.Text;
            dl_NhapSach.TenTacGia = txtTacGia.Text;
            dl_NhapSach.NXB = txtNXB.Text;
            dl_NhapSach.Gia = float.Parse(txtGiaNhapKho.Text);
            dl_NhapSach.SlNhap = Convert.ToInt32(nmrSlNhapKho.Text);
              
            if(ThemMoi)
            {
                dl_NhapSach.TenSach = txtTenSach.Text;
                xldl_NhapSach.Sach_INSERT(dl_NhapSach);
                ThemMoi = false;
                
            }
            else
            {
                dl_NhapSach.STT = int.Parse(txtSTT.Text);
                xldl_NhapSach.Sach_UPDATE(dl_NhapSach);
            }
            dtgNhapSach.DataSource = xldl_NhapSach.NhapSach_Select(dl_NhapSach);
            Binding();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show(" Xóa Sách" + txtTenSach.Text +" ?", "Thông Báo", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                dl_NhapSach.TenSach = txtTenSach.Text;
                xldl_NhapSach.Sach_DELETE(dl_NhapSach);
            }
            dtgNhapSach.DataSource = xldl_NhapSach.NhapSach_Select(dl_NhapSach);
            Binding();
            

        }

        private void btThemVaoKhoVaXuatBaoCao_Click(object sender, EventArgs e)
        {
            //DialogResult dr;
            //    dr = MessageBox.Show(" Xác Nhận Thanh Toán  ?", "Thông Báo", MessageBoxButtons.OKCancel);

            //    if (dr == DialogResult.OK)
            //    {
            //        frmInHoaDon In = new frmInHoaDon();
            //        In.ShowDialog();

            //        for (int i = 0; i < dtgGioHang.Rows.Count; i++)
            //        {
            //            dl.Ngay = Convert.ToDateTime(dtgGioHang.Rows[i].Cells["Ngay"].Value);
            //            dl.TheLoai = Convert.ToString(dtgGioHang.Rows[i].Cells["TheLoai"].Value);
            //            dl.TenSach = Convert.ToString(dtgGioHang.Rows[i].Cells["TenSach"].Value);
            //            dl.TenTacGia = Convert.ToString(dtgGioHang.Rows[i].Cells["TenTacGia"].Value);
            //            dl.NXB = Convert.ToString(dtgGioHang.Rows[i].Cells["NXB"].Value);
            //            dl.Gia = float.Parse(Convert.ToString(dtgGioHang.Rows[i].Cells["Gia"].Value));
            //            dl.Sl = int.Parse(Convert.ToString(dtgGioHang.Rows[i].Cells["Sl"].Value));
            //            dl.Tong = float.Parse(Convert.ToString(dtgGioHang.Rows[i].Cells["Tong"].Value));

            //            xldl.ChiTietBanHang_INSERT(dl);
            //            xldl_GioHang.GioHang_DeleteAll(dl_GioHang);

            //            xldl_GioHang.GioHang_ResetSTT(dl_GioHang);

            //        }
            //        dtgGioHang.DataSource = xldl_GioHang.GioHang_Select(dl_GioHang);
            //        txtTongTatCa.Clear();

        }

        
        

       

       
    }
}
