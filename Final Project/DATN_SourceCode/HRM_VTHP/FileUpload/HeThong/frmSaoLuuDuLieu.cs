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
    public partial class frmSaoLuuDuLieu : Form
    {
        public frmSaoLuuDuLieu()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialog1.Filter = "Backup File File|*.bak";
                saveFileDialog1.Title = "Save an Backup File";
                saveFileDialog1.FileName = "HRM_VTHP" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".bak";
                //saveFileDialog1.ShowDialog();

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    lblTenFile.Text = saveFileDialog1.FileName;
                }
                else
                {
                    lblTenFile.Text = "";
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void btnSaoLuu_Click(object sender, EventArgs e)
        {
            try
            {
                // thực hiện backup file
                string sql = "backup database HRM_VTHP to disk = '" + lblTenFile.Text + "' ";
                Core.Core.RunSql(sql);
                // run sql

                MessageBox.Show("Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi sao lưu");
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
