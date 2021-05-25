using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hacker_Speak
{
    class Program
    {
        /*
         Create a function that takes a string as an argument and returns a coded (h4ck3r 5p34k) version of the string.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a palavra para ser criptografada");
            string str = Console.ReadLine();

            Console.WriteLine(HackerSpeak(str)); 
        }
        public static string HackerSpeak(string str)
        {
            return str.Replace("a", "4").Replace("e", "3").Replace("i", "1").Replace("o", "0").Replace("s", "5");
        }

        
    }
}
