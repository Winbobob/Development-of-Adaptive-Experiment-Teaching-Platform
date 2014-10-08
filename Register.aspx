<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Register" Title="注册页面" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>无标题页</title>
    <style type="text/css">
    #container
    { 
	background-position: center;
	background-image:url(images/Rigister.jpg);
	position: relative;
	width: 409px;
	height: 506px;
	z-index: 1;
	background-repeat: no-repeat;
	margin: 0 auto;
	margin-top: 26px;
    }	
    #content
    {
	position: absolute;
	width: 247px;
	height: 281px;
	left: 135px;
	top: 141px;
    }
    #submit
    {
	position: absolute;
	width: 174px;
	height: 38px;
	left: 492px;
	left: 180px;
	top: 435px;
    }
    .bottomtext
    {
    font-family: 微软雅黑;
    color: #525a4f;
    font-weight: bold;
    font-size:larger;
    }
        
    </style>
</head>
<body bgcolor="#999999">
    <form id="form1" runat="server">
        <div id=container>
           <div id=content>
               <table width="100%">
                  <tr>
                     <td height="32">
                         <asp:Label ID="Label1" runat="server" CssClass="bottomtext" Text="输入学号"></asp:Label></td><td><asp:TextBox ID="txtstuId" runat="server" Width="121px"></asp:TextBox>&nbsp;<asp:RequiredFieldValidator 
                ID="rfvstuId" runat="server" 
                        ControlToValidate="txtstuId" ErrorMessage="RequiredFieldValidator" 
                ForeColor="Red">*</asp:RequiredFieldValidator></td>
                  </tr>
                  <tr>
                    <td height="32"><asp:Label ID="Label2" runat="server" CssClass="bottomtext" Text="输入姓名" ></asp:Label></td><td><asp:TextBox ID="txtstuName" runat="server" Width="121px"></asp:TextBox>&nbsp;<asp:RequiredFieldValidator 
                ID="rfvstuName" runat="server" 
                        ControlToValidate="txtstuName" 
                ErrorMessage="RequiredFieldValidator" ForeColor="Red">*</asp:RequiredFieldValidator></td>
                  </tr>
                  <tr>
                      <td height="32"><asp:Label ID="Label3" runat="server" CssClass="bottomtext" Text="输入密码"></asp:Label></td><td><asp:TextBox ID="txtpsw" runat="server" Width="121px" TextMode="Password"></asp:TextBox>&nbsp;<asp:RequiredFieldValidator 
                ID="rfvpsw" runat="server" 
                        ControlToValidate="txtpsw" ErrorMessage="RequiredFieldValidator" 
                ForeColor="Red">*</asp:RequiredFieldValidator></td>
                  </tr>
                  <tr>
                     <td height="32"><asp:Label ID="Label4" runat="server" CssClass="bottomtext" Text="确认密码"></asp:Label></td><td><asp:TextBox ID="txtpsw1" runat="server" Width="121px" TextMode="Password"></asp:TextBox>&nbsp;<asp:RequiredFieldValidator 
                ID="frvpsw1" runat="server" 
                        ControlToValidate="txtpsw1" ErrorMessage="RequiredFieldValidator" 
                ForeColor="Red">*</asp:RequiredFieldValidator></td>
                  </tr>
                  <tr>
                     <td height="32"><asp:Label ID="Label5" runat="server" CssClass="bottomtext" Text="选择性别"></asp:Label></td><td><asp:RadioButton ID="RadioButton1" runat="server" CssClass="bottomtext" Text="男" GroupName="A" />
                     &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                     <asp:RadioButton ID="RadioButton2" runat="server" Text="女" CssClass="bottomtext" GroupName="A" /></td>
                  </tr>
                  <tr>
                     <td height="32"> <asp:Label ID="Label6" runat="server" CssClass="bottomtext" Text="输入班级"></asp:Label></td><td><asp:TextBox ID="txtclassName" runat="server" Width="121px"></asp:TextBox>&nbsp;<asp:RequiredFieldValidator 
                ID="rfvclassName" runat="server" 
                        ControlToValidate="txtclassName" 
                ErrorMessage="RequiredFieldValidator" ForeColor="Red">*</asp:RequiredFieldValidator></td>
                  </tr>
                  <tr>
                     <td height="35"><asp:Label ID="Label7" runat="server" CssClass="bottomtext" Text="联系方式"></asp:Label></td><td><asp:TextBox ID="txttel" runat="server" Width="121px"></asp:TextBox>&nbsp;<asp:RequiredFieldValidator 
                ID="rfvtel" runat="server" 
                        ControlToValidate="txttel" ErrorMessage="RequiredFieldValidator" 
                ForeColor="Red">*</asp:RequiredFieldValidator></td>
                  </tr>
                  <tr>
                     <td height="32"><asp:Label ID="Label8" runat="server" CssClass="bottomtext" Text="输入邮箱"></asp:Label></td><td><asp:TextBox ID="txtemail" runat="server" Width="121px"></asp:TextBox>&nbsp;<asp:RequiredFieldValidator 
                ID="rfvemail" runat="server" 
                        ControlToValidate="txtemail" ErrorMessage="RequiredFieldValidator" 
                ForeColor="Red">*</asp:RequiredFieldValidator></td>
                  </tr>
               </table>
           </div>
        
           <div id=submit>
              <table>
                <tr>
                  <td><asp:ImageButton ID="ImageButton1" runat="server" width="66" height="32"
                ImageUrl="images/rigister_13.gif" onclick="ImageButton1_Click" />&nbsp;&nbsp;&nbsp;&nbsp; </td>
                  <td><asp:ImageButton ID="ImageButton2" runat="server" width="71" height="32"
                ImageUrl="images/rigister_15.gif" onclick="ImageButton2_Click" />&nbsp;&nbsp; </td>
                </tr>
              </table>
           </div>
         </div>
    </form>
</body>
</html>
