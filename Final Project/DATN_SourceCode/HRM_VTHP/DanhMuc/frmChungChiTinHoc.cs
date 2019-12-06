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
    public partial class frmChungChiTinHoc : Form
    {
        public frmChungChiTinHoc()
        {
            InitializeComponent();
        }
        int kt = 0;
        int TinHocID = 0;
        void Load_DL()
        {
            string sql = "Select * from TinHoc";
            DataTable dt = Core.Core.GetData(sql);
            grdTinHoc.DataSource = dt;
        }
        void Reset()
        {
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnCapNhat.Enabled = false;
            btnHuyBo.Enabled = false;
            btnXoa.Enabled = false;
            txtCCTinHoc.Text = "";
            txtCCTinHoc.Enabled = false;
        }

        private void frmChungChiTinHoc_Load(object sender, EventArgs e)
        {
            Load_DL();
            Reset();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            kt = 1;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnHuyBo.Enabled = true;
            btnXoa.Enabled = false;
            txtCCTinHoc.Text = "";
            txtCCTinHoc.Enabled = true;
            btnCapNhat.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            kt = 2;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnCapNhat.Enabled = true;
            btnXoa.Enabled = false;
            txtCCTinHoc.Enabled = true;
            btnHuyBo.Enabled = true;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (kt == 1)
            {
                if(txtCCTinHoc.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập tên chứng chỉ tin học");
                }
                else
                {
                    string sql = "Insert into TinHoc(TenCCTH) values (N'" + txtCCTinHoc.Text + "')";
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
                string sql = "Update TinHoc set TenCCTH = N'" + txtCCTinHoc.Text + "' where TinHocID = '" + TinHocID + "'";
                Core.Core.RunSql(sql);
                Load_DL();
            }
            Reset();
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            TinHocID = int.Parse(gridView1.GetFocusedRowCellValue("TinHocID").ToString());
            txtCCTinHoc.Text = gridView1.GetFocusedRowCellValue("TenCCTH").ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql = "Select * from HoSoNhanVien where TinHocID = '" + TinHocID + "'";
            DataTable dt = Core.Core.GetData(sql);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Bạn phải xóa bản ghi trong Hồ sơ nhân viên");
            }
            else
            {
                sql = "Delete TinHoc where TinHocID = '" + TinHocID + "'";
                Core.Core.RunSql(sql);
                Load_DL();
                Reset();
            }
        }

        private void btnHuyBo_Click_1(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
