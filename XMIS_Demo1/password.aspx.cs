using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;



namespace XMIS_Demo1
{
    public partial class password : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("login.aspx");
        }
       
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            sqlHelper sh = new sqlHelper();

            string strCmd = "select * from userslogin where username='" + txtUsername.Text +
                "' and password='" + txtPassword.Text + "'";
            bool flag = sh.excuteReader(strCmd);

            if (flag)
            {
                DataTable dt = sh.GetList(strCmd).Tables[0];
                if (txtPassword1.Text != "" && txtPassword1.Text != "")
                {
                    if (int.Parse(txtPassword1.Text) == int.Parse(txtPassword.Text))
                    {
                        Response.Write("<script>alert('和原密码相同，修改失败！')</script>");
                    }
                    else if (int.Parse(txtPassword1.Text) != int.Parse(txtPassword2.Text))
                    {
                        Response.Write("<script>alert('密码不一致!')</script>");
                    }
                    else
                    {
                        string sql = "update userslogin set password='" + txtPassword1.Text + "'where username ='" + txtUsername.Text.Trim() + "'";
                        if (sh.excuteNonQuery(sql))
                        {
                            Response.Write("<script>alert('修改成功');window.location='login.aspx';</script>");

                        }
                    }
                }
                else
                {
                    Response.Write("<script>alert('修改值不能为空!')</script>");
                }
                
            }
            else
            {
                Response.Write("<script>alert('用户名或密码错误！')</script>");
            }
        }

    }
}