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
    public partial class allnote : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                SqlCommand cmd = new SqlCommand("select * from catalogs");
                DataTable dt = dblayer.select(cmd);
                ddl_cat.DataSource = dt;
                ddl_cat.DataTextField = "name";
                ddl_cat.DataValueField = "id";
                ddl_cat.DataBind();
                ddl_cat_SelectedIndexChanged(null, null);
            }

        }
        protected void ddl_cat_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["notecon"].ConnectionString);
            SqlCommand cmd = new SqlCommand("select n.title,n.bref,n.describe,n.datatime,c.name,w.name  from catalogs c  inner join note n on c.id=n.cid and c.id=@id inner join writer w on w.id=n.userid order by n.datatime", con);
            cmd.Parameters.AddWithValue("id", ddl_cat.SelectedValue);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            gv_note.DataSource = dr;
            gv_note.DataBind();
            con.Close();
        }
        protected void ddl_note_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }

        protected void gv_note_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       
    }
}