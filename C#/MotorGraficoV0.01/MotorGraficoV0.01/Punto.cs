using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorGraficoV0._01
{
    class Punto
    {
        private float x;
        private float y;


        public Punto(float x, float y)
        {
            this.X = x;
            this.Y = y;

        }

        public void trasladar(float x, float y)
        {

            this.x = this.x + x;
            this.y = this.y + y;

        }


        public void escalar(float escalar)
        {

            this.x = this.x * escalar;
            this.y = this.y * escalar;

        }

        public void rotar1(float angulo)
        {
            float x2 = 0;
            float y2 = 0;
            // trasladar(-this.x, -this.y);
            Console.WriteLine("*************X= " + this.x + "Y= " + this.y);
            x2 = ((this.x * Convert.ToSingle(Math.Cos(angulo))) - (-this.y * Convert.ToSingle(Math.Sin(angulo))));
            y2 = ((this.x * Convert.ToSingle(Math.Sin(angulo))) + (-this.y * Convert.ToSingle(Math.Cos(angulo))));

            Console.WriteLine("*************X= " + (this.x * Convert.ToSingle(Math.Cos(angulo))) + "  " + -(-this.y * Convert.ToSingle(Math.Sin(angulo))));
            Console.WriteLine("*************y= " + (this.x * Convert.ToSingle(Math.Sin(angulo))) + "  "+ (-this.y * Convert.ToSingle(Math.Cos(angulo))));
            this.x = x2;
            this.y = y2;
            Console.WriteLine("---cos " +Math.Cos(angulo) + "sen " + Math.Sin(angulo) + " angulo " + angulo);
            Console.WriteLine("---cos " + Convert.ToSingle(Math.Cos(angulo)) + "sen " + Convert.ToSingle(Math.Sin(angulo)) + " angulo " + angulo);
            Console.WriteLine("X= " + this.x + "Y= " + this.y);

           
            // trasladar(this.x, this.y);
        }
        public void rotar(float angulo)
        {
            float tempx = this.x;
            float tempy = this.y;

            trasladar(-Form1.PuntoOrigen[0]-tempx, -Form1.PuntoOrigen[1]-tempy);
            float x2 = 0;
            float y2 = 0;
            x2 = ((this.x * Convert.ToSingle(Math.Cos(angulo))) - (-this.y * Convert.ToSingle(Math.Sin(angulo))));
            y2 = ((this.x * Convert.ToSingle(Math.Sin(angulo))) + (-this.y * Convert.ToSingle(Math.Cos(angulo))));
            this.x = x2;
            this.y = y2;
            trasladar(Form1.PuntoOrigen[0]+tempx, Form1.PuntoOrigen[1]+ tempy);
            
        }


        public float X
        {
            get
            {
                return x;
            }

            set
            {
                x = value;
            }
        }

        public float Y
        {
            get
            {
                return y;
            }

            set
            {
                y = value;
            }
        }
    }
}
