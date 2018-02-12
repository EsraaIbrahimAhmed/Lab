using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Lab.BL
{
    class CLS_PATIENT
    {
//*************************البحث  ******************************
        public DataTable SEARCH_PATIENT(string name)
        {
            DAL.DBL dal = new DAL.DBL();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@name", SqlDbType.NVarChar, 100);
            param[0].Value = name;
            dt = dal.SelectData("SearchPatient", param);
            dal.close();
            return dt;
        }

//***************************************اضافة******************************
        public void Add_patient(string pat_name, int pat_age,string unit, string pat_gender, string pat_stu, string pat_email,
            string pat_address, string pat_phone,string con_name)
        {
            DAL.DBL dal = new DAL.DBL();
            dal.open();
            SqlParameter[] param = new SqlParameter[9];

            param[0] = new SqlParameter("@pat_name", SqlDbType.NVarChar, 100);
            param[0].Value = pat_name;

            param[1] = new SqlParameter("@pat_age", SqlDbType.NVarChar, 100);
            param[1].Value = pat_age;

            param[2] = new SqlParameter("@unit", SqlDbType.NVarChar, 50);
            param[2].Value = unit;


            param[3] = new SqlParameter("@pat_gender", SqlDbType.VarChar, 100);
            param[3].Value = pat_gender;

            param[4] = new SqlParameter("@pat_stu", SqlDbType.VarChar, 100);
            param[4].Value = @pat_stu;

            param[5] = new SqlParameter("@pat_email", SqlDbType.VarChar, 100);
            param[5].Value = pat_email;

            param[6] = new SqlParameter("@pat_address", SqlDbType.VarChar, 100);
            param[6].Value = pat_address;

            param[7] = new SqlParameter("@pat_phone", SqlDbType.VarChar, 100);
            param[7].Value = pat_phone;

            param[8] = new SqlParameter("@con_name", SqlDbType.NVarChar,100);
            param[8].Value = con_name;

            dal.executeCommand("Add_patient", param);
            dal.close();

        }

//***********************************تعديل *********************************
        public void edit_patient(string pat_name, string pat_phone, string pat_address,int pat_age,string unit,string pat_emile, int id)
        {
            DAL.DBL dal = new DAL.DBL();
            dal.open();
            SqlParameter[] param = new SqlParameter[7];

            param[0] = new SqlParameter("@name", SqlDbType.NVarChar, 100);
            param[0].Value = pat_name;

            param[1] = new SqlParameter("@phone", SqlDbType.NVarChar, 100);
            param[1].Value = pat_phone;

            param[2] = new SqlParameter("@address", SqlDbType.NVarChar, 100);
            param[2].Value = pat_address;

            param[3] = new SqlParameter("@age", SqlDbType.Int);
            param[3].Value = pat_age;

            param[4] = new SqlParameter("@unit", SqlDbType.NVarChar, 50);
            param[4].Value = unit;

            param[5] = new SqlParameter("@email", SqlDbType.NVarChar, 100);
            param[5].Value = pat_emile;

            param[6] = new SqlParameter("@id", SqlDbType.Int, 100);
            param[6].Value = id;

            dal.executeCommand("edit_patient", param);
            dal.close();

        }



//********************عرض***********************
        public DataTable GET_ALL_PATIENT()
        {
            DAL.DBL dal = new DAL.DBL();
            DataTable dt = new DataTable();
            dt = dal.SelectData("GetAllPatients1", null);
            dal.close();
            return dt;
        }


//***********************الحذف***********************************
        public void delete_patient(int id)
        {
            DAL.DBL dal = new DAL.DBL();
            dal.open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.Int, 100);
            param[0].Value = id;


            dal.executeCommand("delete_patient", param);
            dal.close();

        }


        public DataTable GET_ALL_PATIENT5()
        {
            DAL.DBL dal = new DAL.DBL();
            DataTable dt = new DataTable();
            dt = dal.SelectData("Get_all_patient5", null);
            dal.close();
            return dt;
        }

       
    }
}
