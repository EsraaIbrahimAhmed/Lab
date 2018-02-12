using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Lab.BL
{
    class CLS_CONTRACT
    {


        //For all contractors:
        //***************************************اضافة*****************************
        public void Add_CONTRACT(string con_name, string con_specialization, string con_add, string con_phone, string con_mail, string con_dis, int sign)
        {
            DAL.DBL dal = new DAL.DBL();
            dal.open();
            SqlParameter[] param = new SqlParameter[7];

            param[0] = new SqlParameter("@contractor_name", SqlDbType.NVarChar, 100);
            param[0].Value = con_name;

            param[1] = new SqlParameter("@con_specialization", SqlDbType.NVarChar, 100);
            param[1].Value = con_specialization;

            param[2] = new SqlParameter("@contractor_address", SqlDbType.NVarChar, 100);
            param[2].Value = con_add;

            param[3] = new SqlParameter("@contractor_phone", SqlDbType.VarChar, 50);
            param[3].Value = con_phone;

            param[4] = new SqlParameter("@contractor_email", SqlDbType.VarChar, 50);
            param[4].Value = con_mail;

            param[5] = new SqlParameter("@con_discount", SqlDbType.VarChar, 50);
            param[5].Value = con_dis;

            param[6] = new SqlParameter("@sign", SqlDbType.Int);
            param[6].Value = sign;

            dal.executeCommand("Add_CONTRACT", param);
            dal.close();

        }

        //***********************************تعديل ********************************
        public void UpDate_CONTRACT(string con_name, string con_specialization, string con_add, string con_phone, string con_mail,
            string con_dis, int id)
        {
            DAL.DBL dal = new DAL.DBL();
            dal.open();
            SqlParameter[] param = new SqlParameter[7];

            param[0] = new SqlParameter("@contractor_name", SqlDbType.NVarChar, 100);
            param[0].Value = con_name;

            param[1] = new SqlParameter("@con_specialization", SqlDbType.NVarChar, 100);
            param[1].Value = con_specialization;

            param[2] = new SqlParameter("@contractor_address", SqlDbType.NVarChar, 100);
            param[2].Value = con_add;

            param[3] = new SqlParameter("@contractor_phone", SqlDbType.VarChar, 50);
            param[3].Value = con_phone;

            param[4] = new SqlParameter("@contractor_email", SqlDbType.NVarChar, 50);
            param[4].Value = con_mail;

            param[5] = new SqlParameter("@con_discount", SqlDbType.VarChar, 50);
            param[5].Value = con_dis;

            param[6] = new SqlParameter("@contractor_id", SqlDbType.Int);
            param[6].Value = id;

            dal.executeCommand("UpDate_CONTRACT", param);
            dal.close();

        }
        //***********************الحذف**********************************************
        public void delete_CONTRACT(int id)
        {
            DAL.DBL dal = new DAL.DBL();
            dal.open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.Int, 100);
            param[0].Value = id;


            dal.executeCommand("delete_contract", param);
            dal.close();

        }

        //********************عرض كل التعاقدات ***********************************
        public DataTable GET_ALL_CONTRACT()
        {
            DAL.DBL dal = new DAL.DBL();
            DataTable dt = new DataTable();
            dt = dal.SelectData("GetContractors", null);
            dal.close();
            return dt;
        }
        //**********************************************************************************************
        //For company:

        //***********************عرض كل الشركات **********************************
        public DataTable Get_All_Company(int sign)
        {
            DAL.DBL dal = new DAL.DBL();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@sign", SqlDbType.Int);
            param[0].Value = sign;
            dt = dal.SelectData("GetAllCompany", param);
            dal.close();
            return dt;
        }


        //***************************البحث باسم الشركة  **************************
        public DataTable SearchCompanyByName(string name, int sign)
        {
            DAL.DBL dal = new DAL.DBL();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@name", SqlDbType.NVarChar, 100);
            param[0].Value = name;

            param[1] = new SqlParameter("@sign", SqlDbType.Int);
            param[1].Value = sign;

            dt = dal.SelectData("SearchCompanyByName", param);
            dal.close();
            return dt;
        }


        //For Doctor:

        //************************عرض كل الاطباء***********************************
        public DataTable Get_All_Doctors(int sign)
        {
            DAL.DBL dal = new DAL.DBL();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@sign", SqlDbType.Int);
            param[0].Value = @sign;
            dt = dal.SelectData("GET_ALL_doc", param);
            dal.close();
            return dt;
        }

        //************************البحث باسم الطبيب ********************************
        public DataTable SearchDoctorByName(string name, int sign)
        {
            DAL.DBL dal = new DAL.DBL();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@Dname", SqlDbType.NVarChar, 100);
            param[0].Value = name;

            param[1] = new SqlParameter("@sign", SqlDbType.Int);
            param[1].Value = sign;

            dt = dal.SelectData("SearchDoctorByName", param);
            dal.close();
            return dt;
        }

        //****************************البحث بتخصص الطبيب  **************************
        public DataTable SearchDoctorBySpecialization(string specialization, int sign)
        {
            DAL.DBL dal = new DAL.DBL();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@Dspecialization", SqlDbType.NVarChar, 100);
            param[0].Value = specialization;

            param[1] = new SqlParameter("@sign", SqlDbType.Int);
            param[1].Value = sign;

            dt = dal.SelectData("SearchDoctorBySpecialization", param);
            dal.close();
            return dt;
        }


        //****************************************************************************************
        //For Ex_Lab:
        //**********************عرض كل المعامل الخارجية *************************
        public DataTable Get_All_EXLab(int sign)
        {
            DAL.DBL dal = new DAL.DBL();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@sign", SqlDbType.Int);
            param[0].Value = sign;
            dt = dal.SelectData("GetAllLab", param);
            dal.close();
            return dt;
        }
        
        //********************البحث باسم المعمل ************************************
        public DataTable SearchExLabByName(string name ,int sgin)
        {
            DAL.DBL dal = new DAL.DBL();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@Exname", SqlDbType.NVarChar, 100);
            param[0].Value = name;

            param[1] = new SqlParameter("@sign", SqlDbType.Int);
            param[1].Value = sgin;

            dt = dal.SelectData("SearchExLabByName", param);
            dal.close();
            return dt;
        }
        ////////from patient_class
        //public DataTable GET_ALL_con()
        //{
        //    DAL.DBL dal = new DAL.DBL();
        //    DataTable dt = new DataTable();
        //    dt = dal.SelectData("GET_ALL_con", null);
        //    dal.close();
        //    return dt;
        //}

        //public DataTable GET_ALL_doc()
        //{
        //    DAL.DBL dal = new DAL.DBL();
        //    DataTable dt = new DataTable();
        //    dt = dal.SelectData("GET_ALL_doc", null);
        //    dal.close();
        //    return dt;
        //}


        //public DataTable get_doc_con2()
        //{
        //    DAL.DBL dal = new DAL.DBL();
        //    DataTable dt = new DataTable();
        //    dt = dal.SelectData("get_doc_con2", null);
        //    dal.close();
        //    return dt;
        //}
       
    }
}
