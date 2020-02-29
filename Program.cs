using System;
using Bakery.Models;

namespace Bakery
{
  class Program
  {
    public static void Main()
    {
      Bread breadOrder = new Bread();
      Pastry pastryOrder = new Pastry();
      LoadScreen();
      bool checkout = false;
      while (checkout == false)
      {
        bool menuInput = Menu(breadOrder, pastryOrder);
        if (menuInput == true)
        {
          checkout = true;
        }
      }
    }
      
    public static void LoadScreen()
    {
      Console.Clear();
      Console.WriteLine(@"

      ##################################################

                      Welcome to Pierre's!
                  'Stop and Smell the Flours'

      ##################################################
      #     Bread Loaves $5        Pastries $2 each    #
      #     Buy 2 Get 1 Free          or 3 for $5      #
      ##################################################
      ");
    }

    public static bool Menu(Bread breadOrder, Pastry pastryOrder)
    {
      Console.WriteLine(@"  
      Enter 'B' for standard loaves, 'R' for rye, 'P' for pastry
       Build your order as you go! Or 'C' to checkout
          Made a mistake? Enter 'Q' to start over
          ");
      Console.WriteLine($"    Current order: Standard Loaves - {breadOrder.BreadQuantity}  Rye Loaves - {breadOrder.RyeQuantity}  Pastries - {pastryOrder.PastryQuantity}");
      Console.WriteLine("");
      Console.ResetColor();
      string userResponseInput = Console.ReadLine();
      string response = userResponseInput.ToLower();
      if (response == "b")
      {
        Console.Write("Enter the number of loaves: ");
        string breadCountString = Console.ReadLine();
        if (NumberCheck(breadCountString))
        {
          breadOrder.SetBreadQuantity(int.Parse(breadCountString));
        }
        return false;
      }
      else if (response == "r")
      {
        Console.Write("Enter the number of rye loaves: ");
        string ryeCountString = Console.ReadLine();
        if (NumberCheck(ryeCountString))
        {
          breadOrder.SetRyeQuantity(int.Parse(ryeCountString));
        }
        return false;
      }
      else if (response == "p")
      {
        Console.Write("Enter the number of pastries: ");
        string pastryCountString = Console.ReadLine();
        if (NumberCheck(pastryCountString))
        {
          pastryOrder.SetPastryQuantity(int.Parse(pastryCountString));
        }
        return false;
      }
      else if (response == "q")
      {
        breadOrder.ClearBreadOrder();
        pastryOrder.ClearPastryOrder();
      }
      else if (response == "c")
      {
        breadOrder.SetBreadPrice();
        int breadQuantity = breadOrder.BreadQuantity;
        int ryeQuantity = breadOrder.RyeQuantity;
        int pastryQuantity = pastryOrder.PastryQuantity;
        int breadTotal = breadOrder.BreadPriceTotal();
        int pastryTotal = pastryOrder.PastryPriceTotal(); 

        Console.WriteLine($@"
              Your total order comes to:
                Loaves: {breadQuantity} standard and {ryeQuantity} rye for ${breadTotal}
                Pastries: {pastryQuantity} for ${pastryTotal}
                Total comes to: ${breadTotal + pastryTotal}
                ");
          return true;
        }
        return false;
      }

    public static bool NumberCheck(string inputQuantity)
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