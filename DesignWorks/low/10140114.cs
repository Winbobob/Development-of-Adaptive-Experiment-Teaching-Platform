using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Delegate_Event : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Cat cat = new Cat("Tom");

        Mouse mouse1 = new Mouse("Jerry");
        Mouse mouse2 = new Mouse("Jack");

        cat.CatShout += new EventHandler(mouse1.Run);
        cat.CatShout += new EventHandler(mouse2.Run);

        cat.Shout();

        Response.Write("<br/>");
        cat.CatShout -= new EventHandler(mouse1.Run);
        cat.Shout();
    }
}
