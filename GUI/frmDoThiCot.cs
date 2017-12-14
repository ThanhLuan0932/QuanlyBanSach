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
    public partial class frmDoThiCot : Form
    {
        DuLieu_DoThiCot dlc = new DuLieu_DoThiCot(); // Khai báo đối tượng từ lớp BUS và DTO
        BUS_DoThiCot xlc = new BUS_DoThiCot();
        public frmDoThiCot()
        {
            InitializeComponent();
        }

        private void btLoc_Click(object sender, EventArgs e)
        {
            try // cố gắng thực hiện lệnh này
            {
                if (cbChon.SelectedItem.ToString() == "Số Lượng Bán Ra")
                {
                    if (cbThoiGian.SelectedItem.ToString() == "Tháng")
                    {
                        chart1.DataSource = xlc.SlBanThang_SelectAll(dlc);
                        chart1.ChartAreas["ChartArea1"].AxisX.Title = "Ngày";
                        chart1.ChartAreas["ChartArea1"].AxisX.Title = "Số Lượng Bán Trong Tháng (Đơn vị :Cuốn)";

                        chart1.Series["."].XValueMember = "Thang";
                        chart1.Series["."].YValueMembers = "Sl";
                    }
                    if (cbThoiGian.SelectedItem.ToString() == "Năm")
                    {
                        chart1.DataSource = xlc.SlBanNam_SelectAll(dlc);
                        chart1.ChartAreas["ChartArea1"].AxisX.Title = "Năm";
                        chart1.ChartAreas["ChartArea1"].AxisX.Title = "Số Lượng Bán Trong Năm (Đơn vị :Cuốn)";

                        chart1.Series["."].XValueMember = "Nam";
                        chart1.Series["."].YValueMembers = "Sl";
                    }
                    if (cbThoiGian.SelectedItem.ToString() == "Các Loại Sách")
                    {
                        cbSapXep.Visible = true;
                        if (cbSapXep.SelectedItem.ToString() == "Top Cao Nhất")
                        {
                            chart1.DataSource = xlc.SlSachNhieuNhat_SelectAll(dlc);
                            chart1.ChartAreas["ChartArea1"].AxisX.Title = "Tên";
                            chart1.ChartAreas["ChartArea1"].AxisX.Title = "Số Lượng Bán Theo Tên Loại Sách (Đơn vị : Cuốn)";

                            chart1.Series["."].XValueMember = "TenSach";
                            chart1.Series["."].YValueMembers = "Sl";

                        }
                        if (cbSapXep.SelectedItem.ToString() == "Top Thấp Nhất")
                        {
                            chart1.DataSource = xlc.SlSachItNhat_SelectAll(dlc);
                            chart1.ChartAreas["ChartArea1"].AxisX.Title = "Tên";
                            chart1.ChartAreas["ChartArea1"].AxisX.Title = "Số Lượng Bán Theo Tên Sách (Đơn vị : Cuốn)";

                            chart1.Series["."].XValueMember = "TenSach";
                            chart1.Series["."].YValueMembers = "Sl";
                        }
                    }
                    if (cbThoiGian.SelectedItem.ToString() == "Thể Loại")
                    {
                        cbSapXep.Visible = true;
                        if (cbSapXep.SelectedItem.ToString() == "Top Cao Nhất")
                        {
                            chart1.DataSource = xlc.TheLoaiMuaNhieuNhat_SelectAll(dlc);
                            chart1.ChartAreas["ChartArea1"].AxisX.Title = "Tên";
                            chart1.ChartAreas["ChartArea1"].AxisX.Title = "Số Lượng Bán Ra Theo Thể Loại Sách (Đơn vị :Cuốn)";

                            chart1.Series["."].XValueMember = "TheLoai";
                            chart1.Series["."].YValueMembers = "Sl";

                        }
                        if (cbSapXep.SelectedItem.ToString() == "Top Thấp Nhất")
                        {
                            chart1.DataSource = xlc.TheLoaiMuaItNhat_SelectAll(dlc);
                            chart1.ChartAreas["ChartArea1"].AxisX.Title = "Tên";
                            chart1.ChartAreas["ChartArea1"].AxisX.Title = "Số Lượng Bán Ra Theo Thể Loại Sách (Đơn vị : Cuốn)";

                            chart1.Series["."].XValueMember = "TheLoai";
                            chart1.Series["."].YValueMembers = "Sl";
                        }
                    }


                }
                if (cbChon.SelectedItem.ToString() == "Doanh Thu")
                {
                    
                    if (cbThoiGian.SelectedItem.ToString() == "Tháng")
                    {
                        chart1.DataSource = xlc.DoanhThuThang_SelectAll(dlc);
                        chart1.ChartAreas["ChartArea1"].AxisX.Title = "Ngày";
                        chart1.ChartAreas["ChartArea1"].AxisX.Title = "Doanh Thu Trong Tháng (Đơn Vị: Nghìn Đồng)";

                        chart1.Series["."].XValueMember = "Thang";
                        chart1.Series["."].YValueMembers = "Tong";
                    }
                    if (cbThoiGian.SelectedItem.ToString() == "Năm")
                    {
                        chart1.DataSource = xlc.DoanhThuNam_SelectAll(dlc);
                        chart1.ChartAreas["ChartArea1"].AxisX.Title = "Năm";
                        chart1.ChartAreas["ChartArea1"].AxisX.Title = "Doanh Thu Trong Năm (Đơn vị : Nghìn Đồng)";

                        chart1.Series["."].XValueMember = "Nam";
                        chart1.Series["."].YValueMembers = "Tong";
                    }
                    if (cbThoiGian.SelectedItem.ToString() == "Các Loại Sách")
                    {
                        cbSapXep.Visible = true;
                        if (cbSapXep.SelectedItem.ToString() == "Top Cao Nhất")
                        {
                            chart1.DataSource = xlc.DoanhThuSachNhieuNhat_SelectAll(dlc);
                            chart1.ChartAreas["ChartArea1"].AxisX.Title = "Tên";
                            chart1.ChartAreas["ChartArea1"].AxisX.Title = "Doanh Thu Theo Tên Sách (Đơn vị : Nghìn Đồng)";

                            chart1.Series["."].XValueMember = "TenSach";
                            chart1.Series["."].YValueMembers = "Tong";
                        }
                        if (cbSapXep.SelectedItem.ToString() == "Top Thấp Nhất")
                        {
                            chart1.DataSource = xlc.DoanhThuSachItNhat_SelectAll(dlc);
                            chart1.ChartAreas["ChartArea1"].AxisX.Title = "Tên";
                            chart1.ChartAreas["ChartArea1"].AxisX.Title = "Doanh Thu Theo Tên Sách (Đơn vị : Nghìn Đồng)";

                            chart1.Series["."].XValueMember = "TenSach";
                            chart1.Series["."].YValueMembers = "Tong";
                        }
                    }
                    if (cbThoiGian.SelectedItem.ToString() == "Thể Loại")
                    {
                        cbSapXep.Visible = true;
                        if (cbSapXep.SelectedItem.ToString() == "Top Cao Nhất")
                        {
                            chart1.DataSource = xlc.DoanhThuTheLoaiMuaNhieuNhat_SelectAll(dlc);
                            chart1.ChartAreas["ChartArea1"].AxisX.Title = "Thể Loại";
                            chart1.ChartAreas["ChartArea1"].AxisX.Title = "Doanh Thu Theo Thể Loại Sách (Đơn vị : Nghìn Đồng)";

                            chart1.Series["."].XValueMember = "TheLoai";
                            chart1.Series["."].YValueMembers = "Tong";

                        }
                        if (cbSapXep.SelectedItem.ToString() == "Top Thấp Nhất")
                        {
                            chart1.DataSource = xlc.DoanhThuTheLoaiMuaItNhat_SelectAll(dlc);
                            chart1.ChartAreas["ChartArea1"].AxisX.Title = "Thể Loại";
                            chart1.ChartAreas["ChartArea1"].AxisX.Title = "Doanh Thu Theo Thể Loại Sách (Đơn vị : Nghìn Đồng)";

                            chart1.Series["."].XValueMember = "TheLoai";
                            chart1.Series["."].YValueMembers = "Tong";
                        }
                    }
                }
            }
            catch // nếu có lỗi khi không thực hiện được lệnh trên( chưa chọn các điều kiện) thìxuất hiện thông báo 
            {
                MessageBox.Show("Kiểm Tra Lại Điều Kiện Lọc", "!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
