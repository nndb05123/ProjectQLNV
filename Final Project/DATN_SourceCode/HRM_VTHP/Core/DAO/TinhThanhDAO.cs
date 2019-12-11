using HRM_VTHP.Core.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM_VTHP.Core.DAO
{
    class TinhThanhDAO
    {
        private static TinhThanhDAO instance;

        internal static TinhThanhDAO Instance
        {
            get
            {
                if (instance == null) instance = new TinhThanhDAO(); return HRM_VTHP.Core.DAO.TinhThanhDAO.instance;
            }

            private set
            {
                HRM_VTHP.Core.DAO.TinhThanhDAO.instance = value;
            }
        }


        public string LoadAllTinhThanh()
        {
            string sql = "Select * from TinhThanh";
            return sql;
        }

        public string ThemTinhThanh(TinhThanhDTO tinhThanhDTO)
        {
            string sql = "Insert into TinhThanh(TenTinhThanh) values (N'" + tinhThanhDTO.TenTinhThanh + "')";
            return sql;
        }

        public string UpdateTinhThanh(TinhThanhDTO tinhThanhDTO)
        {
            string sql = "Update TinhThanh set TenTinhThanh = N'" + tinhThanhDTO.TenTinhThanh + "' where TinhThanhID = '" + tinhThanhDTO.TinhThanhID + "'";
            return sql;
        }

        public string LoadTinhThanhFromHoSoNhanVien(TinhThanhDTO tinhThanhDTO)
        {
            string sql = "Select * from HoSoNhanVien where TinhThanhID = '" + tinhThanhDTO.TinhThanhID + "'";
            return sql;
        }

        public string DeleteTinhThanh(TinhThanhDTO tinhThanhDTO)
        {
            string sql = "Delete TinhThanh where TinhThanhID = '" + tinhThanhDTO.TinhThanhID + "'";
            return sql;
        }
    }
}
