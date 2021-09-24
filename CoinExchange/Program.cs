using System;

namespace CoinExchange
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get Input from user
            // Convert Input to decimal (make it a variable)
            Console.Write("Enter a dollar amount: ");
            decimal input = decimal.Parse(Console.ReadLine());

            // Create and assign quarters, dimes, nickels, pennies as variables. Set to 0
            int quarters, dimes, nickels, pennies;

            // Multiply input by 100
            // input *= 100;
            decimal remainder;

            // Modulo by 25 
            remainder = input % 0.25m;
            // Assign to quarter variable
            quarters = (int) ((input - remainder) / 0.25m);
            input -= quarters * 0.25m;

            // Pass to dime section

            // Modulo by 10 
            remainder = input % 0.10m;
            // Assign to dimes variable
            dimes = (int)((input - remainder) / 0.10m);
            input -= dimes * 0.10m;

            // Pass to nickel  section

            // Modulo by 5 
            remainder = input % 0.05m;
            // Assign to nickels variable
            nickels = (int)((input - remainder) / 0.05m);
            input -= nickels * 0.05m;

            // Pass to penny section

            // Assign to penny variable
            pennies = (int) (input * 100);

            // Output quarters, dimes, nickels, pennies
            Console.WriteLine(quarters + " quarters, " + dimes + " dimes, " + nickels + " nickels, " + pennies + " pennies");
            // After MVP, pluralize words
        }
    }
}
