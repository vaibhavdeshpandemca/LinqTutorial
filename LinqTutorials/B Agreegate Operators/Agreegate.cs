using System;
using System.Linq;

namespace LinqTutorials.B_Agreegate_Operators
{
    class Agreegate
    {
        //static void Main(string[] args)
        //{
        //    var numbers = Enumerable.Range(1, 10);
        //    Console.Write("Numbers :");
        //    foreach (var number in numbers)
        //    {
        //        Console.Write($" {number}");
        //    }
        //    Console.WriteLine("\n");
        //    var minNumber = numbers.Min();
        //    Console.WriteLine($"Min Numbers is {minNumber}");
        //    var maxNumber = numbers.Max();
        //    Console.WriteLine($"Max Numbers is {maxNumber}");
        //    var maxdivisiableby2 = numbers.Where(x => x % 2 == 0).Max();
        //    Console.WriteLine($"Max Numbers divisible by 0 is {maxdivisiableby2}");
        //    var sumOfNums = numbers.Sum();
        //    Console.WriteLine($"Sum of Numbers {sumOfNums}");
        //    var countOfNums = numbers.Count();
        //    Console.WriteLine($"Count of Numbers {countOfNums}");
        //    var avgOfNums = numbers.Where(x => x % 2 == 0).Average();
        //    Console.WriteLine($"Average of Numbers {avgOfNums}");

        //    string[] countries = { "India", "USA", "UK" };

        //    Console.WriteLine();
        //    foreach (var country in countries)
        //    {
        //        Console.Write($"{country} ");
        //    }
        //    Console.WriteLine();
        //    int minLength = countries.Min(x => x.Length);
        //    string countryName = countries.Where(x => x.Length == minLength).FirstOrDefault();
        //    Console.WriteLine($"Min length country is {countryName} with lenght {minLength}");

        //    //Agreegate Function
        //    Console.WriteLine("\nAggregate method example");
        //    var aggrStrings = countries.Aggregate((a, b) => $"{a}, {b}");
        //    //var result = Enumerable.Aggregate(countries, (a, b) => $"{a}, {b}");
        //    Console.WriteLine(aggrStrings);

        //    var numMult = numbers.Aggregate(10, (a, b) => a * b);
        //    Console.WriteLine("\nNumbers multiplication using agreegate function is "+numMult);
        //    Console.ReadLine();
        //}
    }
}
