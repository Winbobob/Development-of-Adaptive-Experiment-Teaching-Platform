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

public partial class StudyingInform : System.Web.UI.Page
{ 
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["teaId"] != null)
        {
            GridView1.DataSource = Manage.ShowData1("ClassUnit");
            GridView1.DataBind();
        }
        else
        {
            Response.Redirect("Login.aspx");
        } 
    }
    private static string stuId  = null;
    //数据选择
    protected void GridView1_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
    {
        ClassUnit stuNews = new ClassUnit();
        stuId = GridView1.Rows[e.NewSelectedIndex].Cells[1].Text;
        stuNews = ClassUnitManager.GetStudyingInform(stuId);
        //用户数据显示
        lblstuId.Text = Convert.ToString(stuNews.stuId);
        txtTotalscore.Text = Convert.ToString(stuNews.totalScore);       
    }
    //数据更新
    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        ClassUnit updateStudyingInform = new ClassUnit();
        updateStudyingInform.stuId = lblstuId.Text;
        updateStudyingInform.totalScore = Convert.ToInt32(txtTotalscore.Text);   
        int n = ClassUnitManager.UpdateStudyingInform(updateStudyingInform);
        //提示更改的数据行数
        if (n > 0)
            RegisterClientScriptBlock("", string.Format("<script type = 'text/javascript'> alert('成功更新数据，有{0}行收到更新！'); </script>", n.ToString()));
        lblstuId.Text = "label";
        txtTotalscore.Text = "";
        //数据更改后，再次绑定并显示更新后的数据
        GridView1.DataSource = Manage.ShowData1("ClassUnit");
        GridView1.DataBind();
    }
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
    }
}