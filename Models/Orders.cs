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
  }

  public class Pastry
  {
    public int PastryQuantity { get; set; }
    public Pastry()
    {
      PastryQuantity = 0;
    }
  }
}