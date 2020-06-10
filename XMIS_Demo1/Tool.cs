using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Security;
using System.Web.UI;

/// <summary>
/// Tool 的摘要说明
/// </summary>
public class Tool
{
    public Tool()
    {
        //
        // TODO: 在此处添加构造函数逻辑
        //
    }
    
    /// <summary>后台执行alert弹出对话框
    /// 
    /// </summary>
    /// <param name="_Msg">警告字串</param>
    /// <param name="_Page">this.Page</param>
    /// <returns>警告框JS</returns>
    public static void Alert(string _Msg, Page _Page)
    {
        string StrScript;
        StrScript = ("<script>");
        StrScript += ("alert('" + _Msg + "');");
        StrScript += ("</script>");
        _Page.ClientScript.RegisterStartupScript(_Page.GetType(), "MsgBox", StrScript);
    }
    /// <summary>后台执行alert后跳转到新页面
    /// 
    /// </summary>
    /// <param name="_msg">提示框中的字符串</param>
    /// <param name="_href">跳转的页面</param>
    /// <param name="_page">this.Page</param>
    public static void AlertAndGo(string _msg, string _href, Page _page)
    {
        _page.ClientScript.RegisterStartupScript(_page.GetType(), "", "<script>alert('" + _msg + "');window.location.href ='" + _href + "';</script>");
    }

    /// <summary>后台执行JS
    /// 
    /// </summary>
    /// <param name="js">JS代码</param>
    /// <param name="_Page">this.Page</param>
    public static void ExecJS(string js, Page _Page)
    {
        string StrScript;
        StrScript = ("<script language='javascript' type='text/javascript'>");
        StrScript += js;
        StrScript += ("</script>");
        _Page.ClientScript.RegisterStartupScript(_Page.GetType(), "ExecJS", StrScript);
    }

    /// <summary>过滤SQL非法字符串
    /// 
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public static string GetSafeSQL(string value)
    {
        if (string.IsNullOrEmpty(value))
            return string.Empty;
        value = Regex.Replace(value, @";", string.Empty);
        value = Regex.Replace(value, @"'", string.Empty);
        value = Regex.Replace(value, @"&", string.Empty);
        value = Regex.Replace(value, @"%20", string.Empty);
        value = Regex.Replace(value, @"--", string.Empty);
        value = Regex.Replace(value, @"==", string.Empty);
        value = Regex.Replace(value, @"<", string.Empty);
        value = Regex.Replace(value, @">", string.Empty);
        value = Regex.Replace(value, @"%", string.Empty);
        return value;
    }

    ///将指定字符串按指定长度进行剪切， 
    ///</summary> 
    ///<param name= "oldStr">需要截断的字符串 </param> 
    ///<param name= "maxLength">字符串的最大长度 </param> 
    ///<param name= "endWith">超过长度的后缀 </param> 
    ///<returns>如果超过长度，返回截断后的新字符串加上后缀，否则，返回原字符串</returns> 
    public static string StringTruncat(string oldStr, int maxLength, string endWith)
    {
        if (string.IsNullOrEmpty(oldStr))
            //throw new NullReferenceException( "原字符串不能为空 "); 
            return oldStr + endWith;
        if (maxLength < 1)
            throw new Exception("返回的字符串长度必须大于[0] ");
        if (oldStr.Length > maxLength)
        {
            string strTmp = oldStr.Substring(0, maxLength);
            if (string.IsNullOrEmpty(endWith))
                return strTmp;
            else
                return strTmp + endWith;
        }
        return oldStr;
    }

    /// <summary>MD5加密字符串
    /// 
    /// </summary>
    /// <param name="str">原字符串</param>
    /// <returns></returns>
    public static string MD5(string str)
    {
        string Password = FormsAuthentication.HashPasswordForStoringInConfigFile(str, "MD5");
        return Password;
    }

    /// <summary>发送email,默认是25端口
    /// 
    /// </summary>
    /// <param name="title">邮件标题</param>
    /// <param name="body">邮件内容</param>
    /// <param name="toAdress">收件人</param>
    /// <param name="fromAdress">发件人</param>
    /// <param name="userName">发件用户名</param>
    /// <param name="userPwd">发件密码</param>
    /// <param name="smtpHost">smtp地址</param>
    public static void SendMail(string title, string body, string toAdress, string fromAdress,
                          string userName, string userPwd, string smtpHost)
    {
        try
        {
            MailAddress to = new MailAddress(toAdress);
            MailAddress from = new MailAddress(fromAdress);
            System.Net.Mail.MailMessage message = new System.Net.Mail.MailMessage(from, to);
            message.IsBodyHtml = true; // 如果不加上这句那发送的邮件内容中有HTML会原样输出 
            message.Subject = title; message.Body = body;
            SmtpClient smtp = new SmtpClient();
            smtp.UseDefaultCredentials = true;
            smtp.Port = 25;
            smtp.Credentials = new NetworkCredential(userName, userPwd);
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Host = smtpHost;
            message.To.Add(toAdress);
            smtp.Send(message);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }


    /// <summary>获得当前绝对路径
    /// 
    /// </summary>
    /// <param name="strPath">指定的路径</param>
    /// <returns>绝对路径</returns>
    public static string GetMapPath(string strPath)
    {
        if (HttpContext.Current != null)
        {
            return HttpContext.Current.Server.MapPath(strPath);
        }
        else //非web程序引用
        {
            strPath = strPath.Replace("/", "\\");
            if (strPath.StartsWith("\\"))
            {
                strPath = strPath.Substring(strPath.IndexOf('\\', 1)).TrimStart('\\');
            }
            return System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, strPath);
        }
    }

    /// <summary>返回文件是否存在
    /// 
    /// </summary>
    /// <param name="filename">文件名</param>
    /// <returns>是否存在</returns>
    public static bool FileExists(string filename)
    {
        return System.IO.File.Exists(filename);
    }
}