<%@ Control Language="C#" AutoEventWireup="true" CodeFile="TeacherControl.ascx.cs" Inherits="teatreel" %>
<asp:TreeView ID="TreeView1" runat="server"  
    CollapseImageUrl="~/images/1.png" ExpandImageUrl="~/images/2.png" 
    Font-Names="微软雅黑" ForeColor="#003300">
        <Nodes>
            <asp:TreeNode Text="查看学生信息" Value="查看学生信息" NavigateUrl="~/StudentInformation.aspx">
            </asp:TreeNode>
                <asp:TreeNode Text="查看学生实验" Value="查看学生实验" NavigateUrl="~/TeacherClassUnit.aspx"></asp:TreeNode>
                <asp:TreeNode Text="学生设计题批改" Value="学生设计题批改" NavigateUrl="~/TeacherCorrect.aspx"></asp:TreeNode>
            <asp:TreeNode Text="实验题目管理" Value="实验题目管理">
                <asp:TreeNode Text="单选题" Value="新建节点" NavigateUrl="~/RadioChange.aspx"></asp:TreeNode>
                <asp:TreeNode Text="判断题" Value="新建节点" NavigateUrl="~/JudgeChange.aspx"></asp:TreeNode>
                <asp:TreeNode Text="填空题" Value="新建节点" NavigateUrl="~/BlankChange.aspx"></asp:TreeNode>
                <asp:TreeNode Text="设计题" Value="新建节点" NavigateUrl="~/DesignChange.aspx"></asp:TreeNode>
            </asp:TreeNode>
        </Nodes>
    </asp:TreeView>