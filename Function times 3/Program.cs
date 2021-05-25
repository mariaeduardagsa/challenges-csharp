using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function_times_3
{
    class Program
    {
        /*
         Create a function that takes three collections of arguments and returns the sum of the product of numbers.
         */
        static void Main(string[] args)
        {
            int[] myArray1 = new int[2];
            Console.WriteLine("Digite o primeiro número");
            myArray1[0] = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número");
            myArray1[1] = int.Parse(Console.ReadLine());

            int[] myArray2 = new int[2];
            Console.WriteLine("Digite o terceiro número");
            myArray2[0] = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o quarto número");
            myArray2[1] = int.Parse(Console.ReadLine());

            int[] myArray3 = new int[2];
            Console.WriteLine("Digite o quinto número");
            myArray3[0] = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o sexto número");
            myArray3[1] = int.Parse(Console.ReadLine());

            Console.WriteLine("{0} * {1} * {2} + {3} * {4} * {5} = {6}", myArray1[0], myArray2[0], myArray3[0], myArray1[1], myArray2[1], myArray3[1], times3(myArray1,myArray2, myArray3));


        }
        public static int times3(int[] myArray1, int[] myArray2, int[] myArray3)
        {
            int result =(( myArray1[0] * myArray2[0] * myArray3[0]) + (myArray1[1] * myArray2[1] * myArray3[1]));
            return result; 
        }
    }
}
