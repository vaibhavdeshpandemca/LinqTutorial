using LinqTutorials.Model;
using System;
using System.Linq;

namespace LinqTutorials
{
    class GroupByMultipleKeys
    {
        //static void Main(string[] args)
        //{
        //    //var employeeGroup = from employee in Employee2.GetAllEmployees()
        //    //                    group employee by new { employee.Department, employee.Gender } into eGroup
        //    //                    orderby eGroup.Key.Department, eGroup.Key.Gender
        //    //                    select new
        //    //                    {
        //    //                        Dept = eGroup.Key.Department,
        //    //                        eGroup.Key.Gender,
        //    //                        Employees = eGroup.OrderBy(d => d.Name)
        //    //                    };

        //    var employeeGroup = Employee2.GetAllEmployees()
        //                        .GroupBy(x => new { x.Department, x.Gender })
        //                        .OrderBy(x => x.Key.Department).ThenBy(x => x.Key.Gender)
        //                        .Select(g => new
        //                        {
        //                            Dept = g.Key.Department,
        //                            g.Key.Gender,
        //                            Employees = g.OrderBy(d => d.Name)
        //                        });



        //    foreach (var group in employeeGroup)
        //    {
        //        Console.WriteLine(group.Dept + "\t" + group.Gender + "\t" + group.Employees.Count());
        //        Console.WriteLine("-----------------------------------------");
        //        foreach (var employee in group.Employees)
        //        {
        //            Console.WriteLine(employee.Name + "\t" + employee.Gender + "\t" + employee.Department);
        //        }
        //        Console.WriteLine("\n");
        //    }

        //}
    }
}
