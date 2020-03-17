using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace DemoWeb
{
    public partial class LoginPage : System.Web.UI.Page
    {
        SqlConnection Con = null;
        SqlDataAdapter Adp = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            Con = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlCon"].ToString());
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {

            Adp = new SqlDataAdapter("sp_validateLogin", Con);
            Adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            Adp.SelectCommand.Parameters.AddWithValue("@U", txtUsername.Text);
            Adp.SelectCommand.Parameters.AddWithValue("@P", txtPassword.Text);
            SqlParameter P = new SqlParameter("@C", SqlDbType.Int);
            P.Direction = ParameterDirection.Output;
            Adp.SelectCommand.Parameters.Add(P);
            DataSet DS = new DataSet();
            Adp.Fill(DS, "L");
            if (P.Value.ToString() == "1")
            {
                Session["User"] = txtUsername.Text;
                Response.Redirect("AddEmp.aspx");
            }
            else
            {
                LblMessage.Text = "Invalid Credentials";
                txtUsername.Text = " ";
                txtUsername.Focus();
            }
        }

        protected void btnLogin_Click1(object sender, EventArgs e)
        {

        }
    }
}