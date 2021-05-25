using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fatorial
{
    class Program
    {
        /*
         Create a function that takes an integer and returns the factorial of that integer. 
        That is, the integer multiplied by all positive lower integers.
         */
        static void Main(string[] args)
        {
            int number, factorial = 1;
            Console.WriteLine("Digite um número");
            number = int.Parse(Console.ReadLine());

            if(number < 0)
            {
                Console.WriteLine("Não existe fatorial de número negativo");
            } else if(number <= 1)
            {
                Console.WriteLine("O fatorial de {0} é {1}", number, factorial);
            } else
            {
                for(int counter = number; counter >= 2; counter--)
                {
                    factorial = factorial * counter;

                }
                Console.WriteLine("O fatorial de {0} é {1}", number, factorial);
            }
        }
        

        

    }
}
