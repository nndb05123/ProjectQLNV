using HRM_VTHP.Core.BUS;
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
    public partial class frmBaoCaoKTKL : Form
    {
        public frmBaoCaoKTKL()
        {
            InitializeComponent();
        }
        protected void LoadBaoCao()
        {
            try
            {

                BaoCaoKhenThuongKyLuat reports = new BaoCaoKhenThuongKyLuat(cmbBoPhan.Text, cmbBoPhan.SelectedValue.ToString(), cmbLoaiQuyetDinh.Text, cmbLoaiQuyetDinh.SelectedValue.ToString());
                
                reports.Parameters["BoPhanID"].Value = int.Parse( cmbBoPhan.SelectedValue.ToString());
                reports.Parameters["LoaiQuyetDinhID"].Value = int.Parse(cmbLoaiQuyetDinh.SelectedValue.ToString());
                documentViewer1.DocumentSource = reports;
                reports.CreateDocument();
            }
            catch (Exception)
            {

            }
        }

        private void cmbBoPhan_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadBaoCao();
        }

        private void cmbLoaiQuyetDinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadBaoCao();
        }

        private void frmBaoCaoKTKL_Load(object sender, EventArgs e)
        {
            LoadBaoCao();
            DataTable dt = BoPhanBUS.Instance.LoadAllBoPhan();
            cmbBoPhan.DataSource = dt;
            cmbBoPhan.ValueMember = "BoPhanID";
            cmbBoPhan.DisplayMember = "TenBoPhan";
            string sql = "Select *from LoaiQuyetDinh";
            DataTable dt1 = Core.Core.GetData(sql);
            cmbLoaiQuyetDinh.DataSource = dt1;
            cmbLoaiQuyetDinh.ValueMember = "LoaiQuyetDinhID";
            cmbLoaiQuyetDinh.DisplayMember = "TenLoaiQuyetDinh";
        }
    }
}
