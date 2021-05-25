using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Farm_Problem
{

    /*
     In this challenge, a farmer is asking you to tell him how many 
    legs can be counted among all his animals. The farmer breeds three species:
        chickens = 2 legs
        cows = 4 legs
        pigs = 4 legs
    The farmer has counted his animals and he gives you a subtotal for each species. 
    You have to implement a function that returns the total number of legs of all the animals.
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o número de galinhas");
            int Chickens = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o número de vacas");
            int Cows = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o número de porcos");
            int Pigs = int.Parse(Console.ReadLine());

            int ChickensLegs = 2;
            int CowsLegs = 4;
            int PigsLegs = 4;

            int totalOfChickens = Chickens * ChickensLegs;
            int totalOfCows = Cows * CowsLegs;
            int totalOfPigs = Pigs * PigsLegs;


            Console.WriteLine("O total de pernas de animais na fazenda é de {0}", totalOfChickens + totalOfCows + totalOfPigs);

        }
    }
}
