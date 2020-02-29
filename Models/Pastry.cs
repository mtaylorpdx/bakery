namespace Bakery.Models
{
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
    public void ClearPastryOrder()
    {
      PastryQuantity = 0;
      PastryPrice = 0;
    }
  }
}