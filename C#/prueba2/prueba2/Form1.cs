using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prueba2
{
    public partial class Form1 : Form
    {

        private int numero1;
        private int numero2;
        private String valor="";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            numero1 = Convert.ToInt32(textBox1.Text);
            numero2 = Convert.ToInt32(textBox2.Text);

            for (int i = numero1; i<=numero2;i++)
            {
                valor = valor + " -  " + i;
            }

            MessageBox.Show(valor);
            valor = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            numero1 = Convert.ToInt32(textBox1.Text);
            numero2 = Convert.ToInt32(textBox2.Text);

            do
            {
                valor = valor + " -  " + numero1;
                numero1++;

            } while (numero1<numero2+1);
            MessageBox.Show(valor);
            valor = "";

        }
    }
}
