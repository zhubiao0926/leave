using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace XMIS_Demo1
{
    public partial class StudentEdit : System.Web.UI.Page
    {
        sqlHelper sh = new sqlHelper();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                //修改学生信息前，先根据传过来的学生ID加载学生信息
                int STUDENT_ID;
                if(int.TryParse(Request.QueryString["stuId"],out STUDENT_ID))
                {
                    txtStuno.ReadOnly = true;
                    string sql = "Select STUDENT_ID,STUDENT_NO,STUDENT_NAME,STUDENT_SEX,STUDENT_PHONE,CREATETIME FROM T_STUDENT WHERE STUDENT_ID=" + STUDENT_ID;

                    DataTable dt = sh.GetList(sql).Tables[0];
                    txtStuno.Text = dt.Rows[0]["STUDENT_NO"].ToString();
                    txtName.Text = dt.Rows[0]["STUDENT_NAME"].ToString();
                    txtSex.Text = dt.Rows[0]["STUDENT_SEX"].ToString();
                    txtPhone.Text = dt.Rows[0]["STUDENT_PHONE"].ToString();
                    
                }
            }

        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            string sql = "update T_STUDENT SET STUDENT_NAME='" + txtName.Text + "','...";//没写完

            if(sh.excuteNonQuery(sql))
            {
                Tool.Alert("修改成功",Page); //没写完

            }
        }


    }
}