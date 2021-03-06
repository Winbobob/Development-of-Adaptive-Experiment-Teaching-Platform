﻿<%@ Page Language="C#" MasterPageFile="~/StudentMasterPage.master" AutoEventWireup="true" CodeFile="ExerciseMid.aspx.cs" Inherits="ExerciseMid" Title="中级练习题" %>
<%@ Register src="StudentControl.ascx" tagname="StudentControl" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
<style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style2
        {
            width: 30px;
        }
        .style3
        {
            width: 278px;
        }
        .answer
        {
            font-family: 微软雅黑;
            color: #FF0000;
        }
        .question
        {
            font-family: 微软雅黑;
            color: #003300;
        }
        .explain
        {
            font-family: 微软雅黑;
            color: #000000;
        }
        .title
        {
            font-family: 微软雅黑;
            color: #800000;
            font-size:larger;
        }
        .qFront
        {
            font-family: 微软雅黑;
            color: #003300;
        }
        .qBack
        {
            font-family: 微软雅黑;
            color: #003300;
        }
        .titleLow
        {
            font-family: 微软雅黑;
            color: #800000;
            font-size:x-large;
        }
        .style8
        {
            width: 268px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderCTop" Runat="Server">
<center>
    <asp:Label ID="lblTitle" runat="server" CssClass="titleLow">中级练习题</asp:Label>
    </center>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderContent" Runat="Server">
<asp:Panel ID="PanelAll" runat="server" Height="829px" ScrollBars="Vertical" 
       Width="753px">
    <table class="style1">
          <tr>
          <td class="style2">
              <asp:Label ID="Label5" runat="server" CssClass="title">一、</asp:Label></td>
            <td colspan="5"><asp:Label ID="Label1" runat="server" CssClass="title">单选题</asp:Label>
           </td>
          </tr>
        <tr>
            <td class="style2" align="right" valign="top">
               <asp:Label ID="lblNum1" runat="server" CssClass="question">1.</asp:Label></td>
            <td colspan="4">
                <asp:Label ID="lblS1" runat="server" CssClass="question"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                &nbsp;</td>
            <td colspan="4" valign="top">
                <asp:RadioButtonList ID="rdolistS1" runat="server" RepeatDirection="Horizontal" 
                    Width="456px" CssClass="question">
                    <asp:ListItem></asp:ListItem>
                    <asp:ListItem></asp:ListItem>
                    <asp:ListItem></asp:ListItem>
                    <asp:ListItem></asp:ListItem>
                </asp:RadioButtonList>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                &nbsp;</td>
            <td class="style8">
                <asp:Label ID="lblS1A" runat="server" CssClass="answer"></asp:Label>
            </td>
            <td align="right">
                <asp:Button ID="btnS1E" runat="server" Text="解析" BorderStyle="None" 
                    onclick="btnS1E_Click" Visible="False" Font-Names="微软雅黑" />
            </td>
            <td colspan="2">
                <asp:Label ID="lblS1E" runat="server" CssClass="explain"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2"align="right" valign="top">
               <asp:Label ID="lblNum2" runat="server" CssClass="question">2.</asp:Label></td>
            <td colspan="4">
                <asp:Label ID="lblS2" runat="server" CssClass="question"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                &nbsp;</td>
            <td colspan="4" valign="top">
                <asp:RadioButtonList ID="rdolistS2" runat="server" RepeatDirection="Horizontal" 
                    Width="456px" CssClass="question">
                    <asp:ListItem></asp:ListItem>
                    <asp:ListItem></asp:ListItem>
                    <asp:ListItem></asp:ListItem>
                    <asp:ListItem></asp:ListItem>
                </asp:RadioButtonList>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                &nbsp;</td>
            <td class="style8">
                <asp:Label ID="lblS2A" runat="server" CssClass="answer"></asp:Label>
            </td>
            <td align="right">
                <asp:Button ID="btnS2E" runat="server" Text="解析" BorderStyle="None" 
                     Visible="False" onclick="btnS2E_Click" Font-Names="微软雅黑" />
            </td>
            <td colspan="2">
                <asp:Label ID="lblS2E" runat="server" CssClass="explain"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2" align="right" valign="top">
               <asp:Label ID="lblNum3" runat="server" CssClass="question">3.</asp:Label></td>
            <td colspan="4">
                <asp:Label ID="lblS3" runat="server" CssClass="question"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                &nbsp;</td>
            <td colspan="4" valign="top">
                <asp:RadioButtonList ID="rdolistS3" runat="server" RepeatDirection="Horizontal" 
                    Width="456px" CssClass="question">
                    <asp:ListItem></asp:ListItem>
                    <asp:ListItem></asp:ListItem>
                    <asp:ListItem></asp:ListItem>
                    <asp:ListItem></asp:ListItem>
                </asp:RadioButtonList>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                &nbsp;</td>
            <td class="style8">
                <asp:Label ID="lblS3A" runat="server" CssClass="answer"></asp:Label>
            </td>
            <td align="right">
                <asp:Button ID="btnS3E" runat="server" Text="解析" BorderStyle="None" 
                    Visible="False" onclick="btnS3E_Click" Font-Names="微软雅黑" />
            </td>
            <td colspan="2">
                <asp:Label ID="lblS3E" runat="server" CssClass="explain"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2" align="right" valign="top">
               <asp:Label ID="lblNum4" runat="server" CssClass="question">4.</asp:Label></td>
            <td colspan="4">
                <asp:Label ID="lblS4" runat="server" CssClass="question"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                &nbsp;</td>
            <td colspan="4" valign="top">
                <asp:RadioButtonList ID="rdolistS4" runat="server" RepeatDirection="Horizontal" 
                    Width="456px" CssClass="question">
                    <asp:ListItem></asp:ListItem>
                    <asp:ListItem></asp:ListItem>
                    <asp:ListItem></asp:ListItem>
                    <asp:ListItem></asp:ListItem>
                </asp:RadioButtonList>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                &nbsp;</td>
            <td class="style8">
                <asp:Label ID="lblS4A" runat="server" CssClass="answer"></asp:Label>
            </td>
            <td align="right">
                <asp:Button ID="btnS4E" runat="server" Text="解析" BorderStyle="None" 
                    onclick="btnS4E_Click" Visible="False" Font-Names="微软雅黑" />
            </td>
            <td colspan="2">
                <asp:Label ID="lblS4E" runat="server" CssClass="explain"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
         <tr>
            <td class="style2" align="right" valign="top">
               <asp:Label ID="lblNum5" runat="server" CssClass="question">5.</asp:Label></td>
            <td colspan="4">
                <asp:Label ID="lblS5" runat="server" CssClass="question"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                &nbsp;</td>
            <td colspan="4" valign="top">
                <asp:RadioButtonList ID="rdolistS5" runat="server" RepeatDirection="Horizontal" 
                    Width="456px" CssClass="question">
                    <asp:ListItem></asp:ListItem>
                    <asp:ListItem></asp:ListItem>
                    <asp:ListItem></asp:ListItem>
                    <asp:ListItem></asp:ListItem>
                </asp:RadioButtonList>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                &nbsp;</td>
            <td class="style8">
                <asp:Label ID="lblS5A" runat="server" CssClass="answer"></asp:Label>
            </td>
            <td align="right">
                <asp:Button ID="btnS5E" runat="server" Text="解析" BorderStyle="None" 
                    onclick="btnS5E_Click" Visible="False" Font-Names="微软雅黑" />
            </td>
            <td colspan="2">
                <asp:Label ID="lblS5E" runat="server" CssClass="explain"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
          <td class="style2">
              <asp:Label ID="Label6" runat="server" CssClass="title">二、</asp:Label></td>
            <td colspan="5"><asp:Label ID="Label2" runat="server" CssClass="title">判断题</asp:Label>
           </td>
          </tr>
        <tr>
            <td class="style2" align="right" valign="top">
               <asp:Label ID="lblNum11" runat="server" CssClass="question">1.</asp:Label>
              </td>
            <td colspan="4">
                <asp:Label ID="lblJ1" runat="server" CssClass="question"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        
        <tr>
            <td class="style2">&nbsp;</td>
            <td colspan="4"  valign="top">
                <asp:RadioButtonList ID="rdolistJ1" runat="server" RepeatDirection="Horizontal" 
                    Width="230px" CssClass="question">
                    <asp:ListItem></asp:ListItem>
                    <asp:ListItem></asp:ListItem>
                </asp:RadioButtonList>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                &nbsp;</td>
            <td class="style8">
                <asp:Label ID="lblJ1A" runat="server" CssClass="answer"></asp:Label>
            </td>
            <td align="right">
                <asp:Button ID="btnJ1E" runat="server" Text="解析" BorderStyle="None" 
                     Visible="False" onclick="btnJ1E_Click" Font-Names="微软雅黑" />
            </td>
            <td colspan="2">
                <asp:Label ID="lblJ1E" runat="server" CssClass="explain"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2" align="right"  valign="top">
               <asp:Label ID="lblNum12" runat="server" CssClass="question">2.</asp:Label></td>
               
            <td colspan="4">
                <asp:Label ID="lblJ2" runat="server" CssClass="question"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2" >&nbsp;</td>
            <td colspan="2"  valign="top">
                <asp:RadioButtonList ID="rdolistJ2" runat="server" RepeatDirection="Horizontal" 
                    Width="230px" CssClass="question">
                    <asp:ListItem></asp:ListItem>
                    <asp:ListItem></asp:ListItem>
                </asp:RadioButtonList>
            </td>
            <td>
                &nbsp;</td>
            <td class="style3">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                &nbsp;</td>
            <td class="style8">
                <asp:Label ID="lblJ2A" runat="server" CssClass="answer"></asp:Label>
            </td>
            <td align="right">
                <asp:Button ID="btnJ2E" runat="server" Text="解析" BorderStyle="None" 
                     Visible="False" onclick="btnJ2E_Click" Font-Names="微软雅黑" />
            </td>
            <td colspan="2">
                <asp:Label ID="lblJ2E" runat="server" CssClass="explain"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2" align="right"  valign="top">
               <asp:Label ID="lblNum13" runat="server" CssClass="question">3.</asp:Label></td>
               
            <td colspan="4">
                <asp:Label ID="lblJ3" runat="server" CssClass="question"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2" >&nbsp;</td>
            <td colspan="2"  valign="top">
                <asp:RadioButtonList ID="rdolistJ3" runat="server" RepeatDirection="Horizontal" 
                    Width="230px" CssClass="question">
                    <asp:ListItem></asp:ListItem>
                    <asp:ListItem></asp:ListItem>
                </asp:RadioButtonList>
            </td>
            <td>
                &nbsp;</td>
            <td class="style3">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                &nbsp;</td>
            <td class="style8">
                <asp:Label ID="lblJ3A" runat="server" CssClass="answer"></asp:Label>
            </td>
            <td align="right">
                <asp:Button ID="btnJ3E" runat="server" Text="解析" BorderStyle="None" 
                     Visible="False" onclick="btnJ3E_Click" 
                    Font-Names="微软雅黑" />
            </td>
            <td colspan="2">
                <asp:Label ID="lblJ3E" runat="server" CssClass="explain"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2" align="right"  valign="top">
               <asp:Label ID="lblNum14" runat="server" CssClass="question">4.</asp:Label></td>
                
            <td colspan="4">
                <asp:Label ID="lblJ4" runat="server" CssClass="question"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">&nbsp;</td>
            <td colspan="4"  valign="top">
                <asp:RadioButtonList ID="rdolistJ4" runat="server" RepeatDirection="Horizontal" 
                    Width="230px" CssClass="question">
                    <asp:ListItem></asp:ListItem>
                    <asp:ListItem></asp:ListItem>
                </asp:RadioButtonList>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                &nbsp;</td>
            <td class="style8">
                <asp:Label ID="lblJ4A" runat="server" CssClass="answer"></asp:Label>
            </td>
            <td align="right">
                <asp:Button ID="btnJ4E" runat="server" Text="解析" BorderStyle="None" 
                     Visible="False" onclick="btnJ4E_Click" Font-Names="微软雅黑" />
            </td>
            <td colspan="2">
                <asp:Label ID="lblJ4E" runat="server" CssClass="explain"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr> 
        <tr>
          <td class="style2">
               <asp:Label ID="Label7" runat="server" CssClass="title">三、</asp:Label></td>
            <td colspan="5"><asp:Label ID="Label3" runat="server" CssClass="title">填空题</asp:Label>
           </td>
          </tr>  
        <tr>
            <td class="style2" align="right" valign="top">
               <asp:Label ID="lblNum21" runat="server" CssClass="question">1.</asp:Label></td>
            <td colspan="4">
                <asp:Label ID="lblB1" runat="server" CssClass="qFront"></asp:Label>_______
                <asp:Label ID="lblB12" runat="server" CssClass="qBack"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2"align="right" valign="top">
               <asp:Label ID="lblNum22" runat="server" CssClass="question">2.</asp:Label></td>
            <td colspan="4">     
                <asp:Label ID="lblB2" runat="server" CssClass="qFront"></asp:Label>_______
                <asp:Label ID="lblB22" runat="server" CssClass="qBack"></asp:Label>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2"align="right" valign="top">
               <asp:Label ID="lblNum23" runat="server" CssClass="question">3.</asp:Label></td>
            <td colspan="4">
                <asp:Label ID="lblB3" runat="server" CssClass="qFront"></asp:Label>_______
                <asp:Label ID="lblB32" runat="server" CssClass="qBack"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
         <tr>
            <td class="style2">
                &nbsp;</td>
            <td colspan="4">
                <asp:Label ID="lblB11" runat="server" CssClass="question">(1)</asp:Label>
                <asp:TextBox ID="txtB11" runat="server" style="margin-left: 0px" 
                    CssClass="qFront"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                &nbsp;</td>
            <td class="style8">
                <asp:Label ID="lblB11A" runat="server" CssClass="answer"></asp:Label>
            </td>
            <td align="right">
                <asp:Button ID="btnB11E" runat="server" Text="解析" BorderStyle="None" 
                     Visible="False" onclick="btnB11E_Click" Font-Names="微软雅黑" />
            </td>
            <td colspan="2">
                <asp:Label ID="lblB11E" runat="server" CssClass="explain"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                &nbsp;</td>
            <td colspan="4">
                <asp:Label ID="lblB21" runat="server" CssClass="question">(2)</asp:Label>
                <asp:TextBox ID="txtB21" runat="server" style="margin-left: 0px" 
                    CssClass="qFront"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
         <tr>
            <td class="style2">
                &nbsp;</td>
            <td class="style8">
                <asp:Label ID="lblB21A" runat="server" CssClass="answer"></asp:Label>
            </td>
            <td align="right">
                <asp:Button ID="btnB21E" runat="server" Text="解析" BorderStyle="None" 
                     Visible="False" onclick="btnB21E_Click" Font-Names="微软雅黑" />
            </td>
            <td colspan="2">
                <asp:Label ID="lblB21E" runat="server" CssClass="explain"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                &nbsp;</td>
            <td colspan="4">
                <asp:Label ID="lblB31" runat="server" CssClass="question">(3)</asp:Label>
                <asp:TextBox ID="txtB31" runat="server" style="margin-left: 0px" 
                    CssClass="qFront"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                &nbsp;</td>
            <td class="style8">
                <asp:Label ID="lblB31A" runat="server" CssClass="answer"></asp:Label>
            </td>
            <td align="right">
                <asp:Button ID="btnB31E" runat="server" Text="解析" BorderStyle="None" 
                     Visible="False" onclick="btnB31E_Click" Font-Names="微软雅黑" />
            </td>
            <td colspan="2">
                <asp:Label ID="lblB31E" runat="server" CssClass="explain"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
            
        <tr>
          <td class="style2">
               <asp:Label ID="Label8" runat="server" CssClass="title">四、</asp:Label></td>
            <td colspan="5"><asp:Label ID="Label4" runat="server" CssClass="title">设计题</asp:Label>
           </td>
          </tr>  
        <tr>
            <td class="style2"align="right" valign="top">
               <asp:Label ID="lblNum41" runat="server" CssClass="question">1.</asp:Label></td>
            <td colspan="4">
                <asp:Label ID="lblD1" runat="server" CssClass="question"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
       <tr>
          <td class="style2">
                &nbsp;</td>
            <td colspan="5"><asp:TextBox ID="TextBox1" runat="server" TextMode="MultiLine" Height="69px" Width="463px"></asp:TextBox>
            <asp:Button ID="btnanswer" runat="server" Text="答案下载" BorderStyle="None" Visible="False" onclick="btnanswer_Click" Font-Names="微软雅黑"  ForeColor="Red" />
           </td>
       </tr>  
    </table>
    </asp:Panel>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolderUnit" Runat="Server">
<center>
        <table class="style1">
            <tr>
                <td class="style2">
                    </td>
            </tr>
            <tr>
                <td align="center">
                    <uc1:studentcontrol ID="infotree1" runat="server" />
                </td>
            </tr>
        </table>
    
    </center>
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="ContentPlaceHolderCBottom" Runat="Server">
<center>
  <asp:Button ID="btnOk" runat="server" Text="确定"  Height="30px" 
                    Width="50px" Font-Names="微软雅黑" 
        Font-Size="Medium" onclick="btnOk_Click" />
  </center>
</asp:Content>

