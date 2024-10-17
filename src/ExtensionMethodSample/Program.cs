using System;
using Samples.ExtensionMethodSample;

Console.Clear();
Console.WriteLine("=== Running extension method sample ===");
Console.WriteLine("Creating the dates:\n");
DateTime d1 = DateTime.Now;
DateTime d2 = new DateTime(1996,02,01);
DateTime d3 = new DateTime(2013,02,08);

Console.WriteLine("\t[ First date  ] " + d1.ToString("dd/MM/yyyy"));
Console.WriteLine("\t[ Second date ] " + d2.ToString("dd/MM/yyyy"));
Console.WriteLine("\t[ Third date  ] " + d3.ToString("dd/MM/yyyy"));
Console.WriteLine(Environment.NewLine);
Console.WriteLine("Executing extension method LastDay() \n");

Console.WriteLine($"\tLast day of {d1.ToString("dd/MM/yyyy")} is {d1.LastDay().ToString("dd/MM/yyyy")}");
Console.WriteLine($"\tLast day of {d2.ToString("dd/MM/yyyy")} is {d2.LastDay().ToString("dd/MM/yyyy")}");
Console.WriteLine($"\tLast day of {d3.ToString("dd/MM/yyyy")} is {d3.LastDay().ToString("dd/MM/yyyy")}");
Console.WriteLine(Environment.NewLine);
Console.WriteLine("Executing extension method After() \n");
Console.WriteLine($"\t{d1.ToString("dd/MM/yyyy")} is later than {d2.ToString("dd/MM/yyyy")} -> {d1.After(d2)}");
Console.WriteLine($"\t{d2.ToString("dd/MM/yyyy")} is later than {d3.ToString("dd/MM/yyyy")} -> {d2.After(d3)}");
Console.WriteLine($"\t{d3.ToString("dd/MM/yyyy")} is later than {d2.ToString("dd/MM/yyyy")} -> {d3.After(d2)}");

Console.WriteLine(Environment.NewLine);

