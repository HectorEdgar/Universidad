using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SemestralBase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.pnlHotelAlta.Visible = false;
            this.pnlHotelBuscar.Visible = false;
            this.pnlHotelDespliegueInformacion.Visible = false;
            this.pnlHabitacionAlta.Visible = false;
            this.pnlHabitacionBuscar.Visible = false;
            this.pnlHabitacionDespliegueInformacion.Visible = false;
            this.pnlReservacionAlta.Visible = false;
            this.pnlReservacionDespliegueInformacion.Visible = false;
            this.pnlHuespedAlta.Visible = false;
            this.pnlHuespedBuscar.Visible = false;
            this.pnlMenuHabitacion.Visible = false;
            this.pnlMenuHotel.Visible = false;
            this.pnlMenuHuesped.Visible = false;
            this.pnlMenuReservacion.Visible = false;
            this.pnlMenuPrincipal.Visible = false;
            this.pnlHabitacionEditar.Visible= false;
            this.pnlHotelEditar.Visible = false;
            this.pnlHuespedEditar.Visible = false;
            
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            tbUsuario.Clear();
            tbContrasena.Clear();
            this.pnlInicioSesion.Visible = false;
            this.pnlMenuPrincipal.Visible = true;
        }

        private void btnHotel_Click(object sender, EventArgs e)
        {
            this.pnlMenuPrincipal.Visible = false;
            this.pnlMenuHotel.Visible = true;
        }

        private void btnHabitacion_Click(object sender, EventArgs e)
        {
            this.pnlMenuPrincipal.Visible = false;
            this.pnlMenuHabitacion.Visible = true;

        }

        private void btnHuespedes_Click(object sender, EventArgs e)
        {
            this.pnlMenuPrincipal.Visible = false;
            this.pnlMenuHuesped.Visible = true;

        }

        private void btnReservacion_Click(object sender, EventArgs e)
        {
            this.pnlMenuPrincipal.Visible = false;
            this.pnlMenuReservacion.Visible = true;

        }

        private void btnHotelAlta_Click(object sender, EventArgs e)
        {
            tbHotelCiudad.ResetText();
            tbHotelNombre.ResetText();
            tbHotelPais.ResetText();

            this.pnlMenuHotel.Visible = false;
            this.pnlHotelAlta.Visible = true;
        }

        private void btnHotelBuscar_Click(object sender, EventArgs e)
        {
            tbHotelBuscar.Clear();
            dgvHotelBuscar.Rows.Clear();
            tbHotelBuscar.ResetText();
            this.pnlMenuHotel.Visible = false;
            this.pnlHotelBuscar.Visible = true;

        }

        private void btnHotelDesplegarInformacion_Click(object sender, EventArgs e)
        {
            this.pnlMenuHotel.Visible = false;
            this.pnlHotelDespliegueInformacion.Visible = true;

        }
        private void btnHotelAltaAceptar_Click(object sender, EventArgs e)
        {
            //Click en boton para agregar hotel
            this.pnlHotelAlta.Visible = false;
            this.pnlMenuHotel.Visible = true;
            
            MessageBox.Show("Se ha agregado con exito");
        }

        private void tbHotelBuscar_TextChanged(object sender, EventArgs e)
        {
            //buscar hotel evento del tb del panel hotel buscar
            Console.WriteLine(cbHotelBuscarOpcion.SelectedIndex);
            int opcionSeleccionada = cbHotelBuscarOpcion.SelectedIndex;
            
            if (opcionSeleccionada !=-1)
            {
                if (opcionSeleccionada==0)
                {
                    //buscar por nombre

                }
                else{
                    if(opcionSeleccionada==1)
                    {
                        //buscar por ciudad

                    }else
                    {
                        if (opcionSeleccionada==2)
                        {
                            //buscar por pais

                        }

                    }
                }

            }else
            {
                MessageBox.Show("Por favor seleccione una opción");
            }
        }

        private void dgvHotelBuscar_Click(object sender, EventArgs e)
        {
            //click en el boton de editar en el dgv de Hotel; panel Buscar Hotel

            //Console.WriteLine(dgvHotelBuscar.CurrentCell.ColumnIndex);
            if (dgvHotelBuscar.CurrentCell.ColumnIndex == 3)
            {
                //si presiona el boton te lleva al panel de Editar Hotel
                tbHotelBuscar.Clear();
                dgvHotelBuscar.Rows.Clear();
                this.pnlHotelBuscar.Visible = false;
                this.pnlHotelEditar.Visible = true;
                


            }
        }

        private void btnHotelEditarAceptar_Click(object sender, EventArgs e)
        {
            //click en boton 
            //actualizacion de hotel
            tbHotelBuscar.Clear();
            dgvHotelBuscar.Rows.Clear();

            MessageBox.Show("Se ha registrado con exito");

            this.pnlHotelBuscar.Visible = true;
            this.pnlHotelEditar.Visible = false;

        }

        private void btnHotelEditarEliminar_Click(object sender, EventArgs e)
        {
            //click en boton 
            //Eliminar Hotel
            tbHotelBuscar.Clear();
            dgvHotelBuscar.Rows.Clear();

            MessageBox.Show("Se ha eliminado con exito");

            this.pnlHotelBuscar.Visible = true;
            this.pnlHotelEditar.Visible = false;

        }

        private void btnHabitacionAlta_Click(object sender, EventArgs e)
        {
            cbHabitacionAltaHotel.ResetText();
            nuHabitacionNum.ResetText();
            cbHabitacionTipo.ResetText();
            this.pnlMenuHabitacion.Visible = false;
            this.pnlHabitacionAlta.Visible = true;
        }
        private void btnHabitacionAltaAceptar_Click(object sender, EventArgs e)
        {
            //click en el boton alta de habitación
            cbHabitacionAltaHotel.ResetText();
            nuHabitacionNum.ResetText();
            cbHabitacionTipo.ResetText();
            
            MessageBox.Show("Se ha agregado con exito");
            this.pnlHabitacionAlta.Visible = false;
            this.pnlMenuHabitacion.Visible = true;


        }

        private void btnHabitacionBuscar_Click(object sender, EventArgs e)
        {
            tbHabitacionBuscar.ResetText();
            
            dgvHabitacionBuscar.Rows.Clear();
            this.pnlMenuHabitacion.Visible = false;
            this.pnlHabitacionBuscar.Visible = true;
        }

        private void btnHabitacionDesplegarInformacion_Click(object sender, EventArgs e)
        {
            dtpHabitacionDespliegueInformacionFechaInicio.ResetText();
            dtpHabitacionDespliegueInformacionFechaInicio.ResetText();
            this.pnlMenuHabitacion.Visible = false;
            this.pnlHabitacionDespliegueInformacion.Visible = true;
        }

        private void btnHuespedAltaAceptar_Click(object sender, EventArgs e)
        {
            //Click en boton para agregar un huesped
            tbHuespedBuscar.ResetText();
            dgvHuespedBuscar.Rows.Clear();
            MessageBox.Show("Se ha agregado con exito");

            this.pnlHuespedAlta.Visible = false;
            this.pnlMenuHuesped.Visible = true;

        }

        private void tbHuespedBuscar_TextChanged(object sender, EventArgs e)
        {
            //evento del combo box de Huesped
            int opcionSeleccionada = cbHuespedBuscarOpcion.SelectedIndex;

            if (opcionSeleccionada != -1)
            {
                if (opcionSeleccionada == 0)
                {
                    //buscar por nombre

                }
                else {
                    if (opcionSeleccionada == 1)
                    {
                        //buscar por Direccion

                    }
                    
                }

            }else
            {
                MessageBox.Show("Por favor seleccione una opción");
            }
        }

        private void dgvHuespedBuscar_Click(object sender, EventArgs e)
        {
            //click en el boton de editar en el dgv de Huesped; panel Buscar Huesped

            //Console.WriteLine(dgvHotelBuscar.CurrentCell.ColumnIndex);
            if (dgvHuespedBuscar.CurrentCell.ColumnIndex == 2)
            {
                //si presiona el boton te lleva al panel de Editar Hotel
                tbHuespedBuscar.Clear();
                dgvHuespedBuscar.Rows.Clear();
                this.pnlHuespedBuscar.Visible = false;
                this.pnlHuespedEditar.Visible = true;

            }
        }

        private void btnHuespedEditarAceptar_Click(object sender, EventArgs e)
        {
            //click en el boton de aceptar la actualizacion de huesped
            tbHuespedBuscar.Clear();
            dgvHuespedBuscar.Rows.Clear();
            MessageBox.Show("Se ha actualizado con exito");
            this.pnlHuespedBuscar.Visible = true;
            this.pnlHuespedEditar.Visible = false;

        }

        private void btnHuespedEditarEliminar_Click(object sender, EventArgs e)
        {
            //click en el boton de eliminar huesped
            tbHuespedBuscar.Clear();
            dgvHuespedBuscar.Rows.Clear();
            this.pnlHuespedBuscar.Visible = true;
            this.pnlHuespedEditar.Visible = false;
            MessageBox.Show("Se ha actualizado con exito");

        }

        private void btnHuespedAlta_Click(object sender, EventArgs e)
        {
            tbHuespedNombre.ResetText();
            tbHuespedDireccion.ResetText();
            this.pnlMenuHuesped.Visible = false;
            this.pnlHuespedAlta.Visible = true;
            
        }

        private void btnHuespedBusacar_Click(object sender, EventArgs e)
        {
            tbHuespedBuscar.ResetText();
            dgvHuespedBuscar.Rows.Clear();
            this.pnlHuespedBuscar.Visible = true;
            this.pnlMenuHuesped.Visible = false;

        }

   
        

        private void btnReservacionAltaAceptar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se ha agregado con exito");
            this.pnlReservacionAlta.Visible = false;
                this.pnlMenuReservacion.Visible = true;
        }

        private void btnHabitacionEditarAceptar_Click(object sender, EventArgs e)
        {
            //click en aceptar para actualizar habitacion
            tbHabitacionBuscar.ResetText();
            dgvHabitacionBuscar.Rows.Clear();
            MessageBox.Show("Se ha actualizado con exito");
            pnlHabitacionEditar.Visible = false;
            pnlHabitacionBuscar.Visible = true;
        }

        private void btnHabitacionEditarEliminar_Click(object sender, EventArgs e)
        {
            //click en eliminar para eliminar habitacion
            tbHabitacionBuscar.ResetText();
            dgvHabitacionBuscar.Rows.Clear();
            MessageBox.Show("Se ha eliminado con exito");
            pnlHabitacionEditar.Visible = false;
            pnlHabitacionBuscar.Visible = true;
        }

        private void dgvHabitacionBuscar_Click(object sender, EventArgs e)
        {
            if (dgvHabitacionBuscar.CurrentCell.ColumnIndex==4)
            {
                //click en evento de editar habitacion en panel buscar habitacion
                this.pnlHabitacionBuscar.Visible = false;
                this.pnlHabitacionEditar.Visible = true;

            }
        }

        private void tbHabitacionBuscar_TextChanged(object sender, EventArgs e)
        {
            int opcionSeleccionada = cbHabitacionBuscarOpcion.SelectedIndex;
            Console.WriteLine(cbHabitacionBuscarOpcion.SelectedIndex);
            if (opcionSeleccionada != -1)
            {
                if (opcionSeleccionada == 0)
                {
                    //buscar por numero

                }
                else {
                    if (opcionSeleccionada == 1)
                    {
                        //buscar por hotel

                    }

                }

            }
            else
            {
                MessageBox.Show("Por favor seleccione una opción");
            }
        }

        private void btnReservacionAlta_Click(object sender, EventArgs e)
        {
            cbReservacionHabitacion.ResetText();
            cbReservacionHotel.ResetText();
            dtpReservacionFechaReservacion.ResetText();
            dtpReservacionFinReservacion.ResetText();
            this.pnlMenuReservacion.Visible = false;
            this.pnlReservacionAlta.Visible = true;
            
        }

        private void btnReservacionDesplegarInformacion_Click(object sender, EventArgs e)
        {
            dtpReservacionDespliegueInformacionFechaFin.ResetText();
            dtpReservacionDespliegueInformacionFechaInicio.ResetText();
            this.pnlMenuReservacion.Visible = false;
            this.pnlReservacionDespliegueInformacion.Visible = true;
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.pnlMenuPrincipal.Visible = false;
            this.pnlInicioSesion.Visible = true;
        }

        private void btnRegresarMenuHotel_Click(object sender, EventArgs e)
        {
            this.pnlMenuHotel.Visible = false;
            this.pnlMenuPrincipal.Visible = true;
        }

        private void btnRegresarAltaHotel_Click(object sender, EventArgs e)
        {
            this.pnlHotelAlta.Visible = false;
            this.pnlMenuHotel.Visible = true;
        }

        private void btnRegresarBuscarHoteles_Click(object sender, EventArgs e)
        {
            this.pnlHotelBuscar.Visible = false;
            this.pnlMenuHotel.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.pnlHotelEditar.Visible = false;
            this.pnlHotelBuscar.Visible = true;
        }

        private void btnRegresarHotelDesplegarInformacion_Click(object sender, EventArgs e)
        {
            this.pnlHotelDespliegueInformacion.Visible = false;
            this.pnlMenuHotel.Visible = true;
        }

        private void btnRegresarMenuHabitacion_Click(object sender, EventArgs e)
        {
            this.pnlMenuPrincipal.Visible = true;
            this.pnlMenuHabitacion.Visible = false;
        }

        private void btnRegresarAltaHabitacion_Click(object sender, EventArgs e)
        {
            this.pnlMenuHabitacion.Visible = true;
            this.pnlHabitacionAlta.Visible = false;

        }

        private void btnRegresarBuscarHabitacion_Click(object sender, EventArgs e)
        {
            this.pnlMenuHabitacion.Visible = true;
            this.pnlHabitacionBuscar.Visible = false;
        }

        private void btnRegresarEditarHabitacion_Click(object sender, EventArgs e)
        {
            this.pnlHabitacionEditar.Visible = false;
            this.pnlHabitacionBuscar.Visible = true;
        }

        private void btnRegresarHabitacionDespliegueInformacion_Click(object sender, EventArgs e)
        {
            this.pnlHabitacionDespliegueInformacion.Visible = false;
            this.pnlMenuHabitacion.Visible = true;
        }

        private void btnResgresarMenuHuespedes_Click(object sender, EventArgs e)
        {
            this.pnlMenuHuesped.Visible = false;
            this.pnlMenuPrincipal.Visible = true;
        }

        private void btnRegresarHuespedEditar_Click(object sender, EventArgs e)
        {
            this.pnlHuespedEditar.Visible = false;
            this.pnlHuespedBuscar.Visible = true;
        }

        private void btnRegresarHuespedesBuscar_Click(object sender, EventArgs e)
        {
            this.pnlHuespedBuscar.Visible = false;
            this.pnlMenuHuesped.Visible = true;

        }

        private void btnRegresarHuespedAlta_Click(object sender, EventArgs e)
        {
            this.pnlHuespedAlta.Visible = false;
            this.pnlMenuHuesped.Visible = true;
        }

        private void btnRegresarMenuReservacion_Click(object sender, EventArgs e)
        {
            this.pnlMenuReservacion.Visible = false;
            this.pnlMenuPrincipal.Visible = true;
        }

        private void btnRegresarReservacioDespliegueInformacion_Click(object sender, EventArgs e)
        {
            this.pnlReservacionDespliegueInformacion.Visible = false;
            this.pnlMenuReservacion.Visible = true;
        }

        private void btnRegresarAltaReservacion_Click(object sender, EventArgs e)
        {
            this.pnlReservacionAlta.Visible = false;
            this.pnlMenuReservacion.Visible = true;
        }
    }
}
