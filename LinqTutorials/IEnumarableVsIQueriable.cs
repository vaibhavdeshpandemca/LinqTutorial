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
        static void Main(string[] args)
        {
            JoinsEntities2 db = new JoinsEntities2();

            var employees = (from emp in db.Employees
                         where emp.EmployeeName.Contains("Ra")
                         select emp);
            //employees = employees;

            var empResult = employees.Take(2);

            Console.WriteLine("Employee Name with Ra are "+ empResult.Count());
        }
    }
}
