using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTutorials.Model.OrderingOperators
{
    public class Employee
    {
        public string Name { get; set; }
        public string JobTitle { get; set; }
        public string City { get; set; }

        public static List<Employee> GetAllEmployees()
        {
            List<Employee> listEmployees = new List<Employee>
            {
                new Employee() { Name = "Ben", JobTitle = "Developer", City = "London" },
                new Employee() { Name = "John", JobTitle = "Sr. Developer", City = "Bangalore" },
                new Employee() { Name = "Steve", JobTitle = "Developer", City = "Bangalore" },
                new Employee() { Name = "Stuart", JobTitle = "Sr. Developer", City = "London" },
                new Employee() { Name = "Sara", JobTitle = "Developer", City = "London" },
                new Employee() { Name = "Pam", JobTitle = "Developer", City = "London" },
                new Employee() {Name="Aditya", JobTitle="Jr. Developer", City="Pune"},
                new Employee() {Name="Anurag", JobTitle="Manager", City="Mumbai"}
            };
            return listEmployees;
        }
    }

    
}
