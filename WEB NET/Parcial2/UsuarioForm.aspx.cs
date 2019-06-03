using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class UsuarioForm : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        TextBox txtDocumento = (TextBox)GridView1.FooterRow.FindControl("txtDocumento");
        TextBox txtNombre = (TextBox)GridView1.FooterRow.FindControl("txtNombre");
        TextBox txtDireccion = (TextBox)GridView1.FooterRow.FindControl("txtDireccion");
        TextBox txtTelefono = (TextBox)GridView1.FooterRow.FindControl("txtTelefono");
        TextBox txtEstado = (TextBox)GridView1.FooterRow.FindControl("txtEstado");
        TextBox txtCorreo = (TextBox)GridView1.FooterRow.FindControl("txtCorreo");

        using (bibliotecaEntities entity = new bibliotecaEntities())
        {
            Usuario usuario = new Usuario();

            usuario.usuDocumento = Convert.ToInt16(txtDocumento.Text);
            usuario.usuNombre = txtNombre.Text;
            usuario.usuDireccion = txtDireccion.Text;
            usuario.usuTelefono = txtTelefono.Text;
            usuario.usuEstado = txtEstado.Text;
            usuario.usuCorreo = txtCorreo.Text;

            try
            {
                entity.Usuarios.Add(usuario);
                entity.SaveChanges();
                Response.Redirect("UsuarioForm.aspx");
            }
            catch (Exception)
            {
                
                entity.Usuarios.Remove(usuario);
            }
            
        }

    }
}