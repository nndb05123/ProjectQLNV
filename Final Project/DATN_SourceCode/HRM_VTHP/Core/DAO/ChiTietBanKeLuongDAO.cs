using HRM_VTHP.Core.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM_VTHP.Core.DAO
{
    class ChiTietBanKeLuongDAO
    {
        private static ChiTietBanKeLuongDAO instance;

        internal static ChiTietBanKeLuongDAO Instance
        {
            get
            {
                if (instance == null) instance = new ChiTietBanKeLuongDAO(); return HRM_VTHP.Core.DAO.ChiTietBanKeLuongDAO.instance;
            }

            private set
            {
                HRM_VTHP.Core.DAO.ChiTietBanKeLuongDAO.instance = value;
            }
        }

        public string UpdateStatusChiTietBanKeLuong(ChiTietBanKeLuongDTO chiTietBanKeLuongDTO)
        {
            string sql = @"Update ChiTietBanKeLuong Set TrangThai = 2 where ChiTietBanKeLuongID = '" + chiTietBanKeLuongDTO.ChiTietBanKeLuongID + "'";
            return sql;
        }

        public string UpdateStatusChiTietBanKeLuongWithNhanVienAndTamUng(int NhanVienID, int ThangTamUng )
        {
            string sql = @"update ChiTietTamUng set TrangThaiID = 2 Where NhanVienID = '" + NhanVienID + "' And ThangTamUng = '" + ThangTamUng + "'";
            return sql;
        }

        public string UpdateChiTietBanKeLuong(ChiTietBanKeLuongDTO chiTietBanKeLuongDTO)
        {
            string sql = @"UPDATE ChiTietBanKeLuong
                        SET
                            [TienLuongCung] = '" + chiTietBanKeLuongDTO.TienLuongCung + @"'
                            ,[HieuSuat] = '" + chiTietBanKeLuongDTO.HieuSuat + @"'
                            ,[PhuCap] = '" + chiTietBanKeLuongDTO.PhuCap + @"'
                            ,[TamUng] = '" + chiTietBanKeLuongDTO.TamUng + @"'
                            ,[TongLuong] = '" + chiTietBanKeLuongDTO.TongLuong + @"' 
                            ,[ThueThuNhapCaNhan] = '" + chiTietBanKeLuongDTO.ThueThuNhapCaNhan + @"'
                            ,[ThucLinh] = '" + chiTietBanKeLuongDTO.ThucLinh + @"'   
                        WHERE ChiTietBanKeLuongID = '" + chiTietBanKeLuongDTO.ChiTietBanKeLuongID + "'";
            return sql;
        }
    }
}
