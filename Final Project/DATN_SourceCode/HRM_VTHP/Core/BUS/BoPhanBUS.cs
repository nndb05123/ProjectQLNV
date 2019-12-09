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
    class BoPhanBUS
    {
        private static BoPhanBUS instance;

        internal static BoPhanBUS Instance
        {
            get
            {
                if (instance == null) instance = new BoPhanBUS(); return HRM_VTHP.Core.BUS.BoPhanBUS.instance;
            }

            private set
            {
                HRM_VTHP.Core.BUS.BoPhanBUS.instance = value;
            }
        }

        public DataTable LoadAllBoPhan()
        {
            string sql = BoPhanDAO.Instance.LoadAllBoPhan();
            DataTable dt = Core.GetData(sql);
            return dt;
        }

        public int ThemBoPhan(BoPhanDTO boPhanDTO)
        {
            return Core.RunSql(BoPhanDAO.Instance.ThemBoPhan(boPhanDTO));
        }

        public void UpdateBoPhan(BoPhanDTO boPhanDTO)
        {
            Core.RunSql(BoPhanDAO.Instance.UpdateBoPhan(boPhanDTO));
        }

        public DataTable LoadBoPhanFromNhanVienBoPhan(BoPhanDTO boPhanDTO)
        {
            string sql = BoPhanDAO.Instance.LoadBoPhanFromNhanVienBoPhan(boPhanDTO);
            DataTable dt = Core.GetData(sql);
            return dt;
        }

        public void DeleteBoPhan(BoPhanDTO boPhanDTO)
        {
            Core.RunSql(BoPhanDAO.Instance.DeleteBoPhan(boPhanDTO));
        }
    }
}
