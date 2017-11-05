using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ThrowDie
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the dice simulator");

            Random rnd = new Random();
            int sides;


                    sides = 4;
            int roll = ThrowDie(rnd, sides);

                Console.WriteLine("You have thrown a {0} with {1} sides", roll, sides);
            Console.WriteLine("Press enter to exit..");
            Console.ReadLine();
        }

        static public int ThrowDie(Random rnd, int sides)
        {
            int roll = rnd.Next(1, sides + 1);

            return roll;
        }
        // 1. zorg dat je een aantal keer rolt met D4, D6, D8, D10, D12, D20
        // 2. Maak van GuessTheNumber input vragen een methode
    }
}
