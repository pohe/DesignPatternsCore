// See https://aka.ms/new-console-template for more information
using DependencyInjectionV2;

Console.WriteLine("Hello, World!");


bool myMethod(int i)
{
    return i > 12 && i <= 35;
}


Filter f = new Filter();
List<int> someValues = new List<int>() { 1, 15, 27, 3 };
List<int> filteredValues = f.FilterValues(someValues, v => v > 10);
filteredValues = f.FilterValues(someValues, myMethod);

foreach (var v in filteredValues)
{
    Console.WriteLine(v);
}
Console.ReadLine();
