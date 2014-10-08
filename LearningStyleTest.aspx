<%@ Page Language="C#" MasterPageFile="~/StudentMasterPage.master" AutoEventWireup="true" CodeFile="LearningStyleTest.aspx.cs" Inherits="LearningStyleTest" Title="学习风格测试" %>
<%@ Register src="StudentControl.ascx" tagname="StudentControl" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .question
        {
            font-family: 微软雅黑;
            color: #003300;
        }
  
     .style1
     {
            width: 35px;
        }
  
        .questionTitle
        {
            font-family: 微软雅黑;
            font-size: x-large;
            color: #800000;
            font-weight: bolder;
        }
  
    </style>
    <!-- GreyBox引用开始 --> 
<script type="text/javascript">
    var GB_ROOT_DIR = "greybox/"; //注意这里的路径！！！ 
</script> 
<script type="text/javascript" src="greybox/AJS.js"></script> 
<script type="text/javascript" src="greybox/AJS_fx.js"></script> 
<script type="text/javascript" src="greybox/gb_scripts.js"></script> 
<link href="greybox/gb_styles.css" rel="stylesheet" type="text/css" /> 
<!-- GreyBox引用结束 --> 
<script type="text/javascript">
    //居中弹出模态窗口 
    function openWinCenter() {
        //GB_showCenter(caption, url, /* optional */ height, width, callback_fn) 
        GB_showCenter("学习风格测试结果", "../learningResult.aspx", 350, 630);
    }
</script> 
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderCTop" Runat="Server">
    <center>
         <asp:Label ID="lblTitle" runat="server" CssClass="questionTitle">学生学习风格测试</asp:Label>
    </center>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderContent" Runat="Server">
    <asp:Panel ID="PanelAll" runat="server" Height="829px" ScrollBars="Vertical" Width="753px">
        <table>
          <tr>
            <td align="right" class="style1">
               <asp:Label ID="lblNum1" runat="server" CssClass="question">1.</asp:Label></td>
            <td>
                <asp:Label ID="lblS1" runat="server" CssClass="question"></asp:Label>
                <asp:RequiredFieldValidator ID="rfvS1" runat="server" ControlToValidate="rdolistS1" 
                ErrorMessage="还未完成测试中的第1题！" ForeColor="Red">*</asp:RequiredFieldValidator>
            </td>
          </tr>
          <tr>
            <td class="style1" >
                &nbsp;</td>
            <td>
                <asp:RadioButtonList ID="rdolistS1" runat="server" RepeatDirection="Horizontal" 
                    Width="456px" CssClass="question">
                    <asp:ListItem></asp:ListItem>
                    <asp:ListItem></asp:ListItem>
                </asp:RadioButtonList>
                
            </td>
          </tr>
          <tr>
            <td align="right" class="style1">
               <asp:Label ID="lblNum2" runat="server" CssClass="question">2.</asp:Label></td>
            <td>
                <asp:Label ID="lblS2" runat="server" CssClass="question"></asp:Label>
                <asp:RequiredFieldValidator ID="rfvS2" runat="server" ControlToValidate="rdolistS2" 
                ErrorMessage="还未完成测试中的第2题！" ForeColor="Red">*</asp:RequiredFieldValidator>
            </td>
          </tr>
          <tr>
            <td class="style1" >
                &nbsp;</td>
            <td>
                <asp:RadioButtonList ID="rdolistS2" runat="server" RepeatDirection="Horizontal" 
                    Width="456px" CssClass="question">
                    <asp:ListItem></asp:ListItem>
                    <asp:ListItem></asp:ListItem>
                </asp:RadioButtonList>
            </td>
          </tr>
          <tr>
            <td align="right" class="style1">
               <asp:Label ID="lblNum3" runat="server" CssClass="question">3.</asp:Label></td>
            <td>
                <asp:Label ID="lblS3" runat="server" CssClass="question"></asp:Label>
                <asp:RequiredFieldValidator ID="rfvS3" runat="server" ControlToValidate="rdolistS3" 
                ErrorMessage="还未完成测试中的第3题！" ForeColor="Red">*</asp:RequiredFieldValidator>
            </td>
          </tr>
          <tr>
            <td class="style1" >
                &nbsp;</td>
            <td>
                <asp:RadioButtonList ID="rdolistS3" runat="server" RepeatDirection="Horizontal" 
                    Width="456px" CssClass="question">
                    <asp:ListItem></asp:ListItem>
                    <asp:ListItem></asp:ListItem>
                </asp:RadioButtonList>
            </td>
          </tr>
          <tr>
            <td align="right" class="style1">
               <asp:Label ID="lblNum4" runat="server" CssClass="question">4.</asp:Label></td>
            <td>
                <asp:Label ID="lblS4" runat="server" CssClass="question"></asp:Label>
                <asp:RequiredFieldValidator ID="rfvS4" runat="server" ControlToValidate="rdolistS4" 
                ErrorMessage="还未完成测试中的第4题！" ForeColor="Red">*</asp:RequiredFieldValidator>
            </td>
          </tr>
          <tr>
            <td class="style1" >
                &nbsp;</td>
            <td>
                <asp:RadioButtonList ID="rdolistS4" runat="server" RepeatDirection="Horizontal" 
                    Width="456px" CssClass="question">
                    <asp:ListItem></asp:ListItem>
                    <asp:ListItem></asp:ListItem>
                </asp:RadioButtonList>
            </td>
          </tr>
          <tr>
            <td align="right" class="style1">
               <asp:Label ID="lblNum5" runat="server" CssClass="question">5.</asp:Label></td>
            <td>
                <asp:Label ID="lblS5" runat="server" CssClass="question"></asp:Label>
                <asp:RequiredFieldValidator ID="rfvS5" runat="server" ControlToValidate="rdolistS5" 
                ErrorMessage="还未完成测试中的第5题！" ForeColor="Red">*</asp:RequiredFieldValidator>
            </td>
          </tr>
          <tr>
            <td class="style1" >
                &nbsp;</td>
            <td>
                <asp:RadioButtonList ID="rdolistS5" runat="server" RepeatDirection="Horizontal" 
                    Width="456px" CssClass="question">
                    <asp:ListItem></asp:ListItem>
                    <asp:ListItem></asp:ListItem>
                </asp:RadioButtonList>
            </td>
          </tr>
          <tr>
            <td align="right" class="style1">
               <asp:Label ID="lblNum6" runat="server" CssClass="question">6.</asp:Label></td>
            <td>
                <asp:Label ID="lblS6" runat="server" CssClass="question"></asp:Label>
                <asp:RequiredFieldValidator ID="rfvS6" runat="server" ControlToValidate="rdolistS6" 
                ErrorMessage="还未完成测试中的第6题！" ForeColor="Red">*</asp:RequiredFieldValidator>
            </td>
          </tr>
          <tr>
            <td class="style1" >
                &nbsp;</td>
            <td>
                <asp:RadioButtonList ID="rdolistS6" runat="server" RepeatDirection="Horizontal" 
                    Width="456px" CssClass="question">
                    <asp:ListItem></asp:ListItem>
                    <asp:ListItem></asp:ListItem>
                </asp:RadioButtonList>
            </td>
          </tr>
          <tr>
            <td align="right" class="style1">
               <asp:Label ID="lblNum7" runat="server" CssClass="question">7.</asp:Label></td>
            <td>
                <asp:Label ID="lblS7" runat="server" CssClass="question"></asp:Label>
                <asp:RequiredFieldValidator ID="rfvS7" runat="server" ControlToValidate="rdolistS7" 
                ErrorMessage="还未完成测试中的第7题！" ForeColor="Red">*</asp:RequiredFieldValidator>
            </td>
          </tr>
          <tr>
            <td class="style1" >
                &nbsp;</td>
            <td>
                <asp:RadioButtonList ID="rdolistS7" runat="server" RepeatDirection="Horizontal" 
                    Width="456px" CssClass="question">
                    <asp:ListItem></asp:ListItem>
                    <asp:ListItem></asp:ListItem>
                </asp:RadioButtonList>
            </td>
          </tr>
          <tr>
            <td align="right" class="style1">
               <asp:Label ID="lblNum8" runat="server" CssClass="question">8.</asp:Label></td>
            <td>
                <asp:Label ID="lblS8" runat="server" CssClass="question"></asp:Label>
                <asp:RequiredFieldValidator ID="rfvS8" runat="server" ControlToValidate="rdolistS8" 
                ErrorMessage="还未完成测试中的第8题！" ForeColor="Red">*</asp:RequiredFieldValidator>
            </td>
          </tr>
          <tr>
            <td class="style1" >
                &nbsp;</td>
            <td>
                <asp:RadioButtonList ID="rdolistS8" runat="server" RepeatDirection="Horizontal" 
                    Width="456px" CssClass="question">
                    <asp:ListItem></asp:ListItem>
                    <asp:ListItem></asp:ListItem>
                </asp:RadioButtonList>
            </td>
          </tr>
           <tr>
            <td align="right" class="style1">
               <asp:Label ID="lblNum9" runat="server" CssClass="question">9.</asp:Label></td>
            <td>
                <asp:Label ID="lblS9" runat="server" CssClass="question"></asp:Label>
                <asp:RequiredFieldValidator ID="rfvS9" runat="server" ControlToValidate="rdolistS9" 
                ErrorMessage="还未完成测试中的第9题！" ForeColor="Red">*</asp:RequiredFieldValidator>
            </td>
          </tr>
          <tr>
            <td class="style1" >
                &nbsp;</td>
            <td>
                <asp:RadioButtonList ID="rdolistS9" runat="server" RepeatDirection="Horizontal" 
                    Width="456px" CssClass="question">
                    <asp:ListItem></asp:ListItem>
                    <asp:ListItem></asp:ListItem>
                </asp:RadioButtonList>
            </td>
          </tr>
          <tr>
            <td align="right" class="style1">
               <asp:Label ID="lblNum10" runat="server" CssClass="question">10.</asp:Label></td>
            <td>
                <asp:Label ID="lblS10" runat="server" CssClass="question"></asp:Label>
                <asp:RequiredFieldValidator ID="rfvS10" runat="server" ControlToValidate="rdolistS10" 
                ErrorMessage="还未完成测试中的第10题！" ForeColor="Red">*</asp:RequiredFieldValidator>
            </td>
          </tr>
          <tr>
            <td class="style1" >
                &nbsp;</td>
            <td>
                <asp:RadioButtonList ID="rdolistS10" runat="server" RepeatDirection="Horizontal" 
                    Width="456px" CssClass="question">
                    <asp:ListItem></asp:ListItem>
                    <asp:ListItem></asp:ListItem>
                </asp:RadioButtonList>
            </td>
          </tr>
           <tr>
            <td align="right" class="style1">
               <asp:Label ID="lblNum11" runat="server" CssClass="question">11.</asp:Label></td>
            <td>
                <asp:Label ID="lblS11" runat="server" CssClass="question"></asp:Label>
                <asp:RequiredFieldValidator ID="rfvS11" runat="server" ControlToValidate="rdolistS11" 
                ErrorMessage="还未完成测试中的第11题！" ForeColor="Red">*</asp:RequiredFieldValidator>
            </td>
          </tr>
          <tr>
            <td class="style1" >
                &nbsp;</td>
            <td>
                <asp:RadioButtonList ID="rdolistS11" runat="server" RepeatDirection="Horizontal" 
                    Width="456px" CssClass="question">
                    <asp:ListItem></asp:ListItem>
                    <asp:ListItem></asp:ListItem>
                </asp:RadioButtonList>
            </td>
          </tr>
          <tr>
            <td align="right" class="style1">
               <asp:Label ID="lblNum12" runat="server" CssClass="question">12.</asp:Label></td>
            <td>
                <asp:Label ID="lblS12" runat="server" CssClass="question"></asp:Label>
                <asp:RequiredFieldValidator ID="rfvS12" runat="server" ControlToValidate="rdolistS12" 
                ErrorMessage="还未完成测试中的第12题！" ForeColor="Red">*</asp:RequiredFieldValidator>
            </td>
          </tr>
          <tr>
            <td class="style1" >
                &nbsp;</td>
            <td>
                <asp:RadioButtonList ID="rdolistS12" runat="server" RepeatDirection="Horizontal" 
                    Width="456px" CssClass="question">
                    <asp:ListItem></asp:ListItem>
                    <asp:ListItem></asp:ListItem>
                </asp:RadioButtonList>
            </td>
          </tr>
           <tr>
            <td align="right" class="style1">
               <asp:Label ID="lblNum13" runat="server" CssClass="question">13.</asp:Label></td>
            <td>
                <asp:Label ID="lblS13" runat="server" CssClass="question"></asp:Label>
                <asp:RequiredFieldValidator ID="rfvS13" runat="server" ControlToValidate="rdolistS13" 
                ErrorMessage="还未完成测试中的第13题！" ForeColor="Red">*</asp:RequiredFieldValidator>
            </td>
          </tr>
          <tr>
            <td class="style1" >
                &nbsp;</td>
            <td>
                <asp:RadioButtonList ID="rdolistS13" runat="server" RepeatDirection="Horizontal" 
                    Width="456px" CssClass="question">
                    <asp:ListItem></asp:ListItem>
                    <asp:ListItem></asp:ListItem>
                </asp:RadioButtonList>
            </td>
          </tr>
          <tr>
            <td align="right" class="style1">
               <asp:Label ID="lblNum14" runat="server" CssClass="question">14.</asp:Label></td>
            <td>
                <asp:Label ID="lblS14" runat="server" CssClass="question"></asp:Label>
                <asp:RequiredFieldValidator ID="rfvS14" runat="server" ControlToValidate="rdolistS14" 
                ErrorMessage="还未完成测试中的第14题！" ForeColor="Red">*</asp:RequiredFieldValidator>
            </td>
          </tr>
          <tr>
            <td class="style1" >
                &nbsp;</td>
            <td>
                <asp:RadioButtonList ID="rdolistS14" runat="server" RepeatDirection="Horizontal" 
                    Width="456px" CssClass="question">
                    <asp:ListItem></asp:ListItem>
                    <asp:ListItem></asp:ListItem>
                </asp:RadioButtonList>
            </td>
          </tr>
           <tr>
            <td align="right" class="style1">
               <asp:Label ID="lblNum15" runat="server" CssClass="question">15.</asp:Label></td>
            <td>
                <asp:Label ID="lblS15" runat="server" CssClass="question"></asp:Label>
                <asp:RequiredFieldValidator ID="rfvS15" runat="server" ControlToValidate="rdolistS15" 
                ErrorMessage="还未完成测试中的第15题！" ForeColor="Red">*</asp:RequiredFieldValidator>
            </td>
          </tr>
          <tr>
            <td class="style1" >
                &nbsp;</td>
            <td>
                <asp:RadioButtonList ID="rdolistS15" runat="server" RepeatDirection="Horizontal" 
                    Width="456px" CssClass="question">
                    <asp:ListItem></asp:ListItem>
                    <asp:ListItem></asp:ListItem>
                </asp:RadioButtonList>
            </td>
          </tr>
          <tr>
            <td align="right" class="style1">
               <asp:Label ID="lblNum16" runat="server" CssClass="question">16.</asp:Label></td>
            <td>
                <asp:Label ID="lblS16" runat="server" CssClass="question"></asp:Label>
                <asp:RequiredFieldValidator ID="rfvS16" runat="server" ControlToValidate="rdolistS16" 
                ErrorMessage="还未完成测试中的第16题！" ForeColor="Red">*</asp:RequiredFieldValidator>
            </td>
          </tr>
          <tr>
            <td class="style1" >
                &nbsp;</td>
            <td>
                <asp:RadioButtonList ID="rdolistS16" runat="server" RepeatDirection="Horizontal" 
                    Width="456px" CssClass="question">
                    <asp:ListItem></asp:ListItem>
                    <asp:ListItem></asp:ListItem>
                </asp:RadioButtonList>
            </td>
          </tr>
           <tr>
            <td align="right" class="style1">
               <asp:Label ID="lblNum17" runat="server" CssClass="question">17.</asp:Label></td>
            <td>
                <asp:Label ID="lblS17" runat="server" CssClass="question"></asp:Label>
                <asp:RequiredFieldValidator ID="rfvS17" runat="server" ControlToValidate="rdolistS17" 
                ErrorMessage="还未完成测试中的第17题！" ForeColor="Red">*</asp:RequiredFieldValidator>
            </td>
          </tr>
          <tr>
            <td class="style1" >
                &nbsp;</td>
            <td>
                <asp:RadioButtonList ID="rdolistS17" runat="server" RepeatDirection="Horizontal" 
                    Width="456px" CssClass="question">
                    <asp:ListItem></asp:ListItem>
                    <asp:ListItem></asp:ListItem>
                </asp:RadioButtonList>
            </td>
          </tr>
          <tr>
            <td align="right" class="style1">
               <asp:Label ID="lblNum18" runat="server" CssClass="question">18.</asp:Label></td>
            <td>
                <asp:Label ID="lblS18" runat="server" CssClass="question"></asp:Label>
                <asp:RequiredFieldValidator ID="rfvS18" runat="server" ControlToValidate="rdolistS18" 
                ErrorMessage="还未完成测试中的第18题！" ForeColor="Red">*</asp:RequiredFieldValidator>
            </td>
          </tr>
          <tr>
            <td class="style1" >
                &nbsp;</td>
            <td>
                <asp:RadioButtonList ID="rdolistS18" runat="server" RepeatDirection="Horizontal" 
                    Width="456px" CssClass="question">
                    <asp:ListItem></asp:ListItem>
                    <asp:ListItem></asp:ListItem>
                </asp:RadioButtonList>
            </td>
          </tr>
           <tr>
            <td align="right" class="style1">
               <asp:Label ID="lblNum19" runat="server" CssClass="question">19.</asp:Label></td>
            <td>
                <asp:Label ID="lblS19" runat="server" CssClass="question"></asp:Label>
                <asp:RequiredFieldValidator ID="RrfvS19" runat="server" ControlToValidate="rdolistS19" 
                ErrorMessage="还未完成测试中的第19题！" ForeColor="Red">*</asp:RequiredFieldValidator>
            </td>
          </tr>
          <tr>
            <td class="style1" >
                &nbsp;</td>
            <td>
                <asp:RadioButtonList ID="rdolistS19" runat="server" RepeatDirection="Horizontal" 
                    Width="456px" CssClass="question">
                    <asp:ListItem></asp:ListItem>
                    <asp:ListItem></asp:ListItem>
                </asp:RadioButtonList>
            </td>
          </tr>
          <tr>
            <td align="right" class="style1">
               <asp:Label ID="lblNum20" runat="server" CssClass="question">20.</asp:Label></td>
            <td>
                <asp:Label ID="lblS20" runat="server" CssClass="question"></asp:Label>
                <asp:RequiredFieldValidator ID="rfvS20" runat="server" ControlToValidate="rdolistS20" 
                ErrorMessage="还未完成测试中的第20题！" ForeColor="Red">*</asp:RequiredFieldValidator>
            </td>
          </tr>
          <tr>
            <td class="style1" >
                &nbsp;</td>
            <td>
                <asp:RadioButtonList ID="rdolistS20" runat="server" RepeatDirection="Horizontal" 
                    Width="456px" CssClass="question">
                    <asp:ListItem></asp:ListItem>
                    <asp:ListItem></asp:ListItem>
                </asp:RadioButtonList>
            </td>
          </tr>
           <tr>
            <td align="right" class="style1">
               <asp:Label ID="lblNum21" runat="server" CssClass="question">21.</asp:Label></td>
            <td>
                <asp:Label ID="lblS21" runat="server" CssClass="question"></asp:Label>
                <asp:RequiredFieldValidator ID="rfvS21" runat="server" ControlToValidate="rdolistS21" 
                ErrorMessage="还未完成测试中的第21题！" ForeColor="Red">*</asp:RequiredFieldValidator>
            </td>
          </tr>
          <tr>
            <td class="style1" >
                &nbsp;</td>
            <td>
                <asp:RadioButtonList ID="rdolistS21" runat="server" RepeatDirection="Horizontal" 
                    Width="456px" CssClass="question">
                    <asp:ListItem></asp:ListItem>
                    <asp:ListItem></asp:ListItem>
                </asp:RadioButtonList>
            </td>
          </tr>
          <tr>
            <td align="right" class="style1">
               <asp:Label ID="lblNum22" runat="server" CssClass="question">22.</asp:Label></td>
            <td>
                <asp:Label ID="lblS22" runat="server" CssClass="question"></asp:Label>
                <asp:RequiredFieldValidator ID="rfvS22" runat="server" ControlToValidate="rdolistS22" 
                ErrorMessage="还未完成测试中的第22题！" ForeColor="Red">*</asp:RequiredFieldValidator>
            </td>
          </tr>
          <tr>
            <td class="style1" >
                &nbsp;</td>
            <td>
                <asp:RadioButtonList ID="rdolistS22" runat="server" RepeatDirection="Horizontal" 
                    Width="456px" CssClass="question">
                    <asp:ListItem></asp:ListItem>
                    <asp:ListItem></asp:ListItem>
                </asp:RadioButtonList>
            </td>
          </tr>
        </table>
        
 </asp:Panel>
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
                    <uc1:studentcontrol ID="infotree1" runat="server" />
                </td>
            </tr>
        </table>
    
    </center>
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="ContentPlaceHolderCBottom" Runat="Server">
    <center>
        
       <asp:Button ID="btnSubmit" runat="server" Text="提交" Height="30px" 
                    Width="50px"  Font-Names="微软雅黑" 
                    Font-Size="Medium" onclick="btnSubmit_Click" />
    
        <asp:Panel ID="Panel1" runat="server" Visible=false>
            <input type="button" value="测试结果" onclick="openWinCenter()" id="btnpic" runat="server" 
            style="border-style: double; font-family: 微软雅黑; font-size: large; color: #009933; width: 109px; height: 30px;" />
        </asp:Panel>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ShowMessageBox="true" ShowSummary="false" />
    </center>
</asp:Content>

