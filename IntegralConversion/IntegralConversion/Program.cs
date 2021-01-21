using System;

namespace IntegralConversion
{
	class Program
	{
		static void Main(string[] args)
		{
			sbyte a = 127;
			Console.WriteLine(a);

			int b = (int)a;
			Console.WriteLine(b);

			int x = 128; //sbyte 최대값 보다 1 큰 수
			Console.WriteLine(x);

			sbyte y = (sbyte)x;
			Console.WriteLine(y);
		}
	}
}
