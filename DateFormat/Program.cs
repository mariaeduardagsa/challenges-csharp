using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateFormat
{
    /*
     Create a function that converts a date formatted as MM/DD/YYYY to YYYYDDMM.
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com a data: ");
            string date = Console.ReadLine();

            Console.WriteLine(FormatDate(date));
        }
        public static string FormatDate(string date)
        {
            DateTime inputDate = DateTime.Parse(date);
            return inputDate.ToString("yyyyddMM");
        }
    }
}
