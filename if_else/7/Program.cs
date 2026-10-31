public class Program
{
    public static void Main()
    {
        bool hasRain = true;
        bool hasCold = true;
        if (hasRain == true && hasCold == true)
        {
            Console.WriteLine("Возьми куртку и зонт");
        }
        else if (hasRain == true && hasCold == false)
        {
            Console.WriteLine("Возьми зонт");
        }
        else if (hasRain == false && hasCold == true)
        {
            Console.WriteLine("Возьми куртку");
        }
        else
        {
            Console.WriteLine("Можешь ничего не брать");
        }
    }
}