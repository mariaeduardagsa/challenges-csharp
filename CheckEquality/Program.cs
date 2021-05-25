using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckEquality
{
    class Program
    {

        /*
         In this challenge, you must verify the equality of two different values given the parameters a and b.

        Both the value and type of the parameters need to be equal. The possible types of the given parameters are:

            Numbers
            Strings
            Booleans (false or true)
        What have you learned so far that will permit you to do two different checks (value and type) with a single statement?

        Implement a function that returns true if the parameters are equal, and false if they are not.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("({0}, {1}) = {2}", 1, true, CheckEquality(1, true));
            Console.WriteLine("({0}, {1}) = {2}", false, false, CheckEquality(false, false));
            Console.WriteLine("({0}, {1}) = {2}", 0, "Oi", CheckEquality(0, "Oi"));


        }
        public static bool CheckEquality(object a, object b) // object quando n tem definido o type
        {
           
            return a.Equals(b);

        }
    }
}
