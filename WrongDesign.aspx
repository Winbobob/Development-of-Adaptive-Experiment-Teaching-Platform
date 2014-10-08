<%@ Page Language="C#" MasterPageFile="~/StudentMasterPage.master" AutoEventWireup="true" CodeFile="WrongDesign.aspx.cs" EnableEventValidation="false"  Inherits="WrongDesign"  Title="设计题错题集" %>
<%@ Register src="StudentControl.ascx" tagname="StudentControl" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
 <style type="text/css">
  .num
        {
            font-family: 微软雅黑;
            color: #FF0000;
        }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderCTop" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderContent" Runat="Server">
 &nbsp;&nbsp;
    <asp:DropDownList ID="ddlTitleType" runat="server" Font-Names="微软雅黑" 
        Font-Size="Medium" 
        onselectedindexchanged="ddlTitleType_SelectedIndexChanged" 
        AutoPostBack="True">
        <asp:ListItem Value="0">选择题</asp:ListItem>
        <asp:ListItem Value="1">填空题</asp:ListItem>
        <asp:ListItem Value="2">判断题</asp:ListItem>
        <asp:ListItem Value="3">设计题</asp:ListItem>
    </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:DropDownList ID="ddlGradeNo" runat="server" 
        onselectedindexchanged="DropDownList2_SelectedIndexChanged" 
        AutoPostBack="True" Font-Names="微软雅黑" Font-Size="Medium">
        <asp:ListItem Value="0">初级</asp:ListItem>
        <asp:ListItem Value="1">中级</asp:ListItem>
        <asp:ListItem Value="2">高级</asp:ListItem>
    </asp:DropDownList>
    <br />
    <br />
 &nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label1" Font-Names="微软雅黑" runat="server" Text="错题数:" /><asp:Label ID="lblWTnum" runat="server" Text="" CssClass="num"></asp:Label>
    <br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btnOut" runat="server" onclick="btnOut_Click" Text="导出" Font-Names="微软雅黑"
        Width="91px" />
    
    <asp:Panel ID="PanelAll" runat="server" Height="725px" ScrollBars="Vertical" 
        Width="753px" style="margin-top: 0px">
        <center>
    <asp:GridView ID="GridView1" runat="server" Width="707px" Font-Names="微软雅黑" 
        AutoGenerateColumns="False"  onrowdeleting="GridView1_RowDeleting" 
                onrowdatabound="GridView1_RowDataBound" RowStyle-HorizontalAlign="Left" HeaderStyle-HorizontalAlign="Left">
        <Columns>
            <asp:BoundField HeaderText="ID" />
            <asp:TemplateField HeaderText="题目">
                <ItemTemplate> 
                     <asp:Label ID="lblquestion" runat="server" Text=<%#Eval("question")%> ></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="答案">
                <ItemTemplate>
                    <asp:Button ID="btnAnswer" runat="server" Text="下载" Font-Names="微软雅黑"  CommandName="Show" CommandArgument='<%#Eval("answer") %>' onclick="btnAnswer_Click" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField HeaderText="次数" DataField="num" />
            <asp:CommandField HeaderText="删除" ShowDeleteButton="True" />
        </Columns>
    </asp:GridView>
    </center>
    </asp:Panel>

</asp:Content>
<asp:Content ID="Content9" ContentPlaceHolderID="ContentPlaceHolderUnit" Runat="Server">
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
