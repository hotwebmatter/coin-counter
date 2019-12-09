using System;
using static System.Console;

namespace coin_counter
{
    class Program
    {
        static void Main(string[] args)
        {
            const int CHANGE = 92;
            int changeRemaining,
                quarters,
                dimes,
                nickels,
                pennies;
            // implement classic change-making algorithm

            changeRemaining = CHANGE;
            quarters = changeRemaining / 25;
            changeRemaining %= 25;
            dimes = changeRemaining / 10;
            changeRemaining %= 10;
            nickels = changeRemaining / 5;
            changeRemaining %= 5;
            pennies = changeRemaining;

            WriteLine("Original change amount: {0:C2}", CHANGE);
            WriteLine("Amount of quarters: {0}", quarters);
            WriteLine("Amount of dimes: {0}", dimes);
            WriteLine("Amount of nickels: {0}", nickels);
            WriteLine("Amount of pennies: {0}", pennies);
        }
    }
}
