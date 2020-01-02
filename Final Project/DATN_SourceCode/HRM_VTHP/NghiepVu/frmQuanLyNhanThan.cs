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
    public partial class frmQuanLyNhanThan : Form
    {
        public frmQuanLyNhanThan()
        {
            InitializeComponent();
        }
        int kt = 0;
        int NguoiThanID = 0;
        void Load_DL()
        {
            //Chú ý cách t làm
            //oke
            //Bên form nhân viên là đã format r
            //sử dụng mô hình ba lớp: DAO: lưu những câu query, BUS: excute những câu query
            grdQuanlinhanthan.DataSource = NguoiThanBUS.Instance.LoadAllThanNhan();
        }
        void Reset()
        {
            cmbBoPhan.Enabled = false;
            cmbNhanVien.Enabled = false;
            cmbMQH.Enabled = false;
            btnCapNhat.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnHuybo.Enabled = false;
            txtDiaChi.Enabled = false;
            txtDiaChi.Text = "";
            txtNgheNghiep.Text = "";
            txtSDT.Text = "";
            txtTenNguoiThan.Text = "";
            txtNgheNghiep.Enabled = false;
            txtSDT.Enabled = false;
            txtTenNguoiThan.Enabled = false;
        }

        private void frmQuanLiNhanThan_Load(object sender, EventArgs e)
        {
            //Load all bộ phận
            DataTable dt = NguoiThanBUS.Instance.LoadData_BoPhan();
            cmbBoPhan.DataSource = dt;
            cmbBoPhan.ValueMember = "BoPhanID";
            cmbBoPhan.DisplayMember = "TenBoPhan";
           
            //Load all mối quan hệ
            DataTable dt1 = NguoiThanBUS.Instance.LoadData_MoiQuanHe();
            cmbMQH.DataSource = dt1;
            cmbMQH.ValueMember = "MoiQuanHeID";
            cmbMQH.DisplayMember = "TenMoiQuanHe";


            Load_DL();
            Reset();
        }

        private void cmbBoPhan_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Load Nhân Viên theo bộ phận
            string BoPhanID = cmbBoPhan.SelectedValue.ToString();
            DataTable dtNhanVien = NguoiThanBUS.Instance.LoadData_NhanVien_BoPhan(BoPhanID);
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
            cmbMQH.Enabled = true;
            txtDiaChi.Enabled = true;
            txtNgheNghiep.Enabled = true;
            txtSDT.Enabled = true;
            txtTenNguoiThan.Enabled = true;
            txtDiaChi.Text = "";
            txtNgheNghiep.Text = "";
            txtSDT.Text = "";
            txtTenNguoiThan.Text = "";
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
            cmbMQH.Enabled = true;
            txtDiaChi.Enabled = true;
            txtNgheNghiep.Enabled = true;
            txtSDT.Enabled = true;
            txtTenNguoiThan.Enabled = true;
        }

        private void btnHuybo_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            NguoiThanDTO nguoiThan = new NguoiThanDTO();
            nguoiThan.TenNguoiThan = txtTenNguoiThan.Text;
            nguoiThan.NhanVienID = int.Parse(cmbNhanVien.SelectedValue.ToString());
            nguoiThan.MoiQuanHeID = int.Parse(cmbMQH.SelectedValue.ToString());
            nguoiThan.NgheNghiep = txtNgheNghiep.Text;
            nguoiThan.SDT = txtSDT.Text;
            nguoiThan.DiaChi = txtDiaChi.Text;

            if (kt == 1)
            {
               
                if (NguoiThanBUS.Instance.Add_NguoiThan(nguoiThan) == -1)
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
    
                NguoiThanBUS.Instance.Update_NguoiThan(nguoiThan, NguoiThanID);
                Load_DL();
            }
            Reset();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            NguoiThanBUS.Instance.Delete_NguoiThan(NguoiThanID);
            Load_DL();
            Reset();
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            NguoiThanID = int.Parse(gridView1.GetFocusedRowCellValue("NguoiThanID").ToString());
            txtDiaChi.Text = gridView1.GetFocusedRowCellValue("DiaChi").ToString();
            cmbBoPhan.SelectedValue = int.Parse(gridView1.GetFocusedRowCellValue("BoPhanID").ToString());
            cmbMQH.SelectedValue = int.Parse(gridView1.GetFocusedRowCellValue("MoiQuanHeID").ToString());
            txtNgheNghiep.Text = gridView1.GetFocusedRowCellValue("NgheNghiep").ToString();
            txtSDT.Text = gridView1.GetFocusedRowCellValue("SDT").ToString();
            txtTenNguoiThan.Text = gridView1.GetFocusedRowCellValue("TenNguoiThan").ToString();
            cmbNhanVien.SelectedValue = int.Parse(gridView1.GetFocusedRowCellValue("NhanVienID").ToString());
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Bạn không được phép nhập chữ");
            }
        }

        private void txtTenNguoiThan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Bạn không được phép nhập số");
            }
        }
    }
}
