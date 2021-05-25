using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Is_the_Number_Less_than_or_Equal_to_Zero
{
    /*
     Create a function that takes a number as its only argument and returns true if it's less than or equal to zero, otherwise return false.
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o número");
            int Number = int.Parse(Console.ReadLine());

            Console.WriteLine("{0} <= 0 -> {1}", Number, LessOrEqual(Number));
        }

        public static bool LessOrEqual(int Number)
        {
            if(Number <= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
