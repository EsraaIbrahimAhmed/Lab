using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Lab.BL
{
    class Cls_Doctor
    {
        public DataTable Get_All_Doctors()
        {
            DAL.DBL dal = new DAL.DBL();
            DataTable dt = new DataTable();
            dt = dal.SelectData("GetAllDoctors", null);
            dal.close();
            return dt;
        }
        public void Add_Doctor(string Dname, string Dspecialization, string Daddress, string Dphone, string Demail, string Ddiscount)
        {
            DAL.DBL dal = new DAL.DBL();
            dal.open();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@Dname", SqlDbType.NVarChar, 100);
            param[0].Value = Dname;

            param[1] = new SqlParameter("@Dspecialization", SqlDbType.NVarChar, 100);
            param[1].Value = Dspecialization;

            param[2] = new SqlParameter("@Daddress", SqlDbType.NVarChar, 100);
            param[2].Value = Daddress;

            param[3] = new SqlParameter("@Dphone", SqlDbType.VarChar, 50);
            param[3].Value = Dphone;

            param[4] = new SqlParameter("@Demail", SqlDbType.VarChar, 50);
            param[4].Value = Demail;

            param[5] = new SqlParameter("@Ddiscount", SqlDbType.VarChar, 50);
            param[5].Value = Ddiscount;

            dal.executeCommand("AddingDoctor", param);
            dal.close();
        }
        public void Update_Doctor(int Did ,string Dname, string Dspecialization, string Daddress, string Dphone, string Demail, string Ddiscount)
        {
            DAL.DBL dal = new DAL.DBL();
            dal.open();
            SqlParameter[] param = new SqlParameter[7];
            param[0] = new SqlParameter("@Did", SqlDbType.Int);
            param[0].Value = Did;

            param[1] = new SqlParameter("@Dname", SqlDbType.NVarChar, 100);
            param[1].Value = Dname;

            param[2] = new SqlParameter("@Dspecialization", SqlDbType.NVarChar, 100);
            param[2].Value = Dspecialization;

            param[3] = new SqlParameter("@Daddress", SqlDbType.NVarChar, 100);
            param[3].Value = Daddress;

            param[4] = new SqlParameter("@Dphone", SqlDbType.VarChar, 50);
            param[4].Value = Dphone;

            param[5] = new SqlParameter("@Demail", SqlDbType.VarChar, 50);
            param[5].Value = Demail;

            param[6] = new SqlParameter("@Ddiscount", SqlDbType.VarChar, 50);
            param[6].Value = Ddiscount;

            dal.executeCommand("UpdatingDoctor", param);
            dal.close();
        }

        public void Delete_Doctor(int ID)
        {
            DAL.DBL dal = new DAL.DBL();
            dal.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Did", SqlDbType.Int);
            param[0].Value = ID;
            dal.executeCommand("DeleteDoctor", param);
            dal.close();
        }

        public DataTable SearchDoctorByName(string name)
        {
            DAL.DBL dal = new DAL.DBL();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Dname", SqlDbType.NVarChar, 100);
            param[0].Value = name;
            dt = dal.SelectData("SearchDoctorByName", param);
            dal.close();
            return dt;
        }
        public DataTable SearchDoctorBySpecialization(string specialization)
        {
            DAL.DBL dal = new DAL.DBL();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Dspecialization", SqlDbType.NVarChar, 100);
            param[0].Value = specialization;
            dt = dal.SelectData("SearchDoctorBySpecialization", param);
            dal.close();
            return dt;
        }
    }
}
