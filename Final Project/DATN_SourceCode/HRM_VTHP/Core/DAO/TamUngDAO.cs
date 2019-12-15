using HRM_VTHP.Core.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM_VTHP.Core.DAO
{
    class TamUngDAO
    {
        private static TamUngDAO instance;

        internal static TamUngDAO Instance
        {
            get
            {
                if (instance == null) instance = new TamUngDAO(); return HRM_VTHP.Core.DAO.TamUngDAO.instance;
            }

            private set
            {
                HRM_VTHP.Core.DAO.TamUngDAO.instance = value;
            }
        }


        public string LoadAllTamUng()
        {
            string sql = "Select * from TamUng";
            return sql;
        }

        public string ThemTamUng(TamUngDTO tamUngDTO)
        {
            string sql = "Insert into TamUng(TenTamUng) values(N'" + tamUngDTO.TenTamUng + "')";
            return sql;
        }

        public string UpdateTamUng(TamUngDTO tamUngDTO)
        {
            string sql = "Update TamUng set TenTamUng =N'" + tamUngDTO.TenTamUng + "' where TamUngID ='" + tamUngDTO.TamUngID + "'";
            return sql;
        }

        public string LoadTamUngFromHoSoNhanVien(TamUngDTO tamUngDTO)
        {
            string sql = "Select * from ChiTietTamUng where TamUngID ='" + tamUngDTO.TamUngID + "'";
            return sql;
        }

        public string DeleteTamUng(TamUngDTO tamUngDTO)
        {
            string sql = "Delete TamUng where TamUngID ='" + tamUngDTO.TamUngID + "'";
            return sql;
        }
    }
}
