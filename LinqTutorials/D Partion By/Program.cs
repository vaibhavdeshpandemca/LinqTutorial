using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTutorials.D_Partion_By
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    var emplist = Employee.GetAllEmployees();

        //    var empGroup = from emp in emplist
        //                   group emp by emp.Department into eGroup
        //                   from e in eGroup
        //                   select new
        //                   {
        //                       Employees = e,
        //                       EmpCountByDept = eGroup.Sum(x => x.ID)
        //                   };
        //    Console.WriteLine();


        //    Console.WriteLine(string.Join("\n",empGroup.Select(x => new { x.Employees.ID, x.Employees.Name, x.Employees.Salary, x.Employees.Department, x.EmpCountByDept })));
        //    //foreach (var emp in empGroup)
        //    //{
        //    //    Console.WriteLine($"{emp.Employees.Name} {emp.Employees.Salary} {emp.EmpCountByDept}");
        //    //}

        //    //from e in egroup
        //    //select new
        //    //{
        //    //  DeptCount = e.,
        //    //  e.ID,
        //    //  e.Name,
        //    //  e.Salary,
        //    //  e.Department
        //    //};


        //    //foreach (var emp in empGroup)
        //    //{
        //    //    //Func<Employee, bool> funk = x => x.Department == "IT";
        //    //    //Func<Employee, bool> funk2 = x => x.ID != 0;
        //    //    //Func<Employee, decimal> funck3 = x => DeptITSalary(x);
        //    //    //Console.WriteLine(emp.Key + " \t" + emp.Count(x => funk(x)));
        //    //    //Console.WriteLine(emp.Key + " Count of ID \t" + emp.Count(x => x.ID > 0));
        //    //    //Console.WriteLine(emp.Key + " Salary sum \t" + (emp.Sum(funck3)));


        //    //    Console.WriteLine(); Console.WriteLine();
        //    //    foreach (var e in emp)
        //    //    {
        //    //        Console.WriteLine($"{e.Name}  {e.Department}  {e.Salary} {emp.Count()}");
        //    //    }
        //    //}


        //    Console.ReadLine();
        //    }

        private static decimal DeptITSalary(Employee x)
        {
            return x.Department == "IT" ? x.Salary : 0; 
        }

        private static bool isCounted(Employee e)
        {
            return e.Department == "IT";
        }
    }
   


}
