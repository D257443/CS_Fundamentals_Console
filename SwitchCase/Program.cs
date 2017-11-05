using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declares strings and integers
            string input;
            string name;
            int age;
            int hp = 100;
            int fire;
            int blizzard;
            int shock;
            int backflip;

            // Makes random number picking possible
            Random rnd = new Random();

            Console.WriteLine("Please enter your name");
            name = Console.ReadLine();

            Console.WriteLine("Please enter your age");
            age = int.Parse(Console.ReadLine());
            if (age <= 17)
            {
                Console.WriteLine("You're too young to play this game!");
                Console.ReadLine();
                Environment.Exit(1);
            }
            else
            {
                Console.WriteLine("I hope you entered your real age...");
                
            }

            while (hp > 0)
            {
                Console.WriteLine("Press 1 or Q to cast a fire spell. Takes 5-15 hp off opponent's HP!");
                Console.WriteLine("Press 2 or W to cast a blizzard spell. Takes 10-20 hp off opponent's HP!");
                Console.WriteLine("Press 3 or E to cast a shock spell. Takes 3-10 hp off opponent's HP!");
                Console.WriteLine("Press 4 or R to cast a backflip. Does damage from 0-100 hp, but may also heal your opponent!");
                Console.WriteLine("Press 5 or T to do a barrel roll. Does nothing...");

                input = Console.ReadLine();
                fire = rnd.Next(5, 16);
                blizzard = rnd.Next(10, 21);
                shock = rnd.Next(3, 11);
                backflip = rnd.Next(-100, 100);
                switch (input)
                {
                    case "1":
                    case "q":
                    case "Q":
                        Console.WriteLine("{0} casted a fire spell", name);
                        hp = hp - fire;
                        Console.WriteLine("Your opponent has {0}HP left!", hp);
                        break;
                    case "2":
                    case "w":
                    case "W":
                        Console.WriteLine("{0} casted a blizzard spell", name);
                        hp = hp - blizzard;
                        Console.WriteLine("Your opponent has {0}HP left!", hp);
                        break;
                    case "3":
                    case "e":
                    case "E":
                        Console.WriteLine("{0} casted a shock spell", name);
                        hp = hp - shock;
                        Console.WriteLine("Your opponent has {0}HP left!", hp);
                        break;
                    case "4":
                    case "r":
                    case "R":
                        Console.WriteLine("{0} casted a backflip", name);
                        hp = hp - backflip;
                        Console.WriteLine("Your opponent has {0}HP left!", hp);
                        break;
                    case "5":
                    case "t":
                    case "T":
                        Console.WriteLine("{0} did a barrel roll. He broke the barrel...", name);
                        Process.Start("https://www.google.de/search?q=do+a+barrel+roll&oq=do+a+bar&aqs=chrome.0.69i59j69i57j69i60j0l3.1174j0j7&sourceid=chrome&ie=UTF-8");
                        break;
                    default:
                        Console.WriteLine("Mister {0}, I said you had to cast a spell... why did you enter {1}?!", name, input);
                        break;
                }
            }
            Console.WriteLine("You killed your opponent {0}! You are a real master!", name);
            
            Console.WriteLine("Press enter to exit...");
            Console.ReadLine();
        }
    }
}
