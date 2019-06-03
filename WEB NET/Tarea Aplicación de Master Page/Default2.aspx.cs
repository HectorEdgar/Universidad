using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }





    protected void Button1_Click(object sender, EventArgs e)
    {
        using (ComentariosEntities entiti = new ComentariosEntities())
        {
            Usuario usuario = new Usuario();
            usuario.usuario1 = txtUsuario.Text;
            usuario.password = txtContrasena.Text;
            usuario.nombre = txtNombre.Text;
            usuario.apellido = txtApellido.Text;
            usuario.correo = txtCorreo.Text;
            usuario.telefono = txtTelefono.Text;
            try
            {
                usuario.sexo = txtSexo.Text[0].ToString();
            }
            catch (Exception)
            {

                usuario.sexo = "h";
            }
            


            try
            {
                usuario.pais = Convert.ToInt16(txtPais.Text);
            }
            catch (Exception)
            {
                usuario.pais = 0;
            }


            try
            {
                entiti.Usuarios.Add(usuario);
                entiti.SaveChanges();
                Response.Redirect("Default2.aspx");

            }
            catch (Exception)
            {
                entiti.Usuarios.Remove(usuario);
            }
        }
    }
}