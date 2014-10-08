using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class example_examplePicture5 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Session["stutext"].ToString() == "初级")
            {
                lbllevel.Text = "您进行的是初级测试，请选择初级难度例题进行巩固！";
            }
            else if (Session["stutext"].ToString() == "中级")
            {
                lbllevel.Text = "您进行的是中级测试，请选择中级难度例题进行巩固！";
            }
            else if (Session["stutext"].ToString() == "高级")
            {
                lbllevel.Text = "您进行的是高级测试，请选择高级难度例题进行巩固！";
            }
            else
            {
                lbllevel.Text = "您可以查看初、中、高三个难度的例题！";
            }
        }
    }
}