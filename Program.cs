using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //Startup
            GetAppDetails();
            GetAppGreeting();

            //Game
            while (true)
            {
                Random random = new Random();

                int correctNumber = random.Next(1, 10);

                int guess = 0;

                Console.WriteLine("Guess a number between 1 and 10.");

                while (guess != correctNumber)
                {
                    string inputGuess = Console.ReadLine();
                    if (!int.TryParse(inputGuess, out guess))
                    {
                        PrintColorMessage(ConsoleColor.Red, "Please enter a number.");

                        continue;
                    }
                    guess = Int32.Parse(inputGuess);

                    if (guess != correctNumber)
                    {
                        PrintColorMessage(ConsoleColor.Red, "Wrong answer. Please try again.");
                    }
                }
                PrintColorMessage(ConsoleColor.Yellow, "CORRECT!!");

                Console.WriteLine("Do you want to play again? [Y/N]");

                string answer = Console.ReadLine().ToUpper();
                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }
            }
        }

        // Functions
        static void GetAppDetails()
        {
            string appName = "Guessing Game";
            string appVersion = "1.0";
            string appAuthor = "Craig Whitehouse";

            Console.ForegroundColor = ConsoleColor.Magenta;

            Console.WriteLine("{0}: Version {1} \n by {2}", appName, appVersion, appAuthor);

            Console.ResetColor();
        }

        static void GetAppGreeting()
        {
            Console.WriteLine("What is your name?");

            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a guessing game.", inputName);

        }

        static void PrintColorMessage(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;

            Console.WriteLine(message);

            Console.ResetColor();
        }
    }
}
