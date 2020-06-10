<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="XMIS_Demo1.register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>登录</title>
    <link href="static/css/member/vip.css" rel="stylesheet" type="text/css" />
    <link href="static/css/member/skin_01.css" rel="stylesheet" type="text/css" id="skin" />
</head>
<body>

<div class="main">
  <div class="main_t"></div>
  <div class="main_m">
    <div class="main_bd">
      <div class="yskj step1">
        <div class="yskj_tt"><b>登录</b></div>
        <form runat="server">
          <input type="hidden" name="pid" value="10046">
          <input type="hidden" name="parentid" value="">
          <div class="yskj_bd">
            <ul class="ul">
              <li>
                <label>账户：</label>
                <asp:TextBox ID="txtUsername" runat="server" class="txt1 txt"></asp:TextBox>
              </li>
              <li>
                <label>密码：</label>
                <asp:TextBox ID="txtPassword" runat="server" class="txt1 txt" ></asp:TextBox>
              </li>

            </ul>
            <div class="reg">
                <asp:Button ID="btnLogin" runat="server" Text="登录" class="btn2" OnClick="btnLogin_Click" />
            <!--<div class="other_login" style="margin-left:140px;"> 其他账号登陆： <a href="api/oauth.php?action=geturl"><img src="static/css/member/images/login/qq_big.png" height="16"></a> </div>-->
          </div>
        </form>
      </div>
      <div class="main_bg opcity"></div>
    </div>
  </div>
  <div class="main_b"></div>
</div>

</body>
</html>
