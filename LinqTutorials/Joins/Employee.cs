using System.Collections.Generic;

namespace LinqTutorials.Joins
{
    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int DepartmentID { get; set; }
        public static List<Employee> GetAllEmployees()
        {
            return new List<Employee>()
        {
            new Employee { ID = 1, Name = "Mark", DepartmentID = 1 },
            new Employee { ID = 2, Name = "Steve", DepartmentID = 2 },
            new Employee { ID = 3, Name = "Ben", DepartmentID = 1 },
            new Employee { ID = 4, Name = "Philip", DepartmentID = 1 },
            new Employee { ID = 5, Name = "Mary" }
        };
        }
    }
    public class Department
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public static List<Department> GetAllDepartments()
        {
            return new List<Department>()
        {
            new Department { ID = 1, Name = "IT"},
            new Department { ID = 2, Name = "HR"},
            new Department { ID = 3, Name = "Accounts"},
        };
        }
    }
}
