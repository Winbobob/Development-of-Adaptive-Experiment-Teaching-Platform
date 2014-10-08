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
using System.Web.UI.WebControls;
using SelfAdaptivePlatform.Model;
using SelfAdaptivePlatform.BLL;
using System.IO;

public partial class _Default : System.Web.UI.Page
{
    static string j = "low";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["teaId"] != null)
        {
            if (j == "low")
            {
                GridView1.DataSource = Manage.ShowData3();
                GridView1.DataBind();
            }
            else if (j == "mid")
            {
                GridView1.DataSource = Manage.ShowData4();
                GridView1.DataBind();
            }
            else
            {
                GridView1.DataSource = Manage.ShowData5();
                GridView1.DataBind();
            }
        }
        else
        {
            Response.Redirect("Login.aspx");
        }    
    }
    //选择设计题等级
    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {
        int i = int.Parse(DropDownList2.SelectedValue);
        if (i == 0)
        {
            j = "low";
            GridView1.DataSource = Manage.ShowData3();
            GridView1.DataBind();
        }
        else if (i == 1)
        {
            j = "mid";
            GridView1.DataSource = Manage.ShowData4();
            GridView1.DataBind();
        }
        else
        {
            j = "high";
            GridView1.DataSource = Manage.ShowData5();
            GridView1.DataBind();
        }
    }
    //选择数据
    protected void GridView1_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
    {
        lblstuId.Text = GridView1.Rows[e.NewSelectedIndex].Cells[1].Text;
        lblfilename.Text = GridView1.Rows[e.NewSelectedIndex].Cells[2].Text;
    }
    //更新数据
    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        ClassUnit updateStudyingInform = new ClassUnit();
        updateStudyingInform.stuId = lblstuId.Text;
        if (j == "low")
        {
            updateStudyingInform.designLow = Convert.ToInt32(txtscore.Text);
        }
        else if (j == "mid")
        {
            updateStudyingInform.designMid = Convert.ToInt32(txtscore.Text);
        }
        else
        {
            updateStudyingInform.designHigh = Convert.ToInt32(txtscore.Text);
        }
        int n = ClassUnitManager.UpdateStudyingInform2(updateStudyingInform,j);
        txtscore.Text = "";
        lblstuId.Text = "stuId";
        lblfilename.Text = "filename";
        //提示更改的数据行数
        if (n > 0)
            RegisterClientScriptBlock("", string.Format("<script type = 'text/javascript'> alert('成功更新数据，有{0}行收到更新！'); </script>", n.ToString())); 
    }
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
    }
    //点击下载按钮事件
    protected void btndownload_Click(object sender, EventArgs e)
    {
        //Response.Write(string.Format("<script type = 'text/javascript'> alert('请到DesignWorks/{0}文件夹中查找{1}'); </script>", j, lblfilename.Text));
        //("", string.Format("<script type = 'text/javascript'> alert('请到DesignWorks/{0}文件夹中查找{1}'); </script>", j, lblfilename.Text)); 
        string filename = Path.GetFileName("~/DesignWorks/" + j + "/" + lblfilename.Text);
        Response.Clear(); Response.ContentType = "application/octet-stream ";
        Response.AppendHeader("Content-Disposition", "attachment;Filename =" + System.Convert.ToChar(34) + filename + System.Convert.ToChar(34));
        Response.Charset = "";
        Response.ContentEncoding = System.Text.Encoding.UTF8;
        Response.Flush();
        Response.WriteFile("~/DesignWorks/" + j + "/" + lblfilename.Text); 
    }
}
