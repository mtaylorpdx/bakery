using System;
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
    if (NumberCheck(breadCountString))
    {
      breadOrder.SetBreadQuantity(int.Parse(breadCountString));
    }

    Console.Write("Enter the number of pastries: ");
    string pastryCountString = Console.ReadLine();
    if (NumberCheck(pastryCountString))
    {
      pastryOrder.SetPastryQuantity(int.Parse(pastryCountString));
    }

    int breadTotal = breadOrder.BreadPriceTotal();
    int pastryTotal = pastryOrder.PastryPriceTotal();

    Console.WriteLine($@"
          Your total order comes to:
            {breadCountString} loaves: ${breadTotal}
            {pastryCountString} pastries: ${pastryTotal}
            Total: ${breadTotal + pastryTotal}
            ");
    }
    static bool NumberCheck(string inputQuantity)
    {
      bool success = int.TryParse(inputQuantity, out _);
      if(success)
      {
        return true;
      }
      else 
      {
        return false;
      }
    }
  }
}