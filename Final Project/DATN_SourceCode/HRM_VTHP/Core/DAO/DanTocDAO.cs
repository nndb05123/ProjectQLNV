using HRM_VTHP.Core.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM_VTHP.Core.DAO
{
    class DanTocDAO
    {
        private static DanTocDAO instance;

        internal static DanTocDAO Instance
        {
            get
            {
                if (instance == null) instance = new DanTocDAO(); return HRM_VTHP.Core.DAO.DanTocDAO.instance;
            }

            private set
            {
                HRM_VTHP.Core.DAO.DanTocDAO.instance = value;
            }
        }


        public string LoadAllDanToc()
        {
            string sql = "Select * from DanToc";
            return sql;
        }

        public string ThemDanToc(DanTocDTO danTocDTO)
        {
            string sql = "Insert into DanToc(TenDanToc) values (N'" + danTocDTO.TenDanToc + "')";
            return sql;
        }

        public string UpdateDanToc(DanTocDTO danTocDTO)
        {
            string sql = "Update DanToc set TenDanToc = N'" + danTocDTO.TenDanToc + "' where DanTocID = '" + danTocDTO.DanTocID + "'";
            return sql;
        }

        public string LoadDanTocFromHoSoNhanVien(DanTocDTO danTocDTO)
        {
            string sql = "select * from HoSoNhanVien where DanTocID = '" + danTocDTO.DanTocID + "'";
            return sql;
        }

        public string DeleteDanToc(DanTocDTO danTocDTO)
        {
            string sql = "Delete DanToc where DanTocID = '" + danTocDTO.DanTocID + "'";
            return sql;
        }

    }
}
