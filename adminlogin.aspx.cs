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
    public partial class adminlogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_login_Click(object sender, EventArgs e)
        {
           if (txt_name.Text == "admin" && txt_pass.Text == "123")
            {
                Response.Redirect("~/admin.aspx");

            }
            else
            {
                lbl_status.Text = "invalid username or password";
            }
        }
    }
}
    