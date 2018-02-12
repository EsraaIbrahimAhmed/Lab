using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Lab.BL
{
    class Cls_result
    {
      public void add_result (int reservation_id,string name_en,string result, string normal, string comment, string other)
        {
            DAL.DBL dal = new DAL.DBL();
            dal.open();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@reservation_id", SqlDbType.Int);
            param[0].Value = reservation_id;

            param[1] = new SqlParameter("@name_en", SqlDbType.NVarChar,100);
            param[1].Value = name_en;

            param[2] = new SqlParameter("@result", SqlDbType.NVarChar,100);
            param[2].Value = result;

            param[3] = new SqlParameter("@normal", SqlDbType.NVarChar, 100);
            param[3].Value = normal;

            param[4] = new SqlParameter("@comment", SqlDbType.NVarChar, 100);
            param[4].Value = comment;

            param[5] = new SqlParameter("@other", SqlDbType.NVarChar, 100);
            param[5].Value = other;



            dal.executeCommand("add_result", param);
            dal.close();

        }

        ////////////
        public DataTable select_patient_reservation(string patient_name)
        {
            DAL.DBL dal = new DAL.DBL();
            DataTable dt = new DataTable();
            dal.open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@patient_name", SqlDbType.NVarChar,100);
            param[0].Value = patient_name;

            dt = dal.SelectData("select_patient_reservation", param);
            dal.close();

            return dt;
        }

        public DataTable select_analysis_patient(int reservation_id)
        {
            DAL.DBL dal = new DAL.DBL();
            DataTable dt = new DataTable();
            dal.open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@reservation_id", SqlDbType.Int);
            param[0].Value = reservation_id;

            dt = dal.SelectData("select_analysis_patient", param);
            dal.close();

            return dt;
        }

        public DataTable select_group_analysis_normal(string group_name,int reservation_id)
        {
            DAL.DBL dal = new DAL.DBL();
            DataTable dt = new DataTable();
            dal.open();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@group_name", SqlDbType.NVarChar,100);
            param[0].Value = group_name;

            param[1] = new SqlParameter("@reservation_id", SqlDbType.Int);
            param[1].Value = reservation_id;


            dt = dal.SelectData("select_group_analysis_normal", param);
            dal.close();

            return dt;
        }

        public DataTable select_group_patient(int reservation_id)
        {
            DAL.DBL dal = new DAL.DBL();
            DataTable dt = new DataTable();
            dal.open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@reservation_id", SqlDbType.Int);
            param[0].Value = reservation_id;

            dt = dal.SelectData("select_group_patient", param);
            dal.close();

            return dt;
        }

    }
}
