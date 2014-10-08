using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using SelfAdaptivePlatform.Model;
using SelfAdaptivePlatform.BLL;

public partial class StudyingInform3 : System.Web.UI.Page
{
    DataSet infor = new DataSet();
    static ClassUnit stuNews1 = new ClassUnit();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["stuId"] != null)
        {
            //GridView显示
            string stuId = Session["stuId"].ToString();
            //调用ShowData方法，返回DataSet数据集
            infor = Manage.ShowData2("ClassUnit", stuId);
            GridView1.DataSource = infor;
            GridView1.DataBind();

            //折线图显示
            stuNews1 = ClassUnitManager.GetStudyingInform(stuId);
            int pre = int.Parse(ClassUnitManager.GetStudyingInformpre());
            int low = int.Parse(ClassUnitManager.GetStudyingInformlow());
            int mid =int.Parse( ClassUnitManager.GetStudyingInformmid());
            int high = int.Parse(ClassUnitManager.GetStudyingInformhigh());
            int designlow =int.Parse( ClassUnitManager.GetStudyingInformdelow());
            int designmid=int.Parse( ClassUnitManager.GetStudyingInformdemid());
            int designhigh = int.Parse(ClassUnitManager.GetStudyingInformdehigh());
            int total =int.Parse( ClassUnitManager.GetStudyingInformtotal());
            double[] yval = {stuNews1.pretest,stuNews1.low,stuNews1.mid,stuNews1.high,stuNews1.designLow,stuNews1.designMid,stuNews1.designHigh,stuNews1.totalScore};
            string[] xval = { "前测", "初级测试", "中级测试", "高级测试","初级设计题","中级设计题","高级设计题" ,"总成绩"};
            double[] yval2 = {pre,low,mid,high,designlow,designmid,designhigh,total};
            string[] xval2 = { "前测", "初级测试", "中级测试", "高级测试", "初级设计题", "中级设计题", "高级设计题", "总成绩" };
            Chart1.Series["Series1"].Points.DataBindXY(xval, yval);
            Chart1.Series["Series2"].Points.DataBindXY(xval2, yval2);
            Chart1.Series["Series1"].IsValueShownAsLabel = true;
            Chart1.Series["Series2"].IsValueShownAsLabel = true;
        }
        else
        {
            Response.Redirect("Login.aspx");
        }   
    }
}