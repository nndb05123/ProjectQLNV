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
    public partial class frmBoPhan : Form
    {
        public frmBoPhan()
        {
            InitializeComponent();
        }
        int kt = 0;
        int BoPhanID = 0;
        void Load_DL()
        {
            string sql = @"Select * from BoPhan";
            DataTable dt = Core.Core.GetData(sql);
            grdBoPhan.DataSource = dt;
        }
        void Reset()
        {
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnCapNhat.Enabled = false;
            btnXoa.Enabled = false;
            btnHuyBo.Enabled = false;
            txtBoPhan.Text = "";
            txtBoPhan.Enabled = false;
        }

        private void frmBoPhan_Load(object sender, EventArgs e)
        {
            Load_DL();
            Reset();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            kt = 1;
            btnCapNhat.Enabled = true;
            btnHuyBo.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            txtBoPhan.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            kt = 2;
            btnCapNhat.Enabled = true;
            btnSua.Enabled = false;
            btnHuyBo.Enabled = true;
            txtBoPhan.Enabled = true;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            BoPhanID = int.Parse(gridView1.GetFocusedRowCellValue("BoPhanID").ToString());
            txtBoPhan.Text = gridView1.GetFocusedRowCellValue("TenBoPhan").ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql = "Select * from NhanVienBoPhan where BoPhanID = '" + BoPhanID + "'";
            DataTable dtNVBP = Core.Core.GetData(sql);
            if(dtNVBP.Rows.Count > 0)
            {
                MessageBox.Show("Bạn phải xóa bản ghi trong NhanVienBoPhan");
            }
            else
            {
                sql = "Delete BoPhan where BoPhanID = '" + BoPhanID + "'";
                Core.Core.RunSql(sql);
                Load_DL();
            }
            
            Reset();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if(kt == 1)
            {
                if(txtBoPhan.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập tên bộ phận");
                }
                else
                {
                    string sql = "Insert into BoPhan(TenBoPhan) values(N'" + txtBoPhan.Text + "')";
                    if(Core.Core.RunSql(sql) == -1)
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
                string sql = "Update BoPhan set TenBoPhan =N'" + txtBoPhan.Text + "' where BoPhanID ='" + BoPhanID + "'";
                Core.Core.RunSql(sql);
                Load_DL();
            }
            Reset();
        }

        private void btnHuyBo_Click_1(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
