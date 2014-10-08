Console.WriteLine("������һ����ݣ�");
int i = Convert.ToInt32(Console.ReadLine());
bool judge = DateTime.IsLeapYear(i);
if (judge == true)
{
	Console.WriteLine("����Ϊ����");
}
else
{
	Console.WriteLine("����Ϊƽ��");
}

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head><title>
	初级练习题
</title>
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style2
        {
            width: 30px;
        }
        .style3
        {
            width: 278px;
        }
        .answer
        {
            font-family: 微软雅黑;
            color: #FF0000;
        }
        .question
        {
            font-family: 微软雅黑;
            color: #003300;
        }
        .explain
        {
            font-family: 微软雅黑;
            color: #000000;
        }
        .title
        {
            font-family: 微软雅黑;
            color: #000000;
            font-size:large;
        }
        .qFront
        {
            font-family: 微软雅黑;
            color: #000000;
        }
        .qBack
        {
            font-family: 微软雅黑;
            color: #000000;
        }
        .titleLow
        {
            font-family: 微软雅黑;
            color: #800000;
            font-size: large;
        }
        .style8
        {
            width: 268px;
        }
    </style>

    <style type="text/css">
    #container
    { 
	background-position: center;
	background-image:url(images/Student.jpg);
	position: relative;
	width: 1200px;
	height: 1500px;
	z-index: 1;
	background-repeat: no-repeat;
	margin: 0 auto;
	margin-top: 0;
    }	
    #head
    {
	position: absolute;
	width: 753px;
	height: 48px;
	left: 372px;
	top: 355px;
    }
    #content
    {
	position: absolute;
	width: 753px;
	height: 829px;
	left: 372px;
	top: 411px;
    }
    #information
    {
	position: absolute;
	width: 227px;
	height: 143px;
	left: 98px;
	top: 386px;
    }
    #unit
    {
	position: absolute;
	width: 221px;
	height: 467px;
	left: 100px;
	top: 825px;
    }
    #function
    {
	position: absolute;
	width: 221px;
	height: 155px;
	left: 100px;
	top: 593px;
    }
    #buttom
    {
	position: absolute;
	width: 751px;
	height: 33px;
	left: 374px;
	top: 1251px;
    }
	#down
    {
	position: absolute;
	width: 1109px;
	height: 54px;
	left: 50px;
	top: 1391px;
    bottom: 55px;
    }
    .zhuxiao
    {
    text-decoration: none;
    font-family: 微软雅黑;
    color: #800000;
    font-weight: bold;
    }
    .bottomtext
    {
    font-family: 微软雅黑;
    color: #FFFFFF;
    font-size: medium;
    }
    </style>
<style type="text/css">
	.ctl00_ContentPlaceHolderUnit_infotree1_TreeView1_0 { color:#003300;font-family:微软雅黑;text-decoration:none; }

</style></head>
<body bgcolor="#028B40">
    <form name="aspnetForm" method="post" action="ExerciseLow.aspx" id="aspnetForm">
<div>
<input type="hidden" name="__EVENTTARGET" id="__EVENTTARGET" value="" />
<input type="hidden" name="__EVENTARGUMENT" id="__EVENTARGUMENT" value="" />
<input type="hidden" name="ctl00_ContentPlaceHolderUnit_infotree1_TreeView1_ExpandState" id="ctl00_ContentPlaceHolderUnit_infotree1_TreeView1_ExpandState" value="eenennnennn" />
<input type="hidden" name="ctl00_ContentPlaceHolderUnit_infotree1_TreeView1_SelectedNode" id="ctl00_ContentPlaceHolderUnit_infotree1_TreeView1_SelectedNode" value="" />
<input type="hidden" name="ctl00_ContentPlaceHolderUnit_infotree1_TreeView1_PopulateLog" id="ctl00_ContentPlaceHolderUnit_infotree1_TreeView1_PopulateLog" value="" />
<input type="hidden" name="__VIEWSTATE" id="__VIEWSTATE" value="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" />
</div>

<script type="text/javascript">
//<![CDATA[
var theForm = document.forms['aspnetForm'];
if (!theForm) {
    theForm = document.aspnetForm;
}
function __doPostBack(eventTarget, eventArgument) {
    if (!theForm.onsubmit || (theForm.onsubmit() != false)) {
        theForm.__EVENTTARGET.value = eventTarget;
        theForm.__EVENTARGUMENT.value = eventArgument;
        theForm.submit();
    }
}
//]]>
</script>


<script src="/SelfAdaptivePlatform/WebResource.axd?d=xZoJJ6tS3QryiuTDm5DAoxxbn_V2qkLVgzUbb2V-TJrMjL6_qqajDK3Q3ZS-o6sM3fCfGRSaP6cchRk4FmItsCulvJk1&amp;t=634963807833437500" type="text/javascript"></script>


<script src="/SelfAdaptivePlatform/WebResource.axd?d=YKMjyzK2G51BFhE7tG6AeYTjo5jTDOprFvLljE9U2Vy6k2RerY5t7UWh3I7liRy_JHdol9cCX1yPmwnCfpFLmwWzJBI1&amp;t=634963807833437500" type="text/javascript"></script>
<script type="text/javascript">
//<![CDATA[

    function TreeView_PopulateNodeDoCallBack(context,param) {
        WebForm_DoCallback(context.data.treeViewID,param,TreeView_ProcessNodeData,context,TreeView_ProcessNodeData,false);
    }
var ctl00_ContentPlaceHolderUnit_infotree1_TreeView1_Data = null;//]]>
</script>

<div>

	<input type="hidden" name="__PREVIOUSPAGE" id="__PREVIOUSPAGE" value="zh4-Lr0vADbZkX9Ou6k1Jy5OzTNtmIm2M_iku7A60cdUFL2NWEElEW-O7KWHJ-1rIRIjt-WBokkOEDhoRh_nNakp9E3mtXIm1AJJYMsyCRKmQpuz0" />
	<input type="hidden" name="__EVENTVALIDATION" id="__EVENTVALIDATION" value="/wEWQwKR0d4gAoySufYIAouSufYIAo6SufYIArP67YUGArL67YUGArH67YUGArD67YUGAuyVx+sKArem4YsNArb67YUGArf67YUGArT67YUGArX67YUGAumVx+sKAram4YsNArX67YUGArT67YUGArf67YUGArb67YUGAuqVx+sKArWm4YsNArD67YUGArH67YUGArL67YUGArP67YUGAu+Vx+sKArSm4YsNAq/67YUGAq767YUGAq367YUGAqz67YUGAvCVx+sKArOm4YsNAoD6+eoNArb6+eoNAuyV04QBAremldsEAoX6+eoNArP6+eoNAumV04QBAramldsEAob6+eoNArD6+eoNAuqV04QBArWmldsEAoP6+eoNArX6+eoNAu+V04QBArSmldsEAt+upY8KAuHFoawJAuKupY8KAuDFoawJAuGupY8KAt/FoawJAp/d3qkLApjEvsgBAuyy8tADAuyy7tADAuyy6tADAuyy5tADAq23pOQJAqPen9gCAtOW7JgPApKa4tUJAoHtr5kOuxdSQxFgMCatPdTQVOQi8Bg4SSs=" />
</div>
    <div id=container>
        <div id=head>
           <table width="100%">
              <tr>
                <td>
                    </td>
                <td>
                </td>
                <td align="right">
                    <a id="ctl00_LinkButton3" class="zhuxiao" href="javascript:WebForm_DoPostBackWithOptions(new WebForm_PostBackOptions(&quot;ctl00$LinkButton3&quot;, &quot;&quot;, false, &quot;&quot;, &quot;StudentDefault.aspx&quot;, false, true))">实验说明</a> &nbsp;&nbsp;&nbsp;&nbsp;
                    <a id="ctl00_LinkButton2" class="zhuxiao" href="javascript:WebForm_DoPostBackWithOptions(new WebForm_PostBackOptions(&quot;ctl00$LinkButton2&quot;, &quot;&quot;, false, &quot;&quot;, &quot;LearningStyleText.aspx&quot;, false, true))">学习风格测试</a>
                    &nbsp;&nbsp;&nbsp;&nbsp;<a id="ctl00_LinkButton1" class="zhuxiao" href="javascript:WebForm_DoPostBackWithOptions(new WebForm_PostBackOptions(&quot;ctl00$LinkButton1&quot;, &quot;&quot;, false, &quot;&quot;, &quot;Login.aspx&quot;, false, true))">注销</a>
                    &nbsp;
                </td>

              </tr>
            </table>
            
    <center>
    <span id="ctl00_ContentPlaceHolderCTop_lblTitle" class="titleLow">初级练习题</span>
    </center>

        </div>
        <div id=content>
            
    <div id="ctl00_ContentPlaceHolderContent_PanelAll" style="height:829px;width:753px;overflow-y:scroll;">
	
    <table class="style1">
          <tr>
          <td class="style2">
                <span id="ctl00_ContentPlaceHolderContent_Label5" class="title">一、</span></td>
            <td colspan="5"><span id="ctl00_ContentPlaceHolderContent_Label1" class="title">单选题</span>
           </td>
          </tr>
        <tr>
            <td class="style2" align="right" valign="top">
               <span id="ctl00_ContentPlaceHolderContent_lblNum1" class="question">1.</span></td>
            <td colspan="4">
                <span id="ctl00_ContentPlaceHolderContent_lblS1" class="question">若一个方法声明中含有static修饰符，则称该方法为（  ）。</span>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                &nbsp;</td>
            <td colspan="4"  valign="top">
                <table id="ctl00_ContentPlaceHolderContent_rdolistS1" class="question" border="0" style="width:456px;">
		<tr>
			<td><input id="ctl00_ContentPlaceHolderContent_rdolistS1_0" type="radio" name="ctl00$ContentPlaceHolderContent$rdolistS1" value="A" /><label for="ctl00_ContentPlaceHolderContent_rdolistS1_0">A.静态方法</label></td><td><input id="ctl00_ContentPlaceHolderContent_rdolistS1_1" type="radio" name="ctl00$ContentPlaceHolderContent$rdolistS1" value="B" /><label for="ctl00_ContentPlaceHolderContent_rdolistS1_1">B.动态方法</label></td><td><input id="ctl00_ContentPlaceHolderContent_rdolistS1_2" type="radio" name="ctl00$ContentPlaceHolderContent$rdolistS1" value="C" /><label for="ctl00_ContentPlaceHolderContent_rdolistS1_2">C.虚拟方法</label></td><td><input id="ctl00_ContentPlaceHolderContent_rdolistS1_3" type="radio" name="ctl00$ContentPlaceHolderContent$rdolistS1" value="D" /><label for="ctl00_ContentPlaceHolderContent_rdolistS1_3">D.实例方法</label></td>
		</tr>
	</table>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                &nbsp;</td>
            <td class="style8">
                <span id="ctl00_ContentPlaceHolderContent_lblS1A" class="answer">错误！正确答案：C</span>
            </td>
            <td align="right">
                <input type="submit" name="ctl00$ContentPlaceHolderContent$btnS1E" value="解析" id="ctl00_ContentPlaceHolderContent_btnS1E" style="border-style:None;font-family:微软雅黑;" />
            </td>
            <td colspan="2">
                <span id="ctl00_ContentPlaceHolderContent_lblS1E" class="explain"></span>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2"align="right"  valign="top">
               <span id="ctl00_ContentPlaceHolderContent_lblNum2" class="question">2.</span></td>
            <td colspan="4">
                <span id="ctl00_ContentPlaceHolderContent_lblS2" class="question">在C#语言中，使用（  ）关键字来声明类。</span>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                &nbsp;</td>
            <td colspan="4"  valign="top">
                <table id="ctl00_ContentPlaceHolderContent_rdolistS2" class="question" border="0" style="width:456px;">
		<tr>
			<td><input id="ctl00_ContentPlaceHolderContent_rdolistS2_0" type="radio" name="ctl00$ContentPlaceHolderContent$rdolistS2" value="A" /><label for="ctl00_ContentPlaceHolderContent_rdolistS2_0">A.class</label></td><td><input id="ctl00_ContentPlaceHolderContent_rdolistS2_1" type="radio" name="ctl00$ContentPlaceHolderContent$rdolistS2" value="B" /><label for="ctl00_ContentPlaceHolderContent_rdolistS2_1">B.public</label></td><td><input id="ctl00_ContentPlaceHolderContent_rdolistS2_2" type="radio" name="ctl00$ContentPlaceHolderContent$rdolistS2" value="C" /><label for="ctl00_ContentPlaceHolderContent_rdolistS2_2">C.name</label></td><td><input id="ctl00_ContentPlaceHolderContent_rdolistS2_3" type="radio" name="ctl00$ContentPlaceHolderContent$rdolistS2" value="D" /><label for="ctl00_ContentPlaceHolderContent_rdolistS2_3">D.system</label></td>
		</tr>
	</table>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                &nbsp;</td>
            <td class="style8">
                <span id="ctl00_ContentPlaceHolderContent_lblS2A" class="answer">错误！正确答案：A</span>
            </td>
            <td align="right">
                <input type="submit" name="ctl00$ContentPlaceHolderContent$btnS2E" value="解析" id="ctl00_ContentPlaceHolderContent_btnS2E" style="border-style:None;font-family:微软雅黑;" />
            </td>
            <td colspan="2">
                <span id="ctl00_ContentPlaceHolderContent_lblS2E" class="explain"></span>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2" align="right"  valign="top">
               <span id="ctl00_ContentPlaceHolderContent_lblNum3" class="question">3.</span></td>
            <td colspan="4">
                <span id="ctl00_ContentPlaceHolderContent_lblS3" class="question">下列选项中，属于类的数据成员的是（  ）。</span>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                &nbsp;</td>
            <td colspan="4"  valign="top">
                <table id="ctl00_ContentPlaceHolderContent_rdolistS3" class="question" border="0" style="width:456px;">
		<tr>
			<td><input id="ctl00_ContentPlaceHolderContent_rdolistS3_0" type="radio" name="ctl00$ContentPlaceHolderContent$rdolistS3" value="A" /><label for="ctl00_ContentPlaceHolderContent_rdolistS3_0">A.方法</label></td><td><input id="ctl00_ContentPlaceHolderContent_rdolistS3_1" type="radio" name="ctl00$ContentPlaceHolderContent$rdolistS3" value="B" /><label for="ctl00_ContentPlaceHolderContent_rdolistS3_1">B.字段</label></td><td><input id="ctl00_ContentPlaceHolderContent_rdolistS3_2" type="radio" name="ctl00$ContentPlaceHolderContent$rdolistS3" value="C" /><label for="ctl00_ContentPlaceHolderContent_rdolistS3_2">C.属性</label></td><td><input id="ctl00_ContentPlaceHolderContent_rdolistS3_3" type="radio" name="ctl00$ContentPlaceHolderContent$rdolistS3" value="D" /><label for="ctl00_ContentPlaceHolderContent_rdolistS3_3">D.析构函数</label></td>
		</tr>
	</table>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                &nbsp;</td>
            <td class="style8">
                <span id="ctl00_ContentPlaceHolderContent_lblS3A" class="answer">错误！正确答案：A</span>
            </td>
            <td align="right">
                <input type="submit" name="ctl00$ContentPlaceHolderContent$btnS3E" value="解析" id="ctl00_ContentPlaceHolderContent_btnS3E" style="border-style:None;font-family:微软雅黑;" />
            </td>
            <td colspan="2">
                <span id="ctl00_ContentPlaceHolderContent_lblS3E" class="explain"></span>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2" align="right"  valign="top">
               <span id="ctl00_ContentPlaceHolderContent_lblNum4" class="question">4.</span></td>
            <td colspan="4">
                <span id="ctl00_ContentPlaceHolderContent_lblS4" class="question">在属性的访问声明中，对属性的值的写操作用（  ）关键字标出。</span>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                &nbsp;</td>
            <td colspan="4"  valign="top">
                <table id="ctl00_ContentPlaceHolderContent_rdolistS4" class="question" border="0" style="width:456px;">
		<tr>
			<td><input id="ctl00_ContentPlaceHolderContent_rdolistS4_0" type="radio" name="ctl00$ContentPlaceHolderContent$rdolistS4" value="A" /><label for="ctl00_ContentPlaceHolderContent_rdolistS4_0">A.set</label></td><td><input id="ctl00_ContentPlaceHolderContent_rdolistS4_1" type="radio" name="ctl00$ContentPlaceHolderContent$rdolistS4" value="B" /><label for="ctl00_ContentPlaceHolderContent_rdolistS4_1">B.get</label></td><td><input id="ctl00_ContentPlaceHolderContent_rdolistS4_2" type="radio" name="ctl00$ContentPlaceHolderContent$rdolistS4" value="C" /><label for="ctl00_ContentPlaceHolderContent_rdolistS4_2">C.public</label></td><td><input id="ctl00_ContentPlaceHolderContent_rdolistS4_3" type="radio" name="ctl00$ContentPlaceHolderContent$rdolistS4" value="D" /><label for="ctl00_ContentPlaceHolderContent_rdolistS4_3">D.private</label></td>
		</tr>
	</table>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                &nbsp;</td>
            <td class="style8">
                <span id="ctl00_ContentPlaceHolderContent_lblS4A" class="answer">错误！正确答案：A</span>
            </td>
            <td align="right">
                <input type="submit" name="ctl00$ContentPlaceHolderContent$btnS4E" value="解析" id="ctl00_ContentPlaceHolderContent_btnS4E" style="border-style:None;font-family:微软雅黑;" />
            </td>
            <td colspan="2">
                <span id="ctl00_ContentPlaceHolderContent_lblS4E" class="explain"></span>
            </td>
            <td>
                &nbsp;</td>
        </tr>
         <tr>
            <td class="style2" align="right"  valign="top">
               <span id="ctl00_ContentPlaceHolderContent_lblNum5" class="question">5.</span></td>
            <td colspan="4">
                <span id="ctl00_ContentPlaceHolderContent_lblS5" class="question">（  ）类没有任何直接基类，并且是所有其他类的终极基类。</span>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                &nbsp;</td>
            <td colspan="4"  valign="top">
                <table id="ctl00_ContentPlaceHolderContent_rdolistS5" class="question" border="0" style="width:456px;">
		<tr>
			<td><input id="ctl00_ContentPlaceHolderContent_rdolistS5_0" type="radio" name="ctl00$ContentPlaceHolderContent$rdolistS5" value="A" /><label for="ctl00_ContentPlaceHolderContent_rdolistS5_0">A.object</label></td><td><input id="ctl00_ContentPlaceHolderContent_rdolistS5_1" type="radio" name="ctl00$ContentPlaceHolderContent$rdolistS5" value="B" /><label for="ctl00_ContentPlaceHolderContent_rdolistS5_1">B.class</label></td><td><input id="ctl00_ContentPlaceHolderContent_rdolistS5_2" type="radio" name="ctl00$ContentPlaceHolderContent$rdolistS5" value="C" /><label for="ctl00_ContentPlaceHolderContent_rdolistS5_2">C.struct</label></td><td><input id="ctl00_ContentPlaceHolderContent_rdolistS5_3" type="radio" name="ctl00$ContentPlaceHolderContent$rdolistS5" value="D" /><label for="ctl00_ContentPlaceHolderContent_rdolistS5_3">D.frame</label></td>
		</tr>
	</table>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                &nbsp;</td>
            <td class="style8">
                <span id="ctl00_ContentPlaceHolderContent_lblS5A" class="answer">错误！正确答案：A</span>
            </td>
            <td align="right">
                <input type="submit" name="ctl00$ContentPlaceHolderContent$btnS5E" value="解析" id="ctl00_ContentPlaceHolderContent_btnS5E" style="border-style:None;font-family:微软雅黑;" />
            </td>
            <td colspan="2">
                <span id="ctl00_ContentPlaceHolderContent_lblS5E" class="explain"></span>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
          <td class="style2">
               <span id="ctl00_ContentPlaceHolderContent_Label6" class="title">二、</span></td>
            <td colspan="5"><span id="ctl00_ContentPlaceHolderContent_Label2" class="title">判断题</span>
           </td>
          </tr>
        <tr>
            <td class="style2" align="right" valign="top">
               <span id="ctl00_ContentPlaceHolderContent_lblNum11" class="question">1.</span>
              </td>
            <td colspan="4">
                <span id="ctl00_ContentPlaceHolderContent_lblJ1" class="question">空字符串和空值null是相同的。</span>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        
        <tr>
            <td class="style2">&nbsp;</td>
            <td colspan="4"  valign="top">
                <table id="ctl00_ContentPlaceHolderContent_rdolistJ1" class="question" border="0" style="width:230px;">
		<tr>
			<td><input id="ctl00_ContentPlaceHolderContent_rdolistJ1_0" type="radio" name="ctl00$ContentPlaceHolderContent$rdolistJ1" value="T" /><label for="ctl00_ContentPlaceHolderContent_rdolistJ1_0">T</label></td><td><input id="ctl00_ContentPlaceHolderContent_rdolistJ1_1" type="radio" name="ctl00$ContentPlaceHolderContent$rdolistJ1" value="F" /><label for="ctl00_ContentPlaceHolderContent_rdolistJ1_1">F</label></td>
		</tr>
	</table>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                &nbsp;</td>
            <td class="style8">
                <span id="ctl00_ContentPlaceHolderContent_lblJ1A" class="answer">错误！正确答案：T</span>
            </td>
            <td align="right">
                <input type="submit" name="ctl00$ContentPlaceHolderContent$btnJ1E" value="解析" id="ctl00_ContentPlaceHolderContent_btnJ1E" style="border-style:None;font-family:微软雅黑;" />
            </td>
            <td colspan="2">
                <span id="ctl00_ContentPlaceHolderContent_lblJ1E" class="explain"></span>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2" align="right"  valign="top">
               <span id="ctl00_ContentPlaceHolderContent_lblNum12" class="question">2.</span></td>
               
            <td colspan="4">
                <span id="ctl00_ContentPlaceHolderContent_lblJ2" class="question">构造函数没有返回类型，它可以带参数，也可以不带参数。</span>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2" >&nbsp;</td>
            <td colspan="2"  valign="top">
                <table id="ctl00_ContentPlaceHolderContent_rdolistJ2" class="question" border="0" style="width:230px;">
		<tr>
			<td><input id="ctl00_ContentPlaceHolderContent_rdolistJ2_0" type="radio" name="ctl00$ContentPlaceHolderContent$rdolistJ2" value="T" /><label for="ctl00_ContentPlaceHolderContent_rdolistJ2_0">T</label></td><td><input id="ctl00_ContentPlaceHolderContent_rdolistJ2_1" type="radio" name="ctl00$ContentPlaceHolderContent$rdolistJ2" value="F" /><label for="ctl00_ContentPlaceHolderContent_rdolistJ2_1">F</label></td>
		</tr>
	</table>
            </td>
            <td>
                &nbsp;</td>
            <td class="style3">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                &nbsp;</td>
            <td class="style8">
                <span id="ctl00_ContentPlaceHolderContent_lblJ2A" class="answer">错误！正确答案：T</span>
            </td>
            <td align="right">
                <input type="submit" name="ctl00$ContentPlaceHolderContent$btnJ2E" value="解析" id="ctl00_ContentPlaceHolderContent_btnJ2E" style="border-style:None;font-family:微软雅黑;" />
            </td>
            <td colspan="2">
                <span id="ctl00_ContentPlaceHolderContent_lblJ2E" class="explain"></span>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2" align="right"  valign="top">
               <span id="ctl00_ContentPlaceHolderContent_lblNum13" class="question">3.</span></td>
               
            <td colspan="4">
                <span id="ctl00_ContentPlaceHolderContent_lblJ3" class="question">Object类是.net类库中最顶层的基类。</span>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2" >&nbsp;</td>
            <td colspan="2"  valign="top">
                <table id="ctl00_ContentPlaceHolderContent_rdolistJ3" class="question" border="0" style="width:230px;">
		<tr>
			<td><input id="ctl00_ContentPlaceHolderContent_rdolistJ3_0" type="radio" name="ctl00$ContentPlaceHolderContent$rdolistJ3" value="T" /><label for="ctl00_ContentPlaceHolderContent_rdolistJ3_0">T</label></td><td><input id="ctl00_ContentPlaceHolderContent_rdolistJ3_1" type="radio" name="ctl00$ContentPlaceHolderContent$rdolistJ3" value="F" /><label for="ctl00_ContentPlaceHolderContent_rdolistJ3_1">F</label></td>
		</tr>
	</table>
            </td>
            <td>
                &nbsp;</td>
            <td class="style3">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                &nbsp;</td>
            <td class="style8">
                <span id="ctl00_ContentPlaceHolderContent_lblJ3A" class="answer">错误！正确答案：T</span>
            </td>
            <td align="right">
                <input type="submit" name="ctl00$ContentPlaceHolderContent$btnJ3E" value="解析" id="ctl00_ContentPlaceHolderContent_btnJ3E" style="border-style:None;font-family:微软雅黑;" />
            </td>
            <td colspan="2">
                <span id="ctl00_ContentPlaceHolderContent_lblJ3E" class="explain"></span>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2" align="right"  valign="top">
               <span id="ctl00_ContentPlaceHolderContent_lblNum14" class="question">4.</span></td>
                
            <td colspan="4">
                <span id="ctl00_ContentPlaceHolderContent_lblJ4" class="question">用ref修饰符声明的形参是引用形参。</span>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">&nbsp;</td>
            <td colspan="4"  valign="top">
                <table id="ctl00_ContentPlaceHolderContent_rdolistJ4" class="question" border="0" style="width:230px;">
		<tr>
			<td><input id="ctl00_ContentPlaceHolderContent_rdolistJ4_0" type="radio" name="ctl00$ContentPlaceHolderContent$rdolistJ4" value="T" /><label for="ctl00_ContentPlaceHolderContent_rdolistJ4_0">T</label></td><td><input id="ctl00_ContentPlaceHolderContent_rdolistJ4_1" type="radio" name="ctl00$ContentPlaceHolderContent$rdolistJ4" value="F" /><label for="ctl00_ContentPlaceHolderContent_rdolistJ4_1">F</label></td>
		</tr>
	</table>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                &nbsp;</td>
            <td class="style8">
                <span id="ctl00_ContentPlaceHolderContent_lblJ4A" class="answer">错误！正确答案：F</span>
            </td>
            <td align="right">
                <input type="submit" name="ctl00$ContentPlaceHolderContent$btnJ4E" value="解析" id="ctl00_ContentPlaceHolderContent_btnJ4E" style="border-style:None;font-family:微软雅黑;" />
            </td>
            <td colspan="2">
                <span id="ctl00_ContentPlaceHolderContent_lblJ4E" class="explain"></span>
            </td>
            <td>
                &nbsp;</td>
        </tr> 
        <tr>
          <td class="style2">
              <span id="ctl00_ContentPlaceHolderContent_Label7" class="title">三、</span></td>
            <td colspan="5"><span id="ctl00_ContentPlaceHolderContent_Label3" class="title">填空题</span>
           </td>
          </tr>  
        <tr>
            <td class="style2" align="right" valign="top">
               <span id="ctl00_ContentPlaceHolderContent_lblNum21" class="question">1.</span></td>
            <td colspan="4">
                <span id="ctl00_ContentPlaceHolderContent_lblB1" class="qFront">任何事物都是</span>_______
                <span id="ctl00_ContentPlaceHolderContent_lblB12" class="qBack">，它可以是现实世界中的一个物理对象，可以是抽象的概念或规则。</span>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2"align="right" valign="top">
               <span id="ctl00_ContentPlaceHolderContent_lblNum22" class="question">2.</span></td>
            <td colspan="4">     
                <span id="ctl00_ContentPlaceHolderContent_lblB2" class="qFront">引用型参数通过</span>_______
                <span id="ctl00_ContentPlaceHolderContent_lblB22" class="qBack">关键字加以修饰。</span>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2"align="right" valign="top">
               <span id="ctl00_ContentPlaceHolderContent_lblNum23" class="question">3.</span></td>
            <td colspan="4">
                <span id="ctl00_ContentPlaceHolderContent_lblB3" class="qFront">类的属性通常包括</span>_______
                <span id="ctl00_ContentPlaceHolderContent_lblB32" class="qBack">访问器和set访问器。</span>
            </td>
            <td>
                &nbsp;</td>
        </tr>
         <tr>
            <td class="style2">
                &nbsp;</td>
            <td colspan="4">
                <span id="ctl00_ContentPlaceHolderContent_lblB11">(1)</span>
                <input name="ctl00$ContentPlaceHolderContent$txtB11" type="text" id="ctl00_ContentPlaceHolderContent_txtB11" class="qFront" style="margin-left: 0px" />
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                &nbsp;</td>
            <td class="style8">
                <span id="ctl00_ContentPlaceHolderContent_lblB11A" class="answer">×    正确答案：null</span>
            </td>
            <td align="right">
                <input type="submit" name="ctl00$ContentPlaceHolderContent$btnB11E" value="解析" id="ctl00_ContentPlaceHolderContent_btnB11E" style="border-style:None;font-family:微软雅黑;" />
            </td>
            <td colspan="2">
                <span id="ctl00_ContentPlaceHolderContent_lblB11E" class="explain"></span>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                &nbsp;</td>
            <td colspan="4">
                <span id="ctl00_ContentPlaceHolderContent_lblB21">(2)</span>
                <input name="ctl00$ContentPlaceHolderContent$txtB21" type="text" id="ctl00_ContentPlaceHolderContent_txtB21" class="qFront" style="margin-left: 0px" />
            </td>
            <td>
                &nbsp;</td>
        </tr>
         <tr>
            <td class="style2">
                &nbsp;</td>
            <td class="style8">
                <span id="ctl00_ContentPlaceHolderContent_lblB21A" class="answer">×    正确答案：return</span>
            </td>
            <td align="right">
                <input type="submit" name="ctl00$ContentPlaceHolderContent$btnB21E" value="解析" id="ctl00_ContentPlaceHolderContent_btnB21E" style="border-style:None;font-family:微软雅黑;" />
            </td>
            <td colspan="2">
                <span id="ctl00_ContentPlaceHolderContent_lblB21E" class="explain"></span>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                &nbsp;</td>
            <td colspan="4">
                <span id="ctl00_ContentPlaceHolderContent_lblB31">(3)</span>
                <input name="ctl00$ContentPlaceHolderContent$txtB31" type="text" id="ctl00_ContentPlaceHolderContent_txtB31" class="qFront" style="margin-left: 0px" />
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                &nbsp;</td>
            <td class="style8">
                <span id="ctl00_ContentPlaceHolderContent_lblB31A" class="answer">×    正确答案：protected</span>
            </td>
            <td align="right">
                <input type="submit" name="ctl00$ContentPlaceHolderContent$btnB31E" value="解析" id="ctl00_ContentPlaceHolderContent_btnB31E" style="border-style:None;font-family:微软雅黑;" />
            </td>
            <td colspan="2">
                <span id="ctl00_ContentPlaceHolderContent_lblB31E" class="explain"></span>
            </td>
            <td>
                &nbsp;</td>
        </tr>
            
        <tr>
          <td class="style2">
               <span id="ctl00_ContentPlaceHolderContent_Label8" class="title">四、</span></td>
            <td colspan="5"><span id="ctl00_ContentPlaceHolderContent_Label4" class="title">设计题</span>
           </td>
          </tr>  
        <tr>
            <td class="style2"align="right" valign="top">
               <span id="ctl00_ContentPlaceHolderContent_lblNum41" class="question">1.</span></td>
            <td colspan="4">
                <span id="ctl00_ContentPlaceHolderContent_lblD1" class="question">输入一个年份看是否为闰年。（请用DateTime类的方法实现）</span>
            </td>
            <td>
                &nbsp;</td>
        </tr>
       <tr>
          <td class="style2">
                &nbsp;</td>
            <td colspan="5"><textarea name="ctl00$ContentPlaceHolderContent$TextBox1" rows="2" cols="20" id="ctl00_ContentPlaceHolderContent_TextBox1" style="height:69px;width:463px;"></textarea>
           </td>
       </tr>  
       <tr>
          <td class="style2">
              &nbsp;
          </td>
            <td colspan="5"><span id="ctl00_ContentPlaceHolderContent_lblD1A" class="answer">正确答案：Q1</span>
                <input type="submit" name="ctl00$ContentPlaceHolderContent$btnanswer" value="答案下载" id="ctl00_ContentPlaceHolderContent_btnanswer" style="border-style:None;font-family:微软雅黑;" />
           </td>
       </tr>  
    </table>
    
</div>

        </div>
        <div id=information>
          <table width="100%">
            <tr>
              <td rowspan="4" height="130" width="112" valign="top">
            <img id="ctl00_imgphoto" src="load/IMG_0186.JPG" style="height:130px;width:105px;border-width:0px;" />
        </td>
              <td>姓名:<span id="ctl00_lblstuName">陶燕云</span></td>
            </tr>
            <tr>
              <td>班级:<span id="ctl00_lblclassName">教技101</span></td>
            </tr>
            <tr>
              <td>学号:<span id="ctl00_lblstuId">10140114</span></td>
            </tr>
            <tr>
              <td>性别:<span id="ctl00_lblgender">男        </span></td>
            </tr>
            
          </table>
        </div>
        <div id=function>
          <table>
            <tr>
              <td><input type="image" name="ctl00$ImageButton1" id="ctl00_ImageButton1" border="0px" src="images/student_40.gif" style="border-width:0px;border-style:None;" /></td>
            </tr>
            <tr>
              <td><input type="image" name="ctl00$ImageButton2" id="ctl00_ImageButton2" border="0px" src="images/student_42.gif" style="border-width:0px;border-style:None;" /></td>
            </tr>
            <tr>
              <td><input type="image" name="ctl00$ImageButton3" id="ctl00_ImageButton3" border="0px" src="images/student_43.gif" style="border-width:0px;border-style:None;" /></td>
            </tr>
            <tr>
              <td><input type="image" name="ctl00$ImageButton4" id="ctl00_ImageButton4" border="0px" src="images/student_44.gif" style="border-width:0px;border-style:None;" /></td>
            </tr>
          </table>
        </div>
         <div id=unit>
          
    <center>
        <table>
            <tr>
                <td >
                    </td>
            </tr>
            <tr>
                <td>
                    <a href="#ctl00_ContentPlaceHolderUnit_infotree1_TreeView1_SkipLink"><img alt="跳过导航链接。" src="/SelfAdaptivePlatform/WebResource.axd?d=AsElU24qNT7KN8B8dGe4ZVZbeZMg494ixfeW8le_bOg0e-8EPkEu8DJgGe7zpDkBQ8I9EoM3dvMtf3bpLRODp2qBzvE1&amp;t=634963807833437500" width="0" height="0" style="border-width:0px;" /></a><div id="ctl00_ContentPlaceHolderUnit_infotree1_TreeView1" style="color:#003300;font-family:微软雅黑;">
	<table cellpadding="0" cellspacing="0" style="border-width:0;">
		<tr>
			<td><a id="ctl00_ContentPlaceHolderUnit_infotree1_TreeView1n0" href="javascript:TreeView_ToggleNode(ctl00_ContentPlaceHolderUnit_infotree1_TreeView1_Data,0,ctl00_ContentPlaceHolderUnit_infotree1_TreeView1n0,' ',ctl00_ContentPlaceHolderUnit_infotree1_TreeView1n0Nodes)"><img src="images/1.png" alt="折叠 第一单元" style="border-width:0;" /></a></td><td style="white-space:nowrap;"><a class="ctl00_ContentPlaceHolderUnit_infotree1_TreeView1_0" href="javascript:__doPostBack('ctl00$ContentPlaceHolderUnit$infotree1$TreeView1','s第一单元')" onclick="TreeView_SelectNode(ctl00_ContentPlaceHolderUnit_infotree1_TreeView1_Data, this,'ctl00_ContentPlaceHolderUnit_infotree1_TreeView1t0');" id="ctl00_ContentPlaceHolderUnit_infotree1_TreeView1t0">第一单元</a></td>
		</tr>
	</table><div id="ctl00_ContentPlaceHolderUnit_infotree1_TreeView1n0Nodes" style="display:block;">
		<table cellpadding="0" cellspacing="0" style="border-width:0;">
			<tr>
				<td><div style="width:20px;height:1px"></div></td><td><a id="ctl00_ContentPlaceHolderUnit_infotree1_TreeView1n1" href="javascript:TreeView_ToggleNode(ctl00_ContentPlaceHolderUnit_infotree1_TreeView1_Data,1,ctl00_ContentPlaceHolderUnit_infotree1_TreeView1n1,' ',ctl00_ContentPlaceHolderUnit_infotree1_TreeView1n1Nodes)"><img src="images/1.png" alt="折叠 实验" style="border-width:0;" /></a></td><td style="white-space:nowrap;"><a class="ctl00_ContentPlaceHolderUnit_infotree1_TreeView1_0" href="javascript:__doPostBack('ctl00$ContentPlaceHolderUnit$infotree1$TreeView1','s第一单元\\实验')" onclick="TreeView_SelectNode(ctl00_ContentPlaceHolderUnit_infotree1_TreeView1_Data, this,'ctl00_ContentPlaceHolderUnit_infotree1_TreeView1t1');" id="ctl00_ContentPlaceHolderUnit_infotree1_TreeView1t1">实验</a></td>
			</tr>
		</table><div id="ctl00_ContentPlaceHolderUnit_infotree1_TreeView1n1Nodes" style="display:block;">
			<table cellpadding="0" cellspacing="0" style="border-width:0;">
				<tr>
					<td><div style="width:20px;height:1px"></div></td><td><div style="width:20px;height:1px"></div></td><td><img src="/SelfAdaptivePlatform/WebResource.axd?d=LZmWgk9k-iLWZ7VbxnAY-Ybbiq04KpSUdFZqZtS-KeSji5G5LgR7zd8n6N2oXIfdbfu4_a2_FZvMNwvznN6cmwbFjR5jQ7p8leSZfrt5WmU0i59V0&amp;t=634963807833437500" alt="" /></td><td style="white-space:nowrap;"><a class="ctl00_ContentPlaceHolderUnit_infotree1_TreeView1_0" href="BeforeText.aspx" id="ctl00_ContentPlaceHolderUnit_infotree1_TreeView1t2">前测</a></td>
				</tr>
			</table><table cellpadding="0" cellspacing="0" style="border-width:0;">
				<tr>
					<td><div style="width:20px;height:1px"></div></td><td><div style="width:20px;height:1px"></div></td><td><a id="ctl00_ContentPlaceHolderUnit_infotree1_TreeView1n3" href="javascript:TreeView_ToggleNode(ctl00_ContentPlaceHolderUnit_infotree1_TreeView1_Data,3,ctl00_ContentPlaceHolderUnit_infotree1_TreeView1n3,' ',ctl00_ContentPlaceHolderUnit_infotree1_TreeView1n3Nodes)"><img src="images/1.png" alt="折叠 测试" style="border-width:0;" /></a></td><td style="white-space:nowrap;"><a class="ctl00_ContentPlaceHolderUnit_infotree1_TreeView1_0" href="javascript:__doPostBack('ctl00$ContentPlaceHolderUnit$infotree1$TreeView1','s第一单元\\实验\\测试')" onclick="TreeView_SelectNode(ctl00_ContentPlaceHolderUnit_infotree1_TreeView1_Data, this,'ctl00_ContentPlaceHolderUnit_infotree1_TreeView1t3');" id="ctl00_ContentPlaceHolderUnit_infotree1_TreeView1t3">测试</a></td>
				</tr>
			</table><div id="ctl00_ContentPlaceHolderUnit_infotree1_TreeView1n3Nodes" style="display:block;">
				<table cellpadding="0" cellspacing="0" style="border-width:0;">
					<tr>
						<td><div style="width:20px;height:1px"></div></td><td><div style="width:20px;height:1px"></div></td><td><div style="width:20px;height:1px"></div></td><td><img src="/SelfAdaptivePlatform/WebResource.axd?d=LZmWgk9k-iLWZ7VbxnAY-Ybbiq04KpSUdFZqZtS-KeSji5G5LgR7zd8n6N2oXIfdbfu4_a2_FZvMNwvznN6cmwbFjR5jQ7p8leSZfrt5WmU0i59V0&amp;t=634963807833437500" alt="" /></td><td style="white-space:nowrap;"><a class="ctl00_ContentPlaceHolderUnit_infotree1_TreeView1_0" href="TestLow.aspx?caid=0" id="ctl00_ContentPlaceHolderUnit_infotree1_TreeView1t4">初级</a></td>
					</tr>
				</table><table cellpadding="0" cellspacing="0" style="border-width:0;">
					<tr>
						<td><div style="width:20px;height:1px"></div></td><td><div style="width:20px;height:1px"></div></td><td><div style="width:20px;height:1px"></div></td><td><img src="/SelfAdaptivePlatform/WebResource.axd?d=LZmWgk9k-iLWZ7VbxnAY-Ybbiq04KpSUdFZqZtS-KeSji5G5LgR7zd8n6N2oXIfdbfu4_a2_FZvMNwvznN6cmwbFjR5jQ7p8leSZfrt5WmU0i59V0&amp;t=634963807833437500" alt="" /></td><td style="white-space:nowrap;"><a class="ctl00_ContentPlaceHolderUnit_infotree1_TreeView1_0" href="TestMid.aspx?caid=0" id="ctl00_ContentPlaceHolderUnit_infotree1_TreeView1t5">中级</a></td>
					</tr>
				</table><table cellpadding="0" cellspacing="0" style="border-width:0;">
					<tr>
						<td><div style="width:20px;height:1px"></div></td><td><div style="width:20px;height:1px"></div></td><td><div style="width:20px;height:1px"></div></td><td><img src="/SelfAdaptivePlatform/WebResource.axd?d=LZmWgk9k-iLWZ7VbxnAY-Ybbiq04KpSUdFZqZtS-KeSji5G5LgR7zd8n6N2oXIfdbfu4_a2_FZvMNwvznN6cmwbFjR5jQ7p8leSZfrt5WmU0i59V0&amp;t=634963807833437500" alt="" /></td><td style="white-space:nowrap;"><a class="ctl00_ContentPlaceHolderUnit_infotree1_TreeView1_0" href="TestHigh.aspx?caid=0" id="ctl00_ContentPlaceHolderUnit_infotree1_TreeView1t6">高级</a></td>
					</tr>
				</table>
			</div>
		</div><table cellpadding="0" cellspacing="0" style="border-width:0;">
			<tr>
				<td><div style="width:20px;height:1px"></div></td><td><a id="ctl00_ContentPlaceHolderUnit_infotree1_TreeView1n7" href="javascript:TreeView_ToggleNode(ctl00_ContentPlaceHolderUnit_infotree1_TreeView1_Data,7,ctl00_ContentPlaceHolderUnit_infotree1_TreeView1n7,' ',ctl00_ContentPlaceHolderUnit_infotree1_TreeView1n7Nodes)"><img src="images/1.png" alt="折叠 练习" style="border-width:0;" /></a></td><td style="white-space:nowrap;"><a class="ctl00_ContentPlaceHolderUnit_infotree1_TreeView1_0" href="javascript:__doPostBack('ctl00$ContentPlaceHolderUnit$infotree1$TreeView1','s第一单元\\练习')" onclick="TreeView_SelectNode(ctl00_ContentPlaceHolderUnit_infotree1_TreeView1_Data, this,'ctl00_ContentPlaceHolderUnit_infotree1_TreeView1t7');" id="ctl00_ContentPlaceHolderUnit_infotree1_TreeView1t7">练习</a></td>
			</tr>
		</table><div id="ctl00_ContentPlaceHolderUnit_infotree1_TreeView1n7Nodes" style="display:block;">
			<table cellpadding="0" cellspacing="0" style="border-width:0;">
				<tr>
					<td><div style="width:20px;height:1px"></div></td><td><div style="width:20px;height:1px"></div></td><td><img src="/SelfAdaptivePlatform/WebResource.axd?d=LZmWgk9k-iLWZ7VbxnAY-Ybbiq04KpSUdFZqZtS-KeSji5G5LgR7zd8n6N2oXIfdbfu4_a2_FZvMNwvznN6cmwbFjR5jQ7p8leSZfrt5WmU0i59V0&amp;t=634963807833437500" alt="" /></td><td style="white-space:nowrap;"><a class="ctl00_ContentPlaceHolderUnit_infotree1_TreeView1_0" href="ExerciseLow.aspx" id="ctl00_ContentPlaceHolderUnit_infotree1_TreeView1t8">初级</a></td>
				</tr>
			</table><table cellpadding="0" cellspacing="0" style="border-width:0;">
				<tr>
					<td><div style="width:20px;height:1px"></div></td><td><div style="width:20px;height:1px"></div></td><td><img src="/SelfAdaptivePlatform/WebResource.axd?d=LZmWgk9k-iLWZ7VbxnAY-Ybbiq04KpSUdFZqZtS-KeSji5G5LgR7zd8n6N2oXIfdbfu4_a2_FZvMNwvznN6cmwbFjR5jQ7p8leSZfrt5WmU0i59V0&amp;t=634963807833437500" alt="" /></td><td style="white-space:nowrap;"><a class="ctl00_ContentPlaceHolderUnit_infotree1_TreeView1_0" href="ExerciseMid.aspx" id="ctl00_ContentPlaceHolderUnit_infotree1_TreeView1t9">中级</a></td>
				</tr>
			</table><table cellpadding="0" cellspacing="0" style="border-width:0;">
				<tr>
					<td><div style="width:20px;height:1px"></div></td><td><div style="width:20px;height:1px"></div></td><td><img src="/SelfAdaptivePlatform/WebResource.axd?d=LZmWgk9k-iLWZ7VbxnAY-Ybbiq04KpSUdFZqZtS-KeSji5G5LgR7zd8n6N2oXIfdbfu4_a2_FZvMNwvznN6cmwbFjR5jQ7p8leSZfrt5WmU0i59V0&amp;t=634963807833437500" alt="" /></td><td style="white-space:nowrap;"><a class="ctl00_ContentPlaceHolderUnit_infotree1_TreeView1_0" href="ExerciseHigh.aspx" id="ctl00_ContentPlaceHolderUnit_infotree1_TreeView1t10">高级</a></td>
				</tr>
			</table>
		</div>
	</div>
</div><a id="ctl00_ContentPlaceHolderUnit_infotree1_TreeView1_SkipLink"></a>


                </td>
            </tr>
        </table>
    
    </center>

       </div>
        <div id=buttom>
           
    <center>
  <input type="submit" name="ctl00$ContentPlaceHolderCBottom$btnOk" value="确定" id="ctl00_ContentPlaceHolderCBottom_btnOk" disabled="disabled" style="font-family:微软雅黑;font-size:Medium;height:30px;width:50px;" />
  </center>

        </div>
        <div id=down>
         <table width="100%">
              <tr>
                <td align="center">
                  <span class="bottomtext">浙江师范大学&nbsp;&nbsp; 教师教育学院&nbsp;&nbsp; 教育技术学<br />陶燕云&nbsp; 胡哲玮&nbsp; 朱思奇&nbsp; 黄宇玲</span>
                </td>
              </tr>
            </table>
       </div> 
    </div>
    
<script type="text/javascript">
//<![CDATA[
var ctl00_ContentPlaceHolderUnit_infotree1_TreeView1_ImageArray =  new Array('', '', '', '/SelfAdaptivePlatform/WebResource.axd?d=LZmWgk9k-iLWZ7VbxnAY-Ybbiq04KpSUdFZqZtS-KeSji5G5LgR7zd8n6N2oXIfdbfu4_a2_FZvMNwvznN6cmwbFjR5jQ7p8leSZfrt5WmU0i59V0&t=634963807833437500', 'images/2.png', 'images/1.png');
//]]>
</script>


<script type="text/javascript">
//<![CDATA[

WebForm_InitCallback();var ctl00_ContentPlaceHolderUnit_infotree1_TreeView1_Data = new Object();
ctl00_ContentPlaceHolderUnit_infotree1_TreeView1_Data.images = ctl00_ContentPlaceHolderUnit_infotree1_TreeView1_ImageArray;
ctl00_ContentPlaceHolderUnit_infotree1_TreeView1_Data.collapseToolTip = "折叠 {0}";
ctl00_ContentPlaceHolderUnit_infotree1_TreeView1_Data.expandToolTip = "展开 {0}";
ctl00_ContentPlaceHolderUnit_infotree1_TreeView1_Data.expandState = theForm.elements['ctl00_ContentPlaceHolderUnit_infotree1_TreeView1_ExpandState'];
ctl00_ContentPlaceHolderUnit_infotree1_TreeView1_Data.selectedNodeID = theForm.elements['ctl00_ContentPlaceHolderUnit_infotree1_TreeView1_SelectedNode'];
for (var i=0;i<6;i++) {
var preLoad = new Image();
if (ctl00_ContentPlaceHolderUnit_infotree1_TreeView1_ImageArray[i].length > 0)
preLoad.src = ctl00_ContentPlaceHolderUnit_infotree1_TreeView1_ImageArray[i];
}
ctl00_ContentPlaceHolderUnit_infotree1_TreeView1_Data.lastIndex = 11;
ctl00_ContentPlaceHolderUnit_infotree1_TreeView1_Data.populateLog = theForm.elements['ctl00_ContentPlaceHolderUnit_infotree1_TreeView1_PopulateLog'];
ctl00_ContentPlaceHolderUnit_infotree1_TreeView1_Data.treeViewID = 'ctl00$ContentPlaceHolderUnit$infotree1$TreeView1';
ctl00_ContentPlaceHolderUnit_infotree1_TreeView1_Data.name = 'ctl00_ContentPlaceHolderUnit_infotree1_TreeView1_Data';
//]]>
</script>
</form>
</body>
</html>
