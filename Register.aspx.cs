using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using SelfAdaptivePlatform.Model;
using SelfAdaptivePlatform.BLL;
using System.Xml;

public partial class Register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        txtstuId.Focus();
    }
    //点击注册按钮事件
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        //判断用户学号是否占有
        if (StudentInfoManager.StudentRegistCheck(txtstuId.Text) == false)
        {
            //Response.Write("<script type = 'text/javascript'> alert('该学号已占用！'); </script>");
            RegisterClientScriptBlock("", "<script>alert('该学号已占用！')</script>"); 
            return;
        }
        //判断是否选择性别
        if (RadioButton1.Checked == false && RadioButton2.Checked == false)
        {
            //Response.Write("<script type = 'text/javascript'> alert('您未选择性别！'); </script>");
            RegisterClientScriptBlock("", "<script>alert('您未选择性别！')</script>"); 
            return;
        }
        //检测用户输入的密码是否一致
        if (txtpsw.Text != txtpsw1.Text)
        {
            //Response.Write("<script type = 'text/javascript'> alert('您输入的密码不一致！'); </script>");
            RegisterClientScriptBlock("", "<script>alert('您输入的密码不一致！')</script>"); 
            txtpsw.Focus();
            return;
        }
        string stuId = txtstuId.Text;
        string stuName = txtstuName.Text;
        string password = txtpsw.Text;
        string photo = "~/load/教育技术头像.PNG";    //系统自动上传一张固定头像，用户可在后期手动更改
        string gender = "男";
        if (RadioButton2.Checked == true)
        {
            gender = "女";
        }
        string className = txtclassName.Text;
        string email = txtemail.Text;
        string telephone = txttel.Text;
        DateTime birthday = Convert.ToDateTime("2012-1-1");    //系统暂定生日为2012-1-1，用户可在后期手动更改
        string learningStyle = "";
        StudentInfo studentInfo = new StudentInfo(stuId, stuName, password, learningStyle, photo, gender, className, telephone, email, birthday);
        StudentInfoManager.AddStudent(studentInfo);    //将用户信息记录到数据库
        TestLowManager.UpdateStudyingScore2(stuId);    //在用户成绩表增加该用户最初记录
        Session["stuId"] = txtstuId.Text;
        Session["password"] = txtpsw.Text;
        //生成以学号为文件名的XML文件
        System.Xml.XmlTextWriter xmlWriter = new XmlTextWriter(Server.MapPath("./XML/" + Session["stuId"].ToString() + ".xml"), System.Text.Encoding.UTF8);
        xmlWriter.Formatting = Formatting.Indented;
        xmlWriter.WriteStartDocument();
        xmlWriter.WriteStartElement("学习建议");
        xmlWriter.WriteEndElement();
        //写文档结束，调用WriteEndDocument方法
        xmlWriter.WriteEndDocument();
        //关闭textWriter
        xmlWriter.Close();
        Response.Redirect("LearningStyleTest.aspx");    //注册完成后跳转到学习风格测试
    }
    //点击重置按钮事件
    protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
    {
        txtstuId.Text = "";
        txtstuName.Text = "";
        txtpsw.Text = "";
        txtpsw1.Text = "";
        txtclassName.Text = "";
        txttel.Text = "";
        txtemail.Text = "";
    }
}