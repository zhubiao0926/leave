<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="XMIS_Demo1.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="UTF-8">请假信息后台管理</title>
    <link rel="stylesheet" type="text/css" href="css/common.css"/>
    <link rel="stylesheet" type="text/css" href="css/main.css"/>
    <script type="text/javascript"> 
<!--
    //cade by yuyou
    var getFFVersion = navigator.userAgent.substring(navigator.userAgent.indexOf("Firefox")).split("/")[1]
    //extra height in px to add to iframe in FireFox 1.0+ browsers 
    var FFextraHeight = getFFVersion >= 0.1 ? 16 : 0

    function dyniframesize(down) {
        var pTar = null;
        if (document.getElementById) {
            pTar = document.getElementById(down);
        }

        else {
            eval('pTar = ' + down + ';');
        }

        if (pTar && !window.opera) {
            //begin resizing iframe 
            pTar.style.display = "block"

            if (pTar.contentDocument && pTar.contentDocument.body.offsetHeight) {
                //ns6 syntax 
                pTar.height = pTar.contentDocument.body.offsetHeight + FFextraHeight;
            }

            else if (pTar.Document && pTar.Document.body.scrollHeight) {
                //ie5+ syntax 
                pTar.height = pTar.Document.body.scrollHeight;
            }

        }
    }
    </script>
</head>
<body>
    <form id="form1" runat="server">

<div class="topbar-wrap white">
    <div class="topbar-inner clearfix">
        <div class="topbar-logo-wrap clearfix">
            <h1 class="topbar-logo none"><a href="index.html" class="navbar-brand">后台管理</a></h1>
            <ul class="navbar-list clearfix">
            
              
            </ul>
        </div>
        <div class="top-info-wrap">
            <ul class="top-info-list clearfix">
                <li><a href="#">
                    <asp:Label ID="lblDisplayName" runat="server" Text="Label"></asp:Label>
                    </a></li>
                <li><a href="#">
                    <asp:Button ID="Button2" runat="server" Text="修改密码" class="btn btn-info" OnClick="Button2_Click" />
                    </a></li>
                <li>
                    <asp:Button ID="Button1" runat="server" Text="退出" class="btn btn-info" OnClick="Button1_Click"/></li>
            </ul>
        </div>
    </div>
</div>
<div class="container clearfix">
    <div class="sidebar-wrap">
        <div class="sidebar-title">
            <h1>菜单</h1>
        </div>
        <div class="sidebar-content">
    <asp:Panel ID="panelTeacher" runat="server" Visible="false">
                        <ul class="sidebar-list">
                            <li>
                                <a href="#"><i class="icon-font">&#xe003;</i>常用操作</a>
                                    <ul class="sub-menu">
                                  
                                    <li><a href="allow.aspx" target="main"><i class="icon-font">&#xe005;</i>学生请假管理</a></li>
                                        <li><a href="pro.aspx" target="main"><i class="icon-font">&#xe006;</i>已通过的申请</a></li>
                                        <li><a href="prof.aspx" target="main"><i class="icon-font">&#xe006;</i>未通过的申请</a></li>
                                  
                                </ul>
                            </li>
                        </ul>
                    </asp:Panel>
                    <asp:Panel ID="panelStudent" runat="server" Visible="false">
                        <ul class="sidebar-list">
                            <li>
                                <a href="#"><i class="icon-font">&#xe003;</i>常用操作</a>
                                <ul class="sub-menu">
                                    <li><a href="apply.aspx" target="main"><i class="icon-font">&#xe008;</i>请假申请</a></li>
                                    <li><a href="s.aspx" target="main"><i class="icon-font">&#xe006;</i>审核中的申请</a></li>
                                    <li><a href="spro.aspx" target="main"><i class="icon-font">&#xe006;</i>已通过的申请</a></li>
                                    <li><a href="sprof.aspx" target="main"><i class="icon-font">&#xe006;</i>未通过的申请</a></li>
                                </ul>
                            </li>
                        </ul>
                    </asp:Panel>
            <asp:Panel ID="panelAdmin" runat="server" Visible="false">
                        <ul class="sidebar-list">
                            <li>
                                <a href="#"><i class="icon-font">&#xe003;</i>常用操作</a>
                                <ul class="sub-menu">
                                    <li><a href="apro.aspx" target="main"><i class="icon-font">&#xe006;</i>已通过的申请</a></li>
                                </ul>
                            </li>
                        </ul>
                    </asp:Panel>
        </div>
    </div>
    <!--/sidebar-->
    <div class="main-wrap">
        <div class="crumb-wrap">
            <div class="crumb-list"><i class="icon-font">&#xe06b;</i><span>欢迎访问</span></div>
        </div>
        <div class="result-wrap">
        </div>
        <div class="result-wrap">
            <div class="result-title">
                <h1>系统基本信息</h1>
            </div>
            <div class="result-content">
            <iframe name="main" src="Welcome.aspx" style="width: 100%; height: 449px;" frameborder="no" border="0" marginwidth="0" marginheight="0" scrolling="no" id="down" onload="javascript:dyniframesize('down');"></iframe>
            </div>
        </div>
        <div class="result-wrap">
            <div class="result-title">
                <h1>使用帮助</h1>
            </div>
            <div class="result-content">
                <ul class="sys-info-list">
                    <li>
                    </li>
                </ul>
            </div>
        </div>
    </div>
    <!--/main-->
</div>


    </form>
</body>
</html>
