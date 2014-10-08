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

public partial class ExerciseMid : System.Web.UI.Page
{
    static RadioMid r1 = new RadioMid();
    static RadioMid r2 = new RadioMid();
    static RadioMid r3 = new RadioMid();
    static RadioMid r4 = new RadioMid();
    static RadioMid r5 = new RadioMid();
    static JudgeMid j1 = new JudgeMid();
    static JudgeMid j2 = new JudgeMid();
    static JudgeMid j3 = new JudgeMid();
    static JudgeMid j4 = new JudgeMid();
    static BlankMid b1 = new BlankMid();
    static BlankMid b2 = new BlankMid();
    static BlankMid b3 = new BlankMid();
    static DesignMid d1 = new DesignMid();
    string learningLevel = "mid";

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
                int iUp = TestMidManager.CountRadio();
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
                r1 = TestMidManager.GetRadio(n[0]);
                TestMidManager.ShowQuestionRadio(r1, rdolistS1, lblS1);
                r2 = TestMidManager.GetRadio(n[1]);
                TestMidManager.ShowQuestionRadio(r2, rdolistS2, lblS2);
                r3 = TestMidManager.GetRadio(n[2]);
                TestMidManager.ShowQuestionRadio(r3, rdolistS3, lblS3);
                r4 = TestMidManager.GetRadio(n[3]);
                TestMidManager.ShowQuestionRadio(r4, rdolistS4, lblS4);
                r5 = TestMidManager.GetRadio(n[4]);
                TestMidManager.ShowQuestionRadio(r5, rdolistS5, lblS5);

                //随机出题
                int iUp1 = TestMidManager.CountJudge();
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

                j1 = TestMidManager.GetJudge(j[0]);
                TestMidManager.ShowQuestionJudge(j1, rdolistJ1, lblJ1);
                j2 = TestMidManager.GetJudge(j[1]);
                TestMidManager.ShowQuestionJudge(j2, rdolistJ2, lblJ2);
                j3 = TestMidManager.GetJudge(j[2]);
                TestMidManager.ShowQuestionJudge(j3, rdolistJ3, lblJ3);
                j4 = TestMidManager.GetJudge(j[3]);
                TestMidManager.ShowQuestionJudge(j4, rdolistJ4, lblJ4);

                //随机出题
                int iUp2 = TestMidManager.CountBlank();
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

                b1 = TestMidManager.GetBlank(k[0]);
                TestMidManager.ShowQuestionBlank(b1, lblB1, lblB12);
                b2 = TestMidManager.GetBlank(k[1]);
                TestMidManager.ShowQuestionBlank(b2, lblB2, lblB22);
                b3 = TestMidManager.GetBlank(k[2]);
                TestMidManager.ShowQuestionBlank(b3, lblB3, lblB32);

                //随机出题
                int iUp3 = TestMidManager.CountDesign();
                int[] m = new int[2];
                m[0] = ran.Next(iDown, iUp3);

                d1 = TestMidManager.GetDesign(m[0]);
                TestMidManager.ShowQuestionDesign2(d1, lblD1);
            }
            else
            {
                Response.Redirect("Login.aspx");
            }
            
        }
    }
    protected void btnOk_Click(object sender, EventArgs e)
    {
        TestMidManager.JudgingRadio(rdolistS1, r1, lblS1A, btnS1E);
        TestMidManager.JudgingRadio(rdolistS2, r2, lblS2A, btnS2E);
        TestMidManager.JudgingRadio(rdolistS3, r3, lblS3A, btnS3E);
        TestMidManager.JudgingRadio(rdolistS4, r4, lblS4A, btnS4E);
        TestMidManager.JudgingRadio(rdolistS5, r5, lblS5A, btnS5E);
        TestMidManager.JudgingJudge(rdolistJ1, j1, lblJ1A, btnJ1E);
        TestMidManager.JudgingJudge(rdolistJ2, j2, lblJ2A, btnJ2E);
        TestMidManager.JudgingJudge(rdolistJ3, j3, lblJ3A, btnJ3E);
        TestMidManager.JudgingJudge(rdolistJ4, j4, lblJ4A, btnJ4E);
        TestMidManager.JudgingBlank(b1, txtB11, lblB11A, btnB11E);
        TestMidManager.JudgingBlank(b2, txtB21, lblB21A, btnB21E);
        TestMidManager.JudgingBlank(b3, txtB21, lblB31A, btnB31E);
        TestMidManager.JudgingDesign(d1, btnanswer);
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
