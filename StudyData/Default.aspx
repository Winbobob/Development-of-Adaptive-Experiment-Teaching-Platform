<%@ Page Title="" Language="C#" MasterPageFile="~/StudyData/StudyDataMasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
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
GB_showCenter("例题", "../example/exampleText1.aspx", 320, 630);
}
</script> 
<style type="text/css">
    input{cursor:pointer;height: 30px;width: 154px;font-family: 微软雅黑;color:#6B8E23;font-size:17px;}
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderTop" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderInformation" Runat="Server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolderLeft" Runat="Server">
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="ContentPlaceHolderContent" Runat="Server">
<input type="button" value="例题" onclick="openWinCenter()" /><br/> 
</asp:Content>

