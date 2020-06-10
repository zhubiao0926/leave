using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace XMIS_Demo1
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if(!IsPostBack)
            {
                if (Session["name"] == null)
                {
                    Response.Redirect("Login.aspx");
                }
                else
                {
                    lblDisplayName.Text = Session["name"].ToString();
                    if(Session["type"].ToString()=="admin")
                    {
                        panelAdmin.Visible = true;

                    }
                    else if(Session["type"].ToString()=="student")
                    {
                        panelStudent.Visible = true;

                    }
                    else if (Session["type"].ToString() == "teacher")
                    {
                        panelTeacher.Visible = true;

                    }

                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("login.aspx");
        }
        protected void Button2_Click(object sender, EventArgs e)
        {

                Session.Abandon();
                Response.Redirect("password.aspx");
            }
            
            
            
        
    }
}