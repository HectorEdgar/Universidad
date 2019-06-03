using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class LibrosForm : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {


        TextBox txtboxCodigo = (TextBox)GridView1.FooterRow.FindControl("txtcodigo");
        DropDownList dropCodigo = (DropDownList)GridView1.FooterRow.FindControl("dropCodigo");
        TextBox txtboxNombreLibro = (TextBox)GridView1.FooterRow.FindControl("txtNombreLibro");
        TextBox txtboxNumPaginas = (TextBox)GridView1.FooterRow.FindControl("txtNumPaginas");
        TextBox txtboxAutor = (TextBox)GridView1.FooterRow.FindControl("txtAutor");
        TextBox txtboxEditorial = (TextBox)GridView1.FooterRow.FindControl("txtEditorial");



        using (bibliotecaEntities entity = new bibliotecaEntities())
        {
            Libro libro = new Libro();

            libro.libCodigo = Convert.ToInt16(txtboxCodigo.Text);
            libro.areCodigo = Convert.ToInt16(dropCodigo.SelectedValue);
            libro.libNombre = txtboxNombreLibro.Text;
            libro.libNumPag = Convert.ToInt16(txtboxNumPaginas.Text);
            libro.libAutor = txtboxAutor.Text;
            libro.libEditorial = txtboxEditorial.Text;


            try
            {
                entity.Libros.Add(libro);
                entity.SaveChanges();
                Response.Redirect("LibrosForm.aspx");
            }
            catch (Exception ex)
            {
                entity.Libros.Remove(libro);
            }
        }
    }
}