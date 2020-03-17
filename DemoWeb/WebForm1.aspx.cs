using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace DemoWeb
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection Con = null;
        SqlDataAdapter Adp = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            // ConfigurationManager is used to access Web.Config and Connectionstrings is the tag in which connectivity is specified
            
            Con = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlCon"].ToString());
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Adp = new SqlDataAdapter("Select * from Empdata", Con);
            DataSet DS = new DataSet();
            Adp.Fill(DS, "E");
            DataRow R = DS.Tables["E"].NewRow();
            R[0] = int.Parse(txtEmpno.Text);
            R[1] = txtEname.Text;
            R[2] = txtJob.Text;
            R[3] = txtManager.Text;
            R[4] = DateTime.Parse(txtHiredate.Text);
            R[5] = int.Parse(txtSal.Text);
            R[6] = int.Parse(txtCommision.Text);
            R[7] = int.Parse(txtDeptno.Text);
            DS.Tables["E"].Rows.Add(R);
            SqlCommandBuilder cmd = new SqlCommandBuilder(Adp);
            Adp.InsertCommand = cmd.GetInsertCommand();
            Adp.Update(DS, "E");
            Response.Write("<script>alert('1 Row inserted')</script>");
        }
    }
}