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
    class HoSoNhanVienBUS
    {
        private static HoSoNhanVienBUS instance;

        internal static HoSoNhanVienBUS Instance
        {
            get
            {
                if (instance == null) instance = new HoSoNhanVienBUS(); return HRM_VTHP.Core.BUS.HoSoNhanVienBUS.instance;
            }

            private set
            {
                HRM_VTHP.Core.BUS.HoSoNhanVienBUS.instance = value;
            }
        }

        public DataTable LoadAllHSNhanVien()
        {
            DataTable dt = Core.GetData(HoSoNhanVienDAO.Instance.LoadAllHoSoNhanVien());
            return dt;
        }

        public int ThemHSNhanVien(HoSoNhanVienDTO hoSoNhanVienDTO)
        {
            return Core.RunSql(HoSoNhanVienDAO.Instance.ThemHSNhanVien(hoSoNhanVienDTO));

        }

        public void UpdateHoSoNhanVien(HoSoNhanVienDTO hoSoNhanVienDTO)
        {
            Core.RunSql(HoSoNhanVienDAO.Instance.UpdateHSNhanVien(hoSoNhanVienDTO));
        }

        public void DeleteHSNhanVien(int nhanVienID)
        {
            Core.RunSql(HoSoNhanVienDAO.Instance.DeleteHSNV(nhanVienID));
        }
    }
}
