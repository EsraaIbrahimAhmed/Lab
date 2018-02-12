using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Lab.BL
{
    class CLS_LISTPATIENT
    {
        //********************عرض***********************
        public DataTable GET_List_PATIENT()
        {
            DAL.DBL dal = new DAL.DBL();
            DataTable dt = new DataTable();
            dt = dal.SelectData("get_list_patient", null);
            dal.close();
            return dt;
        }
    }
}
