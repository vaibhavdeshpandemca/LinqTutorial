using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTutorials.Deletages
{
    public delegate bool isPromoted(Employee employee);
    public delegate List<Employee> isPromotedList(List<Employee> employee);
    class DelegateWithLamdaExp
    {
        //static void Main(string[] args)
        //{
        //    var emplist = Employee.GetEmployees();

        //    Console.WriteLine("Employee greater than 5 years");
        //    isPromoted pro = new isPromoted(x => x.Experience > 5);
        //    Employee.PromoteEmployee(emplist, pro);
        //    Console.WriteLine();
        //    Console.WriteLine("Employee salary less than 50000");
        //    isPromoted pro2 = new isPromoted(x => x.salary < 50000);
        //    Employee.PromoteEmployee(emplist, pro2);
        //    Console.WriteLine("********All Employees*********");
        //    displayAllEmployess(emplist);
        //    Console.WriteLine("********Filter Employees*********");
        //    Predicate<Employee> empFilter = x => x.Experience > 5;

        //    var filterEmp = Employee.FilteredEmployess(emplist, empFilter);
        //    Console.WriteLine("Employee experience more than 5 years");
        //    displayAllEmployess(filterEmp);

        //    Console.WriteLine("*********Salary More than 50000**********");
        //    empFilter = x => x.salary > 50000 && x.Experience > 5;
        //    filterEmp = Employee.FilteredEmployess(emplist, empFilter);
        //    displayAllEmployess(filterEmp);

        //    Console.WriteLine("\n\n*************Salary More than 50000 using custom delegate**********");
        //    isPromotedList prom = x => x.FindAll(xp => xp.salary > 50000);
        //    var filtEmpList = prom(emplist);
        //    displayAllEmployess(filtEmpList);

            
        //}

        private static void displayAllEmployess(List<Employee> filterEmp)
        {
            foreach (var employee in filterEmp)
            {
                Console.WriteLine($"Name : {employee.Name} Experience : {employee.Experience} Salary : {employee.salary}");
            }
            Console.WriteLine();
        }

        //private static List<Employee> getEmpList()
        //{

        //}
    }

    public class Employee
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public int Experience { set; get; }
        public int salary { get; set; }
        public static void PromoteEmployee(List<Employee> emp, isPromoted isPromoted)
        {
            Console.WriteLine();
            foreach (Employee employee in emp)
            {
                //if (employee.Experience > 5)
                //{
                //    Console.WriteLine("Employee" + " " + employee.Name + " " + "Promoted");
                //}

                if (isPromoted(employee))
                {
                    Console.WriteLine(employee.Name);
                }
            }
            Console.WriteLine();
            
        }

        public static List<Employee> FilteredEmployess(List<Employee> emp, Predicate<Employee> promote)
        {
            var filterEmp = emp.FindAll(promote);
            return filterEmp;
        }

        //public static List<Employee> FilteredEmployessMyPredicate(List<Employee> emp, isPromotedEmp promote)
        //{
        //    var filterEmp = emp.FindAll(promote);
        //    return filterEmp;
        //}

        public static List<Employee> GetEmployees() {

            List<Employee> emplist = new List<Employee>();
            emplist.Add(new Employee() { Id = 1, Name = "sivakumar", Experience = 8, salary = 40000 });
            emplist.Add(new Employee() { Id = 2, Name = "Aravind", Experience = 2, salary = 100000 });
            emplist.Add(new Employee() { Id = 3, Name = "jagadeesh", Experience = 10, salary = 70000 });
            emplist.Add(new Employee() { Id = 4, Name = "subbalakshmi", Experience = 4, salary = 40000 });

            return emplist;
        }
    }
    }
