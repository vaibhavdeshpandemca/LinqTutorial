using LinqTutorials.C_Restriction_Operators.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqTutorials.C_Restriction_Operators
{
    class RestrictionOperators
    {
        //static void Main(string[] args)
        //{

        //    var numbers = Enumerable.Range(1, 10);
        //    Display(numbers);
        //    //Func<int, bool> evenNum = x => x % 2 == 0;
        //    //var evenNumbers = numbers.Where(x => isEven(x));

        //    var evenNumbers = from nums in numbers
        //                      where nums % 2 == 0
        //                      select nums;

        //    Console.WriteLine("\nEven numbers are ");

        //    Display(evenNumbers);
        //    Console.WriteLine();

        //    var evenIndex = numbers.Select((num, index) => new { Number = num, Index = index });

        //    foreach (var numInd in evenIndex)
        //    {
        //        Console.WriteLine(numInd.Index + " : " + numInd.Number);
        //    }

        //    Console.WriteLine();
        //    EmployeeDBContextNew context = new EmployeeDBContextNew();
        //    var departments = from dept in context.Departments
        //                      where dept.Name == "IT"|| dept.Name == "HR" 
        //                      select new
        //                      {
        //                        dept
        //                      };
        //      //IEnumerable<Department> departments =  context.Departments.Where(x => x.DepartmentName == "IT"|| x.DepartmentName =="HR");
        //        foreach (var dept in departments)
        //        {
        //            Console.WriteLine(dept);
        //        }

        //    Console.ReadLine();
        //}

        private static void Display(System.Collections.Generic.IEnumerable<int> numbers)
        {
            foreach (var number in numbers)
            {
                Console.Write(" " + number);
            }
            Console.WriteLine();
        }

        public static bool isEven(int num)
        {
            if (num %2==0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    
}
