using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WCM
{
    public partial class settings : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text="Welcome "+Session["Username"];
        }

        protected void link_register_Click(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx");
        }

        protected void link_article_Click(object sender, EventArgs e)
        {
            Response.Redirect("Articles.aspx");
        }

        protected void link_edit_Click(object sender, EventArgs e)
        {
            Response.Redirect("Edite_Articles.aspx");
        }
    }
}