using HRM_VTHP.Core.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM_VTHP.Core.DAO
{
    class HoSoNhanVienDAO
    {

        private static HoSoNhanVienDAO instance;

        internal static HoSoNhanVienDAO Instance
        {
            get
            {
                if (instance == null) instance = new HoSoNhanVienDAO(); return HRM_VTHP.Core.DAO.HoSoNhanVienDAO.instance;
            }

            private set
            {
                HRM_VTHP.Core.DAO.HoSoNhanVienDAO.instance = value;
            }
        }

        public string LoadAllHoSoNhanVien()
        {
            string sql = @"select b.NhanVienID, b.TenNV, a.NgayVaoLam, c.DanTocID, c.TenDanToc, d.TonGiaoID, d.TenTonGiao, e.TinhThanhID, e.TenTinhThanh,f.NgoaiNguID, f.TenCCNN, g.TinHocID, g.TenCCTH, h.BangCapID, h.TenBangCap, a.GhiChu, a.ImagePath
                            from HoSoNhanVien a 
                            inner join NhanVien b on a.NhanVienID=b.NhanVienID
                            inner join DanToc c on a.DanTocID=c.DanTocID
                            inner join TonGiao d on a.TonGiaoID=d.TonGiaoID
                            inner join TinhThanh e on a.TinhThanhID=e.TinhThanhID
                            inner join NgoaiNgu f on a.NgoaiNguID=f.NgoaiNguID
                            inner join TinHoc g on a.TinHocID=g.TinHocID
                            inner join BangCap h on a.BangCapID=h.BangCapID";
            return sql;

        }

        public string DeleteHSNV(int nhanVienID)
        {
            string sql = "Delete HoSoNhanVien where NhanVienID='" + nhanVienID + "'";
            return sql;
        }

        public string ThemHSNhanVien(HoSoNhanVienDTO hoSoNhanVienDTO)
        {
            string sql = "Insert into HoSoNhanVien(NhanVienID, NgayVaoLam, DanTocID, TonGiaoID, TinhThanhID, NgoaiNguID, TinHocID, BangCapID, GhiChu, ImagePath) values ('" + hoSoNhanVienDTO.NhanVienID + "', '" + hoSoNhanVienDTO.NgayVaoLam + "', '" + hoSoNhanVienDTO.DanTocID + "', '" + hoSoNhanVienDTO.TonGiaoID + "', '" + hoSoNhanVienDTO.TinhThanhID + "', '" + hoSoNhanVienDTO.NgoaiNguID + "', '" + hoSoNhanVienDTO.TinHocID + "', '" + hoSoNhanVienDTO.BangCapID + "', '" + hoSoNhanVienDTO.GhiChu + "', '" + hoSoNhanVienDTO.ImagePath + "' )";
            return sql;
        }

        public string UpdateHSNhanVien(HoSoNhanVienDTO hoSoNhanVienDTO)
        {
            string sql = "Update HoSoNhanVien set NhanVienID ='" + hoSoNhanVienDTO.NhanVienID + "', NgayVaoLam = '" + hoSoNhanVienDTO.NgayVaoLam + "', DanTocID='" + hoSoNhanVienDTO .DanTocID+ "',  TonGiaoID='" + hoSoNhanVienDTO.TonGiaoID + "', TinhThanhID='" + hoSoNhanVienDTO.TinhThanhID + "', NgoaiNguID='" + hoSoNhanVienDTO.NgoaiNguID + "', TinHocID='" + hoSoNhanVienDTO.TinHocID + "', BangCapID='" + hoSoNhanVienDTO.BangCapID + "',GhiChu='" + hoSoNhanVienDTO.GhiChu + "', ImagePath = '" + hoSoNhanVienDTO.ImagePath + "' where NhanVienID = '" + hoSoNhanVienDTO.NhanVienID + "'";
            return sql;
        }
    }
}
