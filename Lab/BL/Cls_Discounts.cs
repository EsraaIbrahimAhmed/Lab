using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Lab.BL
{
    class Cls_Discounts
    {
        //****************Doctors*********************************
        public DataTable GetContractors(int sign)
        {
            DAL.DBL dal = new DAL.DBL();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@sign", SqlDbType.Int);
            param[0].Value = @sign;
            dt = dal.SelectData("GetContractors", param);
            dal.close();
            return dt;
        }
        //****************AnalysisPrice*****************************
        public DataTable GetAnalysisPrice()
        {
            DAL.DBL dal = new DAL.DBL();
            DataTable dt = new DataTable();
            dt = dal.SelectData("GetAnalysisPrice", null);
            dal.close();
            return dt;
        }
       
        ////****************Contractors*********************************
        //public DataTable GetContractors()
        //{
        //    DAL.DBL dal = new DAL.DBL();
        //    dal.open();
        //    DataTable dt = new DataTable();
        //    dt = dal.SelectData("GetContractors", null);
        //    dal.close();
        //    return dt;
        //}


        
        ////****************ELab****************************************
        //public DataTable GetELab()
        //{
        //    DAL.DBL dal = new DAL.DBL();
        //    dal.open();
        //    DataTable dt = new DataTable();
        //    dt = dal.SelectData("GetELab", null);
        //    dal.close();
        //    return dt;
        //}
    }
}
