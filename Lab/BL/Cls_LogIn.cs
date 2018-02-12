using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Lab.BL
{
    class Cls_LogIn
    {
        public DataTable LogIN(int ID, string pwd, string Ujob)
        {
            DAL.DBL dal = new DAL.DBL();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@ID", SqlDbType.Int);
            param[0].Value = ID;

            param[1] = new SqlParameter("@Pwd", SqlDbType.NVarChar,50);
            param[1].Value = pwd;

            param[2] = new SqlParameter("@Ujob", SqlDbType.NVarChar,50);
            param[2].Value = Ujob;

            dal.open();
            DataTable dt = new DataTable();
            dt = dal.SelectData("UserLogIn", param);
            dal.close();
            return dt;
        }
    }
}
