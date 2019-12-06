using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace HRM_VTHP.BaoCao
{
    public partial class ThongKeSLLaoDong : DevExpress.XtraReports.UI.XtraReport
    {
        public ThongKeSLLaoDong( string trangthaiID)
        {
            InitializeComponent();
            txtTrangThai.Text = trangthaiID;
        }

    }
}
