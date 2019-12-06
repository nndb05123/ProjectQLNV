using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRM_VTHP.HeThong
{
    public partial class frmPhucHoiDuLieu : Form
    {
        public frmPhucHoiDuLieu()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Backup File File|*.bak";
            saveFileDialog1.Title = "Chọn file khôi phục";
            saveFileDialog1.FileName = "";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                lblTenFile.Text = openFileDialog1.FileName;
            }
            else
            {
                lblTenFile.Text = "";
            }
        }

        private void btnPhucHoi_Click(object sender, EventArgs e)
        {
            try
            {
                // phục hồi dữ liệu
                string sql = "restore database HRM_VTHP from disk = '" + lblTenFile.Text + "' [With NoRecovery]";
                Core.Core.RunSql(sql);
                // run sql

                MessageBox.Show("Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi phục hồi");
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
