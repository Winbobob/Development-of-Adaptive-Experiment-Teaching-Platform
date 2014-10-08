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

public partial class ExerciseHigh : System.Web.UI.Page
{
    static RadioHigh r1 = new RadioHigh();
    static RadioHigh r2 = new RadioHigh();
    static RadioHigh r3 = new RadioHigh();
    static RadioHigh r4 = new RadioHigh();
    static RadioHigh r5 = new RadioHigh();
    static JudgeHigh j1 = new JudgeHigh();
    static JudgeHigh j2 = new JudgeHigh();
    static JudgeHigh j3 = new JudgeHigh();
    static JudgeHigh j4 = new JudgeHigh();
    static BlankHigh b1 = new BlankHigh();
    static BlankHigh b2 = new BlankHigh();
    static BlankHigh b3 = new BlankHigh();
    static DesignHigh d1 = new DesignHigh();
    string learningLevel = "high";

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
                int iUp = TestHighManager.CountRadio();
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
                r1 = TestHighManager.GetRadio(n[0]);
                TestHighManager.ShowQuestionRadio(r1, rdolistS1, lblS1);
                r2 = TestHighManager.GetRadio(n[1]);
                TestHighManager.ShowQuestionRadio(r2, rdolistS2, lblS2);
                r3 = TestHighManager.GetRadio(n[2]);
                TestHighManager.ShowQuestionRadio(r3, rdolistS3, lblS3);
                r4 = TestHighManager.GetRadio(n[3]);
                TestHighManager.ShowQuestionRadio(r4, rdolistS4, lblS4);
                r5 = TestHighManager.GetRadio(n[4]);
                TestHighManager.ShowQuestionRadio(r5, rdolistS5, lblS5);

                //随机出题
                int iUp1 = TestHighManager.CountJudge();
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

                j1 = TestHighManager.GetJudge(j[0]);
                TestHighManager.ShowQuestionJudge(j1, rdolistJ1, lblJ1);
                j2 = TestHighManager.GetJudge(j[1]);
                TestHighManager.ShowQuestionJudge(j2, rdolistJ2, lblJ2);
                j3 = TestHighManager.GetJudge(j[2]);
                TestHighManager.ShowQuestionJudge(j3, rdolistJ3, lblJ3);
                j4 = TestHighManager.GetJudge(j[3]);
                TestHighManager.ShowQuestionJudge(j4, rdolistJ4, lblJ4);

                //随机出题
                int iUp2 = TestHighManager.CountBlank();
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

                b1 = TestHighManager.GetBlank(k[0]);
                TestHighManager.ShowQuestionBlank(b1, lblB1, lblB12);
                b2 = TestHighManager.GetBlank(k[1]);
                TestHighManager.ShowQuestionBlank(b2, lblB2, lblB22);
                b3 = TestHighManager.GetBlank(k[2]);
                TestHighManager.ShowQuestionBlank(b3, lblB3, lblB32);

                //随机出题
                int iUp3 = TestHighManager.CountDesign();
                int[] m = new int[2];
                m[0] = ran.Next(iDown, iUp3);

                d1 = TestHighManager.GetDesign(m[0]);
                TestHighManager.ShowQuestionDesign2(d1, lblD1);
            }
            else
            {
                Response.Redirect("Login.aspx");
            }
        }
    }
    protected void btnOk_Click(object sender, EventArgs e)
    {
        TestHighManager.JudgingRadio(rdolistS1, r1, lblS1A, btnS1E);
        TestHighManager.JudgingRadio(rdolistS2, r2, lblS2A, btnS2E);
        TestHighManager.JudgingRadio(rdolistS3, r3, lblS3A, btnS3E);
        TestHighManager.JudgingRadio(rdolistS4, r4, lblS4A, btnS4E);
        TestHighManager.JudgingRadio(rdolistS5, r5, lblS5A, btnS5E);
        TestHighManager.JudgingJudge(rdolistJ1, j1, lblJ1A, btnJ1E);
        TestHighManager.JudgingJudge(rdolistJ2, j2, lblJ2A, btnJ2E);
        TestHighManager.JudgingJudge(rdolistJ3, j3, lblJ3A, btnJ3E);
        TestHighManager.JudgingJudge(rdolistJ4, j4, lblJ4A, btnJ4E);
        TestHighManager.JudgingBlank(b1, txtB11, lblB11A, btnB11E);
        TestHighManager.JudgingBlank(b2, txtB21, lblB21A, btnB21E);
        TestHighManager.JudgingBlank(b3, txtB21, lblB31A, btnB31E);
        TestHighManager.JudgingDesign(d1, btnanswer);
        btnOk.Enabled = false;
    }
    protected void btnS1E_Click(object sender, EventArgs e)
    {
        lblS1E.Text = r1.explain;
    }
    protected void btnS2E_Click(object sender, EventArgs e)
    {
        lblS2E.Text = r2.explain;
    }
    protected void btnS3E_Click(object sender, EventArgs e)
    {
        lblS3E.Text = r3.explain;
    }
    protected void btnS4E_Click(object sender, EventArgs e)
    {
        lblS4E.Text = r4.explain;
    }
    protected void btnS5E_Click(object sender, EventArgs e)
    {
        lblS5E.Text = r5.explain;
    }
    protected void btnJ1E_Click(object sender, EventArgs e)
    {
        lblJ1E.Text = j1.explain;
    }
    protected void btnJ2E_Click(object sender, EventArgs e)
    {
        lblJ2E.Text = j2.explain;
    }
    protected void btnJ3E_Click(object sender, EventArgs e)
    {
        lblJ3E.Text = j3.explain;
    }
    protected void btnJ4E_Click(object sender, EventArgs e)
    {
        lblJ4E.Text = j4.explain;
    }
    protected void btnB11E_Click(object sender, EventArgs e)
    {
        lblB11E.Text = "   解析：" + b1.explain;
    }
    protected void btnB21E_Click(object sender, EventArgs e)
    {
        lblB21E.Text = "   解析：" + b1.explain;
    }
    protected void btnB31E_Click(object sender, EventArgs e)
    {
        lblB31E.Text = "   解析：" + b1.explain;
    }
    protected void btnanswer_Click(object sender, EventArgs e)
    {
        string Q = d1.answer;
        string filename = Path.GetFileName("~/DesignAnswer/" + Q + ".cs");
        Response.Clear(); Response.ContentType = "application/octet-stream ";
        Response.AppendHeader("Content-Disposition", "attachment;Filename =" + System.Convert.ToChar(34) + filename + System.Convert.ToChar(34));
        Response.Charset = "";
        Response.ContentEncoding = System.Text.Encoding.UTF8;
        Response.Flush();
        Response.WriteFile("~/DesignAnswer/" + Q + ".cs");
    }
}
