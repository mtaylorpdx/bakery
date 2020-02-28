﻿using System;
using Bakery.Models;

namespace Bakery
{
  class Program
  {
    static void Main()
    {
    Pastry pastryOrder = new Pastry(0, 0);
    Bread breadOrder = new Bread(0, 0);

    Console.WriteLine(@"

                  Welcome to Pierre's!

    ##################################################
    #     Bread Loaves $5        Pastries $2 each    #
    #     Buy 2 Get 1 Free          or 3 for $5      #
    ##################################################
    ");

    Console.Write("Enter the number of loaves: ");
    string breadCountString = Console.ReadLine();

    Console.Write("Enter the number of pastries: ");
    string pastryCountString = Console.ReadLine();

    breadOrder.SetBreadQuantity(int.Parse(breadCountString));
    pastryOrder.SetPastryQuantity(int.Parse(pastryCountString));
    }
  }
}
