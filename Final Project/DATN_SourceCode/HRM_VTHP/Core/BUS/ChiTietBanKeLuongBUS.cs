using HRM_VTHP.Core.DAO;
using HRM_VTHP.Core.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM_VTHP.Core.BUS
{
    class ChiTietBanKeLuongBUS
    {
        private static ChiTietBanKeLuongBUS instance;

        internal static ChiTietBanKeLuongBUS Instance
        {
            get
            {
                if (instance == null) instance = new ChiTietBanKeLuongBUS(); return HRM_VTHP.Core.BUS.ChiTietBanKeLuongBUS.instance;
            }

            private set
            {
                HRM_VTHP.Core.BUS.ChiTietBanKeLuongBUS.instance = value;
            }
        }

        public void UpdateStatusChiTietBanKeLuong(ChiTietBanKeLuongDTO chiTietBanKeLuongDTO)
        {
            Core.RunSql(ChiTietBanKeLuongDAO.Instance.UpdateStatusChiTietBanKeLuong(chiTietBanKeLuongDTO));
        }

        public void UpdateStatusChiTietBanKeLuongWithNhanVienAndTamUng(int NhanVienID, int ThangTamUng)
        {
            Core.RunSql(ChiTietBanKeLuongDAO.Instance.UpdateStatusChiTietBanKeLuongWithNhanVienAndTamUng(NhanVienID, ThangTamUng));
        }

        public void UpdateChiTietBanKeLuong(ChiTietBanKeLuongDTO chiTietBanKeLuongDTO)
        {
            Core.RunSql(ChiTietBanKeLuongDAO.Instance.UpdateChiTietBanKeLuong(chiTietBanKeLuongDTO));
        }

    }
}
