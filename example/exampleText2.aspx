<%@ Page Language="C#" AutoEventWireup="true" CodeFile="exampleText2.aspx.cs" Inherits="example_exampleText2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>֪ʶ��2���⣨���֣�</title>
    <META http-equiv=Content-Type content="text/html; charset=gb2312">
<STYLE type=text/css>BODY {
	FONT-SIZE: 14px;font-family: ΢���ź�;
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
            font-family: ΢���ź�;
            color: #000000;
            font-size:15px;
        }
   .style4
        {
            font-family: ΢���ź�;
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
  href="javascript:void(0)">���⣨������</A> </LI>
  <LI><A onClick="selectTag('tagContent1',this)" 
  href="javascript:void(0)">���⣨�м���</A> </LI>
  <LI><A onClick="selectTag('tagContent2',this)" 
  href="javascript:void(0)">���⣨�߼���</A> </LI></UL>
<DIV id=tagContent>
<DIV class="tagContent selectTag" id=tagContent0>
           <asp:Panel ID="Panel1" runat="server"  ScrollBars="Vertical"  Height="250px">
         <p class="style3">���磬�������´���ʵ��Բ�����š�<br />
Public void Zoom(double rate)<br />
{<br />&nbsp;&nbsp;&nbsp;
R*=rate;<br />
}<br />
��һ�����������ű���Ϊ0������������ɶ�Zoom�����������޸ģ�<br />
Public void Zoom(double rate)<br />
{<br />&nbsp;&nbsp;&nbsp;
If��rate<=0��return ;<br />&nbsp;&nbsp;&nbsp;
R*=rate;<br />
}
</p>
     </asp:Panel>
</DIV>
<DIV class=tagContent id=tagContent1>
           <asp:Panel ID="Panel2" runat="server"  ScrollBars="Vertical"  Height="250px">
        <p class="style3">
���磬����ķ������ڼ���������������Ԫ�صĺ�:<br />
public int Sum(int[] array)    //ʹ����ͨ����������<br />
{<br />&nbsp;&nbsp;&nbsp;
Int s=0;<br />&nbsp;&nbsp;&nbsp;
For (int i=0;i< arrray.length;i++) <br />&nbsp;&nbsp;&nbsp;
S+=array[i];<br />&nbsp;&nbsp;&nbsp;
Return s;<br />
}<br />
������ڲ���ǰ����params���ò����ͳ�Ϊ�������Ͳ���<br />
public int Sum(params int[] array)    //ʹ�������Ͳ���<br />
{<br />&nbsp;&nbsp;&nbsp;
Int s=0;<br />&nbsp;&nbsp;&nbsp;
For (int i=0;i< arrray.length;i++) <br />&nbsp;&nbsp;&nbsp;
S+=array[i];<br />&nbsp;&nbsp;&nbsp;
Return s;<br />
}
</p>
       </asp:Panel>
</DIV>
<DIV class=tagContent id=tagContent2>
         <asp:Panel ID="Panel3" runat="server"  ScrollBars="Vertical"  Height="250px">
         <p class ="style3">
�����������:<br />
using System;<br />
namespace P4_3<br />
{<br />&nbsp;&nbsp;&nbsp;
class Program<br />&nbsp;&nbsp;&nbsp;
{<br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
static void Main(params string[] args)<br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
{<br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
If(args.Length==0)<br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
{<br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
console.WriteLine(��δ����ָ��������);<br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
Return;<br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
}<br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
Double s=double.parse(args[1]);<br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
If(args[0]==��sum��)<br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
{<br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
For(int i=2;i<args.Length;i++)<br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
S+=double.Parse(args[i]);<br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
}<br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
Else if(args[0]==��prod��)<br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
{<br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
For(int i=2;i<args.Length;i++)<br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
S*=double.Parse(args[i]);<br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
}<br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
console.WriteLine(s);<br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
}<br />&nbsp;&nbsp;&nbsp;
}<br />
}<br />
���磬���ʾ��<br />
D��\prjs>P4_3 sum 8 24<br />
32<br />
D��\prjs>P4_3 sum 8 21 8.8 12.6 5.9<br />
56.3<br />
D��\prjs>P4_3 sum 32 0.75 0.8<br />
19.2<br />
������<br />
�ԡ�sum 8 24 ��Ϊ����args.length�϶�����0������������args[0]��args[0]=��sum��������8+24���õ�32��
</p>
       </asp:Panel>  
</DIV></DIV></DIV>
<p>
  <SCRIPT type=text/javascript>
      function selectTag(showContent, selfObj) {
          // ������ǩ
          var tag = document.getElementById("tags").getElementsByTagName("li");
          var taglength = tag.length;
          for (i = 0; i < taglength; i++) {
              tag[i].className = "";
          }
          selfObj.parentNode.className = "selectTag";
          // ��������
          for (i = 0; j = document.getElementById("tagContent" + i); i++) {
              j.style.display = "none";
          }
          document.getElementById(showContent).style.display = "block";


      }
</SCRIPT>
</p>
</body>
</html>
