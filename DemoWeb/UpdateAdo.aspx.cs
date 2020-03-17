using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoWeb
{
    public partial class UpdateAdo : System.Web.UI.Page
    {
        DemoEntities D = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            D = new DemoEntities();
        }

        protected void Update_Click(object sender, EventArgs e)
        {
            int eno = int.Parse(txtEmployeeNo.Text);
            var E = from E1 in D.EMPDATAs
                    where E1.EMPNO == eno
                    select E1;
            EMPDATA emp = E.First();
            int c = 0;
            bool b = int.TryParse(txtCommission.Text, out c);
            emp.ENAME = txtEmployeeName.Text;
            emp.JOB = txtJob.Text;
            emp.MGR=int.Parse(txtMGR.Text);
            emp.HIREDATE =DateTime.Parse(txtHireDate.Text);
            emp.SAL=int.Parse(txtSalary.Text) ;
            if(c!=0)
            emp.COMM=c ;
            emp.DEPTNO=int.Parse(txtDepartmentNo.Text);
            D.SaveChanges();



        }

        protected void txtEmployeeNo_TextChanged(object sender, EventArgs e)
        {
            int eno = int.Parse(txtEmployeeNo.Text);

            var E = from E1 in D.EMPDATAs
                    where E1.EMPNO == eno
                    select E1;
            EMPDATA emp = E.First();
            string hd = DateTime.Parse(emp.HIREDATE.ToString()).ToString("yyyy-MM-dd");
            txtEmployeeName.Text = emp.ENAME;
            txtJob.Text = emp.JOB;
            txtMGR.Text = emp.MGR.ToString();
            txtHireDate.Text = hd;
            txtSalary.Text = emp.SAL.ToString();
            txtCommission.Text = emp.COMM.ToString();
            txtDepartmentNo.Text = emp.DEPTNO.ToString();

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int eno = int.Parse(txtEmployeeNo.Text);

            var E = from E1 in D.EMPDATAs
                    where E1.EMPNO == eno
                    select E1;
            EMPDATA emp = E.First();
            D.EMPDATAs.Remove(emp);
            D.SaveChanges();
        }
    }
}