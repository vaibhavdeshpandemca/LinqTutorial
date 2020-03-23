using LinqTutorials.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTutorials
{
    class ConversionOperators
    {
        //public static void Main(string[] args)
        //{
            // List
            //int[] numbers = { 1, 2, 3, 4, 5, 6 };

            //List<int> result = numbers.ToList();

            //foreach (int num in result)
            //{
            //    Console.WriteLine(num);
            //}

            // Array

            // SQL Like query wih order by
            //List<string> countries = new List<string> { "US", "India", "UK", "Australia", "Canada" };

            //string[] result = (from country in countries
            //                   orderby country ascending
            //                   select country).ToArray();

            //// Linq with order by
            //// string[] result = countries.OrderByDescending(x => x).ToArray();

            //foreach (string res in result)
            //{
            //    Console.WriteLine(res);
            //}

            // Dictonary  this is key value pair collection where duplicate key is not allowed

            //List<Student1> student1s = Student1.GetAllStudetns();
            //Dictionary<int, string> result = student1s.ToDictionary(d => d.StudentID, d => d.Name);

            //foreach (KeyValuePair<int, string> kvp in result)
            //{
            //    Console.WriteLine(kvp.Key + "\t" + kvp.Value);
            //}

            // Dictionary with Student Object

            //List<Student1> student1s = Student1.GetAllStudetns();
            //Dictionary<int, Student1> result = student1s.ToDictionary(d => d.StudentID, d => d);

            //foreach (KeyValuePair<int, Student1> kvp in result)
            //{
            //    Console.WriteLine(kvp.Key + "\t" + kvp.Value.Name + "\t" + kvp.Value.TotalMarks);
            //}

            // Lookup is like dictionary but duplicated key is allowed.
            //List<Employee1> listEmployees = Employee1.GetAllEmployees();

            //var employeeByJobTitle = listEmployees.ToLookup(d => d.JobTitle);
            //Console.WriteLine("\n****************************************************");
            //Console.WriteLine("Employes groupded by JobTitle");
            //Console.WriteLine("****************************************************\n");


            //foreach (var kvp in employeeByJobTitle)
            //{

            //    Console.WriteLine(kvp.Key);
            //    Console.WriteLine("-----------------");
            //    foreach (var employee in employeeByJobTitle[kvp.Key])
            //    {
            //        Console.WriteLine(employee.Name + "\t" + employee.City + "\t" + employee.JobTitle);
            //    }
            //    Console.WriteLine("\n");
            //}

            //List<Employee1> listEmployees2 = Employee1.GetAllEmployees();

            //var employeeByCity = listEmployees.ToLookup(d => d.City);
            //Console.WriteLine("\n****************************************************");
            //Console.WriteLine("Employes groupded by City");
            //Console.WriteLine("****************************************************\n");
            //foreach (var kvp in employeeByCity)
            //{

            //    Console.WriteLine(kvp.Key);
            //    Console.WriteLine("-----------------");
            //    foreach (var employee in employeeByCity[kvp.Key])
            //    {
            //        Console.WriteLine(employee.Name + "\t" + employee.City + "\t" + employee.JobTitle);
            //    }
            //    Console.WriteLine("\n");
            //}

       // }
    }
}
