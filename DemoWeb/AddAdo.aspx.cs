using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Core.Objects;

namespace DemoWeb
{
    public partial class Ado : System.Web.UI.Page
    {
        DemoEntities D = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            D = new DemoEntities();
        }
        //Entity without StoredProcedures
        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                EMPDATA E = new EMPDATA();
                E.EMPNO = int.Parse(txtEmployeeNo.Text);
                E.ENAME = txtEmployeeName.Text;
                E.JOB = txtJob.Text;
                E.MGR = int.Parse(txtMGR.Text);
                E.HIREDATE = DateTime.Parse(txtHireDate.Text);
                E.SAL = int.Parse(txtSalary.Text);
                E.COMM = int.Parse(txtCommission.Text);
                E.DEPTNO = int.Parse(txtDepartmentNo.Text);
                D.EMPDATAs.Add(E);
                D.SaveChanges();
            }
            catch(DbUpdateException E1)
            {
                SqlException ex = E1.GetBaseException() as SqlException;
                if (ex.Message.Contains("EMP_PK"))
                    Label1.Text = "No Duplicate Empno";
                else if (ex.Message.Contains("FK__EMPDATA_DEPTNO"))
                    Label1.Text = "No Duplicate Deptno";
                else
                Label1.Text = ex.Message;
            }
        }
        //With Stored Procedures
        protected void Button2_Click(object sender, EventArgs e)
        {
            ObjectParameter ob = new ObjectParameter("OP", typeof(string));
            D.sp_AddEmp(int.Parse(txtEmployeeNo.Text), txtEmployeeName.Text, txtJob.Text, int.Parse(txtMGR.Text), 
                        DateTime.Parse(txtHireDate.Text),int.Parse(txtSalary.Text), int.Parse(txtCommission.Text), 
                        int.Parse(txtDepartmentNo.Text), ob);
            Label1.Text = ob.Value.ToString();

        }
    }
}