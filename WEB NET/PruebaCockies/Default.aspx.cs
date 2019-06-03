using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        HttpCookie cookie1 = new HttpCookie("edad", TextBox1.Text);
        cookie1.Expires = new DateTime(2018, 12, 25);
        Response.Cookies.Add(cookie1);
        Label1.Text = "Se creó la cookie";
    }
}