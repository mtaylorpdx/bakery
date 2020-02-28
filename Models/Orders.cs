using System;

namespace Bakery.Models
{
  public class Bread
  {
    public int BreadQuantity { get; set; }

    public Bread()
    {
      BreadQuantity = 0;
    }
    public void SetBreadQuantity(int number)
    {
      BreadQuantity = number;
    }
  }

  public class Pastry
  {
    public int PastryQuantity { get; set; }
    public Pastry()
    {
      PastryQuantity = 0;
    }
    public void SetPastryQuantity(int number)
    {
      PastryQuantity = number;
    }
  }
}