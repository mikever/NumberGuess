// Michael Veronie
// May 25, 2017
// COP2671
// This program asks the user to guess 
// the number from 1 to 100. The user has 5 tries

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuess
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a random number for the answer to be guessed
            Random random = new Random();
            int answer = random.Next(1, 100);

            int guess = 0;  // player's guess
            int tries = 0;  // Number of tries attempted

            Console.WriteLine("Guess the secret number between 1 and 100.");
            Console.WriteLine("You have 5 tries.");
            Console.WriteLine("");

            while (guess != answer && tries < 5)
            {
                tries++;
                Console.Write("Guess No. " + tries + ": ");

                // User input
                guess = Convert.ToInt32(Console.ReadLine());

                if (guess == answer)
                {
                    Console.WriteLine("Congratulations! You guessed the number!");
                }
                else
                {
                    if (tries == 5)
                    {
                        Console.WriteLine("Sorry, you have run out of attempts.");
                        Console.WriteLine("");
                    }
                    else if (guess < answer)
                    {
                        Console.WriteLine("Your guess was too low. Try again.");
                        Console.WriteLine("");
                    }
                    else
                    {
                        Console.WriteLine("Your guess was too high. Try again.");
                        Console.WriteLine("");
                    }
                }
            }
        }
    }
}
