using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remove_the_First_and_the_Last_Characters
{
    class Program
    {

        /*
         Create a function that removes the first and last characters from a string.
         */
        static void Main(string[] args)
        {

            Console.WriteLine("Digite uma palavra");
            string str = Console.ReadLine();
           
            Console.WriteLine(RemoveFirstLast(str));

        }
        public static string RemoveFirstLast(string str)
        {
            if (str.Length <= 2)
                return str;
            else
                return str.Remove(str.Length - 1).Remove(0, 1);
        }
    }
}
