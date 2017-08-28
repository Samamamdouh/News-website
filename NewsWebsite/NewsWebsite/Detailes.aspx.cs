using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace NewsWebsite
{
    public partial class Detailes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            { 
               SqlConnection con = new SqlConnection("Data Source=DESKTOP-J2F795J\\SQLEXPRESS;Initial Catalog=News;Integrated Security=True");
               con.Open();
               SqlCommand cm = new SqlCommand("select  * from articles where id="+ Request.Params["x"], con);
               SqlDataReader dr = cm.ExecuteReader();
               while (dr.Read())
                {
                  detail.InnerHtml +="<b>"  + dr["title"]+  "</b><br>";
                  detail.InnerHtml +=  dr["details"] + "<br>"; 
                  detail.InnerHtml += "<img src=images/"+ dr["photo"] + " /><br>";
                }
               con.Close();
               con.Open();
               SqlCommand cm2 = new SqlCommand("select  * from comments where id_article=" + Request.Params["x"], con);
               SqlDataReader dr2 = cm2.ExecuteReader();
               while (dr2.Read())
               {
                   comments.InnerHtml += "<b>" + dr2["name"] + " : </b>" + dr2["comment"] + "<br>";
               }
               con.Close();
            }
        }

        protected void btn_comment_Click(object sender, EventArgs e)
        {
            comments.InnerHtml += "<b>" + txt_name.Text + " : </b>" + txt_comment.Text + "<br>";
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-J2F795J\\SQLEXPRESS;Initial Catalog=News;Integrated Security=True");
            con.Open();
            SqlCommand cm = new SqlCommand("insert into comments (name,comment,id_article)values(@name,@comment,@id_article)", con);
            cm.Parameters.Add("name",txt_name.Text);
            cm.Parameters.Add("comment", txt_comment.Text);
            cm.Parameters.Add("id_article", Request.Params["x"]);
            cm.ExecuteNonQuery();
            con.Close();
            txt_name.Text = "";
            txt_comment.Text = "";
        }
    }
}