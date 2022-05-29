// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
GenericsTestMaximum.MaximumValue<float> max = new GenericsTestMaximum.MaximumValue<float>();
Console.WriteLine(max.MaximumOfFloat(10.8f, 6.25f, 8.06f));
GenericsTestMaximum.MaximumValue<string> maximum = new GenericsTestMaximum.MaximumValue<string>();
Console.WriteLine(maximum.MaximumOfString("Apple", "Banana", "Peach"));
