using System;

namespace Samples{
	public class TestDateTimeExtensions
	{
	public static void Main(string[] args)
	{
		DateTime d1 = DateTime.Now;
		DateTime d2 = new DateTime(1996,02,01);
		DateTime d3 = new DateTime(2013,02,08);

		DateTime lastDayOfD1 = d1.LastDay();
		DateTime lastDayOfD2 = d2.LastDay();
		DateTime lastDayOfD3 = d3.LastDay();
		Console.WriteLine(Environment.NewLine);

		Console.WriteLine("Last Day.....");

		Console.WriteLine("Last day of {0} is {1}",d1,
				lastDayOfD1);
		Console.WriteLine("Last day of {0} is {1}",d2,
				lastDayOfD2);
		Console.WriteLine("Last day of {0} is {1}",d3,
				lastDayOfD3);

		Console.WriteLine(Environment.NewLine);

		Console.WriteLine("After...");

		Console.WriteLine("{0} is later than {1}: {2}",d1,d2,d1.After(d2));
		Console.WriteLine("{0} is later than {1}: {2}",d2,d3,d2.After(d3));
		Console.WriteLine("{0} is later than {1}: {2}",d3,d2,d3.After(d2));
		Console.WriteLine(Environment.NewLine);

	}
	}
}
