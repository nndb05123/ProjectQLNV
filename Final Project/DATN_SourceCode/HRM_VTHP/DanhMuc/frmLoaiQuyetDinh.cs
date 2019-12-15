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
    public partial class frmLoaiQuyetDinh : Form
    {
        public frmLoaiQuyetDinh()
        {
            InitializeComponent();
        }
        int kt = 0;
        int LoaiQuyetDinhID = 0;
        void Load_DL()
        {
            grdLoaiQD.DataSource = LoaiQuyetDinhBUS.Instance.LoadAllLoaiQuyetDinh();
        }
        void Reset()
        {
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnCapNhat.Enabled = false;
            btnHuyBo.Enabled = false;
            btnXoa.Enabled = false;
            txtLoaiQD.Text = "";
            txtLoaiQD.Enabled = false;
        }

        private void frmLoaiQuyetDinh_Load(object sender, EventArgs e)
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
            txtLoaiQD.Text = "";
            txtLoaiQD.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            kt = 2;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnCapNhat.Enabled = true;
            btnHuyBo.Enabled = true;
            btnXoa.Enabled = false;
            txtLoaiQD.Enabled = true;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            LoaiQuyetDinhDTO loaiQuyetDinhDTO = new LoaiQuyetDinhDTO();
            loaiQuyetDinhDTO.LoaiQuyetDinhID = LoaiQuyetDinhID;
            loaiQuyetDinhDTO.TenLoaiQuyetDinh = txtLoaiQD.Text.Trim();
            if (kt == 1)
            {
                if (txtLoaiQD.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập tên loại quyết định");
                }
                else
                {
                    
                    if (LoaiQuyetDinhBUS.Instance.ThemLoaiQuyetDinh(loaiQuyetDinhDTO) == -1)
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
                LoaiQuyetDinhBUS.Instance.UpdateLoaiQuyetDinh(loaiQuyetDinhDTO);
                Load_DL();
            }
            Reset();
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            LoaiQuyetDinhDTO loaiQuyetDinhDTO = new LoaiQuyetDinhDTO();
            loaiQuyetDinhDTO.LoaiQuyetDinhID = LoaiQuyetDinhID;
            DataTable dt = LoaiQuyetDinhBUS.Instance.LoadLoaiQuyetDinhFromHoSoNhanVien(loaiQuyetDinhDTO);
            if(dt.Rows.Count > 0)
            {
                MessageBox.Show("Bạn phải xóa bản ghi trong KhenThuongKyLuat");
            }
            else
            {
                LoaiQuyetDinhBUS.Instance.DeleteLoaiQuyetDinh(loaiQuyetDinhDTO);
                Load_DL();
                Reset();
            }
            
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            LoaiQuyetDinhID = int.Parse(gridView1.GetFocusedRowCellValue("LoaiQuyetDinhID").ToString());
            txtLoaiQD.Text = gridView1.GetFocusedRowCellValue("TenLoaiQuyetDinh").ToString();
        }

        private void btnHuyBo_Click_1(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
