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
using System.Drawing;
using System.IO;
using System.Text;

public partial class StudentInformation : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["teaId"] != null)
        {
            if (!IsPostBack)
            {
                GridView1.DataSource = StudentInfoManager.ShowData();
                GridView1.DataBind();
                lblnum.Text = StudentInfoManager.num().ToString();
            }
        }
        else
        {
            Response.Redirect("Login.aspx");
        } 
    }


}