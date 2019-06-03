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

namespace Prueba_de_conexion_sqlServer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connetionString = null;
            SqlConnection cnn;
            //connetionString = " Data Source = localhost; Initial Catalog =empresa; Trusted_Connection=True; ";
            connetionString = "Data Source=192.168.1.104; Network Library=DBMSSOCN; Initial Catalog = empresa; Trusted_Connection=True; ";
            cnn = new SqlConnection(connetionString);
            try
            {
                cnn.Open();
                MessageBox.Show("Connection Open ! ");
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can´t open connection ! "+ex.Message);
                
            }


        }
    }
}
