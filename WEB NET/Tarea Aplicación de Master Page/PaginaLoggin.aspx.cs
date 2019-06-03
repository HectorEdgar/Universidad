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
        usuarioActivo usuario = new usuarioActivo();
    }

    
    
    protected void Button1_Click(object sender, EventArgs e)
    {
        using (ComentariosEntities entitie = new ComentariosEntities())
        {

            
            try
            {
                usuarioActivo.Usuario = entitie.Usuarios.Where(p => p.usuario1.Equals(TextBox1.Text)).Where(p => p.password.Equals(TextBox2.Text)).First();
            }
            catch (Exception)
            {

                usuarioActivo.Usuario = null;
            }
            

            if (usuarioActivo.Usuario != null)
            {
                Response.Redirect("PaginaPrincipal.aspx");
            }
            else
            {
                Response.Write("<script language=javascript>alert('Usuario o Contraseña incorrectos');</script>");
                Response.Redirect("PaginaLoggin.aspx");
            }
        }
    }
}