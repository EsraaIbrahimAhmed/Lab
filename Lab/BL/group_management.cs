using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Lab.BL
{
    class group_management
    {
        public DataTable Get_all_groups()
        {
            DAL.DBL dal = new DAL.DBL();
            dal.open();
            DataTable dt = new DataTable();
            dt = dal.SelectData("Get_all_groups", null);
            dal.close();
            return dt;
        }

        public DataTable Search_group(string group_name)
        {
            DAL.DBL dal = new DAL.DBL();
            dal.open();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@group_name", SqlDbType.NVarChar, 100);
            param[0].Value = group_name;

            dt = dal.SelectData("Search_group", param);
            dal.close();
            return dt;

        }

        public void Add_group(string group_name, int analysis_num)
        {
            DAL.DBL dal = new DAL.DBL();
            dal.open();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@group_name", SqlDbType.NVarChar, 100);
            param[0].Value = group_name;

            param[1] = new SqlParameter("@analysis_num", SqlDbType.Int);
            param[1].Value = analysis_num;


            dal.executeCommand("Add_group", param);
            dal.close();

        }

        public void Delete_group(int group_id)
        {
            DAL.DBL dal = new DAL.DBL();
            dal.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@group_id", SqlDbType.Int);
            param[0].Value = group_id;
            dal.executeCommand("Delete_group", param);
            dal.close();

        }

        public void Update_group(int group_id, string group_name, int analysis_num)
        {
            DAL.DBL dal = new DAL.DBL();
            dal.open();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@group_id", SqlDbType.Int);
            param[0].Value = group_id;

            param[1] = new SqlParameter("@group_name", SqlDbType.NVarChar, 100);
            param[1].Value = group_name;

            param[2] = new SqlParameter("@analysis_num", SqlDbType.Int );
            param[2].Value = analysis_num;


            dal.executeCommand("Update_group", param);
            dal.close();

        }
    }
}
