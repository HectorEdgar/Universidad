using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AbcMateria : System.Web.UI.Page
{
    EscuelaDs escuela = new EscuelaDs();
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {



        try
        {
            Materia materia = new Materia();

            materia.MatId = Convert.ToInt16(txtAltaMateriaId.Text);
            materia.MatNombre = txtAltaMateriaNombre.Text;

            escuela.addMateria(materia);
            Response.Redirect("AbcMateria.aspx");
        }
        catch (Exception ex)
        {

            Response.Write("<script language=javascript>alert('" + ex.Message + "');</script>");
        }
    }

    protected void Button3_Click(object sender, EventArgs e)
    {


        try
        {
            var aux = escuela.findMateria(txtActualizarMateriaNombre.Text);
            txtActualizarMateriaId.Text = aux.MatId.ToString();
            txtActualizarMateriaNombre.Text = aux.MatNombre;
        }
        catch (Exception ex)
        {

            Response.Write("<script language=javascript>alert('" + ex.Message + "');</script>");
        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {

        try
        {
            Materia materia = new Materia();

            materia.MatId = Convert.ToInt16(txtActualizarMateriaId.Text);
            materia.MatNombre = txtActualizarMateriaNombre.Text;

            escuela.updateMateria(Convert.ToInt16(txtActualizarMateriaId.Text), materia);
            Response.Redirect("AbcMateria.aspx");
        }
        catch (Exception ex)
        {

            Response.Write("<script language=javascript>alert('" + ex.Message + "');</script>");
        }

    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        try
        {
            escuela.deleteMateria(Convert.ToInt16(txtActualizarMateriaId.Text));
            Response.Redirect("AbcMateria.aspx");
        }
        catch (Exception ex)
        {
            Response.Write("<script language=javascript>alert('" + ex.Message + "');</script>");
        }
    }
}