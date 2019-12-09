using HRM_VTHP.Core.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM_VTHP.Core.DAO
{
    class NgoaiNguDAO
    {
        private static NgoaiNguDAO instance;

        internal static NgoaiNguDAO Instance
        {
            get
            {
                if (instance == null) instance = new NgoaiNguDAO(); return HRM_VTHP.Core.DAO.NgoaiNguDAO.instance;
            }

            private set
            {
                HRM_VTHP.Core.DAO.NgoaiNguDAO.instance = value;
            }
        }


        public string LoadAllNgoaiNgu()
        {
            string sql = "Select * from NgoaiNgu";
            return sql;
        }

        public string ThemNgoaiNgu(NgoaiNguDTO ngoaiNguDTO)
        {
            string sql = "Insert into NgoaiNgu(TenCCNN) values (N'" + ngoaiNguDTO.TenCCNN + "')";
            return sql;
        }

        public string UpdateNgoaiNgu(NgoaiNguDTO ngoaiNguDTO)
        {
            string sql = "Update NgoaiNgu set TenCCNN = N'" + ngoaiNguDTO.TenCCNN + "' where NgoaiNguID = '" + ngoaiNguDTO.NgoaiNguID + "'";
            return sql;
        }

        public string LoadNgoaiNguFormHoSoNhanVien(NgoaiNguDTO ngoaiNguDTO)
        {
            string sql = "Select * from HoSoNhanVien where NgoaiNguID = '" + ngoaiNguDTO.NgoaiNguID + "'";
            return sql;
        }

        public string DeleteNgoaiNgu(NgoaiNguDTO ngoaiNguDTO)
        {
            string sql = "Delete NgoaiNgu where NgoaiNguID = '" + ngoaiNguDTO.NgoaiNguID + "'";
            return sql;
        }

    }
}
