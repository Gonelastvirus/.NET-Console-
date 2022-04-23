using System;
public class Program
{
	public int add(int x, int y)
	{
		int result = x + y;
		return result;
	}

	public static void Main(string[] args)
	{
		int x, y, s;

		Console.Write("Enter first number:");
		x = Convert.ToInt32(Console.ReadLine());

		Console.Write("Enter second number:");
		y = Convert.ToInt32(Console.ReadLine());

		Program obj = new Program();
		s = obj.add(x, y);
		Console.WriteLine("Sum is:" + s);
	}
}