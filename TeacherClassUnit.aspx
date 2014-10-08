<%@ Page Language="C#" MasterPageFile="~/TeacherMasterPage.master" AutoEventWireup="true" CodeFile="TeacherClassUnit.aspx.cs" Inherits="StudyingInform" Title="查看学生实验完成情况" %>

<%@ Register src="TeacherControl.ascx" tagname="TeacherControl" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style1
        {
            height: 21px;
        }
        .style2
        {
            height: 30px;
        }
        .style3
        {
            width: 118px;
        }
        </style>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderContent" Runat="Server">
    
    <center>
    <asp:Panel ID="Panel1" runat="server" Width="753px" Height="678px">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False"
         onselectedindexchanging="GridView1_SelectedIndexChanging" 
            onpageindexchanging="GridView1_PageIndexChanging" CellPadding="4" 
            Font-Names="微软雅黑" Font-Size="Medium" ForeColor="#333333" GridLines="None" 
            Width="642px" >
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:CommandField ShowSelectButton="True" />
            <asp:BoundField DataField="stuId" HeaderText="学号" /> 
            <asp:BoundField DataField="mid" HeaderText="中级测试成绩" /> 
            <asp:BoundField DataField="high" HeaderText="高级测试成绩" /> 
            <asp:BoundField DataField="designMid" HeaderText="中级设计题成绩" /> 
            <asp:BoundField DataField="designHigh" HeaderText="高级设计题成绩" /> 
            <asp:BoundField DataField="totalScore" HeaderText="总成绩" /> 
        </Columns>
        <EditRowStyle BackColor="#7C6F57" />
        <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#E3EAEB" />
        <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />   
       
    </asp:GridView>　
    

    <table width="90%">
        
        <tr>
            <td>
                <asp:Button ID="btnUpdate" runat="server" Text="修改" onclick="btnUpdate_Click" 
                    Font-Names="微软雅黑" Font-Size="Medium" />
            </td>
            <td>
                <asp:Label ID="lblstuId" runat="server" Text="Label" Font-Names="微软雅黑" 
                    Font-Size="Medium"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td class="style3">
  
    <asp:Label ID="Label2" runat="server" Text="总体分数" Font-Names="微软雅黑" Font-Size="Medium"></asp:Label>
            </td>
            <td>
    <asp:TextBox ID="txtTotalscore" runat="server" Font-Names="微软雅黑" Font-Size="Small"></asp:TextBox>
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
                    <uc1:TeacherControl ID="teatreel1" runat="server" />
                </td>
            </tr>
        </table>
    </center>
</asp:Content>


