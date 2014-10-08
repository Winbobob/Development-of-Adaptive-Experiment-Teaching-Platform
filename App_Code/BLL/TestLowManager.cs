using System;
using System.Data;
using System.Configuration;
using System.Collections;
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
///Test 的摘要说明
/// </summary>
    public class TestLowManager
    {
        public TestLowManager()
        {
            //
            //TODO: 在此处添加构造函数逻辑
            //
        }
        /// <summary>
        /// 从数据库中获取低级单选题数量
        /// </summary>
        public static int CountRadioLow()
        {
            SQLHelper dbAccess = new SQLHelper();		//实例化一个SQLHelper类
            int recornnum = dbAccess.CountSqlRecordNum("RadioLow");	   //获取查询数据流
            //根据查询得到的数据，对成员赋值
            //数据流中是否有数据
            return recornnum;
        }
        /// <summary>
        /// 从数据库中获取低级单选题记录
        /// </summary>
        public static RadioLow GetLowRadio(int Id)
        {

            SQLHelper dbAccess = new SQLHelper();		//实例化一个SQLHelper类
            string sql = "Select * from [RadioLow] where Id = @Id";
            SqlParameter[] para = { new SqlParameter("@Id", Id) };   //利用参数para进行动态定义
            SqlDataReader dr = dbAccess.GetDRWithPara(sql, para);	   //获取查询数据流
            //根据查询得到的数据，对成员赋值
            //数据流中是否有数据
            if (dr.Read())
            {
                RadioLow rLow = new RadioLow();
                rLow.Id = int.Parse(dr["Id"].ToString());
                rLow.question = dr["question"].ToString();
                rLow.A = dr["A"].ToString();
                rLow.B = dr["B"].ToString();
                rLow.C = dr["C"].ToString();
                rLow.D = dr["D"].ToString();
                rLow.answer = dr["answer"].ToString();
                rLow.explain = dr["explain"].ToString();
                rLow.suggestion = int.Parse(dr["suggestion"].ToString());

                //关闭SqlDataReader对象，此时连接同时关闭
                dr.Close();
                return rLow;
            }
            else
            {
                dr.Close();
                return null;
            }
        }
        //通过RadioButtonList控件显示低级选择题题目
        public static void ShowQuestionRadioLow(RadioLow rLow,RadioButtonList rdoList,Label lbl)
        {
            rdoList.Items[0].Text = "A." + rLow.A;
            rdoList.Items[1].Text = "B." + rLow.B;
            rdoList.Items[2].Text = "C." + rLow.C;
            rdoList.Items[3].Text = "D." + rLow.D;

            rdoList.Items[0].Value = "A";
            rdoList.Items[1].Value = "B";
            rdoList.Items[2].Value = "C";
            rdoList.Items[3].Value = "D";
            lbl.Text = rLow.question;
        }
        //显示单选题的断点自选选项
        public static void ShowRadioLowBreakingpoint(BreakingPointRadio bp, RadioButtonList rdolist1, RadioButtonList rdolist2, RadioButtonList rdolist3, RadioButtonList rdolist4, RadioButtonList rdolist5)
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
        public static bool JudgingRadio(RadioButtonList rdolist, RadioLow rLow,Label lbl,Button btn)
        {
            bool correct;
            if (rdolist.SelectedValue == rLow.answer)
            {
                lbl.Text = "恭喜你答对了！";
                btn.Visible = true;
                return correct = true;
            }
            else
            {
                lbl.Text = "错误！正确答案：" + rLow.answer;
                btn.Visible = true;
                return correct = false;                
            }            
        }
        /// <summary>
        /// 从数据库中获取低级判断题数量
        /// </summary>
        public static int CountJudgeLow()
        {
            SQLHelper dbAccess = new SQLHelper();		//实例化一个SQLHelper类
            int recornnum = dbAccess.CountSqlRecordNum("JudgeLow");	   //获取查询数据流
            //根据查询得到的数据，对成员赋值
            //数据流中是否有数据
            return recornnum;
        }
        /// <summary>
        /// 从数据库中获取低级判断题记录
        /// </summary>
        public static JudgeLow GetLowJudge(int Id)
        {

            SQLHelper dbAccess = new SQLHelper();		//实例化一个SQLHelper类

            string sql = "Select * from [JudgeLow] where Id = @id";
            SqlParameter[] para = { new SqlParameter("@id", Id) };   //利用参数para进行动态定义
            SqlDataReader dr = dbAccess.GetDRWithPara(sql, para);	   //获取查询数据流

            //根据查询得到的数据，对成员赋值
            //数据流中是否有数据
            if (dr.Read())
            {
                JudgeLow jLow = new JudgeLow();
                
                jLow.Id = int.Parse(dr["Id"].ToString());
                jLow.question = dr["question"].ToString();
                jLow.answer = dr["answer"].ToString();
                jLow.explain = dr["explain"].ToString();
                jLow.suggestion = int.Parse(dr["suggestion"].ToString());

                //关闭SqlDataReader对象，此时连接同时关闭
                dr.Close();
                return jLow;
            }
            else
            {
                dr.Close();
                return null;
            }
        }
        //通过RadioButtonList控件显示低级判断题题目
        public static void ShowQuestionJudgeLow(JudgeLow jLow, RadioButtonList rdoList, Label lbl)
        {
            lbl.Text = jLow.question.ToString();

            rdoList.Items[0].Text = "T";
            rdoList.Items[1].Text = "F";

            rdoList.Items[0].Value = "T";
            rdoList.Items[1].Value = "F";
        }
        //显示判断题的断点自选选项
        public static void ShowJudgeLowBreakingpoint(BreakingPointJudge bp, RadioButtonList rdolist1, RadioButtonList rdolist2, RadioButtonList rdolist3, RadioButtonList rdolist4)
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
        public static bool JudgingJudge(RadioButtonList rdolist, JudgeLow jLow, Label lbl, Button btn)
        {
            bool correct;
            if (rdolist.SelectedValue == jLow.answer)
            {
                lbl.Text = "恭喜你答对了！";
                btn.Visible = true;
                return correct = true;
            }
            else
            {
                lbl.Text = "错误！正确答案：" + jLow.answer;
                btn.Visible = true;
                return correct = false;
            }
        }
        /// <summary>
        /// 从数据库中获取低级填空题数量
        /// </summary>
        public static int CountBlankLow()
        {
            SQLHelper dbAccess = new SQLHelper();		//实例化一个SQLHelper类
            int recornnum = dbAccess.CountSqlRecordNum("BlankLow");	   //获取查询数据流
            //根据查询得到的数据，对成员赋值
            //数据流中是否有数据
            return recornnum;
        }
        /// <summary>
        /// 从数据库中获取低级填空题记录
        /// </summary>
        public static BlankLow GetLowBlank(int Id)
        {

            SQLHelper dbAccess = new SQLHelper();		//实例化一个SQLHelper类
            string sql = "Select * from [BlankLow] where Id = @Id";
            SqlParameter[] para = { new SqlParameter("@Id", Id) };   //利用参数para进行动态定义
            SqlDataReader dr = dbAccess.GetDRWithPara(sql, para);	   //获取查询数据流
            //根据查询得到的数据，对成员赋值
            //数据流中是否有数据
            if (dr.Read())
            {
                BlankLow bLow = new BlankLow();
                
                bLow.Id = int.Parse(dr["Id"].ToString());
                bLow.qFront = dr["qFront"].ToString();
                bLow.qBack = dr["qBack"].ToString();
                bLow.answer = dr["answer"].ToString();
                bLow.explain = dr["explain"].ToString();
                bLow.suggestion = int.Parse(dr["suggestion"].ToString());

                //关闭SqlDataReader对象，此时连接同时关闭
                dr.Close();
                return bLow;
            }
            else
            {
                dr.Close();
                return null;
            }
        }
        //通过Label控件显示填空题题目
        public static void ShowQuestionBlankLow(BlankLow bLow, Label lbl1,Label lbl2)
        {
            lbl1.Text = bLow.qFront.ToString();
            lbl2.Text = bLow.qBack.ToString();
        }
        //显示填空题的断点自填内容
        public static void ShowBlankLowBreakingpoint(BreakingPointBlank bp, TextBox txt1, TextBox txt2, TextBox txt3)
        {
            txt1.Text = bp.ba1;
            txt2.Text = bp.ba2;
            txt3.Text = bp.ba3;
        }
        //判断填空题
        public static bool JudgingBlank(BlankLow bLow, TextBox txt1, Label lbl1, Button btn1)
        {
            bool correct;
            if (txt1.Text.Trim() == bLow.answer)
            {
                lbl1.Text = "√";
                btn1.Visible = true;
                return correct = true;
            }
            else
            {
                lbl1.Text = "×    正确答案：" + bLow.answer; ;
                btn1.Visible = true;
                return correct = false;
            }
        }
        /// <summary>
        /// 从数据库中获取低级设计题数量
        /// </summary>
        public static int CountDesignlow()
        {
            SQLHelper dbAccess = new SQLHelper();		//实例化一个SQLHelper类
            int recornnum = dbAccess.CountSqlRecordNum("Designlow");	   //获取查询数据流
            //根据查询得到的数据，对成员赋值
            //数据流中是否有数据
            return recornnum;
        }
        /// <summary>
        /// 从数据库中获取低级设计题记录
        /// </summary>
        public static DesignLow GetLowDesign(int Id)
        {

            SQLHelper dbAccess = new SQLHelper();		//实例化一个SQLHelper类

            string sql = "Select * from [Designlow] where Id = @Id";
            SqlParameter[] para = { new SqlParameter("@Id", Id) };   //利用参数para进行动态定义
            SqlDataReader dr = dbAccess.GetDRWithPara(sql, para);	   //获取查询数据流

            //根据查询得到的数据，对成员赋值
            //数据流中是否有数据
            if (dr.Read())
            {
                
                DesignLow dLow = new DesignLow();
                dLow.Id = int.Parse(dr["Id"].ToString());
                dLow.question = dr["question"].ToString();
                dLow.answer = dr["answer"].ToString();
                dLow.suggestion = int.Parse(dr["suggestion"].ToString());
                dLow.Q1 = dr["Q1"].ToString();
                dLow.A1 = dr["A1"].ToString();
                dLow.B1 = dr["B1"].ToString();
                dLow.C1 = dr["C1"].ToString();
                dLow.D1 = dr["D1"].ToString();
                dLow.answer1 = dr["answer1"].ToString().Trim();
                dLow.Q2 = dr["Q2"].ToString();
                dLow.A2 = dr["A2"].ToString();
                dLow.B2 = dr["B2"].ToString();
                dLow.C2 = dr["C2"].ToString();
                dLow.D2 = dr["D2"].ToString();
                dLow.answer2 = dr["answer2"].ToString().Trim();

                //关闭SqlDataReader对象，此时连接同时关闭
                dr.Close();
                return dLow;
            }
            else
            {
                dr.Close();
                return null;
            }
        }
        //通过Label控件显示设计题题目
        public static void ShowQuestionDesignLow(DesignLow dLow, Label lblD, Label lblS1, Label lblS2, RadioButtonList rdoListS1, RadioButtonList rdoListS2)
        {
            lblD.Text = dLow.question.ToString();

            lblS1.Text = dLow.Q1.ToString();

            rdoListS1.Items[0].Text = "A." + dLow.A1;
            rdoListS1.Items[1].Text = "B." + dLow.B1;
            rdoListS1.Items[2].Text = "C." + dLow.C1;
            rdoListS1.Items[3].Text = "D." + dLow.D1;

            rdoListS1.Items[0].Value = "A";
            rdoListS1.Items[1].Value = "B";
            rdoListS1.Items[2].Value = "C";
            rdoListS1.Items[3].Value = "D";

            lblS2.Text = dLow.Q2.ToString();

            rdoListS2.Items[0].Text = "A." + dLow.A2;
            rdoListS2.Items[1].Text = "B." + dLow.B2;
            rdoListS2.Items[2].Text = "C." + dLow.C2;
            rdoListS2.Items[3].Text = "D." + dLow.D2;

            rdoListS2.Items[0].Value = "A";
            rdoListS2.Items[1].Value = "B";
            rdoListS2.Items[2].Value = "C";
            rdoListS2.Items[3].Value = "D";
        }
        public static void ShowQuestionDesignLow2(DesignLow dLow, Label lblD)
        {
            lblD.Text = dLow.question.ToString();
        }
        //设计题的单选题判定
        public static bool JudgingDesignRadio(RadioButtonList rdolistS1, RadioButtonList rdolistS2, DesignLow dLow, Label lblS1,Label lblS2)
        {
            bool correct1, correct2;
            if (rdolistS1.SelectedValue == dLow.answer1)
            {
                lblS1.Text = "恭喜你答对了！";
                correct1 = true;
            }
            else
            {
                lblS1.Text = "错误！正确答案：" + dLow.answer1;
                correct1 = false;   
            }
            if (rdolistS2.SelectedValue == dLow.answer2)
            {
                lblS2.Text = "恭喜你答对了！";
                correct2 = true;
            }
            else
            {
                lblS2.Text = "错误！正确答案：" + dLow.answer2;
                correct2 = false;
            }
            return correct1 && correct2;
        }
        public static void JudgingDesign(DesignLow dLow,Button btnanswer)
        {
            btnanswer.Visible = true;
        }
        /// <summary>
        /// 向数据库DesignUpload表添加记录
        /// </summary>
        public static int AddDesignUpload(string stuId,string learningLevel,DateTime createTime, string urlUpload,string filename)
        {
            SQLHelper dbAccess = new SQLHelper();  //实例化一个SQLHelp类
            string sql = "Insert Into [DesignUpload] Values( "
                + "'" + stuId + "',"
                + "'" + learningLevel + "',"
                + "'" + createTime + "',"
                + "'" + urlUpload + "',"
                + "'" + filename  + "')";
            return dbAccess.doSql(sql); //利用SQLHelp类的doSql方法增加用户        
        }
        //单选题分数计算
        public static int radioScore(RadioLow rLow1, RadioLow rLow2, RadioLow rLow3, RadioLow rLow4, RadioLow rLow5, RadioButtonList rdolist1, RadioButtonList rdolist2, RadioButtonList rdolist3, RadioButtonList rdolist4, RadioButtonList rdolist5)
        {
            int score = 0;
            if (rdolist1.SelectedValue == rLow1.answer)
            {
                score += 7;
            }
            if (rdolist2.SelectedValue == rLow2.answer)
            {
                score += 7;
            }
            if (rdolist3.SelectedValue == rLow3.answer)
            {
                score += 7;
            }
            if (rdolist4.SelectedValue == rLow4.answer)
            {
                score += 7;
            }
            if (rdolist5.SelectedValue == rLow5.answer)
            {
                score += 7;
            }
            return score;
        }
        public static int radioScore2(RadioLow rLow1, RadioLow rLow2, RadioLow rLow3, RadioLow rLow4, RadioLow rLow5, RadioButtonList rdolist1, RadioButtonList rdolist2, RadioButtonList rdolist3, RadioButtonList rdolist4, RadioButtonList rdolist5)
        {
            int score = 0;
            if (rdolist1.SelectedValue == rLow1.answer)
            {
                score += 10;
            }
            if (rdolist2.SelectedValue == rLow2.answer)
            {
                score += 10;
            }
            if (rdolist3.SelectedValue == rLow3.answer)
            {
                score += 10;
            }
            if (rdolist4.SelectedValue == rLow4.answer)
            {
                score += 10;
            }
            if (rdolist5.SelectedValue == rLow5.answer)
            {
                score += 10;
            }
            return score;
        }
        //判断题分数计算
        public static int judgeScore(JudgeLow jLow1, JudgeLow jLow2, JudgeLow jLow3,JudgeLow jLow4, RadioButtonList rdolist1, RadioButtonList rdolist2, RadioButtonList rdolist3, RadioButtonList rdolist4)
        {
            int score = 0;
            if (rdolist1.SelectedValue == jLow1.answer)
            {
                score += 5;
            }
            if (rdolist2.SelectedValue == jLow2.answer)
            {
                score += 5;
            }
            if (rdolist3.SelectedValue == jLow3.answer)
            {
                score += 5;
            }
            if (rdolist4.SelectedValue == jLow4.answer)
            {
                score += 5;
            }
            return score;
        }
        public static int judgeScore2(JudgeLow jLow1, JudgeLow jLow2, JudgeLow jLow3,JudgeLow jLow4, JudgeLow jLow5, RadioButtonList rdolist1, RadioButtonList rdolist2, RadioButtonList rdolist3, RadioButtonList rdolist4, RadioButtonList rdolist5)
        {
            int score = 0;
            if (rdolist1.SelectedValue == jLow1.answer)
            {
                score += 10;
            }
            if (rdolist2.SelectedValue == jLow2.answer)
            {
                score += 10;
            }
            if (rdolist3.SelectedValue == jLow3.answer)
            {
                score += 10;
            }
            if (rdolist4.SelectedValue == jLow4.answer)
            {
                score += 10;
            }
            if (rdolist5.SelectedValue == jLow5.answer)
            {
                score += 10;
            }
            return score;
        }
        //填空题分数计算
        public static int blankScore(BlankLow bLow1, BlankLow bLow2, BlankLow bLow3,TextBox txt1, TextBox txt2, TextBox txt3)
        {
            int score = 0;
            if (txt1.Text.Trim() == bLow1.answer)
            {
                score += 5;
            }
            if (txt2.Text.Trim() == bLow2.answer)
            {
                score += 5;
            }
            if (txt3.Text.Trim() == bLow3.answer)
            {
                score += 5;
            }
            return score;
        }
        //设计题分数计算
        public static int designScore(DesignLow dLow, RadioButtonList rdolist1, RadioButtonList rdolist2)
        {
            int score = 0;
            if (rdolist1.SelectedValue == dLow.answer1)
            {
                score += 15;
            }
            if (rdolist2.SelectedValue == dLow.answer2)
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
        //判断分数等级
        public static int Score2(int radioScore, int judgeScore)
        {
            int scoreJudge = 0;
            int scoreAll;
            scoreAll = radioScore + judgeScore;

            if (scoreAll < 60)
            {
                scoreJudge = 0;
            }
            else if (scoreAll >= 60 && scoreAll < 75)
            {
                scoreJudge = 1;
            }
            else if (scoreAll >= 75 && scoreAll < 90)
            {
                scoreJudge = 2;
            }
            else
            {
                scoreJudge = 3;
            }
            return scoreJudge;
        }
        //消息框显示分数情况
        public static string ShowScoreString(int radioScore, int judgeScore, int blankScore, int designScore,bool scoreJudge)
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
        public static string ShowScoreString2(int radioScore, int judgeScore, int scoreJudge)
        {
            string str = null;
            int scoreAll;
            scoreAll = radioScore + judgeScore;

            if (scoreJudge == 0)
            {
                str += "您本套测试练习的总分数为：" + scoreAll;
                str += "很遗憾，您没有通过前测！请继续努力。";
            }
            else if (scoreJudge == 1)
            {
                str += "您本套测试练习的总分数为：" + scoreAll;
                str += "恭喜您，您已通过前测！可以进入低级测试内容。";
            }
            else if (scoreJudge == 2)
            {
                str += "您本套测试练习的总分数为：" + scoreAll;
                str += "恭喜您，您已通过前测！可以直接进入中级测试内容。";
            }
            else
            {
                str += "您本套测试练习的总分数为：" + scoreAll;
                str += "恭喜您，您已通过前测！可以直接进入高级测试内容。";
            }
            str += "您的选择题得分为：" + radioScore;
            str += "您的判断题得分为：" + judgeScore;

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
        public static int UpdateStudyingScore2(string stuId)
       {
            SQLHelper dbAccess = new SQLHelper();  //实例化一个SQLHelp类
            string sql = "Insert Into [ClassUnit] Values('" + stuId + "',0,0,0,0,0,0,0,0)";
            return dbAccess.doSql(sql);	//利用SQLHelp类的doSql方法增加用户    
       }
    }

