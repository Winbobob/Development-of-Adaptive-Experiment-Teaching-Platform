<%@ Page Language="C#" MasterPageFile="~/StudyData/StudyDataMasterPage.master" AutoEventWireup="true" CodeFile="StudyDataPicture2.aspx.cs" Inherits="StudyData_StudyDataPicture2" Title="无标题页" %>

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
        GB_showCenter("知识点2例题（图片型）", "../example/examplePicture2.aspx", 350, 630);
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
<asp:Panel ID="PanelAll" runat="server"  ScrollBars="Vertical"  Height="833px">
  <h3 align="center" style="font-family: 微软雅黑; font-size: 16pt; color: #006600">知识点2：方法</h3>
  <p class="style3">方法是最基本的函数成员，对象所能执行的操作都是通过方法来定义的。方法的声明应依次包括以下4个部分:<br />
  <asp:Image ID="Image2" runat="server"   ImageUrl="~/DataImage/2.1.jpg"  /><br />
  <h3 class="style4">2.1方法的返回值</h3>
   <p class="style3">
       &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
       如果方法的返回类型不为void，那么方法的执行代码中必须通过return语句来返回一个值。当方法的返回类型为void时，其执行代码要么没有return语句，要么只有不跟任何表达式的return语句。</p>
  <h3 class="style4">2.2参数类型</h3>
  <p class="style3"><b>1)值传递和引用传递</b><br />
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
      方法声明的参数列表中的参数叫作形式参数(简称形参)。而实际调用时传递给方法的参数叫作实际参数(简称实参)，二者的名称不要求相同。例如，对于Circle类的Zoom方法，其参数rate就是形参；<br />
下面的代码创建了一个Circle对象并调用了其Zoom方法，传递给该方法参数x就是实参：<br />   
Circle cl=new Circle();<br />
double x = 0.5;<br />
c1. Zoom(x);<br />
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
      调用方法时.程序会首先将实参的值传递给对应的形参，而后执行方法体中的代码。对于引用类型的参数，实参和形参就会指向同一个对象;而对于值类型的参数，实参的值将被复制一份给形参，方法代码中对形参的修改并不会影响到实参。<br />
例如，下面的代码试图交换x和y的值，但实际上交换的只是形参的值.而不会真正改变实参的值:<br />
<asp:Image ID="Image1" runat="server"   ImageUrl="~/DataImage/2.3.jpg"  /><br />
<asp:Image ID="Image3" runat="server"   ImageUrl="~/DataImage/2.4.jpg"  /><br />
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
      C#中提供了方法参数的引用传递方式，此时形参是实参的“引用”，二者指向同一个变量，此时方法代码中对形参值的修改就会直接作用于实参。引用传递的方法参数通过ref关键字加以修饰。<br />
例如，以下代码：<br />
Public void Swap(ref int x,ref int y)<br />
<asp:Image ID="Image4" runat="server"   ImageUrl="~/DataImage/2.5.jpg"  /><br />
<b>2)输出型参数</b><br />
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 当需要返回多个计算结果的时候，需要将其他返回的结果放在方法的输出型参数中。输出型参数用out关键字加以修饰。<br />
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 输出型参数也采用引用传递方式，但其形参要求在方法返回之前必须被赋值（以满足“输出”的要求)，而其所对应的实参在使用时可以不进行初始化。<br />
<b>3)数组型参数</b><br />
方法的参数类型也可以是数组。<br />
对数组型参数的使用有着严格的规定：<br />
      i)方法中只允定义一个数组型参数，而且该参数必须位于参数列表中的最后；<br />
      ii)数组型参数所定义的数组必须是一维数组；<br />
      iii)数组型参数不能同时作为引用型参数或输出型参数。<br />
 &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
      C#应用程序的主方法Main也可以使用数组型参数，但它额外规定数组元素的类型必须是字符串string，此时数组型参数就表示程序所能接受的参数集合。<br />
      <b>参数类型总结</b><br />
<asp:Image ID="Image6" runat="server"   ImageUrl="~/DataImage/2.8.jpg"  /><br /></p>
 <h3 class="style4">2.3方法的重载</h3>
 <p class="style3">C#中允许一个类中包含多个同名的方法，只要它们的参数数量或类型不完全相同，这方法叫做方法的重载。<br />
 <asp:Image ID="Image11" runat="server"   ImageUrl="~/DataImage/2.11.jpg"  /><br />
 在使用过程中，程序会根据传递给方法的实参类型来确定具体调用哪一个方法:
 <asp:Image ID="Image12" runat="server"   ImageUrl="~/DataImage/2.12.jpg"  /><br />
 <asp:Image ID="Image13" runat="server"   ImageUrl="~/DataImage/2.13.jpg"  /><br />
不过，如果两个方法名称和参数列表都相同，而仅仅是返回类型不同，那么C#认为它们不能构成重载。<br />
例如，一个类中不能同时包含下面两个方法:<br />
<asp:Image ID="Image5" runat="server"   ImageUrl="~/DataImage/2.7.jpg"  /><br />
     &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
     此外，由于输出型参数只是在引用型参数的基础上增加了特殊限制，因此只有ref和out型参数的区别也不能构成重载，如二个类中不能同时包含Swap(ref int 
     x, ref int y)和Swap(ref int x,out int y)两个方法。<br />

</p>    
    </asp:Panel>

<center>
<input type="button" value="例题精解" onclick="openWinCenter()" style="border-style: double; font-family: 微软雅黑; font-size: large; color: #009933; width: 135px;" />
</center>

</asp:Content>

