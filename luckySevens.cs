using System;

namespace MyFirstSeeSharpThing
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            int rollCount = 0;
            int maxDollars = 0;
            int rollMax = 0;
            Console.WriteLine("Enter money you'd like to waste");
            userInput = Console.ReadLine();
            int userMoney = Convert.ToInt32(userInput);
            while (userMoney > 0)
            {
                int totalDie = RollDie();
                if (userMoney > maxDollars)
                {
                    maxDollars = userMoney;
                    rollMax = rollCount;
                }
                if (totalDie == 7)
                {
                    userMoney += 4;
                    rollCount++;
                }
                else
                {
                    userMoney -= 1;
                    rollCount++;
                }
            }
            Console.WriteLine("You went broke after " + rollCount + " rolls.");
            Console.WriteLine("You should have stopped after " + rollMax + " rolls when you had " + maxDollars + " dollars.");
        }
        public static int RollDie() 
        {
            Random random = new Random();
            int x = random.Next(1, 7);
            int y = random.Next(1, 7);
            int total = x + y;
            return total;
        }
    }
}
