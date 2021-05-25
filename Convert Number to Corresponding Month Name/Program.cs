using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert_Number_to_Corresponding_Month_Name
{
    class Program
    {

        /*
         Create a function that takes a number (from 1 to 12) and returns its corresponding month name as a string. 
        For example, if you're given 3 as input, your function should return "March", because March is the 3rd month.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o número do mês");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine(MonthName(num));
            
        }
        
        public static string MonthName(int num)
        {
            switch (num)
            {
                case 1:
                    return "Janeiro";
                case 2:
                    return "Fevereiro";
                case 3:
                    return "Março";
                case 4:
                    return "Abril";
                case 5:
                    return "Maio";
                case 6:
                    return "Junho";
                case 7:
                    return "Julho";
                case 8:
                    return "Agosto";
                case 9:
                    return "Setembro";
                case 10:
                    return "Outubro";
                case 11:
                    return "Novembro";
                case 12:
                    return "Dezembro";
                default:
                    return "Finish";


            }
        }
        
    }
}
