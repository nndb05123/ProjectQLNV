using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HRM_VTHP.Core;

namespace HRM_VTHP.DanhMuc
{
    public partial class frmDanToc : Form
    {
        int kt = 0;
        int DanTocID = 0;
        public frmDanToc()
        {
            InitializeComponent();
        }

        private void frmDanToc_Load(object sender, EventArgs e)
        {
            Reset();
            Load_DuLieu();
        }

        void Reset()
        {
            txtDanToc.Text = "";
            txtDanToc.Enabled = false;
            btnSua.Enabled = false;
            btnCapNhat.Enabled = false;
            btnHuyBo.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = true;
        }
        void Load_DuLieu()
        {
            string sql = "Select * from DanToc";
            DataTable dt = Core.Core.GetData(sql);
            grdDanToc.DataSource = dt;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            kt = 1;
            txtDanToc.Text = "";
            txtDanToc.Enabled = true;
            btnSua.Enabled = false;
            btnCapNhat.Enabled = true;
            btnHuyBo.Enabled = true;
            btnXoa.Enabled = false;
            btnThem.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            kt = 2;
            txtDanToc.Enabled = true;
            btnThem.Enabled = false;
            btnCapNhat.Enabled = true;
            btnHuyBo.Enabled = true;
            btnXoa.Enabled = false;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if(kt == 1)
            {
                if (txtDanToc.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập tên dân tộc");
                }
                else
                {
                    string sql = "";
                    sql = "Insert into DanToc(TenDanToc) values (N'" + txtDanToc.Text + "')";
                    if (Core.Core.RunSql(sql) == -1)
                    {
                        MessageBox.Show("Lỗi khi thêm mới!");
                    }
                    else
                    {
                        Load_DuLieu();
                    }
                }
            }
            else
            {
                //Update du lieu
                string sql = "";
                sql = "Update DanToc set TenDanToc = N'" + txtDanToc.Text + "' where DanTocID = '"+DanTocID+"'";
                Core.Core.RunSql(sql);
                Load_DuLieu();
            }
            Reset();
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //delete du lieu
            string sql = "select * from HoSoNhanVien where DanTocID = '"+DanTocID+"'";
            DataTable dt = Core.Core.GetData(sql);
            if(dt.Rows.Count > 0)
            {
                MessageBox.Show("Bạn phải xóa bản ghi trong Hồ sơ nhân viên");
            }
            else
            {
                sql = "Delete DanToc where DanTocID = '" + DanTocID + "'";
                Core.Core.RunSql(sql);
                Load_DuLieu();
                Reset();
            }
            
        }

        private void grdDanToc_Click(object sender, EventArgs e)
        {
            // bỏ
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            DanTocID = int.Parse(gridView1.GetFocusedRowCellValue("DanTocID").ToString());
            txtDanToc.Text = gridView1.GetFocusedRowCellValue("TenDanToc").ToString();
        }

        private void txtDanToc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Bạn không được phép nhập số");
            }
        }
    }
}
