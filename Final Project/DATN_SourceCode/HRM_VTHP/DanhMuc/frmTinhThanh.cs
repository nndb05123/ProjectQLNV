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

namespace HRM_VTHP.DanhMuc
{
    public partial class frmTinhThanh : Form
    {
        public frmTinhThanh()
        {
            InitializeComponent();
        }
        int kt = 0;
        int TinhThanhID = 0;
        void Load_DL()
        {
            grdTinhThanh.DataSource = TinhThanhBUS.Instance.LoadAllTinhThanh();
        }
        void Reset()
        {
            txtTinhThanh.Text = "";
            txtTinhThanh.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnCapNhat.Enabled = false;
            btnXoa.Enabled = false;
            btnHuyBo.Enabled = false;
        }

        private void frmTinhThanh_Load(object sender, EventArgs e)
        {
            Load_DL();
            Reset();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            kt = 1;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnCapNhat.Enabled = true;
            btnHuyBo.Enabled = true;
            btnXoa.Enabled = false;
            txtTinhThanh.Enabled = true;
            txtTinhThanh.Text = "";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            kt = 2;
            btnThem.Enabled = false;
            btnXoa.Enabled = true;
            btnHuyBo.Enabled = true;
            txtTinhThanh.Enabled = true;
            btnSua.Enabled = false;
            btnCapNhat.Enabled = true;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            TinhThanhDTO tinhThanhDTO = new TinhThanhDTO();
            tinhThanhDTO.TinhThanhID = TinhThanhID;
            tinhThanhDTO.TenTinhThanh = txtTinhThanh.Text.Trim();
            if (kt == 1)
            {
                if (txtTinhThanh.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập tên tỉnh thành");
                }
                else
                {
                    //string sql = "Insert into TinhThanh(TenTinhThanh) values (N'" + txtTinhThanh.Text + "')";
                    if (TinhThanhBUS.Instance.ThemTinhThanh(tinhThanhDTO) == -1)
                    {
                        MessageBox.Show("Lỗi khi thêm mới!");
                    }

                    else
                    {
                        Load_DL();
                    }
                }
            }
            else
            {
                TinhThanhBUS.Instance.UpdateTinhThanh(tinhThanhDTO);
                Load_DL();
            }
            Reset();
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            TinhThanhID = int.Parse(gridView1.GetFocusedRowCellValue("TinhThanhID").ToString());
            txtTinhThanh.Text = gridView1.GetFocusedRowCellValue("TenTinhThanh").ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            TinhThanhDTO tinhThanhDTO = new TinhThanhDTO();
            tinhThanhDTO.TinhThanhID = TinhThanhID;
            DataTable dt = TinhThanhBUS.Instance.LoadTinhThanhFromHoSoNhanVien(tinhThanhDTO);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Bạn phải xóa bản ghi trong Hồ sơ nhân viên");
            }
            else
            {
                TinhThanhBUS.Instance.DeleteTinhThanh(tinhThanhDTO);
                Load_DL();
                Reset();
            }
        }

        private void txtTinhThanh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Bạn không được phép nhập số");
            }
        }

        private void btnHuyBo_Click_1(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
