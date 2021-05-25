using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Pin_Code_Validation
{
    class Program
    {
        /*
         ATM machines allow 4 or 6 digit PIN codes and PIN codes cannot contain anything but exactly 4 digits or exactly 6 digits. 
        Your task is to create a function that takes a string and returns true if the PIN is valid and false if it's not.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o PIN");
            string pin = Console.ReadLine();

            Console.WriteLine(ValidatePin(pin));
        }
        public static bool ValidatePin(string pin)
        {
            return (pin.Length == 4 || pin.Length == 6) && pin.All(char.IsDigit);
        }
    }
}
