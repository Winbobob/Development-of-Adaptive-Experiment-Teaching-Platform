﻿<%@ Page Language="C#" MasterPageFile="~/StudyData/StudyDataMasterPage.master" AutoEventWireup="true" CodeFile="StudyDataVideo5.aspx.cs" Inherits="StudyData_StudyDataVideo5" Title="无标题页" %>

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
        GB_showCenter("知识点5例题（文字型）", "../example/exampleText5.aspx", 350, 630);
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
              <td rowspan="4" valign="top" >
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
     <h3 align="center" style="font-family: 微软雅黑; font-size: 16pt; color: #006600">
         知识点5：常用类型</h3>
     <asp:Label ID="Label1" runat="server" CssClass="style3"  Text="请选择相应的章节按钮观看视频："></asp:Label><br /><br />

	 <asp:HyperLink ID="HyperLink1" runat="server" BackColor="#CCCCCC" 
            Font-Size="X-Large" ForeColor="Black" NavigateUrl="~/StudyData/StudyDataVideo5.aspx?videonum=5.1">5.1数据类型的自动转换</asp:HyperLink>
       &nbsp;&nbsp;
       <asp:HyperLink ID="HyperLink2" runat="server" BackColor="#CCCCCC" 
            Font-Size="X-Large" ForeColor="Black" NavigateUrl="~/StudyData/StudyDataVideo5.aspx?videonum=5.2">5.2类型转换</asp:HyperLink>
       &nbsp;&nbsp;
       <asp:HyperLink ID="HyperLink3" runat="server" BackColor="#CCCCCC" 
            Font-Size="X-Large" ForeColor="Black" NavigateUrl="~/StudyData/StudyDataVideo5.aspx?videonum=5.3">5.3复习-数据类型转换</asp:HyperLink>

       <br /><br />
       <center>
       <!-- flashplayer代码开始 -->
            <script type="text/javascript" src="../DataVideo/images/swfobject.js"></script>
            <div id="CuPlayer">
            <strong>提示：您的Flash Player版本过低，请进行Flash播放器升级！</strong></div>
            <script type="text/javascript">
 
            function get_url() 
                { 
                    var src = window.location.href;
                    if(src != "")
                    {
                        var url = src.substr(src.indexOf("?") + 10, 3);
                    } 
                    return url; 
                }

            var name = get_url();
            
            var so = new SWFObject("../DataVideo/CuPlayerMiniV4.swf","CuPlayerV4","600","410","9","#000000");
            so.addParam("allowfullscreen","true");
            so.addParam("allowscriptaccess","always");
            so.addParam("wmode","opaque");
            so.addParam("quality","high");
            so.addParam("salign","lt");
            
            var path = "../DataVideo/" + name + ".xml";
            
            so.addVariable("CuPlayerSetFile",path); //播放器配置文件地址,例SetFile.xml、SetFile.asp、SetFile.php、SetFile.aspx

            so.addVariable("CuPlayerImage","../DataVideo/images/start.jpg");//视频略缩图,本图片文件必须正确
            so.addVariable("CuPlayerWidth","600"); //视频宽度
            so.addVariable("CuPlayerHeight","410"); //视频高度
            so.addVariable("CuPlayerAutoPlay","no"); //是否自动播放
            so.addVariable("CuPlayerLogo","../DataVideo/images/logo.png"); //Logo文件地址
            so.addVariable("CuPlayerPosition","top-right"); //Logo显示的位置
            so.write("CuPlayer");
            </script>
            <!-- flashplayer代码结束 -->
       </center>

   </asp:Panel>


<center>
<input type="button" value="例题精解" onclick="openWinCenter()" style="border-style: double; font-family: 微软雅黑; font-size: large; color: #009933; width: 135px;" />
</center>
 
</asp:Content>

