<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="XMIS_Demo1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>添加学生</title>
    <link href="../css/commonInput.css" rel="stylesheet" />

</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="mainPanel">
                <p style="border-bottom: 1px dotted #ccc;">基本信息</p>
                <p><span style="margin-right: 15px;">学号：<asp:TextBox ID="txtStuno" CssClass="txt" runat="server"></asp:TextBox></span>学生姓名：<asp:TextBox ID="txtName" CssClass="txt" runat="server"></asp:TextBox></p>
                <p><span style="margin-right: 15px;">密码：<asp:TextBox ID="txtPwd" CssClass="txt" TextMode="Password" runat="server"></asp:TextBox></span>确认密码：<asp:TextBox ID="txtPwd1" TextMode="Password" CssClass="txt" runat="server"></asp:TextBox></p>
                <p style="border-bottom: 1px dotted #ccc;">选填信息</p>
                <p style="width: 770px; text-align: right;">
                    <asp:Button ID="btnAdd" runat="server" Text="添加学生" CssClass="btnSub" OnClick="btnAdd_Click" />
                </p>
            </div>
        </div>
    </form>
</body>
</html>
