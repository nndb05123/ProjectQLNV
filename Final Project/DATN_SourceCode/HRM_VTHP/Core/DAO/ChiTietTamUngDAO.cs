using HRM_VTHP.Core.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM_VTHP.Core.DAO
{
    class ChiTietTamUngDAO
    {
        private static ChiTietTamUngDAO instance;

        internal static ChiTietTamUngDAO Instance
        {
            get
            {
                if (instance == null) instance = new ChiTietTamUngDAO(); return HRM_VTHP.Core.DAO.ChiTietTamUngDAO.instance;
            }

            private set
            {
                HRM_VTHP.Core.DAO.ChiTietTamUngDAO.instance = value;
            }
        }
        public string LoadData_ChiTietTamUng()
        {
            string sql = @"select e.TenBoPhan, f.TrangThaiID, f.TenNV, f.MaNV, f.NhanVienID, f.GhiChu, f.PhieuTamUngID, f.ThangTamUng, f.MaPhieuTamUng, f.NgayLap, f.TamUng, f.TenTamUng,f.BoPhanID,f.TamUngID from BoPhan e inner join
                        (select a.MaPhieuTamUng,a.PhieuTamUngID, a.NgayLap, a.NhanVienID, a.TrangThaiID, a.TamUng,a.ThangTamUng, d.BoPhanID, a.GhiChu, b.TenNV, b.MaNV, c.TenTamUng,c.TamUngID from ChiTietTamUng a 
                        inner join NhanVien b on a.NhanVienID = b.NhanVienID
                        inner join TamUng c on a.TamUngID = c.TamUngID
                        inner join NhanVienBoPhan d on a.NhanVienID = d.NhanVienID) as f on e.BoPhanID = f.BoPhanID";
            return sql;
        }
        public string Add_ChiTietTamUng(ChiTietTamUngDTO chiTietTamUngDTO)
        {
            string sql = "Insert into ChiTietTamUng(MaPhieuTamUng, " + "ThangTamUng, " + "TamUngID," + " NhanVienID, " + "NgayLap, " + "TamUng, " + "GhiChu, " + "TrangThaiID) " + "values ('" + chiTietTamUngDTO.MaPhieuTamUng + "', '" + chiTietTamUngDTO.ThangTamUng + "', '" + chiTietTamUngDTO.TamUngID + "', '" + chiTietTamUngDTO.NhanVienID + "', '" + chiTietTamUngDTO.NgayLap + "','" + chiTietTamUngDTO.TamUng + "','" + chiTietTamUngDTO.GhiChu + "', '1')";
            return sql;
        }
        public string Update_ChiTietTamUng(ChiTietTamUngDTO chiTietTamUngDTO,int PhieuTamUngID)
        {
            string sql = "Update ChiTietTamUng set MaPhieuTamUng ='" + chiTietTamUngDTO.MaPhieuTamUng + "', ThangTamUng = '" + chiTietTamUngDTO .ThangTamUng+ "', TamUngID = '" + chiTietTamUngDTO.TamUngID + "', NhanVienID = '" + chiTietTamUngDTO.NhanVienID + "', NgayLap = '" + chiTietTamUngDTO.NgayLap + "', TamUng = '" + chiTietTamUngDTO.TamUng + "', GhiChu ='" + chiTietTamUngDTO.GhiChu + "' where PhieuTamUngID = '" + PhieuTamUngID + "'";
            return sql;
        }
        public string Delete_ChiTietTamUng(int PhieuTamUngID)
        {
            string sql = "Delete ChiTietTamUng where PhieuTamUngID = '" + PhieuTamUngID + "'";
            return sql;
        }
    }
}
