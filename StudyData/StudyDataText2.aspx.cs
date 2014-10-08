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
using System.Xml;
using System.Data.SqlClient;
using SelfAdaptivePlatform.Model;
using SelfAdaptivePlatform.BLL;
using System.IO;

public partial class StudyData_StudyDataText2 : System.Web.UI.Page
{
    static StudentInfo stuNews1 = new StudentInfo();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Session["stuId"] != null)
            {
                string stuId = Session["stuId"].ToString();
                stuNews1 = StudentInfoManager.Getstudentnews(stuId);
                StudentInfoManager.Showstudentnews1(stuNews1, lblstuName, lblstyle, imgphoto);
                if (lblstyle.Text == "活跃型+视觉型" || lblstyle.Text == "活跃型+言语型")
                {
                    lbldata.Text = "视频";
                }
                else if (lblstyle.Text == "沉思型+视觉型")
                {
                    lbldata.Text = "图片";
                }
                else if (lblstyle.Text == "沉思型+言语型")
                {
                    lbldata.Text = "文字";
                }
                else
                {
                    Response.Redirect("../LearningStyleText.aspx");
                }
                rbl1.SelectedValue = "0";

                //再读一遍XML
                string Num = "";
                //C#读取XML文件  http://www.cnblogs.com/xiaoxiangfeizi/archive/2011/08/07/2120807.html
                XmlDocument doc = new XmlDocument();   //使用的时候,首先声明一个XmlDocument对象,然后调用Load方法,从指定的路径加载XML文件
                doc.Load(Server.MapPath("../XML/" + Session["stuId"].ToString() + ".xml"));
                //然后可以通过调用SelectSingleNode得到指定的结点,通过GetAttribute得到具体的属性值.参看下面的代码

                // 得到根节点"学习建议"
                XmlNode xn = doc.SelectSingleNode("学习建议");
                // 得到根节点的所有子节点
                XmlNodeList xnl = xn.ChildNodes;
                foreach (XmlNode xn1 in xnl)
                {
                    // 将节点转换为元素，便于得到节点的属性值
                    XmlElement xe = (XmlElement)xn1;
                    // 得到Type和ISBN两个属性的属性值
                    Num = Num + xe.GetAttribute("类型").ToString() + ",";
                }
                if (Num == "")
                { lblsug.Text = lblstuName.Text + "同学，欢迎进入学习资料素材库！"; }
                else
                { lblsug.Text = lblstuName.Text + "同学，在上次测试中你需要复习知识点有：" + Num; }
            }
            else
            {
                Response.Redirect("../Login.aspx");
            }


        }
    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("StudyDataText1.aspx");
    }
    protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("StudyDataText2.aspx");
    }
    protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("StudyDataText3.aspx");
    }
    protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("StudyDataText4.aspx");
    }
    protected void ImageButton5_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("StudyDataText5.aspx");
    }
    protected void btnOK_Click(object sender, EventArgs e)
    {
        if (rbl1.SelectedValue == "0")
        {
            Response.Redirect("StudyDataText2.aspx");
        }
        else if (rbl1.SelectedValue == "1")
        {
            Response.Redirect("StudyDataPicture2.aspx");
        }
        else
        {
            Response.Redirect("StudyDataVideo2.aspx");
        }
    }
}
