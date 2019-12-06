using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRM_VTHP.BaoCao
{
    public partial class frmThongKeDanhGiaNhanVien : Form
    {
        public frmThongKeDanhGiaNhanVien()
        {
            InitializeComponent();
        }

        protected void LoadBaoCao()
        {
            try
            {
                ThongKeDanhGiaNhanVien reports = new ThongKeDanhGiaNhanVien(cmbTenBoPhan.Text, cmbTenBoPhan.SelectedValue.ToString(), dtpThang.Value.ToString("MM/yyyy"));
                reports.Parameters["BoPhanID"].Value = cmbTenBoPhan.SelectedValue.ToString();
                reports.Parameters["Thang"].Value = dtpThang.Value.ToString("yyyyMM");
                //reports.Parameters["Nam"].Value = cmbNam.SelectedValue.ToString();
                documentViewer1.DocumentSource = reports;
                reports.CreateDocument();
            }
            catch (Exception)
            {


            }
        }

        private void cmbTenBoPhan_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadBaoCao();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            LoadBaoCao();
        }

        private void frmThongKeDanhGiaNhanVien_Load(object sender, EventArgs e)
        {
            LoadBaoCao();
            string sql = "Select * from BoPhan";
            DataTable dt = Core.Core.GetData(sql);
            cmbTenBoPhan.DataSource = dt;
            cmbTenBoPhan.ValueMember = "BoPhanID";
            cmbTenBoPhan.DisplayMember = "TenBoPhan";
        }
    }
}
