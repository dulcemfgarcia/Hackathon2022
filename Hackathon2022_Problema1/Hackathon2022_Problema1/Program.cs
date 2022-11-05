using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon2022_Problema1
{
    class Program
    {
        public static string optionOperation, optionBase;
        public static int number1, number2;
        static void Main(string[] args)
        {
            //get the numbers to operate
            Console.WriteLine("Ingresa un número");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresa otro número");
            number2 = Convert.ToInt32(Console.ReadLine());

            //get the type of operation
            getOperation();

            //get the base
            getBase();

            //Operate, verificate the base and the operation type to operate the numbers
            switch (optionBase)
            {
                case "1":

                    if(optionOperation == "1")
                    {
                        AddInBinary(number1, number2);
                    }
                    else
                    {
                        subInBinary(number1, number2);
                    }

                    break;

                case "2":

                    if (optionOperation == "1")
                    {
                        AddInHexadecimal(number1, number2);
                    }
                    else
                    {
                        subInHexadecimal(number1, number2);
                    }

                    break;

                case "3":
                    if (optionOperation == "1")
                    {
                        AddInDecimal(number1, number2);
                    }
                    else
                    {
                        subInDecimal(number1, number2);
                    }

                    break;


            }
        }
         
        //Methonds to operate in different bases
        private static void AddInBinary(int number1, int number2)
        {

        }
        private static void AddInDecimal(int number1, int number2)
        {
            Console.WriteLine("el resultado de la suma es: " + (number1 + number2));
        }
        private static void AddInHexadecimal(int number1, int number2)
        {

        }
        private static void subInBinary(int number1, int number2)
        {

        }
        private static void subInDecimal(int number1, int number2)
        {
            Console.WriteLine("el resultado de la suma es: " + (number1 - number2));
        }
        private static void subInHexadecimal(int number1, int number2)
        {

        }
        private static void convertToDecimal(int number, int numberBase)
        {

        }
        private static void convertToHexadecimal(int number, int numberBase)
        {

        }
        private static void convertToBinary(int number, int numberBase)
        {

        }

        private static void getOperation()
        {
            Console.WriteLine("-------Presiona según la operación a realizar:-------");
            Console.WriteLine("------------------1. si deseas sumar.----------------");
            Console.WriteLine("------------------2. si deseas restar.---------------");
            optionOperation = Console.ReadLine();
            if (!validateData(optionOperation, 2))
            {
                getOperation();
            }
        }
        private static void getBase()
        {
            Console.WriteLine("-Presiona un número según la base a utilizar:-");
            Console.WriteLine("----------------1. Base binaria.--------------");
            Console.WriteLine("----------------2. Base hexadecimal.----------");
            Console.WriteLine("----------------3. Base decimal.--------------");
            optionBase = Console.ReadLine();
            if (!validateData(optionBase, 3))
            {
                getBase();
            }
        }

        private static bool validateData(string option, int max)
        {
            bool status = true;
            if(Convert.ToInt32(option) > max)
            {
                Console.WriteLine("ingresaste una opción no válida, intenta de nuevo. \t");
                status = false;
            }
            return status;
        }
    }
}
