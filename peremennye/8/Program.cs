public class Program 
{
    public static void Main()
    {
        int bolts = 137;
        int robots = 8;
        int robotReceived = bolts / robots;
        int allRobotReceived = bolts - (bolts % robots);
        double reserve = bolts % robots;
        Console.WriteLine($"Получил робот: {robotReceived}");
        Console.WriteLine($"Получили все роботы: {allRobotReceived}");
        Console.WriteLine($"В резерве: {reserve}");
    }
}