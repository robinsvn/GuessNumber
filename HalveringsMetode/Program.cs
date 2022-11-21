using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalveringsMetode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int returnValue = random.Next(1, 50);

            int Guess = 0;
            int GuessNumber = 0;

            Console.WriteLine("Jeg tenker på ett nummer imellom 1 til 50. Gjett hva det er.");

            while (Guess != returnValue)
            {
                Guess = Convert.ToInt32(Console.ReadLine());

                if (Guess < returnValue)
                {
                    Console.WriteLine("Nummeret er høyere enn " + Guess + ". Prøv på nytt.");
                    GuessNumber++;
                }
                else if (Guess > returnValue)
                {
                    Console.WriteLine("Nummeret er lavere enn " + Guess + ". Prøv på nytt.");
                    GuessNumber++;
                }

            }

            Console.WriteLine("Riktig! Svaret var : " + returnValue + ". Du gjettet " + GuessNumber + " Antall ganger.");
            Console.ReadLine();
        }
    }
}
