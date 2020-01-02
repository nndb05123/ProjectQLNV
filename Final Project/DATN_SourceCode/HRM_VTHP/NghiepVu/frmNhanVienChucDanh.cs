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
    public partial class frmNhanVienChucDanh : Form
    {
        public frmNhanVienChucDanh()
        {
            InitializeComponent();
        }
        int kt = 0;
        int NhanVienID = 0;
        void Load_DL()
        {
            DataTable dt = NhanVienChucDanh.Instance.LoadDaTa_NhanVienChucDanh();
            grdNhanVienChucDanh.DataSource = dt;
        }
        void Reset()
        {
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnHuybo.Enabled = false;
            btnCapNhat.Enabled = false;
            cmbTenChucDanh.Enabled = false;
            cmbBoPhan.Enabled = false;
            cmbNhanVien.Enabled = false;
        }

        private void frmNhanVienChucDanh_Load(object sender, EventArgs e)
        {
          
            DataTable dt1 = NhanVienChucDanh.Instance.Load_BoPhan();
            cmbBoPhan.DataSource = dt1;
            cmbBoPhan.ValueMember = "BoPhanID";
            cmbBoPhan.DisplayMember = "TenBoPhan";
           

            DataTable dt2 = NhanVienChucDanh.Instance.Load_LuongChucDanh();
            cmbTenChucDanh.DataSource = dt2;
            cmbTenChucDanh.ValueMember = "ChucDanhID";
            cmbTenChucDanh.DisplayMember = "TenChucDanh";
            Load_DL();
            Reset();
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
            cmbTenChucDanh.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            kt = 2;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnCapNhat.Enabled = true;
            btnHuybo.Enabled = true;
            btnXoa.Enabled = false;
            cmbNhanVien.Enabled = true;
            cmbBoPhan.Enabled = true;
            cmbTenChucDanh.Enabled = true;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            NhanVienChucDanhDTO nhanVienChucDanhDTO = new NhanVienChucDanhDTO();
            nhanVienChucDanhDTO.NhanVienID = int.Parse(cmbNhanVien.SelectedValue.ToString());
            nhanVienChucDanhDTO.ChucDanhID = int.Parse(cmbTenChucDanh.SelectedValue.ToString());
            if (kt == 1)
            {
                if(cmbNhanVien.SelectedValue.ToString() == "")
                {
                    MessageBox.Show("Không đc phép nhập trùng");
                }
                else if(NhanVienChucDanh.Instance.Add_NhanVienChucDanh(nhanVienChucDanhDTO) == -1)
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
                NhanVienChucDanh.Instance.Update_NhanVienChucDanh(nhanVienChucDanhDTO);
                Load_DL();
            }
            Reset();
        }

        private void btnHuybo_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            NhanVienChucDanhDTO nhanVienChucDanhDTO = new NhanVienChucDanhDTO();
            nhanVienChucDanhDTO.NhanVienID = int.Parse(cmbNhanVien.SelectedValue.ToString());
            nhanVienChucDanhDTO.ChucDanhID = int.Parse(cmbTenChucDanh.SelectedValue.ToString());
            NhanVienChucDanh.Instance.Delete_NhanVienChucDanh(nhanVienChucDanhDTO);

            Load_DL();
            Reset();
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            cmbTenChucDanh.SelectedValue = int.Parse(gridView1.GetFocusedRowCellValue("ChucDanhID").ToString());
            cmbBoPhan.SelectedValue = int.Parse(gridView1.GetFocusedRowCellValue("BoPhanID").ToString());
            cmbNhanVien.SelectedValue = int.Parse(gridView1.GetFocusedRowCellValue("NhanVienID").ToString());
        }

        private void cmbBoPhan_SelectedIndexChanged(object sender, EventArgs e)
        {
            string BoPhanID = cmbBoPhan.SelectedValue.ToString();
            DataTable dtNhanVien = NhanVienChucDanh.Instance.Load_NhanVienBoPhan(BoPhanID);
            cmbNhanVien.DataSource = dtNhanVien;
            cmbNhanVien.ValueMember = "NhanVienID";
            cmbNhanVien.DisplayMember = "TenNV";
        }
    }
}
