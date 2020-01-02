using HRM_VTHP.Core.BUS;
using HRM_VTHP.Core.DTO;
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
    public partial class frmHopDong : Form
    {
        public frmHopDong()
        {
            InitializeComponent();
        }
        int kt = 0;
        int HopDongID = 0;
        void Load_DL()
        {
            DataTable dt = HopDongBUS.Instance.LoadData_HopDong();
            grdHopDong.DataSource = dt;
        }
        void Reset()
        {
            cmbBoPhan.Enabled = false;
            cmbNhanVien.Enabled = false;
            cmbTenLoaiHopDong.Enabled = false;
            dtpNgayHetHan.Enabled = false;
            dtpNgayHieuLuc.Enabled = false;
            dtpNgayKetThuc.Enabled = false;
            dtpNgayKy.Enabled = false;
            btnCapNhat.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnHuybo.Enabled = false;
            txtMaHopDong.Enabled = false;
            txtMaHopDong.Text = "";
            cbTrangThai.Enabled = false;
        }

        private void frmHopDong_Load(object sender, EventArgs e)
        {
           
            DataTable dt = HopDongBUS.Instance.Load_LoaiHopDong();
            cmbTenLoaiHopDong.DataSource = dt;
            cmbTenLoaiHopDong.ValueMember = "LoaiHopDongID";
            cmbTenLoaiHopDong.DisplayMember = "TenLoaiHopDong";
            DataTable dt1 = HopDongBUS.Instance.Load_BoPhan();
            cmbBoPhan.DataSource = dt1;
            cmbBoPhan.ValueMember = "BoPhanID";
            cmbBoPhan.DisplayMember = "TenBoPhan";
            Load_DL();
            Reset();
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
            cmbTenLoaiHopDong.Enabled = true;
            dtpNgayHetHan.Enabled = true;
            dtpNgayHieuLuc.Enabled = true;
            dtpNgayKetThuc.Enabled = true;
            dtpNgayKy.Enabled = true;
            btnCapNhat.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnHuybo.Enabled = true;
            txtMaHopDong.Enabled = true;
            txtMaHopDong.Text = "";
            cbTrangThai.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            kt = 2;
            cmbBoPhan.Enabled = true;
            cmbNhanVien.Enabled = true;
            cmbTenLoaiHopDong.Enabled = true;
            dtpNgayHetHan.Enabled = true;
            dtpNgayHieuLuc.Enabled = true;
            dtpNgayKetThuc.Enabled = true;
            dtpNgayKy.Enabled = true;
            btnCapNhat.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnHuybo.Enabled = true;
            txtMaHopDong.Enabled = true;
            cbTrangThai.Enabled = true;
        }

        private void btnHuybo_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            HopDongDTO hopDongDTO = new HopDongDTO();
            hopDongDTO.MaHopDong = txtMaHopDong.Text;
            hopDongDTO.LoaiHopDongID = int.Parse(cmbTenLoaiHopDong.SelectedValue.ToString());
            hopDongDTO.NgayKy = dtpNgayKy.Value;
            hopDongDTO.NgayHieuLuc = dtpNgayHieuLuc.Value;
            hopDongDTO.NgayHetHan = dtpNgayHetHan.Value;
            hopDongDTO.NhanVienID = int.Parse(cmbNhanVien.SelectedValue.ToString());
            hopDongDTO.NgayKetThuc = dtpNgayKetThuc.Value;
            hopDongDTO.TrangThai = cbTrangThai.Checked;
            if (kt == 1)
            {
                if (HopDongBUS.Instance.Add_HopDong(hopDongDTO) == -1)
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
                HopDongBUS.Instance.Update_HopDong(hopDongDTO, HopDongID);
                Load_DL();
            }
            Reset();
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            HopDongID = int.Parse(gridView1.GetFocusedRowCellValue("HopDongID").ToString());
            txtMaHopDong.Text = gridView1.GetFocusedRowCellValue("MaHopDong").ToString();
            cmbBoPhan.SelectedValue = int.Parse(gridView1.GetFocusedRowCellValue("BoPhanID").ToString());
            cmbNhanVien.SelectedValue = int.Parse(gridView1.GetFocusedRowCellValue("NhanVienID").ToString());
            cmbTenLoaiHopDong.SelectedValue = int.Parse(gridView1.GetFocusedRowCellValue("LoaiHopDongID").ToString());
            dtpNgayKy.Value = DateTime.Parse(gridView1.GetFocusedRowCellValue("NgayKy").ToString());
            dtpNgayHieuLuc.Value = DateTime.Parse(gridView1.GetFocusedRowCellValue("NgayHieuLuc").ToString());
            dtpNgayKetThuc.Value = DateTime.Parse(gridView1.GetFocusedRowCellValue("NgayKetThuc").ToString());
            dtpNgayHetHan.Value = DateTime.Parse(gridView1.GetFocusedRowCellValue("NgayHetHan").ToString());
            cbTrangThai.Checked = Boolean.Parse(gridView1.GetFocusedRowCellValue("TrangThai").ToString());
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            HopDongBUS.Instance.Delete_HopDong(HopDongID);
            Load_DL();
            Reset();
        }
    }
}
