using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorGrafico_V0._2
{
    class PuntoR3
    {
        private float x;
        private float y;
        private float z;
        private float angulo;
        public PuntoR3(float x, float y,float z,float angulo)
        {
            this.X = y+ (x*Convert.ToSingle(Math.Sin(angulo)));
            this.Y = z +( x * Convert.ToSingle(Math.Cos(angulo)));

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

        public void rotar(float angulo)
        {
            // trasladar(-this.x, -this.y);

            this.x = (this.x * Convert.ToSingle(Math.Cos(angulo))) - (this.y * Convert.ToSingle(Math.Sin(angulo)));
            this.y = -(this.x * Convert.ToSingle(Math.Sin(angulo))) + (this.y * Convert.ToSingle(Math.Cos(angulo)));


            // trasladar(this.x, this.y);
        }
        public void rotar1(float angulo)
        {

            this.x = ((this.x - Form1.PuntoOrigen[0]) * Convert.ToSingle(Math.Cos(angulo))) - ((this.y - Form1.PuntoOrigen[1]) * Convert.ToSingle(Math.Sin(angulo)) + Form1.PuntoOrigen[0]);
            this.y = ((this.x - Form1.PuntoOrigen[0]) * Convert.ToSingle(Math.Sin(angulo))) + ((this.y - Form1.PuntoOrigen[1]) * Convert.ToSingle(Math.Cos(angulo)) + Form1.PuntoOrigen[1]);


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

