using System;
using System.Data;
using System.Configuration;
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

public partial class TestLow : System.Web.UI.Page
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
    bool correct = true;
    string learningLevel = "low";
    static ClassUnit stuNews1 = new ClassUnit();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)    
        {
            if (Session["stuId"] != null)
            {
                int score1 = 0;
                int score2 = 0;
                string stuId = Session["stuId"].ToString();
                stuNews1 = ClassUnitManager.GetStudyingInform(stuId);
                score1 = stuNews1.pretest;    //获取前测分数
                score2 = stuNews1.low;    //获取初级测试分数
                //不是第一次做题，读取断点
                if (int.Parse(Request.QueryString["caid"].ToString().Trim()) == 1)
                {
                    BreakingPointRadio bpr = new BreakingPointRadio();
                    bpr = BreakingPointManager.LoadBreakingPointRadio(Session["stuId"].ToString());
                    rLow1 = TestLowManager.GetLowRadio(bpr.r1);    //读取用户单选题断点记录
                    TestLowManager.ShowQuestionRadioLow(rLow1, rdolistS1, lblS1);    //显示单选题题目
                    rLow2 = TestLowManager.GetLowRadio(bpr.r2);
                    TestLowManager.ShowQuestionRadioLow(rLow2, rdolistS2, lblS2);
                    rLow3 = TestLowManager.GetLowRadio(bpr.r3);
                    TestLowManager.ShowQuestionRadioLow(rLow3, rdolistS3, lblS3);
                    rLow4 = TestLowManager.GetLowRadio(bpr.r4);
                    TestLowManager.ShowQuestionRadioLow(rLow4, rdolistS4, lblS4);
                    rLow5 = TestLowManager.GetLowRadio(bpr.r5);
                    TestLowManager.ShowQuestionRadioLow(rLow5, rdolistS5, lblS5);
                    BreakingPointJudge bpj = new BreakingPointJudge();
                    bpj = BreakingPointManager.LoadBreakingPointJudge(Session["stuId"].ToString());
                    jLow1 = TestLowManager.GetLowJudge(bpj.j1);    //读取用户判断题断点记录
                    TestLowManager.ShowQuestionJudgeLow(jLow1, rdolistJ1, lblJ1);    //显示判断题题目
                    jLow2 = TestLowManager.GetLowJudge(bpj.j2);
                    TestLowManager.ShowQuestionJudgeLow(jLow2, rdolistJ2, lblJ2);
                    jLow3 = TestLowManager.GetLowJudge(bpj.j3);
                    TestLowManager.ShowQuestionJudgeLow(jLow3, rdolistJ3, lblJ3);
                    jLow4 = TestLowManager.GetLowJudge(bpj.j4);
                    TestLowManager.ShowQuestionJudgeLow(jLow4, rdolistJ4, lblJ4);
                    BreakingPointBlank bpb = new BreakingPointBlank();
                    bpb = BreakingPointManager.LoadBreakingPointBlank(Session["stuId"].ToString());
                    bLow1 = TestLowManager.GetLowBlank(bpb.b1);    //读取用户填空题断点记录
                    TestLowManager.ShowQuestionBlankLow(bLow1, lblB1, lblB12);    //显示填空题题目
                    bLow2 = TestLowManager.GetLowBlank(bpb.b2);
                    TestLowManager.ShowQuestionBlankLow(bLow2, lblB2, lblB22);
                    bLow3 = TestLowManager.GetLowBlank(bpb.b3);
                    TestLowManager.ShowQuestionBlankLow(bLow3, lblB3, lblB32);
                    BreakingPointDesign bpd = new BreakingPointDesign();
                    bpd = BreakingPointManager.LoadBreakingPointDesign(Session["stuId"].ToString());
                    dLow1 = TestLowManager.GetLowDesign(bpd.d1);    //读取用户设计题断点记录
                    TestLowManager.ShowQuestionDesignLow(dLow1, lblD1, lblD1S1, lblD1S2, rdolistD1S1, rdolistD1S2);    //显示填空题题目
                    TestLowManager.ShowRadioLowBreakingpoint(bpr, rdolistS1, rdolistS2, rdolistS3, rdolistS4, rdolistS5);    //显示单选题的断点自选选项
                    TestLowManager.ShowJudgeLowBreakingpoint(bpj, rdolistJ1, rdolistJ2, rdolistJ3, rdolistJ4);    //显示判断题的断点自选选项
                    TestLowManager.ShowBlankLowBreakingpoint(bpb, txtB11, txtB21, txtB31);    //显示填空题的断点自选选项
                }
                //第一次做题
                else if (int.Parse(Request.QueryString["caid"].ToString().Trim()) == 0)
                {
                    //判断前测分数是否到60分
                    if (score1 >= 60)
                    {
                        //随机出题（加入错题的权重,原先的题号不变，多余的错题作为普通题目放到最后进行随机）
                        long tick = DateTime.Now.Ticks;
                        Random ran = new Random((int)(tick & 0xffffffffL) | (int)(tick >> 32));
                        int iDown = 1;
                        int iUp = TestLowManager.CountRadioLow();
                        int[] rr = new int[iUp + 1];
                        for (int mn = 1; mn <= TestLowManager.CountRadioLow(); mn++)
                        {
                            rr[mn] = WrongRadioManager.WrongRadionum(Session["stuId"].ToString(), mn, "Low", "WrongRadio");
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
                                if (n[i] > TestLowManager.CountRadioLow())
                                {
                                    int temp;
                                    temp = n[i] - TestLowManager.CountRadioLow();
                                    int p;
                                    for (p = 1; p <= TestLowManager.CountRadioLow(); p++)
                                    {
                                        temp = temp - rr[p];
                                        if (temp <= 0) break;
                                    }
                                    n[i] = p;
                                }
                            }
                            //题目不重复
                            if (n[0] != n[1] && n[0] != n[2] && n[0] != n[3] && n[0] != n[4] && n[1] != n[2] && n[1] != n[3] && n[1] != n[4] && n[2] != n[3] && n[2] != n[4] && n[3] != n[4])
                            {
                                i = 4;
                            }
                            if (i == 4) break;
                        }
                        rLow1 = TestLowManager.GetLowRadio(n[0]);    //获取判断题题目
                        TestLowManager.ShowQuestionRadioLow(rLow1, rdolistS1, lblS1);    //显示判断题题目
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
                        int[] jj = new int[iUp1 + 1];
                        for (int mn = 1; mn <= TestLowManager.CountJudgeLow(); mn++)
                        {
                            jj[mn] = WrongRadioManager.WrongRadionum(Session["stuId"].ToString(), mn, "Low", "WrongJudge");
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
                                if (j[i] > TestLowManager.CountJudgeLow())
                                {
                                    int temp;
                                    temp = j[i] - TestLowManager.CountJudgeLow();
                                    int p;
                                    for (p = 1; p <= TestLowManager.CountJudgeLow(); p++)
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
                        int[] kk = new int[iUp2 + 1];
                        for (int mn = 1; mn <= TestLowManager.CountBlankLow(); mn++)
                        {
                            kk[mn] = WrongRadioManager.WrongRadionum(Session["stuId"].ToString(), mn, "Low", "WrongBlank");
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
                                if (k[i] > TestLowManager.CountBlankLow())
                                {
                                    int temp;
                                    temp = k[i] - TestLowManager.CountBlankLow();
                                    int p;
                                    for (p = 1; p <= TestLowManager.CountBlankLow(); p++)
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
                        TestLowManager.ShowQuestionDesignLow(dLow1, lblD1, lblD1S1, lblD1S2, rdolistD1S1, rdolistD1S2);
                    }
                    else
                    {
                        lblTitle.Visible = false;
                        PanelAll.Visible = false;
                        PanelDesign.Visible = false;
                        btnSubmit.Visible = false;
                        btnOk.Visible = false;
                        btnSave.Visible = false;
                        //Response.Write("<script type = 'text/javascript'> alert('你未通过前测，不能进行该等级测试！'); </script>");
                        RegisterClientScriptBlock("", "<script>alert('你未通过前测，不能进行初级测试！')</script>");
                    }
                }
            }
            else
            {
                Response.Redirect("Login.aspx");
            } 
        }
    }
    //点击提交按钮事件
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
        if (FUDesignLow.HasFile)
        {
            // 得到文件的后缀
            String fileExtension =
                System.IO.Path.GetExtension(FUDesignLow.FileName).ToLower();
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

                FUDesignLow.PostedFile.SaveAs(Server.MapPath("./DesignWorks/low/") + FUDesignLow.FileName);
                lbText.Text = "文件上传成功！";
                path = "~/DesignWorks/low/" + FUDesignLow.FileName;
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
    //点击确定按钮事件
    protected void btnOk_Click(object sender, EventArgs e)
    {
        btnSuggest.Visible = true;
        int[] r = new int[5]; //用于存放学习建议
        int[] j = new int[4];
        int[] b = new int[3];
        int[] rr = new int[6];  //用于存放错题的学习建议，有1~5种类型，数字长度选6
        btnOk.Enabled = false;
        btnSave.Enabled = false;
        correct = TestLowManager.JudgingRadio(rdolistS1, rLow1, lblS1A, btnS1E);    //单选题判定，判断对错，显示正确答案
        //记录错题
        if (correct == false)
        {
            r[0] = rLow1.suggestion;
            WrongRadioManager.addRadioToWrongTotal(Session["stuId"].ToString(), rLow1.Id, "Low", "WrongRadio");    
        }
        correct = TestLowManager.JudgingRadio(rdolistS2, rLow2, lblS2A, btnS2E);
        if (correct == false)
        {
            r[1] = rLow2.suggestion;
            WrongRadioManager.addRadioToWrongTotal(Session["stuId"].ToString(), rLow2.Id, "Low", "WrongRadio");
        }
        correct = TestLowManager.JudgingRadio(rdolistS3, rLow3, lblS3A, btnS3E);
        if (correct == false)
        {
            r[2] = rLow3.suggestion;
            WrongRadioManager.addRadioToWrongTotal(Session["stuId"].ToString(), rLow3.Id, "Low", "WrongRadio");
        }
        correct = TestLowManager.JudgingRadio(rdolistS4, rLow4, lblS4A, btnS4E);
        if (correct == false)
        {
            r[3] = rLow4.suggestion;
            WrongRadioManager.addRadioToWrongTotal(Session["stuId"].ToString(), rLow4.Id, "Low", "WrongRadio");
        }
        correct = TestLowManager.JudgingRadio(rdolistS5, rLow5, lblS5A, btnS5E);
        if (correct == false)
        {
            r[4] = rLow5.suggestion;
            WrongRadioManager.addRadioToWrongTotal(Session["stuId"].ToString(), rLow5.Id, "Low", "WrongRadio");
        }
        correct = TestLowManager.JudgingJudge(rdolistJ1, jLow1, lblJ1A, btnJ1E);     //判断题判定，判断对错，显示正确答案
        //记录错题
        if (correct == false)
        {
            j[0] = jLow1.suggestion;
            WrongRadioManager.addRadioToWrongTotal(Session["stuId"].ToString(), jLow1.Id, "Low", "WrongJudge");
        }
        correct = TestLowManager.JudgingJudge(rdolistJ2, jLow2, lblJ2A, btnJ2E);
        if (correct == false)
        {
            j[1] = jLow2.suggestion;
            WrongRadioManager.addRadioToWrongTotal(Session["stuId"].ToString(), jLow2.Id, "Low", "WrongJudge");
        }
        correct = TestLowManager.JudgingJudge(rdolistJ3, jLow3, lblJ3A, btnJ3E);
        if (correct == false)
        {
            j[2] = jLow3.suggestion;
            WrongRadioManager.addRadioToWrongTotal(Session["stuId"].ToString(), jLow3.Id, "Low", "WrongJudge");
        }
        correct = TestLowManager.JudgingJudge(rdolistJ4, jLow4, lblJ4A, btnJ4E);
        if (correct == false)
        {
            j[3] = jLow4.suggestion;
            WrongRadioManager.addRadioToWrongTotal(Session["stuId"].ToString(), jLow4.Id, "Low", "WrongJudge");
        }
        correct = TestLowManager.JudgingBlank(bLow1, txtB11, lblB11A, btnB11E);    //填空题判定，判断对错，显示正确答案
        //记录错题
        if (correct == false)
        {
            b[0] = bLow1.suggestion;
            WrongRadioManager.addRadioToWrongTotal(Session["stuId"].ToString(), bLow1.Id, "Low", "WrongBlank");
        }
        correct = TestLowManager.JudgingBlank(bLow2, txtB21, lblB21A, btnB21E);
        if (correct == false)
        {
            b[1] = bLow2.suggestion;
            WrongRadioManager.addRadioToWrongTotal(Session["stuId"].ToString(), bLow2.Id, "Low", "WrongBlank");
        }
        correct = TestLowManager.JudgingBlank(bLow3, txtB21, lblB31A, btnB31E);
        if (correct == false)
        {
            b[2] = bLow3.suggestion;
            WrongRadioManager.addRadioToWrongTotal(Session["stuId"].ToString(), bLow3.Id, "Low", "WrongBlank");
        }
        correct = TestLowManager.JudgingDesignRadio(rdolistD1S1, rdolistD1S2, dLow1, lblD1S1A, lblD1S2A);    //设计题判定，判断对错，显示正确答案
        //记录错题
        if (correct == false) WrongRadioManager.addRadioToWrongTotal(Session["stuId"].ToString(), dLow1.Id, "Low", "WrongDesign");
        string stuId = Session["stuId"].ToString();
        //判断分数是否合格
        bool scoreJudge = TestLowManager.Score(TestLowManager.radioScore(rLow1, rLow2, rLow3, rLow4, rLow5, rdolistS1, rdolistS2, rdolistS3, rdolistS4, rdolistS5), TestLowManager.judgeScore(jLow1, jLow2, jLow3, jLow4, rdolistJ1, rdolistJ2, rdolistJ3, rdolistJ4), 
            TestLowManager.blankScore(bLow1, bLow2, bLow3, txtB11,txtB21,txtB31), TestLowManager.designScore(dLow1, rdolistD1S1, rdolistD1S2));
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
                rr[j[i]] = j[i];   //如果j[i]不为0，表明为错题，就把建议编号放到相应的jj数组中
            }
        }
        //判断填空错题的学习建议是否重复
        for (int i = 0; i <= 2; i++)
        {
            if (b[i] != 0)
            {
                rr[b[i]] = b[i];   //如果b[i]不为0，表明为错题，就把建议编号放到相应的bb数组中
            }
        }
        for (int i = 0; i <= 5; i++)
        {
            if (rr[i] != 0)
            {
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
        //判断分数是否合格，若合格则上传文件
        if (scoreJudge == true)
        {
            //实现设计题上传
            Boolean fileOK = false;
            // 指定路径
            String path = Server.MapPath("~/");
            // 文件上传控件中如果已经包含文件
            if (FUDesignLow.HasFile)
            {
                // 得到文件的后缀
                String fileExtension =
                    System.IO.Path.GetExtension(FUDesignLow.FileName).ToLower();
                // 允许的文件后缀
                String[] allowedExtensions = { ".cs" };
                // 看包含的文件是否是被允许的文件后缀
                for (int i = 0; i < allowedExtensions.Length; i++)
                {
                    if (fileExtension == allowedExtensions[i])
                    {
                        //如果是，标志位置为真
                        fileOK = true;
                    }
                }
            }
            if (fileOK)
            {
                try
                {
                    //文件另存在服务器指定目录下
                    FUDesignLow.PostedFile.SaveAs(Server.MapPath("./DesignWorks/low/") + FUDesignLow.FileName);
                    lbText.Text = "文件上传成功！";
                    path = "~/DesignWorks/low/" + FUDesignLow.FileName;
                }
                catch (Exception ex)
                {
                    lbText.Text = "文件上传失败！";
                }
            }
            else
            {
                lbText.Text = "注意：只能上传*.cs文件！";
            }
            //将上传地址写入数据库
            DateTime createTime = DateTime.Now;
            string fileName = FUDesignLow.FileName;
            int n = TestLowManager.AddDesignUpload(stuId, learningLevel, createTime, path, fileName);
        }
        //将分数写入成绩表中 
        TestLowManager.UpdateStudyingScore(stuId, learningLevel, TestLowManager.radioScore( rLow1, rLow2, rLow3, rLow4, rLow5, rdolistS1, rdolistS2, rdolistS3, rdolistS4, rdolistS5)
            + TestLowManager.judgeScore(jLow1, jLow2, jLow3, jLow4, rdolistJ1, rdolistJ2, rdolistJ3, rdolistJ4) + TestLowManager.blankScore(bLow1, bLow2, bLow3, txtB11, txtB21, txtB31) 
            + TestLowManager.designScore(dLow1, rdolistD1S1, rdolistD1S2));
        string str = null;
        //判断测试等级
        str = TestLowManager.ShowScoreString(TestLowManager.radioScore(rLow1, rLow2, rLow3, rLow4, rLow5, rdolistS1, rdolistS2, rdolistS3, rdolistS4, rdolistS5), TestLowManager.judgeScore(jLow1, jLow2, jLow3, jLow4, rdolistJ1, rdolistJ2, rdolistJ3, rdolistJ4), TestLowManager.blankScore(bLow1, bLow2, bLow3, txtB11,txtB21, txtB31), 
            TestLowManager.designScore(dLow1, rdolistD1S1, rdolistD1S2), scoreJudge);
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
    //点击保存按钮事件
    protected void btnSave_Click(object sender, EventArgs e)
    {
        string stuId = Session["stuId"].ToString();
        DateTime createTime = DateTime.Now;
        int r1 = rLow1.Id;
        string ra1 = rdolistS1.SelectedValue;
        int r2 = rLow2.Id;
        string ra2 = rdolistS2.SelectedValue;
        int r3 = rLow3.Id;
        string ra3 = rdolistS3.SelectedValue;
        int r4 = rLow4.Id;
        string ra4 = rdolistS4.SelectedValue;
        int r5 = rLow5.Id;
        string ra5 = rdolistS5.SelectedValue;
        int j1 = jLow1.Id;
        string ja1 = rdolistJ1.SelectedValue;
        int j2 = jLow2.Id;
        string ja2 = rdolistJ2.SelectedValue;
        int j3 = jLow3.Id;
        string ja3 = rdolistJ3.SelectedValue;
        int j4 = jLow4.Id;
        string ja4 = rdolistJ4.SelectedValue;
        int b1 = bLow1.Id;
        string ba1 = txtB11.Text;
        int b2 = bLow2.Id;
        string ba2 = txtB21.Text;
        int b3 = bLow3.Id;
        string ba3 = txtB31.Text;
        int d1 = dLow1.Id;
        BreakingPointRadio breakingPointRadio = new BreakingPointRadio(stuId, learningLevel, createTime, r1, ra1, r2, ra2, r3, ra3, r4, ra4, r5, ra5);
        BreakingPointJudge breakingPointJudge = new BreakingPointJudge(stuId, learningLevel, createTime, j1, ja1, j2, ja2, j3, ja3, j4, ja4);
        BreakingPointBlank breakingPointBlank = new BreakingPointBlank(stuId, learningLevel, createTime, b1, ba1, b2, ba2, b3, ba3);
        BreakingPointDesign breakingPointDesign = new BreakingPointDesign(stuId, learningLevel, createTime, d1);
        //对学习断点进行记录
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
    //点击学习建议按钮事件
    protected void btnSuggest_Click(object sender, EventArgs e)
    {
        Session["stutext"] = "初级";
        string Num = "";
        //C#读取XML文件
        XmlDocument doc = new XmlDocument();    //使用的时候,首先声明一个XmlDocument对象，然后调用Load方法，从指定的路径加载XML文件
        doc.Load(Server.MapPath("./XML/" + Session["stuId"].ToString() + ".xml"));
        //然后可以通过调用SelectSingleNode得到指定的结点，通过GetAttribute得到具体的属性值，参看下面的代码
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
        int suggestion = Convert.ToInt32(Num.Substring(0, 1));
        string stuId = Session["stuId"].ToString();
        StudentInfo stuNews2 = new StudentInfo();
        stuNews2 = StudentInfoManager.Getstudentnews(stuId);
        //判断学生错题知识点的第一个
        if (suggestion == 1)
        {
            if (stuNews2.learningStyle == "活跃型+视觉型" || stuNews2.learningStyle == "活跃型+言语型")
            {
                RegisterClientScriptBlock("", string.Format("<script type = 'text/javascript'>  alert('Attention！你需要复习的知识点有{0}');location.href= 'StudyData/StudyDataVideo1.aspx'</script>", Num));    //跳转到学习资料库知识点1视频呈现界面
            }
            else if (stuNews2.learningStyle == "沉思型+视觉型")
            {
                RegisterClientScriptBlock("", string.Format("<script type = 'text/javascript'>  alert('Attention！你需要复习的知识点有{0}');location.href= 'StudyData/StudyDataPicture1.aspx'</script>", Num));    //跳转到学习资料库知识点1图片呈现界面
            }
            else if (stuNews2.learningStyle == "沉思型+言语型")
            {
                RegisterClientScriptBlock("", string.Format("<script type = 'text/javascript'>  alert('Attention！你需要复习的知识点有{0}');location.href= 'StudyData/StudyDataText1.aspx'</script>", Num));    //跳转到学习资料库知识点1文字呈现界面
            }
        }
        else if (suggestion == 2)
        {
            if (stuNews2.learningStyle == "活跃型+视觉型" || stuNews2.learningStyle == "活跃型+言语型")
            {
                RegisterClientScriptBlock("", string.Format("<script type = 'text/javascript'>  alert('Attention！你需要复习的知识点有{0}');location.href= 'StudyData/StudyDataVideo2.aspx'</script>", Num));
            }
            else if (stuNews2.learningStyle == "沉思型+视觉型")
            {
                RegisterClientScriptBlock("", string.Format("<script type = 'text/javascript'>  alert('Attention！你需要复习的知识点有{0}');location.href= 'StudyData/StudyDataPicture2.aspx'</script>", Num));

            }
            else if (stuNews2.learningStyle == "沉思型+言语型")
            {
                RegisterClientScriptBlock("", string.Format("<script type = 'text/javascript'>  alert('Attention！你需要复习的知识点有{0}');location.href= 'StudyData/StudyDataText2.aspx'</script>", Num));
            }
        }
        else if (suggestion == 3)
        {
            if (stuNews2.learningStyle == "活跃型+视觉型" || stuNews2.learningStyle == "活跃型+言语型")
            {
                RegisterClientScriptBlock("", string.Format("<script type = 'text/javascript'>  alert('Attention！你需要复习的知识点有{0}');location.href= 'StudyData/StudyDataVideo3.aspx'</script>", Num));
            }
            else if (stuNews2.learningStyle == "沉思型+视觉型")
            {
                RegisterClientScriptBlock("", string.Format("<script type = 'text/javascript'>  alert('Attention！你需要复习的知识点有{0}');location.href= 'StudyData/StudyDataPicture3.aspx'</script>", Num));
            }
            else if (stuNews2.learningStyle == "沉思型+言语型")
            {
                RegisterClientScriptBlock("", string.Format("<script type = 'text/javascript'>  alert('Attention！你需要复习的知识点有{0}');location.href= 'StudyData/StudyDataText3.aspx'</script>", Num));
            }
        }
        else if (suggestion == 4)
        {
            if (stuNews2.learningStyle == "活跃型+视觉型" || stuNews2.learningStyle == "活跃型+言语型")
            {
                RegisterClientScriptBlock("", string.Format("<script type = 'text/javascript'>  alert('Attention！你需要复习的知识点有{0}');location.href= 'StudyData/StudyDataVideo4.aspx'</script>", Num));
            }
            else if (stuNews2.learningStyle == "沉思型+视觉型")
            {
                RegisterClientScriptBlock("", string.Format("<script type = 'text/javascript'>  alert('Attention！你需要复习的知识点有{0}');location.href= 'StudyData/StudyDataPicture4.aspx'</script>", Num));
            }
            else if (stuNews2.learningStyle == "沉思型+言语型")
            {
                RegisterClientScriptBlock("", string.Format("<script type = 'text/javascript'>  alert('Attention！你需要复习的知识点有{0}');location.href= 'StudyData/StudyDataText4.aspx'</script>", Num));
            }
        }
        else if (suggestion == 5)
        {
            if (stuNews2.learningStyle == "活跃型+视觉型" || stuNews2.learningStyle == "活跃型+言语型")
            {
                RegisterClientScriptBlock("", string.Format("<script type = 'text/javascript'>  alert('Attention！你需要复习的知识点有{0}');location.href= 'StudyData/StudyDataVideo5.aspx'</script>", Num));
            }
            else if (stuNews2.learningStyle == "沉思型+视觉型")
            {
                RegisterClientScriptBlock("", string.Format("<script type = 'text/javascript'>  alert('Attention！你需要复习的知识点有{0}');location.href= 'StudyData/StudyDataPicture5.aspx'</script>", Num));
            }
            else if (stuNews2.learningStyle == "沉思型+言语型")
            {
                RegisterClientScriptBlock("", string.Format("<script type = 'text/javascript'>  alert('Attention！你需要复习的知识点有{0}');location.href= 'StudyData/StudyDataText5.aspx'</script>", Num));
            }
        }
        else
        {
            RegisterClientScriptBlock("", string.Format("<script type = 'text/javascript'>  alert('Congratulations！你可以选择进入到学习资料库进行温故！');location.href= 'StudyData/StudyDataDefault.aspx'</script>"));    //跳转到学习资料库知识点1主界面
        }
    }
}