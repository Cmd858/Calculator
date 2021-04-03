using System;

namespace Calculator
{
	public class Calculator
	{
		static void Main()
		{
			while (true)
			{
				Console.WriteLine("enter number");
				int.TryParse(Console.ReadLine(), out int a);
				Console.WriteLine("enter operation");
				string op = Console.ReadLine();
				Console.WriteLine("enter number");
				int.TryParse(Console.ReadLine(), out int b);
				switch (op)
				{
					case "+":
						Console.WriteLine($"{a + b}");
						break;
					case "-":
						Console.WriteLine($"{a - b}");
						break;
					case "*":
						Console.WriteLine($"{a * b}");
						break;
					case "/":
						Console.WriteLine($"{a / b}");
						break;
				}

			}
		}
	}
}