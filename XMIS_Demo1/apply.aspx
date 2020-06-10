<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="apply.aspx.cs" Inherits="XMIS_Demo1.StudentManager" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .txt {}
    </style>
</head>
<body>
   <form id="form1" runat="server">
        <div>
            <div class="mainPanel">
                <p style="border-bottom: 1px dotted #ccc;">基本信息&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </p>
                <p><span style="margin-right: 15px;">学号：</span><asp:Label ID="Labelno" runat="server" Text="Label"></asp:Label>
&nbsp;学生姓名：<asp:Label ID="Labelsname" runat="server" Text="Label"></asp:Label>
&nbsp;教师：<asp:Label ID="Labeltname" runat="server" Text="Label"></asp:Label>
                </p>
                <p>事由<span style="margin-right: 15px;">：<asp:TextBox ID="txtRea" CssClass="txt" runat="server" Height="68px" Width="491px"></asp:TextBox></span>联系电话：<asp:TextBox ID="txtPhone" CssClass="txt" runat="server" MaxLength="11"></asp:TextBox>
               请假时长：<asp:TextBox ID="txtLength" CssClass="txt" runat="server" OnTextChanged="TextBox1_TextChanged" Width="30px"></asp:TextBox>天</p> 
 
                <p style="width: 770px; text-align: right;">
                    <asp:Button ID="btnAdd" runat="server" Text="申请" CssClass="btnSub" OnClick="btnAdd_Click"/>
                </p>
                <br />
                <br />
                <br />
    
            </div>
        </div>
    </form>
</body>
</html>
