<%@ Page  Language="C#" MasterPageFile="~/StudentMasterPage.master" AutoEventWireup="true" CodeFile="StudentDefault.aspx.cs" Inherits="studentDefault" Title="实验说明" %>
<%@ Register src="StudentControl.ascx" tagname="StudentControl" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
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
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderCTop" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderContent" Runat="Server">
    <center><p><span class="title1">实验说明</span></p></center>
    <p class="content">1.学生首先需要通过注册，填写个人信息。完成后进入学习风格测试。若意外退出，可在下次登录时点击学习风格测试按钮进行重新测试。</p>
    <p class="content">2.学生登录后，可点击个人信息修改按钮对个人信息进行修改。</p>
    <p class="content">3.学生可点击当前学习状态按钮查看自己当前的前测，低级、中级、高级测试的完成情况及其测试分数和老师对其设计题打的分和总分记录。</p>
    <p class="content">4.学生可点击我的错题集合按钮进入错题集页面，通过自主选择低级、中级、高级选项和单选、判断、填空、设计题选项查看错题，并查看答案。当学生对该道错题掌握完全时，则可选择性将该题目移出错题集，不再呈现。</p>
    <p class="content">5.实验模块：学生需先进行前测来评估进入测试的相应等级，若前测成绩高于60分，才可进入测试。前测成绩高于60且低于75，则进入初级测试；成绩若高于75且低于90，则可进入中级测试；若高于90分，直接进行高级测试。在每一等级进行测试时，高于60分则进入高一等级的测试，低于60分则在该等级重新测试。最后完成高级测试后，若学生还想巩固，则可进入练习模块进行学习。</p>
    <p class="content">6.学生在测试时意外无法完成测试，可保存，系统会记录学生最后一次使用实验测试时未完成的学情情景，学生在下次登录平台后可以选择点击学习断点记录，系统将重现该套试题及其完成部分，学生可继续未完成的测试练习</p>
    <p class="content">7.练习模块：学生可根据自身要求选择低级、中级、高级进行练习。</p>
    <p class="content">8.学习建议模块：学生在完成每次测试后，系统不仅会给出该次测试的成绩，答案和解析，学生可点击学习建议按钮查看学习建议，并跳转到相应的知识素材库进行学习。</p>
         
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
                    <uc1:StudentControl ID="teatreel1" runat="server" />
                    </td>
            </tr>
        </table>
    
    </center>
    </asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="ContentPlaceHolderCBottom" Runat="Server">
</asp:Content>

