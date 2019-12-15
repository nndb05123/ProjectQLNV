using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM_VTHP.Core.DAO
{
    class NguoiDungDAO
    {
        private static NguoiDungDAO instance;

        internal static NguoiDungDAO Instance
        {
            get
            {
                if (instance == null) instance = new NguoiDungDAO(); return HRM_VTHP.Core.DAO.NguoiDungDAO.instance;
            }

            private set
            {
                HRM_VTHP.Core.DAO.NguoiDungDAO.instance = value;
            }
        }

        public string GetNguoiDungFromTenDangNhap(string TenDangNhap)
        {
            string sql = "Select * from NguoiDung where TenDangNhap = '" + TenDangNhap + "' ";
            return sql;
        }

        public string UpdateMatKhau(string TenDangNhap,string MatKhauMoi)
        {
            string sql = "Update NguoiDung set MatKhau='" + MatKhauMoi + "' where TenDangNhap='" + TenDangNhap + "'";
            return sql;
        }

        public string Login(string TenDangNhap, string MatKhau)
        {
            string sql = "Select NguoiDungID from NguoiDung where TenDangNhap = '" + TenDangNhap + "' and MatKhau = '" + MatKhau + "'";
            return sql;
        }
    }
}
