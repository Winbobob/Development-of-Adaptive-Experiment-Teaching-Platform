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
using System.Data.SqlClient;
using SelfAdaptivePlatform.Model;
using SelfAdaptivePlatform.BLL;

public partial class studentrevise : System.Web.UI.Page
{
    static StudentInfo stuNews1 = new StudentInfo();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["stuId"] != null)
        {
            if (txtstuId.Text == "")
            {
                if (Session["stuId"] != null)
                {
                    string stuId = Session["stuId"].ToString();
                    stuNews1 = StudentInfoManager.Getstudentnews(stuId);    //获取个人信息
                    StudentInfoManager.Showstudentnews2(stuNews1, txtstuId, txtstuName, txtclassName, rdolistgender, txtemail, imgphoto, txttel, txtbirthday, txtlearningStyle);    //显示个人信息
                    lblgender.Text = stuNews1.gender;
                    rdolistgender.Items[0].Selected = false;
                    rdolistgender.Items[0].Selected = false;
                }
            }
        }
        else
        {
            Response.Redirect("Login.aspx");
        }   
    }
    //点击修改密码按钮事件，使密码修改控件可见
    protected void btnChangepsw_Click(object sender, EventArgs e)
    {
        Label6.Visible = true;
        Label7.Visible = true;
        Label8.Visible = true;
        txtpsw.Visible = true;
        txtpsw1.Visible = true;
        txtpsw2.Visible = true;
        rfvpsw.Visible = true;
        rfvpsw1.Visible = true;
        rfvpsw2.Visible = true;
        cvpsw1.Visible = true;
        btnSubmit.Visible = true;
        btnCancel.Visible = true;
    }
    //点击保存按钮事件
    protected void btnSubmit0_Click(object sender, EventArgs e)
    {
        string stuId = txtstuId.Text;
        stuNews1 = StudentInfoManager.Getstudentnews(stuId);
        string photo = stuNews1.photo;
        string stuName = txtstuName.Text;
        string email = txtemail.Text;
        string gender = "男";
        if (rdolistgender.Items[1].Selected == true)
        {
            gender = "女";
        }
        string className = txtclassName.Text;
        string telephone = txttel.Text;
        DateTime birthday = DateTime.Parse(txtbirthday.Text);
        string learningStyle = txtlearningStyle.Text;
        Boolean fileOK = false;
        String path = Server.MapPath("~/");
        if (fUpload.HasFile)
        {
            String fileExtension =System.IO.Path.GetExtension(fUpload.FileName).ToLower();
            String[] allowedExtensions = { ".gif", ".png", ".jpeg", ".jpg" };
            for (int i = 0; i < allowedExtensions.Length; i++)
            {
                if (fileExtension == allowedExtensions[i])
                {
                    fileOK = true;
                }
            }
        }
        if (fileOK)
        {
            try
            {
                fUpload.PostedFile.SaveAs(Server.MapPath("./load/") + fUpload.FileName);
                lbText.Text = "文件上传成功！";
                photo = "~/load/" + fUpload.FileName;
            }
            catch (Exception ex)
            {
                lbText.Text = "文件上传失败！";
            }
        }
        else
        {
            lbText.Text = "注意：只能上传gif、png、jpeg或者jpg图像文件！";
        }
        StudentInfo studentInfo = new StudentInfo(stuId, stuName, className, email, photo, gender, telephone, birthday, learningStyle);
        StudentInfoManager.UpdateStudent(studentInfo);
        stuNews1 = StudentInfoManager.Getstudentnews(stuId);
        StudentInfoManager.Showstudentnews2(stuNews1, txtstuId, txtstuName, txtclassName, rdolistgender, txtemail, imgphoto, txttel, txtbirthday, txtlearningStyle);
        lblgender.Text = stuNews1.gender;
        RegisterClientScriptBlock("", "<script>alert('修改成功！')</script>"); 
        return;
    }
    //点击确定按钮事件
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        string stuId = txtstuId.Text;
        string password = txtpsw1.Text;
        stuNews1 = StudentInfoManager.Getstudentnews(stuId);
        if (txtpsw.Text != stuNews1.password)
        {
            RegisterClientScriptBlock("", "<script>alert('原密码输入错误！')</script>"); 
            txtpsw.Focus();
        }
        else
        {
            StudentInfo studentInfo1 = new StudentInfo(stuId, password);
            StudentInfoManager.UpdatePsw(studentInfo1);    //密码更新
            RegisterClientScriptBlock("", "<script>alert('密码修改成功！')</script>"); 
        }  
    }
    //点击取消按钮事件
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        txtpsw.Text = "";
        txtpsw1.Text = "";
        txtpsw2.Text = "";
    }
}
