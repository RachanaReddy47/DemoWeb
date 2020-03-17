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
    public partial class Example2 : System.Web.UI.Page
    {
        SqlConnection Con = null;
        SqlDataAdapter Adp = null;
        DemoEntities D = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            D = new DemoEntities();
            Con = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlCon"].ToString());
            Adp = new SqlDataAdapter("sp_ExtraxtDept", Con);
            if (!IsPostBack)
            {
                txtStart.Enabled = false;
                txtEnd.Enabled = false;
                ddlDeptNo.Enabled = false;
                Adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataSet DS = new DataSet();
                Adp.Fill(DS, "D");
                ddlDeptNo.DataSource = DS.Tables["D"];
                ddlDeptNo.DataTextField = "Dname";
                ddlDeptNo.DataValueField = "Deptno";
                ddlDeptNo.DataBind();
            }
        }

        protected void rdbHiredate_CheckedChanged(object sender, EventArgs e)
        {
            if(rdbHiredate.Checked)
            {
                txtStart.Enabled = true;
                txtEnd.Enabled = true;
                ddlDeptNo.Enabled = false;
            }
        }

        protected void rdbDeptno_CheckedChanged(object sender, EventArgs e)
        {
            if(rdbDeptno.Checked)
            {
                txtStart.Enabled = false;
                txtEnd.Enabled = false;
                ddlDeptNo.Enabled = true;
            }
        }

        protected void btnExtract_Click(object sender, EventArgs e)
        {
            if(rdbHiredate.Checked)
            {
                Adp = new SqlDataAdapter("sp_extractdate", Con);
                Adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                Adp.SelectCommand.Parameters.AddWithValue("@Start", txtStart.Text);
                Adp.SelectCommand.Parameters.AddWithValue("@End", txtEnd.Text);
                DataSet DS = new DataSet();
                Adp.Fill(DS, "E");
                gvData.DataSource = DS.Tables["E"];
                gvData.DataBind();
            }
            
            else if(rdbDeptno.Checked)
            {
                Adp = new SqlDataAdapter("sp_getDeptDetails", Con);
                Adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                Adp.SelectCommand.Parameters.AddWithValue("@Deptno", ddlDeptNo.SelectedValue);
                DataSet DS = new DataSet();
                Adp.Fill(DS, "E");
                gvData.DataSource = DS.Tables["E"];
                gvData.DataBind();
            }
        }

        
    }
}