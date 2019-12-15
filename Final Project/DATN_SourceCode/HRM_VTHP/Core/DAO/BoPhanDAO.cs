using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM_VTHP.Core.DAO
{
    class BoPhanDAO
    {
        private static BoPhanDAO instance;

        internal static BoPhanDAO Instance
        {
            get
            {
                if (instance == null) instance = new BoPhanDAO(); return HRM_VTHP.Core.DAO.BoPhanDAO.instance;
            }

            private set
            {
                HRM_VTHP.Core.DAO.BoPhanDAO.instance = value;
            }
        }

        public string LoadAllBoPhan()
        {
            string sql = "Select * from BoPhan";
            return sql;
        }

        public string ThemBoPhan(DTO.BoPhanDTO boPhanDTO)
        {
            string sql = "Insert into BoPhan(TenBoPhan) values(N'" + boPhanDTO.TenBoPhan + "')";
            return sql;
        }

        public string UpdateBoPhan(DTO.BoPhanDTO boPhanDTO)
        {
            string sql = "Update BoPhan set TenBoPhan =N'" + boPhanDTO.TenBoPhan + "' where BoPhanID ='" + boPhanDTO.BoPhanID + "'";
            return sql;
        }

        public string LoadBoPhanFromNhanVienBoPhan(DTO.BoPhanDTO boPhanDTO)
        {
            string sql = "Select * from NhanVienBoPhan where BoPhanID = '" + boPhanDTO.BoPhanID + "'";
            return sql;
        }

        public string DeleteBoPhan(DTO.BoPhanDTO boPhanDTO)
        {
            string sql = "Delete BoPhan where BoPhanID = '" + boPhanDTO.BoPhanID + "'";
            return sql;
        }

    }
}
