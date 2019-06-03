using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default4 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (IsValid)
        {
            Response.Redirect("Default5.aspx");
        }
    }

    protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
    {
        int valor;
        valor = int.Parse(TextBox1.Text);
        if (valor%5==0)
        {
            args.IsValid = true;
        }
        else
        {
            args.IsValid = false;
        }
    }
}