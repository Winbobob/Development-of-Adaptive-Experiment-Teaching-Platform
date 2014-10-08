<%@ Page Language="C#" MasterPageFile="~/StudyData/StudyDataMasterPage.master" AutoEventWireup="true" CodeFile="StudyDataText3.aspx.cs" Inherits="StudyData_StudyDataText3" Title="无标题页" %>

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
        GB_showCenter("知识点3例题（文字型）", "../example/exampleText3.aspx", 350, 630);
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
  <h3 align="center" style="font-family: 微软雅黑; font-size: 16pt; color: #006600">知识点3：类的特殊方法</h3>
  <h3 class="style4">3.1构造函数和析构函数</h3>
  <p class="style3">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 对象通常都有自己的生命周期，对象的创建和销毁就是两个重要的时间点，构造函数( 
      Constructor)和析构函数(Destructor)就表示这两个时问点上的操作。类的构造函数在创建其每个对象时都会被调用，而类的析构函数则在销毁每个对象时自动执行。<br />
  <b>1)构造函数</b><br />
  类的构造函数名称与类名相同，且不声明返回类型，其代码主要用于完成对象的初始化工作。<br />
  例如，下面的Student类的构造函数将grade字段值设为1：<br />
Public Student()<br />
{<br />
      　Grade=1;<br />
}<br />
如果希望通过不同的数据来创建不同的对象，那么可以使用带参数的构造函数，例如：<br />
Public Student(string s)<br />
{<br />
      　Name=s;<br />
}<br />
这样就可以指定学生姓名来创建不同的Student对象：<br />
Student s1=new Student（“王小红”）;<br />
Student s2=new Student（“周军”）;<br />
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 构造函数可以有很多重载形式，以便使用不同的方式来创建对象。但如果一个类只定义了带参数的构造函数，创建对象时就必须指定相应的参数。<br />
<b>2)静态构造函数</b><br />
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
      和其他成员一样，实例构造函数属于对象所有，而使用static修饰符的静态构造函数为类的所有对象共享，并且只在首次使用该类时被调用。C#规定静态构造函数没有任何参数，且不声明访问限制（默认为public）。<br />
  <b>3)析构函数</b><br />
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 和构造函数不同，一个类中只能有一个析构函数，其名称是要在类名前加上“~”。析构函数不能有参数和返回类型，不能是静态的，也不能有访问限制修饰符。<br />
  例如Student中的析构函数可以定义为<br />
Student()<br />
{<br />
      　console.WriteLine(“学生对象{0}销毁”,name);<br />
}<br />
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 在C#程序中，用户不能显式地调用析构函数，通过静态类GC的collect方法可强制程序进行垃圾回收，从而间接调用相关对象的析构函数。
  </p>
  <h3 class="style4">3.2属性</h3>
  <p class="style3">
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
      为了实现对数据的良好封装，C#为类提供了属性访问函数，主要用于控制对字段的访问。属性访问函数主要包括get访问函数和set访问函数，分别用于对字段的读取和设置。<br />
    例如，在Student类中可使用Name属性来封装对私有字段name的访问：<br />
Private string name;<br />
Public string Name<br />
{<br />
      　Get{return name;}<br />
      　Set{name=value;}<br />
}
  </p>
  <h3 class="style4">3.3索引函数</h3>
   <p class="style3">程序设计过程中会遇到这样一些类，他们的主要作用是维护一组数据的集合。<br />
   例如，“同学录”类用于维护一组同学的信息，如果使用属性来访问数据集合的话，该类可定义为如下形式：<br />
   Public  classmateList<br />
{<br />
       　Private string title;<br />
       　Private Student[] classmates;<br />
       　Public Student[] classmates<br />
       　{<br />
　　Get{return classmates;}<br />
　　Set{classmates=value;}<br />
       　}<br />
       　Public classmateList(string t)<br />
       　{<br />
　　Title=t;<br />
　　Classmates=new Student[100];<br />
       　}<br />
}<br />
通过对象的属性来访问集合元素的示例代码如下：<br />
ClassmateList clist= new classmateList(“我的大学同学录”);<br />
Clist.Classmate[0]=new Student(“王小红”); <br />
Clist.Classmate[1]=new Student(“周军”); <br />
Clist.Classmate[2]=new Student(“方小白”); <br />
For(int i=0;i<3;i++)<br />
       　console.WriteLine(Clist.Classmate[i].Name);<br />
索引函数则对属性作了进一步扩展，它能够以数组的方式来访问对象内部的多项数据。虾米那是使用索引函数的classmateList类定义：<br />
Public  classmateList<br />
{<br />
       　Private string title;<br />
       　Private Student[] classmates;<br />
       　Public Student[] this[int index]<br />
       　{<br />
　　Get{return classmates[index];}<br />
　　Set{classmates[index]=value;}<br />
       　}<br />
       　Public classmateList(string t)<br />
       　{<br />
　　Title=t;<br />
　　Classmates=new Student[100];<br />
       　}<br />
}<br />
接下来可以“对象+下标”的方式来访问ClassmateList对象中的classmates数组元素：<br />
ClassmateList clist= new classmateList(“我的大学同学录”);<br />
Clist[0]=new Student(“王小红”); <br />
Clist[1]=new Student(“周军”); <br />
Clist[2]=new Student(“方小白”); <br />
For(int i=0;i<3;i++)<br />
　　console.WriteLine(Clist[i].Name);<br />
很显然，一个类中只能定义一个索引函数。<br />
索引函数的参数类型必须为整数或字符串；此外，它维护的集合对象不一定是数组，也可以是多个离散的字段。例如在下面的Teacher类包含了homePhone、officePhone、mobilePhone这3个私有字段，并通过索引函数来控制它们的读写：<br />
Public class Teacher<br />
{<br />
       　Private string name;<br />
       　Private string homePhone=”未知”;<br />
       　Private string officePhone=”未知”;<br />
       　Private string mobilePhone=”未知”;<br />
       　Public string this[string index]<br />
       　{<br />
       　&nbsp;&nbsp;&nbsp; Get<br />
       　&nbsp;&nbsp;&nbsp; {<br />
       　　&nbsp;&nbsp;&nbsp; If(index==”家庭电话”)<br />
       　　&nbsp;&nbsp;&nbsp; Return homePhone;<br />
       　　&nbsp;&nbsp;&nbsp; Else if(index==”办公电话”)<br />
       　　&nbsp;&nbsp;&nbsp; Return officePhone;<br />
       　　&nbsp;&nbsp;&nbsp; Else<br />
       　　&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Return mobilePhone;<br />
　　}<br />
　　Set<br />
　　{<br />
       　　&nbsp;&nbsp;&nbsp; If(index==”家庭电话”)<br />
       　　&nbsp;&nbsp;&nbsp; homePhone=value;<br />
       　　&nbsp;&nbsp;&nbsp; Else if(index==”办公电话”)<br />
       　　&nbsp;&nbsp;&nbsp; officePhone=value;<br />
       　　&nbsp;&nbsp;&nbsp; Else<br />
       　　&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; mobilePhone=value;<br />
       　　}<br />
       　}<br />
       　Public Teacher(string n)<br />
       　{<br />
　　Name=n;<br />
       　}<br />
}
   </p>
    <h3 class="style4">3.4操作符重载</h3>
  <p class="style3">被重载的操作符必须被声明为公有的和静态的，并通过关键字operator后跟操作符来声明。
  </p>

</asp:Panel>

<center>
<input type="button" value="例题精解" onclick="openWinCenter()" style="border-style: double; font-family: 微软雅黑; font-size: large; color: #009933; width: 135px;" />
</center>
</asp:Content>

