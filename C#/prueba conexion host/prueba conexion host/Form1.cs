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

namespace prueba_conexion_host
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private String conex;
        private MySqlConnection conn;
        private void conectar()
        {
            try
            {
                conex = @"Server=www.db4free.net; Database=ulsaoaxaca5; Uid=ulsaoaxaca5; Pwd=ulsaoaxaca; Port=3306;";
                conn = new MySqlConnection(conex);
                conn.Open();
                MessageBox.Show("Conexión exitosa");
            }
            catch (MySqlException ex)
            {

                MessageBox.Show("Error "+ex.ErrorCode + ex.StackTrace);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conectar();
        }
    }
}
