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
    public partial class profilewriter : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /* SqlCommand cmd = new SqlCommand("select * from depts");
              DataTable dt = DBLayer.select(cmd);
              ddl_depts.DataSource = dt;
              ddl_depts.DataTextField = "name";
              ddl_depts.DataValueField = "deptId";
              ddl_depts.DataBind();*/
            //  SqlCommand cmd = new SqlCommand("insert into writer(name,age,password,email,gender) values(@name,@age,@pass,@email,@gender)");
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["notecon"].ConnectionString);
            SqlCommand cmd = new SqlCommand("select * from writer where id=@id", con);
            cmd.Parameters.AddWithValue("id", Session["userid"].ToString());
            con.Open();
            var dr = cmd.ExecuteReader();
            dr.Read();
            lbl_name.Text = dr["name"].ToString();
            lbl_age.Text = dr["age"].ToString();
            lbl_email.Text = dr["email"].ToString();
            lbl_gender.Text = dr["gender"].ToString();
            con.Close();
        }
        protected void btn_update_Click(object sender, EventArgs e)
        {  
            SqlCommand updatecmd = new SqlCommand("update writer set password=@pass where id=@id");
            BussLayer.editpass(int.Parse(Session["userid"].ToString()), int.Parse(txt_password.Text));
            Response.Redirect("~/loginwriter.aspx");
        }

        protected void btn_add_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/notedetalis.aspx");
        }
        protected void lbtn_logout_Click(object sender, EventArgs e)
        {

        }
    }
}