using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTutorials.Model
{
    public class Employee1
    {
        public string Name { get; set; }
        public string JobTitle { get; set; }
        public string City { get; set; }

        public static List<Employee1> GetAllEmployees()
        {
            List<Employee1> listEmployees = new List<Employee1>
            {
                new Employee1() { Name = "Ben", JobTitle = "Developer", City = "London" },
                new Employee1() { Name = "John", JobTitle = "Sr. Developer", City = "Bangalore" },
                new Employee1() { Name = "Steve", JobTitle = "Developer", City = "Bangalore" },
                new Employee1() { Name = "Stuart", JobTitle = "Sr. Developer", City = "London" },
                new Employee1() { Name = "Sara", JobTitle = "Developer", City = "London" },
                new Employee1() { Name = "Pam", JobTitle = "Developer", City = "London" },
                new Employee1() {Name="Aditya", JobTitle="Jr. Developer", City="Pune"},
                new Employee1() {Name="Anurag", JobTitle="Manager", City="Mumbai"}
            };
            return listEmployees;
        }
    }

    
}
