using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program1
    {
        static void Main(string[] args)
        {

            /*
           
            Tipo de .NET Tipo de C# o alias
                 System.Boolean      bool
                 System.Byte         byte
                 System.Sbyte        sbyte
                 System.Char         char
                 System.Decimal      decimal
                 System.Double       double
                 System.Single       float
                 System.Int32        int
                 System.UInt32       uint
                 System.Int64        long
                 System.UInt64       ulong
                 System.Object       object
                 System.Int16        short
                 System.UInt16       ushort
                 System.String       string   

               

            */

            // Byte.

            byte byte1 = Byte.MaxValue;

            //Int
            /*
            Declaración de C #: int mes;
            C # Inicialización: mes = 10;
            C # por defecto el valor de inicialización: 0;
             */

            //Ejemplo:
            int int1 = int.MaxValue;

            System.Int32 int2 = System.Int32.MaxValue;


            //Float && Double
            /*
            Declaración de C #: Float num;
            C # Inicialización: num = 10.34;
            C # por defecto el valor de inicialización: 0.0;

            float tiene menor precisión que double. Tiene 7 dígitos de
            precisión y double 14 o 15 dígitos.

            Si hubiese ambigüedad acerca de si un determinado valor en coma flotante es float o
            double, por defecto se convierte a double.
            */
            //Ejemplo:

            float float1 = float.MaxValue;
            double double1 = double.MaxValue;


           

            Console.WriteLine("Valor maximo de int1: " + int1);
            Console.WriteLine("Valor maximo de int2: " + int2);
            Console.WriteLine("Valor maximo de float1: " + float1);
            Console.WriteLine("Valor maximo de double1: " + double1);
            Console.WriteLine("Valor maximo de byte1: " + byte1);




           //Bool
           /*
           Tiempo de ejecución de C # Tipo: System
           Declaración de C #: bool bandera;
           C #inicialización #: bandera = true;
           C # por defecto el valor de inicialización: false
           */
           //Ejemplo:

            Console.ReadKey();
            bool booleano1 = (int1==float1);
            Console.WriteLine("el valor del booleano1: "+booleano1);

            bool booleano2 = (int1 == int2);
            Console.WriteLine("el valor del booleano2: "+booleano2);

            /*
            Char
                  
            Declaración de C #: char unCaracter;
            C #inicialización #: char unCaracter=’a’;
            C # por defecto el valor de inicialización: '\0'
            
            Ejemplo:
            */

            char caracter1 = 'Z';
            Console.WriteLine("La variable caracter1 contiene:  "+caracter1);
            


            //Variable Var

            //Es compilado como Int 
            var w = 5;

            // Es compilado como String
            var s = "Hello";

            // es compilado como int[]
            var z = new[] { 0, 1, 2 };


            Console.ReadKey();
            //Objetos 
            MyObject objeto1 = new MyObject();
            int var1 = objeto1.sumar(5, 5);


            Console.WriteLine("El valor de var1 es: "+var1);

            Console.ReadKey();




            /*
            Enum

            Permite utilizar un grupo de constantes a través de nombres asociados que
            son más representativos que dichas constantes. Las constantes pueden ser de los tipos
            siguientes: byte, short, int o long.


             */

            /*
             Struct 

             Un tipo struct es similar a un tipo class -puede contener constructores, constantes,
             métodos, etc...-, con una diferencia muy importante: class es de tipo referencia, y
             struct de tipo valor.
             */


            //Tipos Referencia
            /*
            Array

            Un array es un tipo referencia que contiene un conjunto ordenado de datos que son
            variables (elementos) a los que se accede a través de índices. Estas variables pueden ser
            –a su vez- de tipo valor o de tipo referencia.

            */
            int[] array1;
            int[] array2={ 1,2,9,4,5};
            Console.WriteLine("El elemento del array en la posicion 3 es: "+array2[1]);
            Console.ReadKey();

            /*
           String

           El tipo string representa una cadena de caracteres UNICODE. 
           Un objeto string se maneja como un objeto de una clase cualquiera. Pero además, en
           este caso, se permite crearlo y utilizarlo directamente, a partir de literales:
           */

            string unaCadena = "Hola ";
            string otraCadena = "Mundo";
            String cadena = unaCadena+otraCadena;


            Console.WriteLine("El string cadena contiene: "+cadena);

            Console.ReadKey();



        }
    }
}
