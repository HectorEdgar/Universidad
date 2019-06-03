using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace InventariosDT
{
    public partial class Form1 : Form
    {
        private Form2 guiPrincipal;
        public Form1()
        {
            InitializeComponent();
            playSimpleSound();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void playSimpleSound()
        {
       
         SoundPlayer simpleSound = new SoundPlayer(@"F:\InventariosDT\Miiverse_Music2.wav");
            simpleSound.Play();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            guiPrincipal = new Form2();
            guiPrincipal.Visible = true;
            this.Visible = false;
        }
    }
}
