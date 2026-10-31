public class Program 
{
	public static void Main()
	{
		double temperature = 15.5;
		if (temperature <= 10)
		{
			Console.WriteLine("Холодно");
		}
		else if (temperature > 10 && temperature <= 25)
		{
			Console.WriteLine("Комфортно");
		}
		else if (temperature > 25)
		{
			Console.WriteLine("Жарко");
		}
	}
}
