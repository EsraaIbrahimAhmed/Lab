using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Lab.BL
{
    class Cls_Workers
    {
        public DataTable Get_All_USER()
        {
            DAL.DBL dl=new DAL.DBL();
            DataTable dt = new DataTable();
            dt = dl.SelectData("SelectUser",null);
            dl.close();
            return dt;
        }

        //  ADD USER
        public void Add_User(string name, string password, string address, int phone, int idnumber,DateTime birth,
         string email,string job,string wages,string notes)
        {
            DAL.DBL dal = new DAL.DBL();
            dal.open();
            SqlParameter[] param = new SqlParameter[10];
            param[0] = new SqlParameter("@UserName", SqlDbType.NVarChar, 100);
            param[0].Value = name;

            param[1] = new SqlParameter("@Password", SqlDbType.NVarChar, 100);
            param[1].Value = password;

            param[2] = new SqlParameter("@UserAddress", SqlDbType.NVarChar, 100);
            param[2].Value = address;

            param[3] = new SqlParameter("@UserPhone", SqlDbType.Int, 50);
            param[3].Value = phone;

            param[4] = new SqlParameter("@IdNumber", SqlDbType.Int, 100);
            param[4].Value = idnumber;

            param[5] = new SqlParameter("@DateOfBirth", SqlDbType.Date, 100);
            param[5].Value = birth;

            param[6] = new SqlParameter("@UserEmail",SqlDbType.NVarChar, 100);
            param[6].Value = email;

            param[7] = new SqlParameter("@Job", SqlDbType.NVarChar, 100);
            param[7].Value = job;

            param[8] = new SqlParameter("@WorkerWages", SqlDbType.Int, 50);
            param[8].Value = wages;

            param[9] = new SqlParameter("@notes", SqlDbType.NVarChar, 100);
            param[9].Value = notes;
               
            dal.executeCommand("AddUser",param);
            dal.close();
        }

        // UPDATE USER
      public void UpDate_User(int id,string name, string password, string address, int phone, int idnumber,DateTime birth,
         string email,string job,int wages,string notes)
        {
            DAL.DBL dal = new DAL.DBL();
            dal.open();
            SqlParameter[] param = new SqlParameter[11];
            param[0] = new SqlParameter("@UserId", SqlDbType.NVarChar, 100);
            param[0].Value = id;

            param[1] = new SqlParameter("@UserName", SqlDbType.NVarChar, 100);
            param[1].Value = name;

            param[2] = new SqlParameter("@Password", SqlDbType.NVarChar, 100);
            param[2].Value = password;

            param[3] = new SqlParameter("@UserAddress", SqlDbType.NVarChar, 100);
            param[3].Value = address;

            param[4] = new SqlParameter("@UserPhone", SqlDbType.NVarChar, 50);
            param[4].Value = phone;

            param[5] = new SqlParameter("@IdNumber", SqlDbType.NVarChar, 100);
            param[5].Value = idnumber;

             param[6] = new SqlParameter("@DateOfBirth", SqlDbType.NVarChar, 100);
            param[6].Value = birth;

            param[7] = new SqlParameter("@UserEmai",SqlDbType.NVarChar, 100);
            param[7].Value = email;

            param[8] = new SqlParameter("@Job", SqlDbType.NVarChar, 100);
            param[8].Value = job;

            param[9] = new SqlParameter("@WorkerWages", SqlDbType.Int, 50);
            param[9].Value = wages;

            param[10] = new SqlParameter("@notes", SqlDbType.NVarChar, 100);
            param[10].Value = notes;
            
            dal.executeCommand("UpDateSupp", param);
            dal.close();
        }

        //  DELETE USER
      public void Delete_User(int id)
      {

          DAL.DBL dal = new DAL.DBL();
          dal.open();
          SqlParameter[] param = new SqlParameter[1];
          param[0] = new SqlParameter("@UserId", SqlDbType.Int);
          param[0].Value = id;
          dal.executeCommand("DeleteUser", param);
          dal.close();
      }
       
    }
}