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
    public void ClearBreadOrder()
    {
      BreadQuantity = 0;
      RyeQuantity = 0;
      BreadPrice = 0;
    }
  }
}