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
using System.Data.SqlClient;
using SelfAdaptivePlatform.Model;
using SelfAdaptivePlatform.DAL;

/// <summary>
///BreakingPointManager 的摘要说明
/// </summary>
public class BreakingPointManager
{
	public BreakingPointManager()
	{
		//
		//TODO: 在此处添加构造函数逻辑
		//
	}
    /// <summary>
    /// 向数据库添加一个用户断点记录
    /// </summary>
    public static int AddBreakingPointRadio(BreakingPointRadio ABreakingPoint)
    {
        SQLHelper dbAccess = new SQLHelper();		//实例化一个SQLHelp类
        string sql = "Insert Into [BreakingPointRadio] Values("     //sql字符串,要向数据库中插入 字符串、日期，其两边是需要加上单引号的
            + "'" + ABreakingPoint.stuId + "',"
            + "'" + ABreakingPoint.learningLevel + "',"
            + "'" + ABreakingPoint.createTime + "',"
            + ABreakingPoint.r1 + ","
            + "'" + ABreakingPoint.ra1 + "',"
            + ABreakingPoint.r2+ ","
            + "'" + ABreakingPoint.ra2+ "',"
            + ABreakingPoint.r3 + ","
            + "'" + ABreakingPoint.ra3 + "',"
            + ABreakingPoint.r4 + ","
            + "'" + ABreakingPoint.ra4 + "',"
            + ABreakingPoint.r5 + ","
            + "'"+ ABreakingPoint.ra5 + "')";

        return dbAccess.doSql(sql);	//利用SQLHelp类的doSql方法增加用户        
    }

    public static int AddBreakingPointJudge(BreakingPointJudge ABreakingPoint)
    {
        SQLHelper dbAccess = new SQLHelper();		//实例化一个SQLHelp类
        string sql = "Insert Into [BreakingPointJudge] Values("
            + "'" + ABreakingPoint.stuId + "',"
            + "'" + ABreakingPoint.learningLevel + "',"
            + "'" + ABreakingPoint.createTime + "',"
            + ABreakingPoint.j1 + ","
            + "'" + ABreakingPoint.ja1 + "',"
            + ABreakingPoint.j2+ ","
            + "'" + ABreakingPoint.ja2+ "',"
            + ABreakingPoint.j3 + ","
            + "'" + ABreakingPoint.ja3 + "',"
            + ABreakingPoint.j4 + ","
            + "'"+ ABreakingPoint.ja4 + "')";

        return dbAccess.doSql(sql);	//利用SQLHelp类的doSql方法增加用户        
    }

    public static int AddBreakingPointBlank(BreakingPointBlank ABreakingPoint)
    {
        SQLHelper dbAccess = new SQLHelper();		//实例化一个SQLHelp类
        string sql = "Insert Into [BreakingPointBlank] Values("
            + "'" + ABreakingPoint.stuId + "',"
            + "'" + ABreakingPoint.learningLevel + "',"
            + "'" + ABreakingPoint.createTime + "',"
            + ABreakingPoint.b1 + ","
            + "'" + ABreakingPoint.ba1 + "',"
            + ABreakingPoint.b2+ ","
            + "'" + ABreakingPoint.ba2+ "',"
            + ABreakingPoint.b3 + ","
            + "'"+ ABreakingPoint.ba3 + "')";

        return dbAccess.doSql(sql);	//利用SQLHelp类的doSql方法增加用户        
    }

    public static int AddBreakingPointDesign(BreakingPointDesign ABreakingPoint)
    {
        SQLHelper dbAccess = new SQLHelper();		//实例化一个SQLHelp类
        string sql = "Insert Into [BreakingPointDesign] Values("
            + "'" + ABreakingPoint.stuId + "',"
            + "'" + ABreakingPoint.learningLevel + "',"
            + "'" + ABreakingPoint.createTime + "',"
            +  ABreakingPoint.d1 + ")";

        return dbAccess.doSql(sql);	//利用SQLHelp类的doSql方法增加用户        
    }

    /// <summary>
    /// 判断是否存在该用户的断点记录，存在返回true，不存在就返回false
    /// </summary>
    public static bool StudentRegistCheck(string tblname, string stuId)
    {
        SQLHelper dbAccess = new SQLHelper();    //实例化一个SQLHelper类
        string sql = "select * from ["+ tblname +"] where stuId=@stuId";
        SqlParameter[] para = { new SqlParameter("@stuId", stuId) };
        //Command命令
        SqlDataReader dr = dbAccess.GetDRWithPara(sql, para);
        if (dr.Read())
        { 
            dr.Close();
            return true;
        }
        else
        {
            dr.Close();
            return false;
        }
 
    }


    /// <summary>
    /// 显示“确定”，点击以后就转到预设网址的提示框
    /// </summary>
    /// <param name="_Msg">提示信息</param>
    /// <param name="URL">“确定”以后要转到预设网址</param>
    /// <returns>提示框JS</returns>
    public static void MsgBox(string strMsg, string URL)
    {
        string StrScript;
        StrScript = ("<script language=javascript>");
        StrScript += ("alert('" + strMsg + "');");
        StrScript += ("window.location='" + URL + "';");
        StrScript += ("</script>");
        System.Web.HttpContext.Current.Response.Write(StrScript);
    }


    /// <summary>
    /// 向数据库读取用户断点记录
    /// </summary>
    public static BreakingPointRadio LoadBreakingPointRadio(string stuId)
    {
        if (BreakingPointManager.StudentRegistCheck("BreakingPointRadio",stuId) == false)
        {
            BreakingPointRadio bp = new BreakingPointRadio();
            return bp;
        }
        else
        {
            SQLHelper dbAccess = new SQLHelper();
            string sql = "select * from [BreakingPointRadio] where stuId='" + stuId + "' order by createTime desc";
            DataSet ds = dbAccess.doExcuteForDataset(sql, null, CommandType.Text);  //利用SQLHelper类的doExcuteForDataset方法查询指定表的数据
            BreakingPointRadio bp = new BreakingPointRadio();
            bp.stuId = ds.Tables[0].Rows[0].ItemArray[0].ToString();
            bp.learningLevel = ds.Tables[0].Rows[0].ItemArray[1].ToString();
            bp.createTime = DateTime.Parse(ds.Tables[0].Rows[0].ItemArray[2].ToString());
            bp.r1 = int.Parse(ds.Tables[0].Rows[0].ItemArray[3].ToString());
            bp.ra1 = ds.Tables[0].Rows[0].ItemArray[4].ToString();
            bp.r2 = int.Parse(ds.Tables[0].Rows[0].ItemArray[5].ToString());
            bp.ra2 = ds.Tables[0].Rows[0].ItemArray[6].ToString();
            bp.r3 = int.Parse(ds.Tables[0].Rows[0].ItemArray[7].ToString());
            bp.ra3 = ds.Tables[0].Rows[0].ItemArray[8].ToString();
            bp.r4 = int.Parse(ds.Tables[0].Rows[0].ItemArray[9].ToString());
            bp.ra4 = ds.Tables[0].Rows[0].ItemArray[10].ToString();
            bp.r5 = int.Parse(ds.Tables[0].Rows[0].ItemArray[11].ToString());
            bp.ra5 = ds.Tables[0].Rows[0].ItemArray[12].ToString();
            return bp;
        }
    }

    public static BreakingPointJudge LoadBreakingPointJudge(string stuId)
    {
        if (BreakingPointManager.StudentRegistCheck("BreakingPointJudge",stuId) == false)
        {
            BreakingPointJudge bp = new BreakingPointJudge();
            return bp;
        }
        else
        {
            SQLHelper dbAccess = new SQLHelper();
            string sql = "select * from [BreakingPointJudge] where stuId='" + stuId + "' order by createTime desc";
            DataSet ds = dbAccess.doExcuteForDataset(sql, null, CommandType.Text);  //利用SQLHelper类的doExcuteForDataset方法查询指定表的数据
            BreakingPointJudge bp = new BreakingPointJudge();
            bp.stuId = ds.Tables[0].Rows[0].ItemArray[0].ToString();
            bp.learningLevel = ds.Tables[0].Rows[0].ItemArray[1].ToString();
            bp.createTime = DateTime.Parse(ds.Tables[0].Rows[0].ItemArray[2].ToString());
            bp.j1 = int.Parse(ds.Tables[0].Rows[0].ItemArray[3].ToString());
            bp.ja1 = ds.Tables[0].Rows[0].ItemArray[4].ToString();
            bp.j2 = int.Parse(ds.Tables[0].Rows[0].ItemArray[5].ToString());
            bp.ja2 = ds.Tables[0].Rows[0].ItemArray[6].ToString();
            bp.j3 = int.Parse(ds.Tables[0].Rows[0].ItemArray[7].ToString());
            bp.ja3 = ds.Tables[0].Rows[0].ItemArray[8].ToString();
            bp.j4 = int.Parse(ds.Tables[0].Rows[0].ItemArray[9].ToString());
            bp.ja4 = ds.Tables[0].Rows[0].ItemArray[10].ToString();
            return bp;
        }
    } 

    public static BreakingPointBlank LoadBreakingPointBlank(string stuId)
    {
        if (BreakingPointManager.StudentRegistCheck("BreakingPointBlank",stuId) == false)
        {
            BreakingPointBlank bp = new BreakingPointBlank();
            return bp;
        }
        else
        {
            SQLHelper dbAccess = new SQLHelper();
            string sql = "select * from [BreakingPointBlank] where stuId='" + stuId + "' order by createTime desc";
            DataSet ds = dbAccess.doExcuteForDataset(sql, null, CommandType.Text);  //利用SQLHelper类的doExcuteForDataset方法查询指定表的数据
            BreakingPointBlank bp = new BreakingPointBlank();
            bp.stuId = ds.Tables[0].Rows[0].ItemArray[0].ToString();
            bp.learningLevel = ds.Tables[0].Rows[0].ItemArray[1].ToString();
            bp.createTime = DateTime.Parse(ds.Tables[0].Rows[0].ItemArray[2].ToString());
            bp.b1 = int.Parse(ds.Tables[0].Rows[0].ItemArray[3].ToString());
            bp.ba1 = ds.Tables[0].Rows[0].ItemArray[4].ToString();
            bp.b2 = int.Parse(ds.Tables[0].Rows[0].ItemArray[5].ToString());
            bp.ba2 = ds.Tables[0].Rows[0].ItemArray[6].ToString();
            bp.b3 = int.Parse(ds.Tables[0].Rows[0].ItemArray[7].ToString());
            bp.ba3 = ds.Tables[0].Rows[0].ItemArray[8].ToString();

            return bp;
        }
    }

    public static BreakingPointDesign LoadBreakingPointDesign(string stuId)
    {
        if (BreakingPointManager.StudentRegistCheck("BreakingPointDesign",stuId) == false)
        {
            BreakingPointDesign bp = new BreakingPointDesign();
            return bp;
        }
        else
        {
            SQLHelper dbAccess = new SQLHelper();
            string sql = "select * from [BreakingPointDesign] where stuId='" + stuId + "' order by createTime desc";
            DataSet ds = dbAccess.doExcuteForDataset(sql, null, CommandType.Text);  //利用SQLHelper类的doExcuteForDataset方法查询指定表的数据
            BreakingPointDesign bp = new BreakingPointDesign();
            bp.stuId = ds.Tables[0].Rows[0].ItemArray[0].ToString();
            bp.learningLevel = ds.Tables[0].Rows[0].ItemArray[1].ToString();
            bp.createTime = DateTime.Parse(ds.Tables[0].Rows[0].ItemArray[2].ToString());
            bp.d1 = int.Parse(ds.Tables[0].Rows[0].ItemArray[3].ToString());

            return bp;
        }
    }
}