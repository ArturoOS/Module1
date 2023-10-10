using System;

namespace HelloCore
{
	class Hello
	{
		static void Main(string[] args)
		{
			Console.WriteLine("MODULE 1: .NET FUNDAMENTALS");
			Console.Write("\nINPUT, USERNAME:");
			string username = Console.ReadLine();
			string output = HelloLibrary.HelloLibrary.HelloConcat(username);
			Console.WriteLine(output);
			Console.ReadLine();
		}
	}
}
