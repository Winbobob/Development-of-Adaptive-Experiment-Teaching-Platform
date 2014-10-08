using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SelfAdaptivePlatform.Model;
using SelfAdaptivePlatform.BLL;

public partial class RadioChange : System.Web.UI.Page
{
    static string j = "RadioLow";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["teaId"] != null)
        {
            GridView1.DataSource = Manage.ShowData(j);
            GridView1.DataBind();
        }
        else
        {
            Response.Redirect("Login.aspx");
        }     
    }
    //选择题目等级
    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {
        int i = int.Parse(DropDownList2.SelectedValue);
        if (i == 0)
        {
            j = "RadioLow";
            GridView1.DataSource = Manage.ShowData(j);
            GridView1.DataBind();
        }
        if (i == 1)
        {
            j = "RadioMid";
            GridView1.DataSource = Manage.ShowData(j);
            GridView1.DataBind();
        }
        if (i == 2)
        {
            j = "RadioHigh";
            GridView1.DataSource = Manage.ShowData(j);
            GridView1.DataBind();
        }       
    }
   //点击删除按钮事件
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        string Id;
        Id = this.GridView1.Rows[e.RowIndex].Cells[2].Text;
        //调用DeleteQuestion方法，删除数据库中信息
        int n = QuestionChangeManager.DeleteQuestion(Id, j);
        if (n > 0)
        {
            RegisterClientScriptBlock("", string.Format("<script type= 'text/javascript'> alert('成功删除数据，有{0}行被删除！'); </script>", n.ToString())); 
        }   
        GridView1.DataSource = Manage.ShowData(j);
        GridView1.DataBind();
    }
    private static string Id = null;
    //选择数据，并在textBox框中显示
    protected void GridView1_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
    {
        Id = GridView1.Rows[e.NewSelectedIndex].Cells[2].Text;
        RadioHigh question = new RadioHigh();
        question = QuestionChangeManager.GetRadioQuestion(Id, j);  //通过GetUser方法的userid索引，获取用户数据
        //用户数据显示
        txtQuestion.Text = question.question;
        txtA.Text = question.A;
        txtB.Text = question.B;
        txtC.Text = question.C;
        txtD.Text = question.D;
        txtAnswer.Text = question.answer;
        txtExplain.Text = question.explain;
        txtSuggestion.Text = Convert.ToString(question.suggestion);
    }
    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        RadioHigh updateQuestion = new RadioHigh();
        //将所用更新数据与不可更改数据存放于一个新User实例中
        updateQuestion.Id = int.Parse(Id);
        updateQuestion.question = txtQuestion.Text;
        updateQuestion.answer = txtAnswer.Text;
        updateQuestion.explain = txtExplain.Text;
        updateQuestion.A = txtA.Text;
        updateQuestion.B = txtB.Text;
        updateQuestion.C = txtC.Text;
        updateQuestion.D = txtD.Text;
        updateQuestion.suggestion = Convert.ToInt32(txtSuggestion.Text);
        int n = QuestionChangeManager.UpdateRadioQuestion(updateQuestion, j);
        //提示更改的数据行数
        if (n > 0)
            RegisterClientScriptBlock("", string.Format("<script type = 'text/javascript'> alert('成功更新数据，有{0}行收到更新！'); </script>", n.ToString())); 
        //数据更改后，再次绑定并显示更新后的数据
        GridView1.DataSource = Manage.ShowData(j);
        GridView1.DataBind();
    }
    //点击增加按钮事件
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //将注册信息存入数据库
        string question = txtQuestion.Text;
        string A = txtA.Text;
        string B = txtB.Text;
        string C = txtC.Text;
        string D = txtD.Text;
        string answer = txtAnswer.Text;
        string explain = txtExplain.Text;
        int suggestion = Convert.ToInt32(txtSuggestion.Text);
        RadioHigh newquestion = new RadioHigh(question, A, B, C, D, answer, explain, suggestion);
        int n = QuestionChangeManager.AddRadioQuestion(newquestion, j);
        //提示添加数据行，并清空textBox
        if (n > 0)
        {
            RegisterClientScriptBlock("", string.Format("<script type = 'text/javascript'> alert('成功添加数据，有{0}行数据已添加！'); </script>", n.ToString())); 
            txtQuestion.Text = "";
            txtA.Text = "";
            txtB.Text = "";
            txtC.Text = "";
            txtD.Text = "";
            txtAnswer.Text = "";
            txtExplain.Text = "";
            txtSuggestion.Text = "";
        }
        GridView1.DataSource = Manage.ShowData(j);
        GridView1.DataBind();
    }
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
    }
}