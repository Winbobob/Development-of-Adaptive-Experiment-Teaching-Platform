<%@ Page Language="C#" MasterPageFile="~/StudyData/StudyDataMasterPage.master" AutoEventWireup="true" CodeFile="StudyDataText4.aspx.cs" Inherits="StudyData_StudyDataText4" Title="无标题页" %>

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
        .style2
        {
            font-family: 微软雅黑;
            color: #000000;
            font-size: medium;
            width: 249px;
        }
         .style3
        {
            font-family: 微软雅黑;
            color: #000000;
            font-size:15px;
        }
                 .style4
        {
            font-family: 微软雅黑;
            color:#6B8E23;
            font-size:large;
        }
                
</style>

<!-- GreyBox引用开始 --> 
<script type="text/javascript">
    var GB_ROOT_DIR = "../greybox/"; //注意这里的路径！！！ 
</script> 
<script type="text/javascript" src="../greybox/AJS.js"></script> 
<script type="text/javascript" src="../greybox/AJS_fx.js"></script> 
<script type="text/javascript" src="../greybox/gb_scripts.js"></script> 
<link href="../greybox/gb_styles.css" rel="stylesheet" type="text/css" /> 
<!-- GreyBox引用结束 --> 
<script type="text/javascript">
    //居中弹出模态窗口 
    function openWinCenter() {
        //GB_showCenter(caption, url, /* optional */ height, width, callback_fn) 
        GB_showCenter("知识点4例题（文字型）", "../example/exampleText4.aspx", 350, 630);
    }
</script> 

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderTop" Runat="Server">
<table style="width: 761px"><tr><td colspan= "3">
        <asp:Label ID="lblsug" runat="server" CssClass="bottomtext2"></asp:Label>
        </td>
        <td align="right"><asp:LinkButton ID="LinkButton2" runat="server" CssClass="bottomtext" PostBackUrl="StudyDataDefault.aspx">操作说明</asp:LinkButton></td>
   <td align="right"><asp:LinkButton ID="LinkButton1" runat="server" CssClass="bottomtext" PostBackUrl="../StudentDefault.aspx">返回</asp:LinkButton></td></tr>
    <tr><td class="style2">如需更换学习方式，请手动更改：</td>
        <td class="bottomtext"><asp:RadioButtonList ID="rbl1" runat="server"  RepeatDirection="Horizontal">
          <asp:ListItem Text="文字" Value="0"></asp:ListItem>
          <asp:ListItem Text="图片" Value="1"></asp:ListItem>
          <asp:ListItem Text="视频" Value="2"></asp:ListItem>
       </asp:RadioButtonList></td>
       <td class="bottomtext"><asp:Button ID="btnOK" runat="server" Text="确定" 
               CssClass="bottomtext" onclick="btnOK_Click" /></td>
       <td></td><td>&nbsp;</td>
    </tr></table>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderInformation" Runat="Server">
<table width="100%">
            <tr>
              <td rowspan="4"  valign="top" >
            <asp:Image ID="imgphoto" runat="server"  width="99px" height="133px" />
        </td>
              <td class="bottomtext">姓名:<br />
              <asp:Label ID="lblstuName" runat="server" ></asp:Label></td>
            </tr>
            <tr>
              <td class="bottomtext">学习风格:<br /><asp:Label ID="lblstyle" runat="server" ></asp:Label></td>
            </tr>
            <tr>
              <td class="bottomtext">学习方式:<br /><asp:Label ID="lbldata" runat="server" ></asp:Label></td>
            </tr>
            
    </table>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolderLeft" Runat="Server">
<table>
     <tr><td>
         <asp:ImageButton ID="ImageButton1" runat="server" 
             ImageUrl="~/images/studydata_03.gif" onclick="ImageButton1_Click" /></td></tr><tr><td>
           <br />
           </td></tr>
              <tr><td>
         <asp:ImageButton ID="ImageButton2" runat="server" 
             ImageUrl="~/images/studydata_06.gif" onclick="ImageButton2_Click" /></td></tr><tr><td>
           <br />
           </td></tr>
              <tr><td>
         <asp:ImageButton ID="ImageButton3" runat="server" 
             ImageUrl="~/images/studydata_09.gif" onclick="ImageButton3_Click" /></td></tr><tr><td>
           <br />
           </td></tr>
              <tr><td>
         <asp:ImageButton ID="ImageButton4" runat="server" 
             ImageUrl="~/images/studydata_11.gif" onclick="ImageButton4_Click" /></td></tr><tr><td>
           <br />
           </td></tr>
              <tr><td>
         <asp:ImageButton ID="ImageButton5" runat="server" 
             ImageUrl="~/images/studydata_13.gif" onclick="ImageButton5_Click" /></td></tr><tr><td>
           <br />
           </td></tr>
    </table>
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="ContentPlaceHolderContent" Runat="Server">
<asp:Panel ID="PanelAll" runat="server"  ScrollBars="Vertical"  Height="820px">
  <h3 align="center" style="font-family: 微软雅黑; font-size: 16pt; color: #006600">知识点4：this对象引用</h3>
  <p class="style3">
This关键字在类中使用，是对当前实例的引用。它只能被用在下列类成员的代码块中：<br />
(1)实例构造函数<br />
(2)实例方法<br />
(3)属性和索引的实例访问器<br />
很明显，因为静态成员不是实例的一部分，所以不能在任何静态函数成员的代码中使用this关键字。<br />
This被用于下列目的：<br />
(1)用于区分类的成员和本地变量，或参数。<br />
(2)作为调用方法的实参。
  </p>
  </asp:Panel>
  
<center>
<input type="button" value="例题精解" onclick="openWinCenter()" style="border-style: double; font-family: 微软雅黑; font-size: large; color: #009933; width: 135px;" />
</center>
 
</asp:Content>



