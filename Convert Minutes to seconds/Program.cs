using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert_Minutes_to_seconds
{
    class Program
    {
        /*
         Write a function that takes an integer minutes and converts it to seconds.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o número de minutos"); // , para decimal
            double Minutes = double.Parse(Console.ReadLine());

            Console.WriteLine(MinutesToSeconds(Minutes)+ " seconds");
        }

        public static double MinutesToSeconds(double Minutes)
        {
            double totalOfSeconds = Minutes * 60;
            return totalOfSeconds;
        }
    }
}
