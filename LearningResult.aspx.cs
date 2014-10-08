using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class LearningResult : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        object na = Session["na"];
        object nb = Session["nb"];
        object nc = Session["nc"];
        object nd = Session["nd"];
        string[] XRowarr = { "活跃型","视觉型","沉思型","言语型" };
        object[] YRowarr = { na,nc,nb,nd};
        Chart1.Series["Series1"].Points.DataBindXY(XRowarr, YRowarr);
        Chart1.Series["Series1"].IsValueShownAsLabel = true;
        lblresult.Text = Session["result"].ToString();
    }
}