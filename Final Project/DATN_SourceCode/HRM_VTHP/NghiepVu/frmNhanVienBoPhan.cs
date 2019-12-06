using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRM_VTHP.NghiepVu
{
    public partial class frmNhanVienBoPhan : Form
    {
        public frmNhanVienBoPhan()
        {
            InitializeComponent();
        }
        int kt = 0;
        int NhanVienID = 0;
        //int BoPhanID = 0;
        void Load_DL()
        {
            string sql = @"Select a.NhanVienID, a.BoPhanID, b.TenNV, c.TenBoPhan
                            from ((NhanVienBoPhan a inner join NhanVien b on a.NhanVienID = b.NhanVienID)
                            inner join BoPhan c on a.BoPhanID = c.BoPhanID)";
            DataTable dt = Core.Core.GetData(sql);
            grdNhanVienBoPhan.DataSource = dt;
        }
        void Reset()
        {
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnCapNhat.Enabled = false;
            btnHuybo.Enabled = false;
            btnXoa.Enabled = false;
            cmbBoPhan.Enabled = false;
            cmbTenNV.Enabled = false;
        }

        private void frmNhanVienBoPhan_Load(object sender, EventArgs e)
        {
            Load_DL();
            Reset();
            string sql = "Select * from NhanVien";
            DataTable dt = Core.Core.GetData(sql);
            cmbTenNV.DataSource = dt;
            cmbTenNV.ValueMember = "NhanVienID";
            cmbTenNV.DisplayMember = "TenNV";
            sql = "Select * from BoPhan";
            DataTable dt1 = Core.Core.GetData(sql);
            cmbBoPhan.DataSource = dt1;
            cmbBoPhan.ValueMember = "BoPhanID";
            cmbBoPhan.DisplayMember = "TenBoPhan";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            kt = 1;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnCapNhat.Enabled = true;
            btnHuybo.Enabled = true;
            btnXoa.Enabled = false;
            cmbBoPhan.Enabled = true;
            cmbTenNV.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            kt = 2;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnCapNhat.Enabled = true;
            btnHuybo.Enabled = true;
            btnXoa.Enabled = false;
            cmbTenNV.Enabled = true;
            cmbBoPhan.Enabled = true;
        }

        private void btnHuybo_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if(kt == 1)
            {
                string sql = "Insert into NhanVienBoPhan(NhanVienID, BoPhanID) values ('" + cmbTenNV.SelectedValue + "', '" + cmbBoPhan.SelectedValue + "')";
                if(Core.Core.RunSql(sql) == -1)
                {
                    MessageBox.Show("Lỗi khi thêm mới");
                }
                else
                {
                    Load_DL();
                }
            }
            else
            {
                string sql = "Update NhanVienBoPhan set NhanVienID ='" + cmbTenNV.SelectedValue + "', BoPhanID = '" + cmbBoPhan.SelectedValue + "' where NhanVienID = '" + cmbTenNV.SelectedValue + "'";
                Core.Core.RunSql(sql);
                Load_DL();
            }
            Reset();
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            cmbTenNV.SelectedValue = int.Parse(gridView1.GetFocusedRowCellValue("NhanVienID").ToString());
            cmbBoPhan.SelectedValue = int.Parse(gridView1.GetFocusedRowCellValue("BoPhanID").ToString());
            NhanVienID = int.Parse(gridView1.GetFocusedRowCellValue("NhanVienID").ToString());
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql = "Select * from NhanVienChucDanh where NhanVienID = '"+NhanVienID+"'";
            DataTable dtNVCD = Core.Core.GetData(sql);
            if (dtNVCD.Rows.Count > 0)
            {
                MessageBox.Show("Đã giao nhân viên về chức danh");
            }
            else
            {
                sql = "Delete NhanVienBoPhan where NhanVienID = '" + cmbTenNV.SelectedValue + "' AND BoPhanID = '"+cmbBoPhan.SelectedValue+"'";
                Core.Core.RunSql(sql);
                Load_DL();
            }
            Reset();
        }
    }
}
