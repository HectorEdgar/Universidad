using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoNubiaV0._1.Controladores;

namespace ProyectoNubiaV0._1.Formularios
{
    public partial class AbcAsistencia : Form
    {
        private ControladorAsistencia control;
        public AbcAsistencia()
        {
            InitializeComponent();
            this.control = new ControladorAsistencia();
            control.obtenerAlumnos();

            for (int i = 0; i < control.alumnos.Count; i++)
            {
                txtBuscar.Items.Add(control.alumnos[i].Matricula);
            }
            pnlEditarAsistencia.Enabled = false;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Application.OpenForms["MenuPrincipalAbc"].Visible = true;
            this.Dispose();
        }

        private void AbcAsistencia_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason.Equals(CloseReason.UserClosing))
            {
                Application.Exit();
            }
        }
        private void limpiarPanelEditarAsistencia()
        {
            txtNombreAlumno.ResetText();
            cbAsistencia.SelectedIndex = -1;
            cbFecha.Items.Clear();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            control.buscarAsistencia(txtBuscar.Text);
            cbFecha.Items.Clear();
            if (control.asistencias.Count>0)
            {
                txtNombreAlumno.Text= control.asistencias[0].Alumnos_GrupoGimnasio.Alumno.Nombre;
                for (int i = 0; i < control.asistencias.Count; i++)
                {
                    cbFecha.Items.Add(control.asistencias[i].Fecha);

                }
                cbFecha.SelectedIndex = 0;
                pnlEditarAsistencia.Enabled = true;
            }
            else
            {
                pnlEditarAsistencia.Enabled = false;
                limpiarPanelEditarAsistencia();
                MessageBox.Show("Este alumno aun no tiene asistencia");
            }
        }

        private void cbFecha_SelectedIndexChanged(object sender, EventArgs e)
        {
            String estadoAsistencia = control.asistencias[cbFecha.SelectedIndex].Estado.ToLower();
            if (estadoAsistencia=="asistencia")
            {
                try
                {
                    cbAsistencia.SelectedIndex = 0;
                }
                catch (Exception)
                {

                    MessageBox.Show("Seleccione una matrícula válida");
                }
                
            }
            else
            {
                cbAsistencia.SelectedIndex = 1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            control.actualizarAsistencias(control.asistencias[cbFecha.SelectedIndex].Fecha, cbAsistencia.Text, control.asistencias[cbFecha.SelectedIndex].Matricula, control.asistencias[cbFecha.SelectedIndex].idGimnasio);
            MessageBox.Show("Se actualizó la asistencia con éxito");
        }

   
    }
}
