using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_and_an_exponent
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Create a function that takes a base number and an exponent number and returns the calculation.
             */

            Console.WriteLine("Digite a base");
            double n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o expoente");
            double n2 = int.Parse(Console.ReadLine());

            double result = Math.Pow(n1, n2);
            Console.WriteLine("O resultado de {0} elevado à {1}, é {2}", n1, n2, result);



        }
    }
}
