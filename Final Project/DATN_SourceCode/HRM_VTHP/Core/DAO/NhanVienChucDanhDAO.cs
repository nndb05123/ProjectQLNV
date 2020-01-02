using HRM_VTHP.Core.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM_VTHP.Core.DAO
{
    class NhanVienChucDanhDAO
    {
        private static NhanVienChucDanhDAO instance;

        internal static NhanVienChucDanhDAO Instance
        {
            get
            {
                if (instance == null) instance = new NhanVienChucDanhDAO(); return HRM_VTHP.Core.DAO.NhanVienChucDanhDAO.instance;
            }

            private set
            {
                HRM_VTHP.Core.DAO.NhanVienChucDanhDAO.instance = value;
            }
        }
        public string LoadData_NhanVienChucDanh()
        {

            string sql = @"SELECT DISTINCT BP.BoPhanID, BP.TenBoPhan, CDNV.TenChucDanh, CDNV.TenNV, NVBP.NhanVienID, CDNV.ChucDanhID
                           FROM NhanVienBoPhan NVBP
                           INNER JOIN BoPhan BP ON NVBP.BoPhanID = BP.BoPhanID
                           INNER JOIN 
	                       (SELECT LCD.ChucDanhID, LCD.TenChucDanh, NVCD.NhanVienID, NV.TenNV
	                        FROM NhanVienChucDanh NVCD
	                        INNER JOIN LuongChucDanh LCD ON NVCD.ChucDanhID = LCD.ChucDanhID
	                        INNER JOIN NhanVien NV ON NVCD.NhanVienID = NV.NhanVienID) 
		                    AS CDNV ON NVBP.NhanVienID = CDNV.NhanVienID";
            return sql;
        }
        public string Load_BoPhan()
        {
            string sql = "Select * from BoPhan";
            return sql;
        }
        public string Load_LuongChucDanh()
        {
            string sql = "Select * from LuongChucDanh";
            return sql;
        }
        public string ADD_NhanVienChucDanh(NhanVienChucDanhDTO nhanVienChucDanhDTO)
        {
            string sql = "Insert into NhanVienChucDanh(NhanVienID, ChucDanhID) values ('" + nhanVienChucDanhDTO.NhanVienID + "', '" + nhanVienChucDanhDTO.ChucDanhID + "')";
            return sql;
        }
        public string Update_NhanVienChucDanh(NhanVienChucDanhDTO nhanVienChucDanhDTO)
        {
            string sql = "Update NhanVienChucDanh set NhanVienID ='" + nhanVienChucDanhDTO.NhanVienID + "', ChucDanhID = '" + nhanVienChucDanhDTO.ChucDanhID + "' where NhanVienID = '" + nhanVienChucDanhDTO.NhanVienID + "'";
            return sql;
        }
        public string Delete_NhanVienChucDanh(NhanVienChucDanhDTO nhanVienChucDanhDTO)
        {
            string sql = "Delete NhanVienChucDanh where NhanVienID = '" + nhanVienChucDanhDTO.NhanVienID + "' AND ChucDanhID = '" + nhanVienChucDanhDTO.ChucDanhID + "'";
            return sql;
        }
        public string Load_NhanVienBoPhan(string BoPhanID)
        {
            string sql = "select a.NhanVienID, a.TenNV from NhanVien a INNER JOIN NhanVienBoPhan b on a.NhanVienID = b.NhanVienID and b.BoPhanID = '" + BoPhanID + "'";
            return sql;
        }
    }
}
