public class Program 
{
    public static void Main()
    {
        int temperature = 16;
        bool isHome = true;
        if (!isHome)
        {
            Console.WriteLine("Выключить отопление");
        }
        else if (temperature < 18)
        {
            Console.WriteLine("Включить отопление");
        }
        else if (temperature > 22)
        {
            Console.WriteLine("Выключить отопление");
        }
        else
        {
            Console.WriteLine("Оставить текущий режим");
        }
    }
}