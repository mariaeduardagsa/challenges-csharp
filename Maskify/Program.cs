using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maskify
{
    class Program
    {
        /*
         Usually when you sign up for an account to buy something, your credit card number, 
        phone number or answer to a secret question is partially obscured in some way. 
        Since someone could look over your shoulder, you don't want that shown on your screen. 
        Hence, the website masks these strings.

        Your task is to create a function that takes a string, transforms all but the last four 
        characters into "#" and returns the new masked string.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o número do cartão de crédito");
            string CreditCard = Console.ReadLine();

            Console.WriteLine(Maskify(CreditCard));
        }

        public static string Maskify(string CreditCard)
        {
            char[] chars = CreditCard.ToCharArray(); // ####-####-####-####
            for(int i = 0; i < chars.Length - 4; i++) // ############-1234
            {
                chars[i] = '#';
            }
            return new string(chars);
        }
    }
}
