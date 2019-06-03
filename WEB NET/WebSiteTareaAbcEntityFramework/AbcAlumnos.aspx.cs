using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AbcEscuela : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    EscuelaDs escuela = new EscuelaDs();
    protected void Button1_Click(object sender, EventArgs e)
    {
        

        
        try
        {
            Alumno alumno = new Alumno();

            alumno.AluId = Convert.ToInt16(txtAlumnoId.Text);
            alumno.AluNombre = txtAlumnoNombre.Text;
            alumno.AluApellido = txtAlumnoApellido.Text;
            alumno.AluEdad = Convert.ToInt16(txtAlumnoEdad.Text);
            alumno.AluDireccion = txtAlumnoDireccion.Text;
            escuela.addAlumno(alumno);
            Response.Redirect("AbcAlumnos.aspx");
            
        }
        catch (Exception ex)
        {

            Response.Write("<script language=javascript>alert('"+ex.Message+"');</script>");
            
        }
       
        

    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        var aux=escuela.findAlumno(txtAlumnoNombre0.Text,txtAlumnoApellido0.Text);

        try
        {
            txtAlumnoId0.Text = aux.AluId.ToString();
            txtAlumnoNombre0.Text = aux.AluNombre;
            txtAlumnoEdad0.Text = aux.AluEdad.ToString();
            txtAlumnoApellido0.Text = aux.AluApellido;
            txtAlumnoDireccion0.Text = aux.AluDireccion;



            txtAlumnoEdad0.Enabled = true;
            txtAlumnoApellido0.Enabled = true;
            txtAlumnoDireccion0.Enabled = true;
        }
        catch (Exception)
        {     

        }
    
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        Alumno alumno = new Alumno();
        alumno.AluId =Convert.ToInt16(txtAlumnoId0.Text);
        alumno.AluNombre=txtAlumnoNombre0.Text;
        alumno.AluEdad= Convert.ToInt16(txtAlumnoEdad0.Text);
        alumno.AluApellido=txtAlumnoApellido0.Text;
        alumno.AluDireccion = txtAlumnoDireccion0.Text ;
        try
        {
            escuela.updateAlumno(Convert.ToInt16(txtAlumnoId0.Text), alumno);
            Response.Redirect("AbcAlumnos.aspx");
        }
        catch (Exception ex )
        {
            Response.Write("<script language=javascript>alert('" + ex.Message + "');</script>");
        }
        
    }

    protected void Button3_Click(object sender, EventArgs e)
    {

        try
        {
            escuela.deleteAlumno(Convert.ToInt16(txtAlumnoId0.Text));
            Response.Redirect("AbcAlumnos.aspx");
        }
        catch (Exception ex)
        {
            Response.Write("<script language=javascript>alert('" + ex.Message + "');</script>");
        }
    }
}