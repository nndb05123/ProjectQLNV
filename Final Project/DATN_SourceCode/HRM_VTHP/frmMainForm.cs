using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using HRM_VTHP.DanhMuc;
using HRM_VTHP.NghiepVu;
using HRM_VTHP.HeThong;
using HRM_VTHP.BaoCao;
namespace HRM_VTHP
{
    public partial class frmMainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        frmDanToc frmDT = null;
        frmTonGiao frmTG = null;
        frmTinhThanh frmTT = null;
        frmChungChiNgoaiNgu frmNN = null;
        frmChungChiTinHoc frmTH = null;
        frmBoPhan frmBP = null;
        frmBangCap frmBC = null;
        frmLoaiHopDong frmLHD = null;
        frmLoaiQuyetDinh frmLQD = null;
        frmMoiQuanHe frmMQH = null;
        frmTamUng frmTU = null;
        frmNhanVien frmNV = null;
        frmNhanVienBoPhan frmNVBP = null;
        frmNhanVienChucDanh frmNVCD = null;
        frmQuanLyNhanThan frmNguoiThan = null;
        frmHoSoNV frmHSNV = null;
        frmKhenThuongKiLuat frmKTKL = null;
        frmLuongChucDanh frmLCD = null;
        frmDanhGiaHieuSuat frmHieuSuat = null;
        frmDoiMatKhau frmDMK = null;
        frmBaoCaoHoSoNV frmBCHSNV = null;
        frmBaoCaoBangCapChungChi frmBCBangCap = null;
        frmBaoCaoChamCongcs frmBCChamCong = null;
        frmBaoCaoLuongHangThang frmBCBanKeLuong = null;
        frmBaoCaoChiTietTamUng frmBCTamUng = null;
        frmBaoCaoKTKL frmBCKTKL = null;
        frmThongKeDanhGiaNhanVien frmBCDanhGia = null;
        frmThongKeHopDongHetHan frmBCHopDong = null;
        frmThongkeSLLaoDong frmBCSoLuongLaoDong = null;

        string NguoiDungID;
        public frmMainForm(string NguoiDungID_Login)
        {
            InitializeComponent();
            // maximum form
            NguoiDungID = NguoiDungID_Login;
        }

        private void btnDanToc_ItemClick(object sender, ItemClickEventArgs e)
        {
            //if (frmDT == null || frmDT.IsDisposed)
            //{
            //    frmDT = new DanhMuc.frmDanToc();
            //    frmDT.MdiParent = this;
            //}
            //this.ActivateMdiChild(frmDT);
            //frmDT.Show();
            var frmDanToc = new DanhMuc.frmDanToc();
            frmDanToc.ShowDialog();
        }

        private void btnTonGiao_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frmTonGiao = new DanhMuc.frmTonGiao();
            frmTonGiao.ShowDialog();
        }

        private void btnTinhThanh_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frmTinhThanh = new DanhMuc.frmTinhThanh();
            frmTinhThanh.ShowDialog();
        }

        private void btnBoPhan_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frmBoPhan = new DanhMuc.frmBoPhan();
            frmBoPhan.ShowDialog();
        }

        private void btnLoaiHopDong_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frmLoaiHopDong = new DanhMuc.frmLoaiHopDong();
            frmLoaiHopDong.ShowDialog();
        }

        private void btnBangCap_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frmBangCap = new DanhMuc.frmBangCap();
            frmBangCap.ShowDialog();
        }

        private void btnCCNgoaiNgu_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frmCCNgoaiNgu = new DanhMuc.frmChungChiNgoaiNgu();
            frmCCNgoaiNgu.ShowDialog();
        }

        private void btnCCTinHoc_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frmCCTinHoc = new DanhMuc.frmChungChiTinHoc();
            frmCCTinHoc.ShowDialog();
        }

        private void btnTamUng_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frmTamUng = new DanhMuc.frmTamUng();
            frmTamUng.ShowDialog();
        }

        private void btnMoiQuanHe_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frmMoiQuanHe = new DanhMuc.frmMoiQuanHe();
            frmMoiQuanHe.ShowDialog();
        }

        private void btnLoaiQuyetDinh_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frmLoaiQuyetDinh = new DanhMuc.frmLoaiQuyetDinh();
            frmLoaiQuyetDinh.ShowDialog();
        }

        private void btnNhanVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (frmNV == null || frmNV.IsDisposed)
            {
                frmNV = new NghiepVu.frmNhanVien();
                frmNV.MdiParent = this;
            }
            this.ActivateMdiChild(frmDT);
            frmNV.Show();
        }

        private void btnHoSoNhanVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (frmHSNV == null || frmHSNV.IsDisposed)
            {
                frmHSNV = new NghiepVu.frmHoSoNV();
                frmHSNV.MdiParent = this;
            }
            this.ActivateMdiChild(frmHSNV);
            frmHSNV.Show();
        }

        private void btnThanNhan_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (frmNguoiThan == null || frmNguoiThan.IsDisposed)
            {
                frmNguoiThan = new NghiepVu.frmQuanLyNhanThan();
                frmNguoiThan.MdiParent = this;
            }
            this.ActivateMdiChild(frmNguoiThan);
            frmNguoiThan.Show();
        }

        private void btnNhanVienChucDanh_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (frmNVCD == null || frmNVCD.IsDisposed)
            {
                frmNVCD = new NghiepVu.frmNhanVienChucDanh();
                frmNVCD.MdiParent = this;
            }
            this.ActivateMdiChild(frmNVCD);
            frmNVCD.Show();
        }

        private void btnNhanVienBP_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (frmNVBP == null || frmDT.IsDisposed)
            {
                frmNVBP = new NghiepVu.frmNhanVienBoPhan();
                frmNVBP.MdiParent = this;
            }
            this.ActivateMdiChild(frmNVBP);
            frmNVBP.Show();
        }

        private void btnKhenThuongKyLuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (frmKTKL == null || frmKTKL.IsDisposed)
            {
                frmKTKL = new NghiepVu.frmKhenThuongKiLuat();
                frmKTKL.MdiParent = this;
            }
            this.ActivateMdiChild(frmKTKL);
            frmKTKL.Show();
        }

        private void btnDanhGia_ItemClick(object sender, ItemClickEventArgs e)
        {
            if ( frmHieuSuat== null || frmHieuSuat.IsDisposed)
            {
                frmHieuSuat = new NghiepVu.frmDanhGiaHieuSuat();
                frmHieuSuat.MdiParent = this;
            }
            this.ActivateMdiChild(frmHieuSuat);
            frmHieuSuat.Show();
        }

        private void btnLuongChucDanh_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (frmLCD == null || frmLCD.IsDisposed)
            {
                frmLCD = new NghiepVu.frmLuongChucDanh();
                frmLCD.MdiParent = this;
            }
            this.ActivateMdiChild(frmLCD);
            frmLCD.Show();
        }

        private void btnDoiMK_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frmDoiMatKhau = new HeThong.frmDoiMatKhau();
            frmDoiMatKhau.ShowDialog();
        }

        private void btnHSNhanVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            if ( frmBCHSNV== null || frmBCHSNV.IsDisposed)
            {
                frmBCHSNV = new BaoCao.frmBaoCaoHoSoNV();
                frmBCHSNV.MdiParent = this;
            }
            this.ActivateMdiChild(frmBCHSNV);
            frmBCHSNV.Show();
        }

        private void frmMainForm_Load(object sender, EventArgs e)
        {
            LoadQuyen();
        }

        private void LoadQuyen()
        {
            // load phan quyen
            string sql = @"Select QuanTri From NguoiDung Where NguoiDungID = '" + NguoiDungID + "'";
            DataTable dt = Core.Core.GetData(sql);

            if(dt != null && dt.Rows.Count > 0)
            {
                if(dt.Rows[0]["QuanTri"].ToString() == "0" || dt.Rows[0]["QuanTri"].ToString().ToLower() == "false")
                {
                    sql = @"Select a.NGuoiDungID, a.NghiepVuID, b.URL 
            from QuyenNguoiDung a join NghiepVu b on b.NghiepVuID = a.NghiepVuID Where NguoiDungID = '" + NguoiDungID + "'";

                    dt = Core.Core.GetData(sql);

                    if (dt != null && dt.Rows.Count > 0)
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            switch (dr["URL"].ToString())
                            {
                                case "rbpHeThong":
                                    rbpHeThong.Visible = true;
                                    break;
                                case "rbpDanhMuc":
                                    rbpDanhMuc.Visible = true;
                                    break;
                                case "rbpTienLuong":
                                    rbpTienLuong.Visible = true;
                                    break;
                                case "tbpNhanSu":
                                    tbpNhanSu.Visible = true;
                                    break;
                                case "rbpThongKeBaoCao":
                                    rbpThongKeBaoCao.Visible = true;
                                    break;
                            }
                        }
                    }
                }else
                {
                    rbpHeThong.Visible = true;
                    rbpDanhMuc.Visible = true;
                    rbpTienLuong.Visible = true;
                    tbpNhanSu.Visible = true;
                    rbpThongKeBaoCao.Visible = true;
                }   
            }
        }

        private void frmMainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnQLTamUng_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frmChiTietTamUng = new NghiepVu.frmChiTietTamUng();
            frmChiTietTamUng.ShowDialog();
        }

        private void btnChamCong_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frmChamCong = new NghiepVu.frmChamCong();
            frmChamCong.ShowDialog();
        }

        private void btnBKL_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frmBanKeLuong = new NghiepVu.frmBanKeLuong();
            frmBanKeLuong.ShowDialog();
        }

        private void btnTienLuong_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (frmBCBanKeLuong == null || frmBCBanKeLuong.IsDisposed)
            {
                frmBCBanKeLuong = new BaoCao.frmBaoCaoLuongHangThang();
                frmBCBanKeLuong.MdiParent = this;
            }
            this.ActivateMdiChild(frmBCBanKeLuong);
            frmBCBanKeLuong.Show();
        }

        private void btnBangChamCong_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (frmBCChamCong == null || frmBCChamCong.IsDisposed)
            {
                frmBCChamCong = new BaoCao.frmBaoCaoChamCongcs();
                frmBCChamCong.MdiParent = this;
            }
            this.ActivateMdiChild(frmBCChamCong);
            frmBCChamCong.Show();
        }

        private void btnBCTamUngHoanUng_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (frmBCTamUng == null || frmBCTamUng.IsDisposed)
            {
                frmBCTamUng = new BaoCao.frmBaoCaoChiTietTamUng();
                frmBCTamUng.MdiParent = this;
            }
            this.ActivateMdiChild(frmBCTamUng);
            frmBCTamUng.Show();
        }

        private void btnBCSoLuongLD_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (frmBCSoLuongLaoDong == null || frmBCSoLuongLaoDong.IsDisposed)
            {
                frmBCSoLuongLaoDong = new BaoCao.frmThongkeSLLaoDong();
                frmBCSoLuongLaoDong.MdiParent = this;
            }
            this.ActivateMdiChild(frmBCSoLuongLaoDong);
            frmBCSoLuongLaoDong.Show();
        }

        private void btnBCKTKL_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (frmBCKTKL == null || frmBCKTKL.IsDisposed)
            {
                frmBCKTKL = new BaoCao.frmBaoCaoKTKL();
                frmBCKTKL.MdiParent = this;
            }
            this.ActivateMdiChild(frmBCKTKL);
            frmBCKTKL.Show();
        }

        private void btnBCDanhGiaNV_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (frmBCDanhGia == null || frmBCDanhGia.IsDisposed)
            {
                frmBCDanhGia = new BaoCao.frmThongKeDanhGiaNhanVien();
                frmBCDanhGia.MdiParent = this;
            }
            this.ActivateMdiChild(frmBCDanhGia);
            frmBCDanhGia.Show();
        }

        private void btnBCHopDongHetHan_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frmHopDongHetHan = new BaoCao.frmBaoCaoHopDongSapHetHan();
            frmHopDongHetHan.ShowDialog();
        }

        private void btnBCBangCapChungChi_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (frmBCBangCap == null || frmBCBangCap.IsDisposed)
            {
                frmBCBangCap = new BaoCao.frmBaoCaoBangCapChungChi();
                frmBCBangCap.MdiParent = this;
            }
            this.ActivateMdiChild(frmBCBangCap);
            frmBCBangCap.Show();
        }

        private void btnNguoiDung_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frmNguoiDung = new HeThong.frmQuanLyNguoiDung();
            frmNguoiDung.ShowDialog();
        }

        private void btnPhanQuyen_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frmPhanQuyen = new HeThong.frmPhanQuyenNguoiDung();
            frmPhanQuyen.ShowDialog();
        }

        private void btnPhucHoi_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frmPhucHoi = new HeThong.frmPhucHoiDuLieu();
            frmPhucHoi.ShowDialog();
        }

        private void btnSaoLuu_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frmSaoLuu = new HeThong.frmSaoLuuDuLieu();
            frmSaoLuu.ShowDialog();
        }

        private void btnLogOut_ItemClick(object sender, ItemClickEventArgs e)
        {
            var check = MessageBox.Show("Bạn có muốn đăng xuất ra khỏi hệ thống hay không?"," Thông báo ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(check == DialogResult.Yes)
            {
                // log out
                this.Hide();

                var frmDangNhap = new HeThong.frmDangNhap();
                frmDangNhap.Show();

                
            }
        }

        private void btnHopDong_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frmHopDong = new NghiepVu.frmHopDong();
            frmHopDong.ShowDialog();
        }

        private void btnMauHopDong_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frmMauHopDong = new BaoCao.frmMauHopDongLaoDong();
            frmMauHopDong.ShowDialog();
        }

        private void btnHoSoMotNV_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frmHoSoMotNV = new BaoCao.frmBaoCaoHoSoMotNV();
            frmHoSoMotNV.ShowDialog();
        }
    }
}