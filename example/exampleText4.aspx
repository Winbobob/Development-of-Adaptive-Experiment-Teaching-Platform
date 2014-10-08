﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="exampleText4.aspx.cs" Inherits="example_exampleText4" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <title>知识点4例题（文字）</title>
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
实例构造函数例题：<br />
Public class ComplexNumber<br />
{<br />
      　Private double a=0;<br />
      　Public double A<br />
      　{<br />
　　Get{return a;}<br />
　　Set{<br />
      &nbsp;&nbsp; 　　 If (this.a!=value)<br />
      　　&nbsp;&nbsp; This.a=value;<br />
　　}<br />
      　}<br />
      　Private double b;<br />
      　Public double B<br />
      　{<br />
　　Get{return b;}<br />
　　Set{<br />
　　If (this.b!=value)<br />
　　This.b=value;<br />
　　}<br />
      　}<br />
      　Public void Write()<br />
      　{<br />
　　Console.WriteLine(“{0}+{1}i”,this.a,this.b);<br />
      　}<br />
}
  
  </p>
     </asp:Panel>
</DIV>
<DIV class=tagContent id=tagContent1>
           <asp:Panel ID="Panel2" runat="server"  ScrollBars="Vertical"  Height="250px">
           <p class="style3">
  实例方法例题：<br />
      public class Vistor<br />
      {    <br />
      　string i = &quot;Vistor&quot;;    <br />
      　public void Visit(Element e)  <br />  
      　{        <br />
　　Console.WriteLine("I was {0}.", e.GetType());   <br />     
　　Console.WriteLine("I was {0}.", this.i);    <br />
      　}<br />
      }<br />
      public class Element<br />
      {    <br />
      　string i = &quot;Element&quot;;   <br /> 
      　public void Accept(Vistor v)    <br />
      　{        <br />
　　v.Visit(this);//把对象自身同过Visit方法传出去 <br />   
      　}<br />
      }<br />
      class RUN<br />
      {    <br />
      　static void Main()    <br />
      　{        <br />
　　Vistor v = new Vistor();     <br />   
　　Element e = new Element();<br />
　　e.Accept(v);    <br />
      　}<br />
      }
  
  
  </p>
       </asp:Panel>
</DIV>
<DIV class=tagContent id=tagContent2>
         <asp:Panel ID="Panel3" runat="server"  ScrollBars="Vertical"  Height="250px">
        <p class="style3">
  属性和索引的实例访问器例题：<br />
public int this [int param]   <br />
 {   <br />
      　&nbsp;get&nbsp;&nbsp;<br />
      　{&nbsp;&nbsp;&nbsp;<br />
　　return array[param];<br />&nbsp;&nbsp;&nbsp; }<br />
      　Set<br />
      　{&nbsp;&nbsp;&nbsp;<br />
　　array[param] = value; <br />&nbsp;&nbsp;&nbsp; }<br />
}
  
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
