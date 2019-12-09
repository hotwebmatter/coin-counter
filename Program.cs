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

            WriteLine("{0, 14} {1:C2}", "Change given:", CHANGE);
            WriteLine("{0, 14} {1}", "Quarters:", quarters);
            WriteLine("{0, 14} {1}", "Dimes:", dimes);
            WriteLine("{0, 14} {1}", "Nickels:", nickels);
            WriteLine("{0, 14} {1}", "Pennies:", pennies);
        }
    }
}
