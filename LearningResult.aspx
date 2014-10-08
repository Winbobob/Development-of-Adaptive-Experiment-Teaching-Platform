<%@ Page Language="C#" AutoEventWireup="true" CodeFile="LearningResult.aspx.cs" Inherits="LearningResult" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>学习风格测试结果</title>
     <style type="text/css">
        .questionTitle
        {
            font-family: 微软雅黑;
            font-size: large;
            color: #009933;
            font-weight: bolder;
        }
    </style>
  
</head>
<body>
<center>
    <asp:Chart ID="Chart1" runat="server" BackColor="AliceBlue">
        <Series>
            <asp:Series Name="Series1" ChartType="Radar">
            </asp:Series>
        </Series>
        <ChartAreas>
            <asp:ChartArea Name="ChartArea1">
            </asp:ChartArea>
        </ChartAreas>
        <Titles>
            <asp:Title Text="学习风格测试结果雷达图" ForeColor="Green" ShadowColor="#00CC00"></asp:Title>
        </Titles>
    </asp:Chart>
    <br />
    <asp:Label ID="lblresult" runat="server" CssClass="questionTitle" ></asp:Label>
</center>
</body>
</html>
