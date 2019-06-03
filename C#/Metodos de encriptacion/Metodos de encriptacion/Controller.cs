using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Metodos_de_encriptacion
{
    class Controller
    {
        private String cadena;
        private String cadenaEncriptada;

        public Controller()
        {
            this.Cadena = "";
            this.CadenaEncriptada = "";
        }

        public String encriptarCesar(String texto)
        {
            cadena = texto;
            texto = texto.ToUpper();
            char[] aux = texto.ToCharArray();
            texto = "";

            for (int i = 0; i < aux.Length; i++)
            {
                MessageBox.Show("" + aux[i] + "---" + ((int)aux[i]));
                int cont = ((int)aux[i]);
                if (cont != 10 && cont != 32)
                {
                    cont = cont + 3;
                    if (cont > 90)
                    {
                        cont = cont - 26;
                    }
                    texto = texto + ((char)cont);
                }
                else
                {
                    
                    texto = texto + ((char)cont);
                }
               
                

            }
            cadenaEncriptada = texto;
            return texto;
        }


        public String encriptarPolybios()
        {





            return null;
        }



        public string Cadena
        {
            get
            {
                return cadena;
            }

            set
            {
                cadena = value;
            }
        }

        public string CadenaEncriptada
        {
            get
            {
                return cadenaEncriptada;
            }

            set
            {
                cadenaEncriptada = value;
            }
        }
    }
}
