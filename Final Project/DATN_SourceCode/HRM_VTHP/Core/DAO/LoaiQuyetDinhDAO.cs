using HRM_VTHP.Core.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM_VTHP.Core.DAO
{
    class LoaiQuyetDinhDAO
    {
        private static LoaiQuyetDinhDAO instance;

        internal static LoaiQuyetDinhDAO Instance
        {
            get
            {
                if (instance == null) instance = new LoaiQuyetDinhDAO(); return HRM_VTHP.Core.DAO.LoaiQuyetDinhDAO.instance;
            }

            private set
            {
                HRM_VTHP.Core.DAO.LoaiQuyetDinhDAO.instance = value;
            }
        }


        public string LoadAllLoaiQuyetDinh()
        {
            string sql = "Select * from LoaiQuyetDinh";
            return sql;
        }

        public string ThemLoaiQuyetDinh(LoaiQuyetDinhDTO loaiQuyetDinhDTO)
        {
            string sql = "Insert into LoaiQuyetDinh(TenLoaiQuyetDinh) values(N'" + loaiQuyetDinhDTO.TenLoaiQuyetDinh + "')";
            return sql;
        }

        public string UpdateLoaiQuyetDinh(LoaiQuyetDinhDTO loaiQuyetDinhDTO)
        {
            string sql = "Update LoaiQuyetDinh set TenLoaiQuyetDinh =N'" + loaiQuyetDinhDTO.TenLoaiQuyetDinh + "' where LoaiQuyetDinhID ='" + loaiQuyetDinhDTO.LoaiQuyetDinhID + "'";
            return sql;
        }

        public string LoadLoaiQuyetDinhFromHoSoNhanVien(LoaiQuyetDinhDTO loaiQuyetDinhDTO)
        {
            string sql = "Select * from KhenThuongKyLuat where LoaiQuyetDinhID ='" + loaiQuyetDinhDTO.LoaiQuyetDinhID + "'";
            return sql;
        }

        public string DeleteLoaiQuyetDinh(LoaiQuyetDinhDTO loaiQuyetDinhDTO)
        {
            string sql = "Delete LoaiQuyetDinh where LoaiQuyetDinhID ='" + loaiQuyetDinhDTO.LoaiQuyetDinhID + "'";
            return sql;
        }
    }
}
