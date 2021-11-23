//# 1.
using System;
namespace methodz
{
	class Program
	{
		static void PrintString()
		{
			Console.WriteLine("This method has a 'return type void' and 'No parameters' ");
		}
		// The Main method for the program
		static void Main(string[] args)
		{
			/* Calling the method */
			// Write the method here
			PrintString();
			Console.ReadLine(); // What's the purpose of this line? To halt the program until any key is pressed which will then terminate the program.
		} // end Main
	}
}