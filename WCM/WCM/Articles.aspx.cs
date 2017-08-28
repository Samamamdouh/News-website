using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
namespace WCM
{
    public partial class Articles : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_article_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-J2F795J\\SQLEXPRESS;Initial Catalog=News;Integrated Security=True");
            con.Open();
            SqlCommand cm = new SqlCommand("insert into articles(title,details,photo) values (@title,@details,@photo)",con);
            cm.Parameters.Add("@title", txtTitle.Text);
            cm.Parameters.Add("@details", txtDetails.Text);
            string str_image = System.IO.Path.GetFileName(image.PostedFile.FileName);
            cm.Parameters.Add("@photo", str_image);
            cm.ExecuteNonQuery();
            con.Close();
            image.PostedFile.SaveAs(Server.MapPath("images\\")+str_image);
        }
    }
}