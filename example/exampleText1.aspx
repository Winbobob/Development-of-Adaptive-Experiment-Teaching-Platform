<%@ Page Language="C#" AutoEventWireup="true" CodeFile="exampleText1.aspx.cs" Inherits="example_exampleText1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>֪ʶ��1���⣨�����ͣ�</title>
    <META http-equiv=Content-Type content="text/html; charset=gb2312">
    <STYLE type=text/css>
BODY {
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
    <LI class=selectTag><A onClick="selectTag('tagContent0',this)" 
        href="javascript:void(0)">���⣨������</A> </LI>
    <LI><A onClick="selectTag('tagContent1',this)" 
        href="javascript:void(0)">���⣨�м���</A> </LI>
    <LI><A onClick="selectTag('tagContent2',this)" 
        href="javascript:void(0)">���⣨�߼���</A> </LI>
  </UL>
  <DIV id=tagContent>
    <DIV class="tagContent selectTag" id=tagContent0>
       <asp:Panel ID="Panel1" runat="server"  ScrollBars="Vertical"  Height="250px">
           <p class="style3">
              �йس�Ա�������Ƶİ���������<br />
           (1)class Student<br />
           &nbsp;&nbsp;&nbsp; {<br />
           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; private string name;<br />
             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; private void Write() <br />
             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; {<br />
                 &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Console.WriteLine(name);<br />
             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; }<br />
           &nbsp;&nbsp;&nbsp; }<br />
           &nbsp;&nbsp;&nbsp; Student s1 = new Student();<br />
           &nbsp;&nbsp;&nbsp; Console.WriteLine(s1.name);<br />
           &nbsp;&nbsp;&nbsp; s1.Write();<br />
           ���ϳ������Private��˽�еģ��������ⲿ������ʸó�Ա��<br /><br />
           (2)class Student<br />
           &nbsp;&nbsp;&nbsp; {<br />
             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; private string name;<br />
             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; protected void Write() <br />
             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; {
           <br />
           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Console.WriteLine(name);<br />
           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; }<br />
           &nbsp;&nbsp;&nbsp; }<br />
           &nbsp;&nbsp;&nbsp; class Graduate : Student<br />
           &nbsp;&nbsp;&nbsp; {<br />
           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; public void Output() <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; {<br />
               &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Console.WriteLine(name);<br />
               &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Write();<br />
             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; }<br />
           &nbsp;&nbsp;&nbsp; }<br />
           ���ϳ������Protected���ܱ����ģ�ֻ����ǰ�༰��������Ķ�����ʸó�Ա���������������ⲿ������ʡ�<br /><br />
           (3)class Student<br />
           &nbsp;&nbsp;&nbsp; {<br />
             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; public string name;<br />
             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; public void Write()<br />
             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; {<br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Console.WriteLine(name);<br />
             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; }<br />
           &nbsp;&nbsp;&nbsp; }<br />
           ���ϳ�����ȷ��Public�ǹ��еģ��������ͺͳ�Ա�������ƣ����γ�Աʱ��ʾ�����ⲿ������ʸó�Ա����������ʱ��ʾ�����ⲿ����ʹ�ø����͡�
           </p>
         </asp:Panel>
    </DIV>
    <DIV class=tagContent id=tagContent1>
        <asp:Panel ID="Panel2" runat="server"  ScrollBars="Vertical"  Height="250px">
         <p class="style3">
          &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ����student�࣬���ϣ������ѧ������������������Eһmail��ַ����ô���Խ�ǰ������Ϊpublic����������ΪPrivate;�����ʼ��Ĺ�������Է�װ�ڹ��е�SendEmail�����У��ⲿ�����Կ��Ե��ø÷����������ʼ���������ȥ֪��ѧ����E-mail��ַ��<br />
             ������Ĵ���ʾ��:<br />
             Public class Student<br />
           {<br />
              &nbsp;&nbsp;&nbsp;&nbsp; Public string name;<br />
              &nbsp;&nbsp;&nbsp;&nbsp; Private string email;<br />
              &nbsp;&nbsp;&nbsp;&nbsp; Public void SendEmail(string title,string text)<br />
              &nbsp;&nbsp;&nbsp; {<br />
             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; MailMessage m1=new MailMessage(��admin@qh.edu��,email,title,text);<br />
                 &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; SmtpClient.Send(m1);<br />
               &nbsp;&nbsp;&nbsp; }<br />
            }<br />
             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
             ���Student����һ��������Graduate���������һ������Register��ҲҪʹ�õ�E-mail��ַ���Ǿ�Ӧ����Student��email�ֶε����η���pritrate��Ϊprotected����������Ĵ�����ǲ��Ϸ���:<br />
            Public class Gradute:Student<br />
            {<br />
               &nbsp;&nbsp;&nbsp; Public void Register()<br />
              &nbsp;&nbsp;&nbsp; {<br />
                 &nbsp;&nbsp;&nbsp; Console.WriteLine(��������{0}��,name);<br />
                 &nbsp;&nbsp;&nbsp; Console.WriteLine(�������ʼ���{0}��,email);//���󣺲��ܷ���˽�еĻ����ֶ�<br />
               &nbsp;&nbsp;&nbsp; }<br />
            }
       </p>
       </asp:Panel>

    </DIV>
    <DIV class=tagContent id=tagContent2>
      <asp:Panel ID="Panel3" runat="server"  ScrollBars="Vertical"  Height="250px">
      <p class="style3">
           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
           ����ĳ����ΪStudent�ඨ���˾�̬�ֶ�School�;�̬����WriteSchoolInfo������һ����̬����WritePersonalInfo��ͬʱʹ�õ�����ľ�̬�ֶκͷǾ�̬�ֶ�:<br />
//����P4_1<br />
Using System;<br />
Namespace P4_1<br />
{<br />
           &nbsp;&nbsp;&nbsp; Class Program<br />
           &nbsp;&nbsp;&nbsp; {<br />
           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Static void Main()<br />
           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; {<br />
           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Student s1=new Student();<br />
           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; S1.name=����С�족;<br />
           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Student s2=new Student();<br />
           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; S2.name=���ܾ���;<br /> 
           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; S2.Department=����ѧϵ��;<br />
           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Student.School=�����пƼ���ѧ��;<br />
           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Student.WriteSchoolInfo();<br />
           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; S1.WriteSchoolInfo();<br />
           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; S2.WriteSchoolInfo();<br />
           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; }<br />
           &nbsp;&nbsp;&nbsp; }<br />
           &nbsp;&nbsp;&nbsp; Public class Student<br />
           &nbsp;&nbsp;&nbsp; {<br />
           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Public static string School =����������ѧ��<br />
           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Public string name,Department=�������ϵ��;<br />
           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Public int age;<br />
           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Public void WritePersonalInfo()<br />
           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; {<br />
           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Console.WriteLine(��{0} {1} {2} ��School ,Department, name);<br />
           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; }<br />
           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Public static void WriteSchoolInfo()<br />
           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; {<br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Console.WriteLine(School);<br />
           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; }<br />
           &nbsp;&nbsp;&nbsp; }<br />
}<br />
           �������޸�����ľ�̬�ֶκ�����Student����(��������������)�����ʵ��ֶη����仯������P4_l���������:<br />
��������ѧ<br />
 ���пƼ���ѧ<br />
 ���пƼ���ѧ �����ϵ ��С��<br />
 ���пƼ���ѧ ��ѧϵ �ܾ�<br />
 �ڸó����л�Ӧע��:writePersonannfo������ʹ�õ�schoolʵ������student.school�ļ�д��
       </p>
       </asp:Panel>
    </DIV>
  </DIV>
</DIV>
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
