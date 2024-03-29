﻿/**
 * ######################################################
 * ##    Chapter 2, Programming Exercise #4            ##
 * ##    Developer: Matthew Obert                      ##
 * ##    Date Submitted: December 9 2019               ##
 * ##    Purpose: Width & numeric format specifiers    ##
 * ######################################################
 */
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

            WriteLine("{0, 14} {1:C2}", "Change given:", CHANGE / (double)100);
            WriteLine("{0, 14} {1}", "Quarters:", quarters);
            WriteLine("{0, 14} {1}", "Dimes:", dimes);
            WriteLine("{0, 14} {1}", "Nickels:", nickels);
            WriteLine("{0, 14} {1}", "Pennies:", pennies);
        }
    }
}
