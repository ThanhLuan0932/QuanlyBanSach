using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DuLieu_ChiTietBanHang
    {
       public DateTime Ngay	            {get; set;}
       public String   TheLoai          {get; set;}
	   public String   TenSach          {get; set;}
       public String   TenTacGia        {get; set;}
	   public String   NXB			    {get; set;}
	   public float    Gia              {get; set;}
	   public  int     Sl               {get; set;}
       public float    Tong             {get; set;}
    }
}
