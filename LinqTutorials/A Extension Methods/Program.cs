using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTutorials.A_Extension_Methods
{
    class Program
    {
        //According to MSDN, Extension methods enable you to "add" methods to existing types weithout creating new derived type, 
        //recompiling or otherwise modifying the original type.

        //static void Main(string[] args)
        //{
        //    var name = "varad";
        //    var result = name.toTitleCase();
        //    //var result = StringHelper.toTitleCase(name); // Internally converts below to Wrapper class
        //    Console.WriteLine(result);

        //    var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        //    var evenNumbers = numbers.Where(x => x % 2 == 0);
        //    //var evenNumbers = Enumerable.Where(numbers, x => x % 2 == 0);  // Wrapper class style syntax

        //    foreach (var number in evenNumbers)
        //    {
        //        Console.WriteLine(number);
        //    }

        //    Console.ReadLine();
        //}
    }
}
