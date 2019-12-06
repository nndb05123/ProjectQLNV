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
    public partial class frmKhenThuongKiLuat : Form
    {
        public frmKhenThuongKiLuat()
        {
            InitializeComponent();
        }
        int kt = 0;
        int KhenThuongKyLuatID = 0;
        void Load_DL()
        {
            string sql = @"select f.KhenThuongKyLuatID, f.NhanVienID, f.MaNV, f.TenNV, e.TenBoPhan, f.BoPhanID, f.TenLoaiQuyetDinh, f.LoaiQuyetDinhID, f.NgayQuyetDinh, f.GhiChu from BoPhan e
                        inner join
                        (select a.KhenThuongKyLuatID, a.NhanVienID, a.GhiChu, b.TenNV, b.MaNV, a.LoaiQuyetDinhID, a.NgayQuyetDinh, c.TenLoaiQuyetDinh, d.BoPhanID from KhenThuongKyLuat a
                        inner join NhanVien b on a.NhanVienID = b.NhanVienID inner join LoaiQuyetDinh c on a.LoaiQuyetDinhID = c.LoaiQuyetDinhID
                        inner join NhanVienBoPhan d on a.NhanVienID = d.NhanVienID) as f on e.BoPhanID = f.BoPhanID";
            DataTable dt = Core.Core.GetData(sql);
            grdKhenThuongKiLuat.DataSource = dt;
        }
        void Reset()
        {
            cmbBoPhan.Enabled = false;
            cmbNhanVien.Enabled = false;
            cmbQuyetDinh.Enabled = false;
            dtpNgayQuyetDinh.Enabled = false;
            btnCapNhat.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnHuybo.Enabled = false;
            txtGhiChu.Enabled = false;
            txtGhiChu.Text = "";
        }

        private void frmKhenThuongKiLuat_Load(object sender, EventArgs e)
        {
            string sql = "Select * from LoaiQuyetDinh";
            DataTable dt = Core.Core.GetData(sql);
            cmbQuyetDinh.DataSource = dt;
            cmbQuyetDinh.ValueMember = "LoaiQuyetDinhID";
            cmbQuyetDinh.DisplayMember = "TenLoaiQuyetDinh";
            sql = "Select * from BoPhan";
            DataTable dt1 = Core.Core.GetData(sql);
            cmbBoPhan.DataSource = dt1;
            cmbBoPhan.ValueMember = "BoPhanID";
            cmbBoPhan.DisplayMember = "TenBoPhan";
            Load_DL();
            Reset();
        }

        private void cmbBoPhan_SelectedIndexChanged(object sender, EventArgs e)
        {
            string BoPhanID = cmbBoPhan.SelectedValue.ToString();
            string sql = "select a.NhanVienID, a.TenNV from NhanVien a INNER JOIN NhanVienBoPhan b on a.NhanVienID = b.NhanVienID and b.BoPhanID = '" + BoPhanID + "'";
            DataTable dtNhanVien = Core.Core.GetData(sql);
            cmbNhanVien.DataSource = dtNhanVien;
            cmbNhanVien.ValueMember = "NhanVienID";
            cmbNhanVien.DisplayMember = "TenNV";
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
            cmbNhanVien.Enabled = true;
            cmbQuyetDinh.Enabled = true;
            dtpNgayQuyetDinh.Enabled = true;
            txtGhiChu.Enabled = true;
            txtGhiChu.Text = "";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            kt = 2;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnCapNhat.Enabled = true;
            btnHuybo.Enabled = true;
            btnXoa.Enabled = false;
            cmbBoPhan.Enabled = true;
            cmbNhanVien.Enabled = true;
            cmbQuyetDinh.Enabled = true;
            dtpNgayQuyetDinh.Enabled = true;
            txtGhiChu.Enabled = true;
        }

        private void btnHuybo_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (kt == 1)
            {
                string sql = "Insert into KhenThuongKyLuat(NhanVienID, LoaiQuyetDinhID, NgayQuyetDinh, GhiChu) values ('" + cmbNhanVien.SelectedValue + "', '" + cmbQuyetDinh.SelectedValue + "', '"+dtpNgayQuyetDinh.Value+"', N'"+txtGhiChu.Text+"')";
                if (Core.Core.RunSql(sql) == -1)
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
                string sql = "Update KhenThuongKyLuat set NhanVienID ='" + cmbNhanVien.SelectedValue + "', LoaiQuyetDinhID = '" + cmbQuyetDinh.SelectedValue + "', NgayQuyetDinh = '"+dtpNgayQuyetDinh.Value+"', GhiChu = N'"+txtGhiChu.Text+"' where KhenThuongKyLuatID = '" + KhenThuongKyLuatID + "'";
                Core.Core.RunSql(sql);
                Load_DL();
            }
            Reset();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql = "Delete KhenThuongKyLuat where KhenThuongKyLuatID = '" + KhenThuongKyLuatID + "'";
            Core.Core.RunSql(sql);
            Load_DL();
            Reset();
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            KhenThuongKyLuatID = int.Parse(gridView1.GetFocusedRowCellValue("KhenThuongKyLuatID").ToString());
            cmbQuyetDinh.SelectedValue = int.Parse(gridView1.GetFocusedRowCellValue("LoaiQuyetDinhID").ToString());
            txtGhiChu.Text = gridView1.GetFocusedRowCellValue("GhiChu").ToString();
            cmbBoPhan.SelectedValue = int.Parse(gridView1.GetFocusedRowCellValue("BoPhanID").ToString());
            dtpNgayQuyetDinh.Value = DateTime.Parse(gridView1.GetFocusedRowCellValue("NgayQuyetDinh").ToString());
            cmbNhanVien.SelectedValue = int.Parse(gridView1.GetFocusedRowCellValue("NhanVienID").ToString());
        }
    }
}
