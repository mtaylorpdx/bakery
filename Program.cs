using System;
using Bakery.Models;

namespace Bakery
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(@"

                          Welcome to Pierre's!

            ##################################################
            #     Bread Loaves $5        Pastries $2 each    #
            #   Buy 2 and Get 1 Free        or 3 for $5      #
            ##################################################
            ");
        Console.Write("Enter the number of loaves: ");
        string breadCountString = Console.ReadLine();
        int breadCount = int.Parse(breadCountString);
        Console.Write("Enter the number of pastries: ");
        string pastryCountString = Console.ReadLine();
        int pastryCount = int.Parse(pastryCountString);
        Console.WriteLine(breadCount + " " + pastryCount);
        }
    }
}
