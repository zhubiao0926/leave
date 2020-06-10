<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="allow.aspx.cs" Inherits="XMIS_Demo1.StudentList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="css/commonTable.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style1 {
            height: 30px;
        }
    </style>
    </head>
<body>
    <form id="form1" runat="server">
    <div class="mainPanel" style="width:50%;">
       <table>
           <tr>
               <th style="width:2%">学号</th>
               <th style="width:4%">姓名</th>
               <th style="width:4%">教师</th>
               <th style="width:4%">事由</th>
               <th style="width:4%">电话</th>
               <th style="width:4%">创建时间</th>
               <th style="width:4%">请假时长</th>
               <th style="width:4%">操作</th>
               <th style="width:4%">操作</th>
           </tr>
           <asp:Repeater ID="repList" runat="server">
               <ItemTemplate>
                   <tr>
                       <td><%#Eval("STUDENT_NO")%></td>
                        <td><%#Eval("STUDENT_NAME")%></td>
                        <td><%#Eval("TEACHER")%></td>
                        <td><%#Eval("STUDENT_REA")%></td>
                        <td><%#Eval("STUDENT_PHONE")%></td>
                        <td><%#Eval("CREATETIME")%></td>
                       <td><%#Eval("LENGTH")%></td>
                        <td>
                            
                            <asp:LinkButton ID="lkVerify" runat="server" CommandArgument='<%#Eval("STUDENT_NO")+","+Eval("CREATETIME")%>' OnClientClick="return confirm('是否批准？')" OnClick="lkDel_Click">批准</asp:LinkButton>
                        </td>
                       <td>
                            
                            <asp:LinkButton ID="LinkButton1" runat="server" CommandArgument='<%#Eval("STUDENT_NO")+","+Eval("CREATETIME")%>' OnClientClick="return confirm('是否不批准？')" OnClick="LinkButton1_Click">不批准</asp:LinkButton>
                        </td>
                        
                   </tr>
               </ItemTemplate>

           </asp:Repeater>



       </table>
    </div>
    </form>
</body>
</html>
