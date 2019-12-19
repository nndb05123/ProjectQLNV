using HRM_VTHP.Core.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM_VTHP.Core.BUS
{
    class NguoiDungBUS
    {
        private static NguoiDungBUS instance;

        internal static NguoiDungBUS Instance
        {
            get
            {
                if (instance == null) instance = new NguoiDungBUS(); return HRM_VTHP.Core.BUS.NguoiDungBUS.instance;
            }

            private set
            {
                HRM_VTHP.Core.BUS.NguoiDungBUS.instance = value;
            }
        }

        public DataTable GetNguoiDungFromTenDangNhap(string TenDangNhap)
        {
            return Core.GetData(NguoiDungDAO.Instance.GetNguoiDungFromTenDangNhap(TenDangNhap));
        }

        public void UpdateMatKhau(string TenDangNhap, string MatKhau)
        {
            string mkMoi = Security.EncryptMd5(MatKhau);
            Core.RunSql(NguoiDungDAO.Instance.UpdateMatKhau(TenDangNhap,mkMoi));
        }

        public DataTable Login(string TenDangNhap, string MatKhau)
        {
            string mk = Security.EncryptMd5(MatKhau);
            return Core.GetData(NguoiDungDAO.Instance.Login(TenDangNhap, mk));
        }
    }
}
