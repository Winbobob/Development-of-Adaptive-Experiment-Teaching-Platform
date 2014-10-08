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
/// Summary description for TeacherInfoManager
/// </summary>
/// 
namespace SelfAdaptivePlatform.BLL
{
    public class TeacherInfoManager
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public TeacherInfoManager()
        {
            //
            // TODO: Add constructor logic here
            //
        }


        /// <summary>
        /// 向数据库更新该用户
        /// </summary>
        public static int UpdateTeacher(TeacherInfo ATeacherInfo)
        {
            SQLHelper dbAccess = new SQLHelper();
            string sql = "Update [TeacherInfo] Set teaId='";
            sql += ATeacherInfo.teaId + "',teaname='";
            sql += ATeacherInfo.teaName + "',email='";
            sql += ATeacherInfo.email + "',photo='";
            sql += ATeacherInfo.photo + "',gender='";
            sql += ATeacherInfo.gender + "',telephone='";
            sql += ATeacherInfo.telephone + "' where teaId = '" + ATeacherInfo.teaId + "'";
            return dbAccess.doSql(sql);
        }

        /// <summary>
        /// 向数据库修改该用户密码
        /// </summary>
        public static int UpdatePsw(TeacherInfo ATeacherInfo)
        {
            SQLHelper dbAccess = new SQLHelper();
            string sql = "Update [TeacherInfo] Set teaId='";
            sql += ATeacherInfo.teaId + "',password='";
            sql += ATeacherInfo.password + "' where teaId = '" + ATeacherInfo.teaId + "'";
            return dbAccess.doSql(sql);
        }


        /**/
        /// <summary>
        /// 
        /// 用户登录验证 成功返回true
        /// </summary>
        public static bool TeacherLoginCheck(TeacherInfo teacherInfo)
        {

            SQLHelper dbAccess = new SQLHelper();
            string sql = "select teaId,password from [TeacherInfo] where TeaId=@TeaId and Password = @Password";
            SqlParameter[] para = { new SqlParameter("@TeaId", teacherInfo.teaId), new SqlParameter("@Password", teacherInfo.password) };
            //Command命令
            SqlDataReader dr = dbAccess.GetDRWithPara(sql, para);

            if (dr.Read())
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

        /// <summary>
        /// 从数据库中获取该位教师信息
        /// </summary>
        public static TeacherInfo Getteachernews(string teaId)
        {

            SQLHelper dbAccess = new SQLHelper();		//实例化一个SQLHelper类
            string sql = "Select * from [TeacherInfo] where TeaId = @TeaId";
            SqlParameter[] para = { new SqlParameter("@TeaId", teaId) };   //利用参数para进行动态定义
            SqlDataReader dr = dbAccess.GetDRWithPara(sql, para);	   //获取查询数据流

            //根据查询得到的数据，对成员赋值
            //数据流中是否有数据
            if (dr.Read())
            {
                TeacherInfo teaNews = new TeacherInfo();
                teaNews.teaId = dr["teaId"].ToString();
                teaNews.teaName = dr["teaName"].ToString();
                teaNews.gender = dr["gender"].ToString();
                teaNews.email = dr["email"].ToString();
                teaNews.photo = dr["photo"].ToString();
                teaNews.password = dr["password"].ToString();
                teaNews.telephone = dr["telephone"].ToString();
                //关闭SqlDataReader对象，此时连接同时关闭
                dr.Close();
                return teaNews;
            }
            else
            {
                dr.Close();
                return null;
            }
        }

        /// <summary>
        /// 从数据库中显示该位教师信息
        /// </summary>
        public static void Showteachernews(TeacherInfo teaNews, Label lblteaId, Label lblteaName, Label lblgender, Label lblphone, Image imgphoto)
        {
            lblteaId.Text = teaNews.teaId;
            lblteaName.Text = teaNews.teaName;
            lblgender.Text = teaNews.gender;
            lblphone.Text = teaNews.telephone;
            imgphoto.ImageUrl = teaNews.photo;

        }

        /// <summary>
        /// 从数据库中显示该位教师信息
        /// </summary>
        public static void Showteachernews2(TeacherInfo teaNews, TextBox txtteaId, TextBox txtteaName, RadioButtonList rdolistgender, TextBox txtemail, Image imgphoto, TextBox txttel)
        {
            txtteaId.Text = teaNews.teaId;
            txtteaName.Text = teaNews.teaName;
            if ( teaNews.gender == "女")
            {
                rdolistgender.Items[1].Selected = true;
            }
            else
            {
                rdolistgender.Items[0].Selected = true;
            }
            txtemail.Text = teaNews.email;
            imgphoto.ImageUrl = teaNews.photo;
            txttel.Text = teaNews.telephone;            
        }


    }
}

