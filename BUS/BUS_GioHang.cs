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
    public class BUS_GioHang
    {
        DAO_GioHang xl_GioHang = new DAO_GioHang();
        DuLieu_GioHang dl_GioHang = new DuLieu_GioHang();
        public DataTable GioHang_Select(DuLieu_GioHang dl_GioHang)
        {
            return xl_GioHang.table_Select("select * from GioHang");
        }
        public void Sach_INSERT(DuLieu_GioHang dl_GioHang)
        {
            xl_GioHang.table_Command("set dateformat dmy INSERT into GioHang VALUES ('"+dl_GioHang.Ngay+"',N'"+dl_GioHang.TheLoai+"',N'"+dl_GioHang.TenSach+"',N'"+dl_GioHang.TenTacGia+"',N'"+dl_GioHang.NXB+"','"+dl_GioHang.Gia+"','"+dl_GioHang.Sl+"','"+dl_GioHang.Tong+"')");
        }
        public DataTable TongTatCa_Select(DuLieu_GioHang dl_GioHang)
        {
            return xl_GioHang.table_Select("select sum(Tong)as[Tong] from GioHang");
        }
        public void GioHang_DeleteAll(DuLieu_GioHang dl_GioHang)
        {
            xl_GioHang.table_Command("Delete From GioHang");
        }
        public void GioHang_Delete1(DuLieu_GioHang dl_GioHang)
        {
            xl_GioHang.table_Command("Delete from GioHang where STT = '"+dl_GioHang.STT+"'" );
        }
        public void GioHang_ResetSTT(DuLieu_GioHang dl_GioHang) // reset STT identity
        {
            xl_GioHang.table_Command("DBCC CHECKIDENT ('GioHang', RESEED, 1)");
        }
       
    }
}
