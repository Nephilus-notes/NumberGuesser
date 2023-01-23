using System;
using System.Drawing;
using System.Threading.Tasks.Sources;

//Namespace
namespace NumberGuesser
{
    // Main class
    internal class Program
    {
        // Entry point method
        static void Main(string[] args)
        {
            // Run GetAppInfo function to display version name, author, and app name
            GetAppInfo();


            GreetUser();

            while (true)
            {

                // Create a new random object
                Random random = new Random();

                int correctNumber = random.Next(1, 10);

                // Init guess var
                int guess = 0;

                // Ask user for number
                Console.WriteLine("Guess a number between 1 and 10:");

                while (guess != correctNumber)
                {
                    // Get users input
                    string input = Console.ReadLine();

                    // Make sure it's a number
                    if (!int.TryParse(input, out guess))
                    {

                        // print error message
                        MessageInColor(ConsoleColor.Red, "Try a real number");
                        // Keep Going
                        continue;
                    }

                    // Cast to int and put in guess
                    guess = Int32.Parse(input);

                    if (guess != correctNumber)
                    {
                        MessageInColor(ConsoleColor.Red, "Wrongo!");
                    }
                }

                // Output success message
                MessageInColor(ConsoleColor.Yellow, "Correct!!");

                // Ask to play again
                Console.WriteLine("Play Again? [Y or N]");

                // Get Answer
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

                }
            }
        }


        static void GetAppInfo() // Display app name, version info, and author
        {
            // Set App vars

            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Charles McCall";

            // Change text color
            Console.ForegroundColor = ConsoleColor.Green;

            // Write App info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            // Reset text color
            Console.ResetColor();
        }

        
        static void GreetUser() // Get username and greet
        {
            Console.WriteLine("What is your name?");

            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game!", inputName);
        }
        // Print message of color

        static void MessageInColor(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;

            // Display failed guess
            Console.WriteLine(message);

            // Reset text color
            Console.ResetColor();
        }
    }
}