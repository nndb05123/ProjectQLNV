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
    class TinhThanhBUS
    {
        private static TinhThanhBUS instance;

        internal static TinhThanhBUS Instance
        {
            get
            {
                if (instance == null) instance = new TinhThanhBUS(); return HRM_VTHP.Core.BUS.TinhThanhBUS.instance;
            }

            private set
            {
                HRM_VTHP.Core.BUS.TinhThanhBUS.instance = value;
            }
        }

        public DataTable LoadAllTinhThanh()
        {
            string sql = TinhThanhDAO.Instance.LoadAllTinhThanh();
            DataTable dt = Core.GetData(sql);
            return dt;
        }

        public int ThemTinhThanh(TinhThanhDTO tinhThanhDTO)
        {
            return Core.RunSql(TinhThanhDAO.Instance.ThemTinhThanh(tinhThanhDTO));
        }

        public void UpdateTinhThanh(TinhThanhDTO tinhThanhDTO)
        {
            Core.RunSql(TinhThanhDAO.Instance.UpdateTinhThanh(tinhThanhDTO));
        }

        public DataTable LoadTinhThanhFromHoSoNhanVien(TinhThanhDTO tinhThanhDTO)
        {
            string sql = TinhThanhDAO.Instance.LoadTinhThanhFromHoSoNhanVien(tinhThanhDTO);
            DataTable dt = Core.GetData(sql);
            return dt;
        }

        public void DeleteTinhThanh(TinhThanhDTO tinhThanhDTO)
        {
            Core.RunSql(TinhThanhDAO.Instance.DeleteTinhThanh(tinhThanhDTO));
        }
    }
}
