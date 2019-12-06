using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRM_VTHP.BaoCao
{
    public partial class frmMauHopDongLaoDong : Form
    {
        public frmMauHopDongLaoDong()
        {
            InitializeComponent();
        }

        protected void LoadBaoCao()
        {
            try
            {
                MauHopDongLaoDong reports = new MauHopDongLaoDong();
                documentViewer1.DocumentSource = reports;
                reports.CreateDocument();
            }
            catch (Exception)
            {

            }
        }

        private void frmMauHopDongLaoDong_Load(object sender, EventArgs e)
        {
            string sql = @"Select a.NhanVienID, a.TenNV From NhanVien a Order By TenNV";
            DataTable dt = Core.Core.GetData(sql);

            cmbNV.DataSource = dt;        
            cmbNV.SelectedIndex = 0;
           
            //LoadBaoCao();
        }

        private void cmbNV_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                int nvid = 0;
                int.TryParse(cmbNV.SelectedValue.ToString(),out nvid);
                if (nvid>0)
                { 
                string sql = @"select a.TenNV, a.DiaChi, a.SDT, c.TenChucDanh, d.NgayHieuLuc, d.NgayHetHan from NhanVien a
                            inner join NhanVienChucDanh b on a.NhanVienID = b.NhanVienID
                            inner join LuongChucDanh c on b.ChucDanhID = c.ChucDanhID
                            inner join HopDong d on a.NhanVienID = d.NhanVienID
                            where a.NhanVienID = " + cmbNV.SelectedValue;
                DataTable dt = Core.Core.GetData(sql);
                sql = @"select a.TenNV, a.NgaySinh, a.DiaChi, a.SoCMND, c.TenChucDanh from NhanVien a 
                    inner join NhanVienChucDanh b on a.NhanVienID = b. NhanVienID
                    inner join LuongChucDanh c on b.ChucDanhID = c.ChucDanhID where c.ChucDanhID = 2";
                DataTable dt2 = Core.Core.GetData(sql);
                MauHopDongLaoDong reports = new MauHopDongLaoDong(dt, dt2);
                documentViewer1.DocumentSource = reports;
                reports.CreateDocument();
                }
            }
            catch (Exception ex)
            {

            }

        }
    }
}
