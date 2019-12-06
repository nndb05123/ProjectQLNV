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
    public partial class frmThongKeHopDongHetHan : Form
    {
        public frmThongKeHopDongHetHan()
        {
            InitializeComponent();
        }
        protected void LoadBaoCao()
        {
            try
            {

                ThongKeHopDongHetHan reports = new ThongKeHopDongHetHan(cmbTrangThai.Text);

                reports.Parameters["TrangThaiID"].Value = cmbTrangThai.SelectedValue.ToString();
                documentViewer1.DocumentSource = reports;
                reports.CreateDocument();
            }
            catch (Exception)
            {

            }
        }

        private void frmThongKeHopDongHetHan_Load(object sender, EventArgs e)
        {
            cmbTrangThai.DisplayMember = "Text";
            cmbTrangThai.ValueMember = "Value";

            var items = new[] {
                    new { Text = "Hết hiệu lực", Value = "0" },
                    new { Text = "Có hiệu lực", Value = "1" }
            };

            cmbTrangThai.DataSource = items;
            LoadBaoCao();
        }

        private void cmbTrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadBaoCao();
        }
    }
}
