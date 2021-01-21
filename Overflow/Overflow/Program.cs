using System;

namespace Overflow
{
	class MainApp
	{
		static void Main(string[] args)
		{
			uint a = uint.MaxValue;
			Console.WriteLine(a);
			a++;
			Console.WriteLine(a);

			int b = int.MaxValue;
			Console.WriteLine(b);
			b++;
			Console.WriteLine(b);
		}
	}
}