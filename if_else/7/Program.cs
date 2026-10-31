public class Program
{
    public static void Main()
    {
        bool hasRain = true;
        bool hasCold = true;
        if (hasRain && hasCold)
        {
            Console.WriteLine("Возьми куртку и зонт");
        }
        else if (hasRain)
        {
            Console.WriteLine("Возьми зонт");
        }
        else if (hasCold)
        {
            Console.WriteLine("Возьми куртку");
        }
        else
        {
            Console.WriteLine("Можешь ничего не брать");
        }
    }
}
