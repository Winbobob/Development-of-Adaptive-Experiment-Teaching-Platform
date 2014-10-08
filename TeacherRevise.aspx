<%@ Page Language="C#" MasterPageFile="~/TeacherMasterPage.master" AutoEventWireup="true" CodeFile="TeacherRevise.aspx.cs" Inherits="teacherrevise" Title="教师个人信息修改" %>

<%@ Register src="TeacherControl.ascx" tagname="TeacherControl" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style1
        {
            width: 123px;
        }
        
    .style2
    {
        height: 19px;
    }
    .style3
    {
        height: 30px;
    }
        
    .content
    {
        font-family: 微软雅黑;
    }
        
    .jiben
    {
        font-family: 微软雅黑;
        font-size: large;
        font-weight: bold;
        color: #800000;
        letter-spacing: .3em;
    }
        
    </style>
    
  
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderContent" Runat="Server">
    <table width="90%" align="center" border="2px" style="border-color: #33CC33">
    <tr><td colspan ="4" bgcolor ="#c5e6b3"> <h3><span class="jiben">个人基本信息修改</span></h3> </td></tr>
    <tr>
        <td rowspan="15" border="0"></td></tr>
   <tr><td rowspan ="5" align="center" border="0" >
       <asp:Image ID="imgphoto" width="120px" height="150px" runat="server" />
       </td></tr>
   
   <tr>
   <td align="right" class="style1">
       &nbsp;<asp:Label ID="Label1" runat="server" Text="姓名:" CssClass="content"></asp:Label></td> 
       <td>
           <asp:TextBox ID="txtteaName" runat="server" ValidationGroup="A" 
               CssClass="content"></asp:TextBox>
           <asp:RequiredFieldValidator ID="rfvteaName" runat="server" 
                        ControlToValidate="txtteaName" 
               ErrorMessage="RequiredFieldValidator" ValidationGroup="A" ForeColor="Red">*</asp:RequiredFieldValidator>
       </td> 
   </tr>
   <tr>
   <td  align="right" class="style1"><asp:Label ID="Label2" runat="server" Text="账号:" 
           CssClass="content"></asp:Label></td> 
       <td>
       <asp:TextBox ID="txtteaId" runat="server" ValidationGroup="A" Enabled="False" 
               CssClass="content"></asp:TextBox>
           <asp:RequiredFieldValidator ID="rfvteaId" runat="server" 
               ControlToValidate="txtteaId" ErrorMessage="RequiredFieldValidator" 
               ValidationGroup="A" ForeColor="Red">*</asp:RequiredFieldValidator>&nbsp;<asp:Label 
               ID="Label10" runat="server"
                   Text="Label" ForeColor="Red" CssClass="content"> 账号不能更改！</asp:Label>
          </td> 
   </tr>
   <tr>
   <td align="right" valign="top" class="style1">
       <asp:Label ID="Label3" runat="server" Text="性别:" CssClass="content"></asp:Label></td> 
       <td >
           &nbsp;
           <asp:Label ID="lblgender" runat="server" CssClass="content"></asp:Label>&nbsp;<asp:RadioButtonList 
               ID="rdolistgender" runat="server" Width="125px" 
               RepeatDirection="Horizontal" ValidationGroup="A" CssClass="content">
               <asp:ListItem>男</asp:ListItem>
               <asp:ListItem>女</asp:ListItem>
           </asp:RadioButtonList>
      </td> 
   </tr>
   <tr>
   <td align="right" class="style1"><asp:Label ID="Label4" runat="server" Text="邮箱:" 
           CssClass="content" ></asp:Label></td> 
       <td>
       <asp:TextBox ID="txtemail" runat="server" ValidationGroup="A" CssClass="content"></asp:TextBox>
           <asp:RequiredFieldValidator ID="rfvemail" runat="server" 
               ControlToValidate="txtemail" ErrorMessage="RequiredFieldValidator" 
               ValidationGroup="A" ForeColor="Red">*</asp:RequiredFieldValidator>
           </td> 
   </tr>
   <tr><td  align="center" border="0">
       <asp:Button ID="Button1" runat="server" 
               Text="修改密码" onclick="btnChangepsw_Click" CssClass="content" /></td>
   <td align="right" class="style1"><asp:Label ID="Label5" runat="server" Text="联系方式:" 
           CssClass="content"></asp:Label></td> 
       <td>
       <asp:TextBox ID="txttel" runat="server" ValidationGroup="A" CssClass="content"></asp:TextBox>
           <asp:RequiredFieldValidator ID="rfvtel" runat="server" 
               ControlToValidate="txttel" ErrorMessage="RequiredFieldValidator" 
               ValidationGroup="A" ForeColor="Red">*</asp:RequiredFieldValidator>
       </td> 
   </tr>
   <tr><td rowspan="3" >
    </td>
       <td align="right" class="style1"> <asp:Label ID="Label9" runat="server" 
               Text="头像更换:" CssClass="content"></asp:Label>
           
       </td><td><asp:FileUpload ID="fUpload" runat="server" 
               CssClass="content" />
          
          </td>
       </tr>
       <tr><td></td><td>  <asp:Label ID="lbText" runat="server" 
               CssClass="content" ForeColor="Red" >注意：只能上传gif、png、jpeg或者jpg图像文件！</asp:Label></td></tr>
       <tr><td colspan="2" align="right" class="style17" style="border-style:none"> 
           <br />
           <asp:Button ID="btnSubmit0" runat="server" Text="保存修改" 
               onclick="btnSubmit0_Click" ValidationGroup="A" CssClass="content" />
           </td></tr>
       <tr><td rowspan="3" ></td><td  align="right" 
               class="style1">
           <asp:Label ID="Label6" runat="server" Text="请输入原密码:" Visible="False" 
               CssClass="content"></asp:Label></td>
           <td>
               <asp:TextBox ID="txtpsw" runat="server" TextMode="Password" Visible="False" 
                   ValidationGroup="B" CssClass="content"></asp:TextBox>
               <asp:RequiredFieldValidator ID="rfvpsw" runat="server" 
                   ControlToValidate="txtpsw" ErrorMessage="RequiredFieldValidator" 
                   Visible="False" ValidationGroup="B" ForeColor="Red">*</asp:RequiredFieldValidator>
               </td>
       </tr>
       <tr><td  align="right" class="style1" >
           <asp:Label ID="Label7" runat="server" Text="请输入新密码:" Visible="False" 
               CssClass="content"></asp:Label></td>
           <td >
               <asp:TextBox ID="txtpsw1" runat="server" TextMode="Password" Visible="False" 
                   ValidationGroup="B" CssClass="content"></asp:TextBox>
               <asp:RequiredFieldValidator ID="rfvpsw1" runat="server" 
                   ControlToValidate="txtpsw1" ErrorMessage="RequiredFieldValidator" 
                   Visible="False" ValidationGroup="B" ForeColor="Red">*</asp:RequiredFieldValidator>
           </td>
       </tr>
       <tr><td  align="right" class="style1"><asp:Label ID="Label8" runat="server" 
               Text="确认新密码:" Visible="False" CssClass="content"></asp:Label></td>
           <td >
               <asp:TextBox ID="txtpsw2" runat="server" TextMode="Password" Visible="False" 
                   ValidationGroup="B" CssClass="content"></asp:TextBox>
               <asp:RequiredFieldValidator ID="rfvpsw2" runat="server" 
                   ControlToValidate="txtpsw2" ErrorMessage="RequiredFieldValidator" 
                   Visible="False" ValidationGroup="B" ForeColor="Red">*</asp:RequiredFieldValidator>
               &nbsp;<asp:CompareValidator ID="cvpsw1" runat="server" ControlToCompare="txtpsw1" 
                   ControlToValidate="txtpsw2" ErrorMessage="密码与确认密码不一致！" 
                   SetFocusOnError="True" Visible="False" ValidationGroup="B" 
                   CssClass="content" ForeColor="Red"></asp:CompareValidator>
           </td>
       </tr>
       <tr><td ></td><td colspan="2" align="right" style="border-style:none"
               id="cancel"> 
           <asp:Button ID="btnSubmit" runat="server" Text="确定" 
               onclick="btnSubmit_Click" Width="63px" Visible="False" 
               ValidationGroup="B" CssClass="content" />
           &nbsp;
           <asp:Button ID="btnCancel" runat="server" onclick="btnCancel_Click" Text="取消" 
               Width="57px" Visible="False" ValidationGroup="B" CssClass="content" />
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
                    <uc1:TeacherControl ID="teatreel1" runat="server" /></td>
            </tr>
        </table>
    
    </center>
    </asp:Content>


