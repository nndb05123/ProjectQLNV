using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectQLNVOAD.Model.DTO;


namespace ProjectQLNVOAD.Model.DAO
{
    public class DonViDAO
    {
        #region LoadDonVI
        //Load = Select
        public  string QueryLoadDV()
        {
            //select * from DonVi(cần check)
            string Query ="select tenDonVi, diaChi, SDT, namThanhLap" +
                "From DonVi"; 
            return Query;
        }
        #endregion
        #region SearchDonVi
        //Sửa phụ thuộc vào số lượng biến tìm
        //Cần Check lại query search
        public string QuerySearchDV(string TenDV)
        {
            string Query = "select DonVi*" +
                "From DonVi" +
                "Where DonVi.tenDonVi = "+TenDV +"";
            return Query;
        }
        #endregion
        #region InsertDonVi
        public string QueryInsertDV(DonViDTO DV)
        {
            string Query ="insert into DonVi VALUES('" + DV.MaDV + "', '" + DV.TenDV + "', '" + DV.DiaChiDV + "', '" 
                + DV.SDTDV + "', '" + DV.NamThanhLapDV + "'";
            return Query;
        }
        #endregion
        #region UpdateDonVi
        public string QueryUpdateDV(DonViDTO DV)
        {
            string query = "update DonVi set MaDonVi = '" + DV.MaDV + "',tenDonVi = '"+ DV.TenDV + "',diaChi = '" 
                + DV.DiaChiDV + "',SDT = '" + DV.SDTDV + "',namThanhLap = '" + DV.NamThanhLapDV + "' ";
            return query;
        }
        #endregion
        #region DeleteDonVi
        public string QueryDeleteDV(DonViDTO DV)
        {
            string Query = "delete DonVi where MaDonVi ="+DV.MaDV+"";
            return Query;
        }
        #endregion
    }
}
