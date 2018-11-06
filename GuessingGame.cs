using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            String name = null;
            while (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("What is your name?");
                name = Console.ReadLine();
                if (string.IsNullOrEmpty(name))
                {
                    Console.WriteLine("You didn't type anything!");
                }
                else
                {
                    break;
                }
            }
            bool playAgain = true;
            bool isNumeric = false;
            while (playAgain)
            {
                Console.WriteLine("Hey " + name + "! I'm thinking of a number between" +
                              " 1 and 20. Guess it!");
                String numberString = Console.ReadLine();
                isNumeric = int.TryParse(numberString, out int userNumber);
                if (!isNumeric)
                {
                    Console.WriteLine("That's not a number!");
                    continue;
                }
                else
                {
                    Random random = new Random();
                    int computerNumber = random.Next(1, 21);
                    if (computerNumber > userNumber)
                    {
                        Console.WriteLine("Too low! I was thinking of " + computerNumber);
                    }
                    else if (computerNumber < userNumber)
                    {
                        Console.WriteLine("Too High! I was thinking of " + computerNumber);
                    }
                    else
                    {
                        Console.WriteLine("Spot on! How'd you know?!?");
                    }
                }
                Console.WriteLine("Play again? (y/n)");
                String yesNo = Console.ReadLine();
                String lower = yesNo.ToLower();
                if (lower.Equals("n")) 
                {
                    Console.WriteLine("Thanks for playing!");
                           playAgain = false;
                }
            }
        }
    }
}
