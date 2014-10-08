<%@ Page Language="C#" AutoEventWireup="true" CodeFile="exampleText5.aspx.cs" Inherits="example_exampleText5" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>知识点5例题（文字）</title>
    <META http-equiv=Content-Type content="text/html; charset=gb2312">
<STYLE type=text/css>BODY {
	FONT-SIZE: 14px;font-family: 微软雅黑;
}
OL LI {
	MARGIN: 10px
}
#con {
	FONT-SIZE: 12px; MARGIN: 0px auto; WIDTH: 600px
}
#tags {
	PADDING-RIGHT: 0px; PADDING-LEFT: 0px; PADDING-BOTTOM: 0px; MARGIN: 0px 0px 0px 10px; WIDTH: 400px; PADDING-TOP: 0px; HEIGHT: 23px
}
#tags LI {
	BACKGROUND: url(../images/tagleft.gif) no-repeat left bottom; FLOAT: left; MARGIN-RIGHT: 1px; LIST-STYLE-TYPE: none; HEIGHT: 23px
}
#tags LI A {
	PADDING-RIGHT: 10px; PADDING-LEFT: 10px; BACKGROUND: url(../images/tagright.gif) no-repeat right bottom; FLOAT: left; PADDING-BOTTOM: 0px; COLOR: #999; LINE-HEIGHT: 23px; PADDING-TOP: 0px; HEIGHT: 23px; TEXT-DECORATION: none
}
#tags LI.emptyTag {
	BACKGROUND: none transparent scroll repeat 0% 0%; WIDTH: 4px
}
#tags LI.selectTag {
	BACKGROUND-POSITION: left top; MARGIN-BOTTOM: -2px; POSITION: relative; HEIGHT: 25px
}
#tags LI.selectTag A {
	BACKGROUND-POSITION: right top; COLOR: #000; LINE-HEIGHT: 25px; HEIGHT: 25px
}
#tagContent {
	BORDER-RIGHT: #aecbd4 1px solid; PADDING-RIGHT: 1px; BORDER-TOP: #aecbd4 1px solid; PADDING-LEFT: 1px; PADDING-BOTTOM: 1px; BORDER-LEFT: #aecbd4 1px solid; PADDING-TOP: 1px; BORDER-BOTTOM: #aecbd4 1px solid; BACKGROUND-COLOR: #fff
}
.tagContent {
	PADDING-RIGHT: 10px; DISPLAY: none; PADDING-LEFT: 10px; BACKGROUND: url(../images/bg.gif) repeat-x; PADDING-BOTTOM: 10px; WIDTH: 576px; COLOR: #474747; PADDING-TOP: 10px; HEIGHT: 250px
}
#tagContent DIV.selectTag {
	DISPLAY: block
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
            color: #006600;
            font-size:17px;
        }
</STYLE>
<META content="MSHTML 6.00.2800.1589" name=GENERATOR>
</head>
<body>
<center><asp:Label ID="lbllevel" runat="server" Text="" CssClass="style4"></asp:Label></center>
     <DIV id=con>
<UL id=tags>
  <LI  class=selectTag><A onClick="selectTag('tagContent0',this)" 
  href="javascript:void(0)">例题（初级）</A> </LI>
  <LI><A onClick="selectTag('tagContent1',this)" 
  href="javascript:void(0)">例题（中级）</A> </LI>
  <LI><A onClick="selectTag('tagContent2',this)" 
  href="javascript:void(0)">例题（高级）</A> </LI></UL>
<DIV id=tagContent>
<DIV class="tagContent selectTag"  id=tagContent0>
          <asp:Panel ID="Panel1" runat="server"  ScrollBars="Vertical"  Height="250px">
        <p class="style3">
举例：冒泡排序：<br />
<asp:Image ID="Image11" runat="server"   ImageUrl="~/DataImage/5.19.jpg"  /><br />
<asp:Image ID="Image14" runat="server"   ImageUrl="~/DataImage/5.20.jpg"  />
  </p>
     </asp:Panel>
</DIV>
<DIV class=tagContent id=tagContent1>
           <asp:Panel ID="Panel2" runat="server"  ScrollBars="Vertical"  Height="250px">
           <p class="style3">
  例题：<br />
<asp:Image ID="Image1" runat="server"   ImageUrl="~/DataImage/5.21.jpg"  /><br />
<asp:Image ID="Image2" runat="server"   ImageUrl="~/DataImage/5.22.jpg"  /><br />
<asp:Image ID="Image3" runat="server"   ImageUrl="~/DataImage/5.23.jpg"  /><br />
<asp:Image ID="Image4" runat="server"   ImageUrl="~/DataImage/5.24.jpg"  /><br />
<asp:Image ID="Image5" runat="server"   ImageUrl="~/DataImage/5.25.jpg"  />
  </p>
       </asp:Panel>
</DIV>
<DIV class=tagContent id=tagContent2>
         <asp:Panel ID="Panel3" runat="server"  ScrollBars="Vertical"  Height="250px">
        <p class="style3">
综合应用：<br />
<asp:Image ID="Image19" runat="server"   ImageUrl="~/DataImage/5.26.jpg"  />
  </p>
       </asp:Panel>
</DIV></DIV></DIV>
<p>
  <SCRIPT type=text/javascript>
      function selectTag(showContent, selfObj) {
          // 操作标签
          var tag = document.getElementById("tags").getElementsByTagName("li");
          var taglength = tag.length;
          for (i = 0; i < taglength; i++) {
              tag[i].className = "";
          }
          selfObj.parentNode.className = "selectTag";
          // 操作内容
          for (i = 0; j = document.getElementById("tagContent" + i); i++) {
              j.style.display = "none";
          }
          document.getElementById(showContent).style.display = "block";


      }
</SCRIPT>
</p>
</body>
</html>
