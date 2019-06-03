using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBase2
{
    public partial class Form1 : Form
    {
        private Controller controller;
        public Form1()
        {
            InitializeComponent();
            controller = new Controller();
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
            panel8.Visible = false;
            panel9.Visible = false;

            
            btnAgrgarHotel.Visible = false;

        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            if (controller.validarCuenta(txtUsuario.Text, txtContrasena.Text))
            {
                panel2.Visible = true;
                panel1.Visible = false;
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecto(s)");
            }


        }

        private void ButnAltaHotel_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            panel2.Visible = false;
        }

        private void btnAgregarHAbitacion_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;
            panel3.Visible = false;
        }

        private void btnHabitacionRegresar_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            panel4.Visible = false;
        }

        private void btnHabitacionAgregar_Click(object sender, EventArgs e)
        {
            btnAgrgarHotel.Visible = true;
        }

        private void btnAltaHotelRegresar_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel3.Visible = false;
        }

        private void btnAgrgarHotel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se agrego : V");
            
        }

        private void btnReservaciones_Click(object sender, EventArgs e)
        {
            panel5.Visible = true;
            panel2.Visible = false;
        }

        private void btnMenuReservacionesRegresar_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel5.Visible = false;
        }

        private void btnReservacionParticular_Click(object sender, EventArgs e)
        {
            panel6.Visible = true;
            panel5.Visible = false;
        }

        private void btnAltareservacionParticularRegrsar_Click(object sender, EventArgs e)
        {
            panel5.Visible = true;
            panel6.Visible = false;
        }

        private void btnAltareservacionParticularReservar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("se hizo la reservación : V");
        }

        private void btnReservacionAgencia_Click(object sender, EventArgs e)
        {
            panel7.Visible = true;
            panel5.Visible = false;
        }

        private void btnAltaReservacioAgenciaRegresar_Click(object sender, EventArgs e)
        {
            panel5.Visible = true;
            panel7.Visible = false;
        }

        private void btnAltaReservacioAgenciaReservar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("se hizo la reservación : V");
        }

        private void btnDesplegarHoteles_Click(object sender, EventArgs e)
        {
            panel9.Visible = true;
            panel8.Visible = false;
        }

        private void btnDesplegarReservacionesParticulares_Click(object sender, EventArgs e)
        {
            panel9.Visible = true;
            panel8.Visible = false;
        }

        private void btnDesplegarReservacionesAgencia_Click(object sender, EventArgs e)
        {
            panel9.Visible = true;
            panel8.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel8.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel8.Visible = true;
            panel9.Visible = false;
        }

        private void btnDesplegar_Click(object sender, EventArgs e)
        {
            panel8.Visible = true;
            panel2.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
                        
            panel1.Visible = true;
            txtUsuario.Clear();
            txtContrasena.Clear();
            panel2.Visible = false;
        }
    }
}
