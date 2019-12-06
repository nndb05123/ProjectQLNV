using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;
namespace HRM_VTHP.BaoCao
{
    public partial class BaoCaoHoSoNV : DevExpress.XtraReports.UI.XtraReport
    {
        public BaoCaoHoSoNV(string ten_dv, string donviID)
        {
            InitializeComponent();
            txtTenDonVi.Text = ten_dv;

            //Parameters["BoPhanID"].Value = donviID;
        }
        
    }
}
