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
    public partial class frmThongkeSLLaoDong : Form
    {
        public frmThongkeSLLaoDong()
        {
            InitializeComponent();
        }
        protected void LoadBaoCao()
        {
            try
            {

                ThongKeSLLaoDong reports = new ThongKeSLLaoDong(cmbTrangThai.Text);

                reports.Parameters["TrangThaiID"].Value = int.Parse( cmbTrangThai.SelectedValue.ToString());
                documentViewer1.DocumentSource = reports;
                reports.CreateDocument();
            }
            catch (Exception)
            {

            }
        }

        private void cmbTrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {

            LoadBaoCao();
        }

        private void frmThongkeSLLaoDong_Load(object sender, EventArgs e)
        {
            cmbTrangThai.DisplayMember = "Text";
            cmbTrangThai.ValueMember = "Value";

            var items = new[] {
                    new { Text = "Nghỉ việc", Value = "0" },
                    new { Text = "Đang làm việc", Value = "1" }
            };

            cmbTrangThai.DataSource = items;

            LoadBaoCao();

        }
    }
}
