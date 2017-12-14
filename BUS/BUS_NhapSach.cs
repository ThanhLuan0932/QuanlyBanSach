using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
using System.Data;


namespace BUS
{
    public class BUS_NhapSach
    {
        DAO_NhapSach xl_NhapSach = new DAO_NhapSach();
        DuLieu_NhapSach dl_NhapSach = new DuLieu_NhapSach();
        public DataTable NhapSach_Select(DuLieu_NhapSach dl_NhapSach)
        {
            return xl_NhapSach.table_Select("select * from NhapSach");
        }
        public DataTable LayTheLoai_Select(DuLieu_NhapSach dl_NhapSach)
        {
            return xl_NhapSach.table_Select("select left(MaSach,2) as [MaTheloai] from NhapSach where TheLoai = N'"+dl_NhapSach.TheLoai+"'");
        }
        public DataTable LayQuocGia_Select(DuLieu_NhapSach dl_NhapSach)
        {
            return xl_NhapSach.table_Select("select Right(MaSach,2) as [MaQuocGia]from NhapSach where QuocGia = N'" + dl_NhapSach.TheLoai + "'");
        }
        public DataTable TheLoai_Select(DuLieu_NhapSach dl_NhapSach)
        {
            return xl_NhapSach.table_Select("select * from VietTatTheLoai");
        }
        public DataTable QuocGia_Select(DuLieu_NhapSach dl_NhapSach)
        {
            return xl_NhapSach.table_Select("select * from VietTatTenNuoc");
        }
        
        public void Sach_INSERT(DuLieu_NhapSach dl_NhapSach)
        {
            xl_NhapSach.table_Command("set dateformat dmy INSERT into NhapSach VALUES ('"+dl_NhapSach.Ngay+"', '"+dl_NhapSach.MaSach+"', N'"+dl_NhapSach.TheLoai+"', N'"+dl_NhapSach.TenSach+"', N'"+dl_NhapSach.QuocGia+"',N'"+dl_NhapSach.TenTacGia+"',N'"+dl_NhapSach.NXB+"','"+dl_NhapSach.Gia+"','"+dl_NhapSach.SlNhap+"')");
        }
        public void Sach_UPDATE(DuLieu_NhapSach dl_NhapSach)
        {
            xl_NhapSach.table_Command("update NhapSach set MaSach = '" + dl_NhapSach.MaSach + "', TheLoai = N'" + dl_NhapSach.TheLoai + "', TenSach = N'" + dl_NhapSach.TenSach + "', QuocGia = N'" + dl_NhapSach.QuocGia + "', TenTacGia = N'" + dl_NhapSach.TenTacGia + "', NXB = N'" + dl_NhapSach.NXB + "', Gia = '" + dl_NhapSach.Gia + "', SlNhap = '" + dl_NhapSach.SlNhap + "' Where STT = '" + dl_NhapSach.STT+ "'");
        }
        public void Sach_DELETE(DuLieu_NhapSach dl_NhapSach)
        {
            xl_NhapSach.table_Command("Delete from NhapSach where TenSach = N'" + dl_NhapSach.TenSach + "'");
        }
    }
}
