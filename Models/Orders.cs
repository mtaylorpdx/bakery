using System;

namespace Bakery.Models
{
  public class Bread
  {
    public int BreadQuantity { get; set; }
    public int BreadPrice { get; set; }

    public Bread(int breadQuantity, int breadPrice)
    {
      BreadQuantity = breadQuantity;
      BreadPrice = breadPrice;
    }
    public void SetBreadQuantity(int number)
    {
      BreadQuantity = number;
      Console.WriteLine(BreadQuantity);
      SetBreadPrice();
    }

    public void SetBreadPrice()
    {
    if (BreadQuantity != 0)
    {
      BreadPrice = (BreadQuantity * 5);
    }
    Console.WriteLine("$" + BreadPrice);
    }
  }

  public class Pastry
  {
    public int PastryQuantity { get; set; }
    public int PastryPrice { get; set; }
    public Pastry(int pastryQuantity, int pastryPrice)
    {
      PastryQuantity = pastryQuantity;
      PastryPrice = pastryPrice;
    }
    public void SetPastryQuantity(int number)
    {
      PastryQuantity = number;
      Console.WriteLine(PastryQuantity);
      SetPastryPrice();
    }
    public void SetPastryPrice()
    {
      PastryPrice = (PastryQuantity * 2);
      Console.WriteLine("$" + PastryPrice);
    }
  }
}