using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Lab.BL
{
    class analysis_management
    {
        public DataTable Get_all_analysis()
        {
            DAL.DBL dal = new DAL.DBL();
            dal.open();
            DataTable dt = new DataTable();
            dt = dal.SelectData("Get_all_analysis", null);
            dal.close();
            return dt;
        }


        public void Add_analysis(string name_en,string analysis_price,string how_to_analysis,string analysis_time,string result,string notes)
        {
            DAL.DBL dal = new DAL.DBL();
            dal.open();
            SqlParameter[] param = new SqlParameter[6];
            

            param[0] = new SqlParameter("@name_en", SqlDbType.NVarChar,100);
            param[0].Value = name_en;


            param[1] = new SqlParameter("@analysis_price", SqlDbType.VarChar,50);
            param[1].Value = analysis_price;

            param[2] = new SqlParameter("@how_to_analysis", SqlDbType.NVarChar,100);
            param[2].Value = how_to_analysis;

           
            param[3] = new SqlParameter("@analysis_time", SqlDbType.NVarChar,100);
            param[3].Value = analysis_time;

            param[4] = new SqlParameter("@result", SqlDbType.NVarChar,100);
            param[4].Value = result;


            param[5] = new SqlParameter("@notes", SqlDbType.NVarChar, 200);
            param[5].Value = notes;


            dal.executeCommand("Add_analysis", param);
            dal.close();

        }

        public void add_groups_analysis(string group_name, int analysis_id)
        {
            DAL.DBL dal = new DAL.DBL();
            dal.open();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@group_name", SqlDbType.NVarChar,100);
            param[0].Value = group_name;

            param[1] = new SqlParameter("@analysis_id", SqlDbType.Int);
            param[1].Value = analysis_id;

            dal.executeCommand("add_groups_analysis", param);
            dal.close();
        }

        public void Delete_analysis(int analysis_id)
        {
            DAL.DBL dal = new DAL.DBL();
            dal.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@analysis_id", SqlDbType.Int);
            param[0].Value = analysis_id;
            dal.executeCommand("Delete_analysis", param);
            dal.close();

        }

        public void Update_analysis(int analysis_id,string name_en, string analysis_price, string how_to_analysis, string analysis_time, string result,string notes)
       
        {
            DAL.DBL dal = new DAL.DBL();
            dal.open();
           
           
            SqlParameter[] param = new SqlParameter[7];
            param[0] = new SqlParameter("@analysis_id", SqlDbType.Int);
            param[0].Value = analysis_id;

           

            param[1] = new SqlParameter("@name_en", SqlDbType.NVarChar, 100);
            param[1].Value = name_en;

      
            param[2] = new SqlParameter("@analysis_price", SqlDbType.VarChar,50);
            param[2].Value = analysis_price;

            param[3] = new SqlParameter("@how_to_analysis", SqlDbType.NVarChar, 100);
            param[3].Value = how_to_analysis;

           
            param[4] = new SqlParameter("@analysis_time", SqlDbType.NVarChar, 100);
            param[4].Value = analysis_time;

            param[5] = new SqlParameter("@result", SqlDbType.NVarChar, 100);
            param[5].Value = result;


            param[6] = new SqlParameter("@notes", SqlDbType.NVarChar, 200);
            param[6].Value = notes;


            dal.executeCommand("Update_analysis", param);
            dal.close();

        }

        public void Update_groups_analysis(string group_name, int analysis_id)
        {
            DAL.DBL dal = new DAL.DBL();
            dal.open();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@group_name", SqlDbType.NVarChar, 100);
            param[0].Value = group_name;

            param[1] = new SqlParameter("@analysis_id", SqlDbType.Int);
            param[1].Value = analysis_id;

            dal.executeCommand("Update_groups_analysis", param);
            dal.close();
        }

        public DataTable Search_analysis(string name_en)
        {
            DAL.DBL dal = new DAL.DBL();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@name_en", SqlDbType.NVarChar, 100);
            param[0].Value = name_en;

            dt = dal.SelectData("Search_analysis", param);
            dal.close();
            return dt;

        }
       
    }
}
