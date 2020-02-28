namespace Bakery.Models
{
  public class Bread
  {
    public int BreadQuantity { get; set; }
    public int RyeQuantity { get; set; }
    public int BreadPrice { get; set; }

    public Bread()
    {
      BreadQuantity = 0;
      RyeQuantity = 0;
      BreadPrice = 0;
    }
    public void SetBreadQuantity(int number)
    {
      BreadQuantity += number;
    }
    public void SetRyeQuantity(int number)
    {
      RyeQuantity += number;
    }

    public void SetBreadPrice()
    {
      int total = BreadQuantity + RyeQuantity;
      for (int i = 1; i <= total; i++)
      {
        if (i % 3 != 0)
        {
          BreadPrice += 5;
        }
      }
    }
    public int BreadPriceTotal()
    {
      return BreadPrice;
    }
  }

  public class Pastry
  {
    public int PastryQuantity { get; set; }
    public int PastryPrice { get; set; }
    public Pastry()
    {
      PastryQuantity = 0;
      PastryPrice = 0;
    }
    public void SetPastryQuantity(int number)
    {
      PastryQuantity = number;
      SetPastryPrice();
    }
    public void SetPastryPrice()
    {
      for (int i = 1; i <= PastryQuantity; i++)
      {
        if (i % 3 == 0)
        {
          PastryPrice += 1;
        }
        else
        {
          PastryPrice += 2;
        }
      }
    }
    public int PastryPriceTotal()
    {
      return PastryPrice;
    }
  }
}