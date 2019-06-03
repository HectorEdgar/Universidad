using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (this.IsPostBack == false)
        {
            if (Request.Cookies["mail"] != null)
            {
                TextBox1.Text = Request.Cookies["mail"].Value;
            }
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        HttpCookie cookie1 = new HttpCookie("mail", TextBox1.Text);
        cookie1.Expires = new DateTime(2018, 12, 25);
        Response.Cookies.Add(cookie1);
        Response.Redirect("Default4.aspx");
    }
}