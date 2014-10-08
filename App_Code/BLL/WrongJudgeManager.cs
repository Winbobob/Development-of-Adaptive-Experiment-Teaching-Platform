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
/// Summary description for WrongJudgeManager
/// </summary>
public class WrongJudgeManager
{
	public WrongJudgeManager()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public static DataSet LoadPart(string cTable, string grade, string stuID)
    {
        SQLHelper dbAccess = new SQLHelper();		//实例化一个SQLHelper类
        string sql = "Select question,answer,num,Tid,[" + cTable + "].id from WrongTotal," + cTable + " where  " + cTable + ".Id = WrongTotal.Id and stuID='" + stuID + "' and grade='" + grade + "' and type='WrongJudge'order by num desc";
        DataSet ds = dbAccess.doExcuteForDataset(sql, null, CommandType.Text);//利用SQLHelper类的doExcuteForDataset方法查询最近的n条发言
        return ds;

    }
    public static string Wrongnum(string stuId, string grade)
    {
        SQLHelper dbAccess = new SQLHelper();	//实例化一个SQLHelper类
        string sql = "select count(*) from WrongTotal where stuId='" + stuId + "' and type='WrongJudge' and grade='" + grade + "' ";
        return dbAccess.doSqlForFirst(sql);
    }

    public static int delectTitle1(int ID)
    {
        SQLHelper dbAccess = new SQLHelper();		//实例化一个SQLHelper类
        string sql = "delete from WrongTotal where Tid = " + ID;
        return dbAccess.doSql(sql);
    }

}
