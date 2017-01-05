using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercise
{
    class Program
    {
        class Comp
        {
            public Comp() { }
            public int Compare(int a, int b)
            {
                //Rock = 1, Paper = 2, Scissors = 3
                if (b == a + 1 || b == a - 2) //B Wins
                    return 1;
                if (a == b)
                    return 3; //Draw
                else
                    return 2; //B Loses
            }

            public int Choose()
            {
                Random rnd = new Random();
                return rnd.Next(1, 3);
            }
        }

        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Rock, Paper, Scissors!");
                Console.WriteLine("Rock = 1, Paper = 2, Scissors = 3");

                int choice = Convert.ToInt32(Console.ReadLine());
                Comp comp = new Comp();
                int compchoice = comp.Choose();

                if (choice <= 3 && choice >= 0)
                {
                    Console.Write("You chose ");
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Rock.");
                            break;
                        case 2:
                            Console.WriteLine("Paper.");
                            break;
                        case 3:
                            Console.WriteLine("Scissors.");
                            break;
                        default:
                            break;
                    }

                    Console.Write("CPU chose ");
                    switch (compchoice)
                    {
                        case 1:
                            Console.WriteLine("Rock.");
                            break;
                        case 2:
                            Console.WriteLine("Paper.");
                            break;
                        case 3:
                            Console.WriteLine("Scissors.");
                            break;
                        default:
                            break;
                    }

                    switch (comp.Compare(compchoice, choice))
                    {
                        case 1:
                            Console.WriteLine("You won!");
                            break;
                        case 2:
                            Console.WriteLine("You lost!");
                            break;
                        case 3:
                            Console.WriteLine("It's a tie!");
                            break;
                        default:
                            break;
                    }
                }
                else
                    Console.WriteLine("Invalid choice!");

                Console.WriteLine("Play again?");



                char choice2;

                choice2 = Convert.ToChar(Console.ReadLine());

                if (choice2 == 'y' || choice2 == 'Y')
                { }
                else
                    break;
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
