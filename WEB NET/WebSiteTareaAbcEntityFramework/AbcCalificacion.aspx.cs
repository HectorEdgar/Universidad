using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AbcCalificacion : System.Web.UI.Page
{
    EscuelaDs escuela = new EscuelaDs();
    protected void Page_Load(object sender, EventArgs e)
    {

        
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        

        try
        {
            Calificacion calificacion = new Calificacion();

            calificacion.NotId = Convert.ToInt16(txtAltaCalificacionID.Text);
            calificacion.NotNota = txtAltaCalificacionCalificacion.Text;
            calificacion.AluId = escuela.getAlumnos(0, escuela.getAlumnosCount()).Where(p => p.AluNombre.Equals(txtAltaCalificacionListBox.SelectedItem.Text)).Select(p => p.AluId).First();
            calificacion.MatId = escuela.getMaterias(0, escuela.getMateriasCount()).Where(p => p.MatNombre.Equals(txtAltaCalificacionListbox2.SelectedItem.Text)).Select(p => p.MatId).First();
            
         
            escuela.addCalificacion(calificacion);

            Response.Redirect("AbcCalificacion.aspx");
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
            var aux = escuela.findCalificacion(txtActualizacionCalificacionListBox1.Text, txtActualizacionCalificacionListBox2.Text);
            txtActualizacionCalificacionID.Text = aux.NotId.ToString();
            txtActualizacionCalificacionCalificacion.Text = aux.NotNota;
            txtActualizacionCalificacionCalificacion.Enabled = true;
        }
        catch (Exception)
        {
            Response.Redirect("AbcCalificacion.aspx");
        }
    
        
    }

    protected void Button2_Click(object sender, EventArgs e)
    {

        try
        {
            Calificacion calificacion = new Calificacion();

            calificacion.NotId = Convert.ToInt16(txtActualizacionCalificacionID.Text);
            calificacion.NotNota = txtActualizacionCalificacionCalificacion.Text;
            calificacion.AluId = escuela.getAlumnos(0, escuela.getAlumnosCount()).Where(p => p.AluNombre.Equals(txtActualizacionCalificacionListBox1.SelectedValue)).Select(p => p.AluId).First();
            calificacion.MatId = escuela.getMaterias(0, escuela.getMateriasCount()).Where(p => p.MatNombre.Equals(txtActualizacionCalificacionListBox2.SelectedValue)).Select(p => p.MatId).First();
            escuela.updateCalificacion(Convert.ToInt16(txtActualizacionCalificacionID.Text), calificacion);
            Response.Redirect("AbcCalificacion.aspx");
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
            escuela.deleteCalificacion(Convert.ToInt16(txtActualizacionCalificacionID.Text));
            Response.Redirect("AbcCalificacion.aspx");
        }
        catch (Exception ex)
        {
            Response.Write("<script language=javascript>alert('" + ex.Message + "');</script>");
        }

    }
}