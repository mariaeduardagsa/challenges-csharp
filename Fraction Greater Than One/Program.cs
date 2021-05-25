using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fraction_Greater_Than_One
{
    class Program
    {
        /*
         Given a fraction as a string, return whether or not it is greater than 1 when evaluated.
         */
        static void Main(string[] args)
        {

            Console.WriteLine("Digite a fração");
            string fraction = Console.ReadLine();


            Console.WriteLine("A fração {0} é maior que 1? {1}", fraction, greaterThanOne(fraction));


        }

        public static bool greaterThanOne(string fraction)
        {
            double[] array = Array.ConvertAll(fraction.Split('/'), double.Parse);
            return array[0] / array[1] > 1;
        }
    }
}
