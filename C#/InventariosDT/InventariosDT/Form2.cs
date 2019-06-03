using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventariosDT
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.ExitThread();
        }

        private void buttonItem1_Click(object sender, EventArgs e)
        {

        }

        private void groupPanel1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonItem1_Click_1(object sender, EventArgs e)
        {
            

        }

        private void buttonItem2_Click(object sender, EventArgs e)
        {
          

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
          


        }

        private void panelEx1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonItem3_Click(object sender, EventArgs e)
        {
            


        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
           


        }

        private void buttonItem4_Click(object sender, EventArgs e)
        {
           
        }

        private void buttonItem1_Click_2(object sender, EventArgs e)
        {
            panelEx1.Visible= true;
            panelEx2.Visible = false;
            panelEx3.Visible = false;
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel8.Visible = false;
            panel9.Visible = false;
            panel12.Visible = false;

        }

        private void buttonItem2_Click_1(object sender, EventArgs e)
        {
            panelEx1.Visible = true;
            panelEx2.Visible = false;
            panelEx3.Visible = false;
            panel2.Visible = true;
            panel1.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel8.Visible = false;
            panel12.Visible = false;
            panel9.Visible = false;
        }

        private void buttonItem3_Click_1(object sender, EventArgs e)
        {
            panelEx1.Visible = true;
            panelEx2.Visible = false;
            panelEx3.Visible = false;
            panel3.Visible = true;
            panel2.Visible = false;
            panel1.Visible = false;
            panel4.Visible = false;
            panel8.Visible = false;
            panel9.Visible = false;
            panel12.Visible = false;
        }

        private void buttonItem4_Click_1(object sender, EventArgs e)
        {
            panelEx1.Visible = true;
            panelEx2.Visible = false;
            panelEx3.Visible = false;
            panel4.Visible = true;
            panel2.Visible = false;
            panel1.Visible = false;
            panel3.Visible = false;
            panel8.Visible = false;
            panel9.Visible = false;
            panel12.Visible = false;
        }

        private void buttonItem8_Click(object sender, EventArgs e)
        {
            panelEx1.Visible = false;
            panelEx2.Visible = true;
            panelEx3.Visible = false;
            panel6.Visible = true;
            panel7.Visible = false;
            panel8.Visible = false;
            panel9.Visible = false;
            panel12.Visible = false;

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonItem9_Click(object sender, EventArgs e)
        {
            panelEx1.Visible = false;
            panelEx2.Visible = true;
            panelEx3.Visible = false;
            panel6.Visible = false;
            panel7.Visible=true;
            panel8.Visible = false;
            panel9.Visible = false;
            panel12.Visible = false;
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonItem10_Click(object sender, EventArgs e)
        {
            panelEx1.Visible = false;
            panelEx2.Visible = true;
            panelEx3.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
            panel8.Visible = true;
            panel9.Visible = false;
            panel12.Visible = false;
        }

        private void buttonItem11_Click(object sender, EventArgs e)
        {
            panelEx1.Visible = false;
            panelEx2.Visible = true;
            panelEx3.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
            panel8.Visible = false;
            panel9.Visible = true;
            panel12.Visible = false;

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void buttonItem14_Click(object sender, EventArgs e)
        {
            panelEx1.Visible = false;
            panelEx2.Visible = false;
            panelEx3.Visible = true;
            panel10.Visible = true;
            panel11.Visible = false;
            panel12.Visible = false;
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelEx3_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonItem15_Click(object sender, EventArgs e)
        {
            panelEx1.Visible = false;
            panelEx2.Visible = false;
            panelEx3.Visible = true;
            panel10.Visible = false;
            panel11.Visible = true;
            panel12.Visible = false;
        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonItem16_Click(object sender, EventArgs e)
        {
            panelEx1.Visible = false;
            panelEx2.Visible = false;
            panelEx3.Visible = true;
            panel10.Visible = false;
            panel11.Visible = false;
            panel12.Visible = true;
        }

        private void explorerBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
