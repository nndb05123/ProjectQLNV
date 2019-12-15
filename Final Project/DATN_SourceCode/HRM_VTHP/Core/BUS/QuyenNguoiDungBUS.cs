using HRM_VTHP.Core.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM_VTHP.Core.BUS
{
    class QuyenNguoiDungBUS
    {
        private static QuyenNguoiDungBUS instance;

        internal static QuyenNguoiDungBUS Instance
        {
            get
            {
                if (instance == null) instance = new QuyenNguoiDungBUS(); return HRM_VTHP.Core.BUS.QuyenNguoiDungBUS.instance;
            }

            private set
            {
                HRM_VTHP.Core.BUS.QuyenNguoiDungBUS.instance = value;
            }
        }

        public DataTable GetNhanVienFromBoPhan(string BoPhanID)
        {
            return Core.GetData(QuyenNguoiDungDAO.Instance.GetNhanVienFromBoPhan(BoPhanID));
        }

        public DataTable GetNguoiDungFromNhanVien(string NhanVienID)
        {
            return Core.GetData(QuyenNguoiDungDAO.Instance.GetNguoiDungFromNhanVien(NhanVienID));
        }

        public void DeleteQuyenNguoiDung(string NguoiDungID)
        {
            Core.RunSql(QuyenNguoiDungDAO.Instance.DeleteQuyenNguoiDung(NguoiDungID));
        }

        public void ThemQuyenNguoiDung(string NguoiDungID, string Quyen)
        {
            Core.RunSql(QuyenNguoiDungDAO.Instance.ThemQuyenNguoiDung(NguoiDungID, Quyen));
        }
    }
}
