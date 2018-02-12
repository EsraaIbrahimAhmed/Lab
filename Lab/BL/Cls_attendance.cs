using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Lab.BL
{
    class Cls_attendance
    {



        public DataTable Attendance(string id)
        {
            DAL.DBL dal = new DAL.DBL();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.NVarChar, 100);
            param[0].Value = id;
            
            dt = dal.SelectData("SearchAttendance", param);
            dal.close();
            return dt;
        }

        public DataTable dismisal(string id, DateTime date)
        {
            DAL.DBL dal = new DAL.DBL();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@id", SqlDbType.NVarChar, 100);
            param[0].Value = id;
            param[1] = new SqlParameter("@date", SqlDbType.Date, 100);
            param[1].Value = date;
            dt = dal.SelectData("getdismsal", param);
            dal.close();
            return dt;
        }

        public void GetAttend(int id, DateTime d,DateTime date)
        {
            DAL.DBL dal = new DAL.DBL();
            dal.open();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@id", SqlDbType.Int, 100);
            param[0].Value = id;
            param[1] = new SqlParameter("@dateattend", SqlDbType.DateTime, 100);
            param[1].Value = d;
            param[2] = new SqlParameter("@dateoftoday", SqlDbType.DateTime, 100);
            param[2].Value = date;
            dal.executeCommand("AddAttend", param);
            dal.close();
        }

        public void GetDimisal(int id, DateTime d)//,DateTime att)
        {
            DAL.DBL dal = new DAL.DBL();
            dal.open();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@id", SqlDbType.Int, 100);
            param[0].Value = id;
            param[1] = new SqlParameter("@datedimisal", SqlDbType.DateTime, 100);
            param[1].Value = d;
           // param[2] = new SqlParameter("@attend", SqlDbType.DateTime, 100);
            //param[2].Value = att;

            dal.executeCommand("adddimisal", param);
            dal.close();
        }

    }
}
