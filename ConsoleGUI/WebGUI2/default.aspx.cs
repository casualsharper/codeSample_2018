using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BL;
using Domain;

namespace WebGUI2
{
    public partial class HomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {   
        }
        protected void FetchNews(object sender, EventArgs e)
        {
            NewsFetcher.GetLatestTopics();
            articleView.DataBind();
        }
        protected void SendNews(object sender, EventArgs e)
        {
            Server.Transfer("mailer.aspx", true);
        }
        protected void articleView_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            articleView.PageIndex = e.NewPageIndex;
            articleView.DataBind();
        }

        protected void articleView_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = articleView.SelectedRow;
        }
    }
}