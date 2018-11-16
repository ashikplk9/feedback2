using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class tutor_tutorhomel : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        String nm;
        nm = Convert.ToString(Session["us"]);
    }
}