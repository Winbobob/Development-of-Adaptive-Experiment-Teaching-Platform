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
///ClassUnitManager 的摘要说明
/// </summary>
public class ClassUnitManager
{
	public ClassUnitManager()
	{
		//
		//TODO: 在此处添加构造函数逻辑
		//
	}
    /// <summary>
    /// 向数据库更新数据
    /// </summary>
    public static int UpdateStudyingInform(ClassUnit AClassUnit)
    {
        SQLHelper dbAccess = new SQLHelper();
        string sql = "Update [ClassUnit] Set totalScore=";
        sql += AClassUnit.totalScore + " where stuId = '" + AClassUnit.stuId + "'";
        return dbAccess.doSql(sql);
    }
    public static int UpdateStudyingInform2(ClassUnit AClassUnit,string j)
    {
        SQLHelper dbAccess = new SQLHelper();
        if (j == "low")
        {
            string sql = "Update [ClassUnit] Set designLow=";
            sql += AClassUnit.designLow + " where stuId = '" + AClassUnit.stuId + "'";
            return dbAccess.doSql(sql);
        }
        else if (j == "mid")
        {
            string sql = "Update [ClassUnit] Set designMid=";
            sql += AClassUnit.designMid + " where stuId = '" + AClassUnit.stuId + "'";
            return dbAccess.doSql(sql);
        }
        else
        {
            string sql = "Update [ClassUnit] Set designHigh=";
            sql += AClassUnit.designHigh + " where stuId = '" + AClassUnit.stuId + "'";
            return dbAccess.doSql(sql);
        }
        
    }
    /// <summary>
    /// 从数据库中获取数据
    /// </summary>
    public static ClassUnit GetStudyingInform(string stuId)
    {

        SQLHelper dbAccess = new SQLHelper();		//实例化一个SQLHelper类
        string sql = "Select * from [ClassUnit] where stuId = @stuId";
        SqlParameter[] para = { new SqlParameter("@stuId", stuId) };   //利用参数para进行动态定义
        SqlDataReader dr = dbAccess.GetDRWithPara(sql, para);	   //获取查询数据流

        //根据查询得到的数据，对成员赋值
        //数据流中是否有数据
        if (dr.Read())
        {
            ClassUnit stuNews = new ClassUnit();
            stuNews.stuId = dr["stuId"].ToString();
            stuNews.pretest = int.Parse(dr["pretest"].ToString());
            stuNews.low = int.Parse(dr["low"].ToString());
            stuNews.mid = int.Parse(dr["mid"].ToString());
            stuNews.high = int.Parse(dr["high"].ToString());
            stuNews.designLow = int.Parse(dr["designlow"].ToString());
            stuNews.designMid = int.Parse(dr["designmid"].ToString());
            stuNews.designHigh = int.Parse(dr["designhigh"].ToString());
            stuNews.totalScore = int.Parse(dr["totalScore"].ToString());
            
            //关闭SqlDataReader对象，此时连接同时关闭
            dr.Close();
            return stuNews;
        }
        else
        {
            dr.Close();
            return null;
        }
    }

    //获取最高分
    public static string GetStudyingInformpre()
    {
        SQLHelper dbAccess = new SQLHelper();		//实例化一个SQLHelper类
        string sql = "Select max(pretest)from [ClassUnit]";
        return dbAccess.doSqlForFirst(sql);
    }
    public static string GetStudyingInformlow()
    {
        SQLHelper dbAccess = new SQLHelper();		//实例化一个SQLHelper类
        string sql = "Select max(low)from [ClassUnit]";
        return dbAccess.doSqlForFirst(sql);
    }
    public static string GetStudyingInformmid()
    {
        SQLHelper dbAccess = new SQLHelper();		//实例化一个SQLHelper类
        string sql = "Select max(mid)from [ClassUnit]";
        return dbAccess.doSqlForFirst(sql);
    }
    public static string GetStudyingInformhigh()
    {
        SQLHelper dbAccess = new SQLHelper();		//实例化一个SQLHelper类
        string sql = "Select max(high)from [ClassUnit]";
        return dbAccess.doSqlForFirst(sql);
    }
    public static string GetStudyingInformdelow()
    {
        SQLHelper dbAccess = new SQLHelper();		//实例化一个SQLHelper类
        string sql = "Select max(designlow)from [ClassUnit]";
        return dbAccess.doSqlForFirst(sql);
    }
    public static string GetStudyingInformdemid()
    {
        SQLHelper dbAccess = new SQLHelper();		//实例化一个SQLHelper类
        string sql = "Select max(designmid)from [ClassUnit]";
        return dbAccess.doSqlForFirst(sql);
    }
    public static string GetStudyingInformdehigh()
    {
        SQLHelper dbAccess = new SQLHelper();		//实例化一个SQLHelper类
        string sql = "Select max(designhigh)from [ClassUnit]";
        return dbAccess.doSqlForFirst(sql);
    }
    public static string GetStudyingInformtotal()
    {
        SQLHelper dbAccess = new SQLHelper();		//实例化一个SQLHelper类
        string sql = "Select max(totalscore)from [ClassUnit]";
        return dbAccess.doSqlForFirst(sql);
    }
}
