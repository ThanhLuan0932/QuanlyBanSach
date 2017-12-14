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
using DAO;
using DTO;
using System.IO;

namespace GUI
{
    public partial class frmBanSach : Form
    {
        BUS_ChiTietBanHang xldl = new BUS_ChiTietBanHang();
        BUS_GioHang xldl_GioHang = new BUS_GioHang();
        DuLieu_ChiTietBanHang dl = new DuLieu_ChiTietBanHang();
        DuLieu_GioHang dl_GioHang = new DuLieu_GioHang();
      
        public frmBanSach()
        {
            InitializeComponent();
            
        }

        public void frmBanSach_Load(object sender, EventArgs e)
        {
            txtNgay.Text = DateTime.Now.ToString("dd/MM/yyyy"); // lấy ngày giờ hiện tại của hệ thống
            //frmDangNhap dangnhap = new frmDangNhap();
            txtTenNhanVien.Text = frmDangNhap.MaNV;
            
            
        }
        void Binding()
        {
            txtTheLoai.DataBindings.Clear();
            txtTheLoai.DataBindings.Add("Text", dtgTimSach.DataSource, "TheLoai");
            txtTenSach.DataBindings.Clear();
            txtTenSach.DataBindings.Add("Text", dtgTimSach.DataSource, "TenSach");
            txtTacGia.DataBindings.Clear();
            txtTacGia.DataBindings.Add("Text", dtgTimSach.DataSource, "TenTacGia");
            txtNXB.DataBindings.Clear();
            txtNXB.DataBindings.Add("Text", dtgTimSach.DataSource, "NXB");
            txtGia.DataBindings.Clear();
            txtGia.DataBindings.Add("Text", dtgTimSach.DataSource, "Gia");
        }
        void Clear()
        {
            txtTheLoai.Clear();
            txtTacGia.Clear();
            txtTenSach.Clear();
            txtNXB.Clear();
            txtGia.Clear();
        }

        private void txtTim_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (cbChonMuc.SelectedItem.ToString() == "Thể Loại")
                {
                    dl.TheLoai = txtTim.Text;
                    dtgTimSach.DataSource = xldl.TheLoai_Search(dl);
                }
                if (cbChonMuc.SelectedItem.ToString() == "Tên Sách")
                {
                    dl.TenSach = txtTim.Text;
                    dtgTimSach.DataSource = xldl.TenSach_Search(dl);
                }
                if (cbChonMuc.SelectedItem.ToString() == "Tên Tác Giả")
                {
                    dl.TenTacGia = txtTim.Text;
                    dtgTimSach.DataSource = xldl.TacGia_Search(dl);
                }
                Binding();           
            }
            catch { MessageBox.Show("\tKiểm Tra Lại !","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Error);}
            
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            try
            {
                dl_GioHang.Ngay = Convert.ToDateTime(txtNgay.Text);
                dl_GioHang.TheLoai = txtTheLoai.Text;
                dl_GioHang.TenSach = txtTenSach.Text;
                dl_GioHang.TenTacGia = txtTacGia.Text;
                dl_GioHang.NXB = txtNXB.Text;
                dl_GioHang.Gia = float.Parse(txtGia.Text);
                dl_GioHang.Sl = Convert.ToInt32(nmrSoLuong.Text);
                dl_GioHang.Tong = float.Parse(txtTong.Text);
                xldl_GioHang.Sach_INSERT(dl_GioHang);
                dtgGioHang.DataSource = xldl_GioHang.GioHang_Select(dl_GioHang);
                txtTongTatCa.DataBindings.Clear();
                txtTongTatCa.DataBindings.Add("Text", xldl_GioHang.TongTatCa_Select(dl_GioHang), "Tong");
                txtBo.DataBindings.Clear();
                txtBo.DataBindings.Add("Text", dtgGioHang.DataSource, "STT");
            }
            catch { MessageBox.Show("\tKiểm Tra Lại !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            Clear();
            cbChonMuc.ResetText();
            txtTim.Clear();
            txtTong.Clear();
            while (dtgTimSach.Rows.Count != 0)
            {
                dtgTimSach.Rows.RemoveAt(0);
            }
        }

        private void btThanhToan_Click(object sender, EventArgs e)
        {
            
            try
            {
                DialogResult dr;
                dr = MessageBox.Show(" Xác Nhận Thanh Toán  ?", "Thông Báo", MessageBoxButtons.OKCancel);

                if (dr == DialogResult.OK)
                {
                    frmInHoaDon In = new frmInHoaDon();
                    In.ShowDialog();

                    for (int i = 0; i < dtgGioHang.Rows.Count; i++)
                    {
                        dl.Ngay = Convert.ToDateTime(dtgGioHang.Rows[i].Cells["Ngay"].Value);
                        dl.TheLoai = Convert.ToString(dtgGioHang.Rows[i].Cells["TheLoai"].Value);
                        dl.TenSach = Convert.ToString(dtgGioHang.Rows[i].Cells["TenSach"].Value);
                        dl.TenTacGia = Convert.ToString(dtgGioHang.Rows[i].Cells["TenTacGia"].Value);
                        dl.NXB = Convert.ToString(dtgGioHang.Rows[i].Cells["NXB"].Value);
                        dl.Gia = float.Parse(Convert.ToString(dtgGioHang.Rows[i].Cells["Gia"].Value));
                        dl.Sl = int.Parse(Convert.ToString(dtgGioHang.Rows[i].Cells["Sl"].Value));
                        dl.Tong = float.Parse(Convert.ToString(dtgGioHang.Rows[i].Cells["Tong"].Value));

                        xldl.ChiTietBanHang_INSERT(dl);
                        xldl_GioHang.GioHang_DeleteAll(dl_GioHang);

                        xldl_GioHang.GioHang_ResetSTT(dl_GioHang);

                    }
                    dtgGioHang.DataSource = xldl_GioHang.GioHang_Select(dl_GioHang);
                    txtTongTatCa.Clear();
                }
                    
                    
          

            }
            catch { MessageBox.Show("\tKiểm Tra Lại !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            
        }

        private void btBo_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("\tBỏ Sách Này Ra Khỏi Giỏ Hàng ?", "Thông Báo", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                dl_GioHang.STT = Convert.ToInt32(txtBo.Text);
                xldl_GioHang.GioHang_Delete1(dl_GioHang);
                dtgGioHang.DataSource = xldl_GioHang.GioHang_Select(dl_GioHang);
                txtBo.DataBindings.Clear();
                txtBo.DataBindings.Add("Text", dtgGioHang.DataSource, "STT");
                txtTongTatCa.DataBindings.Clear();
                txtTongTatCa.DataBindings.Add("Text", xldl_GioHang.TongTatCa_Select(dl_GioHang), "Tong");
                
            }           
        }
        private void nmrSoLuong_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                txtTong.Text = Convert.ToString(float.Parse(txtGia.Text) * float.Parse(nmrSoLuong.Value.ToString()));
            }
            catch { MessageBox.Show("\tKiểm Tra Lại !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void nmrSoLuong_KeyUp(object sender, KeyEventArgs e)
        {
            txtTong.Text = Convert.ToString(float.Parse(txtGia.Text) * float.Parse(nmrSoLuong.Value.ToString()));
        }

        private void cbChonMuc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))// bắt lỗi khi nhập kí tự vào combobox loại
            {
                MessageBox.Show("\tMời Chọn", "Thông Báo", MessageBoxButtons.OK);
                e.Handled = true;
            }
        }
        
        private void btXuatHoaDon_Click(object sender, EventArgs e)
        {
            
           

                
        }

            

        }

       
        
    }

