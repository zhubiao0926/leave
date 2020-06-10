using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace XMIS_Demo1
{
    public partial class StudentList : System.Web.UI.Page
    {
        sqlHelper sh = new sqlHelper();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindRepList();
            }
        }

        private void BindRepList()
        {

            string sql = "Select STUDENT_NO,STUDENT_NAME,TEACHER,STUDENT_REA,STUDENT_PHONE,CREATETIME,LENGTH FROM STUDENTAPPLY WHERE FLAG=1 and TEACHER ='" + Session["name"] + "'";

            repList.DataSource = sh.GetList(sql);
            repList.DataBind();
        }

        protected void lkDel_Click(object sender, EventArgs e)
        {
            LinkButton lbt = (LinkButton)sender;
            object[] arg = lbt.CommandArgument.ToString().Split(',');
            string arg0 = arg[0].ToString();
            string arg1 = arg[1].ToString();

            string sql = "UPDATE STUDENTAPPLY SET FLAG=2 WHERE STUDENT_NO='" + arg0 + "' and CREATETIME='" + arg1 + "' and FLAG=1";
            if (sh.excuteNonQuery(sql))
            {
                Tool.Alert("批准成功", Page);
                BindRepList();
            }
            else
            {
                Tool.Alert("批准成功", Page);

            }

        }
        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            LinkButton lbt = (LinkButton)sender;
            object[] arg = lbt.CommandArgument.ToString().Split(',');
            string arg0 = arg[0].ToString();
            string arg1 = arg[1].ToString();

            string sql = "UPDATE STUDENTAPPLY SET FLAG=0 WHERE STUDENT_NO='" + arg0 + "' and CREATETIME='" + arg1 + "'and FLAG=1";
            if (sh.excuteNonQuery(sql))
            {
                Tool.Alert("不批准成功", Page);
                BindRepList();
            }
            else
            {
                Tool.Alert("不批准成功", Page);

            }

        }
    }
}