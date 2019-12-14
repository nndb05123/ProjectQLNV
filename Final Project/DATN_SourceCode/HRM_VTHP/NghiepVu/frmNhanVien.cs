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
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }
        int kt = 0;
        int NhanVienID = 0;
        void Load_DL()
        {
            grdNhanVien.DataSource = NhanVienBUS.Instance.LoadAllNhanVien();
        }
        void Reset()
        {
            
            txtMaNV.Text = "";
            txtTenNV.Text = "";
            txtSDT.Text = "";
            txtDiaChi.Text = "";
            txtSoCMND.Text = "";
            txtEmail.Text = "";
            txtEmail.Enabled = false;
            txtMaNV.Enabled = false;
            txtTenNV.Enabled = false;
            txtSDT.Enabled = false;
            txtDiaChi.Enabled = false;
            txtSoCMND.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnCapNhat.Enabled = false;
            btnXoa.Enabled = false;
            btnHuybo.Enabled = false;
            dtpNgaySinh.Enabled = false;
            cmbGioiTinh.Enabled = false;
            cbTrangThaiID.Enabled = false;
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            DataTable dt = NhanVienBUS.Instance.LoadAllGioiTinh();
            cmbGioiTinh.DataSource = dt;
            cmbGioiTinh.ValueMember = "GioiTinhID";
            cmbGioiTinh.DisplayMember = "GioiTinh";
            Load_DL();
            Reset();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            kt = 1;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnCapNhat.Enabled = true;
            btnXoa.Enabled = false;
            btnHuybo.Enabled = true;
            txtEmail.Text = "";
            txtDiaChi.Text = "";
            txtMaNV.Text = "";
            txtSoCMND.Text = "";
            txtTenNV.Text = "";
            txtSDT.Text = "";
            cmbGioiTinh.Enabled = true;
            txtMaNV.Enabled = true;
            txtTenNV.Enabled = true;
            txtSoCMND.Enabled = true;
            txtSDT.Enabled = true;
            txtSoCMND.Enabled = true;
            txtEmail.Enabled = true;
            txtDiaChi.Enabled = true;
            dtpNgaySinh.Enabled = true;
            cbTrangThaiID.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            kt = 2;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnCapNhat.Enabled = true;
            btnHuybo.Enabled = true;
            btnXoa.Enabled = false;
            cmbGioiTinh.Enabled = true;
            dtpNgaySinh.Enabled = true;
            txtEmail.Enabled = true;
            txtDiaChi.Enabled = true;
            txtMaNV.Enabled = true;
            txtSoCMND.Enabled = true;
            txtSDT.Enabled = true;
            txtTenNV.Enabled = true;
            cbTrangThaiID.Enabled = true;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            NhanVienDTO nhanVienDTO = new NhanVienDTO();
            nhanVienDTO.MaNV = txtMaNV.Text.Trim();
            nhanVienDTO.TenNV = txtTenNV.Text.Trim();
            nhanVienDTO.NgaySinh = dtpNgaySinh.Value;
            nhanVienDTO.GioiTinhID = bool.Parse(cmbGioiTinh.SelectedValue.ToString());
            nhanVienDTO.SDT = txtSDT.Text.Trim();
            nhanVienDTO.SoCMND = txtSoCMND.Text.Trim();
            nhanVienDTO.Email = txtEmail.Text.Trim();
            nhanVienDTO.DiaChi = txtDiaChi.Text.Trim();
            nhanVienDTO.TrangThaiID = cbTrangThaiID.Checked;
            if (kt == 1)
            {
                if (txtMaNV.Text == "" || txtTenNV.Text == "" || txtDiaChi.Text == "" || txtEmail.Text == "" || txtSoCMND.Text == "" || txtSDT.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập 1 số thông tin cần nhập");
                }
                else if(txtMaNV.Text.Length >= 8)
                {
                    MessageBox.Show("Bạn không được nhập Mã nhân viên quá 8 ký tự");
                }
                else
                {
                    if(NhanVienBUS.Instance.ThemNhanVien(nhanVienDTO) == -1)
                    {
                        MessageBox.Show("Lỗi khi thêm mới");
                    }
                    else
                    {
                        Load_DL();
                    }
                }
            }
            else
            {
                nhanVienDTO.NhanVienID = NhanVienID;
                NhanVienBUS.Instance.UpdateNhanVien(nhanVienDTO);
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
            // Check Đã giao bộ phận chưa
            // Select bộ phận theo NhanVienID
            string sql = "select * from NhanVienBoPhan where NhanVienID ='" + NhanVienID + "'";
            sql = "Select * from NhanVienChucDanh where NhanVienID = '" + NhanVienID + "'";
            sql = "Select * from NguoiThan where NhanVienID ='" + NhanVienID + "'";
            sql = "Select * from DanhGiaHieuSuat where NhanVienID = '" + NhanVienID + "'";
            sql = "Select * from KhenThuongKyLuat where NhanVienID = '" + NhanVienID + "'";
            sql = "Select * from HoSoNhanVien where NhanVienID = '" + NhanVienID + "'";
            sql = "Select * from HopDong where NhanVienID = '" + NhanVienID + "'";
            sql = "Select * from ChiTietTamUng where NhanVienID = '" + NhanVienID + "'";
            sql = "Select * from NguoiDung where NhanVienID = '" + NhanVienID + "'";
            DataTable dtHSNV = Core.Core.GetData(sql);
            DataTable dtKTKL = Core.Core.GetData(sql);
            DataTable dtDanhGia = Core.Core.GetData(sql);
            DataTable dtBPNV = Core.Core.GetData(sql);
            DataTable dtCDNV = Core.Core.GetData(sql);
            DataTable dtNguoiThan = Core.Core.GetData(sql);
            DataTable dtHopDong = Core.Core.GetData(sql);
            DataTable dtChiTietTamUng = Core.Core.GetData(sql);
            DataTable dtNguoiDung = Core.Core.GetData(sql);
            // Nếu số lượng > 0 thì thông báo đã giao bộ phận
            if (dtBPNV.Rows.Count > 0)
            {
                MessageBox.Show("Đã giao nhân viên về bộ phận");
            }
            else if (dtCDNV.Rows.Count > 0)
            {
                MessageBox.Show("Đã giao nhân viên về chức danh");
            }
            else if (dtNguoiThan.Rows.Count > 0)
            {
                MessageBox.Show("Bạn phải xóa bản ghi trong QuanLyNhanThan");
            }
            else if(dtKTKL.Rows.Count > 0)
            {
                MessageBox.Show("Bạn phải xóa bản ghi trong KTKL");
            }
            else if(dtDanhGia.Rows.Count > 0)
            {
                MessageBox.Show("Bạn phải xóa bản ghi trong Đánh giá");
            }
            else if(dtHSNV.Rows.Count > 0)
            {
                MessageBox.Show("Bạn phải xóa bản ghi trong HSNV");
            }
            else if(dtHopDong.Rows.Count > 0)
            {
                MessageBox.Show("Bạn phải xóa bản ghi trong hợp đồng");
            }
            else if(dtChiTietTamUng.Rows.Count > 0)
            {
                MessageBox.Show("Bạn phải xóa bản ghi trong ChiTietTamUng");
            }
            else if(dtNguoiDung.Rows.Count > 0)
            {
                MessageBox.Show("Bạn phải xóa bản ghi trong NguoiDung");
            }
            // Nếu không thì xóa
            else
            {
                NhanVienBUS.Instance.DeleteNhanVien(NhanVienID);
                Load_DL();
            }
             Reset();     
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                NhanVienID = int.Parse(gridView1.GetFocusedRowCellValue("NhanVienID").ToString());
                txtDiaChi.Text = gridView1.GetFocusedRowCellValue("DiaChi").ToString();
                txtEmail.Text = gridView1.GetFocusedRowCellValue("Email").ToString();
                txtMaNV.Text = gridView1.GetFocusedRowCellValue("MaNV").ToString();
                txtSoCMND.Text = gridView1.GetFocusedRowCellValue("SoCMND").ToString();
                txtSDT.Text = gridView1.GetFocusedRowCellValue("SDT").ToString();
                txtTenNV.Text = gridView1.GetFocusedRowCellValue("TenNV").ToString();
                cmbGioiTinh.SelectedValue = Boolean.Parse(gridView1.GetFocusedRowCellValue("GioiTinhID").ToString());
                dtpNgaySinh.Value = DateTime.Parse(gridView1.GetFocusedRowCellValue("NgaySinh").ToString());
                cbTrangThaiID.Checked = Boolean.Parse(gridView1.GetFocusedRowCellValue("TrangThaiID").ToString());
            }
            catch(Exception ex)
            {
                MessageBox.Show("Không thể hiển thị thông tin nhân viên!");
            }
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Bạn không được phép nhập chữ");
            }
        }

        private void txtSoCMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Bạn không được phép nhập chữ");
            }
        }

        private void txtTenNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Bạn không được phép nhập số");
            }
        }
    }
}
