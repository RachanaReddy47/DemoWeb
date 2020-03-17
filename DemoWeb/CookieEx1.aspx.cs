using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoWeb
{
    public partial class CookieEx1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(TextBox1.Text.Length!=0)
            {  
                //1st Type Creating a Cookie
                Response.Cookies["User"].Value = TextBox1.Text;
                //2nd Type
                HttpCookie H = new HttpCookie("User1");
                H.Value = TextBox1.Text;
                Response.Cookies.Add(H);
                H.Expires= DateTime.Now.AddSeconds(20);
                //destroying the cookie
                Response.Cookies["User"].Expires = DateTime.Now.AddSeconds(1);
                Response.Redirect("CookieEX2.aspx");
            }
        }
    }
}