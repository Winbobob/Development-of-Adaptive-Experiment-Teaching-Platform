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
using SelfAdaptivePlatform.Model;
using SelfAdaptivePlatform.DAL;
using System.Data.SqlClient;

/// <summary>
///TestMidManager 的摘要说明
/// </summary>
public class TestMidManager
{
    public TestMidManager()
    {
        //
        //TODO: 在此处添加构造函数逻辑
        //
    }

    /// <summary>
    /// 从数据库中获取中级单选题数量
    /// </summary>
    public static int CountRadio()
    {
        SQLHelper dbAccess = new SQLHelper();		//实例化一个SQLHelper类
        int recornnum = dbAccess.CountSqlRecordNum("RadioMid");	   //获取查询数据流
        //根据查询得到的数据，对成员赋值
        //数据流中是否有数据
        return recornnum;
    }

    /// <summary>
    /// 从数据库中获取中级单选题记录
    /// </summary>
    public static RadioMid GetRadio(int Id)
    {

        SQLHelper dbAccess = new SQLHelper();		//实例化一个SQLHelper类
        string sql = "Select * from [RadioMid] where Id = @Id";
        SqlParameter[] para = { new SqlParameter("@Id", Id) };   //利用参数para进行动态定义
        SqlDataReader dr = dbAccess.GetDRWithPara(sql, para);	   //获取查询数据流
        //根据查询得到的数据，对成员赋值
        //数据流中是否有数据
        if (dr.Read())
        {
            RadioMid r = new RadioMid();
            r.Id = int.Parse(dr["Id"].ToString());
            r.question = dr["question"].ToString();
            r.A = dr["A"].ToString();
            r.B = dr["B"].ToString();
            r.C = dr["C"].ToString();
            r.D = dr["D"].ToString();
            r.answer = dr["answer"].ToString();
            r.explain = dr["explain"].ToString();
            r.suggestion = int.Parse(dr["suggestion"].ToString());

            //关闭SqlDataReader对象，此时连接同时关闭
            dr.Close();
            return r;
        }
        else
        {
            dr.Close();
            return null;
        }
    }

    //通过RadioButtonList控件显示中级选择题题目
    public static void ShowQuestionRadio(RadioMid r, RadioButtonList rdoList, Label lbl)
    {
        rdoList.Items[0].Text = "A." + r.A;
        rdoList.Items[1].Text = "B." + r.B;
        rdoList.Items[2].Text = "C." + r.C;
        rdoList.Items[3].Text = "D." + r.D;

        rdoList.Items[0].Value = "A";
        rdoList.Items[1].Value = "B";
        rdoList.Items[2].Value = "C";
        rdoList.Items[3].Value = "D";
        lbl.Text = r.question;
    }

    //显示单选题的断点自选选项
    public static void ShowRadioBreakingpoint(BreakingPointRadio bp, RadioButtonList rdolist1, RadioButtonList rdolist2, RadioButtonList rdolist3, RadioButtonList rdolist4, RadioButtonList rdolist5)
    {
        if (bp.ra1 != null)
        {
            string selected = bp.ra1;
            if (selected == "A")
            {
                rdolist1.Items[0].Selected = true;
            }
            else if (selected == "B")
            {
                rdolist1.Items[1].Selected = true;
            }
            else if (selected == "C")
            {
                rdolist1.Items[2].Selected = true;
            }
            else if (selected == "D")
            {
                rdolist1.Items[3].Selected = true;
            }
            else
            {
                rdolist1.Items[0].Selected = false;
                rdolist1.Items[1].Selected = false;
                rdolist1.Items[2].Selected = false;
                rdolist1.Items[3].Selected = false;
            }
        }
        if (bp.ra2 != null)
        {
            string selected = bp.ra2;
            if (selected == "A")
            {
                rdolist2.Items[0].Selected = true;
            }
            else if (selected == "B")
            {
                rdolist2.Items[1].Selected = true;
            }
            else if (selected == "C")
            {
                rdolist2.Items[2].Selected = true;
            }
            else if (selected == "D")
            {
                rdolist2.Items[3].Selected = true;
            }
            else
            {
                rdolist2.Items[0].Selected = false;
                rdolist2.Items[1].Selected = false;
                rdolist2.Items[2].Selected = false;
                rdolist2.Items[3].Selected = false;
            }
        }
        if (bp.ra3 != null)
        {
            string selected = bp.ra3;
            if (selected == "A")
            {
                rdolist3.Items[0].Selected = true;
            }
            else if (selected == "B")
            {
                rdolist3.Items[1].Selected = true;
            }
            else if (selected == "C")
            {
                rdolist3.Items[2].Selected = true;
            }
            else if (selected == "D")
            {
                rdolist3.Items[3].Selected = true;
            }
            else
            {
                rdolist3.Items[0].Selected = false;
                rdolist3.Items[1].Selected = false;
                rdolist3.Items[2].Selected = false;
                rdolist3.Items[3].Selected = false;
            }
        }
        if (bp.ra4 != null)
        {
            string selected = bp.ra4;
            if (selected == "A")
            {
                rdolist4.Items[0].Selected = true;
            }
            else if (selected == "B")
            {
                rdolist4.Items[1].Selected = true;
            }
            else if (selected == "C")
            {
                rdolist4.Items[2].Selected = true;
            }
            else if (selected == "D")
            {
                rdolist4.Items[3].Selected = true;
            }
            else
            {
                rdolist4.Items[0].Selected = false;
                rdolist4.Items[1].Selected = false;
                rdolist4.Items[2].Selected = false;
                rdolist4.Items[3].Selected = false;
            }
        }
        if (bp.ra5 != null)
        {
            string selected = bp.ra5;
            if (selected == "A")
            {
                rdolist5.Items[0].Selected = true;
            }
            else if (selected == "B")
            {
                rdolist5.Items[1].Selected = true;
            }
            else if (selected == "C")
            {
                rdolist5.Items[2].Selected = true;
            }
            else if (selected == "D")
            {
                rdolist5.Items[3].Selected = true;
            }
            else
            {
                rdolist5.Items[0].Selected = false;
                rdolist5.Items[1].Selected = false;
                rdolist5.Items[2].Selected = false;
                rdolist5.Items[3].Selected = false;
            }
        }
    }

    //单选题判定
    public static bool JudgingRadio(RadioButtonList rdolist, RadioMid r, Label lbl, Button btn)
    {
        bool correct;
        if (rdolist.SelectedValue == r.answer)
        {
            lbl.Text = "恭喜你答对了！";
            btn.Visible = true;
            return correct = true;
        }
        else
        {
            lbl.Text = "错误！正确答案：" + r.answer;
            btn.Visible = true;
            return correct = false;

        }
    }

    
    /// <summary>
    /// 从数据库中获取中级判断题数量
    /// </summary>
    public static int CountJudge()
    {
        SQLHelper dbAccess = new SQLHelper();		//实例化一个SQLHelper类
        int recornnum = dbAccess.CountSqlRecordNum("JudgeMid");	   //获取查询数据流
        //根据查询得到的数据，对成员赋值
        //数据流中是否有数据
        return recornnum;
    }

    /// <summary>
    /// 从数据库中获取中级判断题记录
    /// </summary>
    public static JudgeMid GetJudge(int Id)
    {

        SQLHelper dbAccess = new SQLHelper();		//实例化一个SQLHelper类

        string sql = "Select * from [JudgeMid] where Id = @id";
        SqlParameter[] para = { new SqlParameter("@id", Id) };   //利用参数para进行动态定义
        SqlDataReader dr = dbAccess.GetDRWithPara(sql, para);	   //获取查询数据流

        //根据查询得到的数据，对成员赋值
        //数据流中是否有数据
        if (dr.Read())
        {
            JudgeMid j = new JudgeMid();

            j.Id = int.Parse(dr["Id"].ToString());
            j.question = dr["question"].ToString();
            j.answer = dr["answer"].ToString();
            j.explain = dr["explain"].ToString();
            j.suggestion = int.Parse(dr["suggestion"].ToString());

            //关闭SqlDataReader对象，此时连接同时关闭
            dr.Close();
            return j;
        }
        else
        {
            dr.Close();
            return null;
        }
    }

    //通过RadioButtonList控件显示中级判断题题目
    public static void ShowQuestionJudge(JudgeMid j, RadioButtonList rdoList, Label lbl)
    {
        lbl.Text = j.question.ToString();

        rdoList.Items[0].Text = "T";
        rdoList.Items[1].Text = "F";

        rdoList.Items[0].Value = "T";
        rdoList.Items[1].Value = "F";
    }

    //显示判断题的断点自选选项
    public static void ShowJudgeBreakingpoint(BreakingPointJudge bp, RadioButtonList rdolist1, RadioButtonList rdolist2, RadioButtonList rdolist3, RadioButtonList rdolist4)
    {
        if (bp.ja1 != null)
        {
            string selected = bp.ja1;
            if (selected == "T")
            {
                rdolist1.Items[0].Selected = true;
            }
            else if (selected == "F")
            {
                rdolist1.Items[1].Selected = true;
            }
            else
            {
                rdolist1.Items[0].Selected = false;
                rdolist1.Items[1].Selected = false;
            }
        }
        if (bp.ja2 != null)
        {
            string selected = bp.ja2;
            if (selected == "T")
            {
                rdolist2.Items[0].Selected = true;
            }
            else if (selected == "F")
            {
                rdolist2.Items[1].Selected = true;
            }
            else
            {
                rdolist2.Items[0].Selected = false;
                rdolist2.Items[1].Selected = false;
            }
        }
        if (bp.ja3 != null)
        {
            string selected = bp.ja3;
            if (selected == "T")
            {
                rdolist3.Items[0].Selected = true;
            }
            else if (selected == "F")
            {
                rdolist3.Items[1].Selected = true;
            }
            else
            {
                rdolist3.Items[0].Selected = false;
                rdolist3.Items[1].Selected = false;
            }
        }
        if (bp.ja4 != null)
        {
            string selected = bp.ja4;
            if (selected == "T")
            {
                rdolist4.Items[0].Selected = true;
            }
            else if (selected == "F")
            {
                rdolist4.Items[1].Selected = true;
            }
            else
            {
                rdolist4.Items[0].Selected = false;
                rdolist4.Items[1].Selected = false;
            }
        }
    }

    //判断题判定
    public static bool JudgingJudge(RadioButtonList rdolist, JudgeMid j, Label lbl, Button btn)
    {
        bool correct;
        if (rdolist.SelectedValue == j.answer)
        {
            lbl.Text = "恭喜你答对了！";
            btn.Visible = true;
            return correct = true;
        }
        else
        {
            lbl.Text = "错误！正确答案：" + j.answer;
            btn.Visible = true;
            return correct = false;
        }
    }

    /// <summary>
    /// 从数据库中获取中级填空题数量
    /// </summary>
    public static int CountBlank()
    {
        SQLHelper dbAccess = new SQLHelper();		//实例化一个SQLHelper类
        int recornnum = dbAccess.CountSqlRecordNum("BlankMid");	   //获取查询数据流
        //根据查询得到的数据，对成员赋值
        //数据流中是否有数据
        return recornnum;
    }

    /// <summary>
    /// 从数据库中获取中级填空题记录
    /// </summary>
    public static BlankMid GetBlank(int Id)
    {

        SQLHelper dbAccess = new SQLHelper();		//实例化一个SQLHelper类

        string sql = "Select * from [BlankMid] where Id = @Id";
        SqlParameter[] para = { new SqlParameter("@Id", Id) };   //利用参数para进行动态定义
        SqlDataReader dr = dbAccess.GetDRWithPara(sql, para);	   //获取查询数据流

        //根据查询得到的数据，对成员赋值
        //数据流中是否有数据
        if (dr.Read())
        {
            BlankMid b = new BlankMid();

            b.Id = int.Parse(dr["Id"].ToString());
            b.qFront = dr["qFront"].ToString();
            b.qBack = dr["qBack"].ToString();
            b.answer = dr["answer"].ToString();
            b.explain = dr["explain"].ToString();
            b.suggestion = int.Parse(dr["suggestion"].ToString());

            //关闭SqlDataReader对象，此时连接同时关闭
            dr.Close();
            return b;
        }
        else
        {
            dr.Close();
            return null;
        }
    }



    //通过Label控件显示填空题题目
    public static void ShowQuestionBlank(BlankMid b, Label lbl1, Label lbl2)
    {
        lbl1.Text = b.qFront.ToString();
        lbl2.Text = b.qBack.ToString();
    }

    //显示填空题的断点自填内容
    public static void ShowBlankBreakingpoint(BreakingPointBlank bp, TextBox txt1, TextBox txt2, TextBox txt3)
    {
        txt1.Text = bp.ba1;
        txt2.Text = bp.ba2;
        txt3.Text = bp.ba3;
    }

    //判断填空题
    public static bool JudgingBlank(BlankMid b, TextBox txt1, Label lbl1, Button btn1)
    {
        bool correct;
        if (txt1.Text.Trim() == b.answer)
        {
            lbl1.Text = "√";
            btn1.Visible = true;
            return correct = true;
        }
        else
        {
            lbl1.Text = "×    正确答案：" + b.answer; ;
            btn1.Visible = true;
            return correct = false;
        }
    }

    /// <summary>
    /// 从数据库中获取中级设计题数量
    /// </summary>
    public static int CountDesign()
    {
        SQLHelper dbAccess = new SQLHelper();		//实例化一个SQLHelper类
        int recornnum = dbAccess.CountSqlRecordNum("DesignMid");	   //获取查询数据流
        //根据查询得到的数据，对成员赋值
        //数据流中是否有数据
        return recornnum;
    }

    /// <summary>
    /// 从数据库中获取中级设计题记录
    /// </summary>
    public static DesignMid GetDesign(int Id)
    {

        SQLHelper dbAccess = new SQLHelper();		//实例化一个SQLHelper类

        string sql = "Select * from [DesignMid] where Id = @Id";
        SqlParameter[] para = { new SqlParameter("@Id", Id) };   //利用参数para进行动态定义
        SqlDataReader dr = dbAccess.GetDRWithPara(sql, para);	   //获取查询数据流

        //根据查询得到的数据，对成员赋值
        //数据流中是否有数据
        if (dr.Read())
        {

            DesignMid d = new DesignMid();
            d.Id = int.Parse(dr["Id"].ToString());
            d.question = dr["question"].ToString();
            d.answer = dr["answer"].ToString();
            d.suggestion = int.Parse(dr["suggestion"].ToString());
            d.Q1 = dr["Q1"].ToString();
            d.A1 = dr["A1"].ToString();
            d.B1 = dr["B1"].ToString();
            d.C1 = dr["C1"].ToString();
            d.D1 = dr["D1"].ToString();
            d.answer1 = dr["answer1"].ToString().Trim();
            d.Q2 = dr["Q2"].ToString();
            d.A2 = dr["A2"].ToString();
            d.B2 = dr["B2"].ToString();
            d.C2 = dr["C2"].ToString();
            d.D2 = dr["D2"].ToString();
            d.answer2 = dr["answer2"].ToString().Trim();

            //关闭SqlDataReader对象，此时连接同时关闭
            dr.Close();
            return d;
        }
        else
        {
            dr.Close();
            return null;
        }
    }

    //通过Label控件显示设计题题目
    public static void ShowQuestionDesign(DesignMid d, Label lblD, Label lblS1, Label lblS2, RadioButtonList rdoListS1, RadioButtonList rdoListS2)
    {
        lblD.Text = d.question.ToString();

        lblS1.Text = d.Q1.ToString();

        rdoListS1.Items[0].Text = "A." + d.A1;
        rdoListS1.Items[1].Text = "B." + d.B1;
        rdoListS1.Items[2].Text = "C." + d.C1;
        rdoListS1.Items[3].Text = "D." + d.D1;

        rdoListS1.Items[0].Value = "A";
        rdoListS1.Items[1].Value = "B";
        rdoListS1.Items[2].Value = "C";
        rdoListS1.Items[3].Value = "D";

        lblS2.Text = d.Q2.ToString();

        rdoListS2.Items[0].Text = "A." + d.A2;
        rdoListS2.Items[1].Text = "B." + d.B2;
        rdoListS2.Items[2].Text = "C." + d.C2;
        rdoListS2.Items[3].Text = "D." + d.D2;

        rdoListS2.Items[0].Value = "A";
        rdoListS2.Items[1].Value = "B";
        rdoListS2.Items[2].Value = "C";
        rdoListS2.Items[3].Value = "D";
    }

    public static void ShowQuestionDesign2(DesignMid d, Label lblD)
    {
        lblD.Text = d.question.ToString();
    }

    //设计题的单选题判定
    public static bool JudgingDesignRadio(RadioButtonList rdolistS1, RadioButtonList rdolistS2, DesignMid d, Label lblS1, Label lblS2)
    {
        bool correct1, correct2;
        if (rdolistS1.SelectedValue == d.answer1)
        {
            lblS1.Text = "恭喜你答对了！";
            correct1 = true;
        }
        else
        {
            lblS1.Text = "错误！正确答案：" + d.answer1;
            correct1 = false;
        }

        if (rdolistS2.SelectedValue == d.answer2)
        {
            lblS2.Text = "恭喜你答对了！";
            correct2 = true;

        }
        else
        {
            lblS2.Text = "错误！正确答案：" + d.answer2;
            correct2 = false;
        }
        return correct1 && correct2;
    }

    public static void JudgingDesign(DesignMid d, Button btnanswer)
    {
        btnanswer.Visible = true;
    }

    /// <summary>
    /// 向数据库DesignUpload表添加记录
    /// </summary>
    public static int AddDesignUpload(string stuId, string learningLevel, DateTime createTime, string urlUpload, string filename)
    {
        SQLHelper dbAccess = new SQLHelper();  //实例化一个SQLHelp类
        string sql = "Insert Into [DesignUpload] Values( "
            + "'" + stuId + "',"
            + "'" + learningLevel + "',"
            + "'" + createTime + "',"
            + "'" + urlUpload + "',"
            + "'" + filename + "')";
        return dbAccess.doSql(sql); //利用SQLHelp类的doSql方法增加用户        
    }



    //单选题分数计算
    public static int radioScore(RadioMid r1, RadioMid r2, RadioMid r3, RadioMid r4, RadioMid r5, RadioButtonList rdolist1, RadioButtonList rdolist2, RadioButtonList rdolist3, RadioButtonList rdolist4, RadioButtonList rdolist5)
    {
        int score = 0;
        if (rdolist1.SelectedValue == r1.answer)
        {
            score += 7;
        }
        if (rdolist2.SelectedValue == r2.answer)
        {
            score += 7;
        }
        if (rdolist3.SelectedValue == r3.answer)
        {
            score += 7;
        }
        if (rdolist4.SelectedValue == r4.answer)
        {
            score += 7;
        }
        if (rdolist5.SelectedValue == r5.answer)
        {
            score += 7;
        }
        return score;
    }


    //判断题分数计算
    public static int judgeScore(JudgeMid j1, JudgeMid j2, JudgeMid j3, JudgeMid j4, RadioButtonList rdolist1, RadioButtonList rdolist2, RadioButtonList rdolist3, RadioButtonList rdolist4)
    {
        int score = 0;
        if (rdolist1.SelectedValue == j1.answer)
        {
            score += 5;
        }
        if (rdolist2.SelectedValue == j2.answer)
        {
            score += 5;
        }
        if (rdolist3.SelectedValue == j3.answer)
        {
            score += 5;
        }
        if (rdolist4.SelectedValue == j4.answer)
        {
            score += 5;
        }
        return score;
    }


    //填空题分数计算
    public static int blankScore(BlankMid b1, BlankMid b2, BlankMid b3, TextBox txt1, TextBox txt2, TextBox txt3)
    {
        int score = 0;
        if (txt1.Text.Trim() == b1.answer)
        {
            score += 5;
        }
        if (txt2.Text.Trim() == b2.answer)
        {
            score += 5;
        }
        if (txt3.Text.Trim() == b3.answer)
        {
            score += 5;
        }
        return score;
    }

    //设计题分数计算
    public static int designScore(DesignMid d, RadioButtonList rdolist1, RadioButtonList rdolist2)
    {
        int score = 0;
        if (rdolist1.SelectedValue == d.answer1)
        {
            score += 15;
        }
        if (rdolist2.SelectedValue == d.answer2)
        {
            score += 15;
        }
        return score;
    }

    //判断分数是否合格
    public static bool Score(int radioScore, int judgeScore, int clozeScore, int designScore)
    {
        bool scoreJudge = false;
        int scoreAll;
        scoreAll = radioScore + judgeScore + clozeScore + designScore;

        if (scoreAll < 60)
        {
            scoreJudge = false;
        }
        else
        {
            scoreJudge = true;
        }

        return scoreJudge;
    }

    
    
    //消息框显示分数情况
    public static string ShowScoreString(int radioScore, int judgeScore, int blankScore, int designScore, bool scoreJudge)
    {
        string str = null;
        int scoreAll;
        scoreAll = radioScore + judgeScore + blankScore + designScore;

        if (scoreJudge == false)
        {
            str += "您本套测试练习的总分数为：" + scoreAll;
            str += "很遗憾，您没有通过当前等级测试！";
        }
        else
        {
            str += "您本套测试练习的总分数为：" + scoreAll;
            str += "恭喜您，您已通过当前等级测试！您将进入高一级测试内容。";
        }

        str += "您的选择题得分为：" + radioScore;
        str += "您的判断题得分为：" + judgeScore;
        str += "您的填空题得分为：" + blankScore;
        str += "您的设计题得分为：" + designScore;

        return str;
    }
    
    //判断是否存在该用户的成绩记录
    public static bool StudentScoreCheck(string stuId)
    {

        SQLHelper dbAccess = new SQLHelper();    //实例化一个SQLHelper类
        string sql = "select * from [ClassUnit] where stuId=@stuId";
        SqlParameter[] para = { new SqlParameter("@stuId", stuId) };
        //Command命令
        SqlDataReader dr = dbAccess.GetDRWithPara(sql, para);   //获取查询数据流

        if (dr.Read())  //利用DataReader对象的read()方法，判断是否读取到数据
        {
            //关闭SqlDataReader对象，此时连接同时关闭
            dr.Close();
            return true;
        }
        else
        {
            dr.Close();
            return false;
        }
    }


    //将分数更新入ClassUnit
    public static int UpdateStudyingScore(string stuId, string learningLevel, int score)
    {
        SQLHelper dbAccess = new SQLHelper();  //实例化一个SQLHelp类
        string sql = "Update [ClassUnit] Set " + learningLevel + " = " + score + "where stuId='" + stuId + "'";
        return dbAccess.doSql(sql); //利用SQLHelp类的doSql方法更新消息数据    

    }
    

}

