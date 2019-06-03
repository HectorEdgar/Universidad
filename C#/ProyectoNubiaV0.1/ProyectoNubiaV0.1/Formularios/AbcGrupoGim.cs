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
    public partial class AbcGrupoGim : Form
    {
        private ControlGeneralGrupoGim control;
        private ControlGrupoGimnasio controlGrup;
        private ControlGrupoAlumnos controlGrupAlumno;
        private ControlAlumno controlAlumno;
        public AbcGrupoGim()
        {
            InitializeComponent();

            control = new ControlGeneralGrupoGim();
            controlAlumno = new ControlAlumno();
            controlGrupAlumno = new ControlGrupoAlumnos();

            controlGrup = new ControlGrupoGimnasio();

            bloquearGrupAlum();

            bloquearGrupGim();

            buscarHorarios();
            buscarMatricula();
            buscarGruposGimnasio();
            gridAlumno();
            gridGrupoGimnasio();
            gridAlumnoGrupoGimnasio();
            //8,4,2,1
            try
            {
                textBox1.SelectedIndex = 0;
            }
            catch (Exception)
            {

                textBox1.SelectedIndex = -1;
            }
           
            
            textBox2.SelectedIndex = 0;
            textBox4.SelectedIndex = 0;
            textBox8.SelectedIndex = 0;

        }

        public void buscarMatricula()
        {
            this.control.controlAlum.obtenerAlumnos();
            textBox1.Items.Clear();
            for (int i = 0; i < this.control.controlAlum.alumnos_todos.Count; i++)
            {
                textBox4.Items.Add(this.control.controlAlum.alumnos_todos[i].Matricula);
                textBox2.Items.Add(this.control.controlAlum.alumnos_todos[i].Matricula);
            }
        }
        public void buscarHorarios()
        {
            this.control.controlHorario.obtenerHorariosGimnasio();
            textBox1.Items.Clear();
            for (int i = 0; i < this.control.controlHorario.horariosGimnasio.Count; i++)
            {
                textBox1.Items.Add(this.control.controlHorario.horariosGimnasio[i].nombre);
            }

        }

        public void buscarGruposGimnasio()
        {
            this.control.obtenerGruposGimnasio();

            for (int i = 0; i < this.control.gruposGimnasio.Count; i++)
            {
                textBox8.Items.Add(this.control.gruposGimnasio[i].nombre);
            }
        }

        public void limpiarGA() {

            textBox2.ResetText();
            textBox5.ResetText();
            textBox6.ResetText();
            textBox7.ResetText();

        }

        public void limpiarGG()
        {

            textBox1.ResetText();
            textBox3.ResetText();
            txtId.ResetText();
            txtNombre.ResetText();
            txtCodigo.ResetText();

        }
        public void bloquearGrupAlum() {
            pnlGrupoGim.Enabled = false;
        }
        public void desbloquearGrupAlum()
        {
            pnlGrupoGim.Enabled = true;
        }

        public void bloquearGrupGim()
        {
            pnlGrupo.Enabled = false;
        }
        public void desbloquearGrupGim()
        {
            pnlGrupo.Enabled = true;
        }
        public void obtenerGrupoGimnasio()
        {
            dataGridView1.Rows.Clear();
            this.control.controGrupoGimnasio.obtenerGrupoGim();

            for (int i = 0; i < this.control.controGrupoGimnasio.grupgim.Count; i++)
            {
                String dias = "";
                this.control.BuscarAlumnosGrupoGimnasio(this.control.controGrupoGimnasio.grupgim[i].nombre);

                for (int j = 0; j < control.controlGrupoAlum.grupAlu.Count; j++)
                {
                    dias += " " + control.controlGrupoAlum.grupAlu[j].Matricula;
                }

                dataGridView1.Rows.Add(
                   // this.control.controlAlum.alumno.Matricula,
                    this.control.controlAlum.alumno.Nombre,
                    this.control.controGrupoGimnasio.grupogim.nombre,
                  
                    dias
                    );
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (controlGrup.agregarGrupoGimnasio(textBox3.Text, Convert.ToInt32(textBox1.Text)) > 0)
            {
                MessageBox.Show("Se agrego correctamente");
                limpiarGG();

            }
            else
            {
                MessageBox.Show("Ocurrio un error");
            }
        }

        private void btnBuscarGrupo_Click(object sender, EventArgs e)
        {
            controlGrup.obtenerGrupoGim(txtNombreBusqueda.Text);
            if (controlGrup.grupogim!= null)
            {
                desbloquearGrupGim();

                txtId.Text = controlGrup.grupogim.idGimnasio + "";
                txtNombre.Text = controlGrup.grupogim.nombre;
                txtCodigo.Text = controlGrup.grupogim.IdHorario + "";
            }else
            {
                bloquearGrupGim();
                limpiarGG();
                MessageBox.Show("No se encontro el grupo del gimnasio");
            }
       
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {

            if (controlGrup.actualizarGrupoGim(txtNombre.Text, Convert.ToInt32(txtCodigo.Text)) > 0)
            {
                limpiarGG();
                bloquearGrupGim();
                MessageBox.Show("Se actualizo");
              
            }
            else
            {
                
                MessageBox.Show("No actualizo");
            }
        }

        private void btnElinar_Click(object sender, EventArgs e)
        {
            if (controlGrup.eliminarGrupoGim(Convert.ToInt16(txtId.Text)) > 0)
            {
                limpiarGG();
                bloquearGrupGim();
                MessageBox.Show("Se elimino");
                
            }
            else
            {
                MessageBox.Show("no elimino");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.OpenForms["MenuPrincipalAbc"].Visible = true;
            this.Dispose();
        }

        private void AbcGrupoGim_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (controlGrupAlumno.agregarAlGrupoGimnasio(textBox2.Text, Convert.ToInt32(textBox5.Text)) > 0)
            {
                limpiarGA();
                MessageBox.Show("Se agrego correctamente");   
            }
            else
            {

                MessageBox.Show("Ocurrio un error");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
           control.BuscarAlumnosGrupoGimnasio(txtNombreBusqueda.Text);

            obtenerGrupoGimnasio();
           // control.BuscarAlumnosGrupoGimnasio(txtNombreBusqueda.Text)
               

           // textBox6.Text = controlGrupAlumno.grupAlum.idGimnasio + "";
            //textBox7.Text = controlGrupAlumno.grupAlum.Matricula;
           // textBox4.Text = controlGrupAlumno.grupAlum. + "";
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            

            control.buscarAlumno_GrupoGimnasio(textBox4.Text,textBox8.Text);
            if (control.alumno_GrupoGimnasio!=null)
            {
                desbloquearGrupAlum();
                textBox6.Text = control.alumno_GrupoGimnasio.idGimnasio + "";
                textBox7.Text = control.alumno_GrupoGimnasio.Matricula;
            }
            else
            {
                bloquearGrupAlum();
                limpiarGG();
                MessageBox.Show("No se a encontrado ");
            }
        
            
        }

        private void button5_Click(object sender, EventArgs e)
        {




            try
            {
                control.actualizarAlumno_GrupoGimnasio(textBox7.Text, Convert.ToInt32(textBox6.Text));
                MessageBox.Show("Se actualizo");
                limpiarGA();
            }
            catch (Exception ex)
            {

                MessageBox.Show("No actualizo"+ex.Message);
            }
                
               
            
            
                
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (controlGrupAlumno.eliminarGrupoGim((textBox7.Text)) > 0)
            {
                MessageBox.Show("Se elimino");
                limpiarGA();
            }
            else
            {
                MessageBox.Show("no elimino");
            }

        }

        private void AbcGrupoGim_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason.Equals(CloseReason.UserClosing))
            {
                Application.Exit();
            }
        }

        private void textBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void gridAlumno()
        {
            dataGridView1.DataSource = controlAlumno.obtenerAlumnos();
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;

        }

        public void gridGrupoGimnasio()
        {
            control.obtenerGruposGimnasio();
            dataGridView2.DataSource= control.gruposGimnasio;
            dataGridView2.Columns[3].Visible = false;
            dataGridView2.Columns[4].Visible = false;
        }


        public void gridAlumnoGrupoGimnasio()
        {
            control.obtenerAlumnosGrupos_Gimnasio();

            for (int i = 0; i < control.alumnosGruposGimnasios.Count; i++)
            {
                dataGridView3.Rows.Add(
                    control.alumnosGruposGimnasios[i].Alumno.Matricula,
                    control.alumnosGruposGimnasios[i].GrupoGimnasio.nombre
                    );

            }

        }
    }
}
