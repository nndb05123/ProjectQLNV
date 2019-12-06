using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace HRM_VTHP.BaoCao
{
    public partial class BaoCaoLuongHangThang : DevExpress.XtraReports.UI.XtraReport
    {
        public BaoCaoLuongHangThang(string donvi, string thang)
        {
            InitializeComponent();
            txtDonVi.Text = donvi;
            txtThang.Text = thang;
        }

    }
}
