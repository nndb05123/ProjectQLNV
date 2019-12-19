using HRM_VTHP.Core.DAO;
using HRM_VTHP.Core.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM_VTHP.Core.BUS
{
    class NhanVienBUS
    {
        private static NhanVienBUS instance;

        internal static NhanVienBUS Instance
        {
            get
            {
                if (instance == null) instance = new NhanVienBUS(); return HRM_VTHP.Core.BUS.NhanVienBUS.instance;
            }

            private set
            {
                HRM_VTHP.Core.BUS.NhanVienBUS.instance = value;
            }
        }

        public DataTable LoadAllNhanVien()
        {
            DataTable dt = Core.GetData(NhanVienDAO.Instance.LoadAllNhanVien());
            return dt;
        }

        public DataTable LoadAllGioiTinh()
        {
            DataTable dt = Core.GetData(NhanVienDAO.Instance.LoadAllGioiTinh());
            return dt;
        }

        public int ThemNhanVien(NhanVienDTO nhanVienDTO)
        {
            return Core.RunSql(NhanVienDAO.Instance.ThemNhanVien(nhanVienDTO));

        }

        public void UpdateNhanVien(NhanVienDTO nhanVienDTO)
        {
            Core.RunSql(NhanVienDAO.Instance.UpdateNhanVien(nhanVienDTO));
        }

        public void DeleteNhanVien(int nhanVienID)
        {
            Core.RunSql(NhanVienDAO.Instance.DeleteNhanVien(nhanVienID));
        }
    }
}
