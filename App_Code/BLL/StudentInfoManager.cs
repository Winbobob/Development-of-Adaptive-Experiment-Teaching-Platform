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
/// Summary description for StudentInfoManager
/// </summary>
namespace SelfAdaptivePlatform.BLL
{
    public class StudentInfoManager
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public StudentInfoManager()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        /// <summary>
        /// 向数据库更新该用户
        /// </summary>
        public static int UpdateStudent(StudentInfo AStudentInfo)
        {
            SQLHelper dbAccess = new SQLHelper();
            string sql = "Update [StudentInfo] Set stuId='";
            sql += AStudentInfo.stuId + "',stuname='";
            sql += AStudentInfo.stuName + "',classname='";
            sql += AStudentInfo.className + "',email='";
            sql += AStudentInfo.email + "',photo='";
            sql += AStudentInfo.photo + "',gender='";
            sql += AStudentInfo.gender + "',birthday='";
            sql += AStudentInfo.birthday + "',telephone='";
            sql += AStudentInfo.telephone + "',learningStyle='";
            sql += AStudentInfo.learningStyle + "' where stuId = '" + AStudentInfo.stuId + "'";
            return dbAccess.doSql(sql);
        }
        public static int UpdateStudent2(StudentInfo AStudentInfo)
        {
            SQLHelper dbAccess = new SQLHelper();
            string sql = "Update [StudentInfo] Set stuId='";
            sql += AStudentInfo.stuId + "',learningStyle='";
            sql += AStudentInfo.learningStyle + "',password='";
            sql += AStudentInfo.password + "' where stuId = '" + AStudentInfo.stuId + "'";
            return dbAccess.doSql(sql);
        }
        /// <summary>
        /// 向数据库修改该用户密码
        /// </summary>
        public static int UpdatePsw(StudentInfo AStudentInfo)
        {
            SQLHelper dbAccess = new SQLHelper();
            string sql = "Update [StudentInfo] Set stuId='";
            sql += AStudentInfo.stuId + "',password='";
            sql += AStudentInfo.password + "' where stuId = '" + AStudentInfo.stuId + "'";
            return dbAccess.doSql(sql);
        }
        /// <summary>
        /// 向数据库添加一个用户
        /// </summary>
        public static int AddStudent(StudentInfo AstudentInfo)
        {
            SQLHelper dbAccess = new SQLHelper();		//实例化一个SQLHelp类

            string sql = "Insert Into [StudentInfo] Values( "
                + "'" + AstudentInfo.stuId + "',"
                + "'" + AstudentInfo.stuName + "',"
                + "'" + AstudentInfo.password + "',"
                + "'" + AstudentInfo.learningStyle + "',"
                + "'" + AstudentInfo.className + "',"
                + "'" + AstudentInfo.photo + "',"
                + "'" + AstudentInfo.gender + "',"
                + "'" + AstudentInfo.birthday + "',"
                + "'" + AstudentInfo.email + "',"
                + "'" + AstudentInfo.telephone + "')";

            return dbAccess.doSql(sql);	//利用SQLHelp类的doSql方法增加用户        
        }
        /// <summary>
        /// 用户登录验证 成功返回true
        /// </summary>
        public static bool StudentLoginCheck(StudentInfo studentInfo)
        {
            
            SQLHelper dbAccess = new SQLHelper();
            string sql = "select stuId,password from [StudentInfo] where stuId=@stuId and password = @password";
            SqlParameter[] para = { new SqlParameter("@stuId", studentInfo.stuId), new SqlParameter("@password",studentInfo.password) };
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
        /// 用户注册时的账名验证，不存在重名返回true，存在重名返回false
        /// </summary>
        public static bool StudentRegistCheck(string stuid)
        {
            SQLHelper dbAccess = new SQLHelper();    //实例化一个SQLHelper类
            string sql = "select * from [StudentInfo] where stuId=@stuId";
            SqlParameter[] para = { new SqlParameter("@stuId",stuid) };
            //Command命令
            SqlDataReader dr = dbAccess.GetDRWithPara(sql, para);

            //DataSet ds = dbAccess.doExcuteForDataset(sql, para,CommandType.Text);

            if (dr.Read())  //ds.Tables[0].Rows.Count != 0
            {
                //关闭SqlDataReader对象，此时连接同时关闭
                dr.Close();
                return false;
            }
            else
            {
                dr.Close();
                return true;
            }
        }
        /// <summary>
        /// 从数据库中获取该位学生信息
        /// </summary>
        public static StudentInfo Getstudentnews(string stuId)
        {

            SQLHelper dbAccess = new SQLHelper();		//实例化一个SQLHelper类
            string sql = "Select * from [StudentInfo] where stuId = @stuId";
            SqlParameter[] para = { new SqlParameter("@stuId", stuId) };   //利用参数para进行动态定义
            SqlDataReader dr = dbAccess.GetDRWithPara(sql, para);	   //获取查询数据流

            //根据查询得到的数据，对成员赋值
            //数据流中是否有数据
            if (dr.Read())
            {
                StudentInfo stuNews = new StudentInfo();
                stuNews.stuId = dr["stuId"].ToString();
                stuNews.stuName = dr["stuName"].ToString();
                stuNews.gender = dr["gender"].ToString();
                stuNews.email = dr["email"].ToString();
                stuNews.photo = dr["photo"].ToString();
                stuNews.password = dr["password"].ToString();
                stuNews.telephone = dr["telephone"].ToString();
                stuNews.className = dr["className"].ToString();
                stuNews.birthday = DateTime.Parse(dr["birthday"].ToString());
                stuNews.learningStyle = dr["learningStyle"].ToString();
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
        /// <summary>
        /// 显示该位学生信息
        /// </summary>
        public static void Showstudentnews(StudentInfo stuNews, Label lblstuId, Label lblstuName, Label lblclassName, Label lblgender, Image imgphoto)
        {
            lblstuId.Text = stuNews.stuId;
            lblstuName.Text = stuNews.stuName;
            lblgender.Text = stuNews.gender;
            lblclassName.Text = stuNews.className;
            imgphoto.ImageUrl = stuNews.photo;

        }
        public static void Showstudentnews1(StudentInfo stuNews, Label lblstuName, Label lblstyle,Image imgphoto)
        {
            lblstuName.Text = stuNews.stuName;
            lblstyle.Text = stuNews.learningStyle;
            imgphoto.ImageUrl = stuNews.photo;
        }
        /// <summary>
        /// 显示该位学生信息
        /// </summary>
        public static void Showstudentnews2(StudentInfo stuNews, TextBox txtstuId, TextBox txtstuName, TextBox txtclassName, RadioButtonList rdolistgender, TextBox txtemail, Image imgphoto, TextBox txttel, TextBox txtbirthday, TextBox txtlearningStyle)
        {
            txtstuId.Text = stuNews.stuId;
            txtstuName.Text = stuNews.stuName;
            txtclassName.Text = stuNews.className;
            txtemail.Text = stuNews.email;
            imgphoto.ImageUrl =stuNews.photo;
            txttel.Text = stuNews.telephone;
            txtbirthday.Text = Convert.ToString(stuNews.birthday);
            txtlearningStyle.Text = stuNews.learningStyle;
            if (stuNews.gender == "女")
            {
                rdolistgender.Items[1].Selected = true;
            }
            else
            {
                rdolistgender.Items[0].Selected = true;

            }
        }
        //获取所有学生用户信息
        public static DataSet ShowData()
        {
            SQLHelper dbAccess = new SQLHelper();    //实例化一个SQLHelper类
            //string sql = "Select * from [" + tablename + "]";
            string sql = string.Format("Select stuId,stuName,photo,className,gender,email,learningStyle from [StudentInfo]");
            DataSet ds = dbAccess.doExcuteForDataset(sql, null, CommandType.Text);    //利用SQLHelper类的doExcuteForDataset方法查询指定表的数据
            return ds;
        }
        //获取所有学生总数
        public static string num()
        {
            SQLHelper dbAccess = new SQLHelper();	//实例化一个SQLHelper类
            string sql = "select count(*) from [StudentInfo]";
            return dbAccess.doSqlForFirst(sql);
        }
    }
}
