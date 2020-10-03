using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace high_low
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the high low game");

            while (true)
            {
                //random number generation
                Random rng = new Random();
                int number = rng.Next(1, 10);
                int tries = 0;
                while (true)
                {
                    Console.Write("Enter your guess: ");
                    int guess = Convert.ToInt32(Console.ReadLine());
                    if (guess < number)
                    {
                        Console.WriteLine("Higher");
                        tries = tries + 1;
                    }
                    else if (guess > number)
                    {
                        Console.WriteLine("Lower");
                        tries = tries + 1;
                    }
                    else
                    {
                        Console.WriteLine("you guessed the correct number");
                        tries = tries + 1;
                        Console.WriteLine("you guessed the word in " + tries + " tries");

                        Console.Write("Do you want to play again? ");
                        string again = Console.ReadLine();
                        if (again.ToLower() == "yes")
                        {
                            break;
                        }
                        else if (again.ToLower() == "no")
                        {
                            Environment.Exit(0);
                        }
                    }
                }


            }
        }
    }
}