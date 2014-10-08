<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" Title="登录页面" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta property="qc:admins" content="31456007462727267130665473107" />
    <title>无标题页</title>
    <style type="text/css">
    #container
    { 
	background-position: center;
	background-image:url(images/Login.jpg);
	position: relative;
	width: 600px;
	height: 336px;
	z-index: 1;
	background-repeat: no-repeat;
	margin: 0 auto;
	margin-top: 90px;
    }	
    #content
    {
	position: absolute;
	width: 233px;
	height: 127px;
	left: 337px;
	top: 152px;
    }
    .bottomtext
    {
    font-family: 微软雅黑;
    color: #525a4f;
    font-weight: bold;
    font-size:20px;
    }
    #submit
    {
	position: absolute;
	width: 163px;
	height: 41px;
	left: 492px;
	left: 362px;
	top: 288px;
    }
    #down
    {
	position: absolute;
	width: 60px;
	height: 30px;
	left: 692px;
	left: 535px;
	top: 302px;
    }
        .style1
        {
            width: 90px;
            height:30px;
        }
    </style>
</head>
<body bgcolor="#999999">
    <form id="form1" runat="server">
    <div id=container>
       <div id=content>
          <table>
            <tr>
              <td class="style1"><asp:Label ID="Label1" runat="server" CssClass="bottomtext" Text="用户类型"></asp:Label></td>
              <td><asp:RadioButton ID="RadioButton1" runat="server" Text="教师" GroupName="A" CssClass="bottomtext" ValidationGroup="A"/>
                  <asp:RadioButton ID="RadioButton2" runat="server" Text="学生" GroupName="A" CssClass="bottomtext" ValidationGroup="A" Checked="True" /></td>
            </tr>
            <tr>
               <td class="style1"><asp:Label ID="Label2" runat="server" CssClass="bottomtext" 
                       Text="账　号"></asp:Label></td>
               <td><asp:TextBox ID="txtName" runat="server" Width="106px" ValidationGroup="A"  ></asp:TextBox>
            <asp:RequiredFieldValidator 
                ID="rfvName" runat="server" 
                        ControlToValidate="txtName" ErrorMessage="RequiredFieldValidator" 
                ValidationGroup="A" ForeColor="Red">*</asp:RequiredFieldValidator></td>
            </tr>
            <tr>
               <td class="style1"><asp:Label ID="Label3" runat="server" CssClass="bottomtext" 
                       Text="密　码"></asp:Label></td>
               <td><asp:TextBox ID="txtPassword" runat="server"   Width="106px" 
                    TextMode="Password" ></asp:TextBox>
            <asp:RequiredFieldValidator 
                ID="rfvpassword" runat="server" 
                        ControlToValidate="txtPassword" 
                ErrorMessage="RequiredFieldValidator" ValidationGroup="A" ForeColor="Red">*</asp:RequiredFieldValidator></td>
            </tr>
            <tr>
               <td class="style1"><asp:Label ID="Label4" runat="server" CssClass="bottomtext" Text="验证码"></asp:Label></td>
               <td><asp:TextBox ID="txtcode" runat="server" Width="51px" ValidationGroup="A" MaxLength="4" 
                ></asp:TextBox>
&nbsp;<asp:RequiredFieldValidator  ID="rfvcode" runat="server" ControlToValidate="txtcode" ErrorMessage="RequiredFieldValidator" ValidationGroup="A" ForeColor="Red">*</asp:RequiredFieldValidator>&nbsp;
            <asp:Label ID="lblcode" runat="server" Text="Label" ForeColor="Red" ReadOnly="true"></asp:Label></td>
            </tr>
            </table>
          </div>
          <div id=submit>
            <table>
            <tr>
              <td> &nbsp;<asp:ImageButton ID="ImageButton1" runat="server"  width="68" height="34"
                ImageUrl="images/login_03.gif" onclick="ImageButton1_Click" 
                ValidationGroup="A" /></td>
              <td><asp:ImageButton ID="ImageButton2" runat="server" width="66" height="34"
                ImageUrl="images/login_05.gif" onclick="ImageButton2_Click" 
                ValidationGroup="A" /></td>
            </tr>
          </table>
         </div>
         <div id=down>
         
           <asp:ImageButton ID="ImageButton3" runat="server"  width="61" height="28" ImageUrl="images/login_08.gif" onclick="ImageButton3_Click"  ValidationGroup="B" />
         </div>
    </div>
    </form>
</body>
</html>
