using System;
using Bakery.Models;

namespace Bakery
{
    class Program
    {
        static void Main()
        {
        Pastry pastryOrder = new Pastry();
        Bread breadOrder = new Bread();

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
        breadOrder.SetBreadQuantity(breadCount);
        
        Console.Write("Enter the number of pastries: ");
        string pastryCountString = Console.ReadLine();
        int pastryCount = int.Parse(pastryCountString);
        pastryOrder.SetPastryQuantity(pastryCount);
        
        Console.WriteLine(breadCount + " " + pastryCount);
        }
    }
}
