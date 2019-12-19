using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM_VTHP.Core.DAO
{
    class QuyenNguoiDungDAO
    {
        private static QuyenNguoiDungDAO instance;

        internal static QuyenNguoiDungDAO Instance
        {
            get
            {
                if (instance == null) instance = new QuyenNguoiDungDAO(); return HRM_VTHP.Core.DAO.QuyenNguoiDungDAO.instance;
            }

            private set
            {
                HRM_VTHP.Core.DAO.QuyenNguoiDungDAO.instance = value;
            }
        }

        public string GetNhanVienFromBoPhan(string BoPhanID)
        {
            string sql = @"select a.NhanVienID, a.TenNV from NhanVien a 
                            inner join NhanVienBoPhan b on a.NhanVienID = b.NhanVienID and b.BoPhanID = '" + BoPhanID + "'";
            return sql;
        }

        public string GetNguoiDungFromNhanVien(string NhanVienID)
        {
            string sql = @"select a.NguoiDungID, a.TenDangNhap from NguoiDung a 
                           inner join NhanVien b on a.NhanVienID = b.NhanVienID and b.NhanVienID = '" + NhanVienID + "'";
            return sql;
        }

        public string DeleteQuyenNguoiDung(string NguoiDungID)
        {
            string sql = "delete from QuyenNguoiDung where NguoiDungID = '" + NguoiDungID + "'";
            return sql;
        }

        public string ThemQuyenNguoiDung(string NguoiDungID, string Quyen)
        {
            string sql = "Insert into QuyenNguoiDung(NguoiDungID, NghiepVuID) values ('" + NguoiDungID + "', '"+ Quyen +"')";
            return sql;
        }
    }
}
