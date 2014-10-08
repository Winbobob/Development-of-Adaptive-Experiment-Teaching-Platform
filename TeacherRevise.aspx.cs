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

public partial class teacherrevise : System.Web.UI.Page
{
    static TeacherInfo teaNews1 = new TeacherInfo();
    
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["teaId"] != null)
        {
            if (txtteaId.Text == "")
            {
                if (Session["teaId"] != null)
                {
                    string teaId = Session["teaId"].ToString();
                    teaNews1 = TeacherInfoManager.Getteachernews(teaId);
                    TeacherInfoManager.Showteachernews2(teaNews1, txtteaId, txtteaName, rdolistgender, txtemail, imgphoto, txttel);
                    lblgender.Text = teaNews1.gender;


                }

            }
        }
        else
        {
            Response.Redirect("Login.aspx");
        }   
        
    }

    //使密码修改控件可见
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


    //密码修改
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        string teaId = txtteaId.Text;
        teaNews1 = TeacherInfoManager.Getteachernews(teaId);
        string password = txtpsw1.Text;
        if (txtpsw.Text != teaNews1.password)
        {
            //Response.Write("<script type = 'text/javascript'> alert('原密码输入错误！'); </script>");
            RegisterClientScriptBlock("", "<script>alert('原密码输入错误！')</script>"); 
            txtpsw.Focus();

        }
        else
        {
            TeacherInfo teacherInfo1 = new TeacherInfo(teaId, password);
            TeacherInfoManager.UpdatePsw(teacherInfo1);
            //Response.Write("<script type = 'text/javascript'> alert('密码修改成功！'); </script>");
            RegisterClientScriptBlock("", "<script>alert('密码修改成功！')</script>"); 
        }

    }

    //保存修改
    protected void btnSubmit0_Click(object sender, EventArgs e)
    {
        string teaId = txtteaId.Text;
        teaNews1 = TeacherInfoManager.Getteachernews(teaId);
        string photo = teaNews1.photo;
        string teaName = txtteaName.Text;
        string email = txtemail.Text;
        string gender = "男";
        if (rdolistgender.Items[1].Selected == true)
        {
            gender = "女";
        }
        string telephone = txttel.Text;

        Boolean fileOK = false;
        // 指定路径
        String path = Server.MapPath("~/");
        // 文件上传控件中如果已经包含文件
        if (fUpload.HasFile)
        {
            // 得到文件的后缀
            String fileExtension =
                System.IO.Path.GetExtension(fUpload.FileName).ToLower();
            // 允许的文件后缀
            String[] allowedExtensions = { ".gif", ".png", ".jpeg", ".jpg" };
            // 看包含的文件是否是被允许的文件后缀
            for (int i = 0; i < allowedExtensions.Length; i++)
            {
                if (fileExtension == allowedExtensions[i])
                {
                    // 如果是，标志位置为真
                    fileOK = true;
                }
            }
        }

        if (fileOK)
        {
            try
            {
                // 文件另存在服务器指定目录下
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

        TeacherInfo teaInfo= new TeacherInfo(teaId, teaName, email, photo, gender, telephone);
        TeacherInfoManager.UpdateTeacher(teaInfo);
        

        teaNews1 = TeacherInfoManager.Getteachernews(teaId);
        TeacherInfoManager.Showteachernews2(teaNews1, txtteaId, txtteaName, rdolistgender, txtemail, imgphoto, txttel);
        lblgender.Text = teaNews1.gender;
        //Response.Write("<script type = 'text/javascript'> alert('修改成功！'); </script>");
        RegisterClientScriptBlock("", "<script>alert('修改成功！')</script>"); 
        return;
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        txtpsw.Text="";
        txtpsw1.Text = "";
        txtpsw2.Text = "";
    }
}
