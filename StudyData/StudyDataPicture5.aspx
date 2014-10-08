<%@ Page Language="C#" MasterPageFile="~/StudyData/StudyDataMasterPage.master" AutoEventWireup="true" CodeFile="StudyDataPicture5.aspx.cs" Inherits="StudyData_StudyDataPicture5" Title="无标题页" %>

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
        GB_showCenter("知识点5例题（图片型）", "../example/examplePicture5.aspx", 350, 630);
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
  <h3 align="center" style="font-family: 微软雅黑; font-size: 16pt; color: #006600">知识点5：常用类型</h3>
  <h3 class="style4">5.1Object类</h3>
  <p class="style3">
Object类（可简写为object）是.NET类库中最顶层的基类，它提供了以下4个公有成员方法：<br />
<asp:Image ID="Image1" runat="server"   ImageUrl="~/DataImage/5.1.jpg"  /><br />
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
      这些方法都自动被所有其他类型所继承，因此对任何对象都可以调用。前面已经介绍过，预定义值类型的ToString方法将返回数值的字符串表示，这是因为它们对该方法进行了重载，否则该方法直接返回对象类型的字符串表示。事实上，Console类的Write和writeLine方法输出的都是参数对象的字符串表示。<br />
例如，对于一个不为空的Student对象s1，下面两行代码的效果实际上是相同的：<br />
Console.WriteLine(s1);<br />
Console.WriteLine(s1.ToString());<br />
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; GetType 
      方法将返回对象的类型，这里的Type类也是.NET类库中的一个类。类型表示的字符串格式为“命名空间”+“.”+“类型名”，例如，object类型的字符串表示就是“System.Object”。要注意GetType方法总是返回对象的实际类型，而不是声明类型。<br />
例如：<br />
<asp:Image ID="Image2" runat="server"   ImageUrl="~/DataImage/5.2.jpg"  />
  </p>
  <h3 class="style4">5.2String类</h3>
  <p class="style3"><b>1)字符串与字符数组</b><br />
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
      String类（可简写为string）表示字符串类型，它将一组字符视为一个整体进行处理，使用起来很像是一个字符数组，例如，可以通过Length属性判断字符串长度，还可以通过索引下标来……<br />
提示：<br />
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
      空字符串和空值null是不同的，前者是一个不包含任何字符的string对象，而后者尚未分配存储空间。例如，前者的Length属性为0，而访问后者的Length属性时会发生程序异常。<br />
除了直接赋值外，也可以通过String类的构造函数来创建字符串对象，其中常用的重载形式有以下几种：<br />
<asp:Image ID="Image3" runat="server"   ImageUrl="~/DataImage/5.3.jpg"  /><br />
下面的示例演示了这些构造函数的用法：<br />
<asp:Image ID="Image4" runat="server"   ImageUrl="~/DataImage/5.4.jpg"  /><br />
和构造函数相反，String类的ToCharArray方法用于将字符串转换为字符数组，例如：<br />
<asp:Image ID="Image5" runat="server"   ImageUrl="~/DataImage/5.5.jpg"  /><br />
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
      String类对相等和不等操作符进行了重载：如果两个字符串长度相同，且各个对于位置上的字符也都相同，那么认为这两个字符串是相等的。但它并没有重载“&gt;’’、“&gt;=”等比较操作符，而是提供了一个替代方法CompareTo。当字符串sl通过该方法与字符串s2进行比较时，返回0表示二者相等，返回正数表示s1大于s2，否则表示sl小于s2。 
      CompareTo方法的具体比较规则如下：<br />
（1）如果sl和s2都为空字符串，那么返回整数0。<br />
（2）如果s1为空字符串而s2非空，那么返回整数-1；反之则返回整数1。<br />
（3）比较sl的第一个字符a1和s2的第一个字符a2，如果相等，则继续比较s1和s2的剩余子串，否则返回al和a2的比较结果（即比较al和a2字符编码值）。<br />
（4）如果sl和s2的所有字符都相等，那么返回整数0。<br />
提示：<br />
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
      数字字符的编码小于英文字母，小写字母的编码大于大写字母，汉字字符的编码则大于所有拉丁字符；对于两个汉字字符，系统默认的是比较它们的拼音排序。但不同国家或地区的文本排序规则可能有所不同，这在开发国际化应用软件时要加以注意。<br />
下面给出了一些使用compareTo方法进行字符串比较的示例代码：<br />
<asp:Image ID="Image6" runat="server"   ImageUrl="~/DataImage/5.6.jpg"  /><br />
<b>2)字符操作</b><br />
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
      和字符数组相比，String类还通过IndexOf、LastIndexOf、IndexOfAny、和LastIndexOfAny等方法提供了强大的字符查找功能，其中IndexOf方法常用的重载形式有以下几种：<br />
<asp:Image ID="Image7" runat="server"   ImageUrl="~/DataImage/5.7.jpg"  /><br />
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 方法的返回值为指定字符在字符串中的索引位置，如果未找到则返回 -1，LastIndexOf方法与之类似，只不过他是从后向前查找。看下面的代码示例：<br />
<asp:Image ID="Image8" runat="server"   ImageUrl="~/DataImage/5.8.jpg"  /><br />
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
      和IndexOf方法相比，IndexOfAny方法的第一个参数是一个字符数组，方法的返回值则为数组中任意一个字符在字符串中首次出现的位置；对应地，LastIndexOfAny方法返回字符数组中任意一个字符在字符串中最后出现的位置。看下面代码示例：<br />
<asp:Image ID="Image9" runat="server"   ImageUrl="~/DataImage/5.9.jpg"  /><br />
String类中其他一些常用的字符操作方法（及其重载形式）如下：<br />
<asp:Image ID="Image10" runat="server"   ImageUrl="~/DataImage/5.10.jpg"  /><br />
要注意这些方法都不修改当前字符串对象的内容，而是将修改后的内容作为一个新字符串对象返回。
<br />
<b>3)子串操作</b><br />
      　&nbsp;&nbsp;&nbsp; 字符串中任意一段连续的字符称为该字符串的子串。如果将字符视为长度为1的字符串，那么子串操作也是对字符串操作的扩展。<br />
      　&nbsp;&nbsp;&nbsp; String类的IndexOf和LastIndexOf方法不仅可查找指定字符，还可查找指定子串，其返回的结果是子串的首字符位置。<br />
      　&nbsp;&nbsp;&nbsp; 如果只需要知道字符串之间的包含关系，那么可以使用Contains方法来判断字符串中是否包含指定子串。<br />
      　&nbsp;&nbsp;&nbsp; 使用StartsWith方法和EndsWinth方法来判断字符串是否以只懂得子串开始和结束。<br />
      SubString方法也是string类的一个常用方法，它有以下两种重载形式：<br />
      (1)string Substring(int s):获得字符串从第s个字符开始直至结束的子串。<br />
      (2)string Substring(int s ,int n):获得字符串从第s个字符开始的连续n个字符的子串。<br />
      String类的Split方法用于将字符串分隔为一组子串；<br />
      String类的Replace方法提供用于子串替换的重载形式。<br />
　  </p>
<h3 class="style4">5.3Math类</h3>
<p class="style3">
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; .NET类库中的Math类提供了对初等数学计算的基本支持。它是一个静态类，其两个公有静字段E和PI分别表示对自然对数e和圆周率。<br />
另外，还有一些常用的静态方法：<br />
Abs（求绝对值）；Ceiling（求大于或等于指定数值的最小整数）；floor（求大于或等于指定数值的最大整数）；
Exp（求e的指数幂）；Pow（指数函数）；log（对数函数）；sqrt（平方根）；
Sin（正弦指数）；cos（余弦函数）；tan（正切函数）；
</p>
<h3 class="style4">5.4 DateTime结构</h3>
<p class="style3">
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; .NET类库中的结构类型DateTime对此进行了封装。该结构定义了多个重载的构造函数。<br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
    对于一个DateTime对象而言，其各个时间部分可通过Year（年）、Month（月）、Day（日）、Hour（小时）、Minute（分钟）、Second（秒）、等实例属性获得，通过dayofweek和dayofyear能知道是当天的第几天。<br />
    此外通过DateTime的静态属性Now可获得当前的系统时间。<br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
    和基础值类型一样，DateTime也提供了Parse和TryParse方法，以及转换成字符串的ToString方法。此外它还提供了ToLongDateString、ToShortDateString、ToLongTimeString、ToShortTimeString这4个转换到特定格式字符串的方法。<br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; DateTime结构也重载了各种比较运算符，并提供了专用于时间比较的CompareTo方法。若dt1在dt2时间前面，那么认为dt1小于dt2。
</p>
  </asp:Panel>

<center>
<input type="button" value="例题精解" onclick="openWinCenter()" style="border-style: double; font-family: 微软雅黑; font-size: large; color: #009933; width: 135px;" />
</center>
 
</asp:Content>

