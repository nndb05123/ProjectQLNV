using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRM_VTHP.Core.DAO;
using System.Data;
using HRM_VTHP.Core;
using HRM_VTHP.Core.DTO;

namespace HRM_VTHP.Core.BUS
{
    class BangCapBUS
    {
        private static BangCapBUS instance;

        internal static BangCapBUS Instance
        {
            get
            {
                if (instance == null) instance = new BangCapBUS(); return HRM_VTHP.Core.BUS.BangCapBUS.instance;
            }

            private set
            {
                HRM_VTHP.Core.BUS.BangCapBUS.instance = value;
            }
        }

        public DataTable LoadAllBangCap() {
            string sql = BangCapDAO.Instance.LoadAllBangCap();
            DataTable dt = Core.GetData(sql);
            return dt;
        }

        public int ThemBangCap(BangCapDTO bangCapDTO)
        {
            return Core.RunSql(BangCapDAO.Instance.ThemBangCap(bangCapDTO.TenBangCap));
        }

        public void UpdateBangCap(BangCapDTO bangCapDTO)
        {
            Core.RunSql(BangCapDAO.Instance.UpdateBangCap(bangCapDTO));

        }

        public void DeleteBangCap(BangCapDTO bangCapDTO)
        {
            Core.RunSql(BangCapDAO.Instance.DeleteBangCap(bangCapDTO));

        }

        public DataTable LoadBangCapFromHoSoNhanVien(BangCapDTO bangCapDTO)
        {
            string sql = BangCapDAO.Instance.LoadBangCapFromHoSoNhanVien(bangCapDTO);
            DataTable dt = Core.GetData(sql);
            return dt;
        }
    }
}
