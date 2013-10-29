using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partitioning_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numeros = new double[50];
            for (int i = 0; i < 50; i++)
            {
                numeros[i] = i;
            }
            var primeros25Numeros = numeros.Take(25);
            var tomarMenosPrimeros15 = primeros25Numeros.Skip(15);
            var dividirEntreTres = tomarMenosPrimeros15.SkipWhile(n => n % 3 == 0);
            var dividirEntreDos = dividirEntreTres.TakeWhile(n => n % 2 == 0);

            foreach (var n in dividirEntreDos)
            {
                Console.WriteLine(n);
            }

            Console.ReadLine();
        }
    }
}
