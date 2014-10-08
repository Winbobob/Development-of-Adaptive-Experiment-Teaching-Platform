using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class teacherDefault : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["teaId"] != null)
        {

        }
        else
        {
            Response.Redirect("Login.aspx");
        }   
    }
}