public class Program 
{
	public static void Main()
	{
		int parts = 29;
		int partsInBox = 6;
		Console.WriteLine($"Полных коробок: {parts / partsInBox}");
		Console.WriteLine($"Остаток: {parts % partsInBox}");
	}
}