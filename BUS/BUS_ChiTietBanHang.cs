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
    public class BUS_ChiTietBanHang
    {
        DAO_ChiTietBanHang xl = new DAO_ChiTietBanHang();
        DuLieu_ChiTietBanHang dl = new DuLieu_ChiTietBanHang();
        public DataTable TenSach_Search(DuLieu_ChiTietBanHang dl)
        {
            return xl.table_Select("select * from Kho where TenSach like N'%"+dl.TenSach+"%'");
        }
        public DataTable TheLoai_Search(DuLieu_ChiTietBanHang dl)
        {
            return xl.table_Select("select * from Kho where TheLoai like N'%"+dl.TheLoai+"%'");
        }
        public DataTable TacGia_Search(DuLieu_ChiTietBanHang dl)
        {
            return xl.table_Select("select * from Kho where TenTacGia like N'%"+dl.TenTacGia+"%'");
        }
        public void ChiTietBanHang_INSERT(DuLieu_ChiTietBanHang dl)
        {
            xl.table_Command("set dateformat dmy INSERT into ChiTietBanHang VALUES ('" + dl.Ngay + "',N'" + dl.TheLoai + "',N'" + dl.TenSach + "',N'" + dl.TenTacGia + "',N'" + dl.NXB + "','" + dl.Gia + "','" + dl.Sl + "','" + dl.Tong + "')");

        }

       
    }
}
