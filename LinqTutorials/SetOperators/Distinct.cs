using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTutorials.SetOperators
{
    class Distinct
    {
        //static void Main(string[] args)
        //{
        //    //var countries = new List<string> { "USA", "usa", "India", "Germeny" };
        //    //var result = countries.Distinct(StringComparer.OrdinalIgnoreCase);

        //    //foreach (var country in result)
        //    //{
        //    //    Console.WriteLine(country);
        //    //}

        //    var listEmployee = new List<Employee>
        //    {
        //        new Employee{ID=1001,Name="Mike" },
        //        new Employee{ID=1002,Name="Rob" },
        //        new Employee{ID=1001,Name="Mike" },
        //    };

        //    var result = listEmployee.Distinct();

        //    foreach (var employee in result)
        //    {
        //        Console.WriteLine($"{employee.Name +" "+employee.ID}");
        //    }
        //}
    }

    
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public override bool Equals(object obj)
        {
            return ID == ((Employee)obj).ID && Name == ((Employee)obj).Name;
        }

        public override int GetHashCode()
        {
            return ID.GetHashCode() ^ Name.GetHashCode();
        }
    }
}
