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

namespace MotorGrafico_V0._2
{
    public partial class Form1 : Form
    {
        public static Int32[] PuntoOrigen;
        private PuntoR3 Punto1;
        private PuntoR3 Punto2;
        private PuntoR3 Punto3;
        private PuntoR3 Punto4;
        private PuntoR3 Punto5;
        private PuntoR3 Punto6;
        private PuntoR3 Punto7;
        private PuntoR3 Punto8;
        private Graphics gp;
        private Graphics gp2;
        private Pen BlackPen;




        public Form1()
        {
            InitializeComponent();
            PuntoOrigen = new Int32[2];
            PuntoOrigen[0] = 320;
            PuntoOrigen[1] = 240;
            


            Punto1 = new PuntoR3(40, 0, 0, 120);
            Punto2 = new PuntoR3(40, 40, 0, 120);
            Punto3 = new PuntoR3(40, 0, 40, 120);
            Punto4 = new PuntoR3(40, 40, 40, 120);
            Punto5 = new PuntoR3(0, 0, 40, 120);
            Punto6 = new PuntoR3(0, 40, 40, 120);
            Punto7 = new PuntoR3(0, 40, 0, 120);
            Punto8 = new PuntoR3(0, 0, 0, 120);
            gp = panel1.CreateGraphics();
            gp2 = panel1.CreateGraphics();
            BlackPen = new Pen(Color.Black, 1.5F);


        }

        private void DibujarEjes()
        {
            
                gp.Clear(Color.White);
                gp.DrawLine(BlackPen, PuntoOrigen[0], PuntoOrigen[1], 640, PuntoOrigen[1]);
                gp.DrawLine(BlackPen, PuntoOrigen[0], PuntoOrigen[1], PuntoOrigen[0], 0);
                gp.DrawLine(BlackPen, PuntoOrigen[0], PuntoOrigen[1], 0, 480);
                
            


        }
        private void animacion1()
        {
            float contador=0;
            while (true) {
                if (contador == 361)
                {
                    contador = 0;
                }
                Punto1 = new PuntoR3(40, 0, 0, contador);
                Punto2 = new PuntoR3(40, 40, 0, contador);
                Punto3 = new PuntoR3(40, 0, 40, contador);
                Punto4 = new PuntoR3(40, 40, 40, contador);
                Punto5 = new PuntoR3(0, 0, 40, contador);
                Punto6 = new PuntoR3(0, 40, 40, contador);
                Punto7 = new PuntoR3(0, 40, 0, contador);
                Punto8 = new PuntoR3(0, 0, 0, contador);
                contador=contador + 0.01F;
                Thread.Sleep(35);
                
            }

        }

        private void DibujarFigura()
        {
            while (true) {
                DibujarEjes();
                gp2.DrawLine(BlackPen, Punto1.X + PuntoOrigen[0], -Punto1.Y + PuntoOrigen[1], Punto2.X + PuntoOrigen[0], -Punto2.Y + PuntoOrigen[1]);
                gp2.DrawLine(BlackPen, Punto1.X + PuntoOrigen[0], -Punto1.Y + PuntoOrigen[1], Punto3.X + PuntoOrigen[0], -Punto3.Y + PuntoOrigen[1]);
                gp2.DrawLine(BlackPen, Punto2.X + PuntoOrigen[0], -Punto2.Y + PuntoOrigen[1], Punto4.X + PuntoOrigen[0], -Punto4.Y + PuntoOrigen[1]);
                gp2.DrawLine(BlackPen, Punto3.X + PuntoOrigen[0], -Punto3.Y + PuntoOrigen[1], Punto4.X + PuntoOrigen[0], -Punto4.Y + PuntoOrigen[1]);
                gp2.DrawLine(BlackPen, Punto3.X + PuntoOrigen[0], -Punto3.Y + PuntoOrigen[1], Punto5.X + PuntoOrigen[0], -Punto5.Y + PuntoOrigen[1]);
                gp2.DrawLine(BlackPen, Punto5.X + PuntoOrigen[0], -Punto5.Y + PuntoOrigen[1], Punto6.X + PuntoOrigen[0], -Punto6.Y + PuntoOrigen[1]);
                gp2.DrawLine(BlackPen, Punto6.X + PuntoOrigen[0], -Punto6.Y + PuntoOrigen[1], Punto4.X + PuntoOrigen[0], -Punto4.Y + PuntoOrigen[1]);
                gp2.DrawLine(BlackPen, Punto7.X + PuntoOrigen[0], -Punto7.Y + PuntoOrigen[1], Punto2.X + PuntoOrigen[0], -Punto2.Y + PuntoOrigen[1]);
                gp2.DrawLine(BlackPen, Punto7.X + PuntoOrigen[0], -Punto7.Y + PuntoOrigen[1], Punto6.X + PuntoOrigen[0], -Punto6.Y + PuntoOrigen[1]);
                gp2.DrawLine(BlackPen, Punto8.X + PuntoOrigen[0], -Punto8.Y + PuntoOrigen[1], Punto1.X + PuntoOrigen[0], -Punto1.Y + PuntoOrigen[1]);
                gp2.DrawLine(BlackPen, Punto8.X + PuntoOrigen[0], -Punto8.Y + PuntoOrigen[1], Punto5.X + PuntoOrigen[0], -Punto5.Y + PuntoOrigen[1]);
                gp2.DrawLine(BlackPen, Punto8.X + PuntoOrigen[0], -Punto8.Y + PuntoOrigen[1], Punto7.X + PuntoOrigen[0], -Punto7.Y + PuntoOrigen[1]);
                Thread.Sleep(34);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread hilo = new Thread(DibujarFigura);
            Thread hilo2 = new Thread(animacion1);
            
            
          
            hilo.Start();
            hilo2.Priority = System.Threading.ThreadPriority.Highest;
            hilo2.Start();
            
            
            //hilo2.Join();
            
            
            
        }
    }
}
