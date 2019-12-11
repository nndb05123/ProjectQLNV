using HRM_VTHP.Core.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM_VTHP.Core.DAO
{
    class TonGiaoDAO
    {
        private static TonGiaoDAO instance;

        internal static TonGiaoDAO Instance
        {
            get
            {
                if (instance == null) instance = new TonGiaoDAO(); return HRM_VTHP.Core.DAO.TonGiaoDAO.instance;
            }

            private set
            {
                HRM_VTHP.Core.DAO.TonGiaoDAO.instance = value;
            }
        }


        public string LoadAllTonGiao()
        {
            string sql = "Select * from TonGiao";
            return sql;
        }

        public string ThemTonGiao(TonGiaoDTO tonGiaoDTO)
        {
            string sql = "Insert into TonGiao(TenTonGiao) values (N'" + tonGiaoDTO.TenTonGiao + "')";
            return sql;
        }

        public string UpdateTonGiao(TonGiaoDTO tonGiaoDTO)
        {
            string sql = "Update TonGiao set TenTonGiao =N'" + tonGiaoDTO.TenTonGiao + "' where TonGiaoID = '" + tonGiaoDTO.TonGiaoID + "'";
            return sql;
        }

        public string LoadTonGiaoFromHoSoNhanVien(TonGiaoDTO tonGiaoDTO)
        {
            string sql = "Select * from HoSoNhanVien where TonGiaoID = '" + tonGiaoDTO.TonGiaoID + "'";
            return sql;
        }

        public string DeleteTonGiao(TonGiaoDTO tonGiaoDTO)
        {
            string sql = "Delete TonGiao where TonGiaoID = '" + tonGiaoDTO.TonGiaoID + "'";
            return sql;
        }
    }
}
