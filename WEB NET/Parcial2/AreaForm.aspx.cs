using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Areas : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        TextBox txtboxCodigo = (TextBox)GridView1.FooterRow.FindControl("txtCodigo");
        TextBox txtboxNombre = (TextBox)GridView1.FooterRow.FindControl("txtNombre");
        TextBox txtboxTiempo = (TextBox)GridView1.FooterRow.FindControl("txtTiempo");

        using (bibliotecaEntities entity = new bibliotecaEntities())
        {
            Area area = new Area();
            area.areCodigo = Convert.ToInt16(txtboxCodigo.Text);
            area.areNombre = txtboxNombre.Text;
            area.areTiempo = Convert.ToInt16(txtboxTiempo.Text);

            try
            {
                entity.Areas.Add(area);
                entity.SaveChanges();
                Response.Redirect("AreaForm.aspx");
            }
            catch (Exception exe)
            {

                entity.Areas.Remove(area);
            }
            

        }
    }

 
}