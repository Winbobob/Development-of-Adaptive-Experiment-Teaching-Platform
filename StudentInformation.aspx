<%@ Page Title="" Language="C#" MasterPageFile="~/TeacherMasterPage.master" AutoEventWireup="true" CodeFile="StudentInformation.aspx.cs" Inherits="StudentInformation" %>
<%@ Register src="TeacherControl.ascx" tagname="TeacherControl" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .content
        {
            font-family: 微软雅黑;
        }
       .title1
        {
            font-family: 微软雅黑;
            color:#800000;
            font-size:larger;
            font-weight: bold;
            letter-spacing: .2em;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderContent" Runat="Server">
 <center><p><span class="title1">学生信息一览表</span></p></center>
    <asp:Panel ID="Panel1" runat="server" ScrollBars="Both" Width="753px"  
        Height="630px">
        
<asp:Label ID="Label1" Font-Names="微软雅黑" runat="server" Text="注册总人数:"></asp:Label>
<asp:Label ID="lblnum" runat="server" Text="" CssClass="num"></asp:Label>
         <br />
        <br />
 <center>
    <asp:GridView ID="GridView1" runat="server" Width="707px" Font-Names="微软雅黑"  
        AutoGenerateColumns="False">
        <Columns>
            <asp:TemplateField HeaderText="头像">
                <ItemTemplate> 
                    <asp:Image ID="imgphoto" width="60px" height="70px" runat="server" ImageUrl=<%#Eval("photo")%> />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField HeaderText="学号" DataField="stuId" />
            <asp:BoundField HeaderText="姓名" DataField="stuName" />
            <asp:BoundField HeaderText="班级" DataField="className" />
            <asp:BoundField HeaderText="性别" DataField="gender" />
            <asp:BoundField HeaderText="邮箱" DataField="email" />
            <asp:BoundField HeaderText="学习风格" DataField="learningStyle" />
        </Columns>
    </asp:GridView>
    </center>

 </asp:Panel>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderUnit" Runat="Server">
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

