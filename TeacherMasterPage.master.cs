using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml.Linq;
using SelfAdaptivePlatform.Model;
using SelfAdaptivePlatform.BLL;
using System.Data.SqlClient;


public partial class TeacherMasterPage : System.Web.UI.MasterPage
{
    static TeacherInfo teaNews1 = new TeacherInfo();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["teaId"] != null)
        {
            string teaId = Session["teaId"].ToString();
            teaNews1 = TeacherInfoManager.Getteachernews(teaId);
            TeacherInfoManager.Showteachernews(teaNews1, lblteaId, lblteaName, lblgender, lblphone, imgphoto);

        }
        else
        {
            Response.Redirect("Login.aspx");
        }

    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("TeacherRevise.aspx");
    }
}
