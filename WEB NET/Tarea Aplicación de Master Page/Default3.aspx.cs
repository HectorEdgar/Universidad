using System;
using System.Collections.Generic;
using System.Data.Objects;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        

        DropDownList dropNewUsuario = (DropDownList)GridView1.FooterRow.FindControl("dropNewUsuario");
       
        dropNewUsuario.SelectedValue= dropNewUsuario.Items.FindByText(usuarioActivo.Usuario.usuario1).ToString();
        dropNewUsuario.Enabled = false;

    }



    protected void linkAgregar_Click(object sender, EventArgs e)
    {


        TextBox txtNewId = (TextBox)GridView1.FooterRow.FindControl("txtNewId");
        TextBox txtNewNombre = (TextBox)GridView1.FooterRow.FindControl("txtNewNombre");
        TextBox txtNewDescripcion = (TextBox)GridView1.FooterRow.FindControl("txtNewDescripcion");
        DropDownList dropNewUsuario = (DropDownList)GridView1.FooterRow.FindControl("dropNewUsuario");



        using (ComentariosEntities entity = new ComentariosEntities())
        {
            Post post = new Post();

            try
            {
                post.idpost = Convert.ToInt16(txtNewId.Text);
            }
            catch (Exception)
            {

                post.idpost = 0;
            }


            post.nombre = txtNewNombre.Text;
            post.descripcion = txtNewDescripcion.Text;

            post.usuario = dropNewUsuario.SelectedValue;


            try
            {
                entity.Posts.Add(post);
                entity.SaveChanges();
                GridView1.DataBind();
                Response.Redirect("Default3.aspx");
            }
            catch (Exception)
            {

                entity.Posts.Remove(post);
            }
        }



    }

    protected void botonLinkAgregarComentario_Click(object sender, EventArgs e)
    {
        TextBox txtNewIdComentario = (TextBox)GridView2.FooterRow.FindControl("txtNewIdComentario");
        DropDownList droplComentarioUsuario = (DropDownList)GridView2.FooterRow.FindControl("droplComentarioUsuario");
        DropDownList droplComentarioPost = (DropDownList)GridView2.FooterRow.FindControl("droplComentarioPost");
        TextBox txtComentario = (TextBox)GridView2.FooterRow.FindControl("txtComentario");

        using (ComentariosEntities entity = new ComentariosEntities())
        {
            Comentario comentario = new Comentario();
            try
            {
                comentario.idcomentario = Convert.ToInt16(txtNewIdComentario.Text);
            }
            catch (Exception)
            {

                comentario.idcomentario = 0;
            }
            comentario.usuario = droplComentarioUsuario.SelectedValue;
            
            comentario.comentario1 = txtComentario.Text;
            
            comentario.hora = DateTime.Now; 
            comentario.idpost = Convert.ToInt16(droplComentarioPost.SelectedValue);
            try
            {
                entity.Comentarios.Add(comentario);
                entity.SaveChanges();
                GridView2.DataBind();
                Response.Redirect("Default3.aspx");
            }
            catch (Exception ex)
            {
                entity.Comentarios.Remove(comentario);
                Response.Write(ex.Message);


            }
        }
    }

    protected void GridView1_DataBound(object sender, EventArgs e)
    {
        DropDownList dropNewUsuario = (DropDownList)GridView1.FooterRow.FindControl("dropNewUsuario");
        dropNewUsuario.SelectedValue = dropNewUsuario.Items.FindByText(usuarioActivo.Usuario.usuario1).ToString();
        dropNewUsuario.Enabled = false;

    }



    protected void GridView2_DataBound(object sender, EventArgs e)
    {
        DropDownList droplComentarioUsuario = (DropDownList)GridView2.FooterRow.FindControl("droplComentarioUsuario");
        droplComentarioUsuario.SelectedValue = droplComentarioUsuario.Items.FindByText(usuarioActivo.Usuario.usuario1).ToString();
        droplComentarioUsuario.Enabled = false;
    }
}