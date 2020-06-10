<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="pro.aspx.cs" Inherits="XMIS_Demo1.pro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form2" runat="server">
        <div class="mainPanel" style="width:50%;">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextBox1" runat="server" Height="16px" Width="136px"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="查询学号" class="btn2" OnClick="Button1_Click" />
       <table>
           <tr>
               <th style="width:2%">学号</th>
               <th style="width:4%">姓名</th>
                <th style="width:4%">教师</th>
               <th style="width:4%">事由</th>
               <th style="width:4%">电话</th>
               <th style="width:4%">创建时间</th>
               <th style="width:4%">请假时长</th>
               
           </tr>
           <asp:Repeater ID="prolist" runat="server">
               <ItemTemplate>
                   <tr>
                       <td><%#Eval("STUDENT_NO")%></td>
                        <td><%#Eval("STUDENT_NAME")%></td>
                       <td><%#Eval("TEACHER")%></td>
                        <td><%#Eval("STUDENT_REA")%></td>
                        <td><%#Eval("STUDENT_PHONE")%></td>
                        <td><%#Eval("CREATETIME")%></td>
                        <td><%#Eval("LENGTH")%></td>
                        
                        
                   </tr>
               </ItemTemplate>

           </asp:Repeater>



       </table>
    </div>
    </form>
</body>
</html>
