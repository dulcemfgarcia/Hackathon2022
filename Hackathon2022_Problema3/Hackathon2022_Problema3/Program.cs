using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon2022_Problema3
{
    class Program
    {
        public static string factorial;
        static void Main(string[] args)
        {
            Console.WriteLine("Sumatoria Factorial");
            Console.WriteLine();
            getData();
            int value = Convert.ToInt32(factorial.Substring(0, (factorial.Length - 1)));
            Console.WriteLine();
            Console.WriteLine("El resultado de la suma factorial es: " + factorialSum(value));
            Console.ReadLine();
        }

        private static int factorialSum(int fact)
        {
            
            if(fact == 0)
            {
                return 1;
            }
            else
            {
                return fact * factorialSum(fact - 1);
            }

        }

        private static bool validateData(string data)
        {
            bool status = false;
            string factorialSymbol = data.Substring(data.Length - 1, 1);
            if(factorialSymbol == "!")
            {
                return true;
            }
            else
            {
                Console.WriteLine("Ingresaste un número sin el símbolo de factorial, inténtalo de nuevo");
                Console.WriteLine();
            }
            return status;
        }

        private static void getData()
        {
            Console.WriteLine("Ingresa un número y seguido de él un signo de admiración '!'. Ej: 10! ");
            factorial = Console.ReadLine();
            if (!validateData(factorial))
            {
                getData();
            }
        }
    }
}
