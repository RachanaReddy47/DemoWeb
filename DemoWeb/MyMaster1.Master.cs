using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace DemoWeb
{
    public partial class MyMaster1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string s = Path.GetFileName(Request.Path);
            //if (Request.Cookies["UserName"] == null)
            //    Response.Redirect("Login.aspx");
            //else
            //    Label1.Text = "Welcome " + Request.Cookies["UserName"].Value;
            if (s != "LoginPage.aspx")
            {
                if (Session["User"] == null)
                {
                    Response.Redirect("LoginPage.aspx");
                }
                else
                    Label1.Text = "Welcome " + Session["User"].ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //if(Request.Cookies["UserName"]!=null)
            //{
            //    HttpCookie Cookie = HttpContext.Current.Request.Cookies["UserName"];
            //    Cookie.Expires = DateTime.Now.AddSeconds(1);
            //    HttpContext.Current.Response.Cookies.Add(Cookie);
            //    Response.Redirect("Login.aspx");
            //}

            if(Session["User"]!=null)
            {
                Session.Clear();
                Response.Redirect("LoginPage.aspx");
            }
        }
    }
}