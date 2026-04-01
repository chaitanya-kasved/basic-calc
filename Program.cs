// Basic Calculator (Including What I Have Learned.)
using System;
namespace Program
{
	class Calc
	{
		static void Main(string[] args)
		{
			Console.Write("Enter The Number : ");
			double x = Convert.ToDouble(Console.ReadLine());
			Console.Write("Enter The Number : ");
			double y = Convert.ToDouble(Console.ReadLine());

			Console.WriteLine(x + " + " + y + " = " + (x + y));
			Console.WriteLine(x + " - " + y + " = " + (x - y));
			Console.WriteLine(x + " * " + y + " = " + (x * y));
			Console.WriteLine(x + " / " + y + " = " + (x / y));
			
		}
	}
}
