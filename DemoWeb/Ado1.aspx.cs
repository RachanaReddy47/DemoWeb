using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoWeb
{
    public partial class Ado1 : System.Web.UI.Page
    {
        DemoEntities D = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            D = new DemoEntities();
            if (!IsPostBack)
            {
                txtStart.Enabled = false;
                txtEnd.Enabled = false;
                ddlDeptNo.Enabled = false;
                var D1 = from d1 in D.DEPTDATAs
                         select d1;
                List<DEPTDATA> L = D1.ToList();
                ddlDeptNo.DataSource = L;
                ddlDeptNo.DataTextField = "Dname";
                ddlDeptNo.DataValueField = "Deptno";
                ddlDeptNo.DataBind();
            }

        }

        protected void btnExtract_Click(object sender, EventArgs e)
        {
            if (rdbHiredate.Checked)
            {
                DateTime D1 = DateTime.Parse(txtStart.Text);
                DateTime D2 = DateTime.Parse(txtEnd.Text);
                var E = from d1 in D.EMPDATAs
                        where d1.HIREDATE >= D1 && d1.HIREDATE <= D2
                        select d1;

                List<EMPDATA> Lemp = E.ToList();
                gvData.DataSource = Lemp;
                gvData.DataBind();
            }
            else if (rdbDeptno.Checked)
            {
                int dno = int.Parse(ddlDeptNo.SelectedValue);
                var E = from d in D.EMPDATAs
                        where d.DEPTNO == dno
                        select d;

                List<EMPDATA> Demp = E.ToList();
                gvData.DataSource = Demp;
                gvData.DataBind();


            }
        }

        protected void rdbHiredate_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbHiredate.Checked)
            {
                txtStart.Enabled = true;
                txtEnd.Enabled = true;
                ddlDeptNo.Enabled = false;
            }

        }

        protected void rdbDeptno_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbDeptno.Checked)
            {
                txtStart.Enabled = false;
                txtEnd.Enabled = false;
                ddlDeptNo.Enabled = true;
            }
        }
    }
}