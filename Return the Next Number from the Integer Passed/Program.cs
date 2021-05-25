using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Return_the_Next_Number_from_the_Integer_Passed
{
    class Program
    {
        /*
         Create a function that takes a number as an argument, increments the number by +1 and returns the result.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o número");
            int integerPassed = int.Parse(Console.ReadLine());

            Console.WriteLine("{0} + 1 = {1}", integerPassed, nextNumber(integerPassed));

        }

        public static int nextNumber(int integerPassed)
        {
            return integerPassed + 1;
        }

    }
}
