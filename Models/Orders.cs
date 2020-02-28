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
      SetBreadPrice();
    }

    public void SetBreadPrice()
    {
      for (int i = 1; i <= BreadQuantity; i++)
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
    public Pastry(int pastryQuantity, int pastryPrice)
    {
      PastryQuantity = pastryQuantity;
      PastryPrice = pastryPrice;
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