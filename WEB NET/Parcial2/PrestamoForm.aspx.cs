using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PrestamoFormn : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        using (BibliotecaDataContext context = new BibliotecaDataContext())
        {

            dropPrestamoUsuario.DataSource = context.Usuarios2;
            dropPrestamoUsuario.DataValueField = "usuNombre";
            dropPrestamoUsuario.DataTextField = "usuNombre";

            dropPrestamoLibro.DataSource = context.Libros2;
            dropPrestamoLibro.DataValueField = "libNombre";
            dropPrestamoLibro.DataTextField = "libNombre";

            GridView1.DataSource = from presta in context.DetallePrestamos2
                                   select new
                                   {
                                       presta.Libros2.libNombre,
                                       presta.dtpCantidad,
                                       presta.Prestamos2.preFecha,
                                       presta.dtpFechaFin
                                   };
            GridView1.DataBind();
            dropPrestamoUsuario.DataBind();
            dropPrestamoLibro.DataBind();

            llenarDropDownListDevolucion();

        }
    }
    Prestamos2 prestamo;
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (RegularExpressionValidator1.IsValid)
        {
            using (BibliotecaDataContext context = new BibliotecaDataContext())
            {
                prestamo = new Prestamos2();
                //prestamo.preCodigo = 0;
                prestamo.preFecha = DateTime.Parse(txtPrestamoFecha.Text);
                prestamo.usuDocumento = context.Usuarios2.Where(p => p.usuNombre.Equals(dropPrestamoUsuario.SelectedValue)).Select(p => p.usuDocumento).First();

                try
                {
                    context.Prestamos2.InsertOnSubmit(prestamo);
                    context.SubmitChanges();


                    Label1.Text = "Se ha registrado el prestamo";
                    Button3.Enabled = true;
                    calcularFecha();


                }
                catch (Exception ex)
                {
                    Label1.Text = "Ha ocurrido un error";
                    Button3.Enabled = false;

                }
            }
        }


    }

    private void calcularFecha()
    {
        using (BibliotecaDataContext context = new BibliotecaDataContext())
        {
            Areas2 area = context.Libros2.Where(p => p.libNombre.Equals(dropPrestamoLibro.SelectedValue)).Select(p => p.Areas2).First();
            DateTime fechaDev = prestamo.preFecha;
            DateTime generalTime2 = new DateTime(fechaDev.Year, fechaDev.Month, fechaDev.Day, 0, 0, 0);

            TimeSpan days = new TimeSpan(24 * area.areTiempo, 0, 0);
            generalTime2 += days;

            txtPrestamoFechaEntrega.Text = generalTime2.Day + "/" + generalTime2.Month + "/" + generalTime2.Year;


        }
    }
    protected void dropPrestamoLibro_SelectedIndexChanged(object sender, EventArgs e)
    {
        calcularFecha();

    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        if (RangeValidator1.IsValid)
        {
            using (BibliotecaDataContext context = new BibliotecaDataContext())
            {
                DetallePrestamos2 detalle = new DetallePrestamos2();

                detalle.dtpCantidad = txtCantida.Text;
                detalle.dtpFechaFin = DateTime.Parse(txtPrestamoFechaEntrega.Text);
                detalle.dtpFechaDev = DateTime.Parse("01/01/1999");
                detalle.libCodigo = context.Libros2.Where(p => p.libNombre.Equals(dropPrestamoLibro.SelectedValue)).Select(p => p.libCodigo).First();

                //detalle.preCodigo = prestamo.preCodigo;
                try
                {
                    detalle.preCodigo = context.Prestamos2.Where(p => p.preFecha.CompareTo(DateTime.Parse(txtPrestamoFecha.Text)) == 0).Where(p => p.usuDocumento.Equals(
                        context.Usuarios2.Where(p1 => p1.usuNombre.Equals(dropPrestamoUsuario.SelectedValue)).Select(p1 => p1.usuDocumento).First()
                        )).Select(p => p.preCodigo).First();

                    context.DetallePrestamos2.InsertOnSubmit(detalle);
                    context.SubmitChanges();

                    GridView1.DataSource = from presta in context.DetallePrestamos2
                                           select new
                                           {
                                               presta.Libros2.libNombre,
                                               presta.dtpCantidad,
                                               presta.Prestamos2.preFecha,
                                               presta.dtpFechaFin
                                           };
                    GridView1.DataBind();

                }
                catch (Exception)
                {
                    Label2.Text = "Ha ocurrido un error";
                    //throw;
                }



            }
        }
    }

    protected void dropPrestamoLibro_DataBinding(object sender, EventArgs e)
    {

        calcularFecha();
    }

    private void llenarDropDownListDevolucion()
    {
        using (BibliotecaDataContext context = new BibliotecaDataContext())
        {
            dropDevolucionLibro.DataSource = context.DetallePrestamos2.GroupBy(p => p.Libros2.libNombre).Select(p => p.Select(p1 => p1.Libros2.libNombre).First()).ToList();
            dropDevolucionUsuario.DataSource = context.Prestamos2.GroupBy(p => p.Usuarios2.usuNombre).Select(p => p.Select(p1 => p1.Usuarios2.usuNombre).First()).ToList();

            dropDevolucionLibro.DataBind();
            dropDevolucionUsuario.DataBind();
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        using (BibliotecaDataContext context = new BibliotecaDataContext())
        {
            DetallePrestamos2 detalle = context.DetallePrestamos2.
                Where(p => p.libCodigo.Equals(
                context.Libros2.Where(p1 => p1.libNombre.Equals(dropDevolucionLibro.SelectedItem)).Select(p2 => p2.libCodigo)
                ))
                .Where(p => p.preCodigo.Equals(
                    context.Prestamos2.Where(p1 => p1.usuDocumento.Equals(dropDevolucionUsuario.SelectedValue)).Select(p2 => p2.preCodigo).First()
                    ))
                .First();

            detalle.dtpFechaDev = DateTime.Parse(txtDevolucionFecha.Text);

            Areas2 area = context.Libros2.Where(p => p.libNombre.Equals(dropDevolucionLibro.SelectedValue)).Select(p => p.Areas2).First();
            DateTime fechaDev = detalle.Prestamos2.preFecha;
            DateTime generalTime = new DateTime(fechaDev.Year, fechaDev.Month, fechaDev.Day, 0, 0, 0);
            DateTime generalTime2 = new DateTime(detalle.dtpFechaDev.Year, detalle.dtpFechaDev.Month, detalle.dtpFechaDev.Day, 0, 0, 0);

            TimeSpan days = new TimeSpan(24 * area.areTiempo, 0, 0);
            generalTime += days;

            try
            {
                context.SubmitChanges();
            }
            catch (Exception)
            {

                //throw;
            }
            if (generalTime.CompareTo(generalTime2) < 0)
            {
                Sanciones2 sancion = new Sanciones2();

                sancion.sanDiasSancion = 5;
                sancion.sanFechaInicio = detalle.dtpFechaDev;

                TimeSpan days2 = new TimeSpan(24 * 5, 0, 0);
                DateTime generalTime3 = new DateTime(detalle.dtpFechaDev.Year, detalle.dtpFechaDev.Month, detalle.dtpFechaDev.Day, 0, 0, 0);
                generalTime3 += days;
                sancion.sanFechaFin = generalTime3;
                try
                {
                    context.Sanciones2.InsertOnSubmit(sancion);
                    context.SubmitChanges();
                }
                catch (Exception)
                {

                    //throw;
                }
            }




        }
    }
}