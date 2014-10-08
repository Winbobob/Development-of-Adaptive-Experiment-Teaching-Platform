using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SelfAdaptivePlatform.Model;
using SelfAdaptivePlatform.DAL;
using System.Data;

/// <summary>
///Manage 的摘要说明
/// </summary>
public class Manage
{
	public Manage()
	{
		//
		//TODO: 在此处添加构造函数逻辑
		//
	} 
    public static DataSet ShowData(string tablename)
    {
        SQLHelper dbAccess = new SQLHelper();    //实例化一个SQLHelper类
        //string sql = "Select * from [" + tablename + "]";
        string sql = string.Format("Select * from [{0}]", tablename);
        DataSet ds = dbAccess.doExcuteForDataset(sql, null, CommandType.Text);    //利用SQLHelper类的doExcuteForDataset方法查询指定表的数据
        return ds;
    }
    public static DataSet ShowData1(string tablename)
    {
        SQLHelper dbAccess = new SQLHelper();    //实例化一个SQLHelper类
        //string sql = "Select * from [" + tablename + "]";
        string sql = string.Format("Select stuId,mid,high,designMid,designHigh,totalScore from [{0}]", tablename);
        DataSet ds = dbAccess.doExcuteForDataset(sql, null, CommandType.Text);    //利用SQLHelper类的doExcuteForDataset方法查询指定表的数据
        return ds;
    }
    public static DataSet ShowData2(string tablename,string stuId)
    {
        SQLHelper dbAccess = new SQLHelper();    //实例化一个SQLHelper类
        //string sql = "Select * from [" + tablename + "]";
        string sql = string.Format("Select * from [{0}] where stuId ={1}", tablename,stuId);
        DataSet ds = dbAccess.doExcuteForDataset(sql, null, CommandType.Text);  //利用SQLHelper类的doExcuteForDataset方法查询指定表的数据
        return ds;
    }

    public static DataSet ShowData3()
    {
        SQLHelper dbAccess = new SQLHelper();    //实例化一个SQLHelper类
        //string sql = "Select * from [DesignUpload]";
        string sql = string.Format("Select stuId,filename,createTime,urlupload from [DesignUpload] where learningLevel = 'low'");
        DataSet ds = dbAccess.doExcuteForDataset(sql, null, CommandType.Text);  //利用SQLHelper类的doExcuteForDataset方法查询指定表的数据
        return ds;
    }
    public static DataSet ShowData4()
    {
        SQLHelper dbAccess = new SQLHelper();    //实例化一个SQLHelper类
        //string sql = "Select * from [DesignUpload]";
        string sql = string.Format("Select stuId,filename,createTime,urlupload from [DesignUpload] where learningLevel = 'mid'");
        DataSet ds = dbAccess.doExcuteForDataset(sql, null, CommandType.Text);    //利用SQLHelper类的doExcuteForDataset方法查询指定表的数据
        return ds;
    }
    public static DataSet ShowData5()
    {
        SQLHelper dbAccess = new SQLHelper();    //实例化一个SQLHelper类
        //string sql = "Select * from [DesignUpload]";
        string sql = string.Format("Select stuId,filename,createTime,urlupload from [DesignUpload] where learningLevel = 'high'");
        DataSet ds = dbAccess.doExcuteForDataset(sql, null, CommandType.Text);    //利用SQLHelper类的doExcuteForDataset方法查询指定表的数据
        return ds;
    }
}