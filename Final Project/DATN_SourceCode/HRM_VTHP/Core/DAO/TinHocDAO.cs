using HRM_VTHP.Core.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM_VTHP.Core.DAO
{
    class TinHocDAO
    {
        private static TinHocDAO instance;

        internal static TinHocDAO Instance
        {
            get
            {
                if (instance == null) instance = new TinHocDAO(); return HRM_VTHP.Core.DAO.TinHocDAO.instance;
            }

            private set
            {
                HRM_VTHP.Core.DAO.TinHocDAO.instance = value;
            }
        }

        public string LoadAllTinHoc()
        {
            string sql = "Select * from TinHoc";
            return sql;
        }

        public string ThemTinHoc(TinHocDTO tinHocDTO)
        {
            string sql = "Insert into TinHoc(TenCCTH) values (N'" + tinHocDTO.TenCCTH + "')";
            return sql;
        }

        public string UpdateTinHoc(TinHocDTO tinHocDTO)
        {
            string sql = "Update TinHoc set TenCCTH = N'" + tinHocDTO.TenCCTH + "' where TinHocID = '" + tinHocDTO.TinHocID + "'";
            return sql;
        }

        public string LoadTinHocFromHoSoNhanVien(TinHocDTO tinHocDTO)
        {
            string sql = "Select * from HoSoNhanVien where TinHocID = '" + tinHocDTO.TinHocID + "'";
            return sql;
        }

        public string DeleteTinHoc(TinHocDTO tinHocDTO)
        {
            string sql = "Delete TinHoc where TinHocID = '" + tinHocDTO.TinHocID + "'";
            return sql;
        }
    }
}
