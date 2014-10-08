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

public partial class WrongJudge : System.Web.UI.Page
{
    static string j = "WrongJudgeLow";
    static string k = "JudgeLow";
    static string g = "Low";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["stuId"] != null)
        {
            if (!IsPostBack)
            {
                ShowData();
            }
        }
        else
        {
            Response.Redirect("Login.aspx");
        } 
        
    }
    private void ShowData()
    {
        string a = Session["stuId"].ToString();
        DataSet dataset = WrongJudgeManager.LoadPart(k, g, a);
        GridView1.DataSource = dataset;
        GridView1.DataKeyNames = new string[] { "Tid" };
        GridView1.DataBind();
        lblWTnum.Text = WrongJudgeManager.Wrongnum(a,g).ToString();
        ddlTitleType.SelectedValue = "2";
    }


    protected void ddlTitleType_SelectedIndexChanged(object sender, EventArgs e)
    {
        int i = int.Parse(ddlTitleType.SelectedValue);
        if (i == 0)
        {
            Response.Redirect("~/WrongRadio.aspx?caid=0");
        }
        else if (i == 1)
        {
            Response.Redirect("~/WrongBlank.aspx?caid=0");
        }
        else if (i == 2)
        {
            Response.Redirect("~/WrongJudge.aspx?caid=0");
        }
        else
        {
            Response.Redirect("~/WrongDesign.aspx?caid=0");
        }
    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value);
        int n = WrongJudgeManager.delectTitle1(id);
        if (n > 0)
        {
            //Response.Write(string.Format("<scrip type= 'text/javascript'> alert('成功删除数据，有{0}行被删除！'); </script>", n.ToString()));
            RegisterClientScriptBlock("", string.Format("<scrip type= 'text/javascript'> alert('成功删除数据，有{0}行被删除！'); </script>", n.ToString())); 
        }

        ShowData();
    }
    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        foreach (TableCell tc in e.Row.Cells)
        {
            tc.Attributes["style"] = "height:30px;";
        }
        if (e.Row.RowIndex != -1)
        {
            int id = GridView1.PageIndex * GridView1.PageSize + e.Row.RowIndex + 1;
            e.Row.Cells[0].Text = id.ToString();
            
        }
        
    }

    protected void btnOut_Click(object sender, EventArgs e)
    {
        Export("application/ms-word", "判断题错题.doc");
    }  

    private void Export(string FileType, string FileName)
    {
        Response.Charset = "GB2312";
        Response.ContentEncoding = System.Text.Encoding.UTF8;
        Response.Write("<meta http-equiv=Content-Type content=text/html;charset=UTF-8>");
        Response.AppendHeader("Content-Disposition", "attachment;filename=" + HttpUtility.UrlEncode(FileName, Encoding.UTF8).ToString());
        Response.ContentEncoding = System.Text.Encoding.GetEncoding("GB2312");          ////设置导出文件的格式   
        Response.ContentType = FileType;
        this.EnableViewState = false;
        StringWriter tw = new StringWriter();
        HtmlTextWriter hw = new HtmlTextWriter(tw);
        GridView1.RenderControl(hw);
        Response.Write(tw.ToString());
        Response.End();
    }
     public override void VerifyRenderingInServerForm(Control control)
    {

    }

    protected void btnAnswer_Click(object sender, EventArgs e)
    {
        string answer = ((Button)sender).CommandArgument.ToString(); 
        int row = ((GridViewRow)((Button)sender).NamingContainer).RowIndex;
        GridView1.Rows[row].Cells[3].Text = answer;
    }

    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {
        int i = int.Parse(ddlGradeNo.SelectedValue);
        if (i == 0)
        {
            j = "WrongJudgeLow";
            k = "JudgeLow";
            g = "Low";
            ShowData();
        }

        if (i == 1)
        {
            j = "WrongJudgeMid";
            k = "JudgeMid";
            g = "Mid";
            ShowData();
        }
        if (i == 2)
        {
            j = "WrongJudgeHigh";
            k = "JudgeHigh";
            g = "High";
            ShowData();
        }
    }
}
