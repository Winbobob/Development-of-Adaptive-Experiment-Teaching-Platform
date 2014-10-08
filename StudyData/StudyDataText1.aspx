<%@ Page Language="C#" MasterPageFile="~/StudyData/StudyDataMasterPage.master" AutoEventWireup="true" CodeFile="StudyDataText1.aspx.cs" Inherits="StudyData_StudyDataText1" Title="学习资料库-知识点1-文字" %>

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
        GB_showCenter("知识点1例题（文字型）", "../example/exampleText1.aspx", 350, 630);
    }
</script> 

</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="ContentPlaceHolderInformation" Runat="Server">
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
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolderTop" Runat="Server">
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
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderLeft" Runat="Server">
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
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderContent" Runat="Server">
     <asp:Panel ID="PanelAll" runat="server"  ScrollBars="Vertical"  Height="820px">
        <h3 align="center" style="font-family: 微软雅黑; font-size: 16pt; color: #006600">知识点1：成员概述</h3>
        <h3 class="style4">1.1成员种类</h3>
        <p class="style3">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
            类和结构都是复合类型，它们可以包含数据成员、函数成员和嵌套成员。其中数据成员指的就是字段，而且在类型定义时可以指定字段的初始值，例如: <br />
           class ComplexNumber <br />
           {<br />
           &nbsp;&nbsp;&nbsp; public double a=0; <br />
           &nbsp;&nbsp;&nbsp; public double b=0; <br />
           }<br /> 
           但此时字段并没有获得实际的存储空间，其值只有创建对象时才会被分配：<br /> 
           ComplexNumber c1 =new ComplexNumber(); <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
            如果类型的定义中没有指定字段的初始值，使用对象时也没有给字段赋值，那么字段将会被赋予其类型的默认值(此时C#编译器会给出警告；整数（包括字符和枚举）和实数类型的默认值为0，布尔类型的默认值为false，所有引用类型的默认值为null)。<br />
           例如，对于下面的类Student，在使用语句“Student s1= new Student();”创建对象后，其字段name和age的值将分别为0和null： <br />
           class Student <br />
            {<br /> 
              &nbsp;&nbsp;&nbsp; public string name;<br />
              &nbsp;&nbsp;&nbsp; public int age public Address address; <br />
              &nbsp;&nbsp;&nbsp; public struct Address //嵌套成员<br /> 
              &nbsp;&nbsp;&nbsp; {<br />　&nbsp;&nbsp;&nbsp;&nbsp; public string Province;<br />　　 public string City;<br />　 
            　public string Detail; <br />　 } <br />} <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
            类和结构的变量都可以称为对象，但使用时要牢记类是引用类型，而结构是值类型。类和结构都可以有函数成员——方法，但类还可以有各种的特殊方法成员。4.2节和4.3节将分别对类的一般方法和特殊方法进行详细介绍。
       </p>
       <h3 class="style4">1.2成员访问限制</h3>
       <p class="style3">
           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
           访问限制是实现信息隐藏和封装的重要手段，它是指类型及其成员可以定义不同的访问级别，其他对象必须符合权限才能进行访问。访问级别是通过访问限制符（modifier)来规定的，C#提供了以下4种访问限制修饰符：<br />
         Private（私有）：用于成员访问限制，表示不允许外部对象访问该成员。<br />
         Public（公有）：用于类型和成员访问限制，修饰成员时表示允许外部对象访问该成员，修饰类型时表示允许外部程序集使用该类型。<br />
         Protected（保护）：用于成员访问限制，表示只允许当前类及其派生类的对象访问该成员，而不允许其他外部对象访问。<br />
         Internal（内部）：用于类型和成员访问限制，表示不允许外部程序集使用该类型或访问该成员。<br />
           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
           其中最其中最主要的是掌握前3个修饰符对成员的访问限制。在设计一个类时，只有那些需要外部对象使用的成员才应被定义为公有的;不希望外部对象访问，但希望派生类继承的成员应被定义为保护的;其他成员都应被定义为私有的。<br />
           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
           例如，对于student类，如果希望公开学生姓名，但不公开其E一mail地址，那么可以将前者修饰为public，后者修饰为Private;发送邮件的功能则可以封装在公有的SendEmail方法中，外部对象仍可以调用该方法来发送邮件，而不必去知道学生的E-mail地址。
       </p>
       <h3 class="style4">1.3静态成员和非静态成员</h3>
       <p class="style3">
           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
           通常所说的成员都是指非静态成员，或者叫做实例成员，即成员属于类型的实例(对象)所有。例如，对于前面的Student类，每个学生对象都有自己的name和email字段。 
           另一种情况是静态成员，即成员属于类型本身所有，而不是随着具体对象的变化而变化。C#中使用关键字static来定义静态成员，例如，在student类中可通过下面的代码来定义一个静态字段School:<br />
           Public static string School =”华中理工大学”;<br />在使用时，静态成员是通过类名而不是对象名来访问的。例如：<br />
           Student s1= new Student();<br />Console.WriteLine(s1.name);<br />
           Console.WriteLine(Student.School);<br />　&nbsp;&nbsp; 
           对于类的静态字段，程序会在首次使用到该类时为其分配存储空间，而且该类的所有对象共享这一字段。类似地，可以定义类的静态方法，它也是通过类而非对象来进行调用的。<br />
           　&nbsp;&nbsp; 
           此外，静态方法中的代码只能使用类的静态成员,而不能直接使用非静态成员。这是因为静态方法属于类所有，在其中不能判断非静态成员究竟属于哪个对象。而实例方法既能使用静态成员，也能使用非静态成员。<br />
           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
           对于一个类而言，如果它的所有成员都是静态的，那么还可以使用static关键字将其定义为静态类。例如，Console类就是一个静态类，对它的所有成员访问都是通过类本身进行的。<br />
           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 此外，对静态类不能使用new关键字来创建对象。
       </p>
       <h3 class="style4">1.4常量字段和只读字段</h3>
       <p class="style3">
           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;数学中有一些常量的值是不会发生变化的，比如圆周率、万有引力常数G等。为了防止在程序中改变这些值，可以使用关键字const将其定义为类型的常量字段。例如，下面的Circle类就定义了一个常量字段PI，并在GetArea方法中使用了该字段：<br />
          Public class Circle<br />
          {<br />
             &nbsp;&nbsp;&nbsp; Public const double PI=3.1415927;<br />
             &nbsp;&nbsp;&nbsp; Public double r;<br />
             &nbsp;&nbsp;&nbsp; Public double GetArea()<br />
             &nbsp;&nbsp;&nbsp; {<br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Return PI*r*r;<br />
             &nbsp;&nbsp;&nbsp; }<br />
          }<br />
           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
           常量字段必须在定义时进行赋值，之后只能读取而不允许修改其值。常量字段默认也是静态的（无需再关键字static来进行修饰），即字段属于类型本身所有。因此在下面的计算圆周长的代码中，对PI的访问只能通过类型名Circle进行：<br />
         Circle c =new Circle();<br />
         c.r=5;<br />
         double p=2*Circle.PI*c.r ;<br />
         Circle.PI=3 ;//错误：不允许修改常量字段<br />
           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
           还有一类常量是针时单个对象的，如每个人的的身份证号、每张银行卡的卡号都不应该被改，那么可使用关键字readonly将其定义为只读字段，它只能在对象创建时被赋值，而后不允许修改。例如，下面程序中BankCard类就定义了一个只读字段id，并在静态字段count中记录已有的对象数量，使得每个新创建的BankCard对象id值自动递增（其中构造函数将在4.3.1小节介绍）：<br />
         Public class BankCard<br />
         {<br />
           &nbsp;&nbsp;&nbsp; Public readonly int id;<br />
           &nbsp;&nbsp;&nbsp; Private static int count=0;<br />
           &nbsp;&nbsp;&nbsp; Public BankCard()<br />
           &nbsp;&nbsp;&nbsp; { <br />
             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Id=count++;<br />
           &nbsp;&nbsp;&nbsp; }<br />
         }
         
       </p>
       </asp:Panel>
<center>
<input type="button" value="例题精解" onclick="openWinCenter()" style="border-style: double; font-family: 微软雅黑; font-size: large; color: #009933; width: 135px;" />
</center>
</asp:Content>

