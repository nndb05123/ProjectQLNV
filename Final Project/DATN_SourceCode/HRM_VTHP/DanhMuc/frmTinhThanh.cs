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
    public partial class frmTinhThanh : Form
    {
        public frmTinhThanh()
        {
            InitializeComponent();
        }
        int kt = 0;
        int TinhThanhID = 0;
        void Load_DL()
        {
            string sql = @"Select * from TinhThanh";
            DataTable dt = Core.Core.GetData(sql);
            grdTinhThanh.DataSource = dt;
        }
        void Reset()
        {
            txtTinhThanh.Text = "";
            txtTinhThanh.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnCapNhat.Enabled = false;
            btnXoa.Enabled = false;
            btnHuyBo.Enabled = false;
        }

        private void frmTinhThanh_Load(object sender, EventArgs e)
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
            btnHuyBo.Enabled = true;
            btnXoa.Enabled = false;
            txtTinhThanh.Enabled = true;
            txtTinhThanh.Text = "";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            kt = 2;
            btnThem.Enabled = false;
            btnXoa.Enabled = true;
            btnHuyBo.Enabled = true;
            txtTinhThanh.Enabled = true;
            btnSua.Enabled = false;
            btnCapNhat.Enabled = true;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (kt == 1)
            {
                if (txtTinhThanh.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập tên tỉnh thành");
                }
                else
                {
                    string sql = "Insert into TinhThanh(TenTinhThanh) values (N'" + txtTinhThanh.Text + "')";
                    if (Core.Core.RunSql(sql) == -1)
                    {
                        MessageBox.Show("Lỗi khi thêm mới!");
                    }

                    else
                    {
                        Load_DL();
                    }
                }
            }
            else
            {
                string sql = "Update TinhThanh set TenTinhThanh = N'" + txtTinhThanh.Text + "' where TinhThanhID = '" + TinhThanhID + "'";
                Core.Core.RunSql(sql);
                Load_DL();
            }
            Reset();
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            TinhThanhID = int.Parse(gridView1.GetFocusedRowCellValue("TinhThanhID").ToString());
            txtTinhThanh.Text = gridView1.GetFocusedRowCellValue("TenTinhThanh").ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql = "Select * from HoSoNhanVien where TinhThanhID = '" + TinhThanhID + "'";
            DataTable dt = Core.Core.GetData(sql);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Bạn phải xóa bản ghi trong Hồ sơ nhân viên");
            }
            else
            {
                sql = "Delete TinhThanh where TinhThanhID = '" + TinhThanhID + "'";
                Core.Core.RunSql(sql);
                Load_DL();
                Reset();
            }
        }

        private void txtTinhThanh_KeyPress(object sender, KeyPressEventArgs e)
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
