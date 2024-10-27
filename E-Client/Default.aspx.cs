using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace E_Client
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnPutClient_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/CreateClientPage.aspx");
        }
        protected void btnListClient_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/ListClientPage.aspx");
        }
    }
}