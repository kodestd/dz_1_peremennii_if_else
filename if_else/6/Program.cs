public class Program
{
    public static void Main()
    {
        bool hasTicket = true;
        bool blackList = false;
        if (hasTicket == true && blackList == false)
        {
            Console.WriteLine("Проход Разрешен");
        }
        else
        {
            Console.WriteLine("Проход Запрещен");
        }
    }
}