using System;

namespace StringNumberConversion
{
	class Program
	{
		static void Main(string[] args)
		{
			int a = 123;
			string b = a.ToString();
			Console.WriteLine(b);

			float c = 3.14f;
			string d = c.ToString();
			Console.WriteLine(d);

			string e = "123456";
			int f = int.Parse(e);
			int x = Convert.ToInt32(e);
			Console.WriteLine(f);
			Console.WriteLine(x);

			string g = "1.2345";
			float h = float.Parse(g);
			Console.WriteLine(h);
		}
	}
}
