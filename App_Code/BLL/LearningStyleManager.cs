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
///LearningStyleManager 的摘要说明
/// </summary>
public class LearningStyleManager
{
	public LearningStyleManager()
	{
		//
		//TODO: 在此处添加构造函数逻辑
		//

    }
         /// <summary>
        /// 从数据库中获取单选题记录
        /// </summary>
        public static LearningStyle GetRadio(int Id)
        {

            SQLHelper dbAccess = new SQLHelper();		//实例化一个SQLHelper类
            string sql = "Select * from [LearningStyle] where Id = @Id";
            SqlParameter[] para = { new SqlParameter("@Id", Id) };   //利用参数para进行动态定义
            SqlDataReader dr = dbAccess.GetDRWithPara(sql, para);	   //获取查询数据流
            //根据查询得到的数据，对成员赋值
            //数据流中是否有数据
            if (dr.Read())
            {
                LearningStyle r = new LearningStyle();
                r.Id = int.Parse(dr["Id"].ToString());
                r.question = dr["question"].ToString();
                r.A = dr["A"].ToString();
                r.B = dr["B"].ToString();
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

        //通过RadioButtonList控件显示选择题题目
        public static void ShowQuestionRadio(LearningStyle r, RadioButtonList rdoList, Label lbl)
        {
            rdoList.Items[0].Text = "A." + r.A;
            rdoList.Items[1].Text = "B." + r.B;
            rdoList.Items[0].Value = "A";
            rdoList.Items[1].Value = "B";
            lbl.Text = r.question;
        }
	
}
