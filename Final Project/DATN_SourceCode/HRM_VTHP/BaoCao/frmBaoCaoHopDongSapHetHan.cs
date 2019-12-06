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
    public partial class frmBaoCaoHopDongSapHetHan : Form
    {
        public frmBaoCaoHopDongSapHetHan()
        {
            InitializeComponent();
        }

        protected void LoadBaoCao()
        {
            try
            {
                BaoCaoHopDongHetHan reports = new BaoCaoHopDongHetHan();
                reports.Parameters["SoNgay"].Value = Convert.ToInt32(txtSoNgay.Value);
                documentViewer1.DocumentSource = reports;
                reports.CreateDocument();
            }
            catch (Exception)
            {

            }
        }

        private void frmBaoCaoHopDongSapHetHan_Load(object sender, EventArgs e)
        {
            LoadBaoCao();
        }

        private void txtSoNgay_ValueChanged(object sender, EventArgs e)
        {
            LoadBaoCao();
        }
    }
}
