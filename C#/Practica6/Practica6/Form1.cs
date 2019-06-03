using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica6
{
    public partial class Form1 : Form
    {
        private MySqlConnection conn;
        private MySqlDataAdapter daArtist;
        private MySqlDataAdapter daCompany;
        private DataSet dsArtist;
        private DataGridView dgArtist;
        private DataSet dsCompany;
        private DataGridView dgCompany;
        private const String tablename1 = "artist";
        private const String tablename2 = "company";

        private String CadenaConexion;
        public Form1()
        {
            InitializeComponent();
            //se llama a la función para crear los objetos y componentes
            conectar();

        }

        
        //Se crean los objetos y se agrega el DataGrid al panel
        private void initData()
        {
            //Se crean los objetos y componentes y  se rellenan los DataSet
            

            dsArtist = new DataSet();
            dsCompany = new DataSet();
            daArtist = new MySqlDataAdapter("SELECT * from artist", conn);
            daCompany = new MySqlDataAdapter("SELECT * from company", conn);
            MySqlCommandBuilder cmdBldr1 = new MySqlCommandBuilder(daArtist);
            MySqlCommandBuilder cmdBldr2 = new MySqlCommandBuilder(daCompany);
            daArtist.Fill(dsArtist, tablename1);
            daCompany.Fill(dsCompany,tablename2);


            dgArtist = new DataGridView();
            dgCompany = new DataGridView();
            dgArtist.Location = new Point(0, 0);
            dgCompany.Location = new Point(420,0);
            dgArtist.Size = new Size(400, 200);
            dgCompany.Size = new Size(300,200);

            dgArtist.DataSource = dsArtist;
            dgCompany.DataSource = dsCompany;
            dgArtist.DataMember = tablename1;
            dgCompany.DataMember = tablename2;
            //Se hace visible el 2 panel y se agrega un DataGridView al panel2
            panel2.Controls.Add(dgArtist);
            panel2.Controls.Add(dgCompany);
            panel2.Visible = true;

            

        }

        private void conectar()
        {

            //se obtienen los datos de la cadena de conexión
            //CadenaConexion = "SERVER=" + txtServer.Text + ";PORT=" + txtPort.Text + ";Database=BD_Sucarnet;USER=" + txtUser.Text + ";PASSWORD=" + txtPassword.Text + ";";
            //CadenaConexion = "Server=www.db4free.net; Database=ulsaoaxaca5; Uid=ulsaoaxaca5; Pwd=ulsaoaxaca; Port=3306;";
            CadenaConexion = "Server=192.168.43.10; Database=u435087976_base1; Uid=u435087976_root1; Pwd=ulsaoaxaca; Port=3306;";
            conn = new MySqlConnection(CadenaConexion);
            try
            {
                //Si se abre la conexión mostrará el mensaje y se inicializarán los objetos
                conn.Open();
                MessageBox.Show("Se ha conectado correctamente");
                //conn.Close();

                initData();
                
            }
            catch (Exception e)
            {

                MessageBox.Show("Error "+e.StackTrace);
            }
            
        }

        

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
            try
            {
                //Se actualiza la tabla company de la base de datos y muestra un mensaje
                daCompany.Update(dsCompany, tablename2);
                
                MessageBox.Show("Registros de la tabla company actualizados correctamente");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error en actualizar la tabla company " + ex.StackTrace);
            }

            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //Se actualiza la tabla artist de la base de datos y muestra un mensaje
                daArtist.Update(dsArtist, tablename1);

                MessageBox.Show("Registros de la tabla artist actualizados correctamente");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error en actualizar la tabla artist " + ex.StackTrace);
            }
        }
    }
}
