<%@ Page Language="C#" MasterPageFile="~/StudentMasterPage.master" AutoEventWireup="true" CodeFile="StudentClassUnit.aspx.cs" Inherits="StudyingInform3" Title="当前学习状态" %>

<%@ Register src="StudentControl.ascx" tagname="StudentControl" tagprefix="uc1" %>

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
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderCTop" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderContent" Runat="Server">
    <center >
 <asp:GridView ID="GridView1" runat="server" Height="16px"   AutoGenerateColumns="False"
        Width="672px" CellPadding="4" ForeColor="#333333" GridLines="None" 
        Font-Names="微软雅黑" Font-Size="Medium">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:BoundField DataField="stuId" HeaderText="学号" /> 
            <asp:BoundField DataField="pretest" HeaderText="前测成绩" /> 
            <asp:BoundField DataField="low" HeaderText="初级测试成绩" /> 
            <asp:BoundField DataField="mid" HeaderText="中级测试成绩" /> 
            <asp:BoundField DataField="high" HeaderText="高级测试成绩" /> 
            <asp:BoundField DataField="designLow" HeaderText="初级设计题成绩" /> 
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
    <br>
    <br>
        <asp:Chart ID="Chart1" runat="server" Height="360px" Width="484px" 
            BorderlineColor="Transparent" BackColor="LightYellow" 
            BackImageTransparentColor="Transparent" BackSecondaryColor="Gray" >
            <Series>
                <asp:Series Name="Series1" ChartType="Line" BorderWidth="3">
                </asp:Series>
            </Series>
            <Series>
                <asp:Series Name="Series2" ChartType="Line" BorderWidth="3" >
                </asp:Series>
            </Series>
            <ChartAreas>
                <asp:ChartArea Name="ChartArea1">
                </asp:ChartArea>
            </ChartAreas>
            <Titles>
               <asp:Title Text="我的成绩与最高分对比折线图" ForeColor="Green" ShadowColor="#00CC00"></asp:Title>
            </Titles>
        </asp:Chart>

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
                    <uc1:StudentControl ID="infotree1" runat="server" />
                </td>
            </tr>
        </table>
    
    </center>
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="ContentPlaceHolderCBottom" Runat="Server">
</asp:Content>

