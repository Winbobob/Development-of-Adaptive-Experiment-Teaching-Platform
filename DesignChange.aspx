<%@ Page  Language="C#" MasterPageFile="~/TeacherMasterPage.master" AutoEventWireup="true" CodeFile="DesignChange.aspx.cs" Inherits="designChange"Title="设计题题目管理" %>

<%@ Register src="TeacherControl.ascx" tagname="TeacherControl" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .content
        {
            font-family: 微软雅黑;
        }
    </style>
</asp:Content>


<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderContent" Runat="Server">

    &nbsp;&nbsp;
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
    <asp:Panel ID="Panel1" runat="server" ScrollBars="Both" Width="753px" 
            Height="237px">
    
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
            <asp:BoundField DataField="question" HeaderText="题目" /> 
            <asp:BoundField DataField="answer" HeaderText="答案" /> 
            <asp:BoundField DataField="suggestion" HeaderText="知识点" /> 
            <asp:BoundField DataField="Q1" HeaderText="Q1" /> 
            <asp:BoundField DataField="A1" HeaderText="A1" /> 
            <asp:BoundField DataField="B1" HeaderText="B1" /> 
            <asp:BoundField DataField="C1" HeaderText="C1" /> 
            <asp:BoundField DataField="D1" HeaderText="D1" /> 
            <asp:BoundField DataField="answer1" HeaderText="Q1答案" /> 
            <asp:BoundField DataField="Q2" HeaderText="Q2" /> 
            <asp:BoundField DataField="A2" HeaderText="A2" /> 
            <asp:BoundField DataField="B2" HeaderText="B2" /> 
            <asp:BoundField DataField="C2" HeaderText="C2" /> 
            <asp:BoundField DataField="D2" HeaderText="D2" /> 
            <asp:BoundField DataField="answer2" HeaderText="Q2答案" /> 
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

    <table >
        <tr>
            <td align="right" class="content">
    题目：</td>
            <td align="left">
                <asp:TextBox ID="txtQuestion" runat="server" TextMode="MultiLine"></asp:TextBox>
            </td>
            <td align="right" class="content">
                答案：</td>
            <td align="left">
    <asp:TextBox ID="txtAnswer" runat="server" TextMode="MultiLine" Width="180px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right" class="content">
                知识点：</td>
            <td align="left">
                <asp:TextBox ID="txtSuggestion" runat="server" TextMode="MultiLine"></asp:TextBox>
            </td>
            <td align="right">
                &nbsp;</td>
            <td align="left">
                &nbsp;</td>
        </tr>
        <tr>
            <td align="right" class="content">
                Q1：</td>
            <td align="left">
                <asp:TextBox ID="txtQ1" runat="server" TextMode="MultiLine"></asp:TextBox>
            </td>
            <td align="right" class="content">
                Q1答案：</td>
            <td align="left">
                <asp:TextBox ID="txtQ1Answer" runat="server" 
         TextMode="MultiLine"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right" class="content">
                Q1A：</td>
            <td align="left">
                <asp:TextBox ID="txtQ1A" runat="server" TextMode="MultiLine"></asp:TextBox>
            </td>
            <td align="right" class="content">
                Q1B：</td>
            <td align="left">
                <asp:TextBox ID="txtQ1B" runat="server" 
        TextMode="MultiLine" ></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right" class="content">
                Q1C：</td>
            <td align="left">
                <asp:TextBox ID="txtQ1C" runat="server" TextMode="MultiLine"></asp:TextBox>
            </td>
            <td align="right" class="content">
                Q1D：</td>
            <td align="left">
                <asp:TextBox ID="txtQ1D" runat="server" 
        TextMode="MultiLine"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right" class="content">
                Q2：</td>
            <td align="left">
                <asp:TextBox ID="txtQ2" runat="server" 
        TextMode="MultiLine"></asp:TextBox>
            </td>
            <td align="right" class="content">
                Q2答案：</td>
            <td align="left">
                <asp:TextBox ID="txtQ2Answer" runat="server" TextMode="MultiLine"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right" class="content">
                Q2A：</td>
            <td align="left">
                <asp:TextBox ID="txtQ2A" runat="server" TextMode="MultiLine"></asp:TextBox>
            </td>
            <td align="right" class="content">
                Q2B：</td>
            <td align="left">
    <asp:TextBox ID="txtQ2B" runat="server" 
        TextMode="MultiLine" ></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right" class="content">
&nbsp;Q2C：</td>
            <td align="left">
                <asp:TextBox ID="txtQ2C" runat="server" TextMode="MultiLine"></asp:TextBox>
            </td>
            <td align="right" class="content">
                Q2D：</td>
            <td align="left">
    <asp:TextBox ID="txtQ2D" runat="server" 
        TextMode="MultiLine"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
        <asp:Button ID="btnUpdate" runat="server" Text="修改" 
        onclick="btnUpdate_Click" Font-Names="微软雅黑" Font-Size="Medium" />
            </td>
            <td>
        <asp:Button ID="btnAdd" runat="server" Text="增加" onclick="btnAdd_Click" 
        Font-Names="微软雅黑" Font-Size="Medium" />
            </td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
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
                <td >
                    <uc1:TeacherControl ID="teatreel1" runat="server" />
                </td>
            </tr>
        </table>
    
    </center>
</asp:Content>

