using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Return_the_Middle_Character_s__of_a_String
{
    class Program
    {
        /*
         Create a function that takes a string and returns the middle character(s). 
        If the word's length is odd, return the middle character. If the word's length is even, 
        return the middle two characters.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a palavra");
            string word = Console.ReadLine();

            Console.WriteLine(ReturnTheMiddle(word));
        }
        public static string ReturnTheMiddle(string word)
        {
            int i = 1 - word.Length % 2;
            return word.Substring(word.Length / 2 - i, 1 + i);
        }
    }
}
