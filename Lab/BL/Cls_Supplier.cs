using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Lab.BL
{
    
    class Cls_Supplier
    {
        public DataTable Get_All_Supplier()
        {
            DAL.DBL dl=new DAL.DBL();
            DataTable dt = new DataTable();
            dt = dl.SelectData("SelectSup",null);
            dl.close();
            return dt;
        }
        public void Add_Supplier(string name, string specialization, string address, string phone, string email)
        {
            DAL.DBL dal = new DAL.DBL();
            dal.open();
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@supp_name", SqlDbType.NVarChar, 100);
            param[0].Value = name;
            param[1] = new SqlParameter("@supp_specialization", SqlDbType.NVarChar, 100);
            param[1].Value = specialization;
            param[2] = new SqlParameter("@supp_address", SqlDbType.NVarChar, 100);
            param[2].Value = address;
            param[3] = new SqlParameter("@supp_phone", SqlDbType.NVarChar, 50);
            param[3].Value = phone;
            param[4] = new SqlParameter("@supp_email", SqlDbType.NVarChar, 100);
            param[4].Value = email;
            dal.executeCommand("AddSupp",param);
            dal.close();
        }

      public void UpDate_Supplier(int id ,string name, string specialization, string address, string phone, string email)
        {
            DAL.DBL dal = new DAL.DBL();
            dal.open();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@supp_id", SqlDbType.Int);
            param[0].Value = id;

            param[1] = new SqlParameter("@supp_name", SqlDbType.NVarChar, 100);
            param[1].Value = name;

            param[2] = new SqlParameter("@supp_specialization", SqlDbType.NVarChar, 100);
            param[2].Value = specialization;

            param[3] = new SqlParameter("@supp_address", SqlDbType.NVarChar, 100);
            param[3].Value = address;

            param[4] = new SqlParameter("@supp_phone", SqlDbType.NVarChar, 50);
            param[4].Value = phone;

            param[5] = new SqlParameter("supp_email", SqlDbType.NVarChar, 100);
            param[5].Value = email;

            dal.executeCommand("UpDateSupp", param);
            dal.close();
        }
      public void Delete_Supplier(int id)
      {

          DAL.DBL dal = new DAL.DBL();
          dal.open();
          SqlParameter[] param = new SqlParameter[1];
          param[0] = new SqlParameter("@supp_id", SqlDbType.Int);
          param[0].Value = id; 
          dal.executeCommand("DeleteSup", param);
          dal.close();
      }

      public DataTable SearchSupByName(string name)
      {
          DAL.DBL dal = new DAL.DBL();
          DataTable dt = new DataTable();
          SqlParameter[] param = new SqlParameter[1];
          param[0] = new SqlParameter("@sname", SqlDbType.NVarChar, 100);
          param[0].Value = name;
          dt = dal.SelectData("SearchSupByName", param);
          dal.close();
          return dt;
      }

    
    }
}
