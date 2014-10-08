<%@ Page Language="C#" AutoEventWireup="true" CodeFile="examplePicture1.aspx.cs" Inherits="example_examplePicture1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>知识点1例题（图片）</title>
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
  <LI class=selectTag><A onClick="selectTag('tagContent0',this)" 
  href="javascript:void(0)">例题（初级）</A> </LI>
  <LI><A onClick="selectTag('tagContent1',this)" 
  href="javascript:void(0)">例题（中级）</A> </LI>
  <LI><A onClick="selectTag('tagContent2',this)" 
  href="javascript:void(0)">例题（高级）</A> </LI></UL>
<DIV id=tagContent>
<DIV class="tagContent selectTag" id=tagContent0>
    <asp:Panel ID="Panel1" runat="server"  ScrollBars="Vertical"  Height="250px">
	       <p class="style3">
	         有关成员访问限制的案例分析：<br />(1)<br /><asp:Image ID="Image20" runat="server"   ImageUrl="~/DataImage/1.20.jpg"  /><br />
	    以上程序错误！Private是私有的，不允许外部对象访问该成员。<br /><br />
	     (2)<br /><asp:Image ID="Image21" runat="server"   ImageUrl="~/DataImage/1.21.jpg"  /><br />
	      以上程序错误！Protected是受保护的，只允许当前类及其派生类的对象访问该成员，而不允许其他外部对象访问。<br /><br />
	    (3)<br /><asp:Image ID="Image22" runat="server"   ImageUrl="~/DataImage/1.22.jpg"  /><br />
	     以上程序正确！Public是共有的，用于类型和成员访问限制，修饰成员时表示允许外部对象访问该成员，修饰类型时表示允许外部程序集使用该类型。
	       </p>
         </asp:Panel>   
</DIV>
<DIV class=tagContent id=tagContent1>
       <asp:Panel ID="Panel2" runat="server"  ScrollBars="Vertical"  Height="250px">
          <p class="style3">如何不公开E-mail地址发邮件？<br />
        <asp:Image ID="Image10" runat="server"   ImageUrl="~/DataImage/1.10.jpg"  /><br />
        <asp:Image ID="Image11" runat="server"   ImageUrl="~/DataImage/1.11.jpg"  /><br />
        <p class="style3"> 解题：看下面的父类代码Student示例:<br />
      <asp:Image ID="Image16" runat="server"   ImageUrl="~/DataImage/1.16.jpg"  /><br />
<asp:Image ID="Image12" runat="server"   ImageUrl="~/DataImage/1.12.jpg"  /><br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 如果Student还有一个派生类Graduate，该类的另一个方法Register中也要使用到E-mail地址，那就应当将Student中email字段的修饰符由pritrate改为protected，否则下面的代码就是不合法的:<br />
<asp:Image ID="Image17" runat="server"   ImageUrl="~/DataImage/1.17.jpg"  /> 
         </p>
          </asp:Panel>
</DIV>
<DIV class=tagContent id=tagContent2>
      <asp:Panel ID="Panel3" runat="server"  ScrollBars="Vertical"  Height="250px">
             <p class="style3">
         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
           下面的程序就为Student类定义了静态字段School和静态方法WriteSchoolInfo，而另一个静态方法WritePersonalInfo则同时使用到了类的静态字段和非静态字段：<br />
         <asp:Image ID="Image18" runat="server"   ImageUrl="~/DataImage/1.18.jpg"  /><br />
         <asp:Image ID="Image19" runat="server"   ImageUrl="~/DataImage/1.19.jpg"  /><br />
        <asp:Image ID="Image13" runat="server"   ImageUrl="~/DataImage/1.13.jpg"  /><br />
        <asp:Image ID="Image14" runat="server"   ImageUrl="~/DataImage/1.14.jpg"  /><br />
        这样在修改了类的静态字段后，所有Student对象(包括其派生对象)所访问的字段发生变化。程序P4_l的输出如下:<br />
        <asp:Image ID="Image15" runat="server"   ImageUrl="~/DataImage/1.15.jpg"  />  <br />
        在还应注意：writePersonannfo方法中使用的school实际上是student.school的简写。
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
