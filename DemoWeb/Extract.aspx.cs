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
    public partial class Extract : System.Web.UI.Page
    {
        SqlConnection Con = null;
        SqlDataAdapter Adp = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            
            Con = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlCon"].ToString());         
            Adp = new SqlDataAdapter("sp_ExtraxtDept", Con);
            if (!IsPostBack)
            {
                Adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataSet DS = new DataSet();
                Adp.Fill(DS, "D");
                ddlDeptno.DataSource = DS.Tables["D"];
                ddlDeptno.DataTextField = "Dname";
                ddlDeptno.DataValueField = "Deptno";
                ddlDeptno.DataBind();
            }

        }

        

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Adp = new SqlDataAdapter("sp_getDeptDetails", Con);
            //Adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            //Adp.SelectCommand.Parameters.AddWithValue("@Deptno", ddlDeptno.SelectedValue);
            //DataSet DS = new DataSet();
            //Adp.Fill(DS, "E");
            //gvData.DataSource = DS.Tables["E"];
            //gvData.DataBind();

        }

        protected void ddlDeptno_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            Adp = new SqlDataAdapter("sp_getDeptDetails", Con);
            Adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            Adp.SelectCommand.Parameters.AddWithValue("@Deptno", ddlDeptno.SelectedValue);
            DataSet DS = new DataSet();
            Adp.Fill(DS, "E");
            gvData.DataSource = DS.Tables["E"];
            gvData.DataBind();

        }
    }
}