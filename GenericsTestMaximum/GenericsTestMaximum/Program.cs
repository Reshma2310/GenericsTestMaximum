// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
GenericsTestMaximum.MaximumValue<int> max = new GenericsTestMaximum.MaximumValue<int>(10, 6, 8);
Console.WriteLine(max.MaxValue());
GenericsTestMaximum.MaximumValue<string> maximum = new GenericsTestMaximum.MaximumValue<string>("Apple", "Banana", "Peach");
Console.WriteLine(maximum.MaxValue());
