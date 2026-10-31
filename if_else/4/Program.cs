public class Program 
{
	public static void Main()
	{
		int score = 95;
		if (score >= 90)
		{
			Console.WriteLine(5);
		}
		else if (score >= 75 && score <= 89)
		{
			Console.WriteLine(4);
		}
		else if (score >= 60 && score <= 75)
		{
			Console.WriteLine(3);
		}
		else if (score < 60)
		{
			Console.WriteLine(2);
		}
	}
}