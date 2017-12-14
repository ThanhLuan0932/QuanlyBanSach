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
    public class BUS_DoThiCot
    {
        DuLieu_DoThiCot dlc = new DuLieu_DoThiCot();
        DAO_DoThiCot xlc = new DAO_DoThiCot();
        public DataTable SlBanThang_SelectAll(DuLieu_DoThiCot dlc)
        {
            return xlc.table_Select("select month(Ngay)as[Thang], sum(Sl)as[Sl] from ChiTietBanHang group by month(Ngay)");
        }
        public DataTable DoanhThuThang_SelectAll(DuLieu_DoThiCot dlc)
        {
            return xlc.table_Select("select month(Ngay)as[Thang], sum(Tong)as[Tong] from ChiTietBanHang group by month(Ngay)");
        }

        public DataTable SlBanNam_SelectAll(DuLieu_DoThiCot dlc)
        {
            return xlc.table_Select("select year(Ngay)as[Nam], sum(Sl)as[Sl] from ChiTietBanHang group by year(Ngay)");
        }
        public DataTable DoanhThuNam_SelectAll(DuLieu_DoThiCot dlc)
        {
            return xlc.table_Select("select year(Ngay)as[Nam], sum(Tong)as[Tong] from ChiTietBanHang group by year(Ngay)");
        }

        public DataTable SlSachNhieuNhat_SelectAll(DuLieu_DoThiCot dlc)
        {
            return xlc.table_Select("select top 9 TenSach,sum(Sl) as [Sl] from ChiTietBanHang group by TenSach order by sum(Sl) desc");
        }
        public DataTable SlSachItNhat_SelectAll(DuLieu_DoThiCot dlc)
        {
            return xlc.table_Select("select top 9 TenSach,sum(Sl) as [Sl] from ChiTietBanHang group by TenSach order by sum(Sl) ");
        }

        public DataTable DoanhThuSachNhieuNhat_SelectAll(DuLieu_DoThiCot dlc)
        {
            return xlc.table_Select("select top 9 TenSach,sum(Tong) as [Tong] from ChiTietBanHang group by TenSach order by sum(Tong) desc");
        }
        public DataTable DoanhThuSachItNhat_SelectAll(DuLieu_DoThiCot dlc)
        {
            return xlc.table_Select("select top 9 TenSach,sum(Tong) as [Tong] from ChiTietBanHang group by TenSach order by sum(Tong) ");
        }
        public DataTable TheLoaiMuaNhieuNhat_SelectAll(DuLieu_DoThiCot dlc)
        {
            return xlc.table_Select("select top 9 TheLoai,sum(Sl) as [Sl] from ChiTietBanHang group by TheLoai order by sum(Sl) desc");
        }
        public DataTable TheLoaiMuaItNhat_SelectAll(DuLieu_DoThiCot dlc)
        {
            return xlc.table_Select("select top 9 TheLoai,sum(Sl) as [Sl] from ChiTietBanHang group by TheLoai order by sum(Sl) ");
        }
        public DataTable DoanhThuTheLoaiMuaNhieuNhat_SelectAll(DuLieu_DoThiCot dlc)
        {
            return xlc.table_Select("select top 9 TheLoai,sum(Tong) as [Tong] from ChiTietBanHang group by TheLoai order by sum(Tong) desc");
        }
        public DataTable DoanhThuTheLoaiMuaItNhat_SelectAll(DuLieu_DoThiCot dlc)
        {
            return xlc.table_Select("select top 9 TheLoai,sum(Tong) as [Tong] from ChiTietBanHang group by TheLoai order by sum(Tong) ");
        }

    }
}
