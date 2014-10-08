<%@ Page Language="C#" MasterPageFile="~/StudentMasterPage.master" AutoEventWireup="true" CodeFile="StudentRevise.aspx.cs" Inherits="studentrevise" Title="学生个人信息修改" %>

<%@ Register src="StudentControl.ascx" tagname="StudentControl" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style1
        {
        }
    .title2
    {
        font-family: 微软雅黑;
        font-size: large;
        font-weight: bold;
        color: #800000;
        line-height: 25px;
    }
    .content
    {
        font-family: 微软雅黑;
    }
    </style>
    

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderCTop" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderContent" Runat="Server">
    <table width="90%" align="center" border="2px" style="border-color: #33CC33">
    <tr><td colspan ="4" bgcolor ="#c5e6b3"> <h3><span class="title2">个人基本信息修改</span></h3> </td></tr>
    <tr>
        <td rowspan="16" border="0"></td></tr>
   <tr><td rowspan ="5" align="center" border="0" width="120px" >
       <asp:Image ID="imgphoto" width="120px" height="150px" runat="server" />
       </td></tr>
   
   <tr>
   <td align="right" class="style1">
       &nbsp;<asp:Label ID="Label1" runat="server" Text="姓名:" CssClass="content"></asp:Label></td> 
       <td >
           <asp:TextBox ID="txtstuName" runat="server" ValidationGroup="A" 
               Font-Names="微软雅黑"></asp:TextBox>
           <asp:RequiredFieldValidator ID="rfvstuName" runat="server" 
                        ControlToValidate="txtstuName" 
               ErrorMessage="RequiredFieldValidator" ValidationGroup="A" ForeColor="Red">*</asp:RequiredFieldValidator>
      
       </td> 
   </tr>
   <tr>
   <td  align="right" class="style1"><asp:Label ID="Label10" runat="server" Text="班级:" 
           CssClass="content"></asp:Label></td> 
       <td >
       <asp:TextBox ID="txtclassName" runat="server" ValidationGroup="A" Font-Names="微软雅黑"></asp:TextBox>
           <asp:RequiredFieldValidator ID="rfvclassName" runat="server" 
               ControlToValidate="txtclassName" ErrorMessage="RequiredFieldValidator" 
               ValidationGroup="A" ForeColor="Red">*</asp:RequiredFieldValidator>
       </td> 
   </tr>
   <tr>
   <td  align="right" class="style1"><asp:Label ID="Label2" runat="server" Text="学号:" 
           CssClass="content"></asp:Label></td> 
       <td >
       <asp:TextBox ID="txtstuId" runat="server" ValidationGroup="A" Enabled="False" 
               Font-Names="微软雅黑"></asp:TextBox>
           <asp:RequiredFieldValidator ID="rfvstuId" runat="server" 
               ControlToValidate="txtstuId" ErrorMessage="RequiredFieldValidator" 
               ValidationGroup="A" ForeColor="Red">*</asp:RequiredFieldValidator>
       &nbsp;<asp:Label ID="Label11" runat="server"
                   Text=" 学号不能更改！" ForeColor="Red" Font-Names="微软雅黑"></asp:Label></td> 
   </tr>
   <tr>
   <td class="style1" align="right"><asp:Label ID="Label3" runat="server" Text="性别:" 
           CssClass="content"></asp:Label></td> 
       <td >&nbsp;&nbsp; <asp:Label ID="lblgender" runat="server" CssClass="content"></asp:Label>
           <asp:RadioButtonList ID="rdolistgender" runat="server" Width="125px" 
               RepeatDirection="Horizontal" ValidationGroup="A" CssClass="content">
               <asp:ListItem>男</asp:ListItem>
               <asp:ListItem>女</asp:ListItem>
           </asp:RadioButtonList>
       </td> 
   </tr>
   
   <tr><td align="center">
    <asp:Button ID="btnChangepsw" runat="server" 
               Text="修改密码" onclick="btnChangepsw_Click" Font-Names="微软雅黑" /></td>
   <td align="right" class="style1"><asp:Label ID="Label4" runat="server" Text="生日:" 
           CssClass="content"></asp:Label></td> 
       <td >
       <asp:TextBox ID="txtbirthday" runat="server" ValidationGroup="A" Font-Names="微软雅黑"></asp:TextBox>
           <asp:RequiredFieldValidator ID="rfvbirthday" runat="server" 
               ControlToValidate="txtbirthday" ErrorMessage="RequiredFieldValidator" 
               ValidationGroup="A" ForeColor="Red">*</asp:RequiredFieldValidator>
           </td> 
   </tr>
   <tr><td align="center"  border="0" style="border-style:none">
       &nbsp;</td>
   <td align="right" class="style1"><asp:Label ID="Label12" runat="server" Text="邮箱:" 
           CssClass="content"></asp:Label></td> 
       <td >
       <asp:TextBox ID="txtemail" runat="server" ValidationGroup="A" Font-Names="微软雅黑"></asp:TextBox>
           <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
               ControlToValidate="txtemail" ErrorMessage="RequiredFieldValidator" 
               ValidationGroup="A" ForeColor="Red">*</asp:RequiredFieldValidator>
           </td> 
   </tr>
   <tr><td align="center"  border="0" style="border-style:none">
       &nbsp;</td>
   <td align="right" class="style1"><asp:Label ID="Label5" runat="server" Text="联系方式:" 
           CssClass="content"></asp:Label></td> 
       <td >
       <asp:TextBox ID="txttel" runat="server" ValidationGroup="A" Font-Names="微软雅黑"></asp:TextBox>
           <asp:RequiredFieldValidator ID="rfvtel" runat="server" 
               ControlToValidate="txttel" ErrorMessage="RequiredFieldValidator" 
               ValidationGroup="A" ForeColor="Red">*</asp:RequiredFieldValidator>
       </td> 
   </tr>
   <tr><td  rowspan="4">
      </td> <td align="right" class="style1" > <asp:Label ID="Label9" runat="server" 
               Text="头像更换:" CssClass="content"></asp:Label>
           
       </td><td ><asp:FileUpload ID="fUpload" runat="server" Font-Names="微软雅黑" />  </td>
       </tr>
       <tr><td></td><td>  <asp:Label ID="lbText" runat="server" CssClass="content" 
               ForeColor="Red" >注意：只能上传gif、png、jpeg或者jpg图像文件！</asp:Label></td></tr>
       <tr><td align="right" class="style1"><asp:Label ID="Label13" runat="server" Text="学习风格:" CssClass="content"></asp:Label></td>
       <td class="style17"> 
       <asp:TextBox ID="txtlearningStyle" runat="server" ValidationGroup="A" Enabled="False" 
               Font-Names="微软雅黑"></asp:TextBox>
           <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
               ControlToValidate="txtlearningStyle" ErrorMessage="RequiredFieldValidator" 
               ValidationGroup="A" ForeColor="Red">*</asp:RequiredFieldValidator>
       &nbsp;<asp:Label ID="Label14" runat="server"
                   Text="学习风格不能更改！" ForeColor="Red" Font-Names="微软雅黑"></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    </td></tr>
       <tr><td align="right" class="style1" colspan="2" style="border-style:none">
                    <br />
                    <asp:Button ID="btnSubmit0" runat="server" Text="保存修改" 
               onclick="btnSubmit0_Click" ValidationGroup="A" Font-Names="微软雅黑" />
           </td>
        </tr>
       <tr><td rowspan="3"></td><td  align="right" class="style1"  >
           <asp:Label ID="Label6" runat="server" Text="请输入原密码:" Visible="False" 
               CssClass="content"></asp:Label></td><td >
               <asp:TextBox ID="txtpsw" runat="server" TextMode="Password" Visible="False" 
                   ValidationGroup="B" Font-Names="微软雅黑"></asp:TextBox>
               <asp:RequiredFieldValidator ID="rfvpsw" runat="server" 
                   ControlToValidate="txtpsw" ErrorMessage="RequiredFieldValidator" 
                   Visible="False" ValidationGroup="B" ForeColor="Red">*</asp:RequiredFieldValidator>
           </td>
       </tr>
       <tr><td  align="right" class="style1" > 
           <asp:Label ID="Label7" runat="server" Text="请输入新密码:" Visible="False" 
               CssClass="content"></asp:Label></td><td>
               <asp:TextBox ID="txtpsw1" runat="server" TextMode="Password" Visible="False" 
                   ValidationGroup="B" Font-Names="微软雅黑"></asp:TextBox>
               <asp:RequiredFieldValidator ID="rfvpsw1" runat="server" 
                   ControlToValidate="txtpsw1" ErrorMessage="RequiredFieldValidator" 
                   Visible="False" ValidationGroup="B" ForeColor="Red">*</asp:RequiredFieldValidator>
           </td>
       </tr>
       <tr><td  align="right" class="style1">
           <asp:Label ID="Label8" runat="server" Text="确认新密码:" Visible="False" 
               CssClass="content"></asp:Label></td><td>
               <asp:TextBox ID="txtpsw2" runat="server" TextMode="Password" Visible="False" 
                   ValidationGroup="B" Font-Names="微软雅黑"></asp:TextBox>
               <asp:RequiredFieldValidator ID="rfvpsw2" runat="server" 
                   ControlToValidate="txtpsw2" ErrorMessage="RequiredFieldValidator" 
                   Visible="False" ValidationGroup="B" ForeColor="Red">*</asp:RequiredFieldValidator>
               &nbsp;<asp:CompareValidator ID="cvpsw1" runat="server" ControlToCompare="txtpsw1" 
                   ControlToValidate="txtpsw2" ErrorMessage="密码与确认密码不一致！" 
                   SetFocusOnError="True" Visible="False" ValidationGroup="B" 
                   CssClass="content" ForeColor="Red"></asp:CompareValidator>
           </td>
       </tr>
       <tr><td ></td><td colspan="3" align="right" style="border-style:none"
               id="cancel"> 
           <asp:Button ID="btnSubmit" runat="server" Text="确定" 
               onclick="btnSubmit_Click" Width="63px" Visible="False" 
               ValidationGroup="B" Font-Names="微软雅黑" />
           &nbsp;
           <asp:Button ID="btnCancel" runat="server" onclick="btnCancel_Click" Text="取消" 
               Width="57px" Visible="False" ValidationGroup="B" Font-Names="微软雅黑" />
           </td>
           </tr>
       </table>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolderUnit" Runat="Server">
    <center>
        <table>
            <tr>
                <td>
                    </td>
            </tr>
            <tr>
                <td>
                    <uc1:StudentControl ID="infotree1" runat="server" />
                </td>
            </tr>
        </table>
    
    </center>
    
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="ContentPlaceHolderCBottom" Runat="Server">
</asp:Content>

