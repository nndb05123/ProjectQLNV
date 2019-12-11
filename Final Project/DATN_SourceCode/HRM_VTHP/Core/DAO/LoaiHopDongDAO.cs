using HRM_VTHP.Core.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM_VTHP.Core.DAO
{
    class LoaiHopDongDAO
    {
        private static LoaiHopDongDAO instance;

        internal static LoaiHopDongDAO Instance
        {
            get
            {
                if (instance == null) instance = new LoaiHopDongDAO(); return HRM_VTHP.Core.DAO.LoaiHopDongDAO.instance;
            }

            private set
            {
                HRM_VTHP.Core.DAO.LoaiHopDongDAO.instance = value;
            }
        }


        public string LoadAllLoaiHopDong()
        {
            string sql = "Select * from LoaiHopDong";
            return sql;
        }

        public string ThemLoaiHopDong(LoaiHopDongDTO loaiHopDongDTO)
        {
            string sql = "Insert into LoaiHopDong(TenLoaiHopDong) values(N'" + loaiHopDongDTO.TenLoaiHopDong + "')";
            return sql;
        }

        public string UpdateLoaiHopDong(LoaiHopDongDTO loaiHopDongDTO)
        {
            string sql = "Update LoaiHopDong set TenLoaiHopDong = N'" + loaiHopDongDTO.TenLoaiHopDong + "' where LoaiHopDongID = '" + loaiHopDongDTO.LoaiHopDongID + "'";
            return sql;
        }

        public string LoadLoaiHopDongFromHoSoNhanVien(LoaiHopDongDTO loaiHopDongDTO)
        {
            string sql = "Select * from HopDong where LoaiHopDongID = '" + loaiHopDongDTO.LoaiHopDongID + "'";
            return sql;
        }

        public string DeleteLoaiHopDong(LoaiHopDongDTO loaiHopDongDTO)
        {
            string sql = "Delete LoaiHopDong where LoaiHopDongID = '" + loaiHopDongDTO.LoaiHopDongID + "'";
            return sql;
        }
    }
}
