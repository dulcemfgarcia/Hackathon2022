using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon2020_Problema2
{
    class Program
    {
        static void Main(string[] args)
        {
            string word;
            Console.WriteLine("A continuación, mostraremos la cantidad de vocales en una palabre");
            Console.WriteLine("Ingresa una palabra");
            word = Console.ReadLine().ToUpper();
            Console.WriteLine();
            Console.WriteLine("La cantidad de vocales es: " + countVowels(word).ToString());
            Console.ReadLine();

        }

        //Function to count the vowels on a string
        private static int countVowels(string word)
        {
            int vowelCounter = 0;
            char[] wordVowels = word.ToCharArray();
            for(int i = 0; i < word.ToString().Length; i++)
            {
                if(wordVowels[i] == 'A' || wordVowels[i] == 'E' || wordVowels[i] == 'I' || wordVowels[i] == 'O' ||
                     wordVowels[i] == 'U')
                {
                    vowelCounter++;
                }
            }
            return vowelCounter;
        }
    }
}
