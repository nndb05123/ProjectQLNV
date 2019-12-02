using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ProjectQLNVOAD.Model.DAO;//
using ProjectQLNVOAD.Model.DTO;
using ProjectQLNVOAD.APIManager;//DATABASE CONNECTION



namespace ProjectQLNVOAD.Controller.BUS
{
    class DonViBUS
    {
        //Gọi data
        DonViDAO DV_DAO = new DonViDAO();
        #region IdentityDonVi
        public int IdentityDV()
        {
            int id = 0;
            string column = "MaDonVi";
            string table = "DonVi";
            id = ConnectionSQL.Identitytable(id, column, table);
            return id;
        }
        #endregion
        #region LoadDonVi
        public DataTable LoadDV()
        {
            DataTable table;
            table = ConnectionSQL.TaoBang(DV_DAO.QueryLoadDV());
            return table;
        }
        #endregion
        #region SearchDonVi
        public DataTable SearchDV(string TenDV)
        {
            DataTable table;
            table = ConnectionSQL.TaoBang(DV_DAO.QuerySearchDV(TenDV));
            return table;
        }
        #endregion
        #region InsertDonVI
        public bool InsertDV(DonViDTO DV)
        {
            bool table = false;
            if(ConnectionSQL.ExecuteNonQuery(DV_DAO.QueryInsertDV(DV)) > 0)
            {
                table = true;
            }
            return table;
        }
        #endregion
        #region DeleteDonVi
        public bool DeleteDV(DonViDTO DV)
        {
            bool table = false;
            if (ConnectionSQL.ExecuteNonQuery(DV_DAO.QueryDeleteDV(DV)) > 0)
            {
                table = true;
            }
            return table;
        }
        #endregion
        #region UpdateDonVi
        public bool UpdateDV(DonViDTO DV)
        {
            bool table = false;
            if (ConnectionSQL.ExecuteNonQuery(DV_DAO.QueryUpdateDV(DV)) > 0)
            {
                table = true;
            }
            return table;
        }
        #endregion
    }
}
