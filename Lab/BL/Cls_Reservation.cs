using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Lab.BL
{
    class Cls_Reservation
    {
        public DataTable Get_all_con()
        {
            DAL.DBL dal = new DAL.DBL();
            dal.open();
            DataTable dt = new DataTable();
            dt = dal.SelectData("Get_all_con", null);
            dal.close();
            return dt;
        }

        public DataTable get_patient(string patient_name)
        {
            DAL.DBL dal = new DAL.DBL();
            dal.open();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@patient_name", SqlDbType.NVarChar,100);
            param[0].Value = patient_name;
            dt=dal.SelectData("get_patient", param);
            dal.close();
            return dt;
        }
        public DataTable select_patient(string patient_name)
        {
            DAL.DBL dal = new DAL.DBL();
            dal.open();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@patient_name", SqlDbType.NVarChar, 100);
            param[0].Value = patient_name;
            dt= dal.SelectData("select_patient", param);
            dal.close();
            return dt;
        }
        public DataTable select_group(string group_name)
        {
            DAL.DBL dal = new DAL.DBL();
            dal.open();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("group_name", SqlDbType.NVarChar, 100);
            param[0].Value = group_name;
            dt=dal.SelectData("select_group", param);
            dal.close();
            return dt;
        }

        public DataTable select_analysis(string name_en,string group_name)
        {
            DAL.DBL dal = new DAL.DBL();
            dal.open();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("name_en", SqlDbType.NVarChar, 100);
            param[0].Value = name_en;

            param[1] = new SqlParameter("group_name", SqlDbType.NVarChar, 100);
            param[1].Value = group_name;

            dt = dal.SelectData("select_analysis", param);
            dal.close();
            return dt;
        }

        public void add_reservation(string reservation_date, int patient_id,string doctor_name, double price, double discount, double total, double paid, double rest)
        {
            DAL.DBL dal = new DAL.DBL();
            dal.open();
            SqlParameter[] param = new SqlParameter[8];
           
            param[0] = new SqlParameter("@reservation_date", SqlDbType.Date);
            param[0].Value = reservation_date;

            param[1] = new SqlParameter("@patient_id", SqlDbType.Int);
            param[1].Value = patient_id;

            param[2] = new SqlParameter("@doctor_name", SqlDbType.NVarChar,100);
            param[2].Value = doctor_name;



            param[3] = new SqlParameter("@price", SqlDbType.Float);
            param[3].Value = price;

            param[4] = new SqlParameter("@discount", SqlDbType.Float);
            param[4].Value = discount;

            param[5] = new SqlParameter("@total", SqlDbType.Float);
            param[5].Value = total;

            param[6] = new SqlParameter("@paid", SqlDbType.Float);
            param[6].Value = paid;

            param[7] = new SqlParameter("@rest", SqlDbType.Float);
            param[7].Value = rest;

            dal.executeCommand("add_reservation", param);
            dal.close();
        }

        public void add_reservation_analysis(int reservation_id,string name_en)
        {
            DAL.DBL dal = new DAL.DBL();
            dal.open();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@reservation_id", SqlDbType.Int);
            param[0].Value = reservation_id;

            param[1] = new SqlParameter("@name_en", SqlDbType.NVarChar,100);
            param[1].Value = name_en;

            dal.executeCommand("add_reservation_analysis", param);
            dal.close();
        }
    }
}
