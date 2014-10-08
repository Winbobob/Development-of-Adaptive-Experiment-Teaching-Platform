using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SelfAdaptivePlatform.Model;
using SelfAdaptivePlatform.BLL;

public partial class designChange : System.Web.UI.Page
{
    static string j = "DesignLow";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["teaId"] != null)
        {
            GridView1.DataSource = Manage.ShowData(j);
            //GridView1.DataSource = Manage.ShowData("DesignLow");
            GridView1.DataBind();
        }
        else
        {
            Response.Redirect("Login.aspx");
        }
    }
    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {
        int i = int.Parse(DropDownList2.SelectedValue);
        if (i == 0)
        {
            j = "DesignLow";
            GridView1.DataSource = Manage.ShowData(j);
            GridView1.DataBind();

        }

        if (i == 1)
        {
            j = "DesignMid";
            GridView1.DataSource = Manage.ShowData(j);
            GridView1.DataBind();

        }
        if (i == 2)
        {
            j = "DesignHigh";
            GridView1.DataSource = Manage.ShowData(j);
            GridView1.DataBind();

        }
    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        string Id;
        Id = this.GridView1.Rows[e.RowIndex].Cells[2].Text;
        //调用DeleteQuestion方法，删除数据库中信息
        int n = QuestionChangeManager.DeleteQuestion(Id, j);
        if (n > 0)
        {
            //Response.Write(string.Format("<script type= 'text/javascript'> alert('成功删除数据，有{0}行被删除！'); </script>", n.ToString()));
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
        DesignHigh question = new DesignHigh();
        question = QuestionChangeManager.GetDesignQuestion(Id, j);  //通过GetUser方法的userid索引，获取用户数据

        //用户数据显示
        txtQuestion.Text = question.question;
        txtAnswer.Text = question.answer;
        txtSuggestion.Text = Convert.ToString(question.suggestion);
        txtQ1.Text = question.Q1;
        txtQ1Answer.Text = question.answer1;
        txtQ1A.Text = question.A1;
        txtQ1B.Text = question.B1;
        txtQ1C.Text = question.C1;
        txtQ1D.Text = question.D1;
        txtQ2.Text = question.Q2;
        txtQ2Answer.Text = question.answer2;
        txtQ2A.Text = question.A2;
        txtQ2B.Text = question.B2;
        txtQ2C.Text = question.C2;
        txtQ2D.Text = question.D2;
    }
    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        DesignHigh updateQuestion = new DesignHigh();

        //将所用更新数据与不可更改数据存放于一个新实例中
        updateQuestion.Id = int.Parse(Id);
        updateQuestion.question = txtQuestion.Text;
        updateQuestion.answer = txtAnswer.Text;
        updateQuestion.Q1 = txtQ1.Text;
        updateQuestion.A1 = txtQ1A.Text;
        updateQuestion.B1 = txtQ1B.Text;
        updateQuestion.C1 = txtQ1C.Text;
        updateQuestion.D1 = txtQ1D.Text;
        updateQuestion.answer1 = txtQ1Answer.Text;
        updateQuestion.Q2 = txtQ2.Text;
        updateQuestion.A2 = txtQ2A.Text;
        updateQuestion.B2 = txtQ2B.Text;
        updateQuestion.C2 = txtQ2C.Text;
        updateQuestion.D2 = txtQ2D.Text;
        updateQuestion.answer2 = txtQ2Answer.Text;
        updateQuestion.suggestion = Convert.ToInt32(txtSuggestion.Text);

        //调用UpdateUser方法，实现数据库中的数据更新
        int n = QuestionChangeManager.UpdateDesignQuestion(updateQuestion, j);

        //提示更改的数据行数
        if (n > 0)
            //Response.Write(string.Format("<script type = 'text/javascript'> alert('成功更新数据，有{0}行收到更新！'); </script>", n.ToString()));
            RegisterClientScriptBlock("", string.Format("<script type = 'text/javascript'> alert('成功更新数据，有{0}行收到更新！'); </script>", n.ToString())); 
        //数据更改后，再次绑定并显示更新后的数据
        GridView1.DataSource = Manage.ShowData(j);
        GridView1.DataBind();
    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //将注册信息存入数据库
        string question = txtQuestion.Text;
        string answer = txtAnswer.Text;
        string Q1 = txtQ1.Text;
        string A1 = txtQ1A.Text;
        string B1 = txtQ1B.Text;
        string C1 = txtQ1C.Text;
        string D1 = txtQ1D.Text;
        string answer1 = txtQ1Answer.Text;
        string Q2 = txtQ2.Text;
        string A2 = txtQ2A.Text;
        string B2 = txtQ2B.Text;
        string C2 = txtQ2C.Text;
        string D2 = txtQ2D.Text;
        string answer2 = txtQ2Answer.Text;
        int suggestion = Convert.ToInt32(txtSuggestion.Text);


        DesignHigh newquestion = new DesignHigh(question, answer,suggestion,Q1, A1, B1, C1, D1, answer1, Q2, A2,B2, C2, D2, answer2);
        //调用AddUser方法，添加新用户信息
        int n = QuestionChangeManager.AddDesignQuestion(newquestion, j);

        //提示添加数据行，并清空textBox
        if (n > 0)
        {
            Response.Write(string.Format("<script type = 'text/javascript'> alert('成功添加数据，有{0}行数据已添加！'); </script>", n.ToString()));
            txtQuestion.Text = "";
            txtAnswer.Text = "";
            txtQ1.Text = "";
            txtQ1A.Text = "";
            txtQ1B.Text = "";
            txtQ1C.Text = "";
            txtQ1D.Text = "";
            txtQ1Answer.Text = "";
            txtQ2.Text = "";
            txtQ2A.Text = "";
            txtQ2B.Text = "";
            txtQ2C.Text = "";
            txtQ2D.Text = "";
            txtQ2Answer.Text = "";
            txtSuggestion.Text = "";

        }

        //数据更改后，再次绑定并显示更新后的数据
        GridView1.DataSource = Manage.ShowData(j);
        GridView1.DataBind();
    }

    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
    }
}