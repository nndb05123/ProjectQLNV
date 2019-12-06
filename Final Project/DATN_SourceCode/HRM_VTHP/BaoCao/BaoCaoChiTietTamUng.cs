using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace HRM_VTHP.BaoCao
{
    public partial class BaoCaoChiTietTamUng : DevExpress.XtraReports.UI.XtraReport
    {
        public BaoCaoChiTietTamUng(string tenbophan, string bophanID, string tenloaitamung, string tamungID)
        {
            InitializeComponent();
            txtTenBoPhan.Text = tenbophan;
            txtTenLoaiTamUng.Text = tenloaitamung;
        }

    }
}
