using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Note_Project
{
    public partial class loginwriter : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_login_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["notecon"].ConnectionString);
            SqlCommand cmd = new SqlCommand("select id from writer where name=@name and password=@password", con);
            cmd.Parameters.AddWithValue("name", txt_name.Text);
            cmd.Parameters.AddWithValue("password", txt_pass.Text);
            con.Open();
            var dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                Session.Add("userid", dr["id"]);
                if (chb_remeberme.Checked)
                {
                    HttpCookie cookie = new HttpCookie("userdata");
                    cookie.Values.Add("id", dr["id"].ToString());
                    
                    cookie.Expires = DateTime.Now.AddDays(15);
                    Response.Cookies.Add(cookie);
                }
                Response.Redirect("~/profilewriter.aspx");
            }
            
            else
            {
                lbl_status.Text = "invalid username or password";
            }

            con.Close();
        }
    }
}