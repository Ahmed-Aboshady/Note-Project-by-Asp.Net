using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Note_Project
{
    public partial class admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lbl_vistors.Text = Application["count"].ToString();
            if (!IsPostBack)
            {
                gv_note.DataSource = BussLayer.getall();
                gv_note.DataBind();
            }
        }

        protected void gv_note_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = (int)gv_note.DataKeys[e.RowIndex].Value;
            BussLayer.delete(id);

            gv_note.DataSource = BussLayer.getall();
            gv_note.DataBind();
        }

        protected void gv_note_RowEditing(object sender, GridViewEditEventArgs e)
        {
              string catnName = ((Label)gv_note.Rows[e.NewEditIndex].FindControl("lbl_cat")).Text;
              string userName = ((Label)gv_note.Rows[e.NewEditIndex].FindControl("lbl_user")).Text;

              DataTable d = BussLayer.writerByName(userName);
              int iduser = (int)d.Rows[0]["id"];
              DataTable dt = BussLayer.getByName(catnName);
              int id = (int)dt.Rows[0]["id"];
          
            gv_note.EditIndex = e.NewEditIndex;
            gv_note.DataSource = BussLayer.getall();
            gv_note.DataBind();
            DropDownList ddl = (DropDownList)gv_note.Rows[e.NewEditIndex].FindControl("ddl_catname");
            DropDownList dduser = (DropDownList)gv_note.Rows[e.NewEditIndex].FindControl("ddl_username");
            ddl.DataSource = BussLayer.getallcat();
            ddl.DataTextField = "name";
            ddl.DataValueField = "cid";
            ddl.DataBind();
            ddl.SelectedValue = id.ToString();

            dduser.DataSource = BussLayer.getallwriter();
            dduser.DataTextField = "name";
            dduser.DataValueField = "userid";
            dduser.DataBind();
            dduser.SelectedValue = iduser.ToString();
        }
        protected void gv_note_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            string title = ((TextBox)gv_note.Rows[e.RowIndex].FindControl("title")).Text;
            string bref = ((TextBox)gv_note.Rows[e.RowIndex].FindControl("txt_bref")).Text;
            string desc = ((TextBox)gv_note.Rows[e.RowIndex].FindControl("txt_desc")).Text;
            string data = ((TextBox)gv_note.Rows[e.RowIndex].FindControl("txt_data")).Text;
            string cid = ((DropDownList)gv_note.Rows[e.RowIndex].FindControl("ddl_catname")).SelectedValue;
            string userid = ((DropDownList)gv_note.Rows[e.RowIndex].FindControl("ddl_username")).SelectedValue;
            int id = (int)gv_note.DataKeys[e.RowIndex].Value;
            BussLayer.edit(id, title, bref,desc,int.Parse(data), int.Parse(cid), int.Parse(userid));
            gv_note.EditIndex = -1;
            gv_note.DataSource = BussLayer.getall();
            gv_note.DataBind();
        }
        protected void gv_note_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gv_note.EditIndex = -1;
            gv_note.DataSource = BussLayer.getall();
            gv_note.DataBind();
        }
        protected void gv_note_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}