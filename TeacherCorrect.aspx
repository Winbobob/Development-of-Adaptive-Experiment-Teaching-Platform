<%@ Page Language="C#" MasterPageFile="~/TeacherMasterPage.master" AutoEventWireup="true" CodeFile="TeacherCorrect.aspx.cs" Inherits="_Default" Title="学生设计题批改" %>
<%@ Register src="TeacherControl.ascx" tagname="TeacherControl" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
   <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style2
        {
            height: 30px;
        }
        .content
        {
            font-family: 微软雅黑;
        }
       .style4
       {
           width: 288px;
       }
    </style>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderContent" Runat="Server">
    <asp:Panel ID="Panel1" runat="server" Width="753px" Height="678px">
    &nbsp;&nbsp;
    <asp:DropDownList ID="DropDownList2" runat="server" 
        onselectedindexchanged="DropDownList2_SelectedIndexChanged" 
        AutoPostBack="True" Font-Names="微软雅黑" Font-Size="Medium">
        <asp:ListItem Value="0">初级</asp:ListItem>
        <asp:ListItem Value="1">中级</asp:ListItem>
        <asp:ListItem Value="2">高级</asp:ListItem>
    </asp:DropDownList>
    <br />
    <center>
        <br />
    
    <asp:GridView ID="GridView1" runat="server" 
          onselectedindexchanging="GridView1_SelectedIndexChanging" AutoGenerateColumns="False"
            onpageindexchanging="GridView1_PageIndexChanging" CellPadding="8" 
            Font-Names="微软雅黑" ForeColor="#333333" GridLines="None" Font-Size="Small" 
            Width="695px">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:CommandField ShowSelectButton="True" />
            <asp:BoundField DataField="stuId" HeaderText="学号" /> 
            <asp:BoundField DataField="filename" HeaderText="文件名" /> 
            <asp:BoundField DataField="createTime" HeaderText="提交时间" /> 
            <asp:BoundField DataField="urlupload" HeaderText="文件路径" /> 
        </Columns>
        <EditRowStyle BackColor="#7C6F57" />
        <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#E3EAEB" />
        <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
    </asp:GridView>　
    <br />
    <table width="90%" >
        
        <tr>
            
            <td>
                <asp:Label ID="lblstuId" runat="server" Text="stuId" Font-Names="微软雅黑" 
                    Font-Size="Medium"></asp:Label>
            </td>
            <td class="style4">
                <asp:Label ID="lblfilename" runat="server" Text="filename" Font-Names="微软雅黑" 
                    Font-Size="Medium"></asp:Label>
                     <asp:Button ID="btndownload" runat="server" Text="下载" 
                    Font-Names="微软雅黑" onclick="btndownload_Click"  /></td>
            
            <td>
  <asp:Label ID="lblscore" runat="server" Text="打分" Font-Names="微软雅黑" Font-Size="Medium"></asp:Label>
    <asp:TextBox ID="txtscore" runat="server" Font-Names="微软雅黑" Font-Size="Small" Width="99px"></asp:TextBox>
    
                &nbsp;&nbsp;&nbsp;&nbsp;
    
                <asp:Button ID="btnUpdate" runat="server" Text="确定" onclick="btnUpdate_Click" 
                    Font-Names="微软雅黑" />
                </td>
        
        </tr>
    </table>
    </asp:Panel>
    </center>
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


