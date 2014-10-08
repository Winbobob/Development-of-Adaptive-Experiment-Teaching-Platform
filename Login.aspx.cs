using System;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;
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

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //判断页面是否第一次加载
        if (!IsPostBack)
        {
            txtName.Focus();
            string checkCode = CreateCode(4);
            lblcode.Text = checkCode;
            txtcode.Text = lblcode.Text;    //避免输入万恶的验证码
        }
    }
    //产生验证码
    public string CreateCode(int codeLength)
    {
        string so = "1,2,3,4,5,6,7,8,9,0,a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u,v,w,x,y,z,A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z";
        string[] strArr = so.Split(',');
        string code = "";
        Random rand = new Random();
        for (int i = 0; i < codeLength; i++)
        {
            code += strArr[rand.Next(0, strArr.Length)];
        }
        return code;
    }
    //点击登录按钮事件
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        //判断是否选择用户类型
        if (RadioButton1.Checked == false && RadioButton2.Checked == false)
        {
            //Response.Write("<script type = 'text/javascript'> alert('请选择用户类型！'); </script>");
            RegisterClientScriptBlock("", "<script>alert('请选择用户类型！')</script>");
            return;
        }
        //判断选择学生用户
        else if (RadioButton2.Checked == true)
        {
            StudentInfo studentInfo = new StudentInfo(txtName.Text, txtPassword.Text);
            //登录成功
            if (StudentInfoManager.StudentLoginCheck(studentInfo) && (txtcode.Text == lblcode.Text))  
            {
                Session["stuId"] = txtName.Text;
                Session["password"] = txtPassword.Text;
                Response.Redirect("StudentDefault.aspx");    //跳转到系统学生主界面
            }
            //登录失败
            else if ((!(StudentInfoManager.StudentLoginCheck(studentInfo))) && (txtcode.Text == lblcode.Text))
            {
                //Response.Write("<script type = 'text/javascript'> alert('用户名或密码错误！'); </script>");
                RegisterClientScriptBlock("", "<script>alert('用户名或密码错误！')</script>");
                txtName.Text = "";
                txtPassword.Text = "";
                txtName.Focus();
            }
            else if (StudentInfoManager.StudentLoginCheck(studentInfo) && (txtcode.Text != lblcode.Text))
            {
                //Response.Write("<script type = 'text/javascript'> alert('验证码错误！'); </script>");
                RegisterClientScriptBlock("", "<script>alert('验证码错误！')</script>");
                txtcode.Text = "";
                txtcode.Focus();
            }
            else if ((!(StudentInfoManager.StudentLoginCheck(studentInfo))) && (txtcode.Text != lblcode.Text))
            {
                //Response.Write("<script type = 'text/javascript'> alert('用户名或密码错误！'); </script>");
                RegisterClientScriptBlock("", "<script>alert('用户名或密码错误！')</script>");
                txtName.Text = "";
                txtPassword.Text = "";
                txtName.Focus();
            }
        }
        //判断选择教师用户
        else if (RadioButton1.Checked == true)
        {
            TeacherInfo teacherInfo = new TeacherInfo(txtName.Text, txtPassword.Text);
            //登录成功
            if (TeacherInfoManager.TeacherLoginCheck(teacherInfo) && (txtcode.Text == lblcode.Text))   
            {
                Session["teaId"] = txtName.Text;
                Response.Redirect("TeacherDefault.aspx");    //跳转到系统教师主界面
            }
            //登录失败
            else if ((!(TeacherInfoManager.TeacherLoginCheck(teacherInfo))) && (txtcode.Text == lblcode.Text))
            {
                //Response.Write("<script type = 'text/javascript'> alert('用户名或密码错误！'); </script>");
                RegisterClientScriptBlock("", "<script>alert('用户名或密码错误！')</script>");
                txtName.Text = "";
                txtPassword.Text = "";
                txtName.Focus();
            }
            else if (TeacherInfoManager.TeacherLoginCheck(teacherInfo) && (txtcode.Text != lblcode.Text))
            {
                //Response.Write("<script type = 'text/javascript'> alert('验证码错误！'); </script>");
                RegisterClientScriptBlock("", "<script>alert('验证码错误！')</script>");
                txtcode.Text = "";
                txtcode.Focus();
            }
            else if ((!(TeacherInfoManager.TeacherLoginCheck(teacherInfo))) && (txtcode.Text != lblcode.Text))
            {
                //Response.Write("<script type = 'text/javascript'> alert('用户名或密码错误！'); </script>");
                RegisterClientScriptBlock("", "<script>alert('用户名或密码错误！')</script>");
                txtName.Text = "";
                txtPassword.Text = "";
                txtName.Focus();
            }
        }
    }
    //点击重置按钮事件
    protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
    {
        txtName.Text = "";
        txtPassword.Text = "";
        txtcode.Text = "";
        txtName.Focus();
    }
    //点击注册按钮事件
    protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("Register.aspx");    //跳转到注册界面
    }
}
