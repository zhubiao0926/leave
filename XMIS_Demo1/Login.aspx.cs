using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace XMIS_Demo1
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            sqlHelper sh = new sqlHelper();

            string strCmd = "select * from userslogin where username='" + txtUsername.Text +
                "' and password='" + txtPassword.Text + "'";

            bool flag = sh.excuteReader(strCmd);

            if (flag)
            {
                //使用数据访问类中的GetList方法获取数据表，并返回给dt对象
                DataTable dt = sh.GetList(strCmd).Tables[0];
                //Session对象保存用户登录名、用户类型
                Session["name"] = dt.Rows[0]["username"];
                Session["type"] = dt.Rows[0]["type"];
                Response.Redirect("default.aspx");
            }
            else
            {
                Response.Write("<script>alert('用户名或密码错误！')</script>");
            }
        }


    }
}