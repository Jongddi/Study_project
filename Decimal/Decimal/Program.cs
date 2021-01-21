using System;

namespace Decimal
{
	class MainApp
	{
		static void Main(string[] args)
		{
			float a = 3.1415_9265_3589_7932_3846_2643_3832_79f; //float는 뒤에 f, 7자리

			double b = 3.1415_9265_3589_7932_3846_2643_3832_79; //double는 숫자만, 15-16자리

			decimal c = 3.1415_9265_3589_7932_3846_2643_3832_79m; //decimal은 뒤에 m, 29자리

			double d = 3.141592653589793238462643383279;

			Console.WriteLine(a);
			Console.WriteLine(b);
			Console.WriteLine(c);
			Console.WriteLine(d);

		}
	}
}
