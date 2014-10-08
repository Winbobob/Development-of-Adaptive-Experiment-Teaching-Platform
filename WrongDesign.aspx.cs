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

public partial class WrongDesign : System.Web.UI.Page
{
    static string j = "WrongDesignLow";
    static string k = "DesignLow";
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
        DataSet dataset = WrongDesignManager.LoadPart(k, g, a);
        GridView1.DataSource = dataset;
        GridView1.DataKeyNames = new string[] { "Tid" };
        GridView1.DataBind();
        lblWTnum.Text = WrongDesignManager.Wrongnum(a, g).ToString();
        ddlTitleType.SelectedValue = "3";
    }
    protected void ddlTitleType_SelectedIndexChanged(object sender, EventArgs e)
    {
        int i = int.Parse(ddlTitleType.SelectedValue);
        if (i == 0)
        {
            Response.Redirect("~/WrongRadio.aspx?caid=0");
        }
        if (i == 1)
        {
            Response.Redirect("~/WrongBlank.aspx?caid=0");
        }
        if (i == 2)
        {
            Response.Redirect("~/WrongJudge.aspx?caid=0");
        }
        if (i == 3)
        {
            Response.Redirect("~/WrongDesign.aspx?caid=0");
        }

    }
    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {
        int i = int.Parse(ddlGradeNo.SelectedValue);
        if (i == 0)
        {
            j = "WrongDesignLow";
            k = "DesignLow";
            g = "Low";
            ShowData();
        }

        if (i == 1)
        {
            j = "WrongDesignMid";
            k = "DesignMid";
            g = "Mid";
            ShowData();
        }
        if (i == 2)
        {
            j = "WrongDesignHigh";
            k = "DesignHigh";
            g = "High";
            ShowData();
        }
    }
    
    protected void btnOut_Click(object sender, EventArgs e)
    {
        Export("application/ms-word", "设计题错题.doc");
    }
    private void Export(string FileType, string FileName)
    {
        Response.Charset = "GB2312";
        Response.ContentEncoding = System.Text.Encoding.UTF8;
        Response.Write("<meta http-equiv=Content-Type content=text/html;charset=UTF-8>");
        Response.AppendHeader("Content-Disposition", "attachment;filename=" + HttpUtility.UrlEncode(FileName, Encoding.UTF8).ToString());
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
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value);
        int n = WrongDesignManager.delectTitle1(id);
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
    protected void GridView2_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        foreach (TableCell tc in e.Row.Cells)
        {
            tc.Attributes["style"] = "height:30px;";
        }
    }
    protected void btnAnswer_Click(object sender, EventArgs e)
    {
        string Q = ((Button)sender).CommandArgument.ToString();
        string filename = Path.GetFileName("~/DesignAnswer/" + Q + ".cs");
        Response.Clear(); Response.ContentType = "application/octet-stream ";
        Response.AppendHeader("Content-Disposition", "attachment;Filename =" + System.Convert.ToChar(34) + filename + System.Convert.ToChar(34));
        Response.Charset = "";
        Response.ContentEncoding = System.Text.Encoding.UTF8;
        Response.Flush();
        Response.WriteFile("~/DesignAnswer/" + Q + ".cs"); 
    }
}
