using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmInHoaDon : Form
    {
       
        public frmInHoaDon()
        {
            InitializeComponent();
            
        }
        
        private void frmInHoaDon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QL_BanSachDataSet.GioHang' table. You can move, or remove it, as needed.
            this.GioHangTableAdapter.Fill(this.QL_BanSachDataSet.GioHang);
           // SetPar(rpNgayLapHoaDon);
            
            this.reportViewer1.RefreshReport();
            
          
        }
        private void SetPar_NgayLapHoaDon(string rpNgayLapHoaDon)
        {
            
        }
        private void SetPar_TongTatCa(string rpTongTatCa)
        {
            
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
        

        
    }
}
