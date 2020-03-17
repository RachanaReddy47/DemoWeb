using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoWeb
{
    public partial class QSEX2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string s1=Request.QueryString["A"];
            string s2= Request.QueryString["B"];
            string s3= Request.QueryString["c"];
            Response.Write(s1 + " " + s2+" "+s3);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("QSEx3.aspx");
        }
    }
}