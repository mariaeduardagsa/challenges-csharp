using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scottish_Screaming
{
    /*
     A strong Scottish accent makes every vowel similar to an "e", so you should replace every vowel with an "e". 
     Additionally, it is being screamed, so it should be in block capitals.

     Create a function that takes a string and returns a string.
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a frase a ser traduzida para o scottish screaming");
            string sentence = Console.ReadLine();

            Console.WriteLine(ScottishScreaming(sentence));
        }

        public static string ScottishScreaming(string sentence)
        {
            return sentence.Replace("o", "e").Replace("O", "E").Replace("A", "E").Replace("a", "e").Replace("U", "E").Replace("u", "e").Replace("I", "E").Replace("i", "e");

        }
    }
}
