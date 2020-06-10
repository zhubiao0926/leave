using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;

namespace XMIS_Demo1
{
    public partial class StudentManager : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Labelsname.Text = Session["name"].ToString();

            string strConn = "server=.;database=JWGL;uid=sa;pwd=123456";
            SqlConnection conn = new SqlConnection(strConn);

            string strCmd = "select * from userslogin where username='" + Labelsname.Text + "'";
            SqlCommand cmd = new SqlCommand(strCmd, conn);

            conn.Open();

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                Labelno.Text = dr["id"].ToString();
                Labeltname.Text = dr["teacher"].ToString();
            }

            dr.Close();
            conn.Close();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            sqlHelper sh= new sqlHelper();

            string sno = Labelno.Text.Trim();
            string sname = Labelsname.Text.Trim();
            string teacher = Labeltname.Text.Trim();
            string stuRea = txtRea.Text.Trim();
            string stuPhone = txtPhone.Text.Trim();
            string Length = txtLength.Text.Trim();

            //string stuSex

            
            if(stuRea.Equals(""))
            {
                Tool.Alert("理由不能为空", Page);
            }
            else if(stuPhone.Equals(""))
            {
                Tool.Alert("电话号码不能为空", Page);
            }
            else if (Length.Equals(""))
            {
                Tool.Alert("请假天数不能为空", Page);
            }
            else
            {
                string sqlAddAPPLY= "insert into STUDENTAPPLY(STUDENT_NO,STUDENT_NAME,TEACHER,STUDENT_REA,STUDENT_PHONE,CREATETIME,LENGTH,FLAG) values('" +
                     sno + "','" + sname + "','"+teacher+"','" + stuRea + "','" + stuPhone +"','"+ DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','"+Length+"','"+1+"')";

                if(sh.excuteNonQuery(sqlAddAPPLY))
                {
                    Tool.Alert("申请成功，请等待回复！", Page);
                    Labelno.Text = "";
                    Labelsname.Text = "";
                    Labeltname.Text = "";
                    txtRea.Text = "";
                    txtPhone.Text = "";
                    txtLength.Text = "";
                }
                else
                {
                    Tool.Alert("申请失败，请重试！", Page);
                }
            }

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}