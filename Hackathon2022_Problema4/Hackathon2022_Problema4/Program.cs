using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon2022_Problema4
{
    class Program
    {
        static void Main(string[] args)
        {
            int friendsNumber, portions;
            Console.WriteLine("Ingresa la cantidad de personas que comerán pastel:");
            friendsNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Ingresa la cantidad de porciones que comerá cada uno: ");
            portions = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("La cantidad de pasteles necesarios de 4 porciones es de: " + getCakesNumber(friendsNumber, portions));
            Console.ReadLine();
        }

        //Get the number of cakes that are needed to satisfy all
        private static double getCakesNumber(int friends, int portions)
        {
            double data = (friends * portions) / 4.0;
            double output = Math.Ceiling(data);
            return output;
        }
    }
}
