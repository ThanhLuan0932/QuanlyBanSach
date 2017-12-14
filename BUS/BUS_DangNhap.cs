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
    public class BUS_DangNhap
    {
        DAO_DangNhap xl = new DAO_DangNhap();
        DuLieu_DangNhap dl = new DuLieu_DangNhap();
        public DataTable DangNhap_Select(DuLieu_DangNhap dl)
        {
            return xl.table_Select("select* from PhanQuyen");
        }
        public DataTable TK_Check(DuLieu_DangNhap dl)
        {
            return xl.table_Select("select * from PhanQuyen where TaiKhoan=N'" + dl.TaiKhoan + "' and MaNV='"+ dl.MaNV + "'");
        }
        public DataTable QuanLy_PQ(DuLieu_DangNhap dl)
        {
            return xl.table_Select("select QuanLy from PhanQuyen where TaiKhoan=N'" + dl.TaiKhoan + "' and MaNV='"+ dl.MaNV + "'");
        }
        public DataTable BanHang_PQ(DuLieu_DangNhap dl)
        {
            return xl.table_Select("select BanHang from PhanQuyen where TaiKhoan=N'" + dl.TaiKhoan + "' and MaNV='"+ dl.MaNV + "'");
        }
        public DataTable Kho_PQ(DuLieu_DangNhap dl)
        {
            return xl.table_Select("select Kho from PhanQuyen where TaiKhoan=N'" + dl.TaiKhoan + "' and MaNV='"+ dl.MaNV + "'");
        }
        public DataTable TongKet_PQ(DuLieu_DangNhap dl)
        {
            return xl.table_Select("select TongKet from PhanQuyen where TaiKhoan=N'" + dl.TaiKhoan + "' and MaNV='"+ dl.MaNV + "'");
        }
        //public DataTable TaiKhoan_PQ(DuLieu_DangNhap dl)
        //{
        //    //return xl.table_Select("select  TaiKhoan from PhanQuyen where TaiKhoan=N'" + dl.TaiKhoan + "' and MaNV='"+ dl.MaNV + "'");
        //}
        public DataTable TaiKhoan_PQ(DuLieu_DangNhap dl)
        {
            return xl.table_Select("select distinct TaiKhoan from PhanQuyen ");
        }
        public DataTable MaNV_PQ(DuLieu_DangNhap dl)
        {
            return xl.table_Select("select MaNV from PhanQuyen where TaiKhoan = N'"+dl.TaiKhoan+"' ");
        }
        public DataTable TenNV_PQ(DuLieu_DangNhap dl)
        {
            return xl.table_Select("select NhanVien.MaNV,TenNhanVien from PhanQuyen,NhanVien where PhanQuyen.MaNV=NhanVien.MaNV and PhanQuyen.MaNV='"+dl.MaNV+"'");
        }
        public DataTable TaiKhoan_Search(DuLieu_DangNhap dl)
        {
            return xl.table_Select("select * from PhanQuyen where TaiKhoan = N'" + dl.TaiKhoan + "'");
        }
        public DataTable MaNV_Search(DuLieu_DangNhap dl)
        {
            return xl.table_Select("select * from PhanQuyen where MaNV = N'" + dl.MaNV+ "'");
        }
        public void Quyen_ViTri_Update(DuLieu_DangNhap dl)
        {
            xl.table_Select("update PhanQuyen set BanHang = '" + dl.BanHang + "',Kho = '" + dl.Kho + "',TongKet = '" + dl.TongKet + "'  where TaiKhoan = N'" + dl.TaiKhoan + "'");
        }
        public void Quyen_NhanVien_Update(DuLieu_DangNhap dl)
        {
            xl.table_Select("update PhanQuyen set BanHang = '" + dl.BanHang + "',Kho = '" + dl.Kho + "',TongKet = '" + dl.TongKet + "'  where TaiKhoan = N'" + dl.TaiKhoan + "' and MaNV='"+dl.MaNV+"'");
        }
    }
}
