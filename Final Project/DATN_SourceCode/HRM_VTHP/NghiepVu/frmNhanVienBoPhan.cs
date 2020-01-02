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

            DataTable dt = NhanVienBoPhanBUS.Instance.LoadAllNhanVien();
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

            DataTable dt = NhanVienBoPhanBUS.Instance.LoadData_NhanVien();
            cmbTenNV.DataSource = dt;
            cmbTenNV.ValueMember = "NhanVienID";
            cmbTenNV.DisplayMember = "TenNV";
           
            DataTable dt1 = NhanVienBoPhanBUS.Instance.LoadData_BoPhan();
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
            NhanVienBoPhanDTO nhanVienBoPhanDTO = new NhanVienBoPhanDTO();
            nhanVienBoPhanDTO.NhanVienID = int.Parse(cmbTenNV.SelectedValue.ToString());
            nhanVienBoPhanDTO.BoPhanID = int.Parse(cmbBoPhan.SelectedValue.ToString());

            if (kt == 1)
            {
              
                if(NhanVienBoPhanBUS.Instance.Add_NhanVien_BoPhan(nhanVienBoPhanDTO) == -1)
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

                NhanVienBoPhanBUS.Instance.Add_NhanVien_BoPhan(nhanVienBoPhanDTO);
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

            DataTable dtNVCD = NhanVienBoPhanBUS.Instance.Load_NhanVienChucDanh(NhanVienID);
            if (dtNVCD.Rows.Count > 0)
            {
                MessageBox.Show("Đã giao nhân viên về chức danh");
            }
            else
            {
                NhanVienBoPhanDTO nhanVienBoPhanDTO = new NhanVienBoPhanDTO();
                nhanVienBoPhanDTO.NhanVienID = int.Parse(cmbTenNV.SelectedValue.ToString());
                nhanVienBoPhanDTO.BoPhanID = int.Parse(cmbBoPhan.SelectedValue.ToString());
                NhanVienBoPhanBUS.Instance.Delete_NhanVien_BoPhan(nhanVienBoPhanDTO);
                Load_DL();
            }
            Reset();
        }
    }
}
