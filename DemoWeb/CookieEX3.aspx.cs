using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoWeb
{
    public partial class CookieEX3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                //Fetching data from Cookies
                string s = Request.Cookies["User"].Value;
                string s1 = Request.Cookies["User1"].Value;
                Response.Write(s + " " + s1);
               
            }
            catch(NullReferenceException )
            {
                Response.Redirect("Login.aspx");
            }
        }
    }
}