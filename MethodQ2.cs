//# 2. 
using System;
namespace methodz
{
	class Program
	{
		public int product(int numb1, int numb2)
		{
			int prod = numb1 * numb2;
			return prod;
		}
			// The Main method for the program
		public static void Main(string[] args)
		{
			Program prog = new Program();
			int answer = prog.product(69, 420); // enter parameters here
			Console.WriteLine("The product of the two numbers is "+ answer);
			Console.ReadLine();
		} // end Main
	}
}