using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace HRM_VTHP.BaoCao
{
    public partial class BaoCaoChamCong : DevExpress.XtraReports.UI.XtraReport
    {
        public BaoCaoChamCong(string tenbophan, string bophanID, string thang)
        { 
            InitializeComponent();
            txtTenBoPhan.Text = tenbophan;
            txtThang.Text=thang;
            //txtNam.Text = nam;
        }

    }
}
