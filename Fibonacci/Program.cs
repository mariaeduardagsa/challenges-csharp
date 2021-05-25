using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        /*
         Create a function to return the Nth number in the Fibonacci 
        sequence as a string.
         */
        static void Main(string[] args)
        {
            int a = 0, b = 1, c = 0;

            Console.WriteLine("Quantos valores: ");
            int values = int.Parse(Console.ReadLine());

            Console.WriteLine("Sequência de Fibonacci com {0} {1}", values, "valores");
            
            for(int i = 0; i < values; i++)
            {
                if (i < values - 1)
                {
                    Console.Write(a + ", ");
                } else
                {
                    Console.WriteLine(a);
                }
                
                c = a + b;
                a = b;
                b = c;
            }
            
        }
    }
}
