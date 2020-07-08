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
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void btn_login_Click(object sender, EventArgs e)
        {

        }

        protected void btn_register_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                
                SqlCommand cmd = new SqlCommand("insert into writer(name,age,password,email,gender) values(@name,@age,@pass,@email,@gender)");
                cmd.Parameters.AddWithValue("name", txt_name.Text);
                cmd.Parameters.AddWithValue("age", txt_age.Text);
                cmd.Parameters.AddWithValue("pass", txt_password.Text);
                cmd.Parameters.AddWithValue("gender", rbl_gender.SelectedValue);
                cmd.Parameters.AddWithValue("email", txt_email.Text);
                int rowseffect = dblayer.DML(cmd);
                if (rowseffect > 0)
                {
                    Response.Redirect("~/loginwriter.aspx");

                }
            }
        }
    }
}