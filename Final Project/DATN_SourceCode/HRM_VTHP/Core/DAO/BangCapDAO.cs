using HRM_VTHP.Core.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM_VTHP.Core.DAO
{
    class BangCapDAO
    {
        private static BangCapDAO instance;

        internal static BangCapDAO Instance
        {
            get
            {
                if (instance == null) instance = new BangCapDAO(); return HRM_VTHP.Core.DAO.BangCapDAO.instance;
            }

            private set
            {
                HRM_VTHP.Core.DAO.BangCapDAO.instance = value;
            }
        }

        public string LoadAllBangCap()
        {
            string sql = "Select * from BangCap";
            return sql;
        }

        public string ThemBangCap(string BangCap)
        {
            string sql = $"Insert into BangCap(TenBangCap) values(N'{BangCap}')";
            return sql;
        }

        public string UpdateBangCap(BangCapDTO bangCapDTO)
        {
            string sql = $"Update BangCap set TenBangCap =N'{bangCapDTO.TenBangCap}' where BangCapID ='{ bangCapDTO.BangCapID}'";
            return sql;
        }

        public string DeleteBangCap(BangCapDTO bangCapDTO)
        {
            string sql = "Delete BangCap where BangCapID = '" + bangCapDTO.BangCapID + "'";
            return sql;
        }

        public string LoadBangCapFromHoSoNhanVien(BangCapDTO bangCapDTO)
        {
            string sql = "Select * from HoSoNhanVien where BangCapID = '" + bangCapDTO.BangCapID + "'";
            return sql;
        }
    }
}
