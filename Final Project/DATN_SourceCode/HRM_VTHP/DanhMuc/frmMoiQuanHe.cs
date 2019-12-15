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
    public partial class frmMoiQuanHe : Form
    {
        public frmMoiQuanHe()
        {
            InitializeComponent();
        }
        int kt = 0;
        int MoiQuanHeID = 0;
        void Load_DL()
        {
            grdMoiQuanHe.DataSource = MoiQuanHeBUS.Instance.LoadAllMoiQuanHe();
        }
        void Reset()
        {
            txtMoiQuanHe.Text = "";
            txtMoiQuanHe.Enabled = false;
            btnThem.Enabled = true;
            btnCapNhat.Enabled = false;
            btnHuyBo.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            kt = 1;
            btnThem.Enabled = false;
            btnCapNhat.Enabled = true;
            txtMoiQuanHe.Enabled = true;
            btnSua.Enabled = false;
            btnHuyBo.Enabled = true;
            btnXoa.Enabled = false;
            txtMoiQuanHe.Text = "";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            kt = 2;
            btnThem.Enabled = false;
            txtMoiQuanHe.Enabled = true;
            btnHuyBo.Enabled = true;
            btnCapNhat.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = false;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            MoiQuanHeDTO moiQuanHeDTO = new MoiQuanHeDTO();
            moiQuanHeDTO.MoiQuanHeID = MoiQuanHeID;
            moiQuanHeDTO.TenMoiQuanHe = txtMoiQuanHe.Text.Trim();
            if(kt == 1)
            {
                if (txtMoiQuanHe.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập mối quan hệ");
                }
                else
                {
                    
                    if (MoiQuanHeBUS.Instance.ThemMoiQuanHe(moiQuanHeDTO) == -1)
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
                MoiQuanHeBUS.Instance.UpdateMoiQuanHe(moiQuanHeDTO);
                Load_DL();
            }
            Reset();
        }

      

        private void btnXoa_Click(object sender, EventArgs e)
        {
            MoiQuanHeDTO moiQuanHeDTO = new MoiQuanHeDTO();
            moiQuanHeDTO.MoiQuanHeID = MoiQuanHeID;
            DataTable dt = MoiQuanHeBUS.Instance.LoadMoiQuanHeFromHoSoNhanVien(moiQuanHeDTO);
            if(dt.Rows.Count > 0)
            {
                MessageBox.Show("Bạn phải xóa bản ghi trong NguoiThan");
            }
            else
            {
                MoiQuanHeBUS.Instance.DeleteMoiQuanHe(moiQuanHeDTO);
                Load_DL();
                Reset();
            }
           
        }

        private void frmMoiQuanHe_Load(object sender, EventArgs e)
        {
            Load_DL();
            Reset();
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            MoiQuanHeID = int.Parse(gridView1.GetFocusedRowCellValue("MoiQuanHeID").ToString());
            txtMoiQuanHe.Text = gridView1.GetFocusedRowCellValue("TenMoiQuanHe").ToString();
        }

        private void txtMoiQuanHe_KeyPress(object sender, KeyPressEventArgs e)
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
