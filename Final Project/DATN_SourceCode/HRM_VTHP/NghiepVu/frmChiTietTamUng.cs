using HRM_VTHP.Core.BUS;
using HRM_VTHP.Core.DTO;
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

            DataTable dt = ChiTietTamUngBUS.Instance.LoadData_ChiTietTamUng();
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
           
            DataTable dtTamUng = TamUngBUS.Instance.LoadAllTamUng();
            cmbLoaiTamUng.DataSource = dtTamUng;
            cmbLoaiTamUng.ValueMember = "TamUngID";
            cmbLoaiTamUng.DisplayMember = "TenTamUng";
         
            DataTable dt = BoPhanBUS.Instance.LoadAllBoPhan();
            cmbBoPhan.DataSource = dt;
            cmbBoPhan.ValueMember = "BoPhanID";
            cmbBoPhan.DisplayMember = "TenBoPhan";
        }

        private void cmbBoPhan_SelectedIndexChanged(object sender, EventArgs e)
        {
            string BoPhanID = cmbBoPhan.SelectedValue.ToString();
     
            DataTable dtNhanVien = HopDongBUS.Instance.Load_NhanVienBoPhan(BoPhanID);
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
            ChiTietTamUngDTO chiTietTamUngDTO = new ChiTietTamUngDTO();
            chiTietTamUngDTO.MaPhieuTamUng = txtMaPhieu.Text;
            chiTietTamUngDTO.ThangTamUng = dtpThang.Value.ToString("yyyyMM");
            chiTietTamUngDTO.TamUngID = int.Parse(cmbLoaiTamUng.SelectedValue.ToString());
            chiTietTamUngDTO.NhanVienID = int.Parse(cmbNhanVien.SelectedValue.ToString());
            chiTietTamUngDTO.NgayLap = dtpNgayLap.Value;
            chiTietTamUngDTO.TamUng = float.Parse(txtSoTienTamUng.Text.ToString());
            chiTietTamUngDTO.GhiChu = txtGhiChu.Text;
            if (kt == 1)
            {
                if (validateHieuSuat())
                {
                    if (ChiTietTamUngBUS.Instance.Add_ChiTietTamUng(chiTietTamUngDTO) == -1)
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
                ChiTietTamUngBUS.Instance.Update_ChiTietTamUng(chiTietTamUngDTO, PhieuTamUngID);
                Load_DL();
            }
            Reset();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            ChiTietTamUngBUS.Instance.Delete_ChiTietTamUng(PhieuTamUngID);
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
            
            //dtpThang.Value = DateTime.ParseExact(gridView1.GetFocusedRowCellValue("ThangTamUng").ToString().Trim() + "01", "yyyyMMdd", CultureInfo.InvariantCulture);
            cmbNhanVien.SelectedValue = int.Parse(gridView1.GetFocusedRowCellValue("NhanVienID").ToString());
        }
    }
}
