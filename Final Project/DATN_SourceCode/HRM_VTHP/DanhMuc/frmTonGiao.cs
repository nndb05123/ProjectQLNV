using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRM_VTHP.DanhMuc
{
    public partial class frmTonGiao : Form
    {
        public frmTonGiao()
        {
            InitializeComponent();
        }
        int kt = 0;
        int TonGiaoID = 0;
        void Load_DL()
        {
            string sql = "Select * from TonGiao";
            DataTable dt = Core.Core.GetData(sql);
            grdTonGiao.DataSource = dt;
        }
        void Reset()
        {
            txtTonGiao.Text = "";
            txtTonGiao.Enabled = false;
            btnThem.Enabled = true;
            btnCapNhat.Enabled = false;
            btnSua.Enabled = false;
            btnHuyBo.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void frmTonGiao_Load(object sender, EventArgs e)
        {
            Load_DL();
            Reset();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            kt = 1;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnCapNhat.Enabled = true;
            btnXoa.Enabled = false;
            btnHuyBo.Enabled = true;
            txtTonGiao.Text = "";
            txtTonGiao.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            kt = 2;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnHuyBo.Enabled = true;
            btnXoa.Enabled = false;
            btnCapNhat.Enabled = true;
            txtTonGiao.Enabled = true;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if(kt == 1)
            {
                if (txtTonGiao.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập tôn giáo");
                }
                else
                {
                    string sql = "Insert into TonGiao(TenTonGiao) values (N'" + txtTonGiao.Text + "')";
                    if (Core.Core.RunSql(sql) == -1)
                    {
                        MessageBox.Show("Lỗi khi thêm mới");
                    }

                    else
                    {
                        Load_DL();
                    }
                }
            }
            else
            {
                string sql = "Update TonGiao set TenTonGiao =N'" + txtTonGiao.Text + "' where TonGiaoID = '" + TonGiaoID + "'";
                Core.Core.RunSql(sql);
                Load_DL();
            }
            Reset();
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            TonGiaoID = int.Parse(gridView1.GetFocusedRowCellValue("TonGiaoID").ToString());
            txtTonGiao.Text = gridView1.GetFocusedRowCellValue("TenTonGiao").ToString();
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql = "Select * from HoSoNhanVien where TonGiaoID = '" + TonGiaoID + "'";
            DataTable dt = Core.Core.GetData(sql);
            if(dt.Rows.Count > 0)
            {
                MessageBox.Show("Bạn phải xóa bản ghi trong Hồ sơ nhân viên");
            }
            else
            {
                sql = "Delete TonGiao where TonGiaoID = '" + TonGiaoID + "'";
                Core.Core.RunSql(sql);
                Load_DL();
                Reset();
            }
        }

        private void txtTonGiao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Bạn không được phép nhập số");
            }
        }

        private void btnHuyBo_Click_1(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
