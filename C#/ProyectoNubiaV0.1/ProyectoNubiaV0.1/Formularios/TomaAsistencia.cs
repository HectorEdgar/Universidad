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
    public partial class TomaAsistencia : Form
    {
        private ControladorAsistencia control;
        private int idGimnasio;
        public TomaAsistencia()
        {

            InitializeComponent();
            pnlListaAsistencia.Visible = false;
            control = new ControladorAsistencia();
            control.obtenerGruposGimnasio();
            lblDia.Text = obtenerDia(DateTime.Now.DayOfWeek.ToString());
            idGimnasio = -1;

            for (int i = 0; i < control.gruposGimnasio.Count; i++)
            {
                cbGrupoGimnasio.Items.Add(control.gruposGimnasio[i].nombre);
            }
            cbGrupoGimnasio.SelectedIndex = 0;

        }

        public String obtenerDia(String dia)
        {
            switch (dia)
            {
                case "Monday":
                    return "Lunes";
                case "Tuesday":
                    return "Martes";
                case "Wednesday":
                    return "Miércoles";
                case "Thursday":
                    return "Jueves";
                case "Friday":
                    return "Viernes";
                case "Saturday":
                    return "Sábado";
                case "Sunday":
                    return "Domingo";

            }
            return "";
        }

        private void llenarLista()
        {
            try
            {
                control.obtenerAlumnosGimnasio(control.gruposGimnasio[cbGrupoGimnasio.SelectedIndex].idGimnasio);
                
            }
            catch (Exception)
            {

                MessageBox.Show("Seleccione un grupo válido");
                return;
            }
            
            this.dataGridView1.Rows.Clear();
            idGimnasio = control.gruposGimnasio[cbGrupoGimnasio.SelectedIndex].idGimnasio;
            control.buscarHorario(control.gruposGimnasio[cbGrupoGimnasio.SelectedIndex].HorarioGimnasio.IdHorario);
            String dias = "";
            for (int i = 0; i < control.controlHorarioGimnasioHoras.horarioGimnasio_Horas.Count; i++)
            {
                dias = dias + " " + control.controlHorarioGimnasioHoras.horarioGimnasio_Horas[i].Dia;
            }
            lblDiasGrupo.Text = dias;
            lblHoraFin.Text = control.ControlHoras.hora.HoraFin.ToShortTimeString();
            lblHoraInicio.Text = control.ControlHoras.hora.HoraInicio.ToShortTimeString();


            if (control.comprobarDia(obtenerDia(DateTime.Now.DayOfWeek.ToString())))
            {   
                int fechaActual = Convert.ToInt32(DateTime.Now.ToString("HHmmss"));
                int horaInicio = Convert.ToInt32(control.ControlHoras.hora.HoraInicio.ToString("HHmmss"));
                int horaFin = Convert.ToInt32(control.ControlHoras.hora.HoraFin.ToString("HHmmss"));
                if (fechaActual>= horaInicio && fechaActual<=horaFin )
                {

                    //MessageBox.Show("paso parte 2");
                    llenarListaAsistencia();
                    pnlListaAsistencia.Visible = true;

                }
                else
                {
                    pnlListaAsistencia.Visible = false;
                }
            }
            else
            {
                pnlListaAsistencia.Visible = false;
            }

            
           

            
        }

        private void llenarListaAsistencia()
        {
            if (control.contarAsistencia(control.alumnosGrupoGimnasio[0].Matricula,control.alumnosGrupoGimnasio[0].idGimnasio,DateTime.Now)<=0)
            {
                for (int i = 0; i < control.alumnosGrupoGimnasio.Count; i++)
                {
                    this.dataGridView1.Rows.Add(
                        control.alumnosGrupoGimnasio[i].Matricula,
                        control.alumnosGrupoGimnasio[i].Alumno.Nombre+""+control.alumnosGrupoGimnasio[i].Alumno.Apellidos,
                        true);
                    
                }
            }
            else
            {
                this.control.obtenerAsistencias(control.alumnosGrupoGimnasio[0].idGimnasio, DateTime.Now);
                for (int i = 0; i < control.alumnosGrupoGimnasio.Count; i++)
                {
                    if (control.tieneAsistencia(control.alumnosGrupoGimnasio[i].Matricula, control.alumnosGrupoGimnasio[i].idGimnasio, DateTime.Now))
                    {
                        this.dataGridView1.Rows.Add(
                        control.asistencia.Matricula,
                        control.asistencia.Alumnos_GrupoGimnasio.Alumno.Nombre + "" + control.asistencia.Alumnos_GrupoGimnasio.Alumno.Apellidos,
                        control.asistencia.Estado);
                    }
                    else
                    {
                        this.dataGridView1.Rows.Add(
                        control.alumnosGrupoGimnasio[i].Matricula,
                        control.alumnosGrupoGimnasio[i].Alumno.Nombre + "" + control.alumnosGrupoGimnasio[i].Alumno.Apellidos,
                        true);
                    }

                        
                    //MessageBox.Show(""+i);
                }

            }
            
        }
        private void TomaAsistencia_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason.Equals(CloseReason.UserClosing))
            {
                Application.Exit();
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Application.OpenForms["MenuPrincipal"].Visible = true;
            this.Dispose();
        }

        private void btnGuardarAsistencia_Click(object sender, EventArgs e)
        {
            if (control.contarAsistencia(control.alumnosGrupoGimnasio[0].Matricula, control.alumnosGrupoGimnasio[0].idGimnasio, DateTime.Now) > 0)
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (control.tieneAsistencia(control.alumnosGrupoGimnasio[i].Matricula, control.alumnosGrupoGimnasio[i].idGimnasio, DateTime.Now))
                    {
                        control.actualizarAsistencias(DateTime.Now, dataGridView1.Rows[i].Cells["Asistencia"].Value.ToString(), dataGridView1.Rows[i].Cells["Matricula"].Value.ToString(), idGimnasio);

                    }
                    else
                    {
                        control.agregarAsistencia(DateTime.Now, dataGridView1.Rows[i].Cells["Asistencia"].Value.ToString(), dataGridView1.Rows[i].Cells["Matricula"].Value.ToString(), idGimnasio);

                    }
                }
                MessageBox.Show("Asistencia Tomada");
            }
            else
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    control.agregarAsistencia(DateTime.Now, dataGridView1.Rows[i].Cells["Asistencia"].Value.ToString(), dataGridView1.Rows[i].Cells["Matricula"].Value.ToString(), idGimnasio);
                }
                MessageBox.Show("Asistencia Tomada");

            }
            pnlListaAsistencia.Visible = false;

        }

        private void btnMostrarLista_Click(object sender, EventArgs e)
        {
            if (cbGrupoGimnasio.Items.Count!=0)
            {
                llenarLista();
            }
            else
            {
                MessageBox.Show("No hay Grupos de gimnasio disponibles");
            }
            
        }

  
    }
}
