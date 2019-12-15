using HRM_VTHP.Core.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM_VTHP.Core.DAO
{
    class MoiQuanHeDAO
    {
        private static MoiQuanHeDAO instance;

        internal static MoiQuanHeDAO Instance
        {
            get
            {
                if (instance == null) instance = new MoiQuanHeDAO(); return HRM_VTHP.Core.DAO.MoiQuanHeDAO.instance;
            }

            private set
            {
                HRM_VTHP.Core.DAO.MoiQuanHeDAO.instance = value;
            }
        }


        public string LoadAllMoiQuanHe()
        {
            string sql = "Select * from MoiQuanHe";
            return sql;
        }

        public string ThemMoiQuanHe(MoiQuanHeDTO moiQuanHeDTO)
        {
            string sql = "Insert into MoiQuanHe(TenMoiQuanHe) values(N'" + moiQuanHeDTO.TenMoiQuanHe + "')";
            return sql;
        }

        public string UpdateMoiQuanHe(MoiQuanHeDTO moiQuanHeDTO)
        {
            string sql = "Update MoiQuanHe set TenMoiQuanHe = N'" + moiQuanHeDTO.TenMoiQuanHe + "' where MoiQuanHeID = '" + moiQuanHeDTO.MoiQuanHeID + "'";
            return sql;
        }

        public string LoadMoiQuanHeFromHoSoNhanVien(MoiQuanHeDTO moiQuanHeDTO)
        {
            string sql = "Select * from NguoiThan where MoiQuanHeID = '" + moiQuanHeDTO.MoiQuanHeID + "'";
            return sql;
        }

        public string DeleteMoiQuanHe(MoiQuanHeDTO moiQuanHeDTO)
        {
            string sql = "Delete MoiQuanHe where MoiQuanHeID = '" + moiQuanHeDTO.MoiQuanHeID + "'";
            return sql;
        }
    }
}
