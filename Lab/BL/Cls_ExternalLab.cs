using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Lab.BL
{
    class Cls_ExternalLab
    {
        public DataTable Get_All_EXLab()
        {
            DAL.DBL dal = new DAL.DBL();
            DataTable dt = new DataTable();
            dt = dal.SelectData("GetAllLab", null);
            dal.close();
            return dt;
        }
        public void Add_ExLab(string Exlname, string ExLaddress, string ExLphone, string ExLemail, string ExLdiscount)
        {
            DAL.DBL dal = new DAL.DBL();
            dal.open();
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@EXLname", SqlDbType.NVarChar, 100);
            param[0].Value = Exlname;

            param[1] = new SqlParameter("@EXLaddress", SqlDbType.NVarChar, 100);
            param[1].Value = ExLaddress;

            param[2] = new SqlParameter("@EXLphone", SqlDbType.VarChar, 50);
            param[2].Value = ExLphone;

            param[3] = new SqlParameter("@EXLemail", SqlDbType.NVarChar, 100);
            param[3].Value = ExLemail;

            param[4] = new SqlParameter("@EXLdiscount", SqlDbType.VarChar, 50);
            param[4].Value = ExLdiscount;

            dal.executeCommand("AddingLab", param);
            dal.close();
        }
        public void Update_ExLab(int ExLid ,string Exlname, string ExLaddress, string ExLphone, string ExLemail, string ExLdiscount)
        {
            DAL.DBL dal = new DAL.DBL();
            dal.open();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@EXLid", SqlDbType.Int);
            param[0].Value = ExLid;

            param[1] = new SqlParameter("@EXLname", SqlDbType.NVarChar, 100);
            param[1].Value = Exlname;

            param[2] = new SqlParameter("@EXLaddress", SqlDbType.NVarChar, 100);
            param[2].Value = ExLaddress;

            param[3] = new SqlParameter("@EXLphone", SqlDbType.VarChar, 50);
            param[3].Value = ExLphone;

            param[4] = new SqlParameter("@EXLemail", SqlDbType.NVarChar, 100);
            param[4].Value = ExLemail;

            param[5] = new SqlParameter("@EXLdiscount", SqlDbType.VarChar, 50);
            param[5].Value = ExLdiscount;


            dal.executeCommand("UpdatingExLab", param);
            dal.close();
        }
        public void Delete_ExLab(int ID)
        {
            DAL.DBL dal = new DAL.DBL();
            dal.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@EXLid", SqlDbType.Int);
            param[0].Value = ID;
            dal.executeCommand("DeleteExLab", param);
            dal.close();
        }
        public DataTable SearchExLabByName(string name)
        {
            DAL.DBL dal = new DAL.DBL();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("ExLname", SqlDbType.NVarChar, 100);
            param[0].Value = name;
            dt = dal.SelectData("SearchExLabByName", param);
            dal.close();
            return dt;
        }
    
   }
}
