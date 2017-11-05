using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the 'Guess The Number' game!");

            Random rnd = new Random();
            bool isGuessed = false;
            int min = 1;
            int max = 100;
            int numOfTries = 0;

            int answer = rnd.Next(min, max + 1);

            do
            {
                // Vragen om input
                string input;
                int number = AskInput(number, input);
                
                // Verwerken van input
                if(number < answer)
                {
                    Console.WriteLine("Sorry your guess is too low!");
                }

                if(number > answer)
                {
                    Console.WriteLine("Sorry your guess is too high!");
                }
                
                if(number == answer)
                {
                    isGuessed = true;
                }

                numOfTries++;
                // Geef output
            } while (!isGuessed);

            Console.WriteLine("Yeah! You guessed my number! You are SOOOOO good!");
            Console.WriteLine("The number was indeed {0} you did it in {1} tries!", answer, numOfTries);

            // Afsluiten
            Console.WriteLine("Thank you for playing this awesome game!");
            Console.WriteLine("Press enter to exit...");
            Console.ReadLine();
        }
        static private int AskInput(int number, string input)
        {
            int min = 1;
            int max = 100;
            do
            {
                Console.WriteLine("Please enter a number: ({0} - {1})", min, max);
                input = Console.ReadLine();
            } while (!int.TryParse(input, out number) || min > number || max < number);

            return number;
        }
    }
}
