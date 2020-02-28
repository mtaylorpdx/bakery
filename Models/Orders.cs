using System;

namespace Bakery.Models
{
  public class Bread
  {
    public int BreadQuantity { get; set; }
    public int BreadPrice { get; set; }

    public Bread()
    {
      BreadQuantity = 0;
    }
    public void SetBreadQuantity(int number)
    {
      BreadQuantity = number;
      Console.WriteLine(BreadQuantity);
      SetBreadPrice();
    }

    public void SetBreadPrice()
    {
    BreadPrice = (BreadQuantity * 5);
    Console.WriteLine("$" + BreadPrice);
    }
  }

  public class Pastry
  {
    public int PastryQuantity { get; set; }
    public int PastryPrice { get; set; }
    public Pastry()
    {
      PastryQuantity = 0;
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