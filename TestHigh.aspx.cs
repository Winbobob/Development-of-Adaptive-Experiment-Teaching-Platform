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
using System.Xml;
using System.Data.SqlClient;
using SelfAdaptivePlatform.Model;
using SelfAdaptivePlatform.BLL;
using System.IO;

public partial class TestHigh : System.Web.UI.Page
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
    bool correct = true;
    string learningLevel = "high";
    static ClassUnit stuNews1 = new ClassUnit();
    //static StudentInfo stuNew2 = new StudentInfo();
    //int[] rr = new int[6];  //用于存放错题的学习建议，有1~5中类型，数字长度选6

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)    //防止点保存后，页面再一次刷新，和验证码一样
        {
            if (Session["stuId"] != null)
            {
                //String Msg;
                int score1 = 0;
                int score2 = 0;
                int score3 = 0;
                int score4 = 0;
                string stuId = Session["stuId"].ToString();

                stuNews1 = ClassUnitManager.GetStudyingInform(stuId);
                score1 = stuNews1.pretest;
                score2 = stuNews1.low;
                score3 = stuNews1.mid;
                score4 = stuNews1.high;

                if (int.Parse(Request.QueryString["caid"].ToString().Trim()) == 1) //不是第一次做题，读取断点
                {
                    BreakingPointRadio bpr = new BreakingPointRadio();
                    bpr = BreakingPointManager.LoadBreakingPointRadio(Session["stuId"].ToString());

                    r1 = TestHighManager.GetRadio(bpr.r1);
                    TestHighManager.ShowQuestionRadio(r1, rdolistS1, lblS1);
                    r2 = TestHighManager.GetRadio(bpr.r2);
                    TestHighManager.ShowQuestionRadio(r2, rdolistS2, lblS2);
                    r3 = TestHighManager.GetRadio(bpr.r3);
                    TestHighManager.ShowQuestionRadio(r3, rdolistS3, lblS3);
                    r4 = TestHighManager.GetRadio(bpr.r4);
                    TestHighManager.ShowQuestionRadio(r4, rdolistS4, lblS4);
                    r5 = TestHighManager.GetRadio(bpr.r5);
                    TestHighManager.ShowQuestionRadio(r5, rdolistS5, lblS5);

                    BreakingPointJudge bpj = new BreakingPointJudge();
                    bpj = BreakingPointManager.LoadBreakingPointJudge(Session["stuId"].ToString());

                    j1 = TestHighManager.GetJudge(bpj.j1);
                    TestHighManager.ShowQuestionJudge(j1, rdolistJ1, lblJ1);
                    j2 = TestHighManager.GetJudge(bpj.j2);
                    TestHighManager.ShowQuestionJudge(j2, rdolistJ2, lblJ2);
                    j3 = TestHighManager.GetJudge(bpj.j3);
                    TestHighManager.ShowQuestionJudge(j3, rdolistJ3, lblJ3);
                    j4 = TestHighManager.GetJudge(bpj.j4);
                    TestHighManager.ShowQuestionJudge(j4, rdolistJ4, lblJ4);

                    BreakingPointBlank bpb = new BreakingPointBlank();
                    bpb = BreakingPointManager.LoadBreakingPointBlank(Session["stuId"].ToString());

                    b1 = TestHighManager.GetBlank(bpb.b1);
                    TestHighManager.ShowQuestionBlank(b1, lblB1, lblB12);
                    b2 = TestHighManager.GetBlank(bpb.b2);
                    TestHighManager.ShowQuestionBlank(b2, lblB2, lblB22);
                    b3 = TestHighManager.GetBlank(bpb.b3);
                    TestHighManager.ShowQuestionBlank(b3, lblB3, lblB32);

                    BreakingPointDesign bpd = new BreakingPointDesign();
                    bpd = BreakingPointManager.LoadBreakingPointDesign(Session["stuId"].ToString());

                    d1 = TestHighManager.GetDesign(bpd.d1);
                    TestHighManager.ShowQuestionDesign(d1, lblD1, lblD1S1, lblD1S2, rdolistD1S1, rdolistD1S2);

                    TestHighManager.ShowRadioBreakingpoint(bpr, rdolistS1, rdolistS2, rdolistS3, rdolistS4, rdolistS5);
                    TestHighManager.ShowJudgeBreakingpoint(bpj, rdolistJ1, rdolistJ2, rdolistJ3, rdolistJ4);
                    TestHighManager.ShowBlankBreakingpoint(bpb, txtB11, txtB21, txtB31);
                }
                else if (int.Parse(Request.QueryString["caid"].ToString().Trim()) == 0)
                {
                    if (score1 >= 90 || score3 >= 60)
                    {
                        //随机出题（加入错题的权重,原先的题号不变，多余的错题作为普通题目放到最后进行随机）

                        long tick = DateTime.Now.Ticks;
                        Random ran = new Random((int)(tick & 0xffffffffL) | (int)(tick >> 32));
                        int iDown = 1;
                        int iUp = TestHighManager.CountRadio();
                        int[] rr = new int[iUp + 1];
                        for (int mn = 1; mn <= TestHighManager.CountRadio(); mn++)
                        {
                            rr[mn] = WrongRadioManager.WrongRadionum(Session["stuId"].ToString(), mn, "High", "WrongRadio");
                            iUp = iUp + rr[mn];
                        }

                        int[] n = new int[5];
                        while (true)
                        {
                            int i;
                            n[0] = ran.Next(iDown, iUp);
                            n[1] = ran.Next(iDown, iUp);
                            n[2] = ran.Next(iDown, iUp);
                            n[3] = ran.Next(iDown, iUp);
                            n[4] = ran.Next(iDown, iUp);

                            //对随机选出的5个数重映射题号
                            for (i = 0; i <= 4; i++)
                            {
                                if (n[i] > TestHighManager.CountRadio())
                                {
                                    int temp;
                                    temp = n[i] - TestHighManager.CountRadio();
                                    int p;
                                    for (p = 1; p <= TestHighManager.CountRadio(); p++)
                                    {
                                        temp = temp - rr[p];
                                        if (temp <= 0) break;
                                    }
                                    n[i] = p;
                                }
                            }

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
                        int[] jj = new int[iUp1 + 1];
                        for (int mn = 1; mn <= TestHighManager.CountJudge(); mn++)
                        {
                            jj[mn] = WrongRadioManager.WrongRadionum(Session["stuId"].ToString(), mn, "High", "WrongJudge");
                            iUp1 = iUp1 + jj[mn];
                        }
                        int[] j = new int[4];
                        while (true)
                        {
                            int i;
                            j[0] = ran.Next(iDown, iUp1);
                            j[1] = ran.Next(iDown, iUp1);
                            j[2] = ran.Next(iDown, iUp1);
                            j[3] = ran.Next(iDown, iUp1);

                            //对随机选出的4个数重映射题号
                            for (i = 0; i <= 3; i++)
                            {
                                if (j[i] > TestHighManager.CountJudge())
                                {
                                    int temp;
                                    temp = j[i] - TestHighManager.CountJudge();
                                    int p;
                                    for (p = 1; p <= TestHighManager.CountJudge(); p++)
                                    {
                                        temp = temp - jj[p];
                                        if (temp <= 0) break;
                                    }
                                    j[i] = p;
                                }
                            }

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
                        int[] kk = new int[iUp2 + 1];
                        for (int mn = 1; mn <= TestHighManager.CountBlank(); mn++)
                        {
                            kk[mn] = WrongRadioManager.WrongRadionum(Session["stuId"].ToString(), mn, "High", "WrongBlank");
                            iUp2 = iUp2 + kk[mn];
                        }
                        int[] k = new int[3];
                        while (true)
                        {
                            int i;
                            k[0] = ran.Next(iDown, iUp2);
                            k[1] = ran.Next(iDown, iUp2);
                            k[2] = ran.Next(iDown, iUp2);

                            //对随机选出的3个数重映射题号
                            for (i = 0; i <= 2; i++)
                            {
                                if (k[i] > TestHighManager.CountBlank())
                                {
                                    int temp;
                                    temp = k[i] - TestHighManager.CountBlank();
                                    int p;
                                    for (p = 1; p <= TestHighManager.CountBlank(); p++)
                                    {
                                        temp = temp - kk[p];
                                        if (temp <= 0) break;
                                    }
                                    k[i] = p;
                                }
                            }
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
                        TestHighManager.ShowQuestionDesign(d1, lblD1, lblD1S1, lblD1S2, rdolistD1S1, rdolistD1S2);
                    }

                    else
                    {
                        lblTitle.Visible = false;
                        PanelAll.Visible = false;
                        PanelDesign.Visible = false;
                        btnSubmit.Visible = false;
                        btnOk.Visible = false;
                        btnSave.Visible = false;
                        //Response.Write("<script type = 'text/javascript'> alert('你未通过低等级测试，不能进行该等级测试！'); </script>");
                        RegisterClientScriptBlock("", "<script>alert('你未通过前测或低等级测试，不能进行高级测试！')</script>");
                    }
                }
            }
            else
            {
                Response.Redirect("Login.aspx");
            }   
        }
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {

        btnOk.Visible = true;
        PanelDesign.Visible = true;
        btnSubmit.Enabled = false;

        //实现设计题上传
        Boolean fileOK = false;
        // 指定路径
        String path = Server.MapPath("~/");
        // 文件上传控件中如果已经包含文件
        if (FUDesignHigh.HasFile)
        {
            // 得到文件的后缀
            String fileExtension =
                System.IO.Path.GetExtension(FUDesignHigh.FileName).ToLower();
            // 允许的文件后缀
            String[] allowedExtensions = { ".cs" };
            // 看包含的文件是否是被允许的文件后缀
            for (int i = 0; i < allowedExtensions.Length; i++)
            {
                if (fileExtension == allowedExtensions[i])
                {
                    // 如果是，标志位置为真
                    fileOK = true;
                }
            }
        }

        if (fileOK)
        {
            try
            {
                // 文件另存在服务器指定目录下

                FUDesignHigh.PostedFile.SaveAs(Server.MapPath("./DesignWorks/high/") + FUDesignHigh.FileName);
                lbText.Text = "文件上传成功！";
                path = "~/DesignWorks/high/" + FUDesignHigh.FileName;
            }
            catch (Exception ex)
            {
                lbText.Text = "文件上传失败！";
            }
        }
        else
        {
            lbText.Text = "注意：只能上传*.cs文件，并以“学号.cs”命名！";

        }

    }

    protected void btnOk_Click(object sender, EventArgs e)
    {
        btnSuggest.Visible = true;
        int[] r = new int[5]; //用于存放学习建议
        int[] j = new int[4];
        int[] b = new int[3];
        int[] rr = new int[6];  //用于存放错题的学习建议，有1~5中类型，数字长度选6
        //int []jj = new int[6];
        //int []bb = new int[6];
        btnOk.Enabled = false;
        btnSave.Enabled = false;
        correct = TestHighManager.JudgingRadio(rdolistS1, r1, lblS1A, btnS1E);
        if (correct == false)
        {
            r[0] = r1.suggestion;
            WrongRadioManager.addRadioToWrongTotal(Session["stuId"].ToString(), r1.Id, "High", "WrongRadio");
        }
        correct = TestHighManager.JudgingRadio(rdolistS2, r2, lblS2A, btnS2E);
        if (correct == false)
        {
            r[1] = r2.suggestion;
            WrongRadioManager.addRadioToWrongTotal(Session["stuId"].ToString(), r2.Id, "High", "WrongRadio");
        }
        correct = TestHighManager.JudgingRadio(rdolistS3, r3, lblS3A, btnS3E);
        if (correct == false)
        {
            r[2] = r3.suggestion;
            WrongRadioManager.addRadioToWrongTotal(Session["stuId"].ToString(), r3.Id, "High", "WrongRadio");
        }
        correct = TestHighManager.JudgingRadio(rdolistS4, r4, lblS4A, btnS4E);
        if (correct == false)
        {
            r[3] = r4.suggestion;
            WrongRadioManager.addRadioToWrongTotal(Session["stuId"].ToString(), r4.Id, "High", "WrongRadio");
        }
        correct = TestHighManager.JudgingRadio(rdolistS5, r5, lblS5A, btnS5E);
        if (correct == false)
        {
            r[4] = r5.suggestion;
            WrongRadioManager.addRadioToWrongTotal(Session["stuId"].ToString(), r5.Id, "High", "WrongRadio");
        }
        correct = TestHighManager.JudgingJudge(rdolistJ1, j1, lblJ1A, btnJ1E);
        if (correct == false)
        {
            j[0] = j1.suggestion;
            WrongRadioManager.addRadioToWrongTotal(Session["stuId"].ToString(), j1.Id, "High", "WrongJudge");
        }
        correct = TestHighManager.JudgingJudge(rdolistJ2, j2, lblJ2A, btnJ2E);
        if (correct == false)
        {
            j[1] = j2.suggestion;
            WrongRadioManager.addRadioToWrongTotal(Session["stuId"].ToString(), j2.Id, "High", "WrongJudge");
        }
        correct = TestHighManager.JudgingJudge(rdolistJ3, j3, lblJ3A, btnJ3E);
        if (correct == false)
        {
            j[2] = j3.suggestion;
            WrongRadioManager.addRadioToWrongTotal(Session["stuId"].ToString(), j3.Id, "High", "WrongJudge");
        }
        correct = TestHighManager.JudgingJudge(rdolistJ4, j4, lblJ4A, btnJ4E);
        if (correct == false)
        {
            j[3] = j4.suggestion;
            WrongRadioManager.addRadioToWrongTotal(Session["stuId"].ToString(), j4.Id, "High", "WrongJudge");
        }
        correct = TestHighManager.JudgingBlank(b1, txtB11, lblB11A, btnB11E);
        if (correct == false)
        {
            b[0] = b1.suggestion;
            WrongRadioManager.addRadioToWrongTotal(Session["stuId"].ToString(), b1.Id, "High", "WrongBlank");
        }
        correct = TestHighManager.JudgingBlank(b2, txtB21, lblB21A, btnB21E);
        if (correct == false)
        {
            b[1] = b2.suggestion;
            WrongRadioManager.addRadioToWrongTotal(Session["stuId"].ToString(), b2.Id, "High", "WrongBlank");
        }
        correct = TestHighManager.JudgingBlank(b3, txtB21, lblB31A, btnB31E);
        if (correct == false)
        {
            b[2] = b3.suggestion;
            WrongRadioManager.addRadioToWrongTotal(Session["stuId"].ToString(), b3.Id, "High", "WrongBlank");
        }
        correct = TestHighManager.JudgingDesignRadio(rdolistD1S1, rdolistD1S2, d1, lblD1S1A, lblD1S2A);
        if (correct == false) WrongRadioManager.addRadioToWrongTotal(Session["stuId"].ToString(), d1.Id, "High", "WrongDesign");

        //判断单选错题的学习建议是否重复,同时生成XML文件
        System.Xml.XmlTextWriter xmlWriter = new XmlTextWriter(Server.MapPath("./XML/" + Session["stuId"].ToString() + ".xml"), System.Text.Encoding.UTF8);
        xmlWriter.Formatting = Formatting.Indented;
        xmlWriter.WriteStartDocument();
        xmlWriter.WriteStartElement("学习建议");
        for (int i = 0; i <= 4; i++)
        {
            if (r[i] != 0)
            {
                rr[r[i]] = r[i];   //如果r[i]不为0，表明为错题，就把建议编号放到相应的rr数组中
            }
        }

        //判断判断错题的学习建议是否重复
        for (int i = 0; i <= 3; i++)
        {
            if (j[i] != 0)
            {
                rr[j[i]] = j[i];   //如果j[i]不为0，表明为错题，就把建议编号放到相应的rr数组中
            }
        }

        //判断填空错题的学习建议是否重复
        for (int i = 0; i <= 2; i++)
        {
            if (b[i] != 0)
            {
                rr[b[i]] = b[i];   //如果b[i]不为0，表明为错题，就把建议编号放到相应的rr数组中
            }
        }
        for (int i = 0; i <= 5; i++)
        {
            if (rr[i] != 0)
            {
                //Msg = Msg + rr[i].ToString() + ",";
                //写入XML文件
                xmlWriter.WriteStartElement("错题");
                xmlWriter.WriteAttributeString("类型", rr[i].ToString());
                xmlWriter.WriteEndElement();
            }
        }
        //写文档结束，调用WriteEndDocument方法
        xmlWriter.WriteEndDocument();
        //关闭textWriter
        xmlWriter.Close();

        string stuId = Session["stuId"].ToString();

        bool scoreJudge = TestHighManager.Score(TestHighManager.radioScore(r1, r2, r3, r4, r5, rdolistS1, rdolistS2, rdolistS3, rdolistS4, rdolistS5), TestHighManager.judgeScore(j1, j2, j3, j4, rdolistJ1, rdolistJ2, rdolistJ3, rdolistJ4),
            TestHighManager.blankScore(b1, b2, b3, txtB11, txtB21, txtB31), TestHighManager.designScore(d1, rdolistD1S1, rdolistD1S2));

        if (scoreJudge == true)
        {
            //实现设计题上传
            Boolean fileOK = false;
            // 指定路径
            String path = Server.MapPath("~/");
            // 文件上传控件中如果已经包含文件
            if (FUDesignHigh.HasFile)
            {
                // 得到文件的后缀
                String fileExtension =
                    System.IO.Path.GetExtension(FUDesignHigh.FileName).ToLower();
                // 允许的文件后缀
                String[] allowedExtensions = { ".cs" };
                // 看包含的文件是否是被允许的文件后缀
                for (int i = 0; i < allowedExtensions.Length; i++)
                {
                    if (fileExtension == allowedExtensions[i])
                    {
                        // 如果是，标志位置为真
                        fileOK = true;
                    }
                }
            }

            if (fileOK)
            {
                try
                {
                    // 文件另存在服务器指定目录下

                    FUDesignHigh.PostedFile.SaveAs(Server.MapPath("./DesignWorks/high/") + FUDesignHigh.FileName);
                    lbText.Text = "文件上传成功！";
                    path = "~/DesignWorks/high/" + FUDesignHigh.FileName;
                }
                catch (Exception ex)
                {
                    lbText.Text = "文件上传失败！";
                }
            }
            else
            {
                lbText.Text = "注意：只能上传*.cs文件，并以“学号.cs”命名！";

            }
            //将上传地址写入数据库

            DateTime createTime = DateTime.Now;
            string fileName = FUDesignHigh.FileName;
            int n = TestHighManager.AddDesignUpload(stuId, learningLevel, createTime, path, fileName);
        }
        //将分数写入ClassUnit表中 

        TestHighManager.UpdateStudyingScore(stuId, learningLevel, TestHighManager.radioScore(r1, r2, r3, r4, r5, rdolistS1, rdolistS2, rdolistS3, rdolistS4, rdolistS5)
            + TestHighManager.judgeScore(j1, j2, j3, j4, rdolistJ1, rdolistJ2, rdolistJ3, rdolistJ4) + TestHighManager.blankScore(b1, b2, b3, txtB11, txtB21, txtB31)
            + TestHighManager.designScore(d1, rdolistD1S1, rdolistD1S2));


        string str = null;
        str = TestHighManager.ShowScoreString(TestHighManager.radioScore(r1, r2, r3, r4, r5, rdolistS1, rdolistS2, rdolistS3, rdolistS4, rdolistS5), TestHighManager.judgeScore(j1, j2, j3, j4, rdolistJ1, rdolistJ2, rdolistJ3, rdolistJ4), TestHighManager.blankScore(b1, b2, b3, txtB11, txtB21, txtB31), TestHighManager.designScore(d1, rdolistD1S1, rdolistD1S2), scoreJudge);
        //Response.Write(string.Format("<script type = 'text/javascript'> alert('{0}'); </script>", str));
        RegisterClientScriptBlock("", string.Format("<script type = 'text/javascript'> alert('{0}'); </script>", str));


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


    protected void btnSave_Click(object sender, EventArgs e)
    {
        string stuId = Session["stuId"].ToString();
        DateTime createTime = DateTime.Now;
        int rr1 = r1.Id;
        string ra1 = rdolistS1.SelectedValue;

        int rr2 = r2.Id;
        string ra2 = rdolistS2.SelectedValue;

        int rr3 = r3.Id;
        string ra3 = rdolistS3.SelectedValue;

        int rr4 = r4.Id;
        string ra4 = rdolistS4.SelectedValue;

        int rr5 = r5.Id;
        string ra5 = rdolistS5.SelectedValue;

        int jj1 = j1.Id;
        string ja1 = rdolistJ1.SelectedValue;

        int jj2 = j2.Id;
        string ja2 = rdolistJ2.SelectedValue;

        int jj3 = j3.Id;
        string ja3 = rdolistJ3.SelectedValue;

        int jj4 = j4.Id;
        string ja4 = rdolistJ4.SelectedValue;

        int bb1 = b1.Id;
        string ba1 = txtB11.Text;

        int bb2 = b2.Id;
        string ba2 = txtB21.Text;

        int bb3 = b3.Id;
        string ba3 = txtB31.Text;

        int dd1 = d1.Id;

        BreakingPointRadio breakingPointRadio = new BreakingPointRadio(stuId, learningLevel, createTime, rr1, ra1, rr2, ra2, rr3, ra3, rr4, ra4, rr5, ra5);
        BreakingPointJudge breakingPointJudge = new BreakingPointJudge(stuId, learningLevel, createTime, jj1, ja1, jj2, ja2, jj3, ja3, jj4, ja4);
        BreakingPointBlank breakingPointBlank = new BreakingPointBlank(stuId, learningLevel, createTime, bb1, ba1, bb2, ba2, bb3, ba3);
        BreakingPointDesign breakingPointDesign = new BreakingPointDesign(stuId, learningLevel, createTime, dd1);

        int a = BreakingPointManager.AddBreakingPointRadio(breakingPointRadio);
        int b = BreakingPointManager.AddBreakingPointJudge(breakingPointJudge);
        int c = BreakingPointManager.AddBreakingPointBlank(breakingPointBlank);
        int d = BreakingPointManager.AddBreakingPointDesign(breakingPointDesign);
        //Response.Write("<script type = 'text/javascript'> alert('断点保存成功！'); </script>");
        RegisterClientScriptBlock("", "<script>alert('断点保存成功！')</script>");
        //MsgBox("断点保存成功！", "StudentDefault.aspx");
    }

    //弹出信息框定义
    #region MsgBox
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
    #endregion

    
    protected void btnSuggest_Click(object sender, EventArgs e)
    {
        Session["stutext"] = "高级";
        string Num = "";
        int suggestion = 0;
        //C#读取XML文件  http://www.cnblogs.com/xiaoxiangfeizi/archive/2011/08/07/2120807.html
        XmlDocument doc = new XmlDocument();   //使用的时候,首先声明一个XmlDocument对象,然后调用Load方法,从指定的路径加载XML文件
        doc.Load(Server.MapPath("./XML/" + Session["stuId"].ToString() + ".xml"));
        //然后可以通过调用SelectSingleNode得到指定的结点,通过GetAttribute得到具体的属性值.参看下面的代码

        // 得到根节点"学习建议"
        XmlNode xn = doc.SelectSingleNode("学习建议");
        // 得到根节点的所有子节点
        XmlNodeList xnl = xn.ChildNodes;
        foreach (XmlNode xn1 in xnl)
         {
             // 将节点转换为元素，便于得到节点的属性值
             XmlElement xe = (XmlElement)xn1;
             // 得到Type和ISBN两个属性的属性值
             Num = Num + xe.GetAttribute("类型").ToString() + ",";
         }
        if (Num == "") Num = "0";
        suggestion = Convert.ToInt32(Num.Substring(0, 1));


        //学习建议跳转
        string stuId = Session["stuId"].ToString();
        StudentInfo stuNews2 = new StudentInfo();
        stuNews2 = StudentInfoManager.Getstudentnews(stuId);
        if (suggestion == 1)
        {
            if (stuNews2.learningStyle == "活跃型+视觉型" || stuNews2.learningStyle == "活跃型+言语型")
            {
                //Msg = "StudyData/StudyDataVideo1.aspx";
                RegisterClientScriptBlock("", string.Format("<script type = 'text/javascript'>  alert('Attention！你需要复习的知识点有{0}');location.href= 'StudyData/StudyDataVideo1.aspx'</script>", Num));
            }
            else if (stuNews2.learningStyle == "沉思型+视觉型")
            {
                //Msg = "StudyData/StudyDataPicture1.aspx";
                RegisterClientScriptBlock("", string.Format("<script type = 'text/javascript'>  alert('Attention！你需要复习的知识点有{0}');location.href= 'StudyData/StudyDataPicture1.aspx'</script>", Num));
            }
            else if (stuNews2.learningStyle == "沉思型+言语型")
            {
                //Msg = "StudyData/StudyDataText1.aspx";
                RegisterClientScriptBlock("", string.Format("<script type = 'text/javascript'>  alert('Attention！你需要复习的知识点有{0}');location.href= 'StudyData/StudyDataText1.aspx'</script>", Num));
            }
        }
        else if (suggestion == 2)
        {
            if (stuNews2.learningStyle == "活跃型+视觉型" || stuNews2.learningStyle == "活跃型+言语型")
            {
                //Msg = "StudyData/StudyDataVideo2.aspx";
                RegisterClientScriptBlock("", string.Format("<script type = 'text/javascript'>  alert('Attention！你需要复习的知识点有{0}');location.href= 'StudyData/StudyDataVideo2.aspx'</script>", Num));
            }
            else if (stuNews2.learningStyle == "沉思型+视觉型")
            {
                //Msg = "StudyData/StudyDataPicture2.aspx";
                RegisterClientScriptBlock("", string.Format("<script type = 'text/javascript'>  alert('Attention！你需要复习的知识点有{0}');location.href= 'StudyData/StudyDataPicture2.aspx'</script>", Num));

            }
            else if (stuNews2.learningStyle == "沉思型+言语型")
            {
                //Msg = "StudyData/StudyDataText2.aspx";
                RegisterClientScriptBlock("", string.Format("<script type = 'text/javascript'>  alert('Attention！你需要复习的知识点有{0}');location.href= 'StudyData/StudyDataText2.aspx'</script>", Num));
            }
        }
        else if (suggestion == 3)
        {
            if (stuNews2.learningStyle == "活跃型+视觉型" || stuNews2.learningStyle == "活跃型+言语型")
            {
                //Msg = "StudyData/StudyDataVideo3.aspx";
                RegisterClientScriptBlock("", string.Format("<script type = 'text/javascript'>  alert('Attention！你需要复习的知识点有{0}');location.href= 'StudyData/StudyDataVideo3.aspx'</script>", Num));
            }
            else if (stuNews2.learningStyle == "沉思型+视觉型")
            {
                //Msg = "StudyData/StudyDataPicture3.aspx";
                RegisterClientScriptBlock("", string.Format("<script type = 'text/javascript'>  alert('Attention！你需要复习的知识点有{0}');location.href= 'StudyData/StudyDataPicture3.aspx'</script>", Num));
            }
            else if (stuNews2.learningStyle == "沉思型+言语型")
            {
                //Msg = "StudyData/StudyDataText3.aspx";
                RegisterClientScriptBlock("", string.Format("<script type = 'text/javascript'>  alert('Attention！你需要复习的知识点有{0}');location.href= 'StudyData/StudyDataText3.aspx'</script>", Num));
            }
        }
        else if (suggestion == 4)
        {
            if (stuNews2.learningStyle == "活跃型+视觉型" || stuNews2.learningStyle == "活跃型+言语型")
            {
                //Msg = "StudyData/StudyDataVideo4.aspx";
                RegisterClientScriptBlock("", string.Format("<script type = 'text/javascript'>  alert('Attention！你需要复习的知识点有{0}');location.href= 'StudyData/StudyDataVideo4.aspx'</script>", Num));
            }
            else if (stuNews2.learningStyle == "沉思型+视觉型")
            {
                //Msg = "StudyData/StudyDataPicture4.aspx";
                RegisterClientScriptBlock("", string.Format("<script type = 'text/javascript'>  alert('Attention！你需要复习的知识点有{0}');location.href= 'StudyData/StudyDataPicture4.aspx'</script>", Num));
            }
            else if (stuNews2.learningStyle == "沉思型+言语型")
            {
                //Msg = "StudyData/StudyDataText4.aspx";
                RegisterClientScriptBlock("", string.Format("<script type = 'text/javascript'>  alert('Attention！你需要复习的知识点有{0}');location.href= 'StudyData/StudyDataText4.aspx'</script>", Num));
            }
        }
        else if (suggestion == 5)
        {
            if (stuNews2.learningStyle == "活跃型+视觉型" || stuNews2.learningStyle == "活跃型+言语型")
            {
                //Msg = "StudyData/StudyDataVideo5.aspx";
                RegisterClientScriptBlock("", string.Format("<script type = 'text/javascript'>  alert('Attention！你需要复习的知识点有{0}');location.href= 'StudyData/StudyDataVideo5.aspx'</script>", Num));
            }
            else if (stuNews2.learningStyle == "沉思型+视觉型")
            {
                //Msg = "StudyData/StudyDataPicture5.aspx";
                RegisterClientScriptBlock("", string.Format("<script type = 'text/javascript'>  alert('Attention！你需要复习的知识点有{0}');location.href= 'StudyData/StudyDataPicture5.aspx'</script>", Num));
            }
            else if (stuNews2.learningStyle == "沉思型+言语型")
            {
                //Msg = "StudyData/StudyDataText5.aspx";
                RegisterClientScriptBlock("", string.Format("<script type = 'text/javascript'>  alert('Attention！你需要复习的知识点有{0}');location.href= 'StudyData/StudyDataText5.aspx'</script>", Num));
            }
        }
        else
        {
            //Msg = "StudyData/StudyDataDefault.aspx";
            RegisterClientScriptBlock("", string.Format("<script type = 'text/javascript'>  alert('Congratulations！同学，你可以选择进入到学习资料库进行温故！');location.href= 'StudyData/StudyDataDefault.aspx'</script>"));
        }
        
        //RegisterClientScriptBlock("", string.Format("<script type = 'text/javascript'>  alert('Attention！同学，你需要复习的知识点有{0}');location.href= 'StudyData/StudyDataText1.aspx'</script>", Num));
        //ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "", "<script>alert('修改成功！');location.href='a.aspx？type=1}'</script>", false); 
    }

}

