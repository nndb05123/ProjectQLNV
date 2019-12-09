using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HRM_VTHP.Core;
using HRM_VTHP.Core.BUS;
using HRM_VTHP.Core.DTO;

namespace HRM_VTHP.DanhMuc
{
    public partial class frmChungChiNgoaiNgu : Form
    {
        int kt = 0;
        int NgoaiNguID = 0;
        public frmChungChiNgoaiNgu()
        {
            InitializeComponent();
        }

        private void frmChungChiNgoaiNgu_Load(object sender, EventArgs e)
        {
            Reset();
            Load_DuLieu();
        }
        void Reset()
        {
            txtNgoaiNgu.Text = "";
            txtNgoaiNgu.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnCapNhat.Enabled = false;
            btnHuyBo.Enabled = false;
            btnXoa.Enabled = false;
        }
        void Load_DuLieu()
        {
            grdNgoaiNgu.DataSource = NgoaiNguBUS.Instance.LoadAllNgoaiNgu();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            kt = 1;
            txtNgoaiNgu.Enabled = true;
            txtNgoaiNgu.Text = "";
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnCapNhat.Enabled = true;
            btnHuyBo.Enabled = true;
            btnXoa.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            kt = 2;
            txtNgoaiNgu.Enabled = true;
            btnThem.Enabled = false;
            btnCapNhat.Enabled = true;
            btnHuyBo.Enabled = true;
            btnXoa.Enabled = false;
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            NgoaiNguDTO ngoaiNguDTO = new NgoaiNguDTO();
            ngoaiNguDTO.TenCCNN = txtNgoaiNgu.Text.Trim();
            ngoaiNguDTO.NgoaiNguID = NgoaiNguID;
            if (kt == 1)
            {
                if(txtNgoaiNgu.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập tên chứng chỉ ngoại ngữ");
                }
                else
                {


                    if (NgoaiNguBUS.Instance.ThemNgoaiNgu(ngoaiNguDTO) == -1)
                    {
                        MessageBox.Show("Lỗi khi thêm mới");
                    }
                    else
                    {
                        Load_DuLieu();
                    }
                }
            }
            else
            {
                //Update du lieu
                NgoaiNguBUS.Instance.UpdateNgoaiNgu(ngoaiNguDTO);
                Load_DuLieu();
            }
            Reset();

        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            NgoaiNguDTO ngoaiNguDTO = new NgoaiNguDTO();
            ngoaiNguDTO.NgoaiNguID = NgoaiNguID;
            DataTable dt = NgoaiNguBUS.Instance.LoadNgoaiNguFormHoSoNhanVien(ngoaiNguDTO);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Bạn phải xóa bản ghi trong Hồ sơ nhân viên");
            }
            else
            {
                NgoaiNguBUS.Instance.DeleteNgoaiNgu(ngoaiNguDTO);
                Load_DuLieu();
                Reset();
            }
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            btnThem.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            NgoaiNguID = int.Parse(gridView1.GetFocusedRowCellValue("NgoaiNguID").ToString());
            txtNgoaiNgu.Text = gridView1.GetFocusedRowCellValue("TenCCNN").ToString();
        }

        private void btnHuyBo_Click_1(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
