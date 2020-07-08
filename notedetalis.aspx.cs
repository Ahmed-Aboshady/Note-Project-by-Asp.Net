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
    public partial class notedetalis : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            if (!Page.IsPostBack)
            {
                for (int i = 1; i <= 30; i++)
                {
                    DropDownList1.Items.Add($"{i}");
                    if (i <= 12)
                    {
                        DropDownList2.Items.Add($"{i}");
                    }
                }
                for (int j = 1990; j <= 2020; j++)
                {
                    DropDownList3.Items.Add($"{j}");
                }
            }
           
                if (!IsPostBack)
                {
                    SqlCommand cmd = new SqlCommand("select * from catalogs");
                    DataTable dt = dblayer.select(cmd);
                    ddl_cat.DataSource = dt;
                    ddl_cat.DataTextField = "name";
                    ddl_cat.DataValueField = "id";
                    ddl_cat.DataBind();
            }
            if (!IsPostBack)
            {
                //ddl_user
                SqlCommand cmd = new SqlCommand("select * from writer");
                DataTable dt = dblayer.select(cmd);
                ddl_user.DataSource = dt;
                ddl_user.DataTextField = "name";
                ddl_user.DataValueField = "id";
                ddl_user.DataBind();
            }

        }

        protected void btn_register_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                // SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["iticon"].ConnectionString);
SqlCommand cmd = new SqlCommand("insert into note(title,bref,describe,datatime,cid,userid) values(@name,@bref,@desc,@year,@cid,@userid)");
                cmd.Parameters.AddWithValue("name", txt_name.Text);
                cmd.Parameters.AddWithValue("bref", txt_bref.Text);
                cmd.Parameters.AddWithValue("desc", txt_descibe.Text);
               // cmd.Parameters.AddWithValue("day", DropDownList1.SelectedValue);
               // cmd.Parameters.AddWithValue("month", DropDownList2.SelectedValue);
                cmd.Parameters.AddWithValue("year", DropDownList3.SelectedValue);
                cmd.Parameters.AddWithValue("cid", ddl_cat.SelectedValue);
                cmd.Parameters.AddWithValue("userid", ddl_user.SelectedValue);
                int rowseffect = dblayer.DML(cmd);
                if (rowseffect > 0)
                {
                    Response.Redirect("~/allnote.aspx");

                }
            }
        }
    }
}