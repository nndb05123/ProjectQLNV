using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRM_VTHP.NghiepVu
{
    public partial class frmDanhGiaHieuSuat : Form
    {
        public frmDanhGiaHieuSuat()
        {
            InitializeComponent();
        }
        int kt = 0;
        int DanhGiaHieuSuatID = 0;
        void Load_DL()
        {
            string sql = @"select a.NhanVienID, b.TenNV, a.HieuSuat, a.Thang, a.DanhGiaHieuSuatID, c.BoPhanID from DanhGiaHieuSuat a 
                           inner join NhanVien b on a.NhanVienID = b.NhanVienID
                           inner join NhanVienBoPhan c on a.NhanVienID = c.NhanVienID";
            DataTable dt = Core.Core.GetData(sql);
            grdDanhGiaHieuSuat.DataSource = dt;
        }
        void Reset()
        {
            cmbBoPhan.Enabled = false;
            cmbNhanVien.Enabled = false;
            dtpThang.Enabled = false;
            txtHieuSuatThang.Text = "";
            txtHieuSuatThang.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnCapNhat.Enabled = false;
            btnHuybo.Enabled = false;
            btnXoa.Enabled = false;
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            kt = 1;
            cmbBoPhan.Enabled = true;
            cmbNhanVien.Enabled = true;
            dtpThang.Enabled = true;
            txtHieuSuatThang.Text = "";
            txtHieuSuatThang.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnCapNhat.Enabled = true;
            btnHuybo.Enabled = true;
            btnXoa.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            kt = 2;
            cmbBoPhan.Enabled = true;
            cmbNhanVien.Enabled = true;
            dtpThang.Enabled = true;
            txtHieuSuatThang.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnCapNhat.Enabled = true;
            btnHuybo.Enabled = true;
            btnXoa.Enabled = false;
        }
        protected bool validateHieuSuat()
        {
            string sql = @"Select count(*) as dem from DanhGiaHieuSuat where Thang = '" + dtpThang.Value.ToString("yyyyMM") + "' and NhanVienID = " + cmbNhanVien.SelectedValue + " ";
            DataTable dt = Core.Core.GetData(sql);
            if (dt != null && dt.Rows.Count > 0)
            {
                if (Convert.ToInt32(dt.Rows[0]["dem"].ToString()) > 0)
                    return false;
                else
                    return true;
            }
            else
                return false;
        }
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (kt == 1)
            {
                if(validateHieuSuat())
                {
                    string sql = "Insert into DanhGiaHieuSuat(Thang, NhanVienID, HieuSuat) values ('" + dtpThang.Value.ToString("yyyyMM") + "', '" + cmbNhanVien.SelectedValue + "', '" + txtHieuSuatThang.Text + "')";
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
                    MessageBox.Show("Đã tồn tại hiệu suất tháng cho nhân viên này, không thể thêm mới!");
                }

            }
            else
            {
                string sql = "Update DanhGiaHieuSuat set NhanVienID ='" + cmbNhanVien.SelectedValue + "', Thang = '" + dtpThang.Value.ToString("yyyyMM") + "', HieuSuat = '" + txtHieuSuatThang.Text + "' where DanhGiaHieuSuatID = '" + DanhGiaHieuSuatID + "'";
                Core.Core.RunSql(sql);
                Load_DL();
            }
            Reset();
        }

        private void btnHuybo_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void frmDanhGiaHieuSuat_Load(object sender, EventArgs e)
        {
            string sql = "select * from BoPhan";
            DataTable dt = Core.Core.GetData(sql);
            cmbBoPhan.DataSource = dt;
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql = "Delete DanhGiaHieuSuat where DanhGiaHieuSuatID = '" + DanhGiaHieuSuatID + "'";
            Core.Core.RunSql(sql);
            Load_DL();
            Reset();
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            DanhGiaHieuSuatID = int.Parse(gridView1.GetFocusedRowCellValue("DanhGiaHieuSuatID").ToString());
            dtpThang.Value = DateTime.ParseExact(gridView1.GetFocusedRowCellValue("Thang").ToString().Trim() + "01", "yyyyMMdd", CultureInfo.InvariantCulture);

            txtHieuSuatThang.Text = gridView1.GetFocusedRowCellValue("HieuSuat").ToString();
            cmbBoPhan.SelectedValue = int.Parse(gridView1.GetFocusedRowCellValue("BoPhanID").ToString());
            cmbNhanVien.SelectedValue = int.Parse(gridView1.GetFocusedRowCellValue("NhanVienID").ToString());
        }
    }
}
