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
    public partial class frmChiTietTamUng : Form
    {
        public frmChiTietTamUng()
        {
            InitializeComponent();
        }
        int kt = 0;
        int PhieuTamUngID = 0;
        void Load_DL()
        {
            string sql = @"select e.TenBoPhan, f.TrangThaiID, f.TenNV, f.MaNV, f.NhanVienID, f.GhiChu, f.PhieuTamUngID, f.ThangTamUng, f.MaPhieuTamUng, f.NgayLap, f.TamUng, f.TenTamUng,f.BoPhanID,f.TamUngID from BoPhan e inner join
                        (select a.MaPhieuTamUng,a.PhieuTamUngID, a.NgayLap, a.NhanVienID, a.TrangThaiID, a.TamUng,a.ThangTamUng, d.BoPhanID, a.GhiChu, b.TenNV, b.MaNV, c.TenTamUng,c.TamUngID from ChiTietTamUng a 
                        inner join NhanVien b on a.NhanVienID = b.NhanVienID
                        inner join TamUng c on a.TamUngID = c.TamUngID
                        inner join NhanVienBoPhan d on a.NhanVienID = d.NhanVienID) as f on e.BoPhanID = f.BoPhanID";
            DataTable dt = Core.Core.GetData(sql);
            grdChiTietTamUng.DataSource = dt;
        }
        void Reset()
        {
            cmbBoPhan.Enabled = false;
            cmbNhanVien.Enabled = false;
            cmbLoaiTamUng.Enabled = false;
            btnCapNhat.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnHuyBo.Enabled = false;
            txtGhiChu.Enabled = false;
            txtGhiChu.Text = "";
            txtMaPhieu.Enabled = false;
            txtMaPhieu.Text = "";
            txtSoTienTamUng.Text = "";
            txtSoTienTamUng.Enabled = false;
            dtpThang.Enabled = false;
        }

        private void frmChiTietTamUng_Load(object sender, EventArgs e)
        {
            Load_DL();
            Reset();
            string sql = "Select * from TamUng";
            DataTable dtTamUng = Core.Core.GetData(sql);
            cmbLoaiTamUng.DataSource = dtTamUng;
            cmbLoaiTamUng.ValueMember = "TamUngID";
            cmbLoaiTamUng.DisplayMember = "TenTamUng";
            sql = "Select * from BoPhan";
            DataTable dt = Core.Core.GetData(sql);
            cmbBoPhan.DataSource = dt;
            cmbBoPhan.ValueMember = "BoPhanID";
            cmbBoPhan.DisplayMember = "TenBoPhan";
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
            cmbBoPhan.Enabled = true;
            cmbNhanVien.Enabled = true;
            cmbLoaiTamUng.Enabled = true;
            btnCapNhat.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnHuyBo.Enabled = true;
            txtGhiChu.Enabled = true;
            txtGhiChu.Text = "";
            txtMaPhieu.Enabled = true;
            txtMaPhieu.Text = "";
            txtSoTienTamUng.Text = "";
            txtSoTienTamUng.Enabled = true;
            dtpThang.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            kt = 2;
            cmbBoPhan.Enabled = true;
            cmbNhanVien.Enabled = true;
            cmbLoaiTamUng.Enabled = true;
            btnCapNhat.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnHuyBo.Enabled = true;
            txtGhiChu.Enabled = true;           
            txtMaPhieu.Enabled = true;
            txtSoTienTamUng.Enabled = true;
            dtpThang.Enabled = true;
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            Reset();
        }
        protected bool validateHieuSuat()
        {
            string sql = @"Select count(*) as dem from ChiTietTamUng where ThangTamUng = '" + dtpThang.Value.ToString("yyyyMM") + "' and NhanVienID = " + cmbNhanVien.SelectedValue + " ";
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
                if (validateHieuSuat())
                {
                    string sql = "Insert into ChiTietTamUng(MaPhieuTamUng, ThangTamUng, TamUngID, NhanVienID, NgayLap, TamUng, GhiChu, TrangThaiID) values ('" + txtMaPhieu.Text + "', '" + dtpThang.Value.ToString("yyyyMM")+ "', '" + cmbLoaiTamUng.SelectedValue + "', '" + cmbNhanVien.SelectedValue + "', '" + dtpNgayLap.Value+ "','" + txtSoTienTamUng.Text + "','"+txtGhiChu.Text+"', '1')";
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
                    MessageBox.Show("Đã tồn tại bản ghi nhân viên cùng tháng!");
                }
                    
            }
            else
            {
                string sql = "Update ChiTietTamUng set MaPhieuTamUng ='" + txtMaPhieu.Text + "', ThangTamUng = '" + dtpThang.Value.ToString("yyyyMM") + "', TamUngID = '" + cmbLoaiTamUng.SelectedValue + "', NhanVienID = '" + cmbNhanVien.SelectedValue + "', NgayLap = '" + dtpNgayLap.Value + "', TamUng = '" + txtSoTienTamUng.Text + "', GhiChu ='"+txtGhiChu.Text+"' where PhieuTamUngID = '" + PhieuTamUngID + "'";
                Core.Core.RunSql(sql);
                Load_DL();
            }
            Reset();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql = "Delete ChiTietTamUng where PhieuTamUngID = '" + PhieuTamUngID + "'";
            Core.Core.RunSql(sql);
            Load_DL();
            Reset();
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            PhieuTamUngID = int.Parse(gridView1.GetFocusedRowCellValue("PhieuTamUngID").ToString());
            txtGhiChu.Text = gridView1.GetFocusedRowCellValue("GhiChu").ToString();
            cmbBoPhan.SelectedValue = int.Parse(gridView1.GetFocusedRowCellValue("BoPhanID").ToString());
            cmbLoaiTamUng.SelectedValue = int.Parse(gridView1.GetFocusedRowCellValue("TamUngID").ToString());
            txtMaPhieu.Text = gridView1.GetFocusedRowCellValue("MaPhieuTamUng").ToString();
            txtSoTienTamUng.Text = gridView1.GetFocusedRowCellValue("TamUng").ToString();
            dtpNgayLap.Value = DateTime.Parse(gridView1.GetFocusedRowCellValue("NgayLap").ToString());
            
            dtpThang.Value = DateTime.ParseExact(gridView1.GetFocusedRowCellValue("ThangTamUng").ToString().Trim() + "01", "yyyyMMdd", CultureInfo.InvariantCulture);
            cmbNhanVien.SelectedValue = int.Parse(gridView1.GetFocusedRowCellValue("NhanVienID").ToString());
        }
    }
}
