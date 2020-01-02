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

            DataTable dt = KhenThuongKyLuatBUS.Instance.LoadData_KhenThuongKyLuat();
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
            DataTable dt = LoaiQuyetDinhBUS.Instance.LoadAllLoaiQuyetDinh();
            cmbQuyetDinh.DataSource = dt;
            cmbQuyetDinh.ValueMember = "LoaiQuyetDinhID";
            cmbQuyetDinh.DisplayMember = "TenLoaiQuyetDinh";
            DataTable dt1 = BoPhanBUS.Instance.LoadAllBoPhan();
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
            KhenThuongKyLuatDTO khenThuongKyLuatDTO = new KhenThuongKyLuatDTO();
            khenThuongKyLuatDTO.NhanVienID = int.Parse(cmbNhanVien.SelectedValue.ToString());
            khenThuongKyLuatDTO.LoaiQuyetDinhID = int.Parse(cmbQuyetDinh.SelectedValue.ToString());
            khenThuongKyLuatDTO.NgayQuyetDinh = dtpNgayQuyetDinh.Value;
            khenThuongKyLuatDTO.GhiChu = txtGhiChu.Text;



            if (kt == 1)
            {
               
                if (KhenThuongKyLuatBUS.Instance.Add_KhenThuongKyLuat(khenThuongKyLuatDTO) == -1)
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
                KhenThuongKyLuatBUS.Instance.Update_KhenThuongKyLuat(khenThuongKyLuatDTO, KhenThuongKyLuatID);
                Load_DL();
            }
            Reset();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            KhenThuongKyLuatBUS.Instance.Delete_KhenThuongKyLuat(KhenThuongKyLuatID);
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
