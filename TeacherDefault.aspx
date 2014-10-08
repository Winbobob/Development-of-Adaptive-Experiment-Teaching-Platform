<%@ Page Language="C#" MasterPageFile="~/TeacherMasterPage.master" AutoEventWireup="true" CodeFile="TeacherDefault.aspx.cs" Inherits="teacherDefault" Title="实验说明" %>

<%@ Register src="TeacherControl.ascx" tagname="TeacherControl" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style1
        {
            height: 25px;
        }
        .style2
        {
            height: 30px;
        }
        .title1
        {
            font-family: 微软雅黑;
            color: #000000;
            font-size: large;
            font-weight: bold;
            letter-spacing: .2em;
        }
        .content
        {
            font-family: 微软雅黑;
        }
    </style>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderContent" Runat="Server">
    <center><p><span class="title1">教师指导说明</span></p></center>
    <p class="content">1.教师登录后，可点击个人信息修改按钮对个人信息进行修改。</p>
    <p class="content">2.教师可点击学生信息查看已注册学生的个人信息。</p>
    <p class="content">3.教师点击查看学生实验完成情况按钮查看每单元学生中级、高级测试的完成情况及其测试分数和老师对其设计题打的分和总分记录，并可更改总分。</p> 
    <p class="content">4.教师点击学生设计题批改按钮，通过选择低级、中级、高级按钮分别下载学生不同等级的设计题，并打分。</p>
    <p class="content">5.教师可进行实验题目的管理，对单选、判断、填空、设计题进行增删查改。</p>
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

