using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTutorials
{
    class IEnumarableVsIQueriable
    {
        //static void Main(string[] args)
        //{
        //    JoinsEntities2 db = new JoinsEntities2();
        //    var list = new List<string> { "pam", "john" };
        //    var employees = (from emp in db.Employees
        //                     where list.Contains(emp.EmployeeName)
        //                     select new
        //                     {
        //                         Name = emp.EmployeeName,
        //                         ID = emp.EmployeeID,
        //                         TodayDate = DateTime.Now
        //                     });
        //    //employees = employees;

        //    employees = employees.Take(2);

        //    employees = employees.OrderBy(x => x.Name);


        //    Console.WriteLine("Employee Name with Ra are " + employees.Count());

        //    //foreach (var emp in employees)
        //    //{
        //    //    Console.WriteLine($"Name {emp.Name} Emp Id {emp.ID}");
        //    //}
        //}
    }
}
