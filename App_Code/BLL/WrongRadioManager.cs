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
using SelfAdaptivePlatform.BLL;
/// <summary>
/// Summary description for WrongRadioManager
/// </summary>
public class WrongRadioManager
{
    public WrongRadioManager()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public static string Wrongnum(string stuId, string grade)
    {
        SQLHelper dbAccess = new SQLHelper();    //实例化一个SQLHelper类
        string sql = "select count(*) from WrongTotal where stuId='" + stuId + "' and type='WrongRadio'and grade='" + grade + "' ";
        return dbAccess.doSqlForFirst(sql);
    }
    public static RadioLow GetWrongLowRadio(int ID, string stuID, string sTable, string cTable)
    {
        SQLHelper dbAccess = new SQLHelper();    //实例化一个SQLHelper类
        string sqlID = "select * from[" + cTable + "]INNER JOIN [" + sTable + "] ON [" + cTable + "].Id = [" + sTable + "].Id AND [" + sTable + "].stuID='" + stuID + "' AND[" + sTable + "].Id = @Id";
        SqlParameter[] para = { new SqlParameter("@Id", ID) };    //利用参数para进行动态定义
        SqlDataReader drID = dbAccess.GetDRWithPara(sqlID, para);
        if (drID.Read())
        {
            RadioLow rLow = new RadioLow();
            rLow.Id = int.Parse(drID["Id"].ToString());
            rLow.question = drID["question"].ToString();
            rLow.A = drID["A"].ToString();
            rLow.B = drID["B"].ToString();
            rLow.C = drID["C"].ToString();
            rLow.D = drID["D"].ToString();
            rLow.answer = drID["answer"].ToString();
            rLow.explain = drID["explain"].ToString();
            rLow.suggestion = int.Parse(drID["suggestion"].ToString());
            //关闭SqlDataReader对象，此时连接同时关闭
            drID.Close();
            return rLow;
        }
        else
        {
            drID.Close();
            return null;
        }
    }
    //通过RadioButtonList控件显示低级选择题题目
    public static void ShowQuestionRadioLow(RadioLow rLow, RadioButtonList rdoList, Label lbl)
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
    //清空题目
    public static void ClearQuestion(RadioLow rLow, RadioButtonList rdoList, Label lbl)
    {
        rdoList.Items[0].Text = "";
        rdoList.Items[1].Text = "";
        rdoList.Items[2].Text = "";
        rdoList.Items[3].Text = "";

        rdoList.Items[0].Value = "";
        rdoList.Items[1].Value = "";
        rdoList.Items[2].Value = "";
        rdoList.Items[3].Value = "";
        lbl.Text = "";
    }
    public static int calcLength(string stuID, string sTable, string cTable)
    {
        SQLHelper dbAccess = new SQLHelper();    //实例化一个SQLHelper类
        string sql = "Select count(*) from [" + cTable + "]INNER JOIN [" + sTable + "] ON [" + cTable + "].Id = [" + sTable + "].Id AND [" + sTable + "].stuID='" + stuID + "'";
        return Convert.ToInt32(dbAccess.doSqlForFirst(sql));
    }
    public static int[] getId(string stuID, string sTable, string cTable)
    {
        SQLHelper dbAccess = new SQLHelper();    //实例化一个SQLHelper类
        string sqlID = "select [" + sTable + "].id from[" + cTable + "]INNER JOIN [" + sTable + "] ON [" + cTable + "].Id = [" + sTable + "].Id AND [" + sTable + "].stuID='" + stuID + "'";
        int[] Id = new int[10];
        int i = 0;
        int Id1 = WrongRadioManager.calcLength(stuID,sTable,cTable);
        for (i = 0; i < Id1; i++)
        {
            int b = i + 1;
            string sqlEachId = "select top 1 id from (select top " + b + " * from " + sTable + " order by id )" + sTable + " where stuId= '" + stuID + "' order by id desc";
            Id[i] = Convert.ToInt32(dbAccess.doSqlForFirst(sqlEachId));
        }
        return Id;
    }
    //单选题判定
    public static void JudgingRadio(RadioButtonList rdolist, RadioLow rLow, Label lbl, Button btn)
    {
        if (rdolist.SelectedValue == rLow.answer)
        {
            lbl.Text = "恭喜你答对了！";
            btn.Visible = true;
        }
        else
        {
            lbl.Text = "错误！正确答案：" + rLow.answer;
            btn.Visible = true;
        }
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
    public static bool radioTF(RadioLow rLow1,RadioButtonList rdolist1)
    {
        bool TF_1 = false;
        if (rdolist1.SelectedValue == rLow1.answer)
        {
            TF_1 = true;
        }
        return TF_1;
    }
    public static void radioNum(int ID, string stuID, string sTable)
    {
        SQLHelper dbAccess = new SQLHelper();    //实例化一个SQLHelper类
        string sql = "update [" + sTable + "] set num=num+1 where stuId= '" + stuID + "' and id=" + ID;
        dbAccess.doSql(sql);
    }
    public static DataSet LoadPart(string cTable, string grade, string stuID)
    {
        SQLHelper dbAccess = new SQLHelper();    //实例化一个SQLHelper类
        string sql = "Select question,A,B,C,D,answer,num,Tid,[" + cTable + "].id from WrongTotal," + cTable + " where  " + cTable + ".Id = WrongTotal.Id AND stuID='" + stuID + "' and grade='" + grade + "' and type='WrongRadio' order by num desc";
        DataSet ds = dbAccess.doExcuteForDataset(sql, null, CommandType.Text);    //利用SQLHelper类的doExcuteForDataset方法查询最近的n条发言
        return ds;
    }
    public static void delectTitle(int ID,string stuId,string grade,string type)
    {
        SQLHelper dbAccess = new SQLHelper();    //实例化一个SQLHelper类
        string sql = "delete * from WrongTotal where id = " + ID + " and stuId='" + stuId + "' and grade='" + grade + "' and type='" + type + "'";
        dbAccess.doSql(sql);
    }
    public static int delectTitle1(int ID)
    {
        SQLHelper dbAccess = new SQLHelper();    //实例化一个SQLHelper类
        string sql = "delete from WrongTotal where Tid = " + ID;
        return dbAccess.doSql(sql);
    }
    //添加记录到WrongTotal表
    public static void addRadioToWrongTotal(string stuId, int ID, string grade, string type)
    {
        bool rowNum;    //执行sql语句，返回查询到的结果集
        SQLHelper dbAccess1 = new SQLHelper();    //实例化一个SQLHelper类
        string sql1 = "select * from WrongTotal where stuId  = '" + stuId + "' and id = " + ID + " and type='" + type + "'";
        rowNum = dbAccess1.doSql2(sql1);
        if (rowNum.Equals(false))
        {
            string sql2 = "INSERT INTO WrongTotal (stuId ,id ,state ,num , grade , type) VALUES ('" + stuId + "','" + ID + "','1','1','" + grade + "','" + type + "')";
            dbAccess1.doSql(sql2);
        }
        else
        {
            string sql3 = "update WrongTotal set num = num + 1 where stuId ='" + stuId + "' and id = " + ID + " and type='" + type + "'";
            dbAccess1.doSql(sql3);
        }     
    }
    //得到单选题每个错题的数目（从数据库中读一个变量用Dataset）
    public static int WrongRadionum(string stuId, int id, string grade, string type)
    {
        bool rowNum;    //执行sql语句，返回查询到的结果集
        SQLHelper dbAccess = new SQLHelper();    //实例化一个SQLHelper类
        string sql = "select num from WrongTotal where stuId='" + stuId + "' and id=" + id + " and type='" + type + "'and grade='" + grade + "' ";
        rowNum = dbAccess.doSql2(sql);
        if (rowNum.Equals(false))
        {
            return 0;
        }
        else
        {
            DataSet ds = new DataSet();
            ds = dbAccess.doExcuteForDataset(sql, null, CommandType.Text);
            return Convert.ToInt32(ds.Tables[0].Rows[0]["num"]);
        }
    }
}

