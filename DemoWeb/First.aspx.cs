using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoWeb
{
    public partial class First : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["User"] != null)
                Label2.Text = Session["User"].ToString();
            else
                Response.Redirect("LoginPage.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EMPDATA E = new EMPDATA();
            E.EMPNO = int.Parse(txtEmployeeNo.Text);
            E.ENAME = txtEmployeeName.Text;
            E.JOB = txtJob.Text;
            E.HIREDATE = DateTime.Parse(txtHireDate.Text);
            E.MGR = int.Parse(txtMGR.Text);
            E.SAL = int.Parse(txtSalary.Text);
            E.COMM= int.Parse(txtCommission.Text);
            E.DEPTNO = int.Parse(txtDepartmentNo.Text);
            Session["E"] = E;
            Response.Redirect("Confirm.aspx");
        }
    }
}