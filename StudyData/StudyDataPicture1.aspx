<%@ Page Language="C#" MasterPageFile="~/StudyData/StudyDataMasterPage.master" AutoEventWireup="true" CodeFile="StudyDataPicture1.aspx.cs" Inherits="StudyData_StudyDataPicture1" Title="学习资料库-知识点1-图片" %>

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
        GB_showCenter("知识点1例题（图片型）", "../example/examplePicture1.aspx", 350, 630);
    }
</script> 
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="ContentPlaceHolderInformation" Runat="Server">
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
        <p class="style3">图示总汇<br />
            <asp:Image ID="Image1" runat="server"   ImageUrl="~/DataImage/1.1.jpg" 
                Height="316px" Width="512px"  /><br />
            初始值和存储空间<br />
            <asp:Image ID="Image2" runat="server"   ImageUrl="~/DataImage/1.2.jpg"  /><br />
            <asp:Image ID="Image3" runat="server"   ImageUrl="~/DataImage/1.3.jpg"  /><br />
        </p>
        <h3 class="style4">1.2成员访问限制</h3>
        <p class="style3">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
            访问限制是实现信息隐藏和封装的重要手段，它是指类型及其成员可以定义不同的访问级别，其他对象必须符合权限才能进行访问。访问级别是通过访问限制符（modifier)来规定的，C#提供了以下4种访问限制修饰符：<br />
         <asp:Image ID="Image4" runat="server"   ImageUrl="~/DataImage/1.4.jpg"  /><br />
            在设计一个类时：<br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 只有那些需要外部对象使用的成员才应被定义为公有的;<br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 不希望外部对象访问，但希望派生类继承的成员应被定义为保护的;<br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 其他成员都应被定义为私有的。<br />
        </p>
        <h3 class="style4">1.3静态成员和非静态成员</h3>
       <p class="style3">
           以Student类为例，对比非静态成员和静态成员：<br />
           <asp:Image ID="Image5" runat="server"   ImageUrl="~/DataImage/1.5.jpg"  /><br />
           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
           此外，静态方法中的代码只能使用类的静态成员,而不能直接使用非静态成员。这是因为静态方法属于类所有，在其中不能判断非静态成员究竟属于哪个对象。而实例方法既能使用静态成员，也能使用非静态成员。<br />
           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
           对于一个类而言，如果它的所有成员都是静态的，那么还可以使用static关键字将其定义为静态类。例如，Console类就是一个静态类，对它的所有成员访问都是通过类本身进行的。<br />
           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 此外，对静态类不能使用new关键字来创建对象。
       </p>
       <h3 class="style4">1.4常量字段和只读字段</h3>
       <p class="style3">
           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
           数学中有一些常量的值是不会发生变化的，比如圆周率、万有引力常数G等。为了防止在程序中改变这些值，可以使用关键字const将其定义为类型的常量字段。<br />
       <asp:Image ID="Image6" runat="server"   ImageUrl="~/DataImage/1.6.jpg"  /><br />
       <asp:Image ID="Image7" runat="server"   ImageUrl="~/DataImage/1.7.jpg"  /><br />
       注意：<br />
           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 常量字段必须在定义时进行赋值，之后只能读取而不允许修改其值。<br />
           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 常量字段默认也是静态的（无需再关键字static来进行修饰），即字段属于类型本身所有。<br />
          因此在下面的计算圆周长的代码中，对PI的访问只能通过类型名Circle进行：<br />
        <asp:Image ID="Image8" runat="server"   ImageUrl="~/DataImage/1.8.jpg"  /><br />
        注意：<br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 它只能在对象创建时被赋值，而后不允许修改。<br />
           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
           例如，下面程序中BankCard类就定义了一个只读字段id，并在静态字段count中记录已有的对象数量，使得每个新创建的BankCard对象id值自动递增（其中构造函数将在4.3.1小节介绍）：<br />
        <asp:Image ID="Image9" runat="server"   ImageUrl="~/DataImage/1.9.jpg"  /><br />
        </p> 
    </asp:Panel>
<center>
<input type="button" value="例题精解" onclick="openWinCenter()" style="border-style: double; font-family: 微软雅黑; font-size: large; color: #009933; width: 135px;" />
</center>
	
</asp:Content>

