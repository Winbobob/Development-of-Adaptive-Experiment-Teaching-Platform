<%@ Control Language="C#" AutoEventWireup="true" CodeFile="StudentControl.ascx.cs" Inherits="infotree" %>
<asp:TreeView ID="TreeView1" runat="server" 
    CollapseImageUrl="~/images/1.png" ExpandImageUrl="~/images/2.png" 
    Font-Names="微软雅黑" 
    ForeColor="#003300" >
    <Nodes>
        <asp:TreeNode Text="第一单元" Value="第一单元">
            <asp:TreeNode Text="实验" Value="实验">
                <asp:TreeNode Text="前测" Value="前测" NavigateUrl="~/BeforeTest.aspx"></asp:TreeNode>
                <asp:TreeNode Text="测试" Value="测试">
                   <asp:TreeNode Text="初级" Value="初级" NavigateUrl="~/TestLow.aspx?caid=0"></asp:TreeNode>
                   <asp:TreeNode Text="中级" Value="中级" NavigateUrl="~/TestMid.aspx?caid=0"></asp:TreeNode>
                   <asp:TreeNode Text="高级" Value="高级" NavigateUrl="~/TestHigh.aspx?caid=0"></asp:TreeNode>
                </asp:TreeNode>
            </asp:TreeNode>
            <asp:TreeNode Text="练习" Value="练习">
                <asp:TreeNode Text="初级" Value="初级" NavigateUrl="~/ExerciseLow.aspx"></asp:TreeNode>
                <asp:TreeNode Text="中级" Value="中级" NavigateUrl="~/ExerciseMid.aspx"></asp:TreeNode>
                <asp:TreeNode Text="高级" Value="高级" NavigateUrl="~/ExerciseHigh.aspx"></asp:TreeNode>
            </asp:TreeNode>
        </asp:TreeNode>
        
    </Nodes>
</asp:TreeView>

