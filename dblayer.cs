using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Note_Project
{
    public class dblayer
    {
        public static DataTable select(SqlCommand cmd)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["notecon"].ConnectionString);
            cmd.Connection = con;
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
        }


        public static int DML(SqlCommand cmd)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["notecon"].ConnectionString);
            cmd.Connection = con;
            con.Open();
            int roweffect = cmd.ExecuteNonQuery();
            con.Close();
            return roweffect;
        }

    }
}