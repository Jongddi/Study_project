using System;

namespace FloatToIntegral
{
	class Program
	{
		static void Main(string[] args)
		{
			float a = 0.9f;
			int b = (int)a;
			Console.WriteLine(b);

			float c = 1.1f;
			int d = (int)c;
			Console.WriteLine(d);

			//실수형을 정수형으로 전환할 때에는 무조건 정수부만 가져간다
		}
	}
}
