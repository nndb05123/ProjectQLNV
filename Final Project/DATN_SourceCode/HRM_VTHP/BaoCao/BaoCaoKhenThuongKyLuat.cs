using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace HRM_VTHP.BaoCao
{
    public partial class BaoCaoKhenThuongKyLuat : DevExpress.XtraReports.UI.XtraReport
    {
        public BaoCaoKhenThuongKyLuat(string tenbophan, string bophanID, string tenloaiqd, string loaiquyetdinhID)
        {
            InitializeComponent();
            txtTenBoPhan.Text = tenbophan;
            txtTenLoaiQD.Text = tenloaiqd;

        }

    }
}
