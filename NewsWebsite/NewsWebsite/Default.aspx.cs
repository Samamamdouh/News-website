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
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-J2F795J\\SQLEXPRESS;Initial Catalog=News;Integrated Security=True");
            con.Open();
            SqlCommand cm = new SqlCommand("select id , title from articles",con);
            SqlDataReader dr = cm.ExecuteReader();
            string strnews = "";
            while (dr.Read())
                strnews += "<a href=Detailes.aspx?x="+ dr[0] +">"  + dr[1] +"</a>&nbsp;&nbsp;&nbsp;";

            news.InnerHtml = "<marquee id=title_news onmouseover=title_news.stop(); onmouseout=title_news.start();>" + strnews + "</marquee>"; // عرض عناوين الاخبار فى شريط متحرك
            con.Close();
        }
    }
}