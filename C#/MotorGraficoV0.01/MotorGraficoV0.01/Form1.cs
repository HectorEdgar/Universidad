using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MotorGraficoV0._01
{
    public partial class Form1 : Form
    {
        public static float[] PuntoOrigen;
        private Punto Punto1;
        private Punto Punto2;
        private Punto Punto3;
        private Punto Punto4;
        private Graphics gp;
        private Pen BlackPen;
        private Pen WhitePen;
        public Form1()
        {

            InitializeComponent();
            Inicializar();



        }

        public void Inicializar() {
            PuntoOrigen = new float[2];
            PuntoOrigen[0] = 320;
            PuntoOrigen[1] = 240;

            Punto1 = new Punto(10, 10);
            Punto2= new Punto(20 , 20);
            Punto3 = new Punto(30 , 10);
            Punto4 = new Punto(20 , 40);

            gp =panel1.CreateGraphics();
           



        }

       

        private void DibujarEjes()
        {

            gp.Clear(Color.White);
            gp.DrawLine(BlackPen, 0, PuntoOrigen[1], 640, PuntoOrigen[1]);
            gp.DrawLine(BlackPen, PuntoOrigen[0], 480, PuntoOrigen[0], 0);

           

        }

        private void DibujarFigura()
        {
            gp.DrawLine(BlackPen, Punto1.X + PuntoOrigen[0], -Punto1.Y + PuntoOrigen[1], Punto2.X + PuntoOrigen[0], -Punto2.Y + PuntoOrigen[1]);
            gp.DrawLine(BlackPen, Punto2.X + PuntoOrigen[0], -Punto2.Y + PuntoOrigen[1], Punto3.X + PuntoOrigen[0], -Punto3.Y + PuntoOrigen[1]);
            gp.DrawLine(BlackPen, Punto3.X + PuntoOrigen[0], -Punto3.Y + PuntoOrigen[1], Punto4.X + PuntoOrigen[0], -Punto4.Y + PuntoOrigen[1]);
            gp.DrawLine(BlackPen, Punto4.X + PuntoOrigen[0], -Punto4.Y + PuntoOrigen[1], Punto1.X + PuntoOrigen[0], -Punto1.Y + PuntoOrigen[1]);
        }
        private void button1_Click(object sender, EventArgs e)
        {

            BlackPen = new Pen(Color.Black, 1.5F);
            WhitePen = new Pen(Color.White, 1.5F);

            DibujarFigura();

            //Creamos la instancia del hilo
            Thread hilo = new Thread(animacion2);
            //Iniciamos el hilo
            hilo.Start();
           

        }
        private void animacion2()
        {
            float cont = 0;
            while (cont < 100)
            {
                Thread.Sleep(500);
                DibujarEjes();
                rotar(cont);

                cont=cont+.1F;

            }

        }
        public void animacion1()
        {

            int cont = 0;
            
            while (cont <400)
            {
                Thread.Sleep(20);
                DibujarEjes();
                trasladar(-.20F, 0);
                
                cont++;
            }
            cont = 0;
            while (cont < 400)
            {
                Thread.Sleep(20);
                DibujarEjes();
                trasladar(0, -.20F);
                
                cont++;

            }
            cont = 0;
            while (cont < 45)
            {
                Thread.Sleep(20);
                DibujarEjes();
                rotar(.1F);
                Thread.Sleep(1000);
                cont++;

            }
            cont = 0;
            while (cont < 400)
            {
                Thread.Sleep(20);
                DibujarEjes();
                trasladar(.20F, 0);
                
                
                cont++;

            }
            cont = 0;
            while (cont < 400)
            {
                Thread.Sleep(10);
                DibujarEjes();
                trasladar(0, .20F);
               
                cont++;

            }
           


        }

        private void rotar(float angulo)
        {
            Punto1.rotar(angulo);
            Punto2.rotar(angulo);
            Punto3.rotar(angulo);
            Punto4.rotar(angulo);
            Console.WriteLine("----------");
            DibujarFigura();
        }
        private void trasladar(float x,float y)
        {
            Punto1.trasladar(x, y);
            Punto2.trasladar(x, y);
            Punto3.trasladar(x, y);
            Punto4.trasladar(x, y);

            DibujarFigura();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
