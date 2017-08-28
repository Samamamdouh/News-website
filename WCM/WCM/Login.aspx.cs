using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;// لو استخدمت dataset
using System.Data.SqlClient;
namespace WCM
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_login_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-J2F795J\\SQLEXPRESS;Initial Catalog=News;Integrated Security=True");
            SqlCommand cm = new SqlCommand("select * from Users where username=@username and password=@password",con);
            cm.Parameters.Add("@username",txt_user.Text);
            cm.Parameters.Add("@password", txt_password.Text);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataSet ds = new DataSet();
            da.Fill(ds, "Users");
            if (ds.Tables["Users"].Rows.Count == 0)
                Response.Write("Invalid Username or Password");
            else
            {
                Session["Username"] = txt_user.Text;
                Response.Redirect("settings.aspx");
            }
        }
    }
}