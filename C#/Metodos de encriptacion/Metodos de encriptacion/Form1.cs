using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metodos_de_encriptacion
{
    public partial class Form1 : Form
    {
        private Controller control;
        public Form1()
        {
            InitializeComponent();
            control = new Controller();
        }


        
        private void txtCesarEncriptar_Click(object sender, EventArgs e)
        {
            if (!btnEncriptarCesar.Enabled)
            {
                txtCesarEncriptar.ResetText();
                btnEncriptarCesar.Enabled = true;
            }
            
        }

        private void btnEncriptarCesar_Click(object sender, EventArgs e)
        {
            txtCesarEncriptado.Text = control.encriptarCesar(txtCesarEncriptar.Text);
        }
    }
}
