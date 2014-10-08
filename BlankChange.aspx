<%@ Page Language="C#" MasterPageFile="~/TeacherMasterPage.master" AutoEventWireup="true" CodeFile="BlankChange.aspx.cs" Inherits="BlankChange" Title="填空题题目管理" %>
<%@ Register src="TeacherControl.ascx" tagname="TeacherControl" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .content
        {
            font-family: 微软雅黑;
        }
    </style>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderContent" Runat="Server">&nbsp;&nbsp;
    <asp:DropDownList ID="DropDownList2" runat="server" 
        onselectedindexchanged="DropDownList2_SelectedIndexChanged" 
        AutoPostBack="True" Font-Names="微软雅黑" Font-Size="Medium">
        <asp:ListItem Value="0">初级</asp:ListItem>
        <asp:ListItem Value="1">中级</asp:ListItem>
        <asp:ListItem Value="2">高级</asp:ListItem>
    </asp:DropDownList>
    
    <br />
    
    <br />
    
    <center>
    <asp:Panel ID="Panel1" runat="server" Height="447px"  ScrollBars="Vertical"  
            Width="753px" >
    
    <asp:GridView ID="GridView1" runat="server" 
        onrowdeleting="GridView1_RowDeleting"  AutoGenerateColumns="False"
        onselectedindexchanging="GridView1_SelectedIndexChanging" CellPadding="4" 
        ForeColor="#333333" GridLines="None" 
        onpageindexchanging="GridView1_PageIndexChanging" Font-Names="微软雅黑" Font-Size="Small" 
        >
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:CommandField ShowSelectButton="True" >
                <HeaderStyle Width="50px" />
            </asp:CommandField>
            <asp:CommandField ShowDeleteButton="True" >
                <HeaderStyle Width="50px" />
            </asp:CommandField>
            <asp:BoundField DataField="Id" HeaderText="题号" /> 
            <asp:BoundField DataField="qFront" HeaderText="题目（前半）" /> 
            <asp:BoundField DataField="qBack" HeaderText="题目（后半）" /> 
            <asp:BoundField DataField="answer" HeaderText="答案" /> 
            <asp:BoundField DataField="explain" HeaderText="解析" /> 
            <asp:BoundField DataField="suggestion" HeaderText="知识点" /> 
            
        </Columns>
        <EditRowStyle BackColor="#7C6F57" />
        <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#E3EAEB" />
        <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
    </asp:GridView>
  <br />
    </asp:Panel>
   <br />

        <table width="95%">
            <tr>
                 <td align="right" class="content">
                题目（前半）：</td>
            <td align="left">
                <asp:TextBox ID="txtqFront" runat="server" TextMode="MultiLine"></asp:TextBox>
            </td>
            <td align="right" class="content">
                题目（后半）：</td>
            <td align="left">
                <asp:TextBox ID="txtqBack" runat="server" TextMode="MultiLine"></asp:TextBox>
            </td>
            </tr>
            <tr>
                <td align="right" class="content">
                答案：</td>
            <td align="left">
                <asp:TextBox ID="txtAnswer" runat="server" TextMode="MultiLine"></asp:TextBox>
            </td>
            <td align="right" class="content">
                解析：</td>
            <td align="left">
                <asp:TextBox ID="txtExplain" runat="server" TextMode="MultiLine" ></asp:TextBox>
            </td>
            </tr>
            <tr>
                <td align="right" class="content">
                知识点：</td>
            <td align="left">
                <asp:TextBox ID="txtSuggestion" runat="server" TextMode="MultiLine"></asp:TextBox>
            </td>
            <td align="right" class="content">
                &nbsp;</td>
            <td align="left">
                &nbsp;</td>
            </tr>
             <tr>
            <td>
                </td>
            <td>
        <asp:Button ID="btnUpdate" runat="server" Text="修改" 
        onclick="btnUpdate_Click" Font-Names="微软雅黑" Font-Size="Medium" />
            </td>
            <td>
        <asp:Button ID="btnAdd" runat="server" Text="增加" onclick="btnAdd_Click" 
        Font-Names="微软雅黑" Font-Size="Medium" style="margin-bottom: 0px" />
            </td>
            <td>
               </td>
        </tr>
        </table>
       </center>
    
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolderUnit" Runat="Server">
    <center>
        <table>
            <tr>
                <td >
                    </td>
            </tr>
            <tr>
                <td>
                    <uc1:TeacherControl ID="teatreel1" runat="server" /></td>
            </tr>
        </table>
    
    </center>
</asp:Content>


