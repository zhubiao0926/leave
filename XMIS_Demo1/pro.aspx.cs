using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace XMIS_Demo1
{
    public partial class pro : System.Web.UI.Page
    {
        sqlHelper pr = new sqlHelper();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                BindRepList();
            }
        }

        private void BindRepList()
        {
            string sql = "Select STUDENT_NO,STUDENT_NAME,TEACHER,STUDENT_REA,STUDENT_PHONE,CREATETIME,LENGTH FROM STUDENTAPPLY WHERE FLAG=2 and TEACHER='" + Session["name"] + "'";

            prolist.DataSource = pr.GetList(sql);
            prolist.DataBind();
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            sqlHelper sh = new sqlHelper();

            string sql = "select STUDENT_NO,STUDENT_NAME,TEACHER,STUDENT_REA,STUDENT_PHONE,CREATETIME,LENGTH from STUDENTAPPLY where FLAG=2 and STUDENT_NO='" + TextBox1.Text + "'and TEACHER='" + Session["name"] + "'";
            prolist.DataSource = pr.GetList(sql);
            prolist.DataBind();

        }
       }
}