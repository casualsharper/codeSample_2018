using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BL;

namespace WebGUI2
{
    public partial class Mailer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void MailNews(object sender, EventArgs e)
        {
            SendGrid.SendMail(email.Text);
            loggerView.DataBind();
        }
        protected void BackToList(object sender, EventArgs e)
        {
            Server.Transfer("default.aspx", true);
        }       
    }
}