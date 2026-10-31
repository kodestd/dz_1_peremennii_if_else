public class Program 
{
    public static void Main()
    {
        decimal priceOfOrder = 1500m;
        decimal discount;
        if (priceOfOrder >= 5000)
        {
            discount = 0.10m;
        }
        else if (priceOfOrder >= 1000)
        {
            discount = 0.05m;
        }
        else
        {
            discount = 0m;
        }
        decimal itog = priceOfOrder - (priceOfOrder * discount);
        Console.WriteLine($"Итоговая стоимость: {itog}");
    }
}