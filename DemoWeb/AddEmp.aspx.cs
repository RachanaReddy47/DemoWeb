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
   
    public partial class AddEmp : System.Web.UI.Page
    {
        SqlConnection Con = null;
        SqlDataAdapter Adp = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            Con = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlCon"].ToString());
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Adp = new SqlDataAdapter("sp_AddEmp", Con);
            Adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            Adp.SelectCommand.Parameters.AddWithValue("@Eno", int.Parse(txtEmployeeNo.Text));
            Adp.SelectCommand.Parameters.AddWithValue("@Ename", txtEmployeeName.Text);
            Adp.SelectCommand.Parameters.AddWithValue("@Job", txtJob.Text);
            Adp.SelectCommand.Parameters.AddWithValue("@Mgr", int.Parse(txtMGR.Text));
            Adp.SelectCommand.Parameters.AddWithValue("@hdate",DateTime.Parse(txtHireDate.Text));
            Adp.SelectCommand.Parameters.AddWithValue("@sal",int.Parse(txtSalary.Text));
            Adp.SelectCommand.Parameters.AddWithValue("@Com",int.Parse(txtCommission.Text));
            Adp.SelectCommand.Parameters.AddWithValue("@Dno",int.Parse(txtDepartmentNo.Text));

            SqlParameter P = new SqlParameter("@OP", SqlDbType.NVarChar,200);
            P.Direction = ParameterDirection.Output;
            Adp.SelectCommand.Parameters.Add(P);
            DataSet DS = new DataSet();
            Adp.Fill(DS, "E");
            Label1.Text= P.Value.ToString() ;

            txtEmployeeNo.Text = " ";
            txtEmployeeName.Text = " ";
            txtJob.Text = " ";
            txtMGR.Text = " ";
            txtHireDate.Text = " ";
            txtSalary.Text = " ";
            txtCommission.Text = " ";
            txtDepartmentNo.Text = " ";









        }
    }
}