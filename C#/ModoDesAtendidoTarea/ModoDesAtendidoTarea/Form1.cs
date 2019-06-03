using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModoDesAtendidoTarea
{
    public partial class Form1 : Form
    {

        private SqlConnection conn;
        private SqlDataAdapter daCustumers;
        private DataSet dsCustomers;
        private DataGrid dgCustomers;
        private DataTable dtCustomers;
        private DataRow drActual;
        private DataRow drNueva;
        private int numRegistros;
        private int registroActual;
        private const String tablename = "tbl_employees";


        public Form1()
        {
            InitializeComponent();
            //Se crean los objetos e inicializan las variables
            initData();
            MostrarRegistro(registroActual);
            
        }



        private void MostrarRegistro(int numRegistro)
        {
            //valida el registro a mostrar 
            if (numRegistros > numRegistro )
            {
                //se asigna la fila a la variale drActual
                drActual = dtCustomers.Rows[numRegistro];
                //Se llenan los campos con la informacion de la fila
                txtFirstName.Text = drActual["Nombre"].ToString();
                txtSurName.Text = drActual["Apellido"].ToString();
                txtJobTitle.Text = drActual["Titulo"].ToString();
                txtDepartament.Text = drActual["Departamento"].ToString();

            }
            registroActual = numRegistro;
            mostrarRegistroActual();
        }
        //actualiza la informacion del label
        private void mostrarRegistroActual()
        {
            txtRecords.Text = "Record " + (registroActual + 1) + " of " + numRegistros;
        }


        private void actualizarBD()
        {
            //se actualiza la base de datos con el DataSet
            daCustumers.Update(dsCustomers, tablename);
            
        }
        //Se crean los objetos y se inicializa las variables
        private void initData()
        {
            //conexion con la bd en SQL server
            conn = new SqlConnection("Server=localhost;Database=C:\\EMPLOYEES.MDF;Trusted_Connection=True;");

            dsCustomers = new DataSet();
            //obtiene los datos de la bd con una consulta
            daCustumers = new SqlDataAdapter("select id as Id, first_name as Nombre, last_name as Apellido, job_title as Titulo, department  as Departamento from tbl_employees;", conn);
            SqlCommandBuilder cmdBldr = new SqlCommandBuilder(daCustumers);
            //se rellenan los datos del objeto daCustumers al DataSet 
            daCustumers.Fill(dsCustomers, tablename);
            //se asigna la tabla al objeto dtCustomers
            dtCustomers = dsCustomers.Tables[tablename];
            //Se asigna el numero de registros a numRegistros
            numRegistros = dtCustomers.Rows.Count;
            registroActual = 0;

        }

        //muestra el siguiente registro
        private void btnNext_Click(object sender, EventArgs e)
        {
            //valida el registro para que no pase del numero de registros totales
            if ((registroActual + 1) < numRegistros)
            {
                registroActual++;
                 MostrarRegistro(registroActual);
            }
            
        }

        //muestra el registro anterior
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            //valida que el numero del registro no caiga en un numero negativo
            if ((registroActual - 1) >= 0)
            {
                registroActual--;
                MostrarRegistro(registroActual);
            }
            
        }

        //obtiene el primer registro
        private void btnFirstRecord_Click(object sender, EventArgs e)
        {
            MostrarRegistro(0);
        }

        //obtiene el ultimo registro 
        private void btnLastRecord_Click(object sender, EventArgs e)
        {
            MostrarRegistro(numRegistros - 1);
        }

        //Limpia las cajas de texto para agregar un nuevo registro
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            btnNext.Enabled = false;
            btnPrevious.Enabled = false;
            btnFirstRecord.Enabled = false;
            btnLastRecord.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;

            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            btnAddNew.Enabled = false;


            txtFirstName.Clear();
            txtSurName.Clear();
            txtJobTitle.Clear();
            txtDepartament.Clear();


        }

        //Agrega la nueva Fila y Actualiza la BD
        private void btnSave_Click(object sender, EventArgs e)
        {
            //Valida que los campos no esten vacios
            if (txtFirstName.Text != "" && txtSurName.Text != "" && txtDepartament.Text != "" && txtJobTitle.Text != "")
            {
                btnSave.Enabled = false;
                btnCancel.Enabled = false;
                btnAddNew.Enabled = true;
                btnNext.Enabled = true;
                btnPrevious.Enabled = true;
                btnFirstRecord.Enabled = true;
                btnLastRecord.Enabled = true;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
                //obtiene una nueva fila y se le asigna al DataRow drNueva
                drNueva = dtCustomers.NewRow();
                drNueva["Id"] = "" + (Convert.ToInt16(dtCustomers.Rows[numRegistros - 1]["Id"]) + 1);
                drNueva["Nombre"] = txtFirstName.Text;
                drNueva["Apellido"] = txtSurName.Text;
                drNueva["Titulo"] = txtJobTitle.Text;
                drNueva["Departamento"] = txtDepartament.Text;
                //se agrega la fila nueva al DataTable dtCustomers y se actualizan los registros y la BD
                dtCustomers.Rows.Add(drNueva);
                numRegistros++;
                actualizarBD();
                MessageBox.Show("Registro agregado");
                MostrarRegistro(numRegistros-1);
            }
            else
            {
                MessageBox.Show("Rellene todos los campos");
            }


        }
        //Cancela la agregacion de un nuevo registro 
        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            btnAddNew.Enabled = true;

            btnNext.Enabled = true;
            btnPrevious.Enabled = true;
            btnFirstRecord.Enabled = true;
            btnLastRecord.Enabled = true;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            //se muestra el registro que estaba anteriormente al agregar
            MostrarRegistro(registroActual);


        }

        //Se actualiza el registro actual y actualiza La BD
        private void btnUpdate_Click(object sender, EventArgs e)
        {

            drActual["Nombre"] = txtFirstName.Text;
            drActual["Apellido"] = txtSurName.Text;
            drActual["Titulo"] = txtJobTitle.Text;
            drActual["Departamento"] = txtDepartament.Text;
            actualizarBD();
            MessageBox.Show("Registro actualizado");
        }

        //Elimina el registro actual y actualiza la BD
        private void btnDelete_Click(object sender, EventArgs e)
        {
            dtCustomers.Rows[registroActual].Delete();
            numRegistros--;

            
            //dtCustomers.AcceptChanges();
            actualizarBD();
            MessageBox.Show("Registro eliminado");

            MostrarRegistro(0);
        }
    }
}
