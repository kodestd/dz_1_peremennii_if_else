public class Program 
{
    public static void Main()
    {
        int battery = 15;
        bool hasConnection = false;
        bool isOverheated = true;

        if (isOverheated)
        {
            Console.WriteLine("Авария");
        }
        else if (!hasConnection)
        {
            Console.WriteLine("Нет связи");
        }
        else if (battery < 20)
        {
            Console.WriteLine("Заряд критический");
        }
        else
        {
            Console.WriteLine("Работа разрешена");
        }
    }
}