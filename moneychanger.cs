using System;

namespace MoneyMaker
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to money changer program!");
            // Asking for converting amount
            Console.WriteLine("What is the amount you want to convert?");
            string amount = Console.ReadLine();
            // Convert string to a number
            double total = Convert.ToDouble(amount);
            Console.WriteLine($"{total} cents is equal to ...");
            // Value of two types of coins
            int goldValue = 10;
            int silverValue = 5;
            // Calculate the change
            double goldCoins = Math.Floor(total / goldValue);
            double remainder = total % goldValue;
            double silverCoins = Math.Floor(remainder / silverValue);
            remainder = remainder % silverValue;
            // Printing the results
            Console.WriteLine($"Gold coins: {goldCoins}");
            Console.WriteLine($"Silver coins: {silverCoins}");
            Console.WriteLine($"Brozne coins: {remainder}");
        }
    }
}
