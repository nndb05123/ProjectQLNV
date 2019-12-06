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
    public partial class frmLoaiQuyetDinh : Form
    {
        public frmLoaiQuyetDinh()
        {
            InitializeComponent();
        }
        int kt = 0;
        int LoaiQuyetDinhID = 0;
        void Load_DL()
        {
            string sql = "Select * from LoaiQuyetDinh";
            DataTable dt = Core.Core.GetData(sql);
            grdLoaiQD.DataSource = dt;
        }
        void Reset()
        {
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnCapNhat.Enabled = false;
            btnHuyBo.Enabled = false;
            btnXoa.Enabled = false;
            txtLoaiQD.Text = "";
            txtLoaiQD.Enabled = false;
        }

        private void frmLoaiQuyetDinh_Load(object sender, EventArgs e)
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
            txtLoaiQD.Text = "";
            txtLoaiQD.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            kt = 2;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnCapNhat.Enabled = true;
            btnHuyBo.Enabled = true;
            btnXoa.Enabled = false;
            txtLoaiQD.Enabled = true;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (kt == 1)
            {
                if (txtLoaiQD.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập tên loại quyết định");
                }
                else
                {
                    string sql = "Insert into LoaiQuyetDinh(TenLoaiQuyetDinh) values(N'" + txtLoaiQD.Text + "')";
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
                string sql = "Update LoaiQuyetDinh set TenLoaiQuyetDinh =N'" + txtLoaiQD.Text + "' where LoaiQuyetDinhID ='" + LoaiQuyetDinhID + "'";
                Core.Core.RunSql(sql);
                Load_DL();
            }
            Reset();
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql = "Select * from KhenThuongKyLuat where LoaiQuyetDinhID ='" + LoaiQuyetDinhID + "'";
            DataTable dt = Core.Core.GetData(sql);
            if(dt.Rows.Count > 0)
            {
                MessageBox.Show("Bạn phải xóa bản ghi trong KhenThuongKyLuat");
            }
            else
            {
                sql = "Delete LoaiQuyetDinh where LoaiQuyetDinhID ='" + LoaiQuyetDinhID + "'";
                Core.Core.RunSql(sql);
                Load_DL();
                Reset();
            }
            
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            LoaiQuyetDinhID = int.Parse(gridView1.GetFocusedRowCellValue("LoaiQuyetDinhID").ToString());
            txtLoaiQD.Text = gridView1.GetFocusedRowCellValue("TenLoaiQuyetDinh").ToString();
        }

        private void btnHuyBo_Click_1(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
