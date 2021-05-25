using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert_zero_and_one_to_0_and_1
{
    /*
     Create a function that takes a string as an argument. The function must return a string containing 
    1s and 0s based on the string argument's words. If any word in the argument is not equal to "zero" or "one" 
    (case insensitive), you should ignore it. The returned string's length should be a multiple of 8, 
    if the string is not a multiple of 8 you should remove the numbers in excess.
     */
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite sequências de zero e um");
            string sentence = Console.ReadLine();

            Console.WriteLine(Convert(sentence));

        }

        public static string Convert(string sentence)
        {
            return sentence.Replace("zero", "0").Replace("um", "1").Replace("ZERO", "0").Replace("UM", "1");
        }
    }
}
