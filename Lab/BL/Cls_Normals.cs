using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Lab.BL
{
    class Cls_Normals
    {
        public void Add_normal(string name_en, int age_from, string unit_from, int age_to, string unit_to, string gender, string normal, string normal_unit)
        {
            DAL.DBL dal = new DAL.DBL();
            dal.open();
            SqlParameter[] param = new SqlParameter[8];
            param[0] = new SqlParameter("@name_en", SqlDbType.NVarChar, 100);
            param[0].Value = name_en;

            param[1] = new SqlParameter("@age_from", SqlDbType.Int);
            param[1].Value = age_from;

            param[2] = new SqlParameter("@unit_from", SqlDbType.NVarChar,100);
            param[2].Value = unit_from;

            param[3] = new SqlParameter("@age_to", SqlDbType.Int);
            param[3].Value = age_to;

            param[4] = new SqlParameter("@unit_to", SqlDbType.NVarChar,100);
            param[4].Value = unit_to;

            param[5] = new SqlParameter("@gender", SqlDbType.NVarChar, 50);
            param[5].Value = gender;

            param[6] = new SqlParameter("@normal", SqlDbType.NVarChar, 50);
            param[6].Value = normal;


            param[7] = new SqlParameter("@normal_unit", SqlDbType.NVarChar, 50);
            param[7].Value = normal_unit;

            dal.executeCommand("Add_normal", param);
            dal.close();

        }

        public void Delete_normal(int normal_id)
        {
            DAL.DBL dal = new DAL.DBL();
            dal.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@normal_id", SqlDbType.Int);
            param[0].Value = normal_id;
            dal.executeCommand("Delete_normal", param);
            dal.close();

        }

        public void Update_normal(int normal_id,string name_en, int age_from,string unit_from, int age_to,string unit_to, string gender, string normal,string normal_unit)
        {
            DAL.DBL dal = new DAL.DBL();
            dal.open();
            SqlParameter[] param = new SqlParameter[9];

            param[0] = new SqlParameter("@normal_id",SqlDbType.Int);
            param[0].Value = normal_id;

            param[1] = new SqlParameter("@name_en", SqlDbType.NVarChar, 100);
            param[1].Value = name_en;

            param[2] = new SqlParameter("@age_from", SqlDbType.Int);
            param[2].Value = age_from;

            param[3] = new SqlParameter("@unit_from", SqlDbType.NVarChar, 100);
            param[3].Value = unit_from;

            param[4] = new SqlParameter("@age_to", SqlDbType.Int);
            param[4].Value = age_to;

            param[5] = new SqlParameter("@unit_to", SqlDbType.NVarChar, 100);
            param[5].Value = unit_from;

            param[6] = new SqlParameter("@gender", SqlDbType.NVarChar, 50);
            param[6].Value = gender;

            param[7] = new SqlParameter("@normal", SqlDbType.NVarChar, 50);
            param[7].Value = normal;

            param[8] = new SqlParameter("@normal_unit", SqlDbType.NVarChar, 50);
            param[8].Value = normal_unit;


            dal.executeCommand("Update_normal", param);
            dal.close();

        }

        public DataTable Search_normal(string name_en)
        {
            DAL.DBL dal = new DAL.DBL();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@name_en", SqlDbType.NVarChar, 100);
            param[0].Value = name_en;

            dt = dal.SelectData("Search_normal", param);
            dal.close();
            return dt;

        }

        public DataTable Get_all_analysis()
        {
            DAL.DBL dal = new DAL.DBL();
            dal.open();
            DataTable dt = new DataTable();
            dt = dal.SelectData("Get_all_analysis", null);
            dal.close();
            return dt;
        }
        public DataTable GetAllNormals()
        {
            DAL.DBL dal = new DAL.DBL();
            dal.open();
            DataTable dt = new DataTable();
            dt = dal.SelectData("GetAllNormals", null);
            dal.close();
            return dt;
        }
    }
}
