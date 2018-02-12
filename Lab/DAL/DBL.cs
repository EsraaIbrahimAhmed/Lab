using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Lab.DAL
{
    class DBL
    {
        string sqlString = @"Server=(localdb)\v11.0;Database=ELab;Integrated Security=true";
        SqlConnection con;
        //constructor
        public DBL()
        {
            con = new SqlConnection(sqlString);
        }
        //method open connection
        public void open()
        {
            if (con.State != ConnectionState.Open)
            {
                //con.Open();

            }
        }
        //method close connection
        public void close()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }

        //method to read data from database
        public DataTable SelectData(string stored_procedure, SqlParameter[] param)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = stored_procedure;
            cmd.Connection = con;
            if (param != null)
            {
                for (int i = 0; i < param.Length; i++)
                {
                    cmd.Parameters.Add(param[i]);
                }
            }
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        //method to manipulate data in database
        public void executeCommand(string stored_procedure, SqlParameter[] param)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = stored_procedure;
            cmd.Connection = con;
            if (param != null)
            {
                cmd.Parameters.AddRange(param);
            }

            cmd.ExecuteNonQuery();
        }
    }
}
