using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proje.WP.Web
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Proje.WP.Business.musteri guvenlik = new Business.musteri();

           string sonuc = guvenlik.GuvenlikKontrol(TextBox1.Text, TextBox2.Text);

            if (sonuc == "tamam")
                Response.Redirect("Index1.aspx");
            else
                Label3.Text = sonuc;

        }
    }
}