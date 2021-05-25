using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Re_form_the_word
{
    class Program
    {
        /*
         A word has been split into a left part and a right part. Re-form the word by 
        adding both halves together, changing the first character to an uppercase letter.
         */
        static void Main(string[] args)
        {

            Console.WriteLine("Entre com 1/2 palavra");
            string p1 = Console.ReadLine();
            Console.WriteLine("Entre com outra 1/2 palavra");
            string p2 = Console.ReadLine();

            string[] myArray = new string[2];
            myArray[0] = p1;
            myArray[1] = p2;

           
            Console.WriteLine(CompleteTheWord(myArray));


        }

        public static string CompleteTheWord(string[] myArray)
        {
           string NewWord = myArray[0] + myArray[1];
            return NewWord;
        }

    }
}
