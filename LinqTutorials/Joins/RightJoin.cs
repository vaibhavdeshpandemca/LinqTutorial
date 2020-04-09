using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTutorials.Joins
{
    class RightJoin
    {
        //static void Main(string[] args)
        //{
        //    var rightJoinResult = from dept in Department.GetAllDepartments()
        //                          join emp in Employee.GetAllEmployees()
        //                          on dept.ID equals emp.DepartmentID into eGroup
        //                          from e in eGroup
        //                          select new
        //                          {
        //                              dept,
        //                              e = e ?? new Employee { Name = "Null"}
        //                          };

        //    foreach (var result in rightJoinResult)
        //    {
        //        Console.WriteLine($"{result.e.Name} \t {result.dept.Name} ");
        //    }

       // }
    }
}
