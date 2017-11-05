using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame2P
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declares strings and integers needed in the game
            string input;
            string player1;
            string player2;
            int hp1 = 100;
            int hp2 = 100;
            int fire;
            int blizzard;
            int shock;
            int revive;
            int turn1 = 1;
            int turn2 = 0;
            int revive1 = 2;
            int revive2 = 2;

            Random rnd = new Random();

            Console.WriteLine("Player 1, please enter your name:");
            player1 = Console.ReadLine();

            Console.WriteLine("Player 2, please enter your name:");
            player2 = Console.ReadLine();

            if (player1 == "Fedde" || player2 == "Fedde")
            {
                Console.WriteLine("Your name is really Fedde? You're not gonna play!");
                Console.ReadLine();
                Environment.Exit(1);
            }
            else if (player1 == "Sietse" || player2 == "Sietse")
            {
                Console.WriteLine("Your name is really Sietse? You're not gonna play!");
                Console.ReadLine();
                Environment.Exit(1);
            }

            while (hp1 >= 0 || hp2 >= 0)
            {
                if (turn1 == 1)
                {

                    Console.WriteLine("{0}, choose an option!", player1);
                    Console.WriteLine("Press 1 to cast a fire spell!");
                    Console.WriteLine("Press 2 to cast a blizzard spell!");
                    Console.WriteLine("Press 3 to cast a shock spell!");
                    Console.WriteLine("Press 4 to cast a revive spell! You can still use revive {0} times!", revive1);
                    input = Console.ReadLine();

                    fire = rnd.Next(5, 16);
                    blizzard = rnd.Next(10, 21);
                    shock = rnd.Next(3, 11);
                    revive = rnd.Next(-25, 1);

                    switch (input)
                    {
                        case "1":
                            Console.WriteLine("{0} casted a fire spell!", player1);
                            hp2 = hp2 - fire;
                            Console.WriteLine("{0} has {1}HP left!", player2, hp2);
                            turn1 = turn1 - 1;
                            turn2 = turn2 + 1;
                        break;
                        case "2":
                            Console.WriteLine("{0} casted a blizzard spell!", player1);
                            hp2 = hp2 - blizzard;
                            Console.WriteLine("{0} has {1}HP left!", player2, hp2);
                            turn1 = turn1 - 1;
                            turn2 = turn2 + 1;
                            break;
                        case "3":
                            Console.WriteLine("{0} casted a shock spell!", player1);
                            hp2 = hp2 - shock;
                            Console.WriteLine("{0} has {1}HP left!", player2, hp2);
                            turn1 = turn1 - 1;
                            turn2 = turn2 + 1;
                            break;
                        case "4":
                            if (revive1 >= 1)
                            {
                                Console.WriteLine("{0} casted a revive spell!", player1);
                                hp1 = hp1 - revive;
                                Console.WriteLine("{0} now has {1}HP left!", player1, hp1);
                                turn1 = turn1 - 1;
                                turn2 = turn2 + 1;
                                revive1 = revive1 - 1;
                            }
                            else
                            {
                                Console.WriteLine("You can't cast another revive spell on yourself! Your health will reduce with 10HP!");
                                hp1 = hp1 - 10;
                                turn1 = turn1 - 1;
                                turn2 = turn2 + 1;
                                Console.WriteLine("{0} has {1}HP left!", player1, hp1);
                            }
                            break;
                        default:
                            Console.WriteLine("Answer not valid, press enter to try again!");
                            Console.ReadLine();
                            break;
                    }
                    if (hp1 <= 0)
                    {
                        Console.WriteLine("Congratulations {0}! You won!", player2);
                        Console.WriteLine("Press enter to exit...");
                        Console.ReadLine();
                        Environment.Exit(1);
                    }
                    if (hp2 <= 0)
                    {
                        Console.WriteLine("Congratulations {0}! You won!", player1);
                        Console.WriteLine("Press enter to exit...");
                        Console.ReadLine();
                        Environment.Exit(1);
                    }
                    if (turn2 == 1)
                    {
                        Console.WriteLine("{0}, choose an option!", player2);
                        Console.WriteLine("Press 1 to cast a fire spell!");
                        Console.WriteLine("Press 2 to cast a blizzard spell!");
                        Console.WriteLine("Press 3 to cast a shock spell!");
                        Console.WriteLine("Press 4 to cast a revive spell! You can still use revive {0} times!", revive2);
                        input = Console.ReadLine();

                        fire = rnd.Next(5, 16);
                        blizzard = rnd.Next(10, 21);
                        shock = rnd.Next(3, 11);
                        revive = rnd.Next(-25, 1);

                        switch (input)
                        {
                            case "1":
                                Console.WriteLine("{0} casted a fire spell!", player2);
                                hp1 = hp1 - fire;
                                Console.WriteLine("{0} has {1}HP left!", player1, hp1);
                                turn2 = turn2 - 1;
                                turn1 = turn1 + 1;
                                break;
                            case "2":
                                Console.WriteLine("{0} casted a blizzard spell!", player2);
                                hp1 = hp1 - blizzard;
                                Console.WriteLine("{0} has {1}HP left!", player1, hp1);
                                turn2 = turn2 - 1;
                                turn1 = turn1 + 1;
                                break;
                            case "3":
                                Console.WriteLine("{0} casted a shock spell!", player2);
                                hp1 = hp1 - shock;
                                Console.WriteLine("{0} has {1}HP left!", player1, hp1);
                                turn2 = turn2 - 1;
                                turn1 = turn1 + 1;
                                break;
                            case "4":
                                if (revive2 >= 1)
                                {
                                    Console.WriteLine("{0} casted a revive spell!", player2);
                                    hp2 = hp2 - revive;
                                    Console.WriteLine("{0} now has {1}HP left!", player2, hp2);
                                    turn2 = turn2 - 1;
                                    turn1 = turn1 + 1;
                                    revive2 = revive2 - 1;
                                }
                                else
                                {
                                    Console.WriteLine("You can't cast another revive spell on yourself! Your health will reduce with 10HP!");
                                    hp2 = hp2 - 10;
                                    turn2 = turn2 - 1;
                                    turn1 = turn1 + 1;
                                    Console.WriteLine("{0} has {1}HP left!", player2, hp2);
                                }
                                break;
                            default:
                                Console.WriteLine("Answer not valid, please press enter to try again!");
                                Console.ReadLine();
                                break;
                        }
                        if (hp1 <= 0)
                        {
                            Console.WriteLine("Congratulations {0}! You won!", player2);
                            Console.WriteLine("Press enter to exit...");
                            Console.ReadLine();
                            Environment.Exit(1);
                        }
                        if (hp2 <= 0)
                        {
                            Console.WriteLine("Congratulations {0}! You won!", player1);
                            Console.WriteLine("Press enter to exit...");
                            Console.ReadLine();
                            Environment.Exit(1);
                        }
                    }
                }
            }
        }
    }
}
