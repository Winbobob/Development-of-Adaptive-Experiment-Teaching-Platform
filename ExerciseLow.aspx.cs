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
using System.IO;

public partial class ExerciseLow : System.Web.UI.Page
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
    static BlankLow bLow1 = new BlankLow();
    static BlankLow bLow2 = new BlankLow();
    static BlankLow bLow3 = new BlankLow();
    static DesignLow dLow1 = new DesignLow();
    string learningLevel = "low";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)    
        {
            if (Session["stuId"] != null)
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
                    if (n[0] != n[1] && n[0] != n[2] && n[0] != n[3] && n[0] != n[4] && n[1] != n[2] && n[1] != n[3] && n[1] != n[4] && n[2] != n[3] && n[2] != n[4] && n[3] != n[4])
                    {
                        i = 4;
                    }
                    if (i == 4) break;
                }
                rLow1 = TestLowManager.GetLowRadio(n[0]);
                TestLowManager.ShowQuestionRadioLow(rLow1, rdolistS1, lblS1);
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
                int[] j = new int[4];
                while (true)
                {
                    int i = 0;
                    j[0] = ran.Next(iDown, iUp1);
                    j[1] = ran.Next(iDown, iUp1);
                    j[2] = ran.Next(iDown, iUp1);
                    j[3] = ran.Next(iDown, iUp1);
                    if (j[0] != j[1] && j[0] != j[2] && j[0] != j[3] && j[1] != j[2] && j[1] != j[3] && j[2] != j[3])
                    {
                        i = 3;
                    }
                    if (i == 3) break;
                }
                jLow1 = TestLowManager.GetLowJudge(j[0]);
                TestLowManager.ShowQuestionJudgeLow(jLow1, rdolistJ1, lblJ1);
                jLow2 = TestLowManager.GetLowJudge(j[1]);
                TestLowManager.ShowQuestionJudgeLow(jLow2, rdolistJ2, lblJ2);
                jLow3 = TestLowManager.GetLowJudge(j[2]);
                TestLowManager.ShowQuestionJudgeLow(jLow3, rdolistJ3, lblJ3);
                jLow4 = TestLowManager.GetLowJudge(j[3]);
                TestLowManager.ShowQuestionJudgeLow(jLow4, rdolistJ4, lblJ4);
                //随机出题
                int iUp2 = TestLowManager.CountBlankLow();
                int[] k = new int[3];
                while (true)
                {
                    int i = 0;
                    k[0] = ran.Next(iDown, iUp2);
                    k[1] = ran.Next(iDown, iUp2);
                    k[2] = ran.Next(iDown, iUp2);
                    if (k[0] != k[1] && k[0] != k[2] && k[1] != k[2])
                    {
                        i = 2;
                    }
                    if (i == 2) break;
                }
                bLow1 = TestLowManager.GetLowBlank(k[0]);
                TestLowManager.ShowQuestionBlankLow(bLow1, lblB1, lblB12);
                bLow2 = TestLowManager.GetLowBlank(k[1]);
                TestLowManager.ShowQuestionBlankLow(bLow2, lblB2, lblB22);
                bLow3 = TestLowManager.GetLowBlank(k[2]);
                TestLowManager.ShowQuestionBlankLow(bLow3, lblB3, lblB32);
                //随机出题
                int iUp3 = TestLowManager.CountDesignlow();
                int[] m = new int[2];
                m[0] = ran.Next(iDown, iUp3);
                dLow1 = TestLowManager.GetLowDesign(m[0]);
                TestLowManager.ShowQuestionDesignLow2(dLow1, lblD1);
            }
            else
            {
                Response.Redirect("Login.aspx");
            }
        }
    }
    //点击确定按钮事件
    protected void btnOk_Click(object sender, EventArgs e)
    {
        TestLowManager.JudgingRadio(rdolistS1, rLow1, lblS1A, btnS1E);
        TestLowManager.JudgingRadio(rdolistS2, rLow2, lblS2A, btnS2E);
        TestLowManager.JudgingRadio(rdolistS3, rLow3, lblS3A, btnS3E);
        TestLowManager.JudgingRadio(rdolistS4, rLow4, lblS4A, btnS4E);
        TestLowManager.JudgingRadio(rdolistS5, rLow5, lblS5A, btnS5E);
        TestLowManager.JudgingJudge(rdolistJ1, jLow1, lblJ1A, btnJ1E);
        TestLowManager.JudgingJudge(rdolistJ2, jLow2, lblJ2A, btnJ2E);
        TestLowManager.JudgingJudge(rdolistJ3, jLow3, lblJ3A, btnJ3E);
        TestLowManager.JudgingJudge(rdolistJ4, jLow4, lblJ4A, btnJ4E);
        TestLowManager.JudgingBlank(bLow1, txtB11, lblB11A, btnB11E);
        TestLowManager.JudgingBlank(bLow2, txtB21, lblB21A, btnB21E);
        TestLowManager.JudgingBlank(bLow3, txtB21, lblB31A, btnB31E);
        TestLowManager.JudgingDesign(dLow1,btnanswer);
        btnOk.Enabled = false;
    }
    //点击解析按钮事件
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
    protected void btnB11E_Click(object sender, EventArgs e)
    {
        lblB11E.Text = "   解析：" + bLow1.explain;
    }
    protected void btnB21E_Click(object sender, EventArgs e)
    {
        lblB21E.Text = "   解析：" + bLow1.explain;
    }
    protected void btnB31E_Click(object sender, EventArgs e)
    {
        lblB31E.Text = "   解析：" + bLow1.explain;
    }
    //点击答案下载按钮事件
    protected void btnanswer_Click(object sender, EventArgs e)
    {
        string Q = dLow1.answer;
        string filename = Path.GetFileName("~/DesignAnswer/" + Q + ".cs");
        Response.Clear(); Response.ContentType = "application/octet-stream ";
        Response.AppendHeader("Content-Disposition", "attachment;Filename =" + System.Convert.ToChar(34) + filename + System.Convert.ToChar(34));
        Response.Charset = "";
        Response.ContentEncoding = System.Text.Encoding.UTF8;
        Response.Flush();
        Response.WriteFile("~/DesignAnswer/" + Q + ".cs"); 
    }
}
