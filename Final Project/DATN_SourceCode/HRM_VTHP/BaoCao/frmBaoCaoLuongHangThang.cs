using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace HRM_VTHP.BaoCao
{
    public partial class frmBaoCaoLuongHangThang : Form
    {
        public frmBaoCaoLuongHangThang()
        {
            InitializeComponent();
        }

        protected void LoadBaoCao()
        {
            try
            {
                // get value config
                string BHYT = ConfigurationManager.AppSettings["BHYT"];
                string BHXH = ConfigurationManager.AppSettings["BHXH"];
                string BHTN = ConfigurationManager.AppSettings["BHTN"];

                BaoCaoLuongHangThang reports = new BaoCaoLuongHangThang(cbbBoPhan.Text, dtpThang.Value.ToString("MM/yyyy"));

                reports.Parameters["BoPhanID"].Value = int.Parse( cbbBoPhan.SelectedValue.ToString());
                reports.Parameters["Thang"].Value = dtpThang.Value.ToString("yyyyMM");
                reports.Parameters["BHYT"].Value = BHYT;
                reports.Parameters["BHXH"].Value = BHXH;
                reports.Parameters["BHTN"].Value = BHTN;

                documentViewer1.DocumentSource = reports;
                reports.CreateDocument();
            }
            catch (Exception)
            {


            }
        }
        private void cmbMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadBaoCao();
        }

        private void dtpThang_ValueChanged(object sender, EventArgs e)
        {
            LoadBaoCao();
        }

        private void frmBaoCaoLuongHangThang_Load(object sender, EventArgs e)
        {
            string sql = "Select * from BoPhan Order by TenBoPhan";
            DataTable dt = Core.Core.GetData(sql);
            DataRow dr = dt.NewRow();
            dr["BoPhanID"] = "-1";
            dr["TenBoPhan"] = "Tất cả";
            dt.Rows.InsertAt(dr, 0);

            cbbBoPhan.DataSource = dt;
            cbbBoPhan.ValueMember = "BoPhanID";
            cbbBoPhan.DisplayMember = "TenBoPhan";
            
            LoadBaoCao();
        }

        private void cbbBoPhan_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadBaoCao();
        }
    }
}
