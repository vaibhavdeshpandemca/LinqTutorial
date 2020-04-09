using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTutorials.Joins
{
    class LeftJoin
    {
        //static void Main(string[] args)
        //{
        //    try
        //    {
        //        var leftJoinResult = from emp in Employee.GetAllEmployees()
        //                             join dept in Department.GetAllDepartments()
        //                             on emp.DepartmentID equals dept.ID into eGroup
        //                             from d in eGroup
        //                             select new
        //                             {
        //                                 emp,
        //                                 d = d ?? new Department { Name = "Null" }
        //                             };
        //        foreach (var result in leftJoinResult)
        //        {
        //            Console.WriteLine($"{result.emp.Name} \t {result.d.Name} ");
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }
        //}
    }
}
