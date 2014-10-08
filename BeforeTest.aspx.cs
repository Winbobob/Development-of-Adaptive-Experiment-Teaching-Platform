using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using SelfAdaptivePlatform.Model;
using SelfAdaptivePlatform.BLL;

public partial class BeforeTest : System.Web.UI.Page
{
    static RadioLow rLow1 = new RadioLow();
    static RadioLow rLow2 = new RadioLow();
    static RadioLow rLow3 = new RadioLow();
    static RadioLow rLow4 = new RadioLow();
    static RadioLow rLow5 = new RadioLow();
    static JudgeLow jLow1 = new JudgeLow();
    static JudgeLow jLow2 = new JudgeLow();
    static JudgeLow jLow3 = new JudgeLow();
    static JudgeLow jLow4 = new JudgeLow();
    static JudgeLow jLow5 = new JudgeLow();
    static ClassUnit stuNews1 = new ClassUnit();
    string learningLevel = "pretest";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Session["stuId"] != null)
            {
                int score1 = 0;
                string stuId = Session["stuId"].ToString();
                stuNews1 = ClassUnitManager.GetStudyingInform(stuId);    //获取学生各部分成绩
                score1 = stuNews1.pretest;    //获取前测分数
                //判断前测分数是否到60分
                if (score1 < 60)
                {
                    //随机出题
                    long tick = DateTime.Now.Ticks;
                    Random ran = new Random((int)(tick & 0xffffffffL) | (int)(tick >> 32));
                    int iDown = 1;
                    int iUp = TestLowManager.CountRadioLow();
                    int[] n = new int[5];
                    while (true)
                    {
                        int i = 0;
                        n[0] = ran.Next(iDown, iUp);
                        n[1] = ran.Next(iDown, iUp);
                        n[2] = ran.Next(iDown, iUp);
                        n[3] = ran.Next(iDown, iUp);
                        n[4] = ran.Next(iDown, iUp);
                        //题目不重复
                        if (n[0] != n[1] && n[0] != n[2] && n[0] != n[3] && n[0] != n[4] && n[1] != n[2] && n[1] != n[3] && n[1] != n[4] && n[2] != n[3] && n[2] != n[4] && n[3] != n[4])
                        {
                            i = 4;
                        }
                        if (i == 4) break;
                    }
                    rLow1 = TestLowManager.GetLowRadio(n[0]);    //获取前测单选题题目
                    TestLowManager.ShowQuestionRadioLow(rLow1, rdolistS1, lblS1);    //显示单选题题目
                    rLow2 = TestLowManager.GetLowRadio(n[1]);
                    TestLowManager.ShowQuestionRadioLow(rLow2, rdolistS2, lblS2);
                    rLow3 = TestLowManager.GetLowRadio(n[2]);
                    TestLowManager.ShowQuestionRadioLow(rLow3, rdolistS3, lblS3);
                    rLow4 = TestLowManager.GetLowRadio(n[3]);
                    TestLowManager.ShowQuestionRadioLow(rLow4, rdolistS4, lblS4);
                    rLow5 = TestLowManager.GetLowRadio(n[4]);
                    TestLowManager.ShowQuestionRadioLow(rLow5, rdolistS5, lblS5);
                    //随机出题
                    int iUp1 = TestLowManager.CountJudgeLow();
                    int[] j = new int[5];
                    while (true)
                    {
                        int i = 0;
                        j[0] = ran.Next(iDown, iUp1);
                        j[1] = ran.Next(iDown, iUp1);
                        j[2] = ran.Next(iDown, iUp1);
                        j[3] = ran.Next(iDown, iUp1);
                        j[4] = ran.Next(iDown, iUp1);
                        if (j[0] != j[1] && j[0] != j[2] && j[0] != j[3] && j[0] != j[4] && j[1] != j[2] && j[1] != j[3] && j[1] != j[4] && j[2] != j[3] && j[2] != j[4] && j[3] != j[4])
                        {
                            i = 4;
                        }
                        if (i == 4) break;
                    }
                    jLow1 = TestLowManager.GetLowJudge(j[0]);     //获取前测判断题题目
                    TestLowManager.ShowQuestionJudgeLow(jLow1, rdolistJ1, lblJ1);    //显示判断题题目
                    jLow2 = TestLowManager.GetLowJudge(j[1]);
                    TestLowManager.ShowQuestionJudgeLow(jLow2, rdolistJ2, lblJ2);
                    jLow3 = TestLowManager.GetLowJudge(j[2]);
                    TestLowManager.ShowQuestionJudgeLow(jLow3, rdolistJ3, lblJ3);
                    jLow4 = TestLowManager.GetLowJudge(j[3]);
                    TestLowManager.ShowQuestionJudgeLow(jLow4, rdolistJ4, lblJ4);
                    jLow5 = TestLowManager.GetLowJudge(j[4]);
                    TestLowManager.ShowQuestionJudgeLow(jLow5, rdolistJ5, lblJ5);
                }
                //判断前测分数是否在60至75分之间
                else if (score1 >= 60 && score1 < 75)
                {
                    lblTitle.Visible = false;
                    PanelAll.Visible = false;
                    btnOk.Visible = false;
                    Response.Write("<script type = 'text/javascript'> alert('你已通过前测，可直接进入低级测试单元！'); </script>");
                    //RegisterClientScriptBlock("", string.Format("<script type = 'text/javascript'>  alert('你已通过前测，可直接进入低级测试单元！');location.href= 'TestLow.aspx?caid=0'</script>"));

                }
                //判断前测分数是否在75至90分之间
                else if (score1 >= 75 && score1 < 90)
                {
                    lblTitle.Visible = false;
                    PanelAll.Visible = false;
                    btnOk.Visible = false;
                    //Response.Write("<script type = 'text/javascript'> alert('你已通过前测，可直接进入中级测试单元！'); </script>");
                    RegisterClientScriptBlock("", "<script>alert('你已通过前测，可直接进入中级测试单元！')</script>");
                    //RegisterClientScriptBlock("", string.Format("<script type = 'text/javascript'>  alert('你已通过前测，可直接进入中级测试单元！');location.href= 'TestMid.aspx?caid=0'</script>"));
                }
                else
                {
                    lblTitle.Visible = false;
                    PanelAll.Visible = false;
                    btnOk.Visible = false;
                    //Response.Write("<script type = 'text/javascript'> alert('你已通过前测，可直接进入高级测试单元！'); </script>");
                    RegisterClientScriptBlock("", "<script>alert('你已通过前测，可直接进入高级测试单元！')</script>");
                    //RegisterClientScriptBlock("", string.Format("<script type = 'text/javascript'>  alert('你已通过前测，可直接进入高级测试单元！');location.href= 'TestHigh.aspx?caid=0'</script>"));
                }
            }
            else
            {
                Response.Redirect("Login.aspx");
            }
        }
    }
    //点击提交按钮事件
    protected void btnOk_Click(object sender, EventArgs e)
    {
        btnOk.Enabled = false;
        //单选题判定，判断对错，显示正确答案
        TestLowManager.JudgingRadio(rdolistS1, rLow1, lblS1A, btnS1E);    
        TestLowManager.JudgingRadio(rdolistS2, rLow2, lblS2A, btnS2E);
        TestLowManager.JudgingRadio(rdolistS3, rLow3, lblS3A, btnS3E);
        TestLowManager.JudgingRadio(rdolistS4, rLow4, lblS4A, btnS4E);
        TestLowManager.JudgingRadio(rdolistS5, rLow5, lblS5A, btnS5E);
        //判断题判定，判断对错，显示正确答案
        TestLowManager.JudgingJudge(rdolistJ1, jLow1, lblJ1A, btnJ1E);    
        TestLowManager.JudgingJudge(rdolistJ2, jLow2, lblJ2A, btnJ2E);
        TestLowManager.JudgingJudge(rdolistJ3, jLow3, lblJ3A, btnJ3E);
        TestLowManager.JudgingJudge(rdolistJ4, jLow4, lblJ4A, btnJ4E);
        TestLowManager.JudgingJudge(rdolistJ5, jLow5, lblJ5A, btnJ5E);
        //判断分数等级
        int scoreJudge = TestLowManager.Score2(TestLowManager.radioScore2(rLow1, rLow2, rLow3, rLow4, rLow5, rdolistS1, rdolistS2, rdolistS3, rdolistS4, rdolistS5), TestLowManager.judgeScore2(jLow1, jLow2, jLow3, jLow4, jLow5, rdolistJ1, rdolistJ2, rdolistJ3, rdolistJ4, rdolistJ5));
        string stuId = Session["stuId"].ToString();
        //将分数写入成绩表中 
        TestLowManager.UpdateStudyingScore(stuId, learningLevel, TestLowManager.radioScore2(rLow1, rLow2, rLow3, rLow4, rLow5, rdolistS1, rdolistS2, rdolistS3, rdolistS4, rdolistS5)
            + TestLowManager.judgeScore2(jLow1, jLow2, jLow3, jLow4, jLow5, rdolistJ1, rdolistJ2, rdolistJ3, rdolistJ4, rdolistJ5));
        string str = null;
        //判断测试等级
        str = TestLowManager.ShowScoreString2(TestLowManager.radioScore2(rLow1, rLow2, rLow3, rLow4, rLow5, rdolistS1, rdolistS2, rdolistS3, rdolistS4, rdolistS5), TestLowManager.judgeScore2(jLow1, jLow2, jLow3, jLow4, jLow5, rdolistJ1, rdolistJ2, rdolistJ3, rdolistJ4, rdolistJ5), scoreJudge);
        //Response.Write(string.Format("<script type = 'text/javascript'> alert('{0}'); </script>", str));
        RegisterClientScriptBlock("", string.Format("<script type = 'text/javascript'> alert('{0}'); </script>", str));
    }
    //显示解析
    protected void btnS1E_Click(object sender, EventArgs e)
    {
        lblS1E.Text = rLow1.explain;
    }
    protected void btnS2E_Click(object sender, EventArgs e)
    {
        lblS2E.Text = rLow2.explain;
    }
    protected void btnS3E_Click(object sender, EventArgs e)
    {
        lblS3E.Text = rLow3.explain;
    }
    protected void btnS4E_Click(object sender, EventArgs e)
    {
        lblS4E.Text = rLow4.explain;
    }
    protected void btnS5E_Click(object sender, EventArgs e)
    {
        lblS5E.Text = rLow5.explain;
    }
    protected void btnJ1E_Click(object sender, EventArgs e)
    {
        lblJ1E.Text = jLow1.explain;
    }
    protected void btnJ2E_Click(object sender, EventArgs e)
    {
        lblJ2E.Text = jLow2.explain;
    }
    protected void btnJ3E_Click(object sender, EventArgs e)
    {
        lblJ3E.Text = jLow3.explain;
    }
    protected void btnJ4E_Click(object sender, EventArgs e)
    {
        lblJ4E.Text = jLow4.explain;
    }
    protected void btnJ5E_Click(object sender, EventArgs e)
    {
        lblJ5E.Text = jLow5.explain;
    }
}
