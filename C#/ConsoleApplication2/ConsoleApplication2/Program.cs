using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2 {
    class Program {
        static void Main(string[] args) {
           
            // Static method on type Byte.
            byte a = Byte.MaxValue;
            float b = float.MaxValue;
            int c = int.MaxValue;

            Console.WriteLine("Valor maximo de a: " + a);
            Console.WriteLine("Valor maximo de b: " + b);
            Console.WriteLine("Valor maximo de c: " + c);


            Console.ReadKey();
            byte num = 0xA;
            int i = 5;
            char d = 'Z';

        }
    }
}
