// See https://aka.ms/new-console-template for more information
int[] numbers = { 1, 2, 3, 4, 5, 6 };
float[] percent = { 1.2f, 2.3f, 22.6f, 50.7f, 0.85f };
string[] Colours = { "Red", "Blue", "Pink", "Orange" };

GenericsTestMaximum.MaximumValue<int> maxint = new GenericsTestMaximum.MaximumValue<int>(numbers);
Console.WriteLine(maxint.MaxValue());
GenericsTestMaximum.MaximumValue<float> maxFloat = new GenericsTestMaximum.MaximumValue<float>(percent);
Console.WriteLine(maxFloat.MaxValue());
GenericsTestMaximum.MaximumValue<string> maxString = new GenericsTestMaximum.MaximumValue<string>(Colours);
Console.WriteLine(maxString.MaxValue());