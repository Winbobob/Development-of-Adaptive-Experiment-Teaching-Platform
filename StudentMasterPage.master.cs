using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using SelfAdaptivePlatform.Model;
using SelfAdaptivePlatform.BLL;


public partial class StudentMasterPage : System.Web.UI.MasterPage
{
    static StudentInfo stuNews1 = new StudentInfo();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["stuId"] != null)
        {
            string stuId = Session["stuId"].ToString();
            stuNews1 = StudentInfoManager.Getstudentnews(stuId);
            StudentInfoManager.Showstudentnews(stuNews1, lblstuId, lblstuName, lblclassName, lblgender, imgphoto);
            Session["stutext"] = "";

        }
        else
        {
            Response.Redirect("Login.aspx");
        }

    }

    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("StudentRevise.aspx");
    }



    protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("StudentClassUnit.aspx");
    }
    protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
    {
        BreakingPointRadio bpr = new BreakingPointRadio();
        bpr = BreakingPointManager.LoadBreakingPointRadio(Session["stuId"].ToString());
        BreakingPointJudge bpj = new BreakingPointJudge();
        bpj = BreakingPointManager.LoadBreakingPointJudge(Session["stuId"].ToString());
        BreakingPointBlank bpb = new BreakingPointBlank();
        bpb = BreakingPointManager.LoadBreakingPointBlank(Session["stuId"].ToString());
        BreakingPointDesign bpd = new BreakingPointDesign();
        bpd = BreakingPointManager.LoadBreakingPointDesign(Session["stuId"].ToString());
        string learningLevel1 = bpr.learningLevel;
        if (learningLevel1 == "low")
        {
            Response.Redirect("TestLow.aspx?caid=1");
        }
        else if (learningLevel1 == "mid")
        {
            Response.Redirect("TestMid.aspx?caid=1");
        }
        else if (learningLevel1 == "high")
        {
            Response.Redirect("TestHigh.aspx?caid=1");
        }
        else
        {
            //Response.Redirect("StudentDefault.aspx");
            MsgBox("没有断点记录！", "StudentDefault.aspx");
        }

    }
    /// <summary>
    /// 显示“确定”，点击以后就转到预设网址的提示框
    /// </summary>
    /// <param name="_Msg">提示信息</param>
    /// <param name="URL">“确定”以后要转到预设网址</param>
    /// <returns>提示框JS</returns>
    public void MsgBox(string strMsg, string URL)
    {
        string StrScript;
        StrScript = ("<script language=javascript>");
        StrScript += ("alert('" + strMsg + "');");
        StrScript += ("window.location='" + URL + "';");
        StrScript += ("</script>");
        System.Web.HttpContext.Current.Response.Write(StrScript);
    }

    protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("WrongRadio.aspx?caid=0");
    }
    protected void LinkButton4_Click(object sender, EventArgs e)
    {
        Session["stuId"] = lblstuId.Text;
        Session["stutext"] = "";
        Response.Redirect("StudyData/StudyDataDefault.aspx");
    }
}
