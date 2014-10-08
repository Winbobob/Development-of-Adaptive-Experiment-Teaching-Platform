using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SelfAdaptivePlatform.Model;
using SelfAdaptivePlatform.DAL;
using System.Data.SqlClient;

/// <summary>
///QuestionManager 的摘要说明
///// </summary>
public class QuestionChangeManager
{
	public QuestionChangeManager()
	{
		//
		//TODO: 在此处添加构造函数逻辑
		//
	}
    //删除操作
    public static int DeleteQuestion(string Id,string tablename)
    {
        SQLHelper dbAccess = new SQLHelper();    //实例化一个SQLHelp类
        string sql = "Delete [" + tablename + "] where Id=" + int.Parse(Id);
        return dbAccess.doSql(sql);    //利用SQLHelp类的doSql方法增加用户，执行一条SQL语句，返回受影响的行数   
    }
    //获取选择题数据
    public static RadioHigh GetRadioQuestion(string Id, string tablename)
    {
        SQLHelper dbAccess = new SQLHelper();    //实例化一个SQLHelper类
        string sql = "Select * from [" + tablename + "] where Id = @Id";
        SqlParameter[] para = { new SqlParameter("@Id", Id) };    //利用参数para进行动态定义
        SqlDataReader dr = dbAccess.GetDRWithPara(sql, para);    //获取查询数据流
        //根据查询得到的数据，对成员赋值
        //数据流中是否有数据
        if (dr.Read())
        {
            //声明User对象，将数据流中的值赋给User对象
            RadioHigh question = new RadioHigh();
            question.Id = int.Parse(dr["Id"].ToString());
            question.question = dr["question"].ToString();
            question.A = dr["A"].ToString();
            question.B = dr["B"].ToString();
            question.C = dr["C"].ToString();
            question.D = dr["D"].ToString();
            question.answer = dr["answer"].ToString();
            question.explain = dr["explain"].ToString();
            //关闭SqlDataReader对象，此时连接同时关闭
            dr.Close();
            return question;
        }
        else
        {
            dr.Close();
            return null;
        }
    }
    //获取判断题数据
    public static JudgeHigh GetJudgeQuestion(string Id,string tablename)
    {
        SQLHelper dbAccess = new SQLHelper();    //实例化一个SQLHelper类
        string sql = "Select * from [" + tablename + "] where Id = @Id";
        SqlParameter[] para = { new SqlParameter("@Id", Id) };    //利用参数para进行动态定义
        SqlDataReader dr = dbAccess.GetDRWithPara(sql, para);    //获取查询数据流
        //根据查询得到的数据，对成员赋值
        //数据流中是否有数据
        if (dr.Read())
        {
            //声明User对象，将数据流中的值赋给User对象
            JudgeHigh Question = new JudgeHigh();
            Question.Id = int.Parse(dr["Id"].ToString());
            Question.question = dr["question"].ToString();
            Question.answer = dr["answer"].ToString();
            Question.explain = dr["explain"].ToString();
            Question.suggestion = int.Parse(dr["suggestion"].ToString()); 
            //关闭SqlDataReader对象，此时连接同时关闭
            dr.Close();
            return Question;
        }
        else
        {
            dr.Close();
            return null;
        }
    }
    //获取填空题数据
    public static BlankHigh GetBlankQuestion(string Id, string tablename)
    {
        SQLHelper dbAccess = new SQLHelper();    //实例化一个SQLHelper类
        string sql = "Select * from [" + tablename + "] where Id = @Id";
        SqlParameter[] para = { new SqlParameter("@Id", Id) };    //利用参数para进行动态定义
        SqlDataReader dr = dbAccess.GetDRWithPara(sql, para);    //获取查询数据流
        //根据查询得到的数据，对成员赋值
        //数据流中是否有数据
        if (dr.Read())
        {
            //声明User对象，将数据流中的值赋给User对象
            BlankHigh Question = new BlankHigh();
            Question.Id = int.Parse(dr["Id"].ToString());
            Question.qFront = dr["qFront"].ToString();
            Question.qBack = dr["qBack"].ToString();
            Question.answer = dr["answer"].ToString();
            Question.explain = dr["explain"].ToString();
            Question.suggestion = int.Parse(dr["suggestion"].ToString());
            //关闭SqlDataReader对象，此时连接同时关闭
            dr.Close();
            return Question;
        }
        else
        {
            dr.Close();
            return null;
        }
    }
    //获取设计题数据
    public static DesignHigh GetDesignQuestion(string Id, string tablename)
    {
        SQLHelper dbAccess = new SQLHelper();    //实例化一个SQLHelper类
        string sql = "Select * from [" + tablename + "] where Id = @Id";
        SqlParameter[] para = { new SqlParameter("@Id", Id) };    //利用参数para进行动态定义
        SqlDataReader dr = dbAccess.GetDRWithPara(sql, para);    //获取查询数据流
        //根据查询得到的数据，对成员赋值
        //数据流中是否有数据
        if (dr.Read())
        {
            //声明User对象，将数据流中的值赋给User对象
            DesignHigh Question = new DesignHigh();
            Question.Id = int.Parse(dr["Id"].ToString());
            Question.question = dr["question"].ToString();
            Question.answer = dr["answer"].ToString();
            Question.suggestion = int.Parse(dr["suggestion"].ToString());
            Question.Q1 = dr["Q1"].ToString();
            Question.A1= dr["A1"].ToString();
            Question.B1 = dr["B1"].ToString();
            Question.C1 = dr["C1"].ToString();
            Question.D1 = dr["D1"].ToString();
            Question.answer1 = dr["answer1"].ToString();
            Question.Q2 = dr["Q2"].ToString();
            Question.A2 = dr["A2"].ToString();
            Question.B2 = dr["B2"].ToString();
            Question.C2 = dr["C2"].ToString();
            Question.D2 = dr["D2"].ToString();
            Question.answer2 = dr["answer2"].ToString();
            //关闭SqlDataReader对象，此时连接同时关闭
            dr.Close();
            return Question;
        }
        else
        {
            dr.Close();
            return null;
        }
    }
    //更新选择题数据
    public static int UpdateRadioQuestion(RadioHigh Question, string tablename)
    {
        SQLHelper dbAccess = new SQLHelper();    //实例化一个SQLHelp类
        string sql = "Update [" + tablename + "] Set question='";
        sql += Question.question + "',A='";
        sql += Question.A + "',B='";
        sql += Question.B + "',C='";
        sql += Question.C + "',D='";
        sql += Question.D + "',answer='";
        sql += Question.answer + "',explain='";
        sql += Question.explain + "',suggestion='";
        sql += Question.suggestion + "' where Id=" + Question.Id;
        return dbAccess.doSql(sql);    //利用SQLHelp类的doSql方法增加用户，执行一条SQL语句，返回受影响的行数   
    }
    //更新判断题数据
    public static int UpdateJudgeQuestion(JudgeHigh Question,string tablename)
    {
        SQLHelper dbAccess = new SQLHelper();    //实例化一个SQLHelp类
        string sql = "Update [" + tablename + "] Set question='";
        sql += Question.question + "',answer='";
        sql += Question.answer + "',explain='";
        sql += Question.explain + "',suggestion'";
        sql += Question.suggestion +  "' where Id=" + Question.Id;
        return dbAccess.doSql(sql);    //利用SQLHelp类的doSql方法增加用户，执行一条SQL语句，返回受影响的行数   
    }
    //更新填空题数据
    public static int UpdateBlankQuestion(BlankHigh Question, string tablename)
    {
        SQLHelper dbAccess = new SQLHelper();    //实例化一个SQLHelp类
        string sql = "Update [" + tablename + "] Set qFront='";
        sql += Question.qFront + "',qBack='";
        sql += Question.qBack + "',answer='";
        sql += Question.answer + "',explain='";
        sql += Question.explain +"',suggestion='";
        sql += Question.suggestion + "' where Id=" + Question.Id;
        return dbAccess.doSql(sql);    //利用SQLHelp类的doSql方法增加用户，执行一条SQL语句，返回受影响的行数   
    }
    //更新设计题数据
    public static int UpdateDesignQuestion(DesignHigh Question, string tablename)
    {
        SQLHelper dbAccess = new SQLHelper();    //实例化一个SQLHelp类
        string sql = "Update [" + tablename + "] Set question='";
        sql += Question.question + "',answer='";
        sql += Question.answer + "',suggestion='";
        sql += Question.suggestion + "',Q1='";
        sql += Question.Q1 + "',A1='";
        sql += Question.A1+ "',B1='";
        sql += Question.B1 + "',C1='";
        sql += Question.C1 + "',D1='";
        sql += Question.D1 + "',answer1='";
        sql += Question.answer1 + "',Q2='";
        sql += Question.Q2 + "',A2='";
        sql += Question.A2+ "',B2='";
        sql += Question.B2 + "',C2='";
        sql += Question.C2 + "',D2='";
        sql += Question.D2 + "',answer2='";
        sql += Question.answer2 + "' where Id=" + Question.Id;
        return dbAccess.doSql(sql);    //利用SQLHelp类的doSql方法增加用户，执行一条SQL语句，返回受影响的行数   
    }

    //添加选择题数据
    public static int AddRadioQuestion(RadioHigh Question, string tablename)
    {
        SQLHelper dbAccess = new SQLHelper();    //实例化一个SQLHelp类
        string sql = "Insert Into [" + tablename + "] Values("
            + "'" + Question.question + "',"
            + "'" + Question.A + "',"
            + "'" + Question.B + "',"
            + "'" + Question.C + "',"
            + "'" + Question.D + "',"
            + "'" + Question.answer + "',"
            + "'" + Question.explain + "',"
            + "'" + Question.suggestion + "')";
        return dbAccess.doSql(sql);    //利用SQLHelp类的doSql方法增加用户，执行一条SQL语句，返回受影响的行数   
    }

    //添加判断题数据
    public static int AddJudgeQuestion (JudgeHigh Question,string tablename)
    {
        SQLHelper dbAccess = new SQLHelper();    //实例化一个SQLHelp类
        string sql = "Insert Into [" + tablename + "] Values("
            + "'" + Question.question + "',"
            + "'" + Question.answer + "',"
            + "'" + Question.explain + "',"
            + "'" + Question.suggestion + "')";
        return dbAccess.doSql(sql);    //利用SQLHelp类的doSql方法增加用户，执行一条SQL语句，返回受影响的行数   
    }

    //添加填空题数据
    public static int AddBlankQuestion(BlankHigh Question, string tablename)
    {
        SQLHelper dbAccess = new SQLHelper();    //实例化一个SQLHelp类
        string sql = "Insert Into [" + tablename + "] Values("
            + "'" + Question.qFront + "',"
            + "'" + Question.qBack + "',"
            + "'" + Question.answer + "',"
            + "'" + Question.explain + "',"
            + "'" + Question.suggestion+ "')";
        return dbAccess.doSql(sql);    //利用SQLHelp类的doSql方法增加用户，执行一条SQL语句，返回受影响的行数   
    }
    //添加设计题数据
    public static int AddDesignQuestion(DesignHigh Question, string tablename)
    {
        SQLHelper dbAccess = new SQLHelper();    //实例化一个SQLHelp类
        string sql = "Insert Into [" + tablename + "] Values("
            + "'" + Question.question + "',"
            + "'" + Question.answer + "',"
            + "'" + Question.suggestion + "',"
            + "'" + Question.Q1 + "',"
            + "'" + Question.A1 + "',"
            + "'" + Question.B1 + "',"
            + "'" + Question.C1 + "',"
            + "'" + Question.D1 + "',"
            + "'" + Question.answer1 + "',"
           + "'" + Question.Q2 + "',"
            + "'" + Question.A2 + "',"
            + "'" + Question.B2 + "',"
            + "'" + Question.C2 + "',"
            + "'" + Question.D2 + "',"
            + "'" + Question.answer2 + "')";
        return dbAccess.doSql(sql);    //利用SQLHelp类的doSql方法增加用户，执行一条SQL语句，返回受影响的行数   
    }
}