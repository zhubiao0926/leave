<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentEdit.aspx.cs" Inherits="XMIS_Demo1.StudentEdit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
   <form id="form1" runat="server">
        <div>
            <div class="mainPanel">
                <p style="border-bottom: 1px dotted #ccc;">基本信息</p>
                <p><span style="margin-right: 15px;">学号：<asp:TextBox ID="txtStuno" CssClass="txt" runat="server"></asp:TextBox></span>
                    学生姓名：<asp:TextBox ID="txtName" CssClass="txt" runat="server"></asp:TextBox></p>
                <p>性别<span style="margin-right: 15px;">：<asp:TextBox ID="txtSex" CssClass="txt" runat="server"></asp:TextBox></span>联系电话：<asp:TextBox ID="txtPhone" CssClass="txt" runat="server" MaxLength="11"></asp:TextBox>
                </p>
 
                <p style="width: 770px; text-align:left;">
                    <asp:Button ID="btnUpdate" runat="server" Text="修改信息" CssClass="btnSub" OnClick="btnUpdate_Click"  />
                </p>
                <br />
                <br />
                <br />
    
            </div>
        </div>
    </form>
</body>
</html>
