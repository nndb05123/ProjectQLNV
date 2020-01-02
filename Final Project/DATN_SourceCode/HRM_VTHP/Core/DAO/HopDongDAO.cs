using HRM_VTHP.Core.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM_VTHP.Core.DAO
{
    class HopDongDAO
    {
        private static HopDongDAO instance;

        internal static HopDongDAO Instance
        {
            get
            {
                if (instance == null) instance = new HopDongDAO(); return HRM_VTHP.Core.DAO.HopDongDAO.instance;
            }

            private set
            {
                HRM_VTHP.Core.DAO.HopDongDAO.instance = value;
            }
        }
        public string LoadAll_HopDong()
        {
            string sql = @"select f.TenBoPhan, e.NhanVienID, e.HopDongID, e.LoaiHopDongID, e.TenNV, e.MaHopDong, e.TenLoaiHopDong, e.NgayKy, e.NgayHieuLuc, e.NgayHetHan, e.NgayKetThuc, e.BoPhanID, e.TrangThai from BoPhan f inner join
                           (select a.NhanVienID, a.TrangThai, a.HopDongID, a.LoaiHopDongID, a.MaHopDong, a.NgayHetHan, a.NgayHieuLuc, a.NgayKetThuc, a.NgayKy, b.TenLoaiHopDong, c.TenNV, d.BoPhanID from HopDong a
                           inner join LoaiHopDong b on a.LoaiHopDongID = b.LoaiHopDongID 
                           inner join NhanVien c on a.NhanVienID = c.NhanVienID
                           inner join NhanVienBoPhan d on a.NhanVienID = d.NhanVienID) as e on f.BoPhanID = e.BoPhanID";
            return sql;
        }
        public string Load_LoaiHopDong()
        {
            string sql = "Select * from LoaiHopDong";
            return sql;
        }
        public string Load_BoPhan()
        {
            string sql = "Select * from BoPhan";
            return sql;
        }
        public string Load_NhanVienBoPhan(string BoPhanID)
        {
            string sql = "select a.NhanVienID, a.TenNV from NhanVien a INNER JOIN NhanVienBoPhan b on a.NhanVienID = b.NhanVienID and b.BoPhanID = '" + BoPhanID + "'";
            return sql;
        }
        public string Add_HopDong(HopDongDTO hopDongDTO)
        {
            string sql = "Insert into HopDong( MaHopDong, LoaiHopDongID, NgayKy, NgayHieuLuc, NgayHetHan, NhanVienID, NgayKetThuc, TrangThai) values ('" + hopDongDTO.MaHopDong + "', '" + hopDongDTO.LoaiHopDongID + "', '" + hopDongDTO.NgayKy + "', '" + hopDongDTO.NgayHieuLuc + "', '" + hopDongDTO.NgayHetHan + "', '" + hopDongDTO.NhanVienID + "', '" + hopDongDTO.NgayKetThuc + "', '" + hopDongDTO.TrangThai + "')";
            return sql;
        }
        public string Update_HopDong(HopDongDTO hopDongDTO,int HopDongID)
        {
            string sql = "Update HopDong set MaHopDong ='" + hopDongDTO.MaHopDong + "', LoaiHopDongID = '" + hopDongDTO.LoaiHopDongID + "', NgayKy = '" + hopDongDTO.NgayKy + "', NgayHieuLuc = '" + hopDongDTO.NgayHieuLuc + "', NgayHetHan = '" + hopDongDTO.NgayHetHan + "', NgayKetThuc = '" + hopDongDTO.NgayKetThuc + "', NhanVienID = '" + hopDongDTO.NhanVienID + "', TrangThai = '" + hopDongDTO.TrangThai + "' where HopDongID = '" + HopDongID + "'";
            return sql;
        }
        public string Delete_HopDong(int HopDongID)
        {
            string sql = "Delete HopDong where HopDongID = '" + HopDongID + "'";
            return sql;
        }
    }
}
