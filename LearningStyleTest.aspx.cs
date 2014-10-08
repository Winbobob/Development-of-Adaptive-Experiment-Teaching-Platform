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

public partial class LearningStyleTest : System.Web.UI.Page
{
    static LearningStyle r1 = new LearningStyle();
    static LearningStyle r2 = new LearningStyle();
    static LearningStyle r3 = new LearningStyle();
    static LearningStyle r4 = new LearningStyle();
    static LearningStyle r5 = new LearningStyle();
    static LearningStyle r6 = new LearningStyle();
    static LearningStyle r7 = new LearningStyle();
    static LearningStyle r8 = new LearningStyle();
    static LearningStyle r9 = new LearningStyle();
    static LearningStyle r10 = new LearningStyle();
    static LearningStyle r11 = new LearningStyle();
    static LearningStyle r12 = new LearningStyle();
    static LearningStyle r13 = new LearningStyle();
    static LearningStyle r14 = new LearningStyle();
    static LearningStyle r15 = new LearningStyle();
    static LearningStyle r16 = new LearningStyle();
    static LearningStyle r17 = new LearningStyle();
    static LearningStyle r18 = new LearningStyle();
    static LearningStyle r19 = new LearningStyle();
    static LearningStyle r20 = new LearningStyle();
    static LearningStyle r21 = new LearningStyle();
    static LearningStyle r22 = new LearningStyle();
    static StudentInfo stuNews1 = new StudentInfo();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["stuId"] != null)
        {
            string stuId = Session["stuId"].ToString();
            string learningstyle = "";
            stuNews1 = StudentInfoManager.Getstudentnews(stuId);
            learningstyle = stuNews1.learningStyle;
            //判断是否进行过学习风格测试
            if (learningstyle == "")
            {
                r1 = LearningStyleManager.GetRadio(1);    //获取学习风格测试题
                LearningStyleManager.ShowQuestionRadio(r1, rdolistS1, lblS1);    //显示题目
                r2 = LearningStyleManager.GetRadio(2);
                LearningStyleManager.ShowQuestionRadio(r2, rdolistS2, lblS2);
                r3 = LearningStyleManager.GetRadio(3);
                LearningStyleManager.ShowQuestionRadio(r3, rdolistS3, lblS3);
                r4 = LearningStyleManager.GetRadio(4);
                LearningStyleManager.ShowQuestionRadio(r4, rdolistS4, lblS4);
                r5 = LearningStyleManager.GetRadio(5);
                LearningStyleManager.ShowQuestionRadio(r5, rdolistS5, lblS5);
                r6 = LearningStyleManager.GetRadio(6);
                LearningStyleManager.ShowQuestionRadio(r6, rdolistS6, lblS6);
                r7 = LearningStyleManager.GetRadio(7);
                LearningStyleManager.ShowQuestionRadio(r7, rdolistS7, lblS7);
                r8 = LearningStyleManager.GetRadio(8);
                LearningStyleManager.ShowQuestionRadio(r8, rdolistS8, lblS8);
                r9 = LearningStyleManager.GetRadio(9);
                LearningStyleManager.ShowQuestionRadio(r9, rdolistS9, lblS9);
                r10 = LearningStyleManager.GetRadio(10);
                LearningStyleManager.ShowQuestionRadio(r10, rdolistS10, lblS10);
                r11 = LearningStyleManager.GetRadio(11);
                LearningStyleManager.ShowQuestionRadio(r11, rdolistS11, lblS11);
                r12 = LearningStyleManager.GetRadio(12);
                LearningStyleManager.ShowQuestionRadio(r12, rdolistS12, lblS12);
                r13 = LearningStyleManager.GetRadio(13);
                LearningStyleManager.ShowQuestionRadio(r13, rdolistS13, lblS13);
                r14 = LearningStyleManager.GetRadio(14);
                LearningStyleManager.ShowQuestionRadio(r14, rdolistS14, lblS14);
                r15 = LearningStyleManager.GetRadio(15);
                LearningStyleManager.ShowQuestionRadio(r15, rdolistS15, lblS15);
                r16 = LearningStyleManager.GetRadio(16);
                LearningStyleManager.ShowQuestionRadio(r16, rdolistS16, lblS16);
                r17 = LearningStyleManager.GetRadio(17);
                LearningStyleManager.ShowQuestionRadio(r17, rdolistS17, lblS17);
                r18 = LearningStyleManager.GetRadio(18);
                LearningStyleManager.ShowQuestionRadio(r18, rdolistS18, lblS18);
                r19 = LearningStyleManager.GetRadio(19);
                LearningStyleManager.ShowQuestionRadio(r19, rdolistS19, lblS19);
                r20 = LearningStyleManager.GetRadio(20);
                LearningStyleManager.ShowQuestionRadio(r20, rdolistS20, lblS20);
                r21 = LearningStyleManager.GetRadio(21);
                LearningStyleManager.ShowQuestionRadio(r21, rdolistS21, lblS21);
                r22 = LearningStyleManager.GetRadio(22);
                LearningStyleManager.ShowQuestionRadio(r22, rdolistS22, lblS22);
            }
            else
            {
                lblTitle.Visible = false;
                PanelAll.Visible = false;
                btnSubmit.Visible = false;
                //Response.Write(string.Format("<script type = 'text/javascript'> alert('{0}'); </script>", "您的学习风格为" + learningstyle + "!"));
                RegisterClientScriptBlock("", string.Format("<script type = 'text/javascript'> alert('{0}'); </script>", "您的学习风格为" + learningstyle + "!"));
            }
        }
        else
        {
            Response.Redirect("Login.aspx");
        }
    }
    //点击提交按钮事件
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        int na = 0;
        int nb = 0;
        int nc = 0;
        int nd = 0;
        if (rdolistS1.SelectedValue == "A")
            na = na + 1;
        else if (rdolistS1.SelectedValue == "B")
            nb = nb + 1;
        if (rdolistS2.SelectedValue == "A")
            nc = nc + 1;
        else if (rdolistS2.SelectedValue == "B")
            nd = nd + 1;
        if (rdolistS3.SelectedValue == "A")
            na = na + 1;
        else if (rdolistS3.SelectedValue == "B")
            nb = nb + 1;
        if (rdolistS4.SelectedValue == "A")
            nc = nc + 1;
        else if (rdolistS4.SelectedValue == "B")
            nd = nd + 1;
        if (rdolistS5.SelectedValue == "A")
            na = na + 1;
        else if (rdolistS5.SelectedValue == "B")
            nb = nb + 1;
        if (rdolistS6.SelectedValue == "A")
            nc = nc + 1;
        else if (rdolistS6.SelectedValue == "B")
            nd = nd + 1;
        if (rdolistS7.SelectedValue == "A")
            na = na + 1;
        else if (rdolistS7.SelectedValue == "B")
            nb = nb + 1;
        if (rdolistS8.SelectedValue == "A")
            nc = nc + 1;
        else if (rdolistS8.SelectedValue == "B")
            nd = nd + 1;
        if (rdolistS9.SelectedValue == "A")
            na = na + 1;
        else if (rdolistS9.SelectedValue == "B")
            nb = nb + 1;
        if (rdolistS10.SelectedValue == "A")
            nc = nc + 1;
        else if (rdolistS10.SelectedValue == "B")
            nd = nd + 1;
        if (rdolistS11.SelectedValue == "A")
            na = na + 1;
        else if (rdolistS11.SelectedValue == "B")
            nb = nb + 1;
        if (rdolistS12.SelectedValue == "A")
            nc = nc + 1;
        else if (rdolistS12.SelectedValue == "B")
            nd = nd + 1;
        if (rdolistS13.SelectedValue == "A")
            na = na + 1;
        else if (rdolistS13.SelectedValue == "B")
            nb = nb + 1;
        if (rdolistS14.SelectedValue == "A")
            nc = nc + 1;
        else if (rdolistS14.SelectedValue == "B")
            nd = nd + 1; 
        if (rdolistS15.SelectedValue == "A")
            na = na + 1;
        else if (rdolistS15.SelectedValue == "B")
            nb = nb + 1; 
        if (rdolistS16.SelectedValue == "A")
            nc = nc + 1;
        else if (rdolistS16.SelectedValue == "B")
            nd = nd + 1;
        if (rdolistS17.SelectedValue == "A")
            na = na + 1;
        else if (rdolistS17.SelectedValue == "B")
            nb = nb + 1;
        if (rdolistS18.SelectedValue == "A")
            nc = nc + 1;
        else if (rdolistS18.SelectedValue == "B")
            nd = nd + 1;
        if (rdolistS19.SelectedValue == "A")
            na = na + 1;
        else if (rdolistS19.SelectedValue == "B")
            nb = nb + 1;
        if (rdolistS20.SelectedValue == "A")
            nc = nc + 1;
        else if (rdolistS20.SelectedValue == "B")
            nd = nd + 1;
        if (rdolistS21.SelectedValue == "A")
            na = na + 1;
        else if (rdolistS21.SelectedValue == "B")
            nb = nb + 1;
        if (rdolistS22.SelectedValue == "A")
            nc = nc + 1;
        else if (rdolistS22.SelectedValue == "B")
            nd = nd + 1;
        string learningstyle;
        string stuId = Session["stuId"].ToString();
        string password = Session["password"].ToString();
        Session["na"] = na;
        Session["nb"] = nb;
        Session["nc"] = nc;
        Session["nd"] = nd;
        if (na > nb && nc > nd)
        {
            learningstyle = "活跃型+视觉型";
            Session["result"] = "您的学习风格为活跃型+视觉型，适合视频型学习方式！";
            //Response.Write("<script type = 'text/javascript'> alert('您的学习风格为活跃型+视觉型！'); </script>");
        }
        else if (na > nb && nc < nd)
        {    learningstyle = "活跃型+言语型";
        Session["result"] = "您的学习风格为活跃型+言语型！，适合视频型学习方式！";
             //Response.Write("<script type = 'text/javascript'> alert('您的学习风格为活跃型+言语型！'); </script>");
        }
        else if (na < nb && nc > nd)
        {    learningstyle = "沉思型+视觉型";
        Session["result"] = "您的学习风格为沉思型+视觉型，适合图片型学习方式！";
             //Response.Write("<script type = 'text/javascript'> alert('您的学习风格为沉思型+视觉型！'); </script>");
        }
        else
        {
            learningstyle = "沉思型+言语型";
            Session["result"] = "您的学习风格为沉思型+言语型，适合文字型学习方式！";
            //Response.Write("<script type = 'text/javascript'> alert('您的学习风格为沉思型+言语型！'); </script>");
            
        }
        RegisterClientScriptBlock("", "<script type = 'text/javascript'> alert('测试结束，请点击页面下方的按钮查看学习风格测试结果！'); </script>"); 
        StudentInfo studentInfo = new StudentInfo(stuId, learningstyle, password);
        StudentInfoManager.UpdateStudent2(studentInfo);    //记录用户学习风格类型
        btnSubmit.Visible = false;
        Panel1.Visible = true;
    }

}
