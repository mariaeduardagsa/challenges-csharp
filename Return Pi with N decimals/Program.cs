using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Return_Pi_with_N_decimals
{
    /*
     Given a number n, write a function that returns PI to n decimal places.
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o número de casas do número PI ( < 15) ");
            int decimals = int.Parse(Console.ReadLine());

            Console.WriteLine(myPi(decimals));
        }
        public static decimal myPi(int decimals)
        {
            decimal Pi = 3.141592653589793M;
            decimal returnPi = Math.Round(Pi, decimals);

            return returnPi;
        }
    }
}
