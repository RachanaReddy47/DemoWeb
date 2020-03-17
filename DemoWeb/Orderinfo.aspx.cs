using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoWeb
{
    public partial class Orderinfo : System.Web.UI.Page
    {
        DemoEntities D = null;
        protected void Page_Load(object sender, EventArgs e)
        {
           if(!IsPostBack)
            {
                bind();
            }
            D = new DemoEntities();
            var V = from O in D.OrderInfoes
                    select O;
            GridView.DataSource = V.ToList();
            GridView.DataBind();
            DetailsView.DataSource = V.ToList();
            DetailsView.DataBind();
        }
        private void bind()
        {
            D = new DemoEntities();
            var V = from O in D.OrderInfoes
                    select O;

            FormView.DataSource = V.ToList();
            FormView.DataBind();


        }

        protected void FView_PageIndexChanging(object sender, FormViewPageEventArgs e)
        {
            FormView.PageIndex = e.NewPageIndex;
            bind();
        }

        
            
        protected void GridView_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView.PageIndex = e.NewPageIndex;
            GridView.DataBind();
        }

        protected void DetailsView1_PageIndexChanging(object sender, DetailsViewPageEventArgs e)
        {
            DetailsView.PageIndex = e.NewPageIndex;
            DetailsView.DataBind();
        }
    }
}